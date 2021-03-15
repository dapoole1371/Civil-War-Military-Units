using System;

namespace Ex_7A_Military_Unit
{
    class Program
    {
        static void Main(string[] args)
        {
            Personnel person = new Personnel();
            Weapon weapon = new Weapon();
            MainMenu(ref person, ref weapon);
        }

        static void MainMenu(ref Personnel person, ref Weapon weapon)
        {
            Console.Write("Civil War Units\n1. Infantry\n2. Cavalier\n3. Artilleryman\n4. Exit Program\nPlease select an option from the menu: ");
            string input = Console.ReadLine();
            int output = 0;
            while(!int.TryParse(input, out output) || output < 1 || output > 4)
            {
                Console.Write("Invalid selection, please select a number from the menu: ");
                input = Console.ReadLine();
            }
            switch(output)
            {
                case 1:
                    Display(ref person, ref weapon, output);
                    break;
                case 2:
                    Display(ref person, ref weapon, output);
                    break;
                case 3:
                    Display(ref person, ref weapon, output);
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
            }
        }
        static void Display(ref Personnel person, ref Weapon weapon, int input)
        {
            Console.Clear();
            person.SetType(ref person, input);
            weapon.SetType(ref weapon, person.UnitType);
            Console.WriteLine(person.DisplayInfo(ref person));
            Console.WriteLine(weapon.WeaponDetails(ref weapon));
            Console.WriteLine(weapon.Operate(ref weapon));
            Console.WriteLine("Press <ENTER> to continue");
            Console.ReadLine();
            MainMenu(ref person, ref weapon);
        }
    }
}
