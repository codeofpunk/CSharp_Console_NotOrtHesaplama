using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_OrtalamaHesap
{
    class Program
    {
        static void Main(string[] args)
        {
            double vize1;
            double vize2;
            double final;
            double ortalama;

            Console.WriteLine("****** Ders Not Ortalaması Hesaplama ******");
            Console.Write("1. Vize Notunuz:");
            vize1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("2. Vize Notunuz:");
            vize2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Final Notunuz:");
            final = Convert.ToDouble(Console.ReadLine());

            ortalama = (vize1 + vize2) * 0.2 + final * 0.6;

            if (ortalama < 60)
            {
                Console.WriteLine(ortalama + " Ortalama ile dersten kaldınız! :(");
            }

            else
            {
                Console.WriteLine(ortalama + " Ortalama ile başarıyla dersi geçtiniz.");
            }

            Console.ReadLine();
        }
    }
}
