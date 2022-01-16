using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba13._2
{
    class Shop
    {
        private string name;
        private int check;
        private int potrsum;
        private int tovar;
        private string sales;
        private int sizesale;
        public Shop(string name, int check, int potrsum, int tovar, string sales, int sizesale)
        {
            this.name = name;
            this.check= check;
            this.potrsum = potrsum;
            this.tovar = tovar;
            this.sales = sales;
            this.sizesale = sizesale;
        }
        public int Check
        {
            get { return check; }
            set
            {
                if (value < 1 || value > 100)
                {
                    check = value;
                }
                else { throw new FunctionsExeption("Чек от 0 до 100 рублей "); }
            }
        }
        public int Potrsum
        {
            get { return potrsum; }
            set
            {
                if (value < 1 || value > 300)
                {
                    potrsum = value;
                }
                else { throw new FunctionsExeption("Потраченная сумма начинается от 1 и до 300 "); }
            }
        }
        public int Tovar
        {
            get { return tovar; }
            set
            {
                if (value < 1 || value > 500)
                {
                    tovar = value;
                }
                else { throw new FunctionsExeption("Количество купленных позиций начинается от 1 и до 500 "); }
            }
        }
        public int Sizesale
        {
            get { return sizesale; }
            set
            {
                if (value == 7  || value == 10)
                {
                    sizesale = value;
                }
                else { throw new FunctionsExeption("Скидка 10% на день рождение или 7 постоянным"); }
            }
        }
        public void Input()
        {
            Console.WriteLine("Введите название магазина");
            name = Console.ReadLine();
            Console.WriteLine("Введите чек посетителя");
            check = Convert.ToInt32(Console.ReadLine());
            if (check < 1 || check > 100) throw new FunctionsExeption("Чек от 0 до 100 рублей");
            Console.WriteLine("Введите потраченную сумму в прошлом месяце");
            potrsum = Convert.ToInt32(Console.ReadLine());
            if (potrsum < 1 || potrsum > 300) throw new FunctionsExeption("Потраченная сумма начинается от 1 и до 300");
            Console.WriteLine("Введите купленных позиций");
            Tovar = Convert.ToInt32(Console.ReadLine());
            if (tovar < 1 || tovar > 500) throw new FunctionsExeption("Количество купленных позиций начинается от 1 и до 500 ");
            Console.WriteLine("Имелиется ли скидка?");
            sales = Console.ReadLine();
            Console.WriteLine("Если др - 10% скидка, если постоянный клиент - 7%\n У вас день рождение? 1-Да. Постоянный клиент? 2- Да. 0 -ничего");
            sizesale = Convert.ToInt32(Console.ReadLine());
            if (sizesale != 1 || sizesale != 2 || sizesale != 0) throw new FunctionsExeption("Количество купленных позиций начинается от 1 и до 500 ");
        }
        public override string ToString()
        {
            return "Название магазина: " + name + "Чек посетителя: " + Check + "Потраченная сумма в прошлом месяце: " + Potrsum + "Количество купленных позиций: " + Tovar + "Есть ли скидка: " + sales;
        }
        public void Itogsum()
        {
            if (Sizesale == 10)
            {
                Console.WriteLine(check % 10);
            }
            if (Sizesale == 7)
            {
                Console.WriteLine(check % 7);
            }
            else { Console.WriteLine($"Скидки нет: {check}"); }
        }

    }
}
