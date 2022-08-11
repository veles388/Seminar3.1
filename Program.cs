Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int a = num/100;
int b = num/10-a*10;
int c = num-a*100-b*10;

Console.WriteLine(b);