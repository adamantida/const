﻿using System;

namespace asd
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("впишите знак % если он есть, если нету, то впишите -");
            var a = Console.ReadLine();
            if (a == "%")
            {
                float one, two, tree, fore,five,six,seven,ni2;
                float p1, p2;
                float all;
                Console.WriteLine("впишите десятичные или сотые: ");
                one = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("впишите десятичные или сотые2: ");
                two = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("впишите единичные или ...: ");
                tree = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("впишите единичные или ...2: ");
                fore = Convert.ToSingle(Console.ReadLine());
                // -----------------------------------work------------------------------------
                five = one / 100;
                six = two / 100;
                seven = tree / 100;
                ni2 = fore / 100;
                //-----------------------------------------------------------------------------
                p1 = five * seven;
                p2 = six * ni2;
                all = p1 + p2;
                Console.WriteLine("Ответ " + all);
                Console.ReadKey();
            }
            if (a == "-")
            {
                float inp1, inp2, inp3, inp4;
                float sum1, sum2;
                float allsum, allsum2;
                Console.WriteLine("введите вероятность 1: ");
                inp1 = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("введите вероятность 2: ");
                inp2 = Convert.ToSingle(Console.ReadLine());
                //-------------------------------------------------------------------------------
                                        string dop;
                                        float dop1, dop2;
                                        Console.WriteLine("есть ли дополнительные условия?(Y,n)(Всего вещей  = из них): ");
                                        dop = Console.ReadLine();
                                        if (dop == "Y")
                                        {
                                            Console.WriteLine("Вещь: ");
                                            dop1 = Convert.ToSingle(Console.ReadLine());
                                            Console.WriteLine("из них: ");
                                            dop2 = Convert.ToSingle(Console.ReadLine());
                                            float inp5 = (dop2 / dop1);
                                            float inp6 = 1 - inp5;
                                            float sum3 = inp5 * inp1;
                                            float sum4 = inp6 * inp2;
                                            float sum5 = sum3 + sum4;
                                            Console.WriteLine("Вероятность попадения: "+ sum5);
                                            float sum6 = 1 - sum5;
                                            Console.WriteLine("Вероятность промаха: " + sum6);
                                            Console.ReadLine();
                                        }
                                        if (dop == "y")
                                        {
                                            Console.WriteLine("Вещь: ");
                                            dop1 = Convert.ToSingle(Console.ReadLine());
                                            Console.WriteLine("из них: ");
                                            dop2 = Convert.ToSingle(Console.ReadLine());
                                            float inp5 = (dop2 / dop1);
                                            float inp6 = 1 - inp5;
                                            float sum3 = inp5 * inp1;
                                            float sum4 = inp6 * inp2;
                                            float sum5 = sum3 + sum4;
                                            Console.WriteLine("Вероятность попадения: "+ sum5);
                                            float sum6 = 1 - sum5;
                                            Console.WriteLine("Вероятность промаха: " + sum6);
                                            Console.ReadLine();
                                        }
                else
                {
                    //--------------------------------------------------------------------------------
                    inp3 = 1 - inp1;
                    inp4 = 1 - inp2;
                    sum1 = inp1 * inp3;
                    sum2 = inp2 * inp4;
                    allsum = sum1 + sum2;
                    allsum2 = allsum * 2;
                    Console.WriteLine("вероятность промоха: " + allsum2);
                    Console.ReadKey();
                }
            }
        }
    }
}
