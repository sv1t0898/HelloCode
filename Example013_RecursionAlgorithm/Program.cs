                     //
string[,] table = new string[2, 5];
//table[0,0]    //table[0,1]    //table[0,2]    //table[0,3]    //table[0,4]
//table[1,0]    //table[1,1]    //table[1,2]    //table[1,3]    //table[1,4]
// ...

// table[1, 2] = "слово";

// for (int rows = 0; rows < 2; rows++){
//     for (int columns = 0; columns < 5; columns++){
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }


// void PritnArray(int[,] math){

//     for (int rows = 0; rows < math.GetLength(0); rows++){
//         for (int columns = 0; columns < math.GetLength(1); columns++){
//             Console.Write($"{math[rows, columns]} ");
//     }
//     Console.WriteLine();

//     }
// }

// void FillArray(int[,] math){
//     for (int rows = 0; rows < math.GetLength(0); rows++){
//         for (int columns = 0; columns < math.GetLength(1); columns++){
//             math[rows, columns] = new Random().Next(1, 10);
//         //Console.Write($"{matrix[rows, columns]} ");
//         }
//     }
// }

// int [,] matrix = new int[3, 4];

// PritnArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PritnArray(matrix);

// int[,] pic = new int[,];

// void PrintImage(int[,] image){

//     for (int i = 0; i < image.GetLength(0); i++){
//         for (int j = 0; j < image.GetLength(1); j++){
//             //Console.Write($"{math[rows, columns]} ");
//             if (image[i,j] == 0){
//                 Console.Write(" ");
//                 }
//             else{
//                 Console.Write("+");
//                 }
//             }
//     }
//     Console.WriteLine();

// }

// void FillImage(int row, int col){
//     if(pic[row, col] == 0){
//         pic[row, col] = 1;
//         FillImage(row-1, col);
//         FillImage(row, col-1);
//         FillImage(row+1, col);
//         FillImage(row, col+1);

//     }
// }

// PrintImage(pic);
// FillImage(13,13);
// PrintImage(pic);

// double Factorial(int n){
    
//     //1! = 1
//     //0! = 1
//     if(n == 1){
//         return 1;
//     }
//     else{
//         return n * Factorial(n-1);
//     }
// }

// //Console.WriteLine(Factorial(5));//1*2*3 = 6

// for (int i = 1; i < 40; i++){
//     Console.WriteLine($"{i}? = {Factorial(i)}");
// }

// Числа фибоначи
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

double Fibonacci(int n ){
    if(n ==1 || n == 2){
        return 1;
    }
    else{
       return Fibonacci(n-1) + Fibonacci(n-2);
    }
}

for (int i = 1; i < 50; i++){
    Console.WriteLine($"{i} - {Fibonacci(i)}");
}