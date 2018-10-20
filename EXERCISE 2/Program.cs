/* Custom Project and Libraries Copyright, 2006,2010,2013.  Venkat, ISS */

using System;
using System.Collections.Generic;
using System.Text;
using ISS.RV.LIB;

namespace EXERCISE_2
{
    class ChooseExercise
    {
        static void Main()
        {
            Console.Write("Please choose an exercise 15-48: ");
            int choose = ISSConsole.ReadInt();
            switch (choose)
            {
                case 15:
                    Exercise.Ex15();
                    break;
                case 16:
                    Exercise.Ex16();
                    break;
                case 17:
                    Exercise.Ex17();
                    break;
                case 18:
                    Exercise.Ex18();
                    break;
                case 19:
                    Exercise.Ex19();
                    break;
                case 20:
                    Exercise.Ex20();
                    break;
                case 21:
                    Exercise.Ex21();
                    break;
                case 22:
                    Exercise.Ex22();
                    break;
                case 23:
                    Exercise.Ex23();
                    break;
                case 24:
                    Exercise.Ex24();
                    break;
                case 25:
                    Exercise.Ex25();
                    break;
                case 26:
                    Exercise.Ex26();
                    break;
                case 27:
                    Exercise.Ex27();
                    break;
                case 28:
                    Exercise.Ex28();
                    break;
                case 29:
                    Exercise.Ex29();
                    break;
                case 30:
                    Exercise.Ex30();
                    break;
                case 31:
                    Exercise.Ex31();
                    break;
                case 32:
                    Exercise.Ex32();
                    break;
                case 33:
                    Exercise.Ex33();
                    break;
                case 34:
                    Exercise.Ex34();
                    break;
                case 35:
                    Exercise.Ex35();
                    break;
                case 36:
                    Exercise.Ex36();
                    break;
                case 37:
                    Exercise.Ex37();
                    break;
                case 38:
                    Exercise.Ex38();
                    break;
                case 40:
                    Exercise.Ex40();
                    break;
                case 41:
                    Exercise.Ex41();
                    break;
                case 42:
                    Exercise.Ex42();
                    break;
                case 43:
                    Exercise.Ex43();
                    break;
                case 44:
                    Exercise.Ex44();
                    break;


                    #region /* Do not remove this or write codes after this  */
                    ISSConsole.Pause();
                #endregion
            }
        }
    }
    class Exercise
    {
        public static void Ex15()
        {
            Console.Write("Please insert a number to check if it is Armstrong number: ");
            string a = ISSConsole.ReadString();
            int num = Convert.ToInt32(a);
            double sum = 0;
            /*for (int i = 0; i < 3; i++)
            {
                char b = a[i];
                int c = Convert.ToInt32(new string(b, 1));
                sum += c * c * c;
            }*/
            int digits = a.Length;
            for (int i = num; i > 0; i /= 10)
            {
                int rem = i % 10;
                sum += Math.Pow(rem, digits);
            }
            if (sum == num)
            {
                Console.WriteLine($"{a} is an Armstrong number.");
            }
            else
            {
                Console.WriteLine($"{a} is not an Armstrong number.");
            }
        }
        public static void Ex16()
        {
            Console.Write("Your name: ");
            string name = Console.ReadLine();
            Console.Write("Gentle (F/M): ");
            char gentle = ISSConsole.ReadChar();
            if (gentle == 'F' || gentle == 'f')
            {
                Console.WriteLine($"Good morning Ms. {name}");
            }
            else if (gentle == 'M' || gentle == 'm')
            {
                Console.WriteLine($"Good morning Mr. {name}");
            }
            else
            {
                Console.WriteLine("What is your gentle??????????????");
            }
        }
        public static void Ex17()
        {
            Console.Write("Your name: ");
            string name = Console.ReadLine();
            int age = ISSConsole.ReadInt("Age: ");
            Console.Write("Gentle (F/M): ");
            char gender = ISSConsole.ReadChar();

            if (gender == 'F' || gender == 'f')
            {
                if (age < 40)
                {
                    Console.WriteLine($"Good morning Ms. {name}");
                }
                else
                {
                    Console.WriteLine($"Good morning Aunty {name}");
                }
            }
            else if (gender == 'M' || gender == 'm')
            {
                if (age < 40)
                {
                    Console.WriteLine($"Good morning Mr. {name}");
                }
                else
                {
                    Console.WriteLine($"Good morning Uncle {name}");
                }
            }
            else
            {
                Console.WriteLine("Please insert your Gender pls");
            }
        }
        public static void Ex18()
        {
            int marks = ISSConsole.ReadInt("Please input your Marks: ");
            if (marks>0 && marks<100)
            {
                char grade; //Declaring
                if (marks >= 80)
                {
                    grade='A';
                }
                else if (marks >= 60)
                {
                    grade = 'B';
                }
                else if (marks >= 40)
                {
                    grade = 'C';
                }
                else
                {
                    grade = 'F';
                }
                Console.WriteLine($"You scored {marks} marks which is {grade} grade.");
            }
            else
            {
                Console.WriteLine("**Error**");
            }
        }
        public static void Ex19()
        {
            Console.Write("Please insert the distance travelled (by km): ");
            double input = ISSConsole.ReadDouble();
            double distance = (Math.Ceiling(input * 10)) / 10;
            double totalCost = 2.40;
            if (distance >= 0.5)
            {
                if (distance <= 9)
                {
                    totalCost += (distance-0.5)*0.04;
                }
                else
                {
                    totalCost += 8.5 * 0.04 + (distance - 9) * 0.05;
                }
            }
            Console.WriteLine($"Total cost is: {totalCost:c}");
        }
        public static void Ex20()
        {
            Console.WriteLine("Please place your order: ");
            int tv = ISSConsole.ReadInt("Quantity of TV: ");
            int dvd = ISSConsole.ReadInt("Quantity of DVD: ");
            int mp3 = ISSConsole.ReadInt("Quantity of MP3: ");
            double discount;
            int firstCost = tv * 900 + dvd * 500 + mp3 * 700;
            if (firstCost >= 10000)
            {
                discount = 0.15;
            }
            else if (firstCost >= 5000)
            {
                discount = 0.1;
            }
            else
            {
                discount = 0;
            }
            double totalCost = (tv * 900  + dvd * 500 ) * (discount + 1) + mp3 * 700;
            Console.WriteLine($"Total amount is: {totalCost}");
        }
        public static void Ex21()
        {
            int x;
            do
            {
                Console.Write("Please key a number: ");
                x = ISSConsole.ReadInt();
            }
            while (x != 88);
            Console.WriteLine("Lucky you...");
        }
        public static void Ex22()
        {
            int RandomInteger = ISSMath.RNDInt(10);
            Console.WriteLine("Welcome to the Guess the Number Game!!");
            Console.WriteLine("Please insert a number (0~9): ");
            int count = 0;
            int guess;
            do
            {
                guess = ISSConsole.ReadInt();
                if (guess != RandomInteger)
                {
                    Console.WriteLine("Please try again!");
                    count++;
                }
                else
                {
                    if (count <= 1)
                    {
                        Console.WriteLine("You are a Wizard!");
                    }
                    else if (count <= 4)
                    {
                        Console.WriteLine("You are a good guess!");
                    }
                    else if (count <= 9)
                    {
                        Console.WriteLine("You are lousy!");
                    }
                }
            }
            while (guess != RandomInteger);
        }
        public static void Ex23() //hcf & lcf
        {
            Console.WriteLine("Please input the 2 numbers to get its LCM and HCF:");
            int n1 = ISSConsole.ReadInt("Number 1 = ");
            int n2 = ISSConsole.ReadInt("Number 2 = ");
            int multiply = n1*n2;
            while (n1 != n2)
            {
                if (n1 > n2)
                {
                    n1 -= n2;
                }
                else
                {
                    n2 -= n1;
                }
            }
            int hcf = n1;
            int lcm = multiply / hcf;
            Console.WriteLine($"LCM = {lcm}");
            Console.WriteLine($"HCF = {hcf}");
        }
        public static void Ex24()
        {
            int n = ISSConsole.ReadInt("Please input number to find it's squart root: ");
            double g = ISSMath.RND();
            while (g * g != n)
            {
                g = (g + n / g) / 2;
            }
            Console.WriteLine($"Squart root of {n} is {g}");
        }
        public static void Ex25()
        {
            int n = ISSConsole.ReadInt("Please insert a number to find it's factorial:");
            int factorial = 1;
            if (n == 0)
            {
                factorial = 0;
            }
            else
            {
                for (int i = 1; i <= n; i++) //for (int i=n; i>0;i--)
                {
                    factorial *= i;
                }
            }
            Console.WriteLine($"Factorial of {n} is {factorial}");
        }
        public static void Ex26()
        {
            int n = ISSConsole.ReadInt("Please key in a number to check if it is Prime: ");
            string result=" ";
            while (n < 0)
            {
                Console.WriteLine("Please insert a positive number...");
                n = ISSConsole.ReadInt();
            }
            if (n == 1 || n == 2)
            {
                result = "Prime.";
            }
            else
            {
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        result = "Not Prime.";
                    }
                    else
                    {
                        result = "Prime.";
                    }
                }
            }
            Console.WriteLine(result);
            
        }
        public static void Ex27()
        {
            int n = ISSConsole.ReadInt("Please key in a number to check if it is Perfect number: ");
            int sum = 0;
            for (int i=1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine($"{n} is a Perfect Number.");
            }
            else
            {
                Console.WriteLine($"{n} is not a Perfect Number.");
            }
        }
        public static void Ex28()
        {
            Console.WriteLine("NO\tINVERSE\t\tSQUARE ROOT\tSQUARE");
            Console.WriteLine("------------------------------------------------------");
            for (int i=1; i<=10; i++) 
            {
                double inverse = (double)1 / i; //casting it to a double
                double sqrt =  Math.Sqrt(i); 
                int square = i*i;
                Console.WriteLine($"{i:0.0}\t{inverse:0.0##}\t\t{sqrt:0.###}\t\t{square:0.0}"); //decimal places and tabs
            }
        }
        public static void Ex29() //?
        {
            int count ;
            int y = 0;
            bool check = false;
            for (count = 1; count <= 20; count++)
            {
                Console.Write($"{count}");
                for (int x = -9; x < 10; x++)
                {
                    y = 5 * x * x - 4 * x + 3;
                    if (y == count)
                    {
                        if (count < 10)
                        {
                            Console.Write(new String(' ', y));
                        }
                        else
                        {
                            Console.Write(new String(' ', y + 1));
                        }
                        Console.WriteLine("*");
                        check = true;
                    }
                }
                if (check == true)
                {
                    check = false;
                }
                else
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine("  " + new String('-',20) + "  <--x");
        }
        public static void Ex30()
        {
            for (int i=5; i <= 1000; i++) {
                bool prime = true;
                for (int j = 2; j <= i / 2; j++) {
                    if (i%j==0) 
                    {
                        prime = false;
                    }
                }
                if (prime == true) 
                {
                    Console.WriteLine("\t"+i);
                }
            }
        }
        public static void Ex31() //important for exam //Modify the Perfect Number C# program to print out all the perfect numbers from 1 to 1000.
        {
            int sum = 0;
            for (int j = 1; j <= 1000; j++) 
            {
                for (int i = 1; i < j; i++) 
                {
                    if (j % i == 0) 
                    {
                        sum += i;
                    }
                }
                if (sum == j) {
                    Console.WriteLine("\t" + j);
                }
                sum = 0;
            }
        }
        public static void Ex32()
        {
            int[] sales = new int[12];
            for (int i=0; i < 12; i++)
            {
                sales[i] = ISSConsole.ReadInt($"Please enter sales of month {i}: ");
            }
            int min=sales[0], max=sales[0];
            int monthMin = 0, monthMax = 0;
            int sum = sales[0];
            for (int i=1; i<12; i++)
            {
                sum += sales[i];
                if (sales[i] < min)
                {
                    min = sales[i];
                    monthMin = i;
                }
                if (sales[i] > max)
                {
                    max = sales[i];
                    monthMax = i;
                }
            }
            Console.WriteLine($"The month with Maximum sales is {monthMax}");
            Console.WriteLine($"The month with Minimum sales is {monthMin}");
            Console.WriteLine($"The average monthly sales is {(double)sum/12:c}");
        }
        public static void Ex33()
        {
            int temp;
            int n = ISSConsole.ReadInt("Please insert length of array: ");
            int[] array = new int[n];
            for (int i=0; i < n; i++) {
                array[i] = ISSMath.RNDInt(100);
                Console.Write($"\t{array[i]}");
            }
            Console.WriteLine();
            Console.WriteLine("Simplified seclection sort method progess:");
            for (int i=0; i < n-1; i++) {
                for (int j = i+1; j < n; j++) {
                    if (array[i] < array[j]) {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                        for (int l=0; l < n; l++) {
                            Console.Write($"\t{array[l]}");
                        }
                        Console.WriteLine();}
                    }
                }
            }
        public static void Ex34()
        {
            int maxIndex=0;
            int max;
            int n = ISSConsole.ReadInt("Please insert length of array: ");
            int[] array = new int[n];
            for (int i = 0; i < n; i++) {
                array[i] = ISSMath.RNDInt(100);
                Console.Write($"\t{array[i]}");
            }
            Console.WriteLine();
            max = array[0];
            Console.WriteLine("Refined selection sort method progess:");
            for (int i = 0; i < n-1; i++) {
                for (int j=i+1; j < n; j++) {
                    if (array[j] > max) {
                        max=array[j];
                        maxIndex = j;
                    }
                }
                //swap:
                array[maxIndex] = array[i];
                array[i] = max;
                for (int l = 0; l < n; l++) {
                Console.Write("\t"+ array[l]);
                }
                Console.WriteLine($"\tMax= {max}");
                max = array[i+1];
                maxIndex = i+1;
            }
        }
        public static void Ex35()
        {
            int sumClass;

            int[,] student = new int[12, 4];

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    student[i, j] = ISSMath.RNDInt(100);
                }
            }
            sumClass = 0;
            Console.WriteLine("\t\t\tSubject1\tSubject2\tSubject3\tSubject4\tTotal\tAverage");
            for (int i = 0; i < 12; i++)
            {
                Console.Write($"Student{i + 1}");
                int sum = 0;
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"\t\t{student[i, j]}");
                    sum += student[i, j]; //?
                }
                Console.Write($"\t\t{sum}\t{(double)sum / 4:0.##}");
                Console.WriteLine();
                sumClass += sum;
            }
            Console.WriteLine();
            Console.Write("Sub Average");
            double[] subAverage = new double[4];
            for (int j = 0; j < 4; j++)
            {
                int subSum = 0;
                for (int i = 0; i < 12; i++)
                {
                    subSum += student[i, j];
                }
                subAverage[j] = (double)subSum / 12;
                Console.Write($"\t\t{subAverage[j]:0.##}");
            }
            Console.WriteLine();

            //Find Deviation:
            Console.Write("Deviation");
            double[] deviation = new double[4];
            for (int j = 0; j < 4; j++)
            {
                double sumVariance = 0;
                for (int i = 0; i < 12; i++)
                {
                    sumVariance += Math.Pow((student[i, j] - subAverage[j]), 2);
                }
                deviation[j] = (double)Math.Sqrt(sumVariance / 12);
                Console.Write($"\t\t{deviation[j]:0.##}");
            }
            Console.WriteLine();
            Console.WriteLine($"Class average: {(double)sumClass / (12 * 4):0.##}");
        }

        // ------------------ STRING MANIPULATION TEEHEE --------------------------------//

        public static void Ex36() //PALINDROME
        {
            string s = ISSConsole.ReadString("Please insert a string to check if it is a Palindrome:");
            s = s.ToLower(); //Properties to convert all to lower
            int n = s.Length; //Assign to a length of the string to a variable
            bool check = true;
            string r = "";

            for (int i = 0; i < n; i++)
            {
                string letter = s.Substring(i, 1); //First parameter determines the starting index and strings starts with [0],
                                                   //the second parameter determines the amount of char to concatenate
                                                   //this step breaks it down into individual letters and assign it to letter

                if (letter.CompareTo("a") >= 0 && letter.CompareTo("z") <= 0) //method instance ** Clarify this part from StackOverflow
                    r += letter;
            }
            //Program
            for (int i = 0; i < r.Length; i++)
            {
                if (r[n - 1 - i] != r[i])
                { //if 
                    check = false;
                }
            }
            if (check != false)
            {
                Console.WriteLine($"{s} is a Palindrome.");
            }
            else
            {
                Console.WriteLine($"{s} is not a Palindrome.");
            }

            //more elegant code 

            //public static boolean Palindrom(char[] word) 
            //{
            //    int i1 = 0;
            //    int i2 = word.length - 1;
            //    while (i2 > i1)
            //    {
            //        if (word[i1] != word[i2])
            //        {
            //            return false;
            //        }
            //        ++i1;
            //        --i2;
            //    }
            //    return true;
            //}

        }
        public static void Ex37() //Title Cases
        {
            string temp;
            string result = "";
            string s = ISSConsole.ReadString("Please insert your sentence: ");
            string[] a = s.Split(' '); 
            for(int i = 0; i < a.Length; i++) {
                temp = a[i].Substring(0, 1).ToUpper();
                a[i] = temp + a[i].Substring(1, a[i].Length - 1);
                result += a[i] + " ";
            }
            Console.WriteLine(result);
        }
        public static void Ex38()
        {
            int numA = 0, numE = 0, numI = 0, numO = 0, numU = 0;
            string s = ISSConsole.ReadString("Please type a phrase to count it's vowels number: ");
            string x = s.ToLower();
            int n = s.Length;
            for (int i = 0; i < n; i++)
            {
                if (x[i] == 'a')
                    numA++;
                if (x[i] == 'e')
                    numE++;
                if (x[i] == 'i')
                    numI++;
                if (x[i] == 'o')
                    numO++;
                if (x[i] == 'u')
                    numU++;
            }
            Console.WriteLine($"Number of vowel A: {numA}");
            Console.WriteLine($"Number of vowel E: {numE}");
            Console.WriteLine($"Number of vowel I: {numI}");
            Console.WriteLine($"Number of vowel O: {numO}");
            Console.WriteLine($"Number of vowel U: {numU}");
        }

        //Strings and Array (Redo this for Exams) -------------
        public static void Ex40()
        {
            int tempMark;
            string tempName;
            string[] name = new string[5] { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] mark = new int[5] { 63, 29, 75, 82, 55 };
            string choose = ISSConsole.ReadString("Please choose report type a/b: ").ToLower();

            //SORTING ** IMPORTANT** 
            //First Report sorts the marks in descending order
            //Bubble Sort :D

            if (choose == "a")
            {
                for (int i = 0; i < 4; i++) //creating the first 4 to compare with 5 elements below
                {
                    for(int j=i+1;j<5;j++)
                    if (mark[i] < mark[j]) //if mark[i] is less than mark[j], //change sign for ascending
                    {
                        tempMark = mark[i]; //tempMark will be assigned the lower element
                        mark[i] = mark[j]; //Mark[j] which is the larger numer(descending, if ascending just change sign) will be assigned to the first position
                        mark[j] = tempMark; //mark[i]'s value whihc is stored in tempMark will be assigned to Mark[j];now in second position
                            tempName = name[i]; //likewise for the names of the students who have been assigned their respective marks
                            name[i] = name[j]; //can consider two dimensional arrays version later on during revision
                            name[j] = tempName;
                    }
                }
            }
            else if (choose=="b")
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = i + 1; j < 5; j++)
                    {
                        if (name[i].CompareTo(name[j]) == 1) //returns the value 0 if the argument string is equal to this string, 
                                                             //a value less than 0 if this string is lexicographically less than the 
                                                             //string argument and a value greater than 0 if this string is lexicographically greater than the string argument.
                                                             //To sort by Descending alphabetical order just use -1
                        {
                            tempMark = mark[i];
                            mark[i] = mark[j];
                            mark[j] = tempMark;
                            tempName = name[i];
                            name[i] = name[j];
                            name[j] = tempName;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Please choose a or b.");
                choose = ISSConsole.ReadString();
            }
            for(int i =0; i < 5; i++)
            {
                Console.WriteLine($"{name[i]}\t{mark[i]}");
            }
        }
        public static void Ex41()
        {
            Ex25(); //Repetition
        }
        public static void Ex42()
        {
            for (int i = 1; i <= 25; i++)
            {
                SQT(i);
            }
        }
        public static void SQT(int n)
        {
            double g = ISSMath.RND();
            while (g * g != n)
            {
                g = (g + n / g) / 2;
            }
            Console.WriteLine($"Squart root of {n} is {g}");
        }

        public static void Ex43() //... hexadecimal 
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(hex(i));
            }
        }
        public static string hex(int n) 
        {
            string result = "";
            const string dict = "0123456789ABCDEF";
            do
            {
                int remain = n % 16;
                string ins = dict[remain].ToString();
                result = result.Insert(0, ins);
                n /= 16;
            }
            while (n != 0);
            return result;
        }

        public static void Ex44() //Character replacement program
        {
            string s = ISSConsole.ReadString("Please insert string: ");
            char c1 = ISSConsole.ReadChar("Character to be replaced: ");
            char c2 = ISSConsole.ReadChar("Character chosen to replace: ");
            substitute(s, c1, c2);
        }
        public static void substitute(string s, char c1, char c2)
        {
            s = s.Replace(c1, c2); //just use this to replace
            Console.WriteLine(s);
        }
        public static void Ex45()
        {
            string s1 = ISSConsole.ReadString("Please insert firstWord: ");
            string s2 = ISSConsole.ReadString("Please insert word to find in firstWord: ");

        }
        public static int findWord(string s1, string s2)
        {
            bool check = s1.Contains(s2);
            if (check == false)
            {
                
                return -1;
            }
            else
            {
                return s1.IndexOf(s2);
            }
        }
    }
}