using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOnlineStore {
    class Program {
        static void Main(string[] args) {
            Menu.MenuMethod();
            Console.ReadLine();
        }
        //класс меню
        class Menu {
            //меню
            public static void MenuMethod() {
                char O;
                Console.WriteLine("Выберите пункт меню: ");
                Console.WriteLine("1. Просмотреть список товаров");
                Console.WriteLine("2. Добавить новый товар");
                Console.WriteLine("0. Вернуться в меню");
                do {
                    char sKey = Console.ReadKey().KeyChar;
                    O = sKey;
                    switch (sKey) {
                        case '1':
                            Console.Clear();
                            Console.WriteLine("Список товаров: ");
                            Add add = new Add();
                            add.onShow();
                            break;
                        case '2':
                            Console.Clear();
                            Console.WriteLine("Добавить новый товар");
                            Add create = new Add();
                            create.onCreate();
                            break;
                        case '0':
                            break;
                    }
                }
                while (O != 'o');
            }
        }
        //общий класс добавления информации о товарах и создании нового заказа
        public abstract class Base {
            public abstract void onShow();  //метод добавления информации о товарах
            public abstract void onCreate();    //метод создания и оплаты заказов
        }
        //класс добавления новой информации о товаре
        class Add : Base {
            //метод отображения списка товаров
            public override void onShow() {
                ArrayList list = new ArrayList();
                list.Add("Война и мир \n");
                list.Add("Вокруг реки толика жизни \n");
                list.Add("Программирование на C# \n");
                int nCount = 0;
                foreach (var item in list) {
                    nCount++;
                    Console.Write(nCount);
                    Console.Write(". " + item);
                }
            }
            //метод создания товара
            public override void onCreate() {
                ArrayList list = new ArrayList();   //коллекция с товарами
                Console.WriteLine("Введите новый товар:");
                var addItem = Console.ReadLine();   //добавляем новый товар с клавиатуры
                list.Add(addItem);
                int nCount = 0; //счетчик номера товара
                //цикл для перебора товаров
                foreach (var item in list) {
                    nCount++;
                    Console.Write(nCount);  //выводим номер товара
                    Console.Write(". " + item); //вывод товаров
                }
            }
        }
    }
}
