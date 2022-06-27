int [] array = {1, 22, 13, 28, 34, 45, 66, 47, 28};

int n = array.Length;
int find = 28;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}