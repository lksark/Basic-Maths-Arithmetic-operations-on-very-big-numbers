using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffieHellman_KeyExchange
{
    static class MathArithmetic
    {
        public static int CompareTo_UnlimitedDataSize(List<int> list_a, List<int> list_b)
        {
            // this CompareTo does not compare number with decimal value
            if (list_a.Count > list_b.Count)
                return 1;
            else if (list_a.Count < list_b.Count)
                return -1;
            else
            {
                for (int i = list_a.Count - 1; i >= 0; i--)
                {
                    if (list_a[i] > list_b[i])
                        return 1;
                    else if (list_a[i] < list_b[i])
                        return -1;
                    else
                        ;
                }
            }

            return 0;
        }

        public static string Addition_UnlimitedDataSize(string a, string b)
        {
            List<int> list_a = new List<int>();
            int count_a_Decimal = 0;
            List<int> list_b = new List<int>();
            int count_b_Decimal = 0;
            List<int> list_result_addition = new List<int>();

            bool isDecimal = false;

            try
            {
                a = a.Trim();
                b = b.Trim();

                int temp_int;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a.Substring(i, 1) == ".")
                        isDecimal = true;
                    else
                    {
                        if (!int.TryParse(a.Substring(i, 1), out temp_int))
                            throw new FormatException();

                        if (isDecimal)
                            count_a_Decimal++;

                        list_a.Insert(0, temp_int);
                    }
                }

                isDecimal = false;
                for (int i = 0; i < b.Length; i++)
                {
                    if (b.Substring(i, 1) == ".")
                        isDecimal = true;
                    else
                    {
                        if (!int.TryParse(b.Substring(i, 1), out temp_int))
                            throw new FormatException();

                        if (isDecimal)
                            count_b_Decimal++;
                        
                        list_b.Insert(0, temp_int);
                    }
                }

                if(count_a_Decimal > count_b_Decimal)
                {
                    for(int i = 0; i < count_a_Decimal - count_b_Decimal; i++)
                        list_b.Insert(0, 0);
                }
                if (count_a_Decimal < count_b_Decimal)
                {
                    for (int i = 0; i < count_b_Decimal - count_a_Decimal; i++)
                        list_a.Insert(0, 0);
                }
                else
                    ;

            }
            catch (FormatException e)
            {
                Console.WriteLine("You have entered non-numeric characters");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e);
            }

            list_result_addition = Addition_UnlimitedDataSize(list_a, list_b).ToList();

            string string_result_Addition = "";
            for (int i = list_result_addition.Count() - 1; i >= 0; i--)
                string_result_Addition += list_result_addition[i].ToString();

            // when either a or b has decimal
            if(count_a_Decimal > 0 || count_b_Decimal > 0)
            {
                if (count_a_Decimal >= count_b_Decimal)
                    string_result_Addition = string_result_Addition.Insert(string_result_Addition.Count() - count_a_Decimal, ".");
                else //(count_a_Decimal < count_b_Decimal)
                    string_result_Addition = string_result_Addition.Insert(string_result_Addition.Count() - count_b_Decimal, ".");

                while (string_result_Addition[string_result_Addition.Length - 1] == '0')
                    string_result_Addition = string_result_Addition.Remove(string_result_Addition.Length - 1);
            }

            return string_result_Addition;
        }

        public static List<int> Addition_UnlimitedDataSize(List<int> list_a, List<int> list_b)
        {
            List<int> list_result_addition = new List<int>();

            int result_addition;
            int index = 0;
            int nextDigit_Add1 = 0;

            if (list_a.Count > list_b.Count)
            {
                foreach (int _list_a in list_a)
                {
                    if (index < list_b.Count)
                        result_addition = _list_a + list_b.ElementAt(index) + nextDigit_Add1;
                    else
                        result_addition = _list_a + nextDigit_Add1;
                    index++;

                    nextDigit_Add1 = 0;
                    if (result_addition > 9)
                    {
                        nextDigit_Add1 = 1;
                        result_addition -= 10;
                    }
                    list_result_addition.Add(result_addition);
                }
            }
            else
            {
                foreach (int _list_b in list_b)
                {
                    if (index < list_a.Count)
                        result_addition = list_a.ElementAt(index) + _list_b + nextDigit_Add1;
                    else
                        result_addition = _list_b;
                    index++;

                    nextDigit_Add1 = 0;
                    if (result_addition > 9)
                    {
                        nextDigit_Add1 = 1;
                        result_addition -= 10;
                    }
                    list_result_addition.Add(result_addition);
                }
            }

            if (nextDigit_Add1 == 1)
                list_result_addition.Add(1);

            return list_result_addition;
        }

        public static string Minus_UnlimitedDataSize(string a, string b)
        {
            List<int> list_a = new List<int>();
            int count_a_Decimal = 0;
            List<int> list_b = new List<int>();
            int count_b_Decimal = 0;
            List<int> list_result_minus = new List<int>();

            bool isDecimal = false;

            try
            {
                a = a.Trim();
                b = b.Trim();

                int temp_int;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a.Substring(i, 1) == ".")
                        isDecimal = true;
                    else
                    {
                        if (!int.TryParse(a.Substring(i, 1), out temp_int))
                            throw new FormatException();

                        if (isDecimal)
                            count_a_Decimal++;

                        list_a.Insert(0, temp_int);
                    }
                }

                isDecimal = false;
                for (int i = 0; i < b.Length; i++)
                {
                    if (b.Substring(i, 1) == ".")
                        isDecimal = true;
                    else
                    {
                        if (!int.TryParse(b.Substring(i, 1), out temp_int))
                            throw new FormatException();

                        if (isDecimal)
                            count_b_Decimal++;

                        list_b.Insert(0, temp_int);
                    }
                }

                if (count_a_Decimal > count_b_Decimal)
                {
                    for (int i = 0; i < count_a_Decimal - count_b_Decimal; i++)
                        list_b.Insert(0, 0);
                }
                if (count_a_Decimal < count_b_Decimal)
                {
                    for (int i = 0; i < count_b_Decimal - count_a_Decimal; i++)
                        list_a.Insert(0, 0);
                }
                else
                    ;

            }
            catch (FormatException e)
            {
                Console.WriteLine("You have entered non-numeric characters");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e);
            }

            list_result_minus = Minus_UnlimitedDataSize(list_a, list_b).ToList();

            string string_result = "";

            if(list_result_minus.Last() == -1)
                string_result += "-";
            else
                string_result += list_result_minus.Last().ToString();

            for (int i = list_result_minus.Count() - 2; i >= 0; i--)
                string_result += list_result_minus[i].ToString();

            // when either a or b has decimal
            if (count_a_Decimal > 0 || count_b_Decimal > 0)
            {
                if (count_a_Decimal >= count_b_Decimal)
                    string_result = string_result.Insert(string_result.Count() - count_a_Decimal, ".");
                else //(count_a_Decimal < count_b_Decimal)
                    string_result = string_result.Insert(string_result.Count() - count_b_Decimal, ".");

                while (string_result[string_result.Length - 1] == '0')
                    string_result = string_result.Remove(string_result.Length - 1);
            }

            if (string_result[0] == '.')
                string_result = "0" + string_result;

            if (string_result[0] == '-' && string_result[1] == '.')
                string_result = string_result.Insert(1, "0");

            return string_result;
        }

        public static List<int> Minus_UnlimitedDataSize(List<int> list_a, List<int> list_b)
        {
            List<int> list_result_minus = new List<int>();

            int index = 0;
            int nextDigit_Deduct1 = 0;
            int result_minus;
            bool isPositiveResult = true;

            if (CompareTo_UnlimitedDataSize(list_a, list_b) == 1)
            {
                foreach (int _list_a in list_a)
                {
                    if (index < list_b.Count)
                    {
                        if (_list_a + nextDigit_Deduct1 >= list_b[index])
                        {
                            result_minus = _list_a - list_b[index] + nextDigit_Deduct1;
                            nextDigit_Deduct1 = 0;
                        }
                        else
                        {
                            result_minus = 10 + _list_a - list_b[index] + nextDigit_Deduct1;
                            nextDigit_Deduct1 = -1;
                        }
                        index++;
                    }
                    else
                    {
                        if (_list_a + nextDigit_Deduct1 >= 0)
                        {
                            result_minus = _list_a + nextDigit_Deduct1;
                            nextDigit_Deduct1 = 0;
                        }
                        else
                        {
                            result_minus = 10 + _list_a + nextDigit_Deduct1;
                            nextDigit_Deduct1 = -1;
                        }
                            
                    }

                    list_result_minus.Add(result_minus);
                }
            }
            else if (CompareTo_UnlimitedDataSize(list_a, list_b) == 0)
            {
                // when a and b are exactly same value, a - b = 0
                list_result_minus.Add(0);
            }
            else
            {
                foreach (int _list_b in list_b)
                {
                    if (index < list_a.Count)
                    {
                        if (_list_b + nextDigit_Deduct1 >= list_a[index])
                        {
                            result_minus = _list_b - list_a[index] + nextDigit_Deduct1;
                            nextDigit_Deduct1 = 0;
                        }
                        else
                        {
                            result_minus = 10 + _list_b - list_a[index] + nextDigit_Deduct1;
                            nextDigit_Deduct1 = -1;
                        }
                        index++;
                    }
                    else
                    {
                        if (nextDigit_Deduct1 != 0)
                        {
                            result_minus = _list_b + nextDigit_Deduct1;
                            nextDigit_Deduct1 = 0;
                        }
                        else
                            result_minus = _list_b;
                    }

                    list_result_minus.Add(result_minus);
                }

                isPositiveResult = false;
            }

            // if result more than or equal to 2 digits, remove if biggest index element are 0
            while (list_result_minus.Count() > 1 && list_result_minus.Last() == 0)
                list_result_minus.RemoveAt(list_result_minus.Count - 1);

            if (!isPositiveResult)
                list_result_minus.Add(-1);

            return list_result_minus;
        }

        public static string Multiplication_UnlimitedDataSize(string a, string b)
        {
            List<int> list_a = new List<int>();
            List<int> list_b = new List<int>();
            List<int> list_result_multiplication = new List<int>();
            List<int> list_result_decimal_multiplication = new List<int>();

            bool isDecimal = false;
            int count_Decimal = 0;

            try
            {
                a = a.Trim();
                b = b.Trim();

                int temp_int;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a.Substring(i, 1) == ".")
                        isDecimal = true;
                    else
                    {
                        if (!int.TryParse(a.Substring(i, 1), out temp_int))
                            throw new FormatException();

                        if (isDecimal)
                            count_Decimal++;

                        list_a.Insert(0, temp_int);
                    }
                }

                // remove 0 on right of a_decimal
                if(isDecimal)
                {
                    while (list_a[0] == 0)
                    {
                        list_a.RemoveAt(0);
                        count_Decimal--;
                    }
                }

                isDecimal = false;
                for (int i = 0; i < b.Length; i++)
                {
                    if (b.Substring(i, 1) == ".")
                        isDecimal = true;
                    else
                    {
                        if (!int.TryParse(b.Substring(i, 1), out temp_int))
                            throw new FormatException();

                        if (isDecimal)
                            count_Decimal++;
                        
                        list_b.Insert(0, temp_int);
                    }
                }

                // remove 0 on right of b_decimal
                if (isDecimal)
                {
                    while (list_b[0] == 0)
                    {
                        list_b.RemoveAt(0);
                        count_Decimal--;
                    }
                        
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("You have entered non-numeric characters");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e);
            }

            list_result_multiplication = Multiplication_UnlimitedDataSize(list_a, list_b).ToList();

            string string_result_multiplication = "";

            for(int i = list_result_multiplication.Count() - 1; i >= 0; i--)
                string_result_multiplication += list_result_multiplication[i].ToString();

            // when either a & b has decimal
            if (count_Decimal > 0)
            {
                string_result_multiplication = string_result_multiplication.Insert(string_result_multiplication.Count() - count_Decimal, ".");

                while (string_result_multiplication[string_result_multiplication.Length - 1] == '0')
                    string_result_multiplication = string_result_multiplication.Remove(string_result_multiplication.Length - 1);
            }

            return string_result_multiplication;
        }

        public static List<int> Multiplication_UnlimitedDataSize(List<int> list_a, List<int> list_b)
        {
            List<int> list_result_multiplication = new List<int>();

            int curr_digit = 0;
            int curr_digit_b = 0;
            foreach (int _b in list_b)
            {
                foreach (int _a in list_a)
                {
                    int _temp_result_mutiplication = _a * _b;
                    if (list_result_multiplication.Count == curr_digit + curr_digit_b)
                        list_result_multiplication.Add(_temp_result_mutiplication % 10);
                    else
                    {
                        list_result_multiplication[curr_digit + curr_digit_b] += _temp_result_mutiplication % 10;
                        if (list_result_multiplication[curr_digit + curr_digit_b] > 9)
                        {
                            if (list_result_multiplication.Count == curr_digit + curr_digit_b + 1)
                                list_result_multiplication.Add((int)(list_result_multiplication[curr_digit + curr_digit_b] / 10));
                            else
                                list_result_multiplication[curr_digit + curr_digit_b + 1] += (int)(list_result_multiplication[curr_digit + curr_digit_b] / 10);

                            list_result_multiplication[curr_digit + curr_digit_b] %= 10;
                        }
                    }

                    if (_temp_result_mutiplication > 9)
                    {
                        if (list_result_multiplication.Count == curr_digit + curr_digit_b + 1)
                            list_result_multiplication.Add((int)(_temp_result_mutiplication / 10));
                        else
                        {
                            list_result_multiplication[curr_digit + curr_digit_b + 1] += (int)(_temp_result_mutiplication / 10);
                            if (list_result_multiplication[curr_digit + curr_digit_b + 1] > 9)
                            {
                                if (list_result_multiplication.Count == curr_digit + curr_digit_b + 2)
                                    list_result_multiplication.Add((int)(list_result_multiplication[curr_digit + curr_digit_b + 1] / 10));
                                else
                                    list_result_multiplication[curr_digit + curr_digit_b + 2] += (int)(list_result_multiplication[curr_digit + curr_digit_b + 1] / 10);

                                list_result_multiplication[curr_digit + curr_digit_b + 1] %= 10;
                            }
                        }

                    }

                    curr_digit++;
                }

                ++curr_digit_b;
                curr_digit = 0;
            }

            return list_result_multiplication;
        }

        public static string Division_UnlimitedDataSize(string a, string b)
        {
            int setting_count_decimal = 20;

            List<int> list_a = new List<int>();
            List<int> list_b = new List<int>();
            List<int> list_result_division = new List<int>();
            List<int> list_result_division_residue = new List<int>();
            List<int> list_result_division_decimal = new List<int>();
            Tuple<List<int>, List<int>> tuple_Lists_Result_Residue = new Tuple<List<int>, List<int>>(new List<int>(), new List<int>());

            int count_a_Decimal = 0;
            int count_b_Decimal = 0;
            int count_Result_DecimalPosition = 0;
            bool isDecimal = false;

            try
            {
                a = a.Trim();
                b = b.Trim();

                int temp_int;
                isDecimal = false;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a.Substring(i, 1) == ".")
                        isDecimal = true;
                    else
                    {
                        if (!int.TryParse(a.Substring(i, 1), out temp_int))
                            throw new FormatException();

                        if (isDecimal)
                            count_a_Decimal++;

                        list_a.Insert(0, temp_int);
                    }
                }

                while (list_a.Last() == 0)
                    list_a.RemoveAt(list_a.Count() - 1);

                // remove 0 on right of a_decimal
                if (isDecimal)
                {
                    while (list_a[0] == 0)
                    {
                        list_a.RemoveAt(0);
                        count_a_Decimal--;
                    }
                }

                isDecimal = false;
                for (int i = 0; i < b.Length; i++)
                {
                    if (b.Substring(i, 1) == ".")
                        isDecimal = true;
                    else
                    {
                        if (!int.TryParse(b.Substring(i, 1), out temp_int))
                            throw new FormatException();

                        if (isDecimal)
                            count_b_Decimal++;

                        list_b.Insert(0, temp_int);
                    }
                }

                while (list_b.Last() == 0)
                    list_b.RemoveAt(list_b.Count() - 1);

                // remove 0 on right of b_decimal
                if (isDecimal)
                {
                    while (list_b[0] == 0)
                    {
                        list_b.RemoveAt(0);
                        count_b_Decimal--;
                    }

                }

                if (count_a_Decimal < count_b_Decimal)
                {
                    for (int i = 0; i < (count_b_Decimal - count_a_Decimal); i++)
                        list_a.Insert(0, 0);

                    count_a_Decimal = 0;
                    count_b_Decimal = 0;
                }
                else if (count_a_Decimal > count_b_Decimal)
                {
                    for (int i = 0; i < (count_a_Decimal - count_b_Decimal); i++)
                        list_b.Insert(0, 0);

                    count_a_Decimal = 0;
                    count_b_Decimal = 0;
                }
                else
                    ;
            }
            catch (FormatException)
            {
                Console.WriteLine("String a or String b are not integer");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception");
            }

            // compute division
            if (CompareTo_UnlimitedDataSize(list_a, list_b) > 0)
            {
                tuple_Lists_Result_Residue = Division_UnlimitedDataSize(list_a, list_b);
                list_result_division = tuple_Lists_Result_Residue.Item1.ToList();
                while(list_result_division.Last() == 0)
                    list_result_division.RemoveAt(list_result_division.Count() - 1);

                if (tuple_Lists_Result_Residue.Item2.Count > 0)
                {
                    list_result_division_residue = tuple_Lists_Result_Residue.Item2.ToList();
                }
            }
            else if (CompareTo_UnlimitedDataSize(list_a, list_b) == 0)
            {
                return "1";
            }
            else
            {
                list_result_division_residue = list_a.ToList();
            }

            // This segment code compute out decimal result of division
            if(list_result_division_residue.Count() > 0)
            {
                count_Result_DecimalPosition = list_b.Count() - list_result_division_residue.Count();

                for (int i = 0; i < count_Result_DecimalPosition; i++)
                    list_result_division_residue.Insert(0, 0);
                if (CompareTo_UnlimitedDataSize(list_result_division_residue, list_b) < 0)
                {
                    count_Result_DecimalPosition += 1;
                    list_result_division_residue.Insert(0, 0);
                }

                // Add 20 digit '0' at the back of list_result_division_residue
                //for (int i = 0; i < setting_count_decimal - list_result_division_residue.Count(); i++)
                //for (int i = 0; i < setting_count_decimal; i++)
                for (int i = 0; i < list_b.Count() * 50; i++)
                    list_result_division_residue.Insert(0, 0);

                tuple_Lists_Result_Residue = Division_UnlimitedDataSize(list_result_division_residue, list_b);
                
                list_result_division_decimal = tuple_Lists_Result_Residue.Item1.ToList();

                if (tuple_Lists_Result_Residue.Item2.Count() > 0)
                {
                    Tuple<List<int>, List<int>> tuple_Lists_half_list_b = Division_UnlimitedDataSize(list_b, new List<int>() {2 });

                    List<int> lists_half_list_b = tuple_Lists_half_list_b.Item1.ToList();
                    if (tuple_Lists_half_list_b.Item2.Count() > 0)
                        lists_half_list_b[0]++;

                    if (CompareTo_UnlimitedDataSize(tuple_Lists_Result_Residue.Item2, lists_half_list_b) >= 0)
                        list_result_division_decimal[0]++;
                }

                while (list_result_division_decimal[0] == 0)
                    list_result_division_decimal.RemoveAt(0);

                if(count_Result_DecimalPosition - 1 > 0)
                    for(int i = 0; i < count_Result_DecimalPosition - 1; i++)
                        list_result_division_decimal.Add(0);
            }
            // This segment code compute out decimal result of division

            // print result of division
            string string_result = "";
            if(list_result_division.Count() > 0)
            {
                foreach (int _result_division in list_result_division)
                    string_result = _result_division.ToString() + string_result;
            }
            else
                string_result += "0";

            if (list_result_division_decimal.Count > 0)
            {
                string_result += ".";

                int count_decimal_toPrint = list_result_division_decimal.Count() - 50;
                if (count_decimal_toPrint < 0)
                    count_decimal_toPrint = 0;

                for (int i = list_result_division_decimal.Count() - 1; i > count_decimal_toPrint; i--)
                    string_result += list_result_division_decimal[i].ToString();

                if(count_decimal_toPrint > 0)
                {
                    if (list_result_division_decimal[count_decimal_toPrint - 1] > 4)
                        string_result += (list_result_division_decimal[count_decimal_toPrint] + 1).ToString();
                    else
                        string_result += (list_result_division_decimal[count_decimal_toPrint]).ToString();
                }
                else
                    string_result += (list_result_division_decimal[count_decimal_toPrint]).ToString();

            }

            return string_result;
        }

        public static Tuple<List<int>, List<int>> Division_UnlimitedDataSize(List<int> list_a, List<int> list_b)
        {
            List<int> list_result_division_residue = new List<int>();
            List<int> list_division_multiplication = new List<int>();
            List<int> list_result = new List<int>();

            int temp_index_list_a_start = 0;

            temp_index_list_a_start = list_a.Count() - list_b.Count();
            List<int> list_temp_2 = new List<int>();
            List<int> list_temp_1 = list_a.GetRange(temp_index_list_a_start, list_b.Count());
            while (CompareTo_UnlimitedDataSize(list_temp_1, list_b) < 0 && temp_index_list_a_start - 1 >= 0)
            {
                temp_index_list_a_start--;
                list_temp_1.Insert(0, list_a[temp_index_list_a_start]);
            }

            while (temp_index_list_a_start > 0)
            {
                if (CompareTo_UnlimitedDataSize(list_temp_1, list_b) > 0)
                {
                    list_temp_2 = list_b.ToList();

                    list_division_multiplication.Clear();
                    list_division_multiplication.Add(1);
                    while (CompareTo_UnlimitedDataSize(list_temp_1, list_temp_2) > 0)
                    {
                        list_temp_2 = Addition_UnlimitedDataSize(list_temp_2, list_b);
                        list_division_multiplication = Addition_UnlimitedDataSize(list_division_multiplication, new List<int>() { 1 }).ToList();
                    }

                    if (CompareTo_UnlimitedDataSize(list_temp_1, list_temp_2) < 0)
                    {
                        //when list_temp_1 divided by list_b has residue
                        list_division_multiplication = Minus_UnlimitedDataSize(list_division_multiplication, new List<int>() { 1 }).ToList();
                        list_temp_2 = Minus_UnlimitedDataSize(list_temp_2, list_b).ToList();
                        list_temp_1 = Minus_UnlimitedDataSize(list_temp_1, list_temp_2).ToList();
                    }
                    else
                        list_temp_1.Clear();

                    for (int i = list_division_multiplication.Count() - 1; i >= 0; i--)
                        list_result.Insert(0, list_division_multiplication[i]);
                    list_division_multiplication.Clear();

                    // shift temp_index_list_a_start 1 digit to the right
                    temp_index_list_a_start--;
                    list_temp_1.Insert(0, list_a[temp_index_list_a_start]);
                }
                else if (CompareTo_UnlimitedDataSize(list_temp_1, list_b) == 0)
                {
                    if (list_result.Count() != 0)
                    {
                        for (int i = 0; i < list_b.Count() - 1; i++)
                            list_result.Insert(0, 0);
                    }
                    list_result.Insert(0, 1);

                    // shift index list_b.Length to the right
                    temp_index_list_a_start -= list_b.Count();

                    if (temp_index_list_a_start < 0)
                        temp_index_list_a_start = 0;

                    list_temp_1.Clear();
                    list_temp_1 = list_a.GetRange(temp_index_list_a_start, list_b.Count());
                }
                else
                {
                    //when list_temp_1 smaller than list_b

                    // when list_temp_1 value is 0
                    if (list_temp_1.Count() == 1 && list_temp_1[0] == 0)
                        list_temp_1.Clear();

                    temp_index_list_a_start -= 1;
                    list_temp_1.Insert(0, list_a[temp_index_list_a_start]);
                    list_result.Insert(0, 0);
                }
            }

            // when temp_index_list_a_start at index '0'
            if (CompareTo_UnlimitedDataSize(list_temp_1, list_b) >= 0)
            {
                list_division_multiplication.Clear();
                list_division_multiplication.Add(1);
                list_temp_2 = list_b.ToList();
                while (CompareTo_UnlimitedDataSize(list_temp_1, list_temp_2) > 0)
                {
                    list_temp_2 = Addition_UnlimitedDataSize(list_temp_2, list_b).ToList();
                    list_division_multiplication = Addition_UnlimitedDataSize(list_division_multiplication, new List<int>() { 1 }).ToList();
                }

                if (CompareTo_UnlimitedDataSize(list_temp_1, list_temp_2) < 0)
                {
                    //when list_temp_1 divided by list_b has residue
                    list_division_multiplication = Minus_UnlimitedDataSize(list_division_multiplication, new List<int>() { 1 }).ToList();
                    list_temp_2 = Minus_UnlimitedDataSize(list_temp_2, list_b).ToList();
                    list_result_division_residue = Minus_UnlimitedDataSize(list_temp_1, list_temp_2).ToList();
                    // if no residue, do nothing
                }

                for (int i = list_division_multiplication.Count() - 1; i >= 0; i--)
                    list_result.Insert(0, list_division_multiplication[i]);
                list_division_multiplication.Clear();
            }
            else
                list_result.Insert(0, 0);

            return new Tuple<List<int>, List<int>>(list_result, list_result_division_residue);
        }

        public static string Modular_UnlimitedDataSize(string a, string b)         // a%b
        {

            // this division haven't able to derive decimal result
            List<int> list_a = new List<int>();
            List<int> list_b = new List<int>();
            List<int> list_temp_2 = new List<int>();
            List<int> list_result_division = new List<int>();
            List<int> list_result_division_residue = new List<int>();
            List<int> list_division_multiplication = new List<int>();    // need modification

            int temp_index_list_a_start = 0;

            int count_a_Decimal = 0;
            int count_b_Decimal = 0;
            int count_Result_DecimalPosition = 0;

            bool isDecimal = false;

            try
            {
                a = a.Trim();
                b = b.Trim();

                int temp_int;
                isDecimal = false;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a.Substring(i, 1) == ".")
                        isDecimal = true;
                    else
                    {
                        if (!int.TryParse(a.Substring(i, 1), out temp_int))
                            throw new FormatException();

                        if (isDecimal)
                            count_a_Decimal++;

                        list_a.Insert(0, temp_int);
                    }
                }

                while (list_a.Last() == 0)
                    list_a.RemoveAt(list_a.Count() - 1);

                // remove 0 on right of a_decimal
                if (isDecimal)
                {
                    while (list_a[0] == 0)
                    {
                        list_a.RemoveAt(0);
                        count_a_Decimal--;
                    }
                }

                isDecimal = false;
                for (int i = 0; i < b.Length; i++)
                {
                    if (b.Substring(i, 1) == ".")
                        isDecimal = true;
                    else
                    {
                        if (!int.TryParse(b.Substring(i, 1), out temp_int))
                            throw new FormatException();

                        if (isDecimal)
                            count_b_Decimal++;

                        list_b.Insert(0, temp_int);
                    }
                }

                while (list_b.Last() == 0)
                    list_b.RemoveAt(list_b.Count() - 1);

                // remove 0 on right of b_decimal
                if (isDecimal)
                {
                    while (list_b[0] == 0)
                    {
                        list_b.RemoveAt(0);
                        count_b_Decimal--;
                    }

                }

                if (count_a_Decimal < count_b_Decimal)
                {
                    for (int i = 0; i < (count_b_Decimal - count_a_Decimal); i++)
                        list_a.Insert(0, 0);

                    count_Result_DecimalPosition = count_b_Decimal;
                    count_a_Decimal = 0;
                    count_b_Decimal = 0;
                }
                else if (count_a_Decimal > count_b_Decimal)
                {
                    for (int i = 0; i < (count_a_Decimal - count_b_Decimal); i++)
                        list_b.Insert(0, 0);

                    count_Result_DecimalPosition = count_a_Decimal;
                    count_a_Decimal = 0;
                    count_b_Decimal = 0;
                }
                else
                    ;
            }
            catch (FormatException)
            {
                Console.WriteLine("String a or String b are not integer");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception");
            }

            if (CompareTo_UnlimitedDataSize(list_a, list_b) > 0)
            {
                temp_index_list_a_start = list_a.Count() - list_b.Count();
                List<int> list_temp_1 = list_a.GetRange(temp_index_list_a_start, list_b.Count());

                while (temp_index_list_a_start > 0)
                {
                    if (CompareTo_UnlimitedDataSize(list_temp_1, list_b) > 0)
                    {
                        list_temp_2 = list_b.ToList();

                        list_division_multiplication.Clear();
                        list_division_multiplication.Add(1);
                        while (CompareTo_UnlimitedDataSize(list_temp_1, list_temp_2) > 0)
                        {
                            list_temp_2 = Addition_UnlimitedDataSize(list_temp_2, list_b);
                            list_division_multiplication = Addition_UnlimitedDataSize(list_division_multiplication, new List<int>() { 1 }).ToList();
                        }

                        if (CompareTo_UnlimitedDataSize(list_temp_1, list_temp_2) < 0)
                        {
                            //when list_temp_1 divided by list_b has residue
                            list_division_multiplication = Minus_UnlimitedDataSize(list_division_multiplication, new List<int>() { 1 }).ToList();
                            list_temp_2 = Minus_UnlimitedDataSize(list_temp_2, list_b).ToList();
                            list_temp_2 = Minus_UnlimitedDataSize(list_temp_1, list_temp_2).ToList();
                        }
                        else
                            list_temp_2.Clear();

                        for (int i = list_division_multiplication.Count() - 1; i >= 0; i--)
                            list_result_division.Insert(0, list_division_multiplication[i]);
                        list_division_multiplication.Clear();

                        // shift index list_b.Length to the right
                        int prev_temp_index_list_a_start = temp_index_list_a_start;
                        if (list_temp_2.Count() == 0)
                        {
                            temp_index_list_a_start -= list_b.Count();

                            if (temp_index_list_a_start < 0)
                                temp_index_list_a_start = 0;

                            list_temp_1.Clear();
                            // Problem
                            if (temp_index_list_a_start + list_b.Count() - 1 >= prev_temp_index_list_a_start)
                                list_temp_1 = list_a.GetRange(temp_index_list_a_start, prev_temp_index_list_a_start - temp_index_list_a_start);
                            else
                                list_temp_1 = list_a.GetRange(temp_index_list_a_start, list_b.Count());
                        }
                        else
                        {
                            temp_index_list_a_start -= list_b.Count() - list_temp_2.Count();

                            if (temp_index_list_a_start < 0)
                                temp_index_list_a_start = 0;

                            list_temp_1.Clear();
                            // Problem
                            if (temp_index_list_a_start + list_b.Count() - list_temp_2.Count() - 1 >= prev_temp_index_list_a_start)
                                list_temp_1 = list_a.GetRange(temp_index_list_a_start, prev_temp_index_list_a_start - temp_index_list_a_start);
                            else
                                list_temp_1 = list_a.GetRange(temp_index_list_a_start, list_b.Count() - list_temp_2.Count());

                            //if (list_temp_2.Count() > 1 || (list_temp_2.Count() == 1 && list_temp_2.Last() != 0))

                            for (int i = 0; i < list_temp_2.Count(); i++)
                                list_temp_1.Add(list_temp_2[i]);

                        }
                    }
                    else if (CompareTo_UnlimitedDataSize(list_temp_1, list_b) == 0)
                    {
                        if (list_result_division.Count() != 0)
                        {
                            for (int i = 0; i < list_b.Count() - 1; i++)
                                list_result_division.Insert(0, 0);
                        }
                        list_result_division.Insert(0, 1);

                        // shift index list_b.Length to the right
                        temp_index_list_a_start -= b.Length;

                        if (temp_index_list_a_start < 0)
                            temp_index_list_a_start = 0;

                        list_temp_1.Clear();
                        list_temp_1 = list_a.GetRange(temp_index_list_a_start, list_b.Count());
                    }
                    else
                    {
                        //when list_temp_1 smaller than list_b

                        // list_temp_1 == 0
                        if (list_temp_1.Count() == 1 && list_temp_1.Last() == 0)
                        {
                            list_result_division.Insert(0, 0);
                            list_temp_1.Clear();
                        }

                        if (temp_index_list_a_start - 1 > -1)
                        {
                            temp_index_list_a_start -= 1;
                            list_temp_1.Insert(0, list_a[temp_index_list_a_start]);
                        }
                    }
                }

                // when temp_index_list_a_start at index '0'
                if (CompareTo_UnlimitedDataSize(list_temp_1, list_b) >= 0)
                {
                    list_division_multiplication.Clear();
                    list_division_multiplication.Add(1);
                    list_temp_2 = list_b.ToList();
                    while (CompareTo_UnlimitedDataSize(list_temp_1, list_temp_2) > 0)
                    {
                        list_temp_2 = Addition_UnlimitedDataSize(list_temp_2, list_b).ToList();
                        list_division_multiplication = Addition_UnlimitedDataSize(list_division_multiplication, new List<int>() { 1 }).ToList();
                    }

                    if (CompareTo_UnlimitedDataSize(list_temp_1, list_temp_2) < 0)
                    {
                        //when list_temp_1 divided by list_b has residue
                        list_division_multiplication = Minus_UnlimitedDataSize(list_division_multiplication, new List<int>() { 1 }).ToList();
                        list_temp_2 = Minus_UnlimitedDataSize(list_temp_2, list_b).ToList();
                        list_result_division_residue = Minus_UnlimitedDataSize(list_temp_1, list_temp_2).ToList();    
                    }
                    // if no residue, do nothing

                    for (int i = list_division_multiplication.Count() - 1; i >= 0; i--)
                        list_result_division.Insert(0, list_division_multiplication[i]);
                    list_division_multiplication.Clear();
                }
                else
                    list_result_division.Insert(0, 0);
            }
            else if (CompareTo_UnlimitedDataSize(list_a, list_b) == 0)
            {
                return "0";
            }
            else
                return a;



            string string_result = "";

            if(count_Result_DecimalPosition > 0)
            {
                if(count_Result_DecimalPosition >= list_result_division_residue.Count())
                {
                    string_result = "0.";
                    for (int i = 0; i < count_Result_DecimalPosition - list_result_division_residue.Count(); i++)
                        string_result += "0";
                }
            }

            if (list_result_division_residue.Count() > 0)
            {
                for (int i = list_result_division_residue.Count() - 1; i >= 0; i--)
                    string_result = string_result + list_result_division_residue[i].ToString();
            }
            else
                return "0";

            return string_result;
        }

        public static string Exponent_UnlimitedDataSize(string a, string b)         // a^b
        {
            // a and b only integer allowed
            List<int> list_a = new List<int>();
            List<int> list_b = new List<int>();
            List<int> list_result = new List<int>() { 1 };
            int _2ToPowerOf = 1073741824;
            List<int> list_2ToPowerOf = new List<int> { 1, 0, 7, 3, 7, 4, 1, 8, 2, 4 };
            List<int> list_Exponent_PowerOf2 = new List<int>();

            for (int i = 0; i < a.Length; i++)
                list_a.Insert(0, Int32.Parse(a.Substring(i, 1)));

            for (int i = 0; i < b.Length; i++)
                list_b.Insert(0, Int32.Parse(b.Substring(i, 1)));

            List<int> list_intermittent_result_mutiplication = new List<int>(list_a);

            List<int> list_duplicate_b = new List<int>(list_b);
            while (list_duplicate_b.Count() > 0 && list_duplicate_b.Last() != 0)
            {
                while (CompareTo_UnlimitedDataSize(list_duplicate_b, list_2ToPowerOf) == -1 && _2ToPowerOf >= 0)
                {
                    _2ToPowerOf /= 2;
                    string str_2ToPowerOf = _2ToPowerOf.ToString();
                    list_2ToPowerOf.Clear();
                    foreach (char char_2ToPowerOf in str_2ToPowerOf)
                        list_2ToPowerOf.Insert(0, Int32.Parse(char_2ToPowerOf.ToString()));
                }
                list_Exponent_PowerOf2.Insert(0, _2ToPowerOf);
                list_duplicate_b = Minus_UnlimitedDataSize(list_duplicate_b, list_2ToPowerOf);
            }

            if (list_Exponent_PowerOf2.Count > 0 && list_Exponent_PowerOf2.FirstOrDefault() == 1)
            {
                list_Exponent_PowerOf2.RemoveAt(0);
                list_result.Clear();
                list_result = new List<int>(list_a);
            }

            _2ToPowerOf = 1;
            while (list_Exponent_PowerOf2.Count > 0)
            {
                //list_intermittent_result_mutiplication = Multiplication_UnlimitedDataSize(list_a, list_a);
                List<int> list_temp1 = new List<int>();
                while (list_Exponent_PowerOf2.FirstOrDefault() > _2ToPowerOf)
                {
                    list_temp1.Clear();
                    list_temp1 = new List<int>(list_intermittent_result_mutiplication);
                    list_intermittent_result_mutiplication.Clear();
                    list_intermittent_result_mutiplication = new List<int>(Multiplication_UnlimitedDataSize(list_temp1, list_temp1));
                    _2ToPowerOf *= 2;
                }
                list_Exponent_PowerOf2.RemoveAt(0);

                List<int> list_temp = new List<int>(list_result);
                list_result.Clear();
                list_result = new List<int>(Multiplication_UnlimitedDataSize(list_temp, list_intermittent_result_mutiplication));
            }

            string string_result = "";

            for (int i = list_result.Count() - 1; i >= 0; i--)
                string_result += list_result[i].ToString();

            return string_result;
        }

    }
}
