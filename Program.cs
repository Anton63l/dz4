
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// System.Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());

// int Stepen(int a, int b){
//     int result = 1;

//     for (int i = 1; i <= b; i++){
//         result*=a;
//     }
//     return result;
// }

// System.Console.WriteLine(Stepen(a,b));


//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


// System.Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int SumDigit(int n){
//     int result = 0;
//     while(n > 0){
//         result = result + n % 10;
//         n = n / 10;
//     }
//     return result;
// }

// Console.WriteLine($"Cумма всех цифр в чисое равна {SumDigit(num)}");


// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// int[] GetArray(){
//     int[] result = new int [8];
//     for (int i = 0; i < result.Length; i++)
//     { result [i] = new Random().Next(100);
        
//     }
//     return result;
// }

// void PrintArray(int[] arr){
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write($"{arr[i]} ");       
//     }
// }

// PrintArray(GetArray());