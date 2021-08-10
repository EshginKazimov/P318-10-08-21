using ClassLibrary1;
using NamespaceAccessModifiers.Models;
using System;

namespace NamespaceAccessModifiers
{
    //ClassWork!!!!
    //Butun yaranan property-ler ancaq costructorda set olsun
    //Figure class-i yaratmaq, Type property-si olsun, CalculateArea method-u olsun
    //Circle class-i olsun, Figure-dan miras alsin, CalculateArea-ni ozune uygun hesablasin
    //Rectangle class-i olsun, Figure-dan miras alsin, CalculateArea-ni ozune uygun hesablasin

    class Program
    {
        static void Main(string[] args)
        {
            #region Namespace

            //Figure f = new Figure();
            //f.Demo = 10;
            //Console.WriteLine(f.Demo);

            //Demo.Figure f1 = new Demo.Figure();
            //f1.Test = 10;
            //Console.WriteLine(f1.Test);

            //Figure f = new Figure();
            //f.Test = 10;
            //Console.WriteLine(f.Test);
            //Console.ReadKey();

            #endregion

            #region AccessModifiers

            #region Internal - bir project daxilinde gorunur, class, all members

            //Test t = new Test();
            //t.Demo = 10;
            //Console.WriteLine(t.Demo);

            #endregion

            #region Protected internal - all members
            //reference alan assembly-de Protected-dir
            //oz assembly-sinde Internaldir

            //instance almaq
            //Message m = new Message();
            //m.Subject = "Qiymetlendirme";
            //m.Text = "Ela!";
            //m.Attachment = "";

            #endregion

            #region Private protected - all members
            //reference alan assembly-de Private-dir
            //oz assembly-sinde Protecteddir

            //Message m = new Message();

            #endregion

            #endregion
        }
    }

    class Sms : Message
    {
        public void Print()
        {
            Attachment = "";
            //Subject = "";
        }
    }

    //namespace Demo
    //{
    //    class Figure
    //    {

    //    }
    //}
}

//namespace Demo
//{
//    class Figure
//    {

//    }
//}
