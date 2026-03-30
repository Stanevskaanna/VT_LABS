namespace LAB03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Задание 1.1 (Код проверки пишем ниже)
            Rational r1 = new Rational(3, 8);
            Console.WriteLine(r1);

            // Задание 1.2 (Код проверки пишем ниже)
            Rational r2 = new Rational(4);
            Console.WriteLine(r2);


            // Задание 1.3 (Код проверки пишем ниже)
            Rational r3 = new Rational();
            Console.WriteLine(r3);


            // Задание 1.4 (Код проверки пишем ниже)
            //Rational r4 = new Rational(3, 0);
            //ConsoleWriteLine(r4);


            // Задание 2.1 (Код проверки пишем ниже)
            Rational r21 = new Rational(4, 8);
            Console.WriteLine(r21);

            // Задание 2.2 (Код проверки пишем ниже)
            Rational r22 = new Rational(4, -9);
            Console.WriteLine(r22);
            Rational r23 = new Rational(-2, -10);
            Console.WriteLine(r23);

            // Задание 3.1 (Код проверки пишем ниже)
            
            Console.WriteLine(r1 + r2);
            Console.WriteLine(r1 - r3);
            Console.WriteLine(r1 * r3);
            Console.WriteLine(r1 / r2);


            // Задание 3.2 (Код проверки пишем ниже)
            Console.WriteLine(r1 == r2);
            Console.WriteLine(r1 != r2);
        }
    }
}

    
