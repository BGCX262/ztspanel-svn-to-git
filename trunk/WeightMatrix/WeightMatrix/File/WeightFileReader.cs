using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Xml;

namespace WeightMatrix
{
    public class WeightFileReader
    {
        private XmlReader weightDataReader;

        // Constructor
        public WeightFileReader(string filePath)
        {
            XmlReaderSettings xmlSetting = new XmlReaderSettings();
            xmlSetting.IgnoreWhitespace = true;
            weightDataReader = XmlReader.Create(filePath,xmlSetting);
        }

        // Membaca data
        public Matrix ReadData()
        {
            //double[,] dataTemp;
            weightDataReader.ReadToFollowing("WeightMatrixDataFile");
            weightDataReader.ReadStartElement();
            
            int numberObservations = weightDataReader.ReadElementContentAsInt();
            int rows = numberObservations;
            int cols = numberObservations;
            Matrix dataTemp = new Matrix(rows, cols);

            weightDataReader.ReadStartElement();
            {
                for (int i = 0; i < rows; i++)
                {
                    weightDataReader.ReadStartElement();
                    for (int j = 0; j < cols; j++)
                    {
                        dataTemp[i, j] = weightDataReader.ReadElementContentAsDouble();
                    }
                    weightDataReader.ReadEndElement();
                }
                weightDataReader.ReadEndElement();
            }
            weightDataReader.ReadEndElement();
            return dataTemp;
        }
    }
}
