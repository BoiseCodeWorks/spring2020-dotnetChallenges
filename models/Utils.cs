using System.Collections.Generic;

namespace challenges.Models
{
    static class Utils
    {
        public static int doubleInteger(int num)
        {
            return num * 2;
            // num will be an integer. Double it and return it. (ex 12 => 24)
        }

        public static bool isNumberEven(int num)
        {
            return num % 2 == 0;
            // if(num % 2 == 0){
            //     return true;
            // }else{
            //     return false;
            // }
            //num will be an integer. Return true if it’s even, and false if it isn’t.
        }

        public static string getFileExtension(string str)
        {
            // str will be a string, but it may not have a file extension.
            // return the file extension (with no period) if it has one, otherwise null
            string[] words = str.Split('.'); //  test.txt ["test", "txt"].... test ["test"]
            if (words.Length > 1)
            {
                return words[words.Length - 1];
            }
            return null;
        }

        public static string longestString(IEnumerable<string> arr)
        {
            //declare a variable to hold the longest string
            string longest = "";
            //itterate over the collection
            foreach (string word in arr)
            {
                //compare current word to the longest varialbe
                if (word.Length > longest.Length)
                {
                    //if greater set current as longest
                    longest = word;
                }
            }
            return longest;
        }

        public static int arraySum(IEnumerable<int> arr)
        {
            //given an array return the sum of all its values
            int sum = 0;
            // for (int i = 0; i< arr.Count; i++){
            //     // sum = sum + arr[i];
            //     sum += arr[i];
            // }
            foreach (int num in arr)
            {
                sum += num;
            }
            return sum;
        }
    }
}