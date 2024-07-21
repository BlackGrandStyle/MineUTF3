using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace MineUTF3_0
{
    public partial class FormMain : Form
    {
        // Отображение формы
        public FormMain()
        {
            InitializeComponent();
        }


        // Зов коробки с холдерами
        Holders holders = new Holders();


        // Действия при запуске
        public void FormMain_Load(object sender, EventArgs e)
        {
            // Установка английской раскладки по-умлч.
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-US"));

            // Подсказки при наведении
            var tips = new ToolTip();

            tips.SetToolTip(pictureBoxRestart, "Перезапустить");
            tips.SetToolTip(pictureBoxAbout, "О программе...");
            tips.SetToolTip(pictureBoxOther, "Другие символы...");

            tips.SetToolTip(pictureBoxClear, "Очистить всё");
            tips.SetToolTip(pictureBoxCopy, "Скопировать в буфер");
            tips.SetToolTip(pictureBoxSave, "Сохранить на рабочий стол");

            tips.SetToolTip(labelSelect, "Ниже...");
            tips.SetToolTip(comboBoxMode, "Есть идеи для новых режимов?\nСообщите автору! ->");

            tips.SetToolTip(pictureBoxConvert, "Конвертировать!");
        }




        // Установка определенных настроек при выборе нужного режима
        private void comboBoxMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            holders.CurrentIndexMode = comboBoxMode.SelectedIndex;
            switch (holders.CurrentIndexMode)
            {
                case 0:
                    textBoxConvert.CharacterCasing = CharacterCasing.Normal;
                    InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-US"));
                    textBoxConvert.Enabled = true;
                    textBoxResult.Enabled = true;
                    labelWarn.Visible = false;
                    //labelWarn.Text = "";
                    break;
                case 1:
                    textBoxConvert.CharacterCasing = CharacterCasing.Upper;
                    InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-US"));
                    textBoxConvert.Enabled = true;
                    textBoxResult.Enabled = true;
                    labelWarn.Visible = false;
                    //labelWarn.Text = "";
                    break;
                case 2:
                    textBoxConvert.CharacterCasing = CharacterCasing.Upper;
                    InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ru-RU"));
                    textBoxConvert.Enabled = true;
                    textBoxResult.Enabled = true;
                    labelWarn.Visible = true;
                    labelWarn.Text = "В этом пресете нет следующих символов:\nл п р ш э\nЭто не вина автора, это вина Майнкрафта.";
                    break;
                case 3:
                    textBoxConvert.Enabled = true;
                    textBoxResult.Enabled = true;
                    labelWarn.Visible = false;
                    //labelWarn.Text = "";
                    break;
            }
        }




        // (раз)Блокировка

        // Проверка ввода на текст для разблокировки/блокировки кнопки конвертации
        private void textBoxConvert_TextChanged(object sender, EventArgs e)
        {
            pictureBoxConvert.Visible = !string.IsNullOrEmpty(textBoxConvert.Text) ? true : false;
            pictureBoxClear.Visible = !string.IsNullOrEmpty(textBoxConvert.Text) ? true : false;
        }


        // Проверка результата на текст для разблокировки/блокировки кнопки копирования и сохранения
        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {
            pictureBoxCopy.Visible = !string.IsNullOrEmpty(textBoxResult.Text) ? true : false;
            pictureBoxSave.Visible = !string.IsNullOrEmpty(textBoxResult.Text) ? true : false;
        }




        // Сама конвертация
        private void pictureBoxConvert_Click(object sender, EventArgs e)
        {
            // Занос введенного текста в переменную
            string NeedConvert = textBoxConvert.Text;


            holders.CurrentIndexMode = comboBoxMode.SelectedIndex;
            switch (holders.CurrentIndexMode)
            {
                case 0:
                    if (!Regex.IsMatch(textBoxConvert.Text, @"^[A-Za-z0-9 _,.?!-]+$"))
                    {
                        MessageBox.Show($"{holders.Error}A-Za-z , . ? ! _ - 0-9", $"{holders.Version}");
                    }
                    else
                    {
                        for (int i = 0; i < NeedConvert.Length; i++)
                        {
                            int index = Array.IndexOf(holders.OriginalCharacters_BigLat, NeedConvert[i]);
                            if (index != -1)
                            {
                                NeedConvert = NeedConvert.Remove(i, 1).Insert(i, new string(holders.ReplaceCharacters_BigLat[index], 1));
                            }
                        }
                        textBoxResult.Text = NeedConvert;
                    }
                    break;

                case 1:
                    if (!Regex.IsMatch(textBoxConvert.Text, @"^[A-Z0-9 _,.?!-]+$"))
                    {
                        MessageBox.Show($"{holders.Error}A-Z , . ? ! _ - 0-9", $"{holders.Version}");
                    }
                    else
                    {
                        for (int i = 0; i < NeedConvert.Length; i++)
                        {
                            int index = Array.IndexOf(holders.OriginalCharacters_BetterLat, NeedConvert[i]);
                            if (index != -1)
                            {
                                NeedConvert = NeedConvert.Remove(i, 1).Insert(i, new string(holders.ReplaceCharacters_BetterLat[index], 1));
                            }
                        }
                        textBoxResult.Text = NeedConvert;
                    }
                    break;

                case 2:
                    {
                        if (!Regex.IsMatch(textBoxConvert.Text, @"^[А-Я0-9 _,.?!-]+$"))
                        {
                            MessageBox.Show($"{holders.Error}А-Я , . ? ! _ - 0-9", $"{holders.Version}");
                        }
                        else
                        {
                            for (int i = 0; i < NeedConvert.Length; i++)
                            {
                                int index = Array.IndexOf(holders.OriginalCharacters_Cyrillic, NeedConvert[i]);
                                if (index != -1)
                                {
                                    NeedConvert = NeedConvert.Remove(i, 1).Insert(i, new string(holders.ReplaceCharacters_Cyrillic[index], 1));
                                }
                            }
                            textBoxResult.Text = NeedConvert;
                        }
                        break;
                    }

                case 3:
                    {
                        if (!Regex.IsMatch(textBoxConvert.Text, @"^[0-9 _,.?!-]+$"))
                        {
                            MessageBox.Show($"{holders.Error}0-9 , . ? ! _ -", $"{holders.Version}");
                        }
                        else
                        {
                            for (int i = 0; i < NeedConvert.Length; i++)
                            {
                                int index = Array.IndexOf(holders.OriginalNum_RNum, NeedConvert[i]);
                                if (index != -1)
                                {
                                    NeedConvert = NeedConvert.Remove(i, 1).Insert(i, new string(holders.ReplaceNum_RNum[index], 1));
                                }
                            }
                            textBoxResult.Text = NeedConvert;
                        }
                        break;
                    }
            }
        }




        // Кнопка сохранения
        private void pictureBoxSave_Click(object sender, EventArgs e)
        {
            // Получение пути рабочего стола и запись его в переменную
            string Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\MineUTF";
            string FilePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\MineUTF\Конвертации.txt";

            // Проверка на директорию, нет - создаём
            if (!Directory.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }

            // Создание файла сохранения
            using (FileStream FS = new FileStream(FilePath, FileMode.Append))
            {
                StreamWriter SW = new StreamWriter(FS);
                string SaveConvert = textBoxResult.Text;

                SW.WriteLine(SaveConvert);
                SW.Close();
                MessageBox.Show("Сохранено!\nПроверьте рабочий стол", $"{holders.Version}");
            }
        }




        // Кнопка копирования
        private void pictureBoxCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxResult.Text);
            pictureBoxCopy.BackColor = Color.Lime;
            labelCopied.Visible = true;

            timerCopy.Start();
        }


        // Таймер для кнопки копирования
        private void timerCopy_Tick(object sender, EventArgs e)
        {
            pictureBoxCopy.BackColor = Color.Transparent;
            labelCopied.Visible = false;

            timerCopy.Stop();
        }


        // Кнопка перезапуска
        private void pictureBoxRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }


        // Кнопка очистки
        private void pictureBoxClear_Click(object sender, EventArgs e)
        {
            textBoxConvert.Text = "";
            textBoxResult.Text = "";
        }




        // Открытие других форм
        private void pictureBoxAbout_Click(object sender, EventArgs e)
        {
            FormCredits formCredits = new FormCredits();
            formCredits.Show();
        }

        private void pictureBoxOther_Click(object sender, EventArgs e)
        {
            FormOtherSymbols formOtherSymbols = new FormOtherSymbols();
            formOtherSymbols.Show();
        }
    }
}
