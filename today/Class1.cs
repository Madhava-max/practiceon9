using System;
using System.Collections.Generic;
using System.Text;

namespace realbook
{
    public class User
    {
        public string _id;
        public string _name;
        public string _age;
        public string _address;
        public string _phone;

        public User(string id, string name, string age, string address, string phone)
        {
            _id = id;
            _name = name;
            _age = age;
            _address = address;
            _phone = phone;

        }
    }
}
