namespace verplicht_lifeSims;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int geld = 25;
        DateTime huidigeDag = DateTime.Now;
        int blijheid = 50;
        int honger = 50;
        int thirst = 50;
        int rest = 50;
        while (true)
        // monday  the xth of september xxxx
        {
            if (geld <= 0)
            {
                Console.Clear();
                Console.WriteLine("you are bankrupt, this sends you into a deep depression eventually commiting suicide. womp womp");
                Thread.Sleep(5000);

                Console.WriteLine("Press ctrl+C to exit");
                Console.WriteLine("(or press enter to get revived and live your life in debt)");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("your teammate has collected your reboot card");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("you are getting rebooted.");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("you are getting rebooted..");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("you are getting rebooted...");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("you got rebooted!");
                Thread.Sleep(1000);
                Console.Clear();
            }

            string formattedDate = $"{huidigeDag.DayOfWeek} the {huidigeDag.Day}th of {huidigeDag.ToString("MMMM")}, {huidigeDag.Year}";
            Console.WriteLine("use ctrl+c to exit");
            Console.WriteLine("\n");
            Console.WriteLine(formattedDate);
            Console.WriteLine($"\n");
            Console.WriteLine($"you are {rest}% rested");
            Console.WriteLine($"your belly filled to {honger}% out of 100");
            Console.WriteLine($"your thirst level is at {thirst}% filled");
            Console.WriteLine($"your happiness is {blijheid} out of 100");
            Console.WriteLine($"You have {geld} euros");
            Console.WriteLine("What do you want to do?");
            // Console.WriteLine("1. Go shopping \n2. Go to work \n3. Go to sleep");
            string[] keuzes = ["go shopping", "go to work", "go to sleep"];

            for (int i = 0; i < keuzes.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {keuzes[i]}");


            }
            string keuze = Console.ReadLine();
            if (keuze == "1")
            {
                // string[] shopItems = ["1. clothes", "2. food", "3. drinks"];
                Console.Clear();
                Console.WriteLine("What do you want to get?");
                Console.WriteLine("1. clothes");
                Console.WriteLine("2. food");
                Console.WriteLine("3. drinks");
                string shopKeuze = Console.ReadLine();
                if (shopKeuze == "1")
                {
                    Console.Clear();
                    Console.WriteLine("tip: you can get yourself in debt... be carefull what you purchase");
                    Console.WriteLine("what do you want to purchase?");
                    Console.WriteLine("1. blue sweater (50 euro)");
                    Console.WriteLine("2. linnen pants (20 euro)");
                    Console.WriteLine("3. exit store");
                    string shopKlerenKeuze = Console.ReadLine();
                    if (shopKlerenKeuze == "1")
                    {
                        Console.Clear();
                        blijheid = Math.Clamp(blijheid + 60, 0, 100);
                        geld = geld - 50;
                        Console.WriteLine("You spent 50 euro's for a Blue sweater!");
                    }
                    else if (shopKlerenKeuze == "2")
                    {
                        Console.Clear();
                        blijheid = Math.Clamp(blijheid + 25, 0, 100);
                        geld = geld - 20;
                        Console.WriteLine("You spent 20 euro's for linnen pants!");
                    }
                    else if (shopKlerenKeuze == "3")
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Wrong input!");
                        Console.WriteLine("Press enter to continue");
                        Console.Clear();
                        continue;
                    }

                }
                else if (shopKeuze == "2")
                {

                    Console.Clear();
                    Console.WriteLine("use food to add happiness and hunger");
                    Console.WriteLine("what do you want to purchase?");
                    Console.WriteLine("1. please burger cheese (5 euro)");
                    Console.WriteLine("2. fwench fwies (2 euro)");
                    Console.WriteLine("3. exit store");
                    string shopEtenKeuze = Console.ReadLine();
                    if (shopEtenKeuze == "1")
                    {
                        honger = Math.Clamp(honger + 25, 0, 100);
                        blijheid = Math.Clamp(blijheid + 10, 0, 100);
                        geld = geld - 5;
                        Console.Clear();
                        Console.WriteLine("ate a cheese burber!");
                    }
                    else if (shopEtenKeuze == "2")
                    {
                        honger = Math.Clamp(honger + 10, 0, 100);
                        blijheid = Math.Clamp(blijheid + 2, 0, 100);
                        geld = geld - 2;
                        Console.Clear();
                        Console.WriteLine("french fries are very salty!");
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine("ate some french fries!");
                    }
                    else if (shopEtenKeuze == "3")
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Wrong input!");
                        Console.WriteLine("Press enter to continue");
                        Console.Clear();
                        continue;
                    }

                }
                else if (shopKeuze == "3")
                {

                    Console.Clear();
                    Console.WriteLine("use drinks to replenish your thirst");
                    Console.WriteLine("what do you want to purchase?");
                    Console.WriteLine("1. coke (2 euro)");
                    Console.WriteLine("2. water (1 euro)");
                    Console.WriteLine("3. exit store");
                    string shopDrinkKeuze = Console.ReadLine();
                    if (shopDrinkKeuze == "1")
                    {
                        thirst = Math.Clamp(thirst + 20, 0, 100);
                        blijheid = Math.Clamp(blijheid + 5, 0, 100);
                        geld = geld - 2;
                        Console.Clear();
                        Console.WriteLine("you drank a coke");
                    }
                    else if (shopDrinkKeuze == "2")
                    {
                        thirst = Math.Clamp(thirst + 15, 0, 100);
                        geld = geld - 1;
                        Console.Clear();
                        Console.WriteLine("you drank some water!");
                    }
                    else if (shopDrinkKeuze == "3")
                    {
                        continue;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Wrong input!");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                }
                else
                    Console.WriteLine("Wrong input!");
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
                Console.Clear();
                continue;
            }


            else if (keuze == "2")
            {
                thirst = Math.Clamp(thirst - 20, 0, 100);
                honger = Math.Clamp(honger - 15, 0, 100);
                rest = Math.Clamp(rest - 10, 0, 100);
                geld = geld + 5;
                blijheid = blijheid - 1;
                Console.Clear();
                Console.WriteLine("tip: working can be pretty tiring");
                Thread.Sleep(3000);
                Console.Clear();
                Console.WriteLine("you are working.");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("you are working..");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("you are working...");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("you are working....");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("you are working.....");
                Thread.Sleep(1000);
            }
            else if (keuze == "3")
            {

                thirst = Math.Clamp(thirst - 10, 0, 100);
                honger = Math.Clamp(honger - 5, 0, 100);
                rest = rest + 20;
                Console.Clear();
                Console.WriteLine("tip: sleeping will replenish your rest");
                System.Threading.Thread.Sleep(3000);
                Console.Clear();
                Console.WriteLine("you are sleeping.");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("you are sleeping..");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("you are sleeping...");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("you are sleeping....");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("you are sleeping.....");
                System.Threading.Thread.Sleep(1000);

            }
            else
            {
                Console.WriteLine("Wrong input");
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
                continue;

            }
            huidigeDag = huidigeDag.AddDays(1);
            Console.WriteLine("It is now the next day...");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();
        }
    }
}


