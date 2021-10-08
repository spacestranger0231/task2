using System;
using System.Collections.Generic;
using System.Text;

namespace Домашнє_2__до_понеділка_
{
    class Product
    {
        public string name;
        public int price;
        public int weight;

        public Product()
        {
            name = "sdfsdf";
            price = 231;
            weight = 21213;
        }
        public Product(string _name, int _price, int _weight)
        {
            this.name = _name;
            this.price = _price;
            this.weight = _weight;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }
        public int Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }

        public virtual void into() {
            Console.WriteLine("\nInput name:");
            name = Console.ReadLine();
            Console.WriteLine("\nInput price:");
            price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInput weight:");
            weight = Convert.ToInt32(Console.ReadLine());
        }
           
        public virtual void changeprice(int vid)
        {
            int newv;
            Console.WriteLine("Your previous price was: " + price);
            newv = (vid * price) / 100;
            price = price + newv;
            Console.WriteLine("Your new price is: " + price);
        }

        public override string ToString()
        {
            return "Product" + Name + Price + Weight;
        }

        public override bool Equals(object ob)
        {
            if (ob == null)
            {
                return false;
            }
            else
            {
                Product p = (Product)ob;
                if (price == p.price || weight == p.weight || name == p.name)
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
            return Tuple.Create(price, weight, name).GetHashCode();
        }



    }
}
