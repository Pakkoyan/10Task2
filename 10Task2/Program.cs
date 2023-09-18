//1 Задание
// int i = 0;
// while (true)
// {
//     Console.WriteLine(i);
//     ++i;
// }


//2 Задание
// int[] arr = { 2, 5, 1, 3, 0 };
// Console.WriteLine(arr.Max());


//3 Задание
// int[] arr = { 2, 5, 6, 1, 3, 0 };
// int hightNum = 0;
// foreach (int item in arr)
// {
//     if (hightNum < item && item % 2 == 0)
//     {
//         hightNum = item;        
//     }
// }
// Console.WriteLine(hightNum);


//4 Задание 
// int[] arr = { 2, 5, 1, 3, 0 };
// int indexToRemove = 3;
// int[] newArr = new int[arr.Length - 1];
//
// for (int i = 0, j = 0; i < arr.Length; ++i)
// {
//     if (i == indexToRemove)
//     {
//         continue;
//     }
//     newArr[j++] = arr[i];
// }


//5 Задание 
// int[] arr = { 2, 5, 1, 3, 0 };
// int itemToRemove = 3;
// int[] newArr = new int[arr.Length - 1];
//
// for (int i = 0, j = 0; i < arr.Length; ++i)
// {
//     if (arr[i] == itemToRemove)
//     {
//         continue;
//     }
//     newArr[j++] = arr[i];
// }


//6 Задание 
// int[] arr = { 2, 5, 1, 3, 0 };
// int indexToPaste = 3;
// int itemToPaste = 2;
// int[] newArr = new int[arr.Length + 1];
//
// for (int i = 0, j = 0; i < arr.Length; ++i)
// {
//     if (i == indexToPaste)
//     {
//         newArr[j++] = itemToPaste;
//     }
//     newArr[j++] = arr[i];
// }


//7 Задание 
// int[] arr = { 2, 5, 1, 3, 0 };
// List<int> itemsToDelete = new List<int>();
//
// for (int i = 0; i < arr.Length; ++i)
// {
//     int indexToCheck = i;
//     for (int j = i + 1; j < arr.Length; ++j)
//     {
//         if (arr[indexToCheck] == arr[j])
//         {
//             itemsToDelete.Add(indexToCheck);
//             itemsToDelete.Add(j);
//         }
//     }
// }
//
// List<int> newArr = new List<int>();
//
// for (int i = 0; i < arr.Length; ++i)
// {
//     if (!itemsToDelete.Contains(i))
//     {
//         newArr.Add(arr[i]);
//     }
// }
// int[] result = newArr.ToArray();


//8 Задание
// string str = "Hello World Negria Cogara Pinapple kraska !";
// string[] strArr = str.Split(' ');
// string result = "";
//
// foreach (string word in strArr)
// {
//     if (!word.Contains('a'))
//     {
//         result += word + ' ';
//     }
// }
//
// Console.WriteLine(result);


//9 Задание
// string str = "Hello World Negria Cogara Pinapple kraska ! a";
// string[] strArr = str.Split(' ');
// string result = "";
//
// foreach (string word in strArr)
// {
//     if (!word.Contains(str[str.Length-1]))
//     {
//         result += word + ' ';
//     }
// }
//
// Console.WriteLine(result);


//10 Задание которое бонусное, хочу шоколадку !!!
string str = "123 45 6789 10 44";
string[] strArr = str.Split(' ');
List<int> intList = new List<int>();
int result = 0; 

for (int i = 0; i < strArr.Length; ++i)
{
    intList.Add(Int32.Parse(strArr[i]));
}

foreach (int item in intList)
{
    if (item % 10 == 4 || item % 10 == 3)
    {
        result += item;
    }
}
Console.WriteLine(result);









