using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace student
{
    class stud
    {
        //fields
        private string _name;
        private string _family;
        private int _age;
        private int _nationalcode;
        //consreuctors
        public stud()
        {
            _name = "";
            _family = "";
            _age = 0;
            _nationalcode = 0;
        }
        public stud(string n, string f, int a, int c)
        {
            _name = n;
            _family = f;
            _age = a;
            _nationalcode = c;
        }
        //properties
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string family
        {
            get { return _family; }
            set { _family = value; }
        }
        public int age
        {
            get { return _age; }
            set { if (value > 18) _age = value; }
        }
        public int nationalcode
        {
            get { return _nationalcode; }
            set { _nationalcode = value; }
        }
        //methods
        public void Getinfo()
        {
            Console.WriteLine("student information show");
        }

    }

    class program
    {
        static void Main(string[] args)
        {
            stud my1 = new stud("zahra", "daraby", 21, 123456987);
            stud my2 = new stud();
            my2.name = "ali";
            my2.family = "barani";
            my2.age = 20;
            my2.nationalcode = 1234569685;
            Console.WriteLine("my1:" + my1.name + "-" + my1.family + "-" + my1.age + "-" + my1.nationalcode);
            Console.WriteLine("my2:" + my2.name + "-" + my2.family + "-" + my2.age + "-" + my2.nationalcode);
            my2 = my1;
            Console.WriteLine("my2:" + my2.name + "-" + my2.family + "-" + my2.age + "-" + my2.nationalcode);
            my1 = my2;
            Console.WriteLine("my1:" + my1.name + "-" + my1.family + "-" + my1.age + "-" + my1.nationalcode);
            Console.ReadKey();
        }
    }
}
