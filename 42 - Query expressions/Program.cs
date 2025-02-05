int[] numbers = {1, 9, 2, 8, 3, 7, 4, 6, 5};

foreach (int aaa in LINQ2(numbers))
    Console.WriteLine(aaa);

IEnumerable<int> Normal(int[] array)
{
    List<int> numbers = new List<int>();
    foreach (int a in array)
        if (a % 2 == 0)
            numbers.Add(a);

    int[] ints = numbers.ToArray();
    Array.Sort(ints);

    for (int i = 0; i < ints.Length; i++)
        ints[i] *= 2;
    return ints;
}

IEnumerable<int> LINQ(int[] array)
{
    return from a in array
           where a % 2 == 0
           orderby a
           select a * 2;
}

IEnumerable<int> LINQ2(int[] array)
{
    return array
           .Where(a => a % 2 == 0)
           .OrderBy(a => a)
           .Select(a => a * 2);
}