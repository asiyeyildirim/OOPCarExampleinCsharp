using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders5_IBB
{
    internal class clsCarGallery
    {

       // We defined a class named CarGallery //Sınıf adı
    //Class features- Sınıf özellikleri:

        public string Brand { get; set; } // marka
        public string Model { get; set; } // model
        public string MClass { get; set; } // model class
        public int MPower { get; set; } // motor gücü
        public int MVolume { get; set; } // motor hacmi
        public string MSerial { get; set; } // seri no
        public char GasType { get; set; } // yakıt türü
        public char GearType { get; set; } // vites türü
        public string CaseType { get; set; } // kasa tipi
        public int ProducedYear { get; set; } // üretim yılı
        public string Color { get; set; } // renk

        public int  Price =100000; //default value
    }
}
