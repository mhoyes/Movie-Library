
#region USING
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization; 
#endregion

namespace Movie_Library
{
    public static class Serialization
    {
        #region DATA MEMBERS
        //
        #endregion


        #region CONSTRUCTORS
        //public Serialization()
        //{
        //} 
        #endregion


        #region PROPERTIES
        //
        #endregion

        #region SERIALIZE_METHODS
        //Serialize to XML
        public static bool WriteToXML<T>(string path, string fileName, T data)
        {
            bool hasSaved = false;

            //serialize data
            FileStream fs = new FileStream(fileName, FileMode.Create);
            XmlSerializer serial = new XmlSerializer(typeof(T));

            //Empty XML Namespace
            var emptyXML = new XmlSerializerNamespaces();
            emptyXML.Add("", "");

            //try-catch if serialized
            try
            {
                serial.Serialize(fs, data, emptyXML);
                hasSaved = true;
            }
            catch (Exception ex)
            {
                hasSaved = false;
                throw ex;
            }

            fs.Close();

            return hasSaved;
        }

        public static bool WriteXNAToXML<T>(string path, string fileName, T data)
        {
            bool hasSaved = false;

            //serialize data
            FileStream fs = File.Open(@fileName + ".xml", FileMode.OpenOrCreate);
            XmlSerializer serial = new XmlSerializer(typeof(T));

            //Empty XML Namespace
            var emptyXML = new XmlSerializerNamespaces();
            emptyXML.Add("", "");

            //try-catch if serialized
            try
            {
                serial.Serialize(fs, data, emptyXML);
                hasSaved = true;
            }
            catch (Exception ex)
            {
                hasSaved = false;
                throw ex;
            }

            //fs.Close();

            return hasSaved;
        }
        #endregion


        #region DESERIALIZE_METHODS
        public static T ReadFromXML<T>(string path, string fileName)
        {
            T data;

            //deserialize data
            FileStream fs = new FileStream(fileName, FileMode.Open);
            XmlSerializer serial = new XmlSerializer(typeof(T));

            data = (T)serial.Deserialize(fs);

            fs.Close();

            return data;
        }
        #endregion
    }
}
