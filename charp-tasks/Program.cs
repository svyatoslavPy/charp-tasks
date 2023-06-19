namespace ConsoleApp3
{
    class Program
    {
        static void SumAvarage(int oneNum, int twoNum, int threeNum)
        {
            int sum = oneNum + twoNum + threeNum;
            int avarage = sum / 3;
            Console.WriteLine("Cреднее арифметическое: " + avarage);
        }

     
        static void Main(string[] args)
        {
            #region avarage task
            Console.WriteLine("Введите первое число: ");
            int oneNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int twoNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число: ");
            int threeNum = Convert.ToInt32(Console.ReadLine());
            SumAvarage(oneNum, twoNum, threeNum);
            #endregion

            #region degree task
            Console.WriteLine("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите степень: ");
            int degree = Convert.ToInt32(Console.ReadLine());
            int result = num;

            for (int i = 1; i < degree; i++)
            {
                result *= num;
  
            }
            Console.WriteLine(result);
            #endregion

            #region converter currency
            Console.WriteLine("Введите кол-во uah: ");
            int uah = Convert.ToInt32(Console.ReadLine());
            int uahToUsd = uah / 36;
            int uahToEuro = uah / 40;

            Console.WriteLine("USD - " + "$" + uahToUsd);
            Console.WriteLine("Euro - " + "€" + uahToEuro);

            #endregion

            #region  KM
            Console.WriteLine("Введите километры: ");
            double km = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("КМ - Морские мили" + km * 0.53);
            Console.WriteLine("КМ - Сухопутные мили" + km * 0.62);
            #endregion

            #region процент от числа P

            Console.WriteLine("Введите число n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число p: ");
            int p = Convert.ToInt32(Console.ReadLine());
           
            int resP = n / 100 * p;
            Console.WriteLine(resP);

            #endregion

            #region перевод градусов

            Console.WriteLine("Введите градусы по Цельсию в градусы по шкале Фарангейта");
            double C = Convert.ToDouble(Console.ReadLine());
            double resultF = C * 1.8 + 32;
            double resultFtoC = (resultF - 32) / 1.8;

            Console.WriteLine(resultF);
            Console.WriteLine("Перевести обратно градусы по Цельсию?");
            string? operation = Console.ReadLine();

            if (operation == "Да")
            {
                Console.WriteLine(resultFtoC);
            }
            else
            {
                Console.WriteLine("Попробуйте еще раз");
            }

            #endregion

        }
    }
}