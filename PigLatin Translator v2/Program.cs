namespace PigLatin_Translator_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = translateRun();
                Console.WriteLine(a);

        }

        static string translateRun()
        {
            Console.WriteLine("Welcome to the English-Pig Latin Translator. Please type any word.");
            string englishIn = Console.ReadLine().ToLower(); //converts user input to all lower-case
            if (englishIn.Length < 2)
            {
                Console.WriteLine("This word is not long enough, try again.");
                return translateRun();
            }
            else
            {
                string vowels = "aeiou";
                //a=0, e=1, i=2, o=3, u=4
                //-1= not in list

                string consonants = "bcdfghjklmnpqrstvwxyz";
                //b=0, c=1, d=2, f=3, g=4, h=5, j=6, k=7, l=8, m=9, n=10, p=11, q=12, r=13, s=14, t=15, v=16,w=17, x= 18y, =19, z=20
                // -1= not in list

                string pigLatinOut = ""; //output of translation

                foreach (string word in englishIn.Split()) //for each word in the now-split user entry
                {
                    string firstLetter = word.Substring(0, 1);      
                    var restOfWord = word.Substring(1, word.Length - 1);
                    //var currentletterv = vowels.IndexOf(firstLetter);
                    //var currentletterc = consonants.IndexOf(firstLetter);

                    for (int i = 0; i < restOfWord.Length; i++)
                    {
                        int z = currentletterv[i];
                        bool vowelCheck = VoCheck(z);
                        bool constCheck = CoCheck(z);

                        if (vowelCheck == true)
                        {
                            Console.WriteLine("there is a vowel");
                        }
                        else if (vowelCheck == false)
                        {
                            Console.WriteLine("there is no vowel");
                        }
                        else if (constCheck == true)
                        {
                            Console.WriteLine("there is a const");
                        }
                        else if (constCheck == false)
                        {
                            Console.WriteLine("there is no const");
                        }
                    }

                        Console.WriteLine(firstLetter); // write first letter of word
                    //Console.WriteLine(currentletterv); //is the first letter a vowel? 0-4 = yes, -1 = no
                    //Console.WriteLine(currentletterc); //is it a consonent? 0-20 = yes, -1 = no
                    
                    Console.WriteLine();
                }
            }
            return translateRun();
        }

        public static bool VoCheck(int vowel1) // true or false if selected letter is a vowel or not
        {
            if (vowel1 >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CoCheck(int const1) // true or false if selected letter is a constant or not
        {
            if (const1 >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}