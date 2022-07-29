// Задача: написать программу, которая из имеющегося массива срок формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// Примеры:
// ["hello","2","world",":-)"]->["2",":-)"]
// ["1234","1567","-2","computer science"]->["-2"]
// ["Russia","Denmark","Kazan"]->[]

Console.WriteLine("Заполните строку массива: ");
string[] Texts1, Texts2, Texts3 ;
string[] Result1, Result2, Result3 ;
Texts1 = new string[4]{ "hello", "2", "world", ":-)"};
Texts2 = new string[4]{"1234","1567","-2","computer science"};
Texts3 = new string[3]{"Russia","Denmark","Kazan"};
int t1=Texts1.Length;
int t2=Texts2.Length;
int t3=Texts3.Length;