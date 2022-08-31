//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

/*
void Stepen(int num1, int num2){
    int result=1;
    for (int curr = 1; curr <= num2; curr++){
        result *= num1;
    }
    Console.WriteLine($"Число {num1} в степени {num2} равно {result}");
}

Console.Write("Введите  первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Stepen(number1, number2);
*/
// Задача 27: Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.
/*
void Summa(int num, int r){
    int result=0;
    for (int curr = 1; curr <= r; curr++){
        result += num % 10;
        num = num / 10;
    }
    Console.WriteLine($"Сумма цифр числа равна {result}");
}

int Razr(int num){
    int result=0;
    while(num>=1){
        num = num / 10;
        result++;
    }
    return result;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int r = Razr(number);
Summa(number, r);
*/

//Задача 29: Напишите программу, которая задаёт массив из 
//произвольного количества элементов и выводит их на экран.
/*
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/
int[] CreateArray(int size){
    int[] array = new int[size];
    for (int i=0; i < size; i++){
        Console.Write($"Введите {i}-й элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array){
    Console.Write("[ ");
    for(int i=0; i<array.Length - 1; i++){
        Console.Write(array[i]+", ");
    }
    Console.Write(array[array.Length - 1]+" ]");
}

Console.Write("Введите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
ShowArray(CreateArray(size));