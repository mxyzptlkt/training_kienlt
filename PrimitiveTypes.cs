using System;

namespace PrimitiveTypes
{
    public class stringEx
    {
        public static void Ex1(string? inputString)
        {
            if (inputString == null)
            {
                Console.WriteLine("Chuỗi null");
            }
            else if (inputString == "")
            {
                Console.WriteLine("Chuỗi rỗng");
            }
            else if (String.IsNullOrWhiteSpace(inputString))
            {
                Console.WriteLine("Chuỗi space");
            }
            else
            {
                Console.WriteLine(inputString);
            }
        }
        public static void Ex2(string? inputString)
        {
            if (inputString == null)
            {
                Console.WriteLine("Chuỗi null");
            }
            else if (inputString == "")
            {
                Console.WriteLine("Chuỗi rỗng");
            }
            else if (String.IsNullOrWhiteSpace(inputString))
            {
                Console.WriteLine("Chuỗi space");
            }
            else
            {
                Console.WriteLine(inputString.Trim());
            }
        }
        public static void Ex3(string? inputString)
        {
            if (inputString == null)
            {
                Console.WriteLine("Chuỗi null");
            }
            else if (inputString == "")
            {
                Console.WriteLine("Chuỗi rỗng");
            }
            else if (String.IsNullOrWhiteSpace(inputString))
            {
                Console.WriteLine("Chuỗi space");
            }
            else
            {
                Console.WriteLine(inputString.Replace(" ",""));
            }
        }
        public static void Ex4(string? inputString)
        {
            if (inputString == null)
            {
                Console.WriteLine("Chuỗi null");
            }
            else if (inputString == "")
            {
                Console.WriteLine("Chuỗi rỗng");
            }
            else if (String.IsNullOrWhiteSpace(inputString))
            {
                Console.WriteLine("Chuỗi space");
            }
            else
            {
                char[] inputChar = inputString.ToCharArray();
                for (int index = 0; index < inputChar.Length - 1; index++)
                {
                    if (inputChar[index] == ' ')
                    {
                        inputChar[index + 1] = Char.ToUpper(inputChar[index + 1]);
                    }
                }
                string resultString = new string(inputChar);
                Console.WriteLine(resultString);
            }
        }
        public static void Ex5(string? inputString)
        {
            if (inputString == null)
            {
                Console.WriteLine("Chuỗi null");
            }
            else if (inputString == "")
            {
                Console.WriteLine("Chuỗi rỗng");
            }
            else if (String.IsNullOrWhiteSpace(inputString))
            {
                Console.WriteLine("Chuỗi space");
            }
            else
            {
                int spaceCount = 0;
                foreach (char c in inputString)
                {
                    if (c == ' ')
                    {
                        spaceCount++;
                    }
                }
                Console.WriteLine(spaceCount);
            }
        }
        public static void Ex6(string? inputString)
        {
            if (inputString == null)
            {
                Console.WriteLine("Chuỗi null");
            }
            else if (inputString == "")
            {
                Console.WriteLine("Chuỗi rỗng");
            }
            else if (String.IsNullOrWhiteSpace(inputString))
            {
                Console.WriteLine("Chuỗi space");
            }
            else
            {
                int nonSpaceCount = 0;
                foreach (char c in inputString)
                {
                    if (c != ' ')
                    {
                        nonSpaceCount++;
                    }
                }
                Console.WriteLine(nonSpaceCount);
            }
        }
        public static void Ex7(string? inputString1, string? inputString2)
            => Console.WriteLine(inputString1 == inputString2
                                ? $"{inputString1} == {inputString2}"
                                : $"{inputString1} != {inputString2}");
        public static void Ex8(string? inputString1, string? inputString2)
            => Console.WriteLine(inputString1?.ToLower() == inputString2?.ToLower() 
                                ? $"{inputString1} == {inputString2}"
                                : $"{inputString1} != {inputString2}");       
        public static void Ex9(string? inputString)
        {
            if (inputString == null)
            {
                Console.WriteLine("Chuỗi null");
            }
            else if (inputString == "")
            {
                Console.WriteLine("Chuỗi rỗng");
            }
            else if (String.IsNullOrWhiteSpace(inputString))
            {
                Console.WriteLine("Chuỗi space");
            }
            else
            {
                Console.WriteLine(inputString.Replace("ABC","DEF"));
            }
        }
        public static void Ex10(string? inputString)
        {
            if (inputString == null)
            {
                Console.WriteLine("Chuỗi null");
            }
            else if (inputString == "")
            {
                Console.WriteLine("Chuỗi rỗng");
            }
            else if (String.IsNullOrWhiteSpace(inputString))
            {
                Console.WriteLine("Chuỗi space");
            }
            else
            {
                Console.WriteLine($"Kính chào ông {inputString}. Chúc ngon miệng.");
            }
        }
        public static void Ex11(string? inputString)
        {
            if (inputString == null)
            {
                Console.WriteLine("Chuỗi null");
            }
            else if (inputString == "")
            {
                Console.WriteLine("Chuỗi rỗng");
            }
            else if (String.IsNullOrWhiteSpace(inputString))
            {
                Console.WriteLine("Chuỗi space");
            }
            else
            {
                char[] inputChar = inputString.ToCharArray();
                Array.Reverse(inputChar);
                string resultString = new string(inputChar);
                Console.WriteLine(resultString);
            }
        }
        public static void Ex12(string? inputString, int inputNumber)
        {
            if (inputString == null)
            {
                Console.WriteLine("Chuỗi null");
            }
            else if (inputString == "")
            {
                Console.WriteLine("Chuỗi rỗng");
            }
            else if (String.IsNullOrWhiteSpace(inputString))
            {
                Console.WriteLine("Chuỗi space");
            }
            else
            {   if (inputNumber >> 31 == -1)
                {
                    Console.WriteLine("Số < 0");
                }
                else
                {   
                    int nonSpaceCharIndex = 0;
                    for (int index = 0; index < inputString.Length; index++)
                    {
                        if (inputString[index] != ' ')
                        {
                            nonSpaceCharIndex = index;
                            break;
                        }
                    }
                    Console.WriteLine(inputString.Substring(nonSpaceCharIndex, inputNumber));
                }
            }
        }
        public static void Ex13(string? inputString, int inputNumber)
        {
            if (inputString == null)
            {
                Console.WriteLine("Chuỗi null");
            }
            else if (inputString == "")
            {
                Console.WriteLine("Chuỗi rỗng");
            }
            else if (String.IsNullOrWhiteSpace(inputString))
            {
                Console.WriteLine("Chuỗi space");
            }
            else
            {   if (inputNumber < 0)
                {
                    Console.WriteLine("Số nhỏ hơn 0");
                }
                else
                {
                    Console.WriteLine(inputString.Trim().Substring(0, inputNumber));
                }
            }
        }
        public static void Ex14(string? inputString, int inputNumber)
        {
            if (inputString == null)
            {
                Console.WriteLine("Chuỗi null");
            }
            else if (inputString == "")
            {
                Console.WriteLine("Chuỗi rỗng");
            }
            else if (String.IsNullOrWhiteSpace(inputString))
            {
                Console.WriteLine("Chuỗi space");
            }
            else
            {   if (inputNumber < 0)
                {
                    Console.WriteLine("Số nhỏ hơn 0");
                }
                else
                {
                    string resultString = inputString.Trim();
                    Console.WriteLine(resultString.Substring(resultString.Length - inputNumber, inputNumber));
                }
            }
        }
    }
    public class intEx
    {
        public static void Ex1(int inputNumber)
        {
            if (inputNumber >> 31 == -1)
            {
                Console.WriteLine("Số < 0");
            }
            else
            {
                Console.WriteLine((inputNumber & 1) == 0
                                    ? "Số chẵn" : "Số lẻ");
            }
        }
        public static void Ex2(int inputNumber)
            => Console.WriteLine(Math.Abs(inputNumber));
        public static void Ex3(int inputNumber)
            => Console.WriteLine(inputNumber >> 31 == -1 ? "Số < 0" : Math.Pow(2, inputNumber));
        public static void Ex4(int inputNumber1, int inputNumber2)
            => Console.WriteLine(inputNumber2 == 0
                                    ? "Số bị chia = 0"
                                    : $"{inputNumber1} chia {inputNumber2} bằng " +
                                      $"{inputNumber1 / inputNumber2} dư {inputNumber1 % inputNumber2}");
        public static void Ex5(int inputNumber)
        {
            if (inputNumber >> 31 == -1)
            {
                Console.WriteLine("Số < 0");
            }
            else
            {
                bool isPrime;
                isPrime = inputNumber == 1 ? true : false;
                for (int i = 2; i <= Math.Sqrt(inputNumber); i++)
                {
                    if (inputNumber % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine(isPrime ? "Số nguyên tố" : "Không phải số nguyên tố");
            }
        }
        public static void Ex6(string? inputString)
        {
            int inputNumber = 0;
            bool isSuccessCast = int.TryParse(inputString, out inputNumber);
            Console.WriteLine(isSuccessCast ? "Chuỗi số" : "Không phải chuỗi số");
        }
    }
    public class decimalEx
    {
        public static void Ex1(decimal inputNumber1, decimal inputNumber2, int inputNumber3)
            => Console.WriteLine(inputNumber2 == 0m
                                    ? "Số bị chia = 0"
                                    : Math.Round(inputNumber1 / inputNumber2, inputNumber3));
    }
    public class datetimeEx
    {
        public static void Ex1()
            => Console.WriteLine($"Hôm nay là ngày {DateTime.Now.Day}, tháng "
                               + $"{DateTime.Now.Month}, năm {DateTime.Now.Year}");
        public static void Ex2(DateTime inputDateTime)
            => Console.WriteLine($"Hôm nay là thứ {inputDateTime.DayOfWeek}, tháng "
                               + $"{inputDateTime.Month}, năm {inputDateTime.Year}");
        public static void Ex3(DateTime inputDateTime)
            => Console.WriteLine($"Hôm sau là thứ {(DayOfWeek)(((int)inputDateTime.DayOfWeek + 1) % 7)}, tháng "
                               + $"{inputDateTime.Month}, năm {inputDateTime.Year}");
        public static void Ex4(DateTime inputDateTime)
            => Console.WriteLine($"Hôm trước là thứ {(DayOfWeek)(((int)inputDateTime.DayOfWeek + 6) % 7)}, tháng "
                               + $"{inputDateTime.Month}, năm {inputDateTime.Year}");
        public static void Ex5(DateTime inputDateTime)
            => Console.WriteLine(inputDateTime < DateTime.Now
                                    ? "Ngày quá khứ"
                                    : (inputDateTime > DateTime.Now 
                                            ?"Ngày tương lai"
                                            : "Ngày hôm nay"));
        public static void Ex6(DateTime inputDateTime)
            => Console.WriteLine($"{inputDateTime:dd/MM/yyyy} \n"
                               + $"{inputDateTime:yyyy/MM/dd} \n"
                               + $"{inputDateTime:MM/yyyy} \n"
                               + $"{inputDateTime:MM-yyyy}");
        public static void Ex7(DateTime inputDateTime)
            => Console.WriteLine($"{(DayOfWeek)(((int)inputDateTime.DayOfWeek + 4) % 7)}");
        public static void Ex8(DateTime inputDateTime)
            => Console.WriteLine((new DateTime(inputDateTime.Year, inputDateTime.Month,
                                                DateTime.DaysInMonth(inputDateTime.Year,
                                                inputDateTime.Month))).DayOfWeek);
        public static void Ex10(DateTime inputDateTime)
            => Console.WriteLine((new DateTime(inputDateTime.Year, 12,
                                                DateTime.DaysInMonth(inputDateTime.Year, 12)))
                                                .DayOfWeek);
        public static void Ex11(DateTime inputDateTime1, DateTime inputDateTime2)
            => Console.WriteLine(Math.Abs((inputDateTime1 - inputDateTime2).Days));
    }
}
