using System;
using System.Linq;

namespace ConsoleApp3
{
    public static class Class1
    {

        public static void Task1()
        {
            int sideLength = 4; 
            char symbol = '*'; 

            for (int i = 0; i < sideLength; i++)
            {
                for (int j = 0; j < sideLength; j++)
                {
                    Console.Write(symbol + " ");
                }
                Console.WriteLine();
            }
        }

        public static void Task2()
        {
            int number1 = 1221;
            int number2 = 3443;
            int number3 = 7854;

            Console.WriteLine(IsPalindrome(number1));
            Console.WriteLine(IsPalindrome(number2)); 
            Console.WriteLine(IsPalindrome(number3));

             bool IsPalindrome(int number)
            {
                int originalNumber = number;
                int reversedNumber = 0;

                while (number > 0)
                {
                    int remainder = number % 10;
                    reversedNumber = reversedNumber * 10 + remainder;
                    number /= 10;
                }

                return originalNumber == reversedNumber;
            }

            
        }

        public static void Task3()
        {
            int[] originalArray = { 1, 2, 6, -1, 88, 7, 6 };
            int[] filterArray = { 6, 88, 7 };

            var resultArray = FilterArray(originalArray, filterArray);

            Console.WriteLine("Resoult:");
            foreach (int num in resultArray)
            {
                Console.Write(num + " ");
            }

            int[] FilterArray(int[] originalArray, int[] filterArray)
            {
                List<int> resultList = new List<int>(originalArray);

                foreach (int num in filterArray)
                {
                    resultList.RemoveAll(x => x == num);
                }

                return resultList.ToArray();
            }
        }
    }

    class Website
    {
        private string name;
        private string path;
        private string description;
        private string ipAddress;

        public void SetName(string name)
        {
            name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetPath(string path)
        {
            path = path;
        }

        public string GetPath()
        {
            return path;
        }

        public void SetDescription(string description)
        {
            description = description;
        }

        public string GetDescription()
        {
            return description;
        }

        public void SetIpAddress(string ipAddress)
        {
            ipAddress = ipAddress;
        }

        public string GetIpAddress()
        {
            return ipAddress;
        }

        public void InputData()
        {
            Console.WriteLine("Enter website name:");
            SetName(Console.ReadLine());

            Console.WriteLine("Enter website path:");
            SetPath(Console.ReadLine());

            Console.WriteLine("Enter website description:");
            SetDescription(Console.ReadLine());

            Console.WriteLine("Enter website IP address:");
            SetIpAddress(Console.ReadLine());
        }

        public void DisplayData()
        {
            Console.WriteLine("Website Name: " + GetName());
            Console.WriteLine("Website Path: " + GetPath());
            Console.WriteLine("Website Description: " + GetDescription());
            Console.WriteLine("Website IP Address: " + GetIpAddress());
        }
    }

    class Magazine
    {
        private string name;
        private int yearFounded;
        private string description;
        private string contactPhone;
        private string email;

        public void SetName(string magName)
        {
            name = magName;
        }

        public string GetName()
        {
            return name;
        }

        public void SetYearFounded(int year)
        {
            yearFounded = year;
        }

        public int GetYearFounded()
        {
            return yearFounded;
        }

        public void SetDescription(string desc)
        {
            description = desc;
        }

        public string GetDescription()
        {
            return description;
        }

        public void SetContactPhone(string phone)
        {
            contactPhone = phone;
        }

        public string GetContactPhone()
        {
            return contactPhone;
        }

        public void SetEmail(string emailAddress)
        {
            email = emailAddress;
        }

        public string GetEmail()
        {
            return email;
        }

        public void InputData()
        {
            Console.WriteLine("Enter magazine name:");
            SetName(Console.ReadLine());

            Console.WriteLine("Enter year founded:");
            SetYearFounded(int.Parse(Console.ReadLine()));

            Console.WriteLine("Enter magazine description:");
            SetDescription(Console.ReadLine());

            Console.WriteLine("Enter contact phone:");
            SetContactPhone(Console.ReadLine());

            Console.WriteLine("Enter email:");
            SetEmail(Console.ReadLine());
        }

        public void DisplayData()
        {
            Console.WriteLine("Magazine Name: " + GetName());
            Console.WriteLine("Year Founded: " + GetYearFounded());
            Console.WriteLine("Description: " + GetDescription());
            Console.WriteLine("Contact Phone: " + GetContactPhone());
            Console.WriteLine("Email: " + GetEmail());
        }
    }

    class Store
    {
        private string name;
        private string address;
        private string profileDescription;
        private string contactPhone;
        private string email;

        public void SetName(string storeName)
        {
            name = storeName;
        }

        public string GetName()
        {
            return name;
        }

        public void SetAddress(string storeAddress)
        {
            address = storeAddress;
        }

        public string GetAddress()
        {
            return address;
        }

        public void SetProfileDescription(string description)
        {
            profileDescription = description;
        }

        public string GetProfileDescription()
        {
            return profileDescription;
        }

        public void SetContactPhone(string phone)
        {
            contactPhone = phone;
        }

        public string GetContactPhone()
        {
            return contactPhone;
        }

        public void SetEmail(string emailAddress)
        {
            email = emailAddress;
        }

        public string GetEmail()
        {
            return email;
        }

        public void InputData()
        {
            Console.WriteLine("Enter store name:");
            SetName(Console.ReadLine());

            Console.WriteLine("Enter store address:");
            SetAddress(Console.ReadLine());

            Console.WriteLine("Enter store profile description:");
            SetProfileDescription(Console.ReadLine());

            Console.WriteLine("Enter contact phone:");
            SetContactPhone(Console.ReadLine());

            Console.WriteLine("Enter email:");
            SetEmail(Console.ReadLine());
        }

        public void DisplayData()
        {
            Console.WriteLine("Store Name: " + GetName());
            Console.WriteLine("Store Address: " + GetAddress());
            Console.WriteLine("Profile Description: " + GetProfileDescription());
            Console.WriteLine("Contact Phone: " + GetContactPhone());
            Console.WriteLine("Email: " + GetEmail());
        }
    }
}
