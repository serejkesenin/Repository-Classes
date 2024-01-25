using System;
class HelloWorld {
static void Main()
{
  Console.WriteLine("Введите тип массива: одн, двум, ступ");
  string type = Console.ReadLine();
  if (type =="одн")
  {
      Console.Write("Введите длину массива ");
      int length = int.Parse(Console.ReadLine());
      Console.Write("Массив заполняется пользователем?(true/false) ");
      bool choice = bool.Parse(Console.ReadLine());
      int[] mass1 = new int[length];
      Odnomernye mass = new Odnomernye(length, choice);
  }
  if (type =="двум")
  {
      Console.Write("Введите количество строк массива ");
      int m1 = int.Parse(Console.ReadLine());
      Console.Write("Введите количество столбцов массива ");
      int m2 = int.Parse(Console.ReadLine());
      Console.Write("Массив заполняется пользователем?(true/false) ");
      bool choice = bool.Parse(Console.ReadLine());
      Dvumernye mass = new Dvumernye(m1,m2, choice);
    
  }
  if (type == "ступ")
  {
      Console.Write("Введите количество строк массива ");
      int m1 = int.Parse(Console.ReadLine());
      Console.Write("Массив заполняется пользователем?(true/false) ");
      bool choice = bool.Parse(Console.ReadLine());
      Stupenchatye mass = new Stupenchatye(m1, choice);
  }
 }
}








class Odnomernye
{
   public int[] massive;
   public Odnomernye(int n, bool choice)
   {
       int[] massive = new int[n];
       if (choice)
       {
           massive = GetMass_user(n,massive);
           printMass(n,massive);
       }
       else
       {
           massive = GetMass(n,massive);
           printMass(n,massive);
       }
   }
 public int AveRage(int[] massive, int n)
 {
   int sum = 0;
   foreach(int el in massive)
   {
       sum += el;
   }
   return sum/n;
 }
 public int[] DelEl(int[] massive, int n)
 {
   int k = 0;
   for(int i=0; i < n; i++)
   {
       if(Math.Abs(massive[i])< 100)
       {
           k += 1;
       }
   }
   int[] mas1 = new int[k];
   int x = 0;
   for(int i=0; i < n; i++)
   {
       if(Math.Abs(massive[i])< 100)
       {
           mas1[x] = massive[i];
           x+=1;
       }
   }
   return mas1;
 }
 public int[] GetMassWoDubs(int[] mass)
 {
   int newMassLength = mass.Length;
   for(int i = 0; i < mass.Length; i++)
   {
   for(int j = i; j < mass.Length; j++)
   {
       if(mass[i] == mass[j] && i != j)
       {
           newMassLength--;
           break;
       }
   }
   }
   Console.WriteLine("New array length = " + newMassLength + "\n");
  
   int[] newMass = new int[newMassLength];
   for(int i = 0; i < newMass.Length; i++)
   {
       newMass[i] = int.MinValue;
   }
   int c = 0;
   for(int i = 0; i < mass.Length; i++)
   {
       if(!Ex(mass[i], newMass))
       {
           newMass[c] = mass[i];
           c++;
           //   Console.WriteLine("newMass[" + (c - 1) + "]= " + newMass[c] + " ");
       }
   }
   return newMass;
 }








 public bool Ex(int val, int[] mass)
 {
   for(int i = 0; i < mass.Length; i++)
   {
       if(mass[i] == val)
       {
           return true;
       }
   }
   return false;
 }




 public void printMass(int n, int[] massive)
 {
   for(int i = 0; i < n; i++)
   {
       Console.Write(massive[i] + " ");
   }
 }
 public int[] GetMass(int n, int[] massive)
 {
   Random random = new Random();
   for(int i = 0; i < n; i++)
   {
       int val = random.Next(0,10);
       massive[i] = val;
   }
   return massive;
 }




 public int[] GetMass_user(int n, int[] massive)
 {
   for(int i = 0; i < n; i++)
   {
       int val = int.Parse(Console.ReadLine());
       massive[i] = val;
   }
   return massive;
 }
}
























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
