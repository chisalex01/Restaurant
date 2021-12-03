using System;
using Restaurant.Menu.Pizza;
using Restaurant.Menu.Pasta;
using Restaurant.Menu.Desert;
using Restaurant.Menu.Sauce;
using Restaurant.Menu.Meat;
using Restaurant.Menu.Drinks;
using Restaurant.Menu.SideDish;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        static bool MainMenu()
        {
            Product capriciosa = PizzaFactory.MakePizza(PizzaType.Capriciosa);
            Product quattroStagioni = PizzaFactory.MakePizza(PizzaType.QuattroStagioni);
            Product margherita = PizzaFactory.MakePizza(PizzaType.Margherita);
            Product prosciutoFunghi = PizzaFactory.MakePizza(PizzaType.ProsciutoEFunghi);
            Product carbonara = PastaFactory.MakePasta(PastaType.Carbonara);
            Product seaFood = PastaFactory.MakePasta(PastaType.SeaFood);
            Product gnochi = PastaFactory.MakePasta(PastaType.Gnochi);
            Product quattroFormaggi = PastaFactory.MakePasta(PastaType.QuattroFormaggi);
            Product chicken = MeatFactory.MakeMeat(MeatType.Chicken);
            Product duck = MeatFactory.MakeMeat(MeatType.Duck);
            Product hamburger = MeatFactory.MakeMeat(MeatType.Hamburger);
            Product steak = MeatFactory.MakeMeat(MeatType.Steak);
            Product frenchFries = SideDishFactory.MakeSideDish(SideDishType.FrenchFries);
            Product rice = SideDishFactory.MakeSideDish(SideDishType.Rice);
            Product mashedPotatoes = SideDishFactory.MakeSideDish(SideDishType.MashedPotatoes);
            Product ketchup = SauceFactory.MakeSauce(SauceType.Ketchup);
            Product mayo = SauceFactory.MakeSauce(SauceType.Mayo);
            Product tzatziki = SauceFactory.MakeSauce(SauceType.Tzatziki);
            Product lavaCake = DesertFactory.MakeDesert(DesertType.LavaCake);
            Product iceCream = DesertFactory.MakeDesert(DesertType.IceCream);
            Product water = DrinkFactory.MakeDrink(DrinkType.Water);
            Product cola = DrinkFactory.MakeDrink(DrinkType.Cola);
            Product lemonade = DrinkFactory.MakeDrink(DrinkType.Lemonade);
            Product fresh = DrinkFactory.MakeDrink(DrinkType.Fresh);
            Cart cart = new Cart();

            int bill = 0;
            
            cart.addProduct(margherita);

            Console.Clear();
            Console.WriteLine("Choose a category:");
            Console.WriteLine("1) Pizza");
            Console.WriteLine("2) Pasta");
            Console.WriteLine("3) Meat");
            Console.WriteLine("4) Side dish");
            Console.WriteLine("5) Sauce/Dressing");
            Console.WriteLine("6) Desert");
            Console.WriteLine("7) Drinks");
            Console.WriteLine("\r\n8) Go to cart");
            Console.WriteLine("9) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Choose a category:");
                    Console.WriteLine("1) Capriciosa\n   Ingredients: tomato sauce, mozzarella, ham, bacon, salami, mushrooms, onion, red pepper, olive\n" + "   Price: " + capriciosa.Price + "$\n");
                    Console.WriteLine("2) Quattro stagioni\n   Ingredients: tomato sauce, mozzarella, salami, ham, olives, mushrooms\n" + "   Price: " + quattroStagioni.Price + "$\n");
                    Console.WriteLine("3) Margherita\n   Ingredients: tomato sauce, mozzarella\n" + "   Price: " + margherita.Price + "$\n");
                    Console.WriteLine("4) Prosciuto e funghi\n   Ingredients: tomato sauce, mozzarella, ham, mushrooms\n" + "   Price: " + prosciutoFunghi.Price + "$\n");
                    Console.WriteLine("\r\n5) Back");

                    Console.Write("\r\nSelect an option: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            cart.addProduct(capriciosa);
                            bill +=capriciosa.Price;
                            return true;
                        case "2":
                            cart.addProduct(quattroStagioni);
                            bill += quattroStagioni.Price;
                            return true;
                        case "3":
                            cart.addProduct(margherita);
                            bill += margherita.Price;
                            return true;
                        case "4":
                            cart.addProduct(prosciutoFunghi);
                            bill += prosciutoFunghi.Price;
                            return true;
                        case "5":
                            MainMenu();
                            return false;
                        default:
                            Error();
                            return true;
                    }

                case "2":
                    Console.Clear();
                    Console.WriteLine("Choose a category:");
                    Console.WriteLine("1) Carbonara\n   Ingredients: pasta, bacon, sour cream, egg, parmesan, salt, pepper, oil olives\n" + "   Price: " + carbonara.Price + "$\n");
                    Console.WriteLine("2) Sea food\n   Ingredients: butter, garlic, lemon juice, white wine, parsley, salt, pepper\n" + "   Price: " + seaFood.Price + "$\n");
                    Console.WriteLine("3) Gnochi\n   Ingredients: potatoes, egg, parmesan\n" + "   Price: " + gnochi.Price + "$\n");
                    Console.WriteLine("4) Quattro formaggi\n   Ingredients: thyme, pepper, mozzarela, gorgonzola, fontina, parmegiano\n" + "   Price: " + quattroFormaggi.Price + "$\n");
                    Console.WriteLine("\r\n5) Back");

                    Console.Write("\r\nSelect an option: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            cart.addProduct(carbonara);
                            bill += carbonara.Price;
                            return true;
                        case "2":
                            cart.addProduct(seaFood);
                            bill += seaFood.Price;
                            return true;
                        case "3":
                            cart.addProduct(gnochi);
                            bill += gnochi.Price;
                            return true;
                        case "4":
                            cart.addProduct(quattroFormaggi);
                            bill += quattroFormaggi.Price;
                            return true;
                        case "5":
                            MainMenu();
                            return false;
                        default:
                            Error();
                            return true;
                    }
                case "3":
                    Console.Clear();
                    Console.WriteLine("Choose a category:");
                    Console.WriteLine("1) Chicken\n   Price: " + chicken.Price + "$\n");
                    Console.WriteLine("2) Duck\n   Price: " + duck.Price + "$\n");
                    Console.WriteLine("3) Hamburger\n   Price: " + hamburger.Price + "$\n");
                    Console.WriteLine("4) Steak\n   Price: " + steak.Price + "$\n");
                    Console.WriteLine("\r\n5) Back");

                    Console.Write("\r\nSelect an option: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            cart.addProduct(chicken);
                            bill += chicken.Price;
                            return true;
                        case "2":
                            cart.addProduct(duck);
                            bill += duck.Price;
                            return true;
                        case "3":
                            cart.addProduct(hamburger);
                            bill += hamburger.Price;
                            return true;
                        case "4":
                            cart.addProduct(steak);
                            bill += steak.Price;
                            return true;
                        case "5":
                            MainMenu();
                            return false;
                        default:
                            Error();
                            return true;
                    }
                case "4":
                    Console.Clear();
                    Console.WriteLine("Choose a category:");
                    Console.WriteLine("1) French fries\n   Price: " + frenchFries.Price + "$\n");
                    Console.WriteLine("2) Rice\n   Price: " + rice.Price + "$\n");
                    Console.WriteLine("3) Mashed Potatoes\n   Price: " + mashedPotatoes.Price + "$\n");
                    Console.WriteLine("\r\n4) Back");

                    Console.Write("\r\nSelect an option: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            cart.addProduct(frenchFries);
                            bill += frenchFries.Price;
                            return true;
                        case "2":
                            cart.addProduct(rice);
                            bill += rice.Price;
                            return true;
                        case "3":
                            cart.addProduct(mashedPotatoes);
                            bill += mashedPotatoes.Price;
                            return true;
                        case "4":
                            MainMenu();
                            return false;
                        default:
                            Error();
                            return true;
                    }
                case "5":
                    Console.Clear();
                    Console.WriteLine("Choose a category:");
                    Console.WriteLine("1) Ketchup\n   Price: " + ketchup.Price + "$\n");
                    Console.WriteLine("2) Mayo\n   Price: " + mayo.Price + "$\n");
                    Console.WriteLine("3) Tzatziki\n   Price: " + tzatziki.Price + "$\n");
                    Console.WriteLine("\r\n4) Back");

                    Console.Write("\r\nSelect an option: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            cart.addProduct(ketchup);
                            bill += ketchup.Price;
                            return true;
                        case "2":
                            cart.addProduct(mayo);
                            bill += mayo.Price;
                            return true;
                        case "3":
                            cart.addProduct(tzatziki);
                            bill += tzatziki.Price;
                            return true;
                        case "4":
                            MainMenu();
                            return false;
                        default:
                            Error();
                            return true;
                    }
                case "6":
                    Console.Clear();
                    Console.WriteLine("Choose a category:");
                    Console.WriteLine("1) Lava Cake\n   Ingredients: dark chocolate, butter, sugar powder, flour, egg, vanilla\n" + "   Price: " + lavaCake.Price + "$\n");
                    Console.WriteLine("2) Ice Cream\n   Ingredients: whipped cream, milk, egg, sugar\n" + "   Price: " + iceCream.Price + "$\n");
                    Console.WriteLine("\r\n3) Back");

                    Console.Write("\r\nSelect an option: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            cart.addProduct(lavaCake);
                            bill += lavaCake.Price;
                            return true;
                        case "2":
                            cart.addProduct(iceCream);
                            bill += iceCream.Price;
                            return true;
                        case "3":
                            MainMenu();
                            return false;
                        default:
                            Error();
                            return true;
                    }
                case "7":
                    Console.Clear();
                    Console.WriteLine("Choose a category:");
                    Console.WriteLine("1) Water\n   Price: " + water.Price + "$\n");
                    Console.WriteLine("2) Cola\n    Price: " + cola.Price + "$\n");
                    Console.WriteLine("3) Lemonade\n    Price: " + lemonade.Price + "$\n");
                    Console.WriteLine("4) Fresh\n   Price: " + fresh.Price + "$\n");
                    Console.WriteLine("\r\n5) Back");

                    Console.Write("\r\nSelect an option: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            cart.addProduct(water);
                            bill += water.Price;
                            return true;
                        case "2":
                            cart.addProduct(cola);
                            bill += cola.Price;
                            return true;
                        case "3":
                            cart.addProduct(lemonade);
                            bill += lemonade.Price;
                            return true;
                        case "4":
                            cart.addProduct(fresh);
                            bill += fresh.Price;
                            return true;
                        case "5":
                            MainMenu();
                            return false;
                        default:
                            Error();
                            return true;
                    }
                case "8":
                    Console.Clear();
                    Console.WriteLine(cart);
                    Console.WriteLine("Your total is: " + bill + "$");
                    Console.WriteLine("Press ENTER to go back");
                    switch (Console.ReadLine())
                    {
                        case "":
                            MainMenu();
                            return false;
                        default:
                            Error();
                            return true;
                    }
                case "9":
                    return false;
                default:
                    Error();
                    return true;
            }
        }

            static void Error()
            {
                Console.WriteLine("\r\nOption not available! Choose one of the options above!");
                Console.Write("\r\nPress Enter to choose an option");
                Console.ReadLine();
                MainMenu();
            }
    }
}
