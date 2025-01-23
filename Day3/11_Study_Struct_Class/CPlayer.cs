using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Study_Struct_Class
{
    internal class CPlayer
    {
        

        //값들을 더해서 반환
        public int CardSun(int iSum, int iMoon, int iStar)
        {
            return iSum + iMoon + iStar;
        }

        // 결과를 String 형태로 반환 (화면에 결과를 보여주기 위해 사용)
        public string ResultText(int iCount, int iSun, int iMoon, int iStar, int iCardSum)
        {
            return string.Format("{0}회) 해:{1}, 달:{2}, 별:{3} => 합계는 {4} 입니다.", iCount, iSun, iMoon, iStar, iCardSum);
        }

        public string playerPair(int iCount, int ip1CardSum, int ip2CardSum)
        {
            int iCheck = ip1CardSum - ip2CardSum;
            if(iCheck > 0)
            {
                return string.Format("{0}회차 : Player1이 {1}만큼 더 큽니다.",iCount,iCheck);
            }
            else if(iCheck < 0) 
            {
                return string.Format("{0}회차 : Player2가 {1}만큼 더 큽니다.", iCount, Math.Abs(iCheck));
            }
            
            return string.Format("{0}회차 : Player1과 Player2의 값이 같습니다.", iCount);
            
        }

        public string PlayerResult(int iP1CardSum, int iP2CardSum) 
        {
            string strReturn = string.Empty;

            if (iP1CardSum > iP2CardSum)
            {
                strReturn = "Player1이 이겼습니다.";    
            }
            else if(iP1CardSum < iP2CardSum)
            {
                strReturn = "Player2가 이겼습니다.";
            }
            else
            {
                strReturn = "Player1과 Player2는 비겼습니다.";
            }

            return strReturn;
        }
    }
}
