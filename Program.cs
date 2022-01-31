using System;
using System.Text;

namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Q1: Enter the string:");
                string s = Console.ReadLine();

                string RemoveVowels(string s)
                {
                    try
                    {
                        string[] vowels = new string[] { "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };

                        for (int i = 0; i < s.Length; i++) 
                        {
                            for (int j = 0; j < vowels.Length; j++)
                            {
                                s = s.Replace(vowels[j], String.Empty);
                            }

                        }

                        return new string(s.ToString());
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                string final_string = RemoveVowels(s);
                Console.WriteLine("Final string after removing the Vowels: {0}", final_string);
            }

            {
                string[] bulls_string1 = new string[] { "Marshall", "Student", "Center" };
                string[] bulls_string2 = new string[] { "MarshallStudent", "Center" };
                string s1 = string.Join("", bulls_string1); //Using the join method to join the strings in the array.
                string s2 = string.Join("", bulls_string2);
                Console.WriteLine("Q2");
                Console.WriteLine(s1);
                Console.WriteLine(s2);
                if (s1.Equals(s2)) // Equals method to compare the strings.
                {
                    Console.WriteLine("Yes, Both the array’s represent the same string");
                }
                else
                {
                    Console.WriteLine("No, Both the array’s don’t represent the same string ");
                }
            }
            {
                int[] bull_bucks = new int[] { 1, 8, 1 };

                int SumOfUnique(int[] bull_bucks)
                {
                    try
                    {
                        Array.Sort(bull_bucks);

                        int sum = bull_bucks[0]; // 1st element assigned to the varaible sum.
                        for (int i = 0; i < bull_bucks.Length - 1; i++) 
                        {
                            if (bull_bucks[i] != bull_bucks[i + 1]) // if the next element is not equals to the previous element.
                            {
                                sum = sum + bull_bucks[i + 1]; // the next element will be added to the sum.
                            }
                        }
                        return sum;
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                int unique_sum = SumOfUnique(bull_bucks);
                Console.WriteLine("Q3:");
                Console.WriteLine("Sum of Unique Elements in the array are :{0}", unique_sum);
                Console.WriteLine();
            }
            {
                int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
                Console.WriteLine("Q4:");
                int DiagonalSum(int[,] bulls_grid)
                {
                    double length = Math.Sqrt(bulls_grid.Length); //square rooting the total elements in the array to get the length of the matrix.Only works with square matrix.
                    int len = (int)length; 
                    int sum = 0; // assigning sum as 0 so to iterate and add elements to the variable.


                    for (int i = 0; i < len; i++)
                    {

                        sum += bulls_grid[i, i] + bulls_grid[i, len - 1 - i]; /*adds 1st element and 3rd element of first row in the first
                                                                                iteration, the 2nd element gets added twice in the second iteration
                                                                                 adds 1st and 3rd element of the last row in the third iteration. */
                    }
                    {
                        if (len % 2 == 1) /* this conditional statement if middle element gets added twice. */
                        {
                            sum = sum - bulls_grid[(len / 2), (len / 2)]; /*deducts the middle element from the sum.*/
                        }
                    }
                    return sum;

                }
                int diagsum = DiagonalSum(bulls_grid);
                Console.WriteLine("The sum of diagonal elements in the bulls grid is:{0}", diagsum);
                Console.WriteLine();
            }

            {
                string word = "aiohn";
                int[] indices = { 3, 1, 4, 2, 0 };
                Console.WriteLine("Q5:");

                string RestoreString(string word, int[] indices)
                {
                    var sb = new StringBuilder(); //Created a new string builder.
                    for (var i = 0; i < indices.Length; i++)
                    {
                        var CharPos = Array.IndexOf(indices, i); /* using Array.IndexOf method to know the index of the elements
                                                                        of the indices.in each iteration it finds the index */
                        sb.Append(word[CharPos]); //Appending the elements in sb according to the array of the indexes in CharPos//
                    }
                    return sb.ToString();
                }
                string final = RestoreString(word, indices);
                Console.WriteLine("Final string after strings are restored: {0}", final);
            }

            {
                Console.WriteLine("Q6:");
                string bulls_string = Console.ReadLine();
                char ch = Console.ReadLine()[0]; //reading a character. 
                int start = 0;
                string reverse = string.Empty;
                string word;
                string ReversePrefix(string bulls_string, char ch)
                {
                    if (bulls_string.Contains(ch)) //if the strings contains the character.
                    {
                        int posit = bulls_string.IndexOf(ch);//Getting the index of the first occurence of the character.
                        string indexed = bulls_string.Substring(start, posit+1); //extracting the characters from the index mentioned.
                        string left = bulls_string.Substring(posit, bulls_string.Length - posit); /*To get the characters that is remaining
                                                                              from the first occurence of the character specified. */
                        {
                            for (int i = indexed.Length - 1; i >= 0; i--)//reversin the loop till zero.
                            {
                                reverse += indexed[i]; //reverse the string
                            }
                            word = reverse + left; //added the word reversed and remaining/
                        }
                    }
                    else return bulls_string;
                    return word;
                }
                string prefixed = ReversePrefix(bulls_string, ch);
                Console.WriteLine("Final string: {0}", prefixed);

            }
        }

    }

}
