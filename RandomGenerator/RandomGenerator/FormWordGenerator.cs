using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RandomGenerator
{
    public partial class FormWordGenerator : Form
    {
        private List<string> wordsList;
        private List<string> randomWords;
        private int currentWordIndex = 0;
        private int generationAttempts = 0;

        public FormWordGenerator()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            generationAttempts += 1;
            // Получение списка слов из текстового поля
            string wordsInput = WordTextBox.Text;
            List<string> wordsList = wordsInput.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();

            // Получение количества слов для генерации
            int numberOfWords;
            if (!int.TryParse(NumberOfWordsTextBox.Text, out numberOfWords))
            {
                MessageBox.Show("Некорректное количество слов.");
                return;
            }

            // Проверка наличия слов в списке
            if (wordsList.Count == 0)
            {
                MessageBox.Show("Введите слова в текстовое поле.");
                return;
            }

            // Генерация случайных слов
            Random random = new Random();
            List<string> randomWords = new List<string>();
            for (int i = 0; i < numberOfWords; i++)
            {
                int randomIndex = random.Next(wordsList.Count);
                randomWords.Add(wordsList[randomIndex]);
            }

            // Вывод результатов
            ResultTextBox.Text = string.Join("\r\n", randomWords);
            generation_attempts.Text = "Попыток генерации: " + generationAttempts;
        }

        private void FormWordGenerator_Load(object sender, EventArgs e)
        {
            // Инициализация компонентов
            WordTextBox.Text = "Слово 1\r\nСлово 2\r\nСлово 3\r\nСлово 4\r\nСлово 5\r\nСлово 6\r\nСлово 7\r\nСлово 8\r\nСлово 9";
            NumberOfWordsTextBox.Text = "1";
            generation_attempts.Text = "Попыток генерации: " + generationAttempts;
        }

        private void reset_attempts_Click(object sender, EventArgs e)
        {
            generationAttempts = 0;
            ResultTextBox.Text = "";
            generation_attempts.Text = "Попыток генерации: " + generationAttempts;
        }

        private void reset_list_Click(object sender, EventArgs e)
        {
            WordTextBox.Text = "";
        }
    }
}