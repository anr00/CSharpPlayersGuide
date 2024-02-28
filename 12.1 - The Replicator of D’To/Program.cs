int[] array1 = new int[5];
Console.WriteLine("Please, type five numbers.");
int number_user;

for (number_user = 0; number_user < array1.Length; number_user++)
{
    array1[number_user] = Convert.ToInt32(Console.ReadLine());
}  

int copy;
int[] array2 = new int[5];

for (copy = 0; copy < array1.Length; copy++)
{
    array2[copy] = array1[copy];      
}

Console.WriteLine("This is the old array:");
for (int item = 0; item < array1.Length; item++)
{
    Console.WriteLine(array1[item]);
}

Console.WriteLine("This is the new array:");
for (int item = 0; item < array1.Length; item++)
{
    Console.WriteLine(array2[item]);
}