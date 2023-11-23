// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N. Использовать рекурсию, не использовать циклы.
int m;
int n;
while(true){
    Console.WriteLine("Введите число m");
if(int.TryParse(Console.ReadLine(),out m)){
    break;
}

}
while(true){
    Console.WriteLine("Введите число n");
if(int.TryParse(Console.ReadLine(),out n)){
    break;
}
}
void NumWrite(int m, int n){
    Console.WriteLine(m);
    if(m == n){
        return;
    }
    NumWrite(m + 1, n);
}
Console.WriteLine();
NumWrite(m,n);