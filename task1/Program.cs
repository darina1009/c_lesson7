int Promt(string text){
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());

}

double[,] GetArray2d(){
    int m = Promt("введите m");
    int n = Promt("введите n");
    double[,] array = new double[m, n];
    for(int i = 0; i<m; i++){
        for( int j = 0; j < n; j++){
            array[i,j] = new Random().NextDouble() * 100;
        }
    }
    return array; 
};

void PrintArray(double[,] array2d){//вывод массива
    for(int i= 0; i< array2d.GetLength(0);i++){
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
             Console.Write("{0,6:F2}", array2d[i, j]);
            //Console.Write(array2d[i,j] + " ");
        }
        Console.WriteLine();
    }
}

double[,] array2d = GetArray2d();
PrintArray(array2d);



