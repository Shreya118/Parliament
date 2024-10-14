using System;
using System.Collections.Generic;

public class Parliament1
{
    public static void Main(string[] args)
    {
        int choice;

        do
        {
            Console.WriteLine("Indian Parliament");
            Console.WriteLine("1. President of India");
            Console.WriteLine("2. Rajya Sabha");
            Console.WriteLine("3. Lok Sabha");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter your choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    President.DisplayDetails();
                    break;
                case 2:
                    RajyaSabha.DisplayDetails();
                    break;
                case 3:
                    LokSabha.DisplayDetails();
                    break;
                case 4:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again");
                    break;
            }
        } while (choice != 4);
    }
}

public class President
{
    public static void DisplayDetails()
    {
        Console.WriteLine("\nThe President of India is an integral part of the Parliament though he/she is not a member of either House of Parliament. Under the Constitution, the executive power of the Union is vested in the President to be exercised by him/her either directly or through officers subordinates to him/her.\n");

        int Pchoice;
        do
        {
            Console.WriteLine("1. President");
            Console.WriteLine("2. Back to main menu");
            Console.WriteLine("Enter your choice: ");

            Pchoice = int.Parse(Console.ReadLine());

            switch (Pchoice)
            {
                case 1:
                    Console.WriteLine("\nThe current President of India is 'Smt. Droupadi Murmu'\n");
                    break;
                case 2:
                    Console.WriteLine("\nReturning to main menu\n");
                    break;
                default:
                    Console.WriteLine("\nInvalid choice, please try again");
                    break;
            }
        } while (Pchoice != 2);
    }
}

public class ParliamentHouse
{
    private List<string> members = new List<string>();

    public void AddMember()
    {
        Console.WriteLine("Enter the name of the member to add: ");
        string name = Console.ReadLine();
        if (System.Text.RegularExpressions.Regex.IsMatch(name, @"^[a-zA-Z]+$"))
        {
            members.Add(name);
            Console.WriteLine("Member added successfully.");
        }
        else
        {
            Console.WriteLine("Invalid name. Only alphabetic characters are allowed.");
        }
    }

    public void DisplayMembers()
    {
        if (members.Count == 0)
        {
            Console.WriteLine("No members added yet.\n");
        }
        else
        {
            Console.WriteLine("Members:\n");
            foreach (var member in members)
            {
                Console.WriteLine(member);
            }
        }
    }

    public void DeleteMember()
    {
        if (members.Count == 0)
        {
            Console.WriteLine("No members added yet.\n");
        }
        else
        {
            Console.WriteLine("Enter the name of the member to delete: ");
            string name = Console.ReadLine();
            if (members.Remove(name))
            {
                Console.WriteLine("Member deleted successfully.");
            }
            else
            {
                Console.WriteLine("Member not found.");
            }
        }
    }

    public List<string> GetMembers()
    {
        return members;
    }
}

public class RajyaSabha : ParliamentHouse
{
    public static void DisplayDetails()
    {
        Console.WriteLine("\nCouncil of States i.e Rajya Sabha is the Upper House of the Indian Parliament. Rajya Sabha consists of the representatives of the States and the Union Territories and persons nominated by the President of India.\n");

        int Rchoice;
        RajyaSabha rs = new RajyaSabha();
        do
        {
            Console.WriteLine("Rajya Sabha");
            Console.WriteLine("1. Chairman");
            Console.WriteLine("2. Deputy Chairman");
            Console.WriteLine("3. Add Member");
            Console.WriteLine("4. Display Members");
            Console.WriteLine("5. Delete Member");
            Console.WriteLine("6. Back to main menu");
            Console.WriteLine("Enter your choice: ");

            Rchoice = int.Parse(Console.ReadLine());

            switch (Rchoice)
            {
                case 1:
                    Console.WriteLine("\nThe current chairman of Rajya Sabha 'Shri Jagdeep Dhankhar' \n");
                    break;
                case 2:
                    Console.WriteLine("\nThe current deputy chairman of Rajya Sabha 'Shri Harivansh' \n");
                    break;
                case 3:
                    rs.AddMember();
                    break;
                case 4:
                    rs.DisplayMembers();
                    break;
                case 5:
                    rs.DeleteMember();
                    break;
                case 6:
                    Console.WriteLine("\nReturning to main menu\n");
                    break;
                default:
                    Console.WriteLine("\nInvalid choice, please try again");
                    break;
            }
        } while (Rchoice != 6);
    }
}

public class LokSabha : ParliamentHouse
{
    public static void DisplayDetails()
    {
        Console.WriteLine("\nAs per the provision of Article 79 of Indian Constitution, the House of the People, the Lok Sabha is the lower House of the parliament. Lok Sabha is composed of representatives of the people chosen by direct election on the basis of the adult suffrage\n");

        int Lchoice;
        LokSabha ls = new LokSabha();
        do
        {
            Console.WriteLine("Lok Sabha");
            Console.WriteLine("1. Speaker");
            Console.WriteLine("2. Add Member");
            Console.WriteLine("3. Display Members");
            Console.WriteLine("4. Delete Member");
            Console.WriteLine("5. Back to main menu");
            Console.WriteLine("Enter your choice: ");

            Lchoice = int.Parse(Console.ReadLine());

            switch (Lchoice)
            {
                case 1:
                    Console.WriteLine("\nThe current speaker of Lok Sabha is 'Shri Om Birla'\n");
                    break;
                case 2:
                    ls.AddMember();
                    break;
                case 3:
                    ls.DisplayMembers();
                    break;
                case 4:
                    ls.DeleteMember();
                    break;
                case 5:
                    Console.WriteLine("\nReturning to main menu\n");
                    break;
                default:
                    Console.WriteLine("\nInvalid choice, please try again");
                    break;
            }
        } while (Lchoice != 5);
    }
}
