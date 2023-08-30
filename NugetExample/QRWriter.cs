using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QRCoder;

namespace NugetExample
{
    internal class QRWriter
    {

        public void WriteQrToFile(string textToEncode,string pathToWrite)
        {
            
            if (string.IsNullOrEmpty(textToEncode))
            {
                throw new ArgumentException("textToEncode not valid");
            }

            if (string.IsNullOrEmpty(pathToWrite))
            {
                throw new ArgumentException("pathToWrite not valid");
            }
            
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(textToEncode, QRCodeGenerator.ECCLevel.Q);

            PngByteQRCode qrCode = new PngByteQRCode(qrCodeData);
            byte[] qrCodeImage = qrCode.GetGraphic(20);

            File.WriteAllBytes(pathToWrite, qrCodeImage);
        }
    }
}
