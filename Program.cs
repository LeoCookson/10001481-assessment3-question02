using System;

namespace A3Q2
{

    //Creates Class
    class Falcon
    {
        private string _FalconName;
        private string _Species;
        private string _Sex;
        private int _Weight;
        private string _BandNumber;

        //Set 
        public string FalconName
        {

            set
            {
                Console.WriteLine("please enter Falcon name");
                _FalconName = Console.ReadLine();
            }
        }

        public string Species
        {
            set
            {
                Console.WriteLine("please enter Falcon Species");
                _Species = Console.ReadLine();
            }
        }

        public string Sex
        {
            set
            {
                Console.WriteLine("Please enter Falcon Sex");
                _Sex = Console.ReadLine();
            }
        }

        public int Weight
        {
            set
            {
                Console.WriteLine("please enter Falcon Weight");
                _Weight = int.Parse(Console.ReadLine());
            }
        }

        public string BandNumber
        {
            set
            {
                Console.WriteLine("Please enter Falcon Brand Number");
                _BandNumber = Console.ReadLine();
            }
        }
        public Falcon(string _FalconName, string _Species, string _Sex, int _Weight, string _BandNumber)
        {
            FalconName = _FalconName;
            Species = _Species;
            Sex = _Sex;
            Weight = _Weight;
            BandNumber = _BandNumber;
        }
        //Display method 
        public string DisplayFalcon()
        {
            var show = "**********\nFALCON DATA OUTPUT\n";
            show += $"Falcon Name: {_FalconName}\n";
            show += $"Species: {_Species} \n";
            show += $"Sex: {_Sex} \n";
            show += $"Weight: {_Weight}grams \n";
            show += $"BandNumber: {_BandNumber} \n";

            return show;
        }
    }
    class Program
    {
        //Display to screen 
        static void Main(string[] args)
        {
            Console.Clear();
            var input = new Falcon("", "", "", 000, "");

            Console.WriteLine(input.DisplayFalcon());
        }
    }
}
