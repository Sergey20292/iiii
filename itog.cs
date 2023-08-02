// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

\\
Console.Write("Введите количество строк - ");
int n = Convert.ToInt32(Console.ReadLine()); 
string[] startMass = new string[n]; 
for (int i = 0; i < n; i++){
    Console.Write($"Введите строку №{i+1}:\n    ");
    startMass[i] = Console.ReadLine();
}


int length= 0;
for (int i = 0; i < startMass.GetLength(0); i++){
    if (startMass[i].Length < 4 ){
     length++;
    }
}

string [] newMass= new string [length];

int count=0;
for (int i = 0; i < startMass.GetLength(0); i++){
    if (startMass[i].Length < 4 ){
        newMass[count]=startMass[i];
        count++;
    }
}
Console.WriteLine(string.Join(",",newMass));

