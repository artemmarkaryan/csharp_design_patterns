using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        /*Конструктор singleton всегда должен быть скрытым, чтобы предотвратить создание объекта через оператор new. */
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.Instance;
            singleton.DoSomething();
        }
    }
    public class Singleton
    {
        /* Это статический метод, управляющий доступом к экземпляру одиночки.
        При первом запуске, он создаёт экземпляр одиночки и помещает его в
        статическое поле. При последующих запусках, он возвращает клиенту
        объект, хранящийся в статическом поле. */
        private static Singleton instance = null;
        private Singleton() { }
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
        public void DoSomething()
        {
            Console.WriteLine("Singleton class code has been called");
            Console.ReadLine();
        }

    }
}