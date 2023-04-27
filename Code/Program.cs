Console.Write("Укажите размер массива ");
int ArraySize = int.Parse(Console.ReadLine());

UserInput(ArraySize);

string[] UserInput(int num){
    string[] arr = new string[num];
    for (int i = 0; i < num; i++)
    {   
        Console.Write($"Укажите {i+1} элемент массива: ");
        arr[i] = Console.ReadLine();
        Console.WriteLine(arr[i]);
    }
    return arr;
}
