using System.Net;
using System.Net.Sockets;

namespace wongyeok
{
    public static class NetworkInfo
    {
        /// <summary>
        /// 이미지 서버 포트 - 가져오기
        /// </summary>
        public static short ImgPort
        {
            get
            {
                return 20004;
            }
        }
        /// <summary>
        /// 원격 제어 요청 포트 - 가져오기
        /// </summary>
        public static short SetupPort
        {
            get
            {
                return 20002;
            }
        }
        /// <summary>
        /// 이벤트 서버 포트
        /// </summary>
        public static short EventPort
        {
            get
            {
                return 20010;
            }
        }

        /// <summary>
        /// 디폴트 IP 주소 문자열 - 가져오기
        /// </summary>
        public static string DefaultIP
        {
            get
            {
                //호스트 이름 구하기
                string host_name = Dns.GetHostName();
                //호스트 엔트리 구하기
                IPHostEntry host_entry = Dns.GetHostEntry(host_name);
                //호스트 주소 목록 반복
                foreach (IPAddress ipaddr in host_entry.AddressList)
                {
                    //주소 체계가 InterNetwork일 때
                    if (ipaddr.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return ipaddr.ToString();//IP 주소 문자열 반환
                    }
                }
                return string.Empty;//빈 문자열 반환
            }
        }
    }
}
