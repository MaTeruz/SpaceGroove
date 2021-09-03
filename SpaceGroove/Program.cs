using System;
using System.Collections;
using System.Collections.Generic;


namespace SpaceGroove
{
    /*class int
    {
        private int num;

        public int(int num_) 
        {            
            this.num = num_;
        }

        public void print()
        {
            Console.WriteLine("================================");
            Console.WriteLine("The roints cerial number: "+ num + "\n================================");
        }
    }*/


    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> bots = new Dictionary<string, int>() { };
            bots.Add("q-33", 7043);
            bots.Add("10-Hi-F9s", 2);
            bots.Add("Y-K9", 10);
            
            bots["Test"] = new int();

            foreach (var robo in bots)
            {
                Console.WriteLine("\n================================================="+
                                 $"\nRobot Key ={robo.Key}, Robot Value = {robo.Value}"+
                                  "\n=================================================");
            }

            Dictionary<string, int>.ValueCollection valueColl = bots.Values;

            foreach ( int s in valueColl)
            {
                Console.WriteLine("\n==============="+
                                 $"\nValues = {s}"+
                                  "\n===============");
            }

            Console.ReadKey();

            int value;
            if (bots.TryGetValue("Test", out value))
            {
                Console.WriteLine("\n---------------------------------"+
                                 $"\nKey = Test, value = {value}"+
                                  "\n---------------------------------");
            }
            else
            {
                Console.WriteLine("key = Test is not found5 ");
            }

            Console.ReadKey();

            if (bots.TryGetValue("10-Hi-F9s", out value))
            {
                Console.WriteLine("\n---------------------------------" +
                                 $"\nKey = 10-Hi-F9s, value = {value}" +
                                  "\n---------------------------------");
            }
            else
            {
                Console.WriteLine("\nkey = 10-Hi-F9s is not found5 ");
            }

            Console.ReadKey();
            Console.WriteLine("\nDecontructing robot(10-Hi-F9s)");
            bots.Remove("10-Hi-F9s");
            Console.ReadKey();

            if (!bots.ContainsKey("10-Hi-F9s"))
            {
                Console.WriteLine("\n|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|" +
                                  "\n|Robot (10-Hi-F9s) has been Destroyed succesfully!|"+
                                  "\n|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|");
            }

            Console.WriteLine($"\nNew Number of Robots = {bots.Count}");

            Console.WriteLine("\nThe New full list of Robots");

            foreach (KeyValuePair<string, int> var in bots)    
            {
                Console.WriteLine("\n-------------------------------------------------"+
                                 $"\nRobot key = {var.Key}, Robots value = {var.Value}"+
                                  "\n-------------------------------------------------");
            }

            Console.ReadLine();

        }
    }
}
