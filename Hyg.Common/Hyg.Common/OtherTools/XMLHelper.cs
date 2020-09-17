/*===================================Copyright© 2020 xxx Ltd. All rights reserved.==============================

文件类名 : XMLHelper.cs
创建人员 : Mr.Hu
创建时间 : 2020-09-17 17:39:48 
备注说明 : 

 =====================================End=======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Hyg.Common.OtherTools
{
    /// <summary>
    /// XMLHelper
    /// </summary>
    public class XMLHelper
    {
        public static XmlNode ResolveXML(string xmlStr, string nodeName, bool IsFirstLevel)
        {
            XmlNode xmlNode = null;
            var doc = new XmlDocument();
            doc.LoadXml(xmlStr);
            if (IsFirstLevel)
            {
                XmlNodeList xmlNodeList = doc.ChildNodes;
                for (int i = 0; i < xmlNodeList.Count; i++)
                {
                    if (xmlNodeList[i].Name == nodeName)
                    {
                        xmlNode = xmlNodeList[i];
                    }
                }
            }
            else
            {
                XmlNodeList nodeList = doc.SelectNodes(nodeName);
                if (nodeList != null)
                {
                    xmlNode = nodeList[0];
                }
            }

            return xmlNode;
        }

        /// <summary>
        /// 获取属性名称
        /// </summary>
        /// <param name="xmlNode"></param>
        /// <param name="attributeName"></param>
        /// <returns></returns>
        public static string GetAttribute(XmlNode xmlNode, string attributeName)
        {
            try
            {
                return xmlNode.Attributes[attributeName].Value;
            }
            catch (Exception)
            {
                return "";
            }

        }
    }
}
