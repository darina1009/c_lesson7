int Promt(string text){
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());

}

int[,] GetArray2d(){
    int m = Promt("введите m");
    int n = Promt("введите n");
    int[,] array = new int[m, n];
    for(int i = 0; i<m; i++){
        for( int j = 0; j < n; j++){
            array[i,j] = new Random().Next(1,10);
        }
    }
    return array; 
}

void PrintArray(int[,] array2d){//вывод массива
    for(int i= 0; i< array2d.GetLength(0);i++){
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
             Console.Write(array2d[i, j] +" " );
        }
        Console.WriteLine();
    }
  
}
int[] Summ(int[,] array2d){
 int[] summ = new int[array2d.GetLength(0)];
        for (int i = 0; i < array2d.GetLength(0); i++)
            {
                for (int j = 0; j <array2d.GetLength(1); j++)
                {    
                    summ[i] += array2d[j, i];      //подсчет суммы колонки
                } 
                Console.WriteLine();
            }
            Console.WriteLine();
            foreach (double elem in summ)
            {
                
                Console.WriteLine(elem/array2d.GetLength(1)); //вывод среднего для колонки
            }
            return summ;
}

int[,] array2d = GetArray2d();
PrintArray(array2d);
Summ(array2d);