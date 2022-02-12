using System;


namespace OOPHW1
{
    class Program
    {
        static Dictionary<string, string[]> dataBase = new Dictionary<string, string[]>();
        static void Main(string[] args)
        {

            #region task2
            //Product chips = new Product("Lays", 12.85, 100);

            //Console.WriteLine(chips.Info());
            //chips.Sell();
            //Console.WriteLine(chips.Info());
            //Console.WriteLine(Product.TotalIncome);

            //Milk palSud = new Milk("Pal Sud",22.85,30,1.5,3.2);

            //Console.WriteLine(palSud.Info());
            //palSud.Sell();
            //Console.WriteLine(palSud.Info());
            //Console.WriteLine(Milk.TotalIncome);
            #endregion

            #region Gunel lab Task Dynamic Product add
            
            
            
            while (true)
            {
                int choice = Menu();
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Product Name - ");
                        string name = Console.ReadLine();
                        Console.Write("Price - ");
                        double.TryParse(Console.ReadLine(), out double price);
                        Console.Write("Count - ");
                        int.TryParse(Console.ReadLine(), out int count);
                        CreateProduct(name, price, count);
                     
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Enter product name: ");
                        string rmprod = Console.ReadLine();
                        DeleteProduct(rmprod);
                        Console.WriteLine("Product Deleted!");
                        break;
                    case 3:
                        Console.Write("Enter product name: ");
                        string chginfo = Console.ReadLine();
                        Console.WriteLine(dataBase[chginfo]);
                        ChangeProductInfo(chginfo);
                        Console.WriteLine("Product Changed");
                        break;
                    case 4:
                        Console.WriteLine("DataBASE:");
                        ShowDB();
                        break;
                    case 5:
                        break;




                }
            }
            

            #endregion
        }


        static int Menu()
        {
            Console.WriteLine("Choose Operation: ");
            Console.WriteLine("1. Add New Product");
            Console.WriteLine("2. Delete Product from DB");
            Console.WriteLine("3. Change Product info");
            Console.WriteLine("4. Show Database");
            Console.WriteLine("5. Exit");

            int.TryParse(Console.ReadLine(), out int choice);
            return choice;
        }

        static void CreateProduct(string name, double price, int count)
        {
            Product product = new Product(name, price, count);
            string price_str, count_str;
            price_str = price.ToString();
            count_str = count.ToString();
            
            dataBase.Add(name,new[] {price_str,count_str});


        }

        static void DeleteProduct(string name)
        {
            dataBase.Remove(name);
        }

        static void ChangeProductInfo(string name)
        {
            Console.Write("Choose what you want to change(price,count): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "price":
                    Console.WriteLine("Enter new price: ");
                    string price = Console.ReadLine();
                    string[] info = dataBase[name];
                    info[0] = price;
                    dataBase[name] = info;
                    Console.WriteLine(dataBase[name]);
                    break;
                case "count":
                    Console.WriteLine("Enter new count: ");
                    string count = Console.ReadLine();
                    string[] count_info = dataBase[name];
                    count_info[1] = count;
                    dataBase[name] = count_info;
                    Console.WriteLine(dataBase[name]);
                    break;
            }
        }

        static void ShowDB()
        {
            foreach (var item in dataBase)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine($"Price- {item.Value[0]}");
                Console.WriteLine($"Count - {item.Value[1]}");
            }
        }
    }
}