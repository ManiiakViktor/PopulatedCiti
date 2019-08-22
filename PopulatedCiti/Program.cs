using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulatedCiti
{
    struct Citi
    {
        public string name;
        public int pop;
        public int sq;
        public int spd;//   specific population density;
        public int num;// length name

        //public void DisplayInfo()
        //{
        //    Console.Write($" Name: {name} \n Population: {pop} \n Square: {sq} \n Specific population density - {spd} ");
        //}
    }

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(" enter city information ");
            string info = Console.ReadLine();
            //string info = "Kharkiv=1431000,350;Kiev=2804000,839;Las-Vegas=6000000,10020";
            string[] result = info.Split(';', '=', ',');
            for (int i1 = 0; i1 < result.Length; i1++)
            {
                //string i = result[i1];
                
                Citi Kh;
                Kh.name = result[0];
                Kh.pop = Convert.ToInt32(result[1]);
                Kh.sq = Convert.ToInt32(result[2]);
                Kh.spd = Kh.pop / Kh.sq;
                Kh.num = Kh.name.Length;
                // Kh.DisplayInfo();
                Citi Ki;
                Ki.name = result[3];
                Ki.pop = Convert.ToInt32(result[4]);
                Ki.sq = Convert.ToInt32(result[5]);
                Ki.spd = Ki.pop / Ki.sq;
                Ki.num = Ki.name.Length;
                //Ki.DisplayInfo();

                Citi La;
                La.name = result[6];
                La.pop = Convert.ToInt32(result[7]);
                La.sq = Convert.ToInt32(result[8]);
                La.spd = La.pop / La.sq;
                La.num = La.name.Length;
                // La.DisplayInfo();
                int[] numMax = new int[3];
                numMax[0] = Kh.num;
                numMax[1] = Ki.num;
                numMax[2] = La.num;
                int biggestNumber = numMax.Max();
                if (biggestNumber == numMax[0])
                    Console.Write($" The city with the longest name -{Kh.name}{Kh.num}-number of characters");
                if (biggestNumber == numMax[1])
                    Console.Write($" The city with the longest name -{Ki.name}{Ki.num}-number of characters");
                if (biggestNumber == numMax[2])
                    Console.Write($" The city with the longest name - {La.name}-{La.num}-number of characters");
                int[] pcity = new int[3];
                pcity[0] = Kh.pop;
                pcity[1] = Ki.pop;
                pcity[2] = La.pop;
                int maxPcity = pcity.Max();
                if (maxPcity == pcity[0])
                    Console.Write($" \n The most populated city -{Kh.name}- {Kh.pop}-people");
                if (maxPcity == pcity[1])
                    Console.Write($" \n The most populated city -{Ki.name}-{Ki.pop}-people");
                if (maxPcity == pcity[2])
                    Console.Write($"\n The most populated city - {La.name}-{La.pop}-people");
                Console.WriteLine($"");
                Console.WriteLine($"Urban population density:\n -{Kh.name}-{Kh.spd}\n -{Ki.name}-{Ki.spd} \n {La.name}-{La.spd}");
                //Console.WriteLine(La.num);
                // Console.WriteLine(biggestNumber);
                Console.ReadKey();

            }
        }
    }
}
