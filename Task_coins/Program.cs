Console.Clear();
int N = new Random().Next(1, 101);
int[] arr = new int[N];
int numberOfCoins = 0;
int numberOf1 = 0;
int numberOf0 = 0;
for (int i = 0; i < N; i++)
{
    arr[i] = new Random().Next(0, 2);
    if (arr[i] == 0)
    {
        numberOf0++;

    }
    else
    {
        numberOf1++;
    }
}

if (numberOf1 > numberOf0)
{
    numberOfCoins = numberOf0;
}
else
{
    numberOfCoins = numberOf1;
}

Console.WriteLine(numberOfCoins);