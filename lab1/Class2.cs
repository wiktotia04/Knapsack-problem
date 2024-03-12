using Google.Protobuf.Collections;
using Google.Protobuf.WellKnownTypes;
using Mysqlx.Session;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Problem
    {
        public int n { get; set; }
        public int seed { get; set; }
        public int c { get; set; }
        

        public List<Item> list = new List<Item>();

        

        public Problem(int n,int seed)
        {
            Random random = new Random(seed);
            this.n = n;      //random.Next(10, 10);
            this.seed = seed;
            this.c = c;
            

            for (int i = 0; i < n; i++)
            {
                Item item = new Item(random.Next(1, 11), random.Next(1, 11), 0);
                list.Add(item);
            }
        }

        /*public void Plecak(List<Item> list)
        {
            for (int i = 0; i < list.Count; i++)
            {

                if (list[i].weight <= c)
                {
                    list[i].x = 1;
                }
                else
                {
                    list[i].x = 0;
                }

            }
        }*/

        public Result Solve(int capacity)
        {
            //Plecak(list);

            Result result = new Result();

             c = capacity;

            list = list.OrderByDescending(x=> (double)x.value / x.weight).ToList();


            for (int i = 0; i < list.Count; i++)
            {

                if (list[i].weight <= c)
                {
                    list[i].x = 1;
                }
                else
                {
                    list[i].x = 0;
                }

            }

            for (int i = 0; i < list.Count; i++)
            {
                var item = list[i];

                if (item.weight * item.x == 0)
                {

                }
                else
                {
                    if (item.weight <= capacity)
                    {
                        result.TotalValue += item.value;
                        result.TotalWeight += item.weight;
                        capacity -= item.weight;
                        result.index.Add(i);
                    }
                }

            }
            

            return result;
        }
        public override string ToString()
        {
            string result = $"Pojemnosc plecaka: {c}, liczba przedmiotow: {n}, nasionko losowania: {seed}\n";

            foreach (var item in list)
            {
                result += $"Index: {list.IndexOf(item)}, Weight: {item.weight}, Value: {item.value}, X: {item.x},  Value/Weight: {(double)item.value / item.weight}\n";
            }

            return result;
        }



    }




}