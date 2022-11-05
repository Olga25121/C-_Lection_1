//Вид 1 - не принимает аргументы, ничего не возвращает
// void Metod1()
// {
// Console.WriteLine("Автор …");
// }
// Metod1();

//Вид 2 - принимает аргументы, ничего не возвращает
// void Metod2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Metod2("Текст сообщения");

//Именованные аргументы - вывод разного текста к разным аргументам
// void Metod21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Metod21(msg: "Текст", count: 4);

//Вид 3 - не принимает аргументы, возвращает значения (генератор случайных чисел, данных)
// int Metod3() 
// {
//     return DateTime.Now.Year; //обязательно использование оператора return
// }
// int year = Metod3();//вызываем метод, в левой части используем идентификатор переменной (year) и через оператор присваивания (=) кладём нужное значение
// Console.WriteLine(year);

//Вид 4 - принимает аргументы, возвращает значения
// string Metod4(int count, string text) //Возвращать будем строку string.Передавать будем int count 
// {
//     int i = 0;
//     string result = String.Empty; //значением является пустая строка string.Empty.
//     while (i < count)
//     {
//         result = result + text;    //правой кнопкой сделать rename и написать условный текст
//         i++;                       //Мы будем string компоновать друг за другом count раз.
//     }
//     return result;
// }
// string res = Metod4(10, "z");  //переменная куда мы будем класть результат, конечный string result.
// Console.WriteLine(res);

//Цикл For (пример Вид 4)
// string Metod4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Metod4(10, "z");
// Console.WriteLine(res);

//Цикл в цикле
//Задача 1. Вывод таблицы умножения на экран
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i * j}");
//     }
//     Console.WriteLine(); 
// }

//Задача 2. Дан текст. В нём нужно 
// -все пробелы заменить чёрточками, 
// -маленькие буквы «к» заменить большими «К», а 
// -большие «С» заменить на маленькие «с».
// string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";
// //string s = "qwerty"
// //            012345
// //s[3] // r


// string Replace(string text, char oldValue, char newValue) //новый оператор
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }
// string newText = Replace(text, ' ',  '|');  // вместо пробелов - черточки
// Console.WriteLine(newText);

// Console.WriteLine();
// newText = Replace(text, 'к', 'К');
// Console.WriteLine(newText);

// Console.WriteLine();
// newText = Replace(text, 'C', 'c');
// Console.WriteLine(newText);

//Задача 3. Упорядочивание данных внутри массива
//Алгоритм сортировки методом минимакса или иногда просто называют методом максимального

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PrintArray(int[] array)        //метод вывода на экран массива
{
int count = array.Length;
for (int i = 0; i < count; i++)
{
Console.Write($"{array[i]}");
}
Console.WriteLine();
}
void SelectionSort(int[] array)     //упорядочивание массива
{
for (int i = 0; i < array.Length - 1; i++)
{
int minPosition = i;
for (int j = i+1; j < array.Length; j++)
{
if(array[j] < array[minPosition]) 
{
minPosition = j;
}
}
int temporary = array[i];           //замена через временное хранилище temporary
array[i] = array[minPosition];
array[minPosition] = temporary;
}
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);








