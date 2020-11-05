using System;

namespace калькулятор_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstItm;
            string itmForAdd;
            string itmForDiff;
            string cond;

            int i = 0;
            int j = 0;
            
            while (true)
            {
                //первое число
                firstItm = Console.ReadLine();
                char[] arrFirstChar =firstItm.ToCharArray();
                int[] arrFirstItm = new int[arrFirstChar.Length];
                for (i = 0; i < arrFirstChar.Length; i++)
                {
                    while (!int.TryParse(arrFirstChar[i].ToString(), out arrFirstItm[i]))
                    {
                        Console.WriteLine(  "Write correctly");
                    }
               
                }
                int[] result = new int[arrFirstItm.Length + 1];
            //знак           
                cond = Console.ReadLine();

                while (cond != "+" && cond != "-" && cond != "*" && cond != "/" )
                {
                    cond = Console.ReadLine();
                    Console.WriteLine("error");
                }
                switch (cond)
                {
                    case "+":
                        //второе число 
                        itmForAdd = Console.ReadLine();
                        char[] arrSecondChar = itmForAdd.ToCharArray();
                        int[] arrItmForAdd = new int[arrSecondChar.Length];
                        for (i = 0; i < arrSecondChar.Length; i++)
                        {
                            while (!int.TryParse(arrSecondChar[i].ToString(), out arrItmForAdd[i]))
                            {
                                Console.WriteLine("Write correctly");
                            }
                        }
                        //действие 1
                            if (arrFirstItm.Length > arrItmForAdd.Length)
                            { 
                                if (arrFirstItm[0] + 1 == 10)
                                {
                                    result = new int[arrFirstItm.Length + 1];
                                    for (i = 0; i < arrFirstItm.Length; i++)
                                    {
                                        result[result.Length - 1 - i] += arrFirstItm[arrFirstItm.Length - 1 - i];
                                    }
                                    for (j = 0; j < arrItmForAdd.Length; j++)
                                    {
                                        result[result.Length - 1 - j] += arrItmForAdd[arrItmForAdd.Length - 1 - j];
                                    }
                                    for (j = 0; j < result.Length; j++)
                                    {
                                        while (result[result.Length - 1 - j] >= 10)
                                        {
                                            result[result.Length - 2 - j] += result[result.Length - 1 - j] / 10;
                                            result[result.Length - 1 - j] = result[result.Length - 1 - j] % 10;
                                        }
                                    }
                                }
                                else
                                {
                                    result = new int[arrFirstItm.Length];

                                for (i = 0; i < arrFirstItm.Length; i++)
                                {
                                    result[result.Length - 1 - i] += arrFirstItm[arrFirstItm.Length - 1 - i];
                                }
                                for (j = 0; j < arrItmForAdd.Length; j++)
                                {
                                    result[result.Length - 1 - j] += arrItmForAdd[arrItmForAdd.Length - 1 - j];
                                }
                                    for (j = 0; j < result.Length; j++)
                                    {
                                        while (result[result.Length - 1 - j] >= 10)
                                        {
                                        result[result.Length - 2 - j] += result[result.Length - 1 - j] / 10;
                                        result[result.Length - 1 - j] = result[result.Length - 1 - j] % 10;
                                        }
                                    }
                                }                           
                            } 
                            else if (arrFirstItm.Length < arrItmForAdd.Length)
                            {
                                if (arrItmForAdd[arrItmForAdd.Length - 2] + 1 == 10)
                                {
                                    result = new int[arrItmForAdd.Length + 1];

                                    for (i = 0; i < arrFirstItm.Length; i++)
                                    {
                                        result[result.Length - 1 - i] += arrFirstItm[i];
                                    }
                                    for (j = 0; j < arrItmForAdd.Length; j++)
                                    {
                                        result[result.Length - 1 - j] += arrItmForAdd[arrItmForAdd.Length - 1 - j];
                                    }
                                    for (j = 0; j < result.Length; j++)
                                    {
                                        while (result[result.Length - 1 - j] >= 10)
                                        {
                                            result[result.Length - 2 - j] += result[result.Length - 1 - j] / 10;
                                            result[result.Length - 1 - j] = result[result.Length - 1 - j] % 10;
                                        }
                                    }
                                }
                                else
                                {
                                    result = new int[arrItmForAdd.Length];

                                for (i = 0; i < arrItmForAdd.Length; i++)
                                {
                                   result[result.Length - 1 - i] += arrItmForAdd[arrItmForAdd.Length - 1 - i];
                                }
                                for (j = 0; j < arrFirstItm.Length; j++)
                                {
                                    result[result.Length - 1 - j] += arrFirstItm[arrFirstItm.Length - 1 - j];
                                    }
                                    for (j = 0; j < result.Length; j++)
                                    {
                                        while (result[result.Length - 1 - j] >= 10)
                                        {
                                        result[result.Length - 2 - j] += result[result.Length - 1 - j] / 10;
                                        result[result.Length - 1 - j] = result[result.Length - 1 - j] % 10;
                                        }
                                    }                              
                                }
                            }
                        else if (arrFirstItm.Length == arrItmForAdd.Length)
                        {                            
                                if (arrFirstItm[0] + arrItmForAdd[0] >= 10)
                                {
                                    result = new int[arrFirstItm.Length + 1];

                                    for (i = 0; i < arrFirstItm.Length; i++)
                                    {
                                        result[result.Length - 1 - i] += arrFirstItm[arrFirstItm.Length - 1 - i];
                                    }
                                    for (j = 0; j < arrItmForAdd.Length; j++)
                                    {
                                        result[result.Length - 1 - j] += arrItmForAdd[arrItmForAdd.Length - 1 - j];
                                    }

                                    for (j = 0; j < result.Length; j++)
                                    {
                                        while (result[result.Length - 1 - j] >= 10)
                                        {
                                            result[result.Length - 2 - j] += result[result.Length - 1 - j] / 10;
                                            result[result.Length - 1 - j] = result[result.Length - 1 - j] % 10;
                                        }
                                    }
                                }
                                else
                                {
                                    result = new int[arrFirstItm.Length];
                                    for (j = 0; j < arrItmForAdd.Length; j++)
                                    {
                                        arrFirstItm[arrFirstItm.Length - 1 - j] += arrItmForAdd[arrItmForAdd.Length - 1 - j];
                                    };

                                    for (j = 0; j < arrFirstItm.Length; j++)
                                    {
                                        while (arrFirstItm[arrFirstItm.Length - 1 - j] >= 10)
                                        {
                                            arrFirstItm[arrFirstItm.Length - 2 - j] += arrFirstItm[arrFirstItm.Length - 1 - j] / 10;
                                            arrFirstItm[arrFirstItm.Length - 1 - j] = arrFirstItm[arrFirstItm.Length - 1 - j] % 10;
                                        }
                                        result[j] = arrFirstItm[j];
                                    }
                                }                           
                        }
                        break;
                    case "-":
                        //второе число 
                        itmForDiff = Console.ReadLine();
                        char[] arrThirdChar = itmForDiff.ToCharArray();
                        int[] arrItmForDiff = new int[arrThirdChar.Length];
                        for (i = 0; i < arrThirdChar.Length; i++)
                        {
                        

                            while (!int.TryParse(arrThirdChar[i].ToString(), out arrItmForDiff[i]))
                            {
                                Console.WriteLine("Write correctly");
                            }
                        }
                        if (arrFirstItm.Length > arrItmForDiff.Length)
                        {
                                result = new int[arrFirstItm.Length];

                                for (i = 0; i < arrFirstItm.Length; i++)
                                {
                                    result[result.Length - 1 - i] += arrFirstItm[arrFirstItm.Length - 1 - i];
                                }
                                for (i = 0; i < arrItmForDiff.Length; i++)
                                {
                                    if (result[result.Length - 1 - i] - arrItmForDiff[arrItmForDiff.Length - 1 - i] < 0)
                                    {
                                        result[result.Length - 1 - i] += 10;
                                        result[result.Length - 2 - i] -= 1;
                                    }
                                }
                                for (i = 0; i < result.Length; i++)
                                {
                                    if (result[result.Length - 1 - i] < 0)
                                    {
                                        result[result.Length - 1 - i] += 10;
                                        result[result.Length - 2 - i] -= 1;                                    
                                    }
                                }
                                for (j = 0; j < arrItmForDiff.Length; j++)
                                {
                                    result[result.Length - 1 - j] -= arrItmForDiff[arrItmForDiff.Length - 1 - j];                              
                                }
                                if (arrFirstItm[0] == 1)
                                {
                                    int[] resultTest = new int[result.Length];
                                    for (j = 0; j < result.Length; j++)
                                    {
                                        resultTest[result.Length - 1 - j] = result[result.Length - 1 - j];
                                    }
                                    for (j = 0; j < resultTest.Length; j++)
                                    {
                                        if (resultTest[j] <= arrFirstItm[j])
                                        {
                                            result = new int[arrFirstItm.Length - j - 1];
                                        }
                                    }
                                    for (j = 0; j < result.Length; j++)
                                    {
                                        result[result.Length - 1 - j] = resultTest[resultTest.Length - 1 - j];
                                    }
                                }
                        }
                        else if (arrFirstItm.Length < arrItmForDiff.Length)
                        {
                                result = new int[arrItmForDiff.Length];
           
                                for (i = 0; i < arrItmForDiff.Length; i++)
                                {
                                    result[result.Length - 1 - i] += arrItmForDiff[arrItmForDiff.Length - 1 - i];
                                }
                                for (i = 0; i < arrFirstItm.Length; i++)
                                {
                                    if (result[result.Length - 1 - i] - arrFirstItm[arrFirstItm.Length - 1 - i] < 0)
                                    {
                                        result[result.Length - 1 - i] += 10;
                                        result[result.Length - 2 - i] -= 1;
                                    }
                                }
                                for (i = 0; i < result.Length; i++)
                                {
                                    if (result[result.Length - 1 - i] < 0)
                                    {
                                        result[result.Length - 1 - i] += 10;
                                        result[result.Length - 2 - i] -= 1;
                                    }                    
                                }
                                for (j = 0; j < arrFirstItm.Length; j++)
                                {
                                    result[result.Length - 1 - j] -= arrFirstItm[arrFirstItm.Length - 1 - j];
                                }
                                if (arrItmForDiff[0] == 1)
                                {
                                    int[] resultTest = new int[result.Length];
                                    for (j = 0; j < result.Length; j++)
                                    {
                                        resultTest[result.Length - 1 - j] = result[result.Length - 1 - j];
                                    }
                                    for (j = 0; j < resultTest.Length; j++)
                                    {
                                        if (resultTest[j] <= arrItmForDiff[j])
                                        {
                                            result = new int[arrItmForDiff.Length - j - 1];
                                        }
                                    }
                                    for (j = 0; j < result.Length; j++)
                                    {
                                        result[result.Length - 1 - j] = resultTest[resultTest.Length - 1 - j];
                                    }
                                }
                                result[0] *= -1;                                              
                        }
                        else if (arrFirstItm.Length == arrItmForDiff.Length)
                        {
                                result = new int[arrFirstItm.Length];

                                for (i = 0; i < arrFirstItm.Length; i++)
                                {
                                    result[result.Length - 1 - i] += arrFirstItm[arrFirstItm.Length - 1 - i];
                                }
                                for (i = 0; i < arrFirstItm.Length; i++)
                                {
                                    if (result[result.Length - 1 - i] - arrItmForDiff[arrItmForDiff.Length - 1 - i] < 0)
                                    {
                                        result[result.Length - 1 - i] += 10;
                                        result[result.Length - 2 - i] -= 1;
                                    }
                                }
                                for (i = 0; i < result.Length; i++)
                                {
                                    if (result[result.Length - 1 - i] < 0)
                                    {
                                        result[result.Length - 1 - i] += 10;
                                        result[result.Length - 2 - i] -= 1;
                                    }
                                }
                                for (j = 0; j < arrItmForDiff.Length; j++)
                                {
                                    result[result.Length - 1 - j] -= arrItmForDiff[arrItmForDiff.Length - 1 - j];
                                }
                                if (arrFirstItm[0] == 1)
                                {
                                    int[] resultTest = new int[result.Length];
                                    for (j = 0; j < result.Length; j++)
                                    {
                                        resultTest[result.Length - 1 - j] = result[result.Length - 1 - j];
                                    }
                                    for (j = 0; j < result.Length; j++)
                                    {
                                        if (resultTest[j] <= arrFirstItm[j])
                                        {
                                            result = new int[arrFirstItm.Length - j - 1];
                                        }
                                    }
                                    for (j = 0; j < result.Length; j++)
                                    {
                                        result[result.Length - 1 - j] = resultTest[resultTest.Length - 1 - j];
                                    }
                                }                               
                        }//СЛОМАНО, работает не во всеми комбинациями чисел
                        break;
                }
                for (i = 0; i < result.Length; i++)
                {
                    Console.Write(result[i]);
                }
                Console.WriteLine();
            }
        }
    }
}