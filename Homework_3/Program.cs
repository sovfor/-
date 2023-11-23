// Задайте произвольный массив. Выведете его элементы, начиная с конца.
//  Использовать рекурсию, не использовать циклы.

 int[] CreateNewRandomArray(){
    int lenght = new Random().Next(1,11);
    int[] array = new int[lenght];
    return array;
}

 void FillArray(int[] arr, int lenght)
 {
     if(lenght < 0){
         return;
     }
     arr[lenght] = new Random().Next(1,11);

     FillArray(arr,lenght - 1);
    
 }

 void WriteArray(int[] arr, int lenght)
 {
     if(lenght < 0){
         return;
     }
     Console.Write(arr[lenght] + " ") ;

     WriteArray(arr,lenght - 1);

 }
 int[] array = CreateNewRandomArray();
 FillArray(array, array.Length - 1);
 WriteArray(array, array.Length - 1);
 Console.WriteLine();


