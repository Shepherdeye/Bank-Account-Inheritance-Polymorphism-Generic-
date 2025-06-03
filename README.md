<h2> Search Task </h2>

<br>

// Duplication Method

 public static bool IsDuplicate(List<int> numbers)
 {

     bool noDuplication = true;
     if (numbers.Count != 0)
     {
         for (int i = 0; i < numbers.Count; i++)
         {
            for(int j = i+1; j < numbers.Count; j++)
             {
                 if(numbers[i] == numbers[j])
                 {
                     noDuplication = false;
                     break;
                 }
             }
         }

         return noDuplication;

     }
     else
         return false;
 }

// Check  if  have vowels

     public static bool HaveVowels(string text = "")
     {
         List<string> vowels = new List<string> { "a", "e", "i", "o", "u" };
         bool contain=false;
         for (int i = 0; i < vowels.Count; i++)
         {
             if (text.ToLower().Contains(vowels[i]))
             {
                 contain= true;
                 break;
             }
         }

         return contain;
     }
static void Main(){

    List<int> numbers = new List<int> { 1, 2, 2, 3, 4 };

    bool duplication = IsDuplicate(numbers);


    if (duplication)
    
        Console.WriteLine("No Duplication");
    
    else
    
        Console.WriteLine("there is Duplication");
    

    bool have = HaveVowels("RSD");

    if (have)

        Console.WriteLine("Contain Vowels ");
    else
        Console.WriteLine("Don't Contain ");
    
          }

}