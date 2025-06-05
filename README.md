<h1>Search Task</h1>
   internal class Program
   {
       public static bool IsDuplicate(List<int> nums)
       {

           if (nums != null || nums.Count != 0)
           {
               for (int i = 0; i < nums.Count; i++)
               {

                   for (int j = i + 1; j < nums.Count; j++)
                   {

                       if (nums[i] == nums[j])

                           throw new Exception("There is a Duplication");
                   }

               }

               return true;
           }
           throw new Exception("Null or Empty List");

       }

       public static bool HasVowels(string text)
       {


           if (text.Length != 0)
           {
               List<string> vowels = new List<string> { "a", "e", "i", "u", "o" };

               for (int i = 0; i < vowels.Count; i++)
               {
                   if (text.ToLower().Contains(vowels[i]))

                       throw new Exception("Its Contain a Vowel");

               }

               return true;
           }

           else
               throw new Exception("Empty String");
       }
       static void Main(string[] args)
       {
           try
           {
               List<int> nums = new List<int> { 1, 2, 3 };

               bool check = IsDuplicate(nums);

               if (check)
                   Console.WriteLine("No Duplication");

           }
           catch (Exception e)
           {

               Console.WriteLine(e.Message);
           }


           try
           {


               bool check = HasVowels("Syd");

               if (check)
                   Console.WriteLine("Not Contain Vowels ");

           }
           catch (Exception e)
           {

               Console.WriteLine(e.Message);
           }


       }
   }