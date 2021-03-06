﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace CardDav
{
    public class CardDavParser
    {
        public static List<string> GetNodeContents(XmlNode parentNode, string tag, List<string> results = null)
        {
            if (results == null) results = new List<string>();

            foreach (XmlNode node in parentNode.ChildNodes)
            {
                if (node.Name.ToLower().Equals(tag.ToLower()))
                    results.Add(node.InnerText);

                if (node.HasChildNodes)
                {
                    GetNodeContents(node, tag, results);
                }
            }

            return results;
        }
    }
}
