namespace GolfSwing
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Welcome to Damion's Virtual Caddy");

            //I want to call diferent programs.
            //the first is a club recommender based on stock yardages
            //the second is a database that stores my yardages
            //finally a personalized club recommender based on my yardages


            string programSelection;
            int yardageTo;
            int i = 1;


            //this code will be used to select 1 of 3 functions

            //Console.WriteLine("Enter program option");
            //programSelection = Console.ReadLine();
            //Console.WriteLine("You chose " + programSelection);

            

            Console.WriteLine("Using average yardages, we can determine the proper club you should use.");

            while(i == 1)
            {
                Console.WriteLine("Enter yardage: ");

                try
                {

                    yardageTo = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("The hole is " + yardageTo + " yards away.");

                    Console.WriteLine("I recommend you use your " + ClubChoice(yardageTo));
                }
                catch
                {
                    Console.WriteLine("You didn't enter valid data");
                }

                Console.WriteLine("Type end, to end program, or enter to check another yardage.");

                string check = Console.ReadLine();

                if(check == "end")
                {
                    i++;
                }

            }

            Console.WriteLine("Thank you for using Damion's Virtual Caddy");

            Console.ReadLine();
        }

        static string ClubChoice(int aYardage)
        {
            int lobWedge = 60;
            int sandWedge = 80;
            int gapWedge = 90;
            int pitchWedge = 100;
            int nineIron = 115;
            int eightIron = 130;
            int sevenIron = 140;
            int sixIron = 145;
            int hybridClub = 180;
            int fiveWood = 195;
            int threeWood = 210;
            int driverClub = 220;
            int yardage;
            yardage = aYardage;
            string clubRec = "unassigned";

            if (yardage >= driverClub)
            {
                clubRec = "Driver";
            }
            else if (yardage >= threeWood)
            {
                clubRec = "3 Wood";
            }
            else if (yardage >= fiveWood)
            {
                clubRec = "5 Wood";
            }
            else if (yardage >= hybridClub)
            {
                clubRec = "Hybrid";
            }
            else if (yardage >= sixIron)
            {
                clubRec = "6 iron";
            }
            else if (yardage >= sevenIron)
            {
                clubRec = "7 iron";
            }
            else if (yardage >= eightIron)
            {
                clubRec = "8 iron";
            }
            else if (yardage >= nineIron)
            {
                clubRec = "9 iron";
            }
            else if (yardage >= pitchWedge)
            {
                clubRec = "P Wedge";
            }
            else if (yardage >= gapWedge)
            {
                clubRec = "G Wedge";
            }
            else if (yardage >= sandWedge)
            {
                clubRec = "S Wedge";
            }
            else if (yardage <= sandWedge)
            {
                clubRec = "L Wedge";
            }

            return clubRec;
        }

    }
}