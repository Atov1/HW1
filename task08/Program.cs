Console.WriteLine ("Введите число");
int  N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N+1];

for ( int i = 0; i<=N; i++)
{
    array[i] = i;
    while (array[i] % 2 = 0)
{
    Console.WriteLine(array[i]);
    i++;
}

}