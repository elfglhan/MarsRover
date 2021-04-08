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
            string[] robInf;//robot bilgileri array olarak tutulan alan

            Console.WriteLine("Robotun kordinatlarını ve yönünü girin: ");
            robotLoc = Console.ReadLine();
            robInf = robotLoc.Split(" ");
            if (robInf.Length == 3)
            {
                rb.x = Convert.ToInt32(robInf[0]);//robotun bulunduğu x kordinatını atadım
                rb.y = Convert.ToInt32(robInf[1]);//robotun bulunduğu y kord. atadım.
                rb.Direction = robInf[2];//hangi yönde durduğunu atadım.
            }
            Console.WriteLine("Yol bilgilerini giriniz:");
                way = Console.ReadLine(); 
                foreach (char c in way.ToCharArray())//girilen yol bilgisinin her karakterinin 
                {
                    if (c.ToString() == "L")
                    {
                        if (rb.Direction == "N")
                        {
                            rb.Direction = "W";
                            continue;
                        }
                        else if (rb.Direction == "W")
                        {
                            rb.Direction = "S";
                            continue;
                        }
                        else if (rb.Direction == "S")
                        {
                            rb.Direction = "E";
                            continue;
                        }
                        else if (rb.Direction == "E")
                        {
                            rb.Direction = "N";
                            continue;
                        }
                    }
                else if (c.ToString() == "R")
                {
                    if (rb.Direction == "N")
                    {
                        rb.Direction = "E";
                        continue;
                    }
                    else if (rb.Direction == "E")
                    {
                        rb.Direction = "S";
                        continue;
                    }
                    else if (rb.Direction == "S")
                    {
                        rb.Direction = "W";
                        continue;
                    }
                    else if (rb.Direction == "W")
                    {
                        rb.Direction = "N";
                        continue;
                    }
                }
                else if(c.ToString() == "M")
                    {
                        if (rb.Direction == "N")
                        {
                            rb.y += 1;
                            continue;
                        }
                        else if (rb.Direction == "S")
                        {
                            rb.y -= 1;
                            continue;
                        }
                        else if (rb.Direction == "W")
                        {
                        
                            rb.x -= 1;
                            continue;
                        }
                        else if (rb.Direction == "E")
                        {
                            rb.x += 1;
                            continue;
                        }
                    }             
                }
            
            Console.Write("Son konum :{0} {1} {2} ", rb.x, rb.y, rb.Direction);
            Console.ReadKey();

        }
    }
}
