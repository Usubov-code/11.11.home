using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._11.home
{
    public delegate void Deligate(int a, int b);
    public static class Program
    {
        static void Main(string[] args)
        {
            #region deligate
            //Deligate del = Sum;

            //del += Subtraction;
            //del += Division;
            //del += Multi;


            //del(5,4);
            #endregion

            #region task 1


            //List<int> Mylist = new List<int>();

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Please enter a number");
            //    Mylist.Add(Convert.ToInt32(Console.ReadLine())); 

            //}

            //int[] arr = Mylist.ToArray();
            //int multi = 1;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    multi = arr[i] * 3;
            //    Console.WriteLine($"{multi} number Multi");
            //}


            #endregion

            #region task 2

            //List<int> list = new List<int>();
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Please enter the number");
            //    list.Add(Convert.ToInt32(Console.ReadLine()));
            //}



            //for (int i = 0; i < list.Count; i++)
            //{


            //    list[i] = (int)Math.Pow(list[i], 3);



            //    Console.WriteLine(list[i]);

            //}

            #endregion

            #region task3
            //List<string> lst = new List<string>() ;

            //Console.WriteLine("Enter the String 3");
            //for (int i = 1; i < 4; i++)
            //{
            //    lst.Add(Console.ReadLine());
            //    Console.WriteLine($"Entered{i}");
            //}


            //foreach (var item in lst)
            //{
            //    Console.WriteLine($"#{item}#");
            //}



            #endregion

            #region task 4

            //List<Car> liste = new List<Car>();

            //for (int i = 0; i < 5; i++)
            //{
            //    Car car = new Car();
            //    car.Brand = Console.ReadLine();
            //    car.Model = Console.ReadLine();
            //    car.DoorCount = Convert.ToByte(Console.ReadLine());

            //    liste.Add(car);
            //}


            //FullInfo(liste);
            #endregion

            #region taks 5

            //List<byte> Ages = new List<byte>();

            //Ages.Add(5);
            //Ages.Add(2);
            //Ages.Add(3);


            //Ages.AddRange(Ages);


            //Ages.Remove(5);
            //Ages.RemoveAt(0);
            //Ages.RemoveRange(0,3);

            #endregion
        }



        public static void FullInfo(this List<Car> liste)
        {
            foreach (var item in liste)
            {
                Console.WriteLine($"car brand name: {item.Brand} car model name: {item.Model} car door count: {item.DoorCount}");
            }
            


        }
        public static void Sum(int a, int b)
        {
            Console.WriteLine($"sum {a + b}");

        }
        public static void Subtraction(int a, int b)
        {
            Console.WriteLine($"subtraction {a - b} ");

        }
        public static void Division(int a, int b)
        {
            Console.WriteLine($"division {a / b} ");

        }
        public static void Multi(int a, int b)
        {

            Console.WriteLine($"Multi {a * b} ");

        }
    }

}
