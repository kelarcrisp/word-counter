using System;
using System.Collections.Generic;


namespace WordCounter
{
    public class Item
    
    {

        public string Sentence {get; set;}
        public string Word {get; set;}

        public Item (string word, string sentence)
        {
            Word = word;
            Sentence = sentence;
        }




        // public string[] SplitSentence(string sentence)
        // {
        //     string[] newWords = sentence.Split(' ');

        //     return newWords;
        // }
         
        public int WordFinder(string sentence, string word)
        {
            
          string[] newWords= sentence.Split(new char[] { ' ', ',', '.' });
            List<string> myList = new List<string>();

            int Count = 0;
            for(int i = 0; i<newWords.Length; i++)
            {
                
            if(newWords[i] == word)
            { 
              
             Count += 1;
            
            }
            else
            {
                Count +=0;
            }
            
            }
            // Console.WriteLine(Count);
            return Count;
           
        } 

       

      
    }
}