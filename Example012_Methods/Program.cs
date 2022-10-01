// // Вид 1
// void Method1(){
//     Console.WriteLine("Автор ...");

// }
// Method1();

// //Вид 2

// void Method2(string msg){
//     Console.WriteLine(msg);
// }


// void Method21(string msg, int count){
//     int i = 0;
//     while (i < count)
//     {
//         i++;
//         Console.WriteLine(msg);
//     }
// }
// Method21(msg:"Текст сообщения", count:5);

// // Вид 3

// int Method3(){
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);

// //Вид 4

// string Method4(int count, string text){
    
//     int i = 0;
//     string result = String.Empty;

//     while(i < count){

//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "+Text");
// Console.WriteLine(res);

// string Method41(int count, string text){
    
//     string result = String.Empty;

//     for(int i = 0; i < count; i++){

//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res41 = Method41(5, "forText");
// Console.WriteLine(res41);

// // Таблица умножения
// void multiplication_table(){
//     for(int i = 2; i < 10; i++){

//         for(int j = 2; j <= 10; j++){
//              Console.Write($" {i} x {j} = {i*j} ");
//         }
//          Console.WriteLine();
//     }
// }

// multiplication_table();

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "q w e r t y"
//             0 1 2 3 4 5


// // Метод для работы с техтом.
// string Replace(string text, char oldValue, char newVakue){
//     string result = String.Empty;

//     int kength = text.Length;
//     for (int i = 0; i < kength; i++){
//         if(text[i] == oldValue) 
//             result = result + $"{newVakue}";
//         else{
//             result = result + $"{text[i]}";
//         }
//     }

//     return result;
// }
// string newText = Replace(text, 'к', 'К');
// Console.WriteLine();
// string newText2 = Replace(newText, 'с', 'С');
// Console.WriteLine(newText);
// Console.WriteLine(newText2);

// Алгоритм сортировки MIN MAX.
int[] arr = {1, 4, 7, 4, 8, 6, 4, 2, 1};

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);

void PrintArray(int[] array){
    int count = array.Length;

    for (int i = 0; i < count; i++){
        Console.Write($"{array[i]}");
        Console.Write(",");
    }
}


void SelectionSort(int[] array){

    //int length = array.Length;
    for (int i = 0; i < array.Length - 1; i++){
        int minPosition = i;

        for(int j = i + 1; j < array.Length; i++){
            if(array[i] < array[minPosition]){
                minPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

