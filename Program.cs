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
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Write("Name  :      ");
                        string name = Console.ReadLine();
                        Console.Write("age  :      ");
                        int age = int.Parse(Console.ReadLine());
                        Console.Write("address  :      ");
                        string address = Console.ReadLine();
                        Console.Write("phone  :      ");
                        string phone = Console.ReadLine();
                        User user = new User(name, age, address, phone);
                        userlist.Add(user);
                        for(int i=0;i<userlist.Count;i++)
                        {
                            Console.WriteLine("the name is :" + userlist[i]._name);
                        }
                        break;
                    default:
                        Console.WriteLine("give the crt input");
                        break;
                }
                if(option>3)
                {
                    break;
                }
                
            }
        }
    }
}

