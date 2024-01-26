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




