﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
namespace Library.Model
{
   public class ReaderMenu
    {
        static void return_()
        {
            Libraryy lib = new Libraryy();

        }
        public ReaderMenu(Reader reader)
        {
            ReaderService readerService = new ReaderService();
            Console.WriteLine("1)Добавить книгу\n2)Найти книгу\n3)назад");

            int sw = Int32.Parse(Console.ReadLine());
            Console.Clear();

            switch (sw)
            {
                case 1:
                    readerService.CreateNewBookReader(reader);
                    return_();
                        break;
                case 2:
                    readerService.FindBook();
                    return_();
                    break;
                case 3:
                    return_();
                    break;


            }
        }
    }
}
