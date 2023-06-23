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
            array[i,j] = new Random().Next(10);
        }
    }
    return array; 
};

void PrintArray(int[,] array2d){//вывод массива
    for(int i= 0; i< array2d.GetLength(0);i++){
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
             Console.Write(array2d[i, j] +" " );
        }
        Console.WriteLine();
    }
}



void Element(int[,] array2d){
    int num = 0;
    int i = Promt("введите i");
int j =Promt("введите j");
            if(i<=array2d.GetLength(0) & j <= array2d.GetLength(1)){
        num = array2d[i,j];
        Console.WriteLine(num);
    }
    else{
        Console.WriteLine("такого числа в массиве нет");
    }
    //return num;
}

int[,] array2d = GetArray2d();
PrintArray(array2d);
Element(array2d);
//Console.WriteLine(num);