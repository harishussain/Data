using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace Xmlparsing
{
    class Program
    { 
       
        static void parsexml(string xmlString)
        {
            StringBuilder output = new StringBuilder();
           using( XmlReader reader = XmlReader.Create(new StringReader(xmlString)))
           {
               reader.ReadToFollowing("book");
               reader.MoveToFirstAttribute();
               string genre = reader.Value;
               output.AppendLine("genre:"+genre);
               reader.MoveToNextAttribute();
               string publication = reader.Value;
               output.AppendLine("publication"+publication);
               reader.MoveToAttribute(2);
               reader.ReadToFollowing("title");
               output.AppendLine("title is:" + reader.ReadElementContentAsString());
            }
           Console.WriteLine(output);
           Console.ReadLine();
        }
        static void Main(string[] args)
        {
            

           string xmlString = @"
                               <bookstore>
                                <book genre='modelgraph' publication='12-3-22' Emi='4ddls4' > 
                                 <title> the model desig in 2 dimension</title>
                                 <author>
                                   <first-name>Allen</first-name>
                                    <last-name>Turing</last-name>
                                   </auther>
                                </book>
                                </bookstore>
                                ";
            parsexml(xmlString);
          





        }
    }
}
