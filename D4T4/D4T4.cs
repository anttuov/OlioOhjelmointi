using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4T4
{
    class Vehicle
    {
        public string name;
        public string model;
        public int year;
        public string color;
        public override string ToString()
        {
            return "name:" + name+" model:"+model+" year:"+year+" color:"+color;
        }
        public virtual void PrintData()
        {
            Console.WriteLine("name:" + name + " model:" + model + " year:" + year + " color:" + color);
        }
    }
    class Bike : Vehicle
    {
        public bool gearwheels;
        public string gearname;

        public override void PrintData()
        {
            Console.WriteLine(base.ToString() + " gearwheels:" + gearwheels + " gearname:" + gearname);
        }
    }
    class Boat : Vehicle
    {
        public int seats;
        public string boattype;
        public override void PrintData()
        {
            Console.WriteLine(base.ToString() + " seats:" + seats + " boattype:" + boattype);
        }
    }
    class D4T4
    {
        static void Main(string[] args)
        {
            Bike bike = new Bike { name = "jopo", model = "street", year = 2010, color = "blue", gearwheels = true, gearname = "shimano" };
            Boat boat = new Boat { name = "suvi", model = "xxx5000", year = 1990, color = "blue", seats = 3, boattype = "rowboat" };
            bike.PrintData();
            boat.PrintData();

        }
    }
}
