using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_3_Operators
{
    public partial class Practice
    {
        /// <summary>
        /// B3-P1/5. NumbersAddition. Напишите алгоритм, который складывает два числа.
        /// </summary>
        public static void B3_P1_9_NumbersAddition()
        {
            Console.WriteLine("Enter the number x");
            int x =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number y");
            int y = int.Parse(Console.ReadLine());
            int z = x + y;
            Console.WriteLine("The sum of the numbers is " + $"{z}");
        }

        /// <summary>
        /// B3-P2/9. CheckResultAddition. Изменить предыдущий алгоритм. 
        /// Пускай он теперь не выводит ответ сам. 
        /// А запрашивает ответ и потом проверяет его на правильность.
        /// </summary>
        public static void B3_P2_9_CheckResultAddition()
        {
            Console.WriteLine("Enter the number x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number y");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the sum of the numbers?");
            if (int.Parse(Console.ReadLine()) == x+y)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            
        }

        /// <summary>
        /// B3-P3/9. CheckResultAdditionWithTips. Изменить предыдущий алгоритм. 
        /// Пускай он теперь выводит не только информацию правильно или не правильно, 
        /// но и дополнительно, 	ожидается число больше или меньше указанного.
        /// </summary>
        public static void B3_P3_9_CheckResultAdditionWithTips()
        {
            Console.WriteLine("Enter the number x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number y");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the sum of the numbers?");
            int answer = int.Parse(Console.ReadLine());
            if (answer == x + y)
            {
                Console.WriteLine("True");
            }
            else if (answer > x + y)
            {
                Console.WriteLine("Must be less");
            }
            else
            {
                Console.WriteLine("Must be more");
            }

        }

        /// <summary>
        /// B3-P4/9. CheckResultWithOperator. Изменить предыдущий алгоритм. 
        /// Пускай алгоритм теперь запрашивает оператор (+ или -).
        /// </summary>
        public static void B3_P4_9_CheckResultWithOperator()
        {
            int result=0;
            Console.WriteLine("Enter the number x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number y");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("operator (+ or -)");
            string sumbol= Console.ReadLine();
            Console.WriteLine("enter the result of the operation");
            int answer = int.Parse(Console.ReadLine());
            if (sumbol == "+")
            {
                result = x + y;
            }
            else
            {
                result = x - y;
            }
            if (answer == result)
            {
                Console.WriteLine("True");
            }
            else if (answer > result)
            {
                Console.WriteLine("Must be less");
            }
            else
            {
                Console.WriteLine("Must be more");
            }
        }

        /// <summary>
        /// B3-P5/9. CheckResultWithAttemps. Изменить предыдущий алгоритм. 
        /// Пускай у пользователя будет 3 попытки чтобы решить эту задачу правильно
        /// </summary>
        public static void B3_P5_9_CheckResultWithAttemps()
        {
            int result = 0;
            Console.WriteLine("Enter the number x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number y");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("operator (+ or -)");
            string sumbol = Console.ReadLine();
            if (sumbol == "+")
            {
                result = x + y;
            }
            else
            {
                result = x - y;
            }
            for (int i=0; i<3;i++)
            {
                Console.WriteLine("enter the result of the operation.Number of attempts:" +$"{3-i}");
                int answer = int.Parse(Console.ReadLine());
                if (answer == result)
                {
                    Console.WriteLine("True");
                    break;
                }
                else if (answer > result)
                {
                    Console.WriteLine("Must be less");
                }
                else
                {
                    Console.WriteLine("Must be more");
                }
            }

        }

        /// <summary>
        /// B3-P6/9. FiveNumbersAddition. Изменить предыдущий алгоритм. 
        /// Пускай алгоритм складывает пять чисел вместо двух.
        /// </summary>
        public static void B3_P6_9_FiveNumbersAddition()
        {
            int result = 0;
            for (int i = 0; i < 5; ++i)
            {
                Console.WriteLine("Enter the number" +$"{i+1}");
                result += int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter the result of the sum of numbers.Number of attempts:" + $"{3 - i}");
                int answer = int.Parse(Console.ReadLine());
                if (answer == result)
                {
                    Console.WriteLine("True");
                    break;
                }
                else if (answer > result)
                {
                    Console.WriteLine("Must be less");
                }
                else
                {
                    Console.WriteLine("Must be more");
                }
            }
        }

        /// <summary>
        /// B3-P7/9. NumbersResultWithInfoIfCorrect. Изменить предыдущий алгоритм. 
        /// В конце алгоритма выводить информацию была ли задача решена правильно.
        /// </summary>
        public static void B3_P7_9_NumbersResultWithInfoIfCorrect()
        {
            int result = 0;
            for (int i = 0; i < 5; ++i)
            {
                Console.WriteLine("Enter the number" + $"{i + 1}");
                result += int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter the result of the sum of numbers.Number of attempts:" + $"{3 - i}");
                int answer = int.Parse(Console.ReadLine());
                if (answer == result)
                {
                    Console.WriteLine("True");
                    break;
                }
                else if (answer > result)
                {
                    Console.WriteLine("Must be less");
                }
                else
                {
                    Console.WriteLine("Must be more");
                }
                if (i==2)
                {
                    Console.WriteLine("Task solved incorrectly. Try again");
                }
            }

        }

        /// <summary>
        /// B3-P8/9. CircleArea. Написать алгоритм, рассчитывающий площадь круга по заданному радиусу. 
        /// </summary>
        public static void B3_P8_9_CircleArea()
        {
            Console.WriteLine("Введите радиус круга:");
            string radiusstring = Console.ReadLine();
            double radius = double.Parse(radiusstring.Replace(",","."));
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("Площадь круга:" +$"{area}");

        }

        /// <summary>
        /// B3-P9/9. CreaditCalculator.Написать программу - калькулятор кредита на 1 год.
        /// </summary>
        public static void B3_P9_9_CreaditCalculator()
        {
            Console.WriteLine("Введите сумму кредита:");
            int sumCredit=int.Parse(Console.ReadLine());
            Console.WriteLine("Введите % под который берется кредит:");
            int percentCredit = int.Parse(Console.ReadLine());
            int sumAndPercent = sumCredit + (sumCredit * percentCredit / 100);
            Console.WriteLine("Выплаты по месяцам:");
           // int i;
            double totalPay=0;
            int i=0;
            for (i = 0; i < 12; i++)
            {
                double pay = Math.Round(sumAndPercent / 12.0, 2);
                Console.WriteLine($"{i+1}"+" месяц "+$"{pay}");
                totalPay += pay;
            }
            Console.WriteLine("Общая сумма выплат составит:" +$"{totalPay}"+" руб.");
        }
    }
}
