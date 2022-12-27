using ders5_IBB;
using System;
using static ders5_IBB.clsCarGallery;


internal class Program
{
    private static void Main(string[] args)
    {
        //object creation- (Class name- object name =  new class name)

        clsCarGallery carGallery = new clsCarGallery(); //instance example1
        Student student = new Student();


        //Access to object properties

        carGallery.Brand = "Mercedes";
        carGallery.Model = "C200";
        carGallery.Color = "Black";

        Console.WriteLine(carGallery.Price.ToString()); //takes from default value


        Console.WriteLine("Arabanın markası : " +carGallery.Brand);
        Console.WriteLine("Arabanın Modeli: " +carGallery.Model);
        Console.WriteLine("Arabanın rengi :"+carGallery.Color);




        // Example 2

        student.Name = "Elif";
        student.Secondname = "Yılmaz";
        student.Age = 25;
        student.SClass = 11;
        student.lenght = 1.67f;


        Console.WriteLine("Student's Name: " + student.Name);
        Console.WriteLine("Student's Second Name: " + student.Secondname.ToUpper());
        Console.WriteLine("Student's Age: " + student.Age);
        Console.WriteLine("Student's Class: " + student.SClass);
        Console.WriteLine("Student's Gender: " + student.Gender);
        Console.WriteLine("Student's Lenght: " + student.lenght);

        Console.ReadKey();
        
    }

    /* public class CarGallery // We defined a class named CarGallery //Sınıf adı
     { Class features- Sınıf özellikleri:

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
    */

    //Example 2

    public class Student
    {
        public String Name { get; set; }
        public String Secondname { get; set; }
        public int Age { get; set; }
        public int SClass { get; set; } //student class

        public char Gender = 'F';

        public float lenght { get; set; }

    }
}
