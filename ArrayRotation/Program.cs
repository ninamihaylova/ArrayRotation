class ArrayRotation
{
    static void Main()
    {
        
        int[] numbers = Console.ReadLine()
            .Split(" ",StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        
        int rotations = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < rotations; i++)
        {
            int firstElement = numbers[0];
            for (int j = 1; j < numbers.Length; j++)
            {
                numbers[j-1] = numbers[j];
            }
            numbers[numbers.Length - 1] = firstElement;
        }

        
        Console.WriteLine(string.Join(" ", numbers));
    }
}
        