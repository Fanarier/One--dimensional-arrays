int count = 50;
Random rnd = new Random();
Console.WriteLine("Наименьший нечетный элемент:" +Enumerable.Range(0, count).Select(x => rnd.Next(-33, 66)).Where(x => x % 2 == 1).Min());
