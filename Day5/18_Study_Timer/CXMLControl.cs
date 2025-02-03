using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Security.Cryptography;

namespace _18_Study_Timer
{
    internal class CXMLControl
    {
        public static string _TICK = "TICK";
        public static string _TOTAL = "TOTAL";

        public static string _ADD_1 = "ADD_1";
        public static string _ADD_3 = "ADD_3";
        public static string _ADD_50 = "ADD_50";


        public static string _LEVEL_1 = "LEVEL_1";
        public static string _LEVEL_3 = "LEVEL_3";
        public static string _LEVEL_50 = "LEVEL_50";

        public Dictionary<string, string>fXML_Reader(string strXMLPath)
        {
            Dictionary<string, string>DXMLConfig = new Dictionary<string, string>();

            using (XmlReader rd = XmlReader.Create(strXMLPath))
            {
                while (rd.Read()) 
                {
                    if (rd.IsStartElement())
                    {
                        if(rd.Name.Equals("SETTING"))
                        {
                            string strID = rd["ID"];
                            rd.Read();

                            string strTICK = rd.ReadElementContentAsString(_TICK,"");
                            DXMLConfig.Add(_TICK, strTICK);
                            
                            string strTOTAL = rd.ReadElementContentAsString(_TOTAL, "");
                            DXMLConfig.Add(_TOTAL, strTOTAL);

                            string strADD_1 = rd.ReadElementContentAsString(_ADD_1, "");
                            DXMLConfig.Add(_ADD_1, strADD_1);

                            string strADD_3 = rd.ReadElementContentAsString(_ADD_3, "");
                            DXMLConfig.Add(_ADD_3, strADD_3);

                            string strADD_50 = rd.ReadElementContentAsString(_ADD_50, "");
                            DXMLConfig.Add(_ADD_50, strADD_50);


                            string strLEVEL_1 = rd.ReadElementContentAsString(_LEVEL_1, "");
                            DXMLConfig.Add(_LEVEL_1, strLEVEL_1);

                            string strLEVEL_3 = rd.ReadElementContentAsString(_LEVEL_3, "");
                            DXMLConfig.Add(_LEVEL_3, strLEVEL_3);

                            string strLEVEL_50 = rd.ReadElementContentAsString(_LEVEL_50, "");
                            DXMLConfig.Add(_LEVEL_50, strLEVEL_50);
                        }
                    }
                }

            }
            return DXMLConfig;
        }
        /// <summary>
        /// XML을 저장하기 위해 사용
        /// </summary>
        /// <param name="strXMLPath">저장 할 XML FILE의 경로 및 파일명</param>
        /// <param name="DXMLConfig">XML로 저장할 항목</param>
        public void fXML_Writer(string strXMLPath, Dictionary<string, string> DXMLConfig) 
        {
            // using 범위 내에 XmlWriter를 정의 하여 using으 ㄹ벗어 나게 될 경우 자동으로 Dispose하여 메모리를 관리
            using (XmlWriter wr =XmlWriter.Create(strXMLPath))
            {
                // XML 형태의 Data를 작성 (결과 및 예제 확인)
                wr.WriteStartDocument();

                //SETTING
                wr.WriteStartElement("SETTING");
                wr.WriteAttributeString("ID", "0001"); // attribue에 쓰기

                wr.WriteElementString(_TICK, DXMLConfig[_TICK]);
                wr.WriteElementString(_TOTAL, DXMLConfig[_TOTAL]);

                wr.WriteElementString(_ADD_1, DXMLConfig[_ADD_1]);
                wr.WriteElementString(_ADD_3, DXMLConfig[_ADD_3]);
                wr.WriteElementString(_ADD_50, DXMLConfig[_ADD_50]);
                
                wr.WriteElementString(_LEVEL_1, DXMLConfig[_LEVEL_1]);
                wr.WriteElementString(_LEVEL_3, DXMLConfig[_LEVEL_3]);
                wr.WriteElementString(_LEVEL_50, DXMLConfig[_LEVEL_50]);

                wr.WriteEndElement();
                wr.WriteEndDocument();
            }
        }
    }
}
