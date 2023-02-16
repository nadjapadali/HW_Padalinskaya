static void NumRec(int N)
{
    if(N > 0){
        Console.WriteLine(N);
        NumRec(N-1);
    }
}

NumRec(8);


