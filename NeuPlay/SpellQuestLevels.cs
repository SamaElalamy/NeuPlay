using System;

namespace NeuPlay
{
    internal class SpellQuestLevels
    {
        //AI is used in helping to link Word_Item and LevelManager
        private WordItem[] currentLevelWords;
        private int currentWordIndex = 0;

        //read only
        public int Score 
        { 
            get; 
            private set; 
        } = 0;
        public int CurrentIndex
        {
            get
            {
                return currentWordIndex;
            }
        }
        public int NumberOfWord
        {
            get
            {
                if (currentLevelWords != null)
                {
                    return currentLevelWords.Length;
                }
                else
                {
                    return 0;
                }
            }
        }

        public bool StartLevel(string textFilePath)
        {
            LevelManager manager = new LevelManager();
            currentLevelWords = manager.LoadLevel(textFilePath);

            
            if (currentLevelWords != null && currentLevelWords.Length > 0)
            {
                currentWordIndex = 0;
                return true;
            }
            return false;
        }

        
        public WordItem GetCurrentWord()
        {
            if (currentLevelWords != null && currentWordIndex < currentLevelWords.Length)
            {
                return currentLevelWords[currentWordIndex];
            }
            return null; 
        }

        public bool CheckAnswer(char selectedLetter)
        {
            WordItem current = GetCurrentWord();

            //handling upper and lower case letters
            if (current != null && Char.ToUpper(selectedLetter) == Char.ToUpper(current.MissingLetter))
            {
                Score += 10; 
                currentWordIndex++;
                return true;
            }
            return false; 
        }

        public bool IsLevelComplete()
        {
            return currentLevelWords == null || currentWordIndex >= currentLevelWords.Length;
        }
    }
}