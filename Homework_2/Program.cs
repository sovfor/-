// Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.
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

int Akkerman(int m,int n)
{
    if(m == 0){
        return n + 1;
    }
     else if(m > 0 && n == 0){
         return Akkerman(m - 1, 1);
     }
     else{return Akkerman(m - 1, Akkerman(m, n - 1));}
return 1000;
}

Console.WriteLine(Akkerman(n,m));
