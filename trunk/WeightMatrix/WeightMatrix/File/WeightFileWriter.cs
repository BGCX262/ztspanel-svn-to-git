// Class untuk menulis data ke dalam File
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace WeightMatrix
{
    public class WeightFileWriter
    {
        private XmlWriter weightDataWriter;

        // Constructor
         public WeightFileWriter(string filePath)
        {
            XmlWriterSettings xmlSetting = new XmlWriterSettings();
            xmlSetting.Indent = true;
            weightDataWriter = XmlWriter.Create(filePath, xmlSetting);
        }

        // Menulis data dengan format XML
         public void WriteData(Matrix a)
         {
             int rows = a.Rows ;
             int cols = a.Cols;
             weightDataWriter.WriteStartDocument();
             weightDataWriter.WriteStartElement("WeightMatrixDataFile");
             weightDataWriter.WriteElementString("NumberObservations", rows.ToString());
             
             weightDataWriter.WriteStartElement("WeightData");
             for (int i = 0; i < rows; i++)
             {   weightDataWriter.WriteStartElement("DataRows");
                    for (int j = 0; j < cols; j++)
                    {
                        weightDataWriter.WriteElementString("Value", a[i,j].ToString());
                    }
                    weightDataWriter.WriteEndElement();
             }
             weightDataWriter.WriteFullEndElement();

         }

         public void CloseFile()
         {
             weightDataWriter.Close();
         }

    }
}
