using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace RsaGenerateKey.NET.Common
{
  public  class XmlFormatter
    {
        private int _keySize;
        private string _savePath;
      public XmlFormatter(int keysize,string savePath)
      {
          this._keySize = keysize;
          this._savePath = savePath;
      }
  
      public void GenerateKey()
      {
          RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(_keySize);
          string privateKey = rsa.ToXmlString(true);
          string pulicKey = rsa.ToXmlString(false);
          string pubFile = Path.Combine(_savePath, "publicKey.xml");
          string privFile = Path.Combine(_savePath, "privateKey.xml");
          Save(privFile, privateKey);
          Save(pubFile, pulicKey);
           
      }

      public void Save(string fileName, string content)
      {
          StreamWriter sw = new StreamWriter(fileName,false);
          sw.Write(content);
          sw.Close();
      }
    }
}
