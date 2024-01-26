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
