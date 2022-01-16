using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_14._1
{
    class Notebook
    {
        private int paper;
        public Notebook(int paper)  
        {
            Create += PrintA;
            Create(this, new NotebookEventArgs("Объект создан"));
            this.paper = paper;

        }
        delegate void NotebookEvent(object obj, NotebookEventArgs m);
        event NotebookEvent Create; 
        public int Paper
        {
            get { return paper; }
            set
            {
                if (value > 1)
                {
                    paper = value;
                }
                else
                {
                    throw new FunctionsExeption("Неверно");
                }
            }
        }
        static void PrintA(object obj, NotebookEventArgs s)
        {
            Console.WriteLine(s.message);
        }

        public void Input()
        {
            Console.WriteLine("Введите количество листов");
            paper = Convert.ToInt32(Console.ReadLine());
            if (paper < 1 ) throw new FunctionsExeption("Номер невернный");
        }
        public void virvat()
        {
            Console.WriteLine("Введите количество вырванных листов");
            int k = Convert.ToInt32(Console.ReadLine());
            if(k > paper) throw new FunctionsExeption("Столько нет листов");
            else
            {
                paper = paper - k;
                Console.WriteLine(paper);
            }

        }
        public void vkleit()
        {
            Console.WriteLine("Введите количество вклеиных листов");
            int k = Convert.ToInt32(Console.ReadLine());
            if (k < 0) throw new FunctionsExeption("Вклейти листы");
            else
            {
                paper = paper + k;
                Console.WriteLine(paper);
            }
        }
        

}
}
