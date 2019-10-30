using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Day3_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Champions champion = new Champions();
            champion.printNumberOfChampions();

            // Calls default base class
            Jungler jungle1 = new Jungler();
            jungle1.printNumberOfChampions();

            // Calls child class with 2 params
            Jungler jungle2 = new Jungler(200000000, 29);
            jungle2.printNumberOfChampions();

            MyTopJungler topjungle = new MyTopJungler();
            topjungle.printLengthOfChamp();
            topjungle.printUpperCaseOfChampName();

            TopLaner toplane = new TopLaner();
            toplane.SomeTopLaners();
           

            Console.ReadLine();
        }
    }

    class Champions
    {
        private long numberOfPlayers;
        private int numberOfChamps;

        public long NumberOfPlayers { get => numberOfPlayers; set => numberOfPlayers = value; }
        public int NumberOfChamps { get => numberOfChamps; set => numberOfChamps = value; }

        public Champions()
        {
            numberOfPlayers = 1000000000;
            numberOfChamps = 145;
        }

        public Champions(long numberOfPlayers, int numberOfChamps)
        {
            this.numberOfPlayers = numberOfPlayers;
            this.numberOfChamps = numberOfChamps;
        }

        public virtual void printNumberOfChampions()
        {
            Console.WriteLine("Total LoL players: " + numberOfPlayers + ", Total LoL champs: " + numberOfChamps);
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" + "\r\n");
        }

        public virtual void description()
        {
            Console.WriteLine("This is a Champion.");
        }
    }

    class TopLaner : Champions
    {
        public override void description()
        {
            Console.WriteLine("This is a Toplaner.");
        }

        public string[] SomeTopLaners()
        {
            // Arrays
            string[] toplaners = { "Wukong", "Malphite","Darius", "Shen", "Jax" };

            foreach(string i in toplaners)
            {
                Console.WriteLine("{0}", i);
            }

            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

            return toplaners;
        }
    }

    class Jungler : Champions
    {

        public Jungler() { }
       
        public Jungler(long numberOfPlayers, int numberOfChamps) : base(numberOfPlayers, numberOfChamps) { }

        public override void printNumberOfChampions()
        {
            Console.WriteLine("Total Jungle players: " + NumberOfPlayers + ", Total Jungle champs: " + NumberOfChamps);
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" + "\r\n");
        }

        public override void description()
        {
            Console.WriteLine("This is a Jungler.");
        }
    }

    class MyTopJungler : Jungler
    {
        private string name;

        public MyTopJungler()
        {
            name = "Warwick";
        }

        // Stringbuilder class for amending strings
        StringBuilder champName = new StringBuilder("Warwick");

        public int printLengthOfChamp()
        {
            int length = name.Length;
            Console.WriteLine("Length of Warwick: " + length);
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" + "\r\n");
            return length;
        }

        public string printUpperCaseOfChampName()
        {
            champName.ToString();
            champName.Append("Warwick");

            string upperCaseChampName = name.ToUpper();
            Console.WriteLine("Uppercase of Warwick: " + upperCaseChampName);
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" + "\r\n");
            return upperCaseChampName;
        }


        public MyTopJungler(string newName)
        {
            name = newName;
        }
        public string getChampionName()
        {
            return name;
        }

        public void setChampionName(string newName)
        {
            name = newName;
        }

        public void displayName()
        {
            Console.WriteLine("I am " + name);
        }

        public string abilityName(string abilityQ)
        {
            return abilityQ;
        }

        public string abilityName(string abilityQ, string abilityW)
        {
            return abilityQ + ", " + abilityW;
        }

        public string abilityName(string abilityQ, string abilityW, string abilityE)
        {
            return abilityQ + " - " + abilityW + " - " + abilityE;
        }

        public string abilityName(string abilityQ, string abilityW, string abilityE, string abilityR, out string abilityPassive)
        {
            abilityPassive = "Eternal Hunger";
            return abilityQ + " -- " + abilityW + " -- " + abilityE + " -- " + abilityR;
        }
    }
}
