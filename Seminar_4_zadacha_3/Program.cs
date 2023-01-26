System.Console.Write("Введите колличество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());;
int [] array = new int[n];

// Random ran = new Random();

for (int i=0; i< n; i++)
{
 Console.Write("Введите элемент №{0}:\r\n        ", i + 1);
// Random ran = new Random();
// array[i] = ran.Next();


 array[i]=Convert.ToInt32(Console.ReadLine());;
}
System.Console.WriteLine("Вы ввели следующие символы: ");

for(int i =0;i<n;i++)
{
    
    System.Console.WriteLine(array[i]);
}