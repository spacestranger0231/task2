using System;
using System.Collections.Generic;
using System.Text;

namespace Домашнє_2__до_понеділка_
{
    class Dairy_products:Product
    {
        public int termin;
        public Dairy_products() {
            name = "wrwrw";
            price = 231;
            weight = 21213;
            termin = 2342;
        }

        public Dairy_products(string _name, int _price, int _weight, int _termin):base(_name, _price, _weight)
        {
            this.termin = _termin;
        }

        public int dairy_Products
        {
            get
            {
                return termin;
            }
            set
            {
                termin = value;
            }

        }

        public  override void changeprice(int vid)
        {
            int newvid;
            if (termin < 0)
            {
                Console.WriteLine("PRODUCT PROSTROCHENYI");
            }
            else
            {
                if (termin == 0)
                {
                    newvid = -50;
                }

                else if (termin <= 5 && termin >= 1)
                {
                    newvid = -25;
                }
                else
                {
                    newvid = 5;
                }
                int newv;
                Console.WriteLine("Your previous price was: " + price);
                vid += newvid;
                newv = (vid * price) / 100;
                price += newv;
                Console.WriteLine("Your new price is: " + price);
            }
        }

        public override void into()
        {
            Console.WriteLine("\nInput name:");
            name = Console.ReadLine();
            Console.WriteLine("\nInput price:");
            price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInput weight:");
            weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInput termin:");
            termin = Convert.ToInt32(Console.ReadLine());
        }

        public override string ToString()
        {
            return "Product" + Name + Price + Weight + termin;
        }

        public override bool Equals(object ob)
        {
            if (ob == null)
            {
                return false;
            }
            else
            {
                Dairy_products p = (Dairy_products)ob;
                if (price == p.price || weight == p.weight || name == p.name || termin == p.termin)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        public override int GetHashCode()
        {
            return Tuple.Create(price, weight, name, termin).GetHashCode();
        }
    }
}
