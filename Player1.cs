using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExample
{
    class Player1
    {
        public string Name { get; set; }
        public int Run { get; set; }

        public Player1(string name, int run)
        {
            Name = name;
            Run = run;
        }
    }
    class Team : IEnumerable
    {
        private Player1[] playerArray = new Player1[4];

        public Team()
        {
            playerArray[0] = new Player1("Virat", 90);
            playerArray[1] = new Player1("Dhoni", 100);
            playerArray[2] = new Player1("Rohit", 40);
            playerArray[3] = new Player1("Yuvraj", 80);

        }

        public IEnumerator GetEnumerator()
        {
            return playerArray.GetEnumerator();
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            Team India = new Team();

            foreach (Player1 player in India)
            {
                Console.WriteLine("Name is{0} and Run is {1}", player.Name, player.Run);

            }
            Console.ReadLine();
        }
    }
}