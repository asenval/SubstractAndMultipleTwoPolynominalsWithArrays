using System;

class SubstractAndMultipleTwoPolynominalsWithArrays
{
    static void Main()
    {
        SumTwoPolynominalsWithArrays SP = new SumTwoPolynominalsWithArrays();  // you can download 11.SumTwoPolynomialsWithArrays and use it for this task
        Console.WriteLine("Enter first polynomials (for example 4x4-x2+3x-5):");
        string polynomial1 = Console.ReadLine();
        Console.WriteLine("Enter second polynomials:");
        string polynomial2 = Console.ReadLine();
        //
        //   OR
        //
        //string polynomial1 = "4x4-x2+3x-5";
        //string polynomial2 = "8x3-2x2+2x+3";
        //
        int[] pArray1 = SP.SeparatePolinomialToArray(polynomial1);
        int[] pArray2 = SP.SeparatePolinomialToArray(polynomial2);
        int[] result = new int[pArray1.Length];
        string str;
        result = SubstractPolinomials(pArray1, pArray2);
        str = SP.TransvereArrayToPolinomial(result);
        Console.WriteLine(str);
        result = MultyolyPolinomials(pArray1, pArray2);
        str = SP.TransvereArrayToPolinomial(result);
        Console.WriteLine(str);
    }

    public static int[] SubstractPolinomials(int[] pArray1, int[] pArray2)
    {
        int[] result = new int[pArray1.Length];
        for (int i = 0; i < pArray1.Length; i++)
        {
            result[i] = pArray1[i] - pArray2[i];
        }

        
        return result;
    }

    public static int[] MultyolyPolinomials(int[] pArray1, int[] pArray2)
    {
        SumTwoPolynominalsWithArrays SP = new SumTwoPolynominalsWithArrays();
        int[] result = new int[20];
        int[] resultPrevious = new int[20];
        int[] resultCurrent = new int[20];
        for (int i = 0; i < pArray1.Length; i++)
        {
            for (int j = 0; j < pArray1.Length; j++)
            {
                resultCurrent[j+i] = pArray1[j] * pArray2[i];
            }
            result = SP.SumPolinomials(resultCurrent, resultPrevious);
            result.CopyTo(resultPrevious, 0);
            Array.Clear(resultCurrent, 0, result.Length - 1);
                       
        }
        
        return result;
    }
}
