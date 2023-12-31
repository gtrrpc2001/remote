﻿using System.Windows.Automation;
using System.Drawing;
using RecvRCInfoEvent;
using KMESendRecvLib;

namespace wongyeok
{
    public class Remote
    {
        static Remote singleton;//단일개체
        /// <summary>
        /// 단일 개체 - 가져오기
        /// </summary>
        public static Remote Singleton
        {
            get
            {
                return singleton;
            }
        }
        static Remote()
        {
            singleton = new Remote(); //단일 개체 생성
        }

        //원격제어 요청 메시지 수신 이벤트
        public event RecvRCInfoEventHandler RecvedRCInfo = null;

        //키보드, 마우스 메시지 수신 이벤트
        public event RecvKMEEventHandler RecvedKMEvent = null;

        RecvEventServer res = null;//키보드, 마우스 메시지 수신 서버

        /// <summary>
        /// 데스크톱 사각 영역 - 가져오기
        /// </summary>
        public Rectangle Rect
        {
            get;
            private set;
        }

        private Remote()
        {
            //최상위 자동화 요소 구하기
            AutomationElement ae = AutomationElement.RootElement;
            //사각 영역 구하기
            System.Windows.Rect rt = ae.Current.BoundingRectangle;
            // 형식 변환
            Rect = new Rectangle((int)rt.Left,
                                 (int)rt.Top,
                                 (int)rt.Width,
                                 (int)rt.Height);

            //원격제어 요청 수신 이벤트 메시지 핸들러 등록
            RecvedRCInfo += new RecvRCInfoEventHandler(SetupServer_RecvedRCInfo);
            SetupServer.Start(MyIP, NetworkInfo.SetupPort);//원격제어 요청 서버 가동
        }

        void SetupServer_RecvedRCInfo(object sender, RecvRCInfoEventArgs e)
        {
            if (RecvedRCInfo != null)//원격 제어 요청 수신 구독자가 있을 때
            {
                RecvedRCInfo(this, e);//원격 제어 요청 수신 이벤트 발생(By Pass)

            }
        }

        /// <summary>
        /// 로컬 IP 문자열 - 가져오기
        /// </summary>
        public string MyIP
        {
            get
            {
                return NetworkInfo.DefaultIP;

            }
        }

        /// <summary>
        /// 메시지 수신 서버 가동
        /// </summary>
        public void RecvEventStart()
        {
            //메시지 수신 서버 가동
            res = new RecvEventServer(MyIP, NetworkInfo.EventPort);

            //키보드, 마우스 이벤트 수신 이벤트 핸들러 등록
            res.RecvedKMEvent += new RecvKMEEventHandler(res_RecvKMEEventHandler);
        }

        void res_RecvKMEEventHandler(object sender, RecvKMEEventArgs e)
        {
            if (RecvedKMEvent != null)//메시지 수신 이벤트 핸들러가 있을 때
            {
                RecvedKMEvent(this, e);//이벤트 발생(By Pass)
            }

            //수신한 이벤트에 따라 프로그램 방식으로 이벤트 발생
            switch (e.MT)
            {
                case MsgType.MT_KDOWN: WrapNative.KeyDown(e.Key); break;
                case MsgType.MT_KEYUP: WrapNative.KeyUp(e.Key); break;
                case MsgType.MT_M_LEFTDOWN: WrapNative.LeftDown(); break;
                case MsgType.MT_M_LEFTUP: WrapNative.LeftUp(); break;
                case MsgType.MT_M_MOVE: WrapNative.Move(e.Now); break;
            }
        }


        /// <summary>
        /// 원격 제어 호스트 닫기
        /// </summary>
        public void Stop()
        {
            SetupServer.Close();//Setup 서버 닫기
            if (res != null)
            {
                res.Close();//메시지 수신 서버 닫기
                res = null;
            }
        }
    }
}
