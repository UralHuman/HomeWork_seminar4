int MaPow()
{
System.Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

int count = a;

int i = 1;

while (i<b)
{
    
    a = a*count;
    i++;
    
}
return a;
}
int c = MaPow();
System.Console.Write(c);