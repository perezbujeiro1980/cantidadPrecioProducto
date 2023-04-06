using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace baldesdeEnduido
{
    class Program
    {
        static void Main(string[] args)
        {
         // kgs-precio $

        //22 kg ? 
            22> 21 ? si
                350x4 (28k)= 1400$
                14x2 = 28k (1300$)
                21x2= 42k (2040$)


      //19 kgs
            7x3 = 21k = $1050
            14x2 =28k = $1300
            

             
       




         int[,] precioEnduido = new int[,] { { 7, 350 }, { 14, 650 }, { 21, 1020} };

        Console.Write("kilos:");
        int kilos = Convert.ToInt16(Console.ReadLine());

        ////10 kgs
        //for (int i = 0; i <= precioEnduido.Length-1; i++)
        //{
        //    if (i < 3 ) {
        //        if (kilos == precioEnduido[i,0])
        //            Console.Write(precioEnduido[i,1]);

        //        if (kilos > precioEnduido[i, 0] && kilos <= precioEnduido[i + 1, 0])
        //            Console.Write(precioEnduido[i + 1, 1]);
        //    }           
            
        //}

        //Console.ReadKey();
        //}
        
    }
}
