using System.ComponentModel;
using System.Diagnostics;

namespace Hangman
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        #region UI properties

        public string SpotLight
        {
            get => _spotLight;
            set
            {
                _spotLight = value;
                OnPropertyChanged(nameof(SpotLight));
            }
        }

        public List<char> Letters
        {
            get => _letters;
            set
            {
                _letters = value;
                OnPropertyChanged();
            }
        }

        public string Message
        {
            get => _message;
            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }

        public string GameStatus
        {
            get => _gameStatus;
            set
            {
                _gameStatus = value;
                OnPropertyChanged();
            }
        }

        public string CurrentImage
        {
            get => currentImage;
            set
            {
                currentImage = value;
                OnPropertyChanged();
            }
        }

        #endregion


        #region Fields

        List<string> words = new List<string>()
         {
            "python",
            "javascript",
            "maui",
            "csharp",
            "mongodb",
            "sql",
            "xaml",
            "word",
            "excel",
            "powerpoint",
            "code",
            "hotreload",
            "snippets"
         };
        string _answer = string.Empty;
        private string _spotLight;
        List<char> _guessed = new List<char>();
        private List<char> _letters = new List<char>();
        private string _message;
        private int _mistakes = 0;
        private string _gameStatus;
        private int _maxErrors = 6;
        private string currentImage;

        #endregion

        public MainPage()
        {
            InitializeComponent();
            Letters.AddRange(Enumerable.Range('a', 26).Select(x => (char)x));
            BindingContext = this;
            PickWord();
            CalculateWord(_answer, _guessed);
            UpdateStatus();
            CurrentImage = "img0.jpg";
        }

        #region Game Engine

        private void PickWord()
        {
            Random random = new Random();
            int index = random.Next(0, words.Count);
            _answer = words[index];
            Debug.WriteLine($"Answer: {_answer}");
        }

        private void CalculateWord(string answer, List<char> guessed)
        {
            var temp = answer.Select(x => guessed.Contains(x) ? x : '_').ToArray();
            SpotLight = string.Join(" ", temp);
        }

        private void HandleGuess(char letter)
        {
            if (!_guessed.Contains(letter))
            {
                _guessed.Add(letter);
            }
            if (_answer.Contains(letter))
            {
                CalculateWord(_answer, _guessed);
                CheckIfGameWon();
            }
            else if (!_answer.Contains(letter))
            {
                _mistakes++;
                UpdateStatus();
                CheckIfgameLost();
                CurrentImage = $"img{_mistakes}.jpg";
            }
        }

        private void CheckIfgameLost()
        {
            if (_mistakes >= _maxErrors)
            {
                Message = "You lost!";
                DisableLetters();
            }
        }

        private void CheckIfGameWon()
        {
            if (SpotLight.Replace(" ", "") == _answer)
            {
                Message = "You won!";
                DisableLetters();
            }
        }

        private void DisableLetters()
        {
            foreach (var item in LetterContainer.Children)
            {
                var btn = item as Button;
                if (btn != null)
                {
                    btn.IsEnabled = false;
                }
            }
        }

        private void EnableLetters()
        {
            foreach (var item in LetterContainer.Children)
            {
                var btn = item as Button;
                if (btn != null)
                {
                    btn.IsEnabled = true;
                }
            }
        }

        private void UpdateStatus()
        {
            GameStatus = $"Errors: {_mistakes} of {_maxErrors}";
        }

        #endregion

        private void Button_Clicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (btn.Text != null)
            {
                char letter = btn.Text[0];
                btn.IsEnabled = false;
                HandleGuess(letter);                
            }
        }

        private void Reset_Clicked(object sender, EventArgs e)
        {
            _mistakes = 0;
            _guessed.Clear();
            CurrentImage = "img0.jpg";
            PickWord();
            CalculateWord(_answer, _guessed);
            Message = string.Empty;
            UpdateStatus();
            EnableLetters();
        }
    }

}
