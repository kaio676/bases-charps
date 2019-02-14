using System;

namespace lista
{
    class Program
    {

       //public int Numero { get;  set; }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
            string titular = Console.ReadLine();
            int numero = 24;
            int i;
           // string lista = "";


            for(i = 1;i < numero; i++){
                Console.WriteLine("#EXTINF:-1 tvg-logo="+" group-title="+"TBBT 2 TEMPORADA"+ " Tbbt 5X0"+i);
                System.Console.WriteLine("http://xd.azureedge.net/RedeCanais/RCServer01/videos/DHEMT02EP0"+i+".mp4");

            }

        }
    }
}
