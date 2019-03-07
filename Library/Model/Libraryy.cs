using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace Library.Model
{
    public class Libraryy
    {
        static void return_()
        {
            Libraryy lib = new Libraryy();

        }
        public Libraryy()
        {
            UserMenu userMenu = new UserMenu();
            User user = new User("Ruslan", "admin", "admin");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n1)Админ\n2)Читатель");
            int sw1 = Int32.Parse(Console.ReadLine());
            Console.Clear();
            switch (sw1)
            {
                
                case 1: Console.ForegroundColor = ConsoleColor.Green;
                     Admin admin = new Admin(user.login, user.password, user.name);
                    AdminMenu adminMenu = new AdminMenu(admin);
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("1)Зарегестрироваться\n2)Войти");

                    int sw2 = Int32.Parse(Console.ReadLine());
                    switch (sw2)
                    {
                        case 1:
                            userMenu.Registration(user, out string message);
                            return_();
                            break;
                        case 2: userMenu.LogOn(user.login, user.password, out string message_);
                            Reader reader = new Reader(user.login, user.password, user.name, "ooo", "ooo", "ooo", true);
                            ReaderMenu readerMenu = new ReaderMenu(reader);
                            return_();
                            break;
                    }
                    break;
                  


            }

        }
    }
}
