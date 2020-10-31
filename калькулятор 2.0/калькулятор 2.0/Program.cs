using System;

namespace калькулятор_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1;
            string num2;
            string num3;

            string cond;

            int i = 0;
            int j = 0;
            int sum1 = 0;
            int sum2 = 0;


            while (true)
            {
                //первое число
                num1 = Console.ReadLine();
                char[] arr_n1 = num1.ToCharArray();
                int[] arr_num1 = new int[arr_n1.Length];
                for (i = 0; i < arr_n1.Length; i++)
                {
                    arr_num1[i] = int.Parse(arr_n1[i].ToString());
                }
                int[] result = new int[arr_num1.Length + 1];


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
                        num2 = Console.ReadLine();
                        char[] arr_n2 = num2.ToCharArray();
                        int[] arr_num2 = new int[arr_n2.Length];
                        for (i = 0; i < arr_n2.Length; i++)
                        {
                            arr_num2[i] = int.Parse(arr_n2[i].ToString());
                        }

                        //действие 1

                        if (arr_num1.Length > arr_num2.Length)
                        {

                                if (arr_num1[0] + 1 == 10)
                                {
                                    result = new int[arr_num1.Length + 1];
                                    for (i = 0; i < arr_num1.Length; i++)
                                    {


                                        result[result.Length - 1 - i] += arr_num1[arr_num1.Length - 1 - i];

                                    }

                                    for (j = 0; j < arr_num2.Length; j++)
                                    {
                                        result[result.Length - 1 - j] += arr_num2[arr_num2.Length - 1 - j];
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
                                    result = new int[arr_num1.Length];

                                for (i = 0; i < arr_num1.Length; i++)
                                {
                                    result[result.Length - 1 - i] += arr_num1[arr_num1.Length - 1 - i];
                                }

                                for (j = 0; j < arr_num2.Length; j++)
                                    {
                                    result[result.Length - 1 - j] += arr_num2[arr_num2.Length - 1 - j];
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

                        else if (arr_num1.Length < arr_num2.Length)
                        {

                                if (arr_num2[arr_num2.Length - 2] + 1 == 10)
                                {
                                    result = new int[arr_num2.Length + 1];


                                    for (i = 0; i < arr_num1.Length; i++)
                                    {


                                        result[result.Length - 1 - i] += arr_num1[i];

                                    }

                                    for (j = 0; j < arr_num2.Length; j++)
                                    {
                                        result[result.Length - 1 - j] += arr_num2[arr_num2.Length - 1 - j];
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
                                    result = new int[arr_num2.Length];

                                for (i = 0; i < arr_num2.Length; i++)
                                {
                                   result[result.Length - 1 - i] += arr_num2[arr_num2.Length - 1 - i];
                                }
                                for (j = 0; j < arr_num1.Length; j++)
                                    {
                                    result[result.Length - 1 - j] += arr_num1[arr_num1.Length - 1 - j];
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

                        else if (arr_num1.Length == arr_num2.Length)
                        {
                            
                                if (arr_num1[0] + arr_num2[0] >= 10)
                                {
                                    result = new int[arr_num1.Length + 1];

                                    for (i = 0; i < arr_num1.Length; i++)
                                    {


                                        result[result.Length - 1 - i] += arr_num1[arr_num1.Length - 1 - i];

                                    }

                                    for (j = 0; j < arr_num2.Length; j++)
                                    {
                                        result[result.Length - 1 - j] += arr_num2[arr_num2.Length - 1 - j];
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
                                    result = new int[arr_num1.Length];
                                    for (j = 0; j < arr_num2.Length; j++)
                                    {
                                        arr_num1[arr_num1.Length - 1 - j] += arr_num2[arr_num2.Length - 1 - j];
                                    };

                                    for (j = 0; j < arr_num1.Length; j++)
                                    {
                                        while (arr_num1[arr_num1.Length - 1 - j] >= 10)
                                        {
                                            arr_num1[arr_num1.Length - 2 - j] += arr_num1[arr_num1.Length - 1 - j] / 10;
                                            arr_num1[arr_num1.Length - 1 - j] = arr_num1[arr_num1.Length - 1 - j] % 10;
                                        }

                                        result[j] = arr_num1[j];

                                    }
                                }
                            
                        }

                        break;
                    case "-":

                        //второе число 
                        num3 = Console.ReadLine();
                        char[] arr_n3 = num3.ToCharArray();
                        int[] arr_num3 = new int[arr_n3.Length];
                        for (i = 0; i < arr_n3.Length; i++)
                        {
                            arr_num3[i] = int.Parse(arr_n3[i].ToString());
                        }

                        if (arr_num1.Length > arr_num3.Length)
                        {

                                result = new int[arr_num1.Length];


                                for (i = 0; i < arr_num1.Length; i++)
                                {

                                    result[result.Length - 1 - i] += arr_num1[arr_num1.Length - 1 - i];

                                }

                                for (i = 0; i < arr_num3.Length; i++)
                                {
                                    if (result[result.Length - 1 - i] - arr_num3[arr_num3.Length - 1 - i] < 0)
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

                                for (j = 0; j < arr_num3.Length; j++)
                                {

                                    result[result.Length - 1 - j] -= arr_num3[arr_num3.Length - 1 - j];


                                }

                                if (arr_num1[0] == 1)
                                {
                                    int[] resultTest = new int[result.Length];
                                    for (j = 0; j < result.Length; j++)
                                    {
                                        resultTest[result.Length - 1 - j] = result[result.Length - 1 - j];
                                    }


                                    for (j = 0; j < resultTest.Length; j++)
                                    {

                                        if (resultTest[j] <= arr_num1[j])
                                        {
                                            result = new int[arr_num1.Length - j - 1];
                                        }

                                    }
                                    for (j = 0; j < result.Length; j++)
                                    {
                                        result[result.Length - 1 - j] = resultTest[resultTest.Length - 1 - j];
                                    }
                                }
                        }

                        else if (arr_num1.Length < arr_num3.Length)
                        {

                                result = new int[arr_num3.Length];


                                for (i = 0; i < arr_num3.Length; i++)
                                {

                                    result[result.Length - 1 - i] += arr_num3[arr_num3.Length - 1 - i];

                                }

                                for (i = 0; i < arr_num1.Length; i++)
                                {
                                    if (result[result.Length - 1 - i] - arr_num1[arr_num1.Length - 1 - i] < 0)
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

                                for (j = 0; j < arr_num1.Length; j++)
                                {

                                    result[result.Length - 1 - j] -= arr_num1[arr_num1.Length - 1 - j];


                                }



                                if (arr_num3[0] == 1)
                                {
                                    int[] resultTest = new int[result.Length];
                                    for (j = 0; j < result.Length; j++)
                                    {
                                        resultTest[result.Length - 1 - j] = result[result.Length - 1 - j];
                                    }


                                    for (j = 0; j < resultTest.Length; j++)
                                    {

                                        if (resultTest[j] <= arr_num3[j])
                                        {
                                            result = new int[arr_num3.Length - j - 1];
                                        }

                                    }
                                    for (j = 0; j < result.Length; j++)
                                    {
                                        result[result.Length - 1 - j] = resultTest[resultTest.Length - 1 - j];
                                    }
                                }
                                result[0] *= -1;
                       
                          
                        }

                        else if (arr_num1.Length == arr_num3.Length)
                        {

                            for (i = 0; i < arr_num3.Length; i++)
                            {
                                sum2 += arr_num3[i];
                            }

                            for (i = 0; i < arr_num1.Length; i++)
                            {
                                sum1 += arr_num1[i];
                            }


                         

                                result = new int[arr_num1.Length];


                                for (i = 0; i < arr_num1.Length; i++)
                                {

                                    result[result.Length - 1 - i] += arr_num1[arr_num1.Length - 1 - i];

                                }

                                for (i = 0; i < arr_num1.Length; i++)
                                {
                                    if (result[result.Length - 1 - i] - arr_num3[arr_num3.Length - 1 - i] < 0)
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

                                for (j = 0; j < arr_num3.Length; j++)
                                {

                                    result[result.Length - 1 - j] -= arr_num3[arr_num3.Length - 1 - j];


                                }

                                if (arr_num1[0] == 1)
                                {
                                    int[] resultTest = new int[result.Length];
                                    for (j = 0; j < result.Length; j++)
                                    {
                                        resultTest[result.Length - 1 - j] = result[result.Length - 1 - j];
                                    }


                                    for (j = 0; j < result.Length; j++)
                                    {

                                        if (resultTest[j] <= arr_num1[j])
                                        {
                                            result = new int[arr_num1.Length - j - 1];
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