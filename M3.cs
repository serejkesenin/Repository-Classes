class Stupenchatye
{
   public Stupenchatye(int m, bool choice)
  {
      int[][] mass = new int[m][];
      if (choice)
      {
          InputArray_user(m, mass);
      }
      else
      {
          InputArray(m, mass);
      }
      Console.WriteLine("Массив:");
      PrintArray(mass);
      Console.WriteLine("Все элементы, четные по значению равны произведению их индексов");
      EditArray(mass);
      PrintArray(mass);
      Console.WriteLine("Среднее значение по массиву");
      Console.WriteLine(AveRage(mass));
      Console.WriteLine("Среднее значение во вложенных массивах");
      AveRage_inside(mass);

  }
    static int[][] InputArray_user(int n, int[][] j_array)
{
  for (int i = 0; i<n;i++)
  {
      Console.Write($"Введите длину {i+1} строки: ");
      int len = int.Parse(Console.ReadLine());
      j_array[i] = new int[len];
      for (int j = 0; j < len; j++)
      {
          Console.Write($"Элемент [{i},{j}]: ");
          j_array[i][j] = Convert.ToInt32(Console.ReadLine());
      }
  }
  return j_array;
}
static int[][] InputArray(int n, int[][] j_array)
{
  Random random = new Random();
  for (int i = 0; i<n;i++)
  {
      Console.Write($"Введите длину {i+1} строки: ");
      int len = random.Next(0,10);
      j_array[i] = new int[len];
      for (int j = 0; j < len; j++)
      {
          Console.Write($"Элемент [{i},{j}]: ");
          j_array[i][j] = random.Next(0,10);
      }
  }
  return j_array;
}
  static int[][] EditArray(int[][] mass)
{
  for (int i = 0; i<mass.Length;i++)
  {
      for (int j = 0; j < mass[i].Length; j++)
      {
          if (mass[i][j] %2 == 0)
          {
              mass[i][j] = i*j;

          }
      }
  }
  return mass;
}
static void PrintArray(int[][] mass)
{
  int c = 0;
  for (int i = 0; i<mass.Length;i++)
  {
    foreach(int el in mass[i])
      {
          if (c != (mass[i].Length - 1))
          {
              Console.Write($"{el}" + " ");
              c++;
          }
          else
          {
              Console.Write($"{el}" + "\n");
              c = 0;
          }
      }
}
}




static int AveRage(int[][] massive)
{
  int sum = 0;
  int n = 0;
  foreach(int[] el in massive)
  {
      foreach(int i in el)
      {
          sum += i;
          n+=1;
      }
  }
  return sum/n;
}
static void AveRage_inside(int[][] massive)
{
  int sum = 0;
  int n = 0;
  foreach(int[] el in massive)
  {
      foreach(int i in el)
      {
          sum += i;
          n+=1;
      }
      Console.Write(sum/n);
      Console.Write(" ");
  }

}
}
