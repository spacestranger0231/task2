using System;

namespace Домашнє_2__до_понеділка_
{

    public enum Kategory { highsort1 = 1, highsort2 };
    public enum Kind { baranyna = 1, teliatyna, svynyna, kuriatyna };

    
    class Meat : Product
    {
        Kategory Kate;
        Kind Ki;


        public Meat(string _name, int _price, int _weight, Kategory _Kate, Kind _Ki) : base(_name, _price, _weight)
        {
            this.Kate = _Kate;
            this.Ki = _Ki;
        }

        public Meat()
        {
            name = "";
            price = 231;
            weight = 21213;
            Kate = 0;
            Ki = 0;
        }

        public Kategory Kategor
        {
            get
            {
                return Kate;
            }
            set
            {
                Kate = value;
            }

        }

        public Kind Kin
        {
            get
            {
                return Ki;
            }
            set
            {
                Ki = value;
            }
        }

        public override void into()
        {
            int n, k;
            Console.WriteLine("\nInput name:");
            name = Console.ReadLine();
            Console.WriteLine("\nInput price:");
            price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInput weight:");
            weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nWhich type of sort?");
            n = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("\nYou`ve chose highsort1");
            }
            else if (n == 2)
            {
                Console.WriteLine("\nYou`ve chose highsort2");
            }
            else
            {
                Console.WriteLine("\nWrong input");
            }
            Console.WriteLine("\nWhich meat?");
            k = Convert.ToInt32(Console.ReadLine());
            if (k == 1)
            {
                Console.WriteLine("\nYou`ve chose 'BARANYNA'");
            }
            else if (k == 2)
            {
                Console.WriteLine("\nYou`ve chose 'TELIATYNA'");
            }
            else if (k == 3)
            {
                Console.WriteLine("\nYou`ve chose 'SVYNYNA'");
            }
            else if (k == 4)
            {
                Console.WriteLine("\nYou`ve chose 'KURIATYNA'");
            }
            else
            {
                Console.WriteLine("\nWrong input");
            }
        }

        public void changepricemeat(int vid, Kategory k)
        {
            int plusp = 0;
            int newv;
            if (k == Kategory.highsort1)
            {
                plusp = 15;
            }
            else if (k == Kategory.highsort2)
            {
                plusp = 10;
            }
            Console.WriteLine("Your previous price was: " + price);
            vid += plusp;
            newv = (vid * price) / 100;
            price += newv;
            Console.WriteLine("Your new price is: " + price);
        }

        public override string ToString()
        {
            return "Product" + Name + Price + Weight + Kategor + Kin;
        }

        public override bool Equals(object ob)
        {
            if (ob == null)
            {
                return false;
            }
            else
            {
                Meat p = (Meat)ob;
                if (price == p.price || weight == p.weight || name == p.name || Kate == p.Kate || Ki == p.Ki)
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
            return Tuple.Create(price, weight, name, Kate, Ki).GetHashCode();
        }

    }

}
