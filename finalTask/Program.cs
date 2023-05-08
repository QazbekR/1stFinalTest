
string[] array1 = new string[7] {"1996", "1", "cawabanga", "4536", "why", "because", "nopeYEs"};
string[] array2 = new string[array1.Length];


void arrayT(string[] array1, string[] array2)
    {
        int count = 0;
        for (int i = 0; i < array1.Length; i++)
            {
                if(array1[i].Length <= 3)
                    {
                        array2[count] = array1[i];
                        count++;
                    }
            }
    }
void PrintAr(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
    }
arrayT(array1, array2);
PrintAr(array2);
