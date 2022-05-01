using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulStokProgramı
{
    public static class QrBuilder
    {

        public static Image QrYap(string anaYerAdi, string yerAdi, string malzemeAdi, string adet)
        {
            
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            StringBuilder s = new StringBuilder();
            s.Append($"Ana Yer Ad: {anaYerAdi}");
            s.AppendLine();
            s.Append($"Yer Ad: {yerAdi}");
            s.AppendLine();
            s.Append($"Malzeme Ad: {malzemeAdi}");
            s.AppendLine();
            s.Append($"Malzeme Adet: {adet}");
            return qrcode.Draw(s.ToString(), 50);
            
        }
    }
}
