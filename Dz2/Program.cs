Console.WriteLine("Введите число ");
int number1 = Convert.ToInt32(Console.ReadLine() );
String number1Text = Convert.ToString(number1);

if(number1Text.Length > 2)
{
Console.WriteLine("третья цифра = " + number1Text[2]);
}
else
{
    Console.WriteLine("Нету 3 цифры " );
}

