class TestClass
{
    static void Main(string[] args)
    {   
        //Флаг для цикла
        start:


        System.Console.Write("Enter name Alex: ");      //Вводим имя указаное в тексте (не важно какой регистр)
        String user = System.Console.ReadLine();

        //Если имя = alex - то выполняем следующий код
        if (user.ToLower() == "alex") {
            System.Console.WriteLine("Hello, alex!");

            //Просто счетчик с числом, при достижении которого будет выводится надпись с поздравлением
            System.Console.WriteLine("\nKeep pressing ENTER to increase the number to 100 or ESC to the exit: ");

            //Пока счетчик = 0, цикл будет продолжаться
            for (int i = 0; i <= 100; i++) {
                var key = Console.ReadKey();                    //Создаем переменную с клавишей
                ConsoleKeyInfo cki = new ConsoleKeyInfo();      //Инициализируем ключ-клавишу

                System.Console.Write("number: " + i);           //Просто счетчик

                if (key.Key == ConsoleKey.Escape) {             //при нажатии на ESC - консоль будет закрываться
                    Environment.Exit(0);
                }
            }

            //Когда достиг числа 100
            System.Console.Write("\n\nCongratulations! You have reached 100!");
            Console.ReadKey();
        }

        //Иначе будет выводить что имя указано не верно
        else {
            Console.Write("\nERR >> Wrong user name!");
            Console.ReadKey();
            Console.Clear();
            goto start;         //Знаю что не правильно использовать флаги, но ктож меня отсановит?)
        }
    }
}