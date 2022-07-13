//KATA: https://www.codewars.com/kata/546f922b54af40e1e90001da/train/csharp


// Этот код работает. Но на codewars выдает ошибку:
// src/Solution.cs(10,19): error CS0308: The non-generic type 'List' cannot be used with type arguments
/*
string AlphabetPosition(string text)
{
    var alfa = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    var arr = text.ToUpper().ToCharArray();
    var list = new List<int>();

    for (int i = 0; i < arr.Length; i++)
    {
        if (alfa.Contains(arr[i]))
        {
            var index = alfa.IndexOf(arr[i]);
            list.Add(index + 1);
        }
    }
    return string.Join(" ", list.ToArray());
}
*/

//Попытался решить без 'List'. Подебажил, работает, но не пониммаю, как положить в массив порядковые числители букв.
//Сейчас в массив заносится ноль, если в строке text стоит запятая или пробел.
string AlphabetPosition(string text)
{
    var alfa = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    var alfaArr = alfa.ToCharArray();
    var arr = text.ToUpper().ToCharArray();
    var sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (alfa.Contains(arr[i]))
        {
            sum += 1;
        }
    }
    var list = new int[sum];
    for (int i = 0; i < list.Length; i++)
    {
        if (alfaArr.Contains(arr[i]))
        {
            var index = alfa.IndexOf(arr[i]);
            list[i] = index + 1;
        }
        else
        {
            //Не понимаю, как можно продолжить итерацию  со следующим значением, если первое условие неверное 
        }
    }
    return string.Join(" ", list.ToArray());
}

Console.WriteLine(AlphabetPosition("As, s a"));