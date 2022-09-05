using System;
using System.Text;
namespace Lab1
{
    class Program
    {
        private static void Main()
        {
            bool boolVar = false;
            byte byteVar = 12;
            sbyte sByteVar = 39;
            char charVar = 'c';
            decimal decimalVar = 14;
            double doubleVar = 18.23;
            float floatVar = 42.7f;
            Console.WriteLine("Введите целое число: ");
            int intVar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{intVar}");
            uint uIntVar = 0;
            nint nIntVar = -55;
            nuint nUIntVar = 350;
            long longVar = 14551;
            ulong uLongVar = 54314;
            short shortVar = 12;
            ushort uShortVar = 64;

            //Неявные преобразования
            long intToLong = intVar;
            short sbyteToShort = sByteVar;
            int uShortToInt = uShortVar;
            float byteToFloat = byteVar;
            double floatToDouble = floatVar;

            //Явные преобразования
            sbyte byteToSByte = (sbyte)byteVar;
            ulong longToULong = (ulong)longVar;
            int parsable = int.Parse("4124");
            Console.WriteLine(parsable);
            float javni = (float)Convert.ToDouble(intVar);
            int convertable = Convert.ToInt32("14812");

            //Упаковка
            int variable = 123;
            object packing = variable;
            int result = (int)packing; // распаковка

            //Неявная типизация
            var number = 543;
            var stingr = "blabla";
            Console.WriteLine(stingr);

            //Var
            var fff = 78;
            //fff = "blabla" - ошибка компиляции т.к. тип переменной var не может быть изменен после инициализации

            //Nullable
            string? nullable = Console.ReadLine();

            //Строки
            string str = "Hello";
            string str2 = "World";
            //Console.WriteLine(str > str2) - нельзя сравнить строки
            Console.WriteLine(string.Compare(str, str2));
            string str3 = str + str2; // конкатенация
            Console.WriteLine(str3);

            //string copy = str3; - копирование
            string copy = string.Copy(str3);
            Console.WriteLine(copy);

            string str4 = string.Concat("ISiT", " ", "2-1");
            Console.WriteLine(str4);

            //Выделение подстроки
            string str5 = "I love BSTU!!";
            string substring = str5.Substring(7, 4);
            Console.WriteLine(substring);

            //Разделение строки на слова 
            string str6 = "I love BSTU!!";
            string[] words = str6.Split(' ');
            foreach (string i in words)
            {
                Console.WriteLine(i);
            }

            //Вставка подстроки в заданную позицию
            string str7 = "I love Pears!!";
            string str8 = str7.Insert(7, "Pears");
            Console.WriteLine(str8);

            //Удаление подстроки
            string str9 = "I love BSTU!!";
            string str10 = str9.Remove(7, 6);
            Console.WriteLine(str10);

            //Интерполирование строк
            string str11 = "I love BSTU!!";
            string str12 = $"I love {str4}";
            Console.WriteLine(str12);

            //Пустая и null строка
            string empty = "";
            string nullString = null;
            bool trueOrFalse = string.IsNullOrEmpty(empty);
            bool true0rFalse = string.IsNullOrEmpty(nullString);
            Console.WriteLine($"{trueOrFalse} {true0rFalse}");
            Console.WriteLine(string.Concat(empty, nullString)); //пустое значение nullString не выводится т.к. оно не является строкой а значением null

            //StringBuilder - класс для работы со строками (изменение, добавление, удаление)
            StringBuilder stringBuilder = new StringBuilder("Hello");
            Console.WriteLine(stringBuilder);
            stringBuilder.Remove(0, 2);
            stringBuilder.Insert(0, "Hi ");
            stringBuilder.Append("0");
            Console.WriteLine(stringBuilder);

            //Массивы
            //Заполнение матрицы через цикл
            int[,] matrix = new int[3, 3];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = i + j;
                    Console.Write(matrix[i, j] + "   ");
                }
                Console.WriteLine();
            }
            //Массив строк
            string[] strings = { "a pear", "an apple", "a banana" };
            foreach (string i in strings)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(strings.Length);

            //Поменяйте произвольный элемент (пользователь определяет позицию и значение)
            Console.WriteLine("Введите позицию элемента");
            int position = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение элемента");
            strings[position] = Console.ReadLine();
            foreach (string i in strings)
            {
                Console.WriteLine(i);
            }

            //Ступенчатый массив
            int[][] steppedArr = new int[3][] { new int[2], new int[3], new int[4] };
            for (int i = 0; i < steppedArr.Length; i++)
            {
                for (int j = 0; j < steppedArr[i].Length; j++)
                {
                    Console.Write($"steppedArr[{i}][{j}] = ");
                    steppedArr[i][j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < steppedArr.Length; i++)
            {
                Console.WriteLine(String.Join(" ", steppedArr[i]));
            }

            //Неявно типизированные переменные
            var justAnArr = new[] { 1, 2, 3 };
            var justAString = "Good Morning!";

            //Кортежи
            (int, string, char, string, ulong) cortege = (214, "Blade", '2', "film", 1234567890);
            Console.WriteLine(cortege);
            Console.WriteLine(cortege.Item2);
            Console.WriteLine(cortege.Item3);
            Console.WriteLine(cortege.Item4);
            Console.WriteLine(cortege.Item5);

            //Распаковка кортежа в переменные
            var (gam, film, symbol, name, number2) = cortege;
            Console.WriteLine($"{gam} {film} {symbol} {name} {number2}");
            var c0rtege = (x: 45, y: "sg", z: "epiphone");
            Console.WriteLine($"{c0rtege.x} {c0rtege.y} {c0rtege.z}");

            //Использование переменной _
            _ = "chigolder";

            //Сравнение кортежей
            (int, string, char, string, ulong) cortegeTheSecond = (123, "Fury", '5', "neg", 123123412);
            Console.WriteLine(cortege.CompareTo(cortegeTheSecond));

            //Локальная функция в main
            (int, int, int, char) CallCortege(int[] myArr, string myStr)
            {
                return (myArr.Max(), myArr.Min(), myArr.Sum(), myStr[0]);
            }
            Console.Write(CallCortege(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "nix"));

            //Работа с checked/unchecked
            int func1()
            {
                checked {

                    //int maxInt = int.MaxValue + 1;
                    return 0;
                       }
            }
            int func2()
            {
                unchecked
                {
                    int maxInt = int.MaxValue + 1;
                    return maxInt;
                }
            }
            Console.WriteLine($"Функция 1: {func1()}");
            Console.WriteLine($"Функция 2: {func2()}");
            

        }
    }
}