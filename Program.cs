int[] osorterad = { 5, 9, 7, 25, 1, 78, 65, 42 };


int count = 0;

for (int i = 0; i < osorterad.Length; i++)
{
    count++;
    display();
    sort();
    
}

void display()
{
    foreach (int a in osorterad)
    {
        Console.Write(a + ", ");
    }
    Console.WriteLine();
}
void sort()
{
    for (int i = 0; i < osorterad.Length - 1; i++)
    {
        count++;
        int a = osorterad[i];
        int b = osorterad[i + 1];

        if (a > b)
        {
            osorterad[i] = b;
            osorterad[i + 1] = a;
        }
    }
}

Console.WriteLine(count);

