using System;
using System.Collections.Generic;

namespace realbook
{
    class Program
    {


        static void Main(string[] args)
        {
            List<User> userlist = new List<User>();

            while (true)
            {
                Console.WriteLine("choose the option 1. to add " +
                    "2. to delete " +
                    "3. to edit");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Write("unique id  :      ");
                        string id = Console.ReadLine();
                        Console.Write("Name  :      ");
                        string name = Console.ReadLine();
                        Console.Write("age  :      ");
                        string age = Console.ReadLine();
                        Console.Write("address  :      ");
                        string address = Console.ReadLine();
                        Console.Write("phone  :      ");
                        string phone = Console.ReadLine();
                        User user = new User(id, name, age, address, phone);
                        userlist.Add(user);
                        for (int i = 0; i < userlist.Count; i++)
                        {
                            Console.WriteLine("the name is :" + userlist[i]._name);
                        }
                        break;
                    case 2:
                        Console.WriteLine("give the index of the element to be removed   : ");
                        int wrongIndex = int.Parse(Console.ReadLine());
                        userlist.RemoveAt(wrongIndex);
                        for (int i = 0; i < userlist.Count; i++)
                        {
                            Console.WriteLine("the name is :" + userlist[i]._name);
                        }
                        break;

                    case 3:
                        Console.WriteLine("give the index of the element to be edited :   ");
                        int editIndex = int.Parse(Console.ReadLine());
                        Console.WriteLine("give the nuber as 1.to edit name   2.to edit age 3. to edit address 4. to edit phone  :   ");
                        int number = int.Parse(Console.ReadLine());
                          switch (number)
                        {
                            case 1:
                                userlist[editIndex]._name = Console.ReadLine();
                                break;
                            case 2:
                                userlist[editIndex]._age = Console.ReadLine();
                                break;
                            case 3:
                                userlist[editIndex]._address = Console.ReadLine();
                                break;
                            case 4:
                                userlist[editIndex]._phone = Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine("give the correct num  ");
                                break;
                        }
                        for (int i = 0; i < userlist.Count; i++)
                        {
                            Console.WriteLine("the name is :" + userlist[i]._name);
                        }
                        break;
                        
                    default:
                        Console.WriteLine("give the crt input");
                        break;
                }
                if (option > 3)
                {
                    break;
                }

            }
        }
    }
}
