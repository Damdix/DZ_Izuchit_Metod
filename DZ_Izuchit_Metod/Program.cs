// --- Метод --- \\

//[модификатор] тип_возращаемого_метода название_метода([параметры])            консрукция метода
//{                                                                             консрукция метода
//    [тело_метода]                                                             консрукция метода
//}                                                                             консрукция метода

//static void SayHello()
//{
//    Console.WriteLine("Hello");
//}
//Console.ReadLine();


//Пример

void SayHelloRu() => Console.WriteLine("Привет");                                         //Объявляем несколько методов(сокращенно)

void SayHelloEn() => Console.WriteLine("Hello");

void SayHelloFr() => Console.WriteLine("Salut");


Console.WriteLine("Введите ru, fr, en");                                                //Даем текст пользователю
Console.WriteLine("Ввод: ");
string language = Convert.ToString(Console.ReadLine());                                //Ввод пользователя

switch (language)                                                                      //создзали switch case для выбора
{
    case "ru":
        SayHelloRu();
        break;
    case "fr":
        SayHelloFr();
        break;
    case "en":
        SayHelloEn();
        break;
}
