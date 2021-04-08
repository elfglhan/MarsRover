using System;
using MarsRover.Library;
namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {//kontrol fonksyonları yazılcak.
            Console.WriteLine("Plato Boyutları 5*5");
            Program p = new Program();
            p.Mars();
        }

        public void Mars()
        {
            Robots rb = new Robots();
            string robotLoc;
            string way;
            string[] wayinf;//yolun karakter olarak ayrılmış verisini tutan alan.
            string[] robInf;//robot bilgileri array olarak tutulan alan

            Console.WriteLine("1. robotun kordinatlarını ve yönünü girin: ");

            robotLoc = Console.ReadLine();
            Console.WriteLine("Yol bilgilerini giriniz:");
            char chr = Console.ReadKey().KeyChar;
            if (chr.ToString() == "M" && chr.ToString() == "L" && chr.ToString() == "R")
            {

            }
            way = Console.ReadLine();
            wayinf = way.Split();
            robInf = robotLoc.Split();
            if (robInf.Length == 3)
            {
                rb.x = Convert.ToInt32(robInf[0]);//robotun bulunduğu x kordinatını atadım
                rb.y = Convert.ToInt32(robInf[1]);//robotun bulunduğu y kord. atadım.
                rb.Direction = robInf[2];//hangi yönde durduğunu atadım.
            }

            if (rb.Direction == "N")
            {
                foreach (var route in wayinf)
                {
                    if (route == "m")
                    {
                        rb.x += 1;
                    }
                    else if (route == "l")
                    {
                        rb.Direction = "e";
                    }
                    else
                    {
                        rb.Direction = "S";
                    }
                }
            }

            //array a atıycam 
            //o array içine döngüyle dolaşıcam 
            //döngünün içinde l veya r görürse rb.direction değişikliği olucak 
            //m harfi görürse yön ilerlemesi yapacak ama yönü w yada n ise y ekseni e yada s ise x ekseni değişecek 


        }
    }
}
