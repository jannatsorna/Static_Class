using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Static_Class.Program;

namespace Static_Class   //can not inherit, must write static keyword before declear variable, can not create instance,object, 
                        //don't need to write virtual,override,abstract before method as it is static so when u write anything that directly go the the memory
{
    internal class Program
    {
        public static class Student
        {
            public static int s_id;
            public static string s_name;
            public static double s_tutionfee;

            static Student()//constructor
            {
                s_id = 11;
                s_name = "Tamanna";
                s_tutionfee = 76500;
            }
            public static void Get_Details()
            {
                Console.WriteLine("Student Id : {0}", s_id);
                Console.WriteLine("Student Name : {0}", s_name);
                Console.WriteLine("Tution Fee : {0}", s_tutionfee);
            }
            public static void Get_Scholarship()
            {
                double s_amount = s_tutionfee / 10;
                Console.WriteLine("Scholarship that get by the student is : {0} Tk", s_amount);
                Console.WriteLine("tution Fee that student have to pay : {0} Tk", (s_tutionfee - s_amount));
            }

        }

        //using static method in both parent & chid class
        public class Base
        {
            public static void Get()
            {
                Console.WriteLine("This is a BASE Class");
            }
        }
        public class Derived : Base 
        {
            public static void Get()
            {
                Console.WriteLine("This is a DERIVED Class");
            }
        }


        //passing value to a list in static class

        public class Product //normal class
        {
            public int p_id { get; set; }
            public string p_name { get; set; }
            public double p_price { get; set; }
           
            public Product(int ID, string Name, double Price)//constructor with parameter
            {
                p_id = ID;
                p_name = Name;
                p_price = Price;
            }
        }
        public static class Pro //static class
        {
            public static List<Product> plist = new List<Product>(new[]
            {
                new Product(11,"Onion",250),
                new Product(12,"Potato",20),
                new Product(13,"Chess",389.78),
            });
            public static List<Product> Get_Product_Details()
            {
                return plist;
            }
        }
    }

    /*   
        static class Test
        {
            //declear list
            static List<string> list;
            //constructor
            static Test()
            {
                //allocate the list
                list = new List<string>();
            }
        }
        public static void Record(string value)
        {
            //push the value in list
            list.Add(value);
        }
        public static void Display()
        {
            foreach(var value in list)
            {
                Console.WriteLine(value);
            }
        }
        */

    public class Must_Give_The_Class
    {
        static void Main(string[] args)
        {
            Student.Get_Details();
            Student.Get_Scholarship();

            //  Test.Record("Apple");
            //  Test.Record("Orange");
            //  Test.Display();
           // Product product = new Product();

            List<Product> productsList = new List<Product>();
            productsList= Pro.Get_Product_Details();
            foreach (Product data in productsList)
            {
                Console.WriteLine("Product Id : {0},Product Name : {1},Product Price : {2}",data.p_id, data.p_name, data.p_price);
            }

            Base.Get();
            Derived.Get();
            Console.ReadLine();

        }
    }
     
}



