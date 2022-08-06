// Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран. Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)

void Masif(int[] num)
{
    int size = num.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{num[i]} ");
    }
    Console.WriteLine();
}
int[] NewMass()
{  
    int size = 8;
    int[] num = new int[size];
    for (int i = 0; i < size; i++)
    {
        num[i] = new Random().Next(1, 100);        
    }    
    return num;
}
int[] num_1 = NewMass();
Masif(num_1);
int[] num_2 = NewMass();
Masif(num_2);

