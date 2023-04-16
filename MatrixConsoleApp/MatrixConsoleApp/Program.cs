while (true)
{
    Random random = new Random();
    Console.WriteLine("Введите число строк матрицы");
    string first = Console.ReadLine();
    Console.WriteLine("Введите число столбцов матрицы");
    string second = Console.ReadLine();

    int n = 0;
    int m = 0;

    if (Int32.TryParse(first, out n) && Int32.TryParse(second, out m))
    {
        if (n > 0 && m > 0)
        {
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = random.Next(-10, 10);
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                bool checking = false;
                int sum = 0;
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        checking = true;
                    }
                }
                if (checking)
                {
                    for (int j = 0; j < m; j++)
                    {
                        sum += matrix[i, j];
                    }
                    Console.WriteLine("Строка {0}, сумма элементов: {1}", i + 1, sum);
                }
            }
            var f = false;

            for (int i = 0; i < n; i++)
            {
                var min = matrix[i, 0];
                for (int j = 0; j < m; j++)
                {
                    if (min > matrix[i, j])
                    {
                        min = matrix[i, j];
                    }
                }
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] == min)
                    {
                        var ch = true;
                        for (int k = 0; k < n; k++)
                        {
                            if (matrix[k, j] > min)
                            {
                                ch = false;
                                break;
                            }
                        }
                        if (ch)
                        {
                            Console.WriteLine("Седловая точка Matrix[{0},{1}]={2}", i + 1, j + 1, matrix[i, j]);
                            f = true;
                        }
                    }
                }
            }
            if (!f)
            {
                Console.WriteLine("Седловых точек в матрице нет");
            }
        }
        else
        {
            Console.WriteLine("Введены числа меньше нуля");
        }
    }
    else
    {
        Console.WriteLine("Введены не числа");
    }
}