//Одномерные массивы. Плотников Кирилл Андреевич 22-ИСП-2/2
//№варианта:16
//Массив задан датчиком случайных чисел на интервале  [–33,  66]. Найти наименьший нечетный элемент.

Console.ForegroundColor = ConsoleColor.Yellow;

int n = 100;
int[] mas = new int[n];
Random random = new Random();
for (int i = 0; i < n; i++)
{
    mas[i] = random.Next(-33,66);
    Console.Write(mas[i]+" ");
}

Console.ForegroundColor = ConsoleColor.Red;

Console.WriteLine("Наименьший нечетный элемент:" +Enumerable.Range(0, n).Select(x => random.Next(-33, 66)).Where(x => x % 2 == 1).Min());

Console.ForegroundColor = ConsoleColor.Green;
