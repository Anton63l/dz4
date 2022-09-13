//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumDigit(int n){
int count = 0;

while(num>0){
    count++;
    num /= 10;
}
return count;
}

System.Console.WriteLine(SumDigit(num));
