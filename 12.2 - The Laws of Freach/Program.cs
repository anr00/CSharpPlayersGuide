{

    int[] arrays = {1, 2, 3, 4, 5};
    int numero_ajuda = int.MaxValue;

    foreach (int array in arrays)
    {
        if (array < numero_ajuda)
        {
            numero_ajuda = array;
        }
    }
    Console.WriteLine(numero_ajuda);
    } 

{

    int[] arrays = {1, 2, 3, 4, 5};
    int numero_ajuda = int.MinValue;

    foreach (int array in arrays)
    {
        if (numero_ajuda < array)
        {
            numero_ajuda = array;
        }
    }
    Console.WriteLine(numero_ajuda);
    }

{

    int[] arrays = {1, 2, 3, 4, 5};
    double total = 0;

    foreach (int array in arrays)

    {
        total = array + total;
    }
    
    float media = (float)total / arrays.Length;
    Console.WriteLine(media);
    }