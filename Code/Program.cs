Console.Write("Укажите размер массива ");
int ArraySize = int.Parse(Console.ReadLine());

PrintArray(UserInput(ArraySize));

string[] UserInput(int num){
    string[] arr = new string[num];
    for (int i = 0; i < num; i++)
    {   
        Console.Write($"Укажите {i+1} элемент массива: ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

void PrintArray(string[] arr){
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}
