// Задача 34: Задайте массив заполненный случайными положительными трехзначными числами.
// Напишите программу, которая покажет количество четных чисел в массиве. 
/*
int[] array = GetArray(6, 100, 999);
Console.WriteLine($"[{String.Join(",", array)}]");
int countPositiveSum = 0;
foreach (int el in array){
    if(el % 2 == 0){
        countPositiveSum += 1;
    }
}
Console.WriteLine($"Количество четных чисел равно {countPositiveSum}");
*/



//Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечетных индексах.
/*
int[] array = GetArray(6, -100, 100);
Console.WriteLine($"[{String.Join(",", array)}]");
int sum = 0;
for(int i = 1; i < array.Length; i += 2){
sum = sum + array[i];
}
Console.WriteLine($"Сумма элементов на нечетных индексах равна {sum}");
*/



//Задача 37: Найдите произведение пар чисел в одномерном массиве.
//Парой считается первый и последний элемент, второй и предпоследний и т.д.
//Результат запишите в новом массиве.
/*
Console.WriteLine("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine()!);
int[] array = GetArray(size, 1, 10);
Console.WriteLine($"[{String.Join(",", array)}]");
if(size % 2 == 0){
int NewSize = size / 2; 
int[] NewArray = GetNewArray(NewSize);
Console.WriteLine($"[{String.Join(",", NewArray)}]");
}
else{
    int NewSize = (size / 2) + 1;
    int[] NewArray = GetNewArray(NewSize);
Console.WriteLine($"[{String.Join(",", NewArray)}]");
}
// ------метод заполнения получившегося массива------
int[] GetNewArray(int NewSize){     
  int[] RES = new int[NewSize];
    for (int i = 0; i <= (size - 1) / 2; i ++){
    RES [i] = array[i] * array[(size -1) - i];
    }
    if((size - 1) % 2 == 0){
        RES [(size - 1) / 2] = array[(size - 1) / 2];
    }
    return RES;
}
   //------МЕТОД заполнения массива--------
int [] GetArray(int size, int minValue, int maxValue){
 int[] res = new int[size];
 for(int i = 0; i < size; i++)
 {
    res[i] = new Random().Next(minValue, maxValue + 1);
 }   
 return res;
}
*/