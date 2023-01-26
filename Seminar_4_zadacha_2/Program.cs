System.Console.Write(">>> ");
int a = Convert.ToInt32(Console.ReadLine());

int sum =0;
 while (a>0)
 {
    int digit = a%10;
    sum = sum + digit;
    a = a/10;
 }
 System.Console.WriteLine($"Сумма цифр = {sum}");


