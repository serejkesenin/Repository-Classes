class Dvumernye
{
  public int[,] mass;
   public Dvumernye(int m1, int m2, bool choice)
   {
      int[,] mass = new int[m1,m2];
      if (choice)
      {
          GetMass_user(m1, m2, mass);
          Console.WriteLine("Массив:");
          PrintMass(m1, mass);
      }
      else
      {
          GetMass(m1, m2, mass);
          Console.WriteLine("Массив:");
          PrintMass(m1, mass);
      }
      Console.WriteLine("Четные строки в обратном порядке:");
      Matryza(m1,m2,mass);
      Console.WriteLine("Среднее значение массива:");
      Console.WriteLine(AveRage(mass));
   }








static void PrintMass(int m1, int[,] mass)
{
  int c = 0;
  Console.WriteLine(" ");
  foreach(int el in mass)
      {
          if (c != (m1 - 1))
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





static int[,] GetMass(int m1, int m2, int[,] mass)
{
      Random random = new Random();
      for (int i = 0; i < m1; i++)
          {
              for(int j =  0; j < m2; j++)
              {
                  Console.Write($"Элемент [{i},{j}]: ");
                  mass[i, j] =  random.Next(0,10);
              }
          }
  return mass;
}








static int[,] GetMass_user(int m1, int m2, int[,] mass)
{
      for (int i = 0; i < m1; i++)
      {
          for(int j =  0; j < m2; j++)
          {
              Console.Write($"Элемент [{i},{j}]: ");
              mass[i, j] = Convert.ToInt32(Console.ReadLine());
          }
      }
  return mass;
}




static void Matryza(int m1, int m2, int[,] mass)
{
  Console.WriteLine(" ");
  for (int i = 0; i < m1; i++)
  {
          if (i%2 == 0)
          {
              for (int g = m2 - 1; g >= 0; g--)
              {
                  if (g==0)
                  {Console.Write($"{mass[i,g]}" + "\n");}
                  else
                  {Console.Write($"{mass[i,g]}" + " ");}
              }
          }
          else
          {
              for (int j = 0; j < m2; j++)
              {
                  if (j == m2 - 1)
                  {Console.Write( $"{mass[i,j]}" + "\n");}
                  else
                  {Console.Write( $"{mass[i,j]}" + " ");}
              }
          }
}
}
  static int AveRage(int[,] massive)
{
  int sum = 0;
  int n = 0;
  foreach(int el in massive)
  {
          sum += el;
          n+=1;
  }
  return sum/n;
}
}













