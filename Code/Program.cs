Console.Write("Укажите размер массива ");
int ArraySize = int.Parse(Console.ReadLine());

string[] strarray = UserInput(ArraySize);
PrintArray(strarray);
Console.WriteLine();
PrintArray(SearchThreeDigitNumbers(strarray));

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
    Console.Write($"[");
    for (int i = 0; i < arr.Length; i++)
    {   
        if(arr.Length!=i+1){
            Console.Write($" \"{arr[i]}\",");
        }else{
            Console.Write($" \"{arr[i]}\"");
        }
        
    }
    Console.Write($"]");
}


string[] SearchThreeDigitNumbers (string[] array){
    string[] arraystr = new string[]{};
    int num= 1;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length<=3){
            Array.Resize(ref arraystr, num);
            arraystr[num-1] = array[i];
            num++;
        }
        
    }
    return arraystr;
}
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []