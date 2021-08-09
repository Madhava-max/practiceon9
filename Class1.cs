using System;
using System.Collections.Generic;
using System.Text;

namespace realbook
{
    public class User
    {
        
        public string _name;
        private int _age;
        private string _address;
        private string _phone;

        public User(string name, int age, string address, string phone)
        {
            _name = name;
            _age = age;
            _address = address;
            _phone = phone;

        }
    }
}
