using System;
using System.Collections.Generic;
using System.Text;
namespace Домашнє_2__до_понеділка_
{
   
    class Storage
    {
        const int size = 5;
        int count;

        public int inicialization_menu()
        {
            int choice;
            Console.WriteLine("\nYou want to put data into by:" +
                "\n1.Inicialization" + "\n2.Dialogue");
            choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

        public void inputprod(Product[] p)
        {
            for (int i = 0; i < size; i++)
            {
                p[i].into();
            }
        }

        public void inputmeat(Meat[] m)
        {
            for (int i = 0; i < size; i++)
            {
                m[i].into();
            }
        }
        public void inputdairy(Dairy_products[] d)
        {
            for (int i = 0; i < size; i++)
            {
                d[i].into();
            }
        }

        public void changep(int siz, int pri, Product[] p)
        {
            for (int i = 0; i < siz; i++)
            {
                p[i].changeprice(pri);
            }
        }

        public void changepmeat(int siz, int pri, Kategory kate, Meat[] m)
        {
            for (int i = 0; i < siz; i++)
            {
                m[i].changepricemeat(pri, kate);
            }
        }

        public void changepd(int siz, int pri, Dairy_products[] d)
        {
            for (int i = 0; i < siz; i++)
            {
                d[i].changeprice(pri);
            }
        }

        public int menumain()
        {
            int n;
            Console.WriteLine("\n 'YOU' want some of:");
            Console.WriteLine("\n 1. Just Products");
            Console.WriteLine("\n 2.Meat");
            Console.WriteLine("\n 3.Dairy products");
            n = Convert.ToInt32(Console.ReadLine());
            return n;
        }
        public void getmeat(Kind k)
        {
            if (k == Kind.baranyna)
            {
                Console.WriteLine("\nYou`ve chosen 'BARANYNA'");
            }
            else if (k == Kind.teliatyna)
            {
                Console.WriteLine("\nYou`ve chosen 'TELIATYNA'");
            }
            else if (k == Kind.svynyna)
            {
                Console.WriteLine("\nYou`ve chosen 'SVYNYNA'");
            }
            else if (k == Kind.kuriatyna)
            {
                Console.WriteLine("\nYou`ve chosen 'KURIATYNA'");
            }
            else
            {
                Console.WriteLine("\nWrong input");
            }
        }


        //initialized input
        public void in_input(Product[] p,Meat[] m, Dairy_products[] d)
        {
            Console.WriteLine("\nInput products: ");
            inputprod(p);
            Console.WriteLine("\nInput Meat: ");
            inputmeat(m);
            Console.WriteLine("\nInput Dairy: ");
            inputdairy(d);
            count = size;
        }

       



        //dialogue input
        public void dial_input(Product[] p, Meat[] m, Dairy_products[] d)
        {
            Console.WriteLine("\n-Hello, how can I help you?");
            Console.WriteLine("\n-Hello, I want to buy some products, what do you have?");
            Console.WriteLine("\n-What,do you want to buy? Do you want some specifict products like" +
                "meat or dairy products or you wanna look on products in general?");
            Console.WriteLine("\n-Actually I want all of this");
            Console.WriteLine("\n-Fine, so from what should we start?");
            Console.WriteLine("\n-I want some...");
            int k = menumain();
            Console.WriteLine("\n-Sure,here we have: ");
            if (k == 1)
            {
                const int s = 3;
                count = s;
                int pricen;
                Console.WriteLine("\n -So, you`ve chosen products");
                Console.WriteLine("\n -Here we have: ");

                for (int i = 0; i < s; i++)
                {
                    p[i].name = Console.ReadLine();
                }

                Console.WriteLine("\n -And how much does it weight?");
                for (int i = 0; i < s; i++)
                {
                    Console.WriteLine(p[i].name + " is/are ");
                    p[i].weight = Console.Read();
                }
                Console.WriteLine("\n -And how much does it cost?");
                for (int i = 0; i < s; i++)
                {
                    Console.WriteLine(p[i].name + " cost(`s) ");
                    p[i].price = Console.Read();
                }
                Console.WriteLine("\n -Great, I want some: " + p[2].name);
                Console.WriteLine("\n -Oooh, I am so sorry, but due to new law, we have some additional % on price?");
                Console.WriteLine("\n -What???????? how much?");
                Console.WriteLine("\n -Well, it has additional % of: ");
                pricen = Console.Read();
                Console.WriteLine("\n -So, how much I have to pay?");
                changep(s, pricen, p);
                Console.WriteLine("\n -Fine, I`ll pay, but you should know I`m truly dissapointed of your shop, goodbye young man!");
                Console.WriteLine("\n -Thank you, hope once you`ll come to us again");
                Console.WriteLine("\n -I doubt it");
            }
            else if (k == 2)
            {
                const int s = 1;
                count = s;
                Kategory sort = Kategory.highsort1;
                Kind ki = Kind.kuriatyna;
                int pricen;
                Console.WriteLine("\n -So, you`ve chosen meat");
                Console.WriteLine("\n -Here we have: ");
                Console.WriteLine("\n'-Kuriatyna'");
                Console.WriteLine("\n'-TELIATYNA'");
                Console.WriteLine("\n'-SVYNYNA'");
                Console.WriteLine("\n'-KURIATYNA'");
                Console.WriteLine("\n -What would you like?");
                Console.WriteLine("\n -I wouls like?");
                getmeat(ki);
                m[1].name = ki.ToString();
                Console.WriteLine("\n -And how much does it weight?");
                Console.WriteLine(p[1].name + " is/are ");
                m[1].weight = Console.Read();
                Console.WriteLine("\n -And how much does it cost?");
                Console.WriteLine(m[1].name + " cost(`s) ");
                m[1].price = Console.Read();
                Console.WriteLine("\n -Great, I want some");
                Console.WriteLine("\n -Oooh, I am so sorry, but due to new law, we have some additional % on price?");
                Console.WriteLine("\n -Well, how much?");
                Console.WriteLine("\n -Well, it depends on the sort you`ve chose, would you like highsort 1 or 2+% which is:?");
                pricen = Console.Read();
                Console.WriteLine("\n -I would like" + sort);
                Console.WriteLine("\n-Great, then you have to pay:");
                changepmeat(s, pricen, sort, m);
                Console.WriteLine("\n -Fine, thank you!");
                Console.WriteLine("\n -Thank you, see you soon");
            }

            else if (k == 3)
            {
                const int s = 3;
                count = s;
                int pricen;
                Console.WriteLine("\n -So, you`ve chosen dairy products");
                Console.WriteLine("\n -Here we have: ");
                for (int i = 0; i < s; i++)
                {
                    d[i].name = Console.ReadLine();
                }
                Console.WriteLine("\n -And how much does it weight?");
                for (int i = 0; i < s; i++)
                {
                    Console.WriteLine(d[i].name + " is/are ");
                    d[i].weight = Console.Read();
                }
                Console.WriteLine("\n -And how much does it cost?");
                for (int i = 0; i < s; i++)
                {
                    Console.WriteLine(d[i].name + " cost(`s) ");
                    d[i].price = Console.Read();
                }
                Console.WriteLine("\n -Great, I want some: " + p[2].name);
                Console.WriteLine("\n -Oooh, I am so sorry, but due to new law and different leftover time, we may have different price?");
                Console.WriteLine("\n -Exuce me? How much?");
                Console.WriteLine("\n -Wait, can you look on the box, how many days are there written?");
                for (int i = 0; i < s; i++)
                {
                    d[i].termin = Console.Read();
                }
                Console.WriteLine("\n -And % is");
                pricen = Console.Read();
                Console.WriteLine("\n -Then your price is: ");
                changepd(s, pricen, d);
                Console.WriteLine("\n -Thank you, bye!");
                Console.WriteLine("\n -Goodbye!");
            }
            else
            {
                Console.WriteLine("\n-Sorry, I think we don`t have this here.");
            }
        }

        public void output(Product[] p, Meat[] m, Dairy_products[] d)
        {
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine("\nName:" + p[i].name);
            }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("\nName:" + p[i].weight);
            }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("\nName:" + p[i].price);
            }
            
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("\nName:" + m[i].name);
            }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("\nName:" + m[i].weight);
            }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("\nName:" + m[i].price);
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("\nName:" + d[i].name);
            }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("\nName:" + d[i].weight);
            }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("\nName:" + d[i].price);
            }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("\nName:" + d[i].termin);
            }
        }

       

        //Main program
        static void Main(string[] args)
        {
            Meat[] m = new Meat[size];
            Product[] p = new Product[size];
            Dairy_products[] d = new Dairy_products[size];
            Storage s = new Storage();
            int c = s.inicialization_menu();

            if (c == 1)
            {
                s.in_input(p, m, d);
            }
            else if (c == 2)
            {
                s.dial_input(p, m, d);
            }
            else
            {
                Console.WriteLine("\nWrong input");
            }
            s.output(p, m, d);

            //doesn`t work in the end
        }
    }
}
