// using Avalonia.Controls;
// using Avalonia.Interactivity;
// using MsBox.Avalonia;
// using MsBox.Avalonia.Enums;

// namespace HelloAvalonia;

// public partial class MainWindow : Window
// {
//     public MainWindow()
//     {
//         InitializeComponent();
//     }

//     private async void ButtonHello_Click(object? sender, RoutedEventArgs e)
//     {
//         var box = MessageBoxManager.GetMessageBoxStandard(
//             "Приветствие",
//             "Привет, меня зовут Aribzhan!",
//             ButtonEnum.Ok);
//         await box.ShowAsync();
//     }
// }


// using Avalonia.Controls;
// using Avalonia.Interactivity;

// namespace HelloAvalonia;

// public partial class MainWindow : Window
// {
//     public MainWindow()
//     {
//         InitializeComponent();
//     }

//     private void ButtonChangeText_Click(object? sender, RoutedEventArgs e)
//     {
//         label1.Text = "Текст изменён!";
//     }
// }



// using Avalonia.Controls;
// using Avalonia.Interactivity;
// using MsBox.Avalonia;
// using MsBox.Avalonia.Enums;

// namespace HelloAvalonia;

// public partial class MainWindow : Window
// {
//     public MainWindow()
//     {
//         InitializeComponent();
//     }

//     private async void ButtonShowResult_Click(object? sender, RoutedEventArgs e)
//     {
//         string input = ageInput.Text?.Trim() ?? "";

//         if (int.TryParse(input, out int age))
//         {
//             var box = MessageBoxManager.GetMessageBoxStandard(
//                 "Результат",
//                 $"Вам {age} лет!",
//                 ButtonEnum.Ok);
//             await box.ShowAsync();
//         }
//         else
//         {
//             var box = MessageBoxManager.GetMessageBoxStandard(
//                 "Ошибка",
//                 "Пожалуйста, введите корректный возраст.",
//                 ButtonEnum.Ok);
//             await box.ShowAsync();
//         }
//     }
// }






// using Avalonia.Controls;
// using Avalonia.Input;
// using Avalonia.Media;
// using System;

// namespace HelloAvalonia
// {
//     public partial class MainWindow : Window
//     {
//         private Random random = new Random();

//         public MainWindow()
//         {
//             InitializeComponent();
//         }

//         private void ColorButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
//         {
//             // Случайный цвет
//             var color = Color.FromRgb(
//                 (byte)random.Next(0, 256),
//                 (byte)random.Next(0, 256),
//                 (byte)random.Next(0, 256));

//             this.Background = new SolidColorBrush(color);
//         }

//         private void TitleTextBox_TextChanged(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
//         {
//             this.Title = TitleTextBox.Text;
//         }

//         private void Window_PointerMoved(object? sender, PointerEventArgs e)
//         {
//             var point = e.GetPosition(this);
//             CoordsText.Text = $"Координаты: X={point.X:F0}, Y={point.Y:F0}";
//         }
//     }
// }



// using Avalonia.Controls;
// using Avalonia.Media;

// namespace HelloAvalonia
// {
//     public partial class MainWindow : Window
//     {
//         public MainWindow()
//         {
//             InitializeComponent();
//         }

//         private void GreenButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
//         {
//             this.Background = new SolidColorBrush(Colors.Green);
//             this.Title = "Цвет изменён на зелёный";
//         }

//         private void BlueButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
//         {
//             this.Background = new SolidColorBrush(Colors.Blue);
//             this.Title = "Цвет изменён на синий";
//         }
//     }
// }



// Practic task 


// using Avalonia.Controls;
// using System;

// namespace HelloAvalonia
// {
//     public partial class MainWindow : Window
//     {
//         public MainWindow()
//         {
//             InitializeComponent();
//         }

//         private void Calc_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
//         {
//             if (int.TryParse(YearBox.Text, out int year))
//             {
//                 int age = DateTime.Now.Year - year;
//                 ResultText.Text = $"Ваш возраст: {age} лет";
//             }
//             else
//             {
//                 ResultText.Text = "Введите корректный год!";
//             }
//         }
//     }
// }






// using Avalonia.Controls;
// using Avalonia.Interactivity;

// namespace HelloAvalonia
// {
//     public partial class MainWindow : Window
//     {
//         public MainWindow()
//         {
//             InitializeComponent();
//         }

//         private void AnswerButton_Click(object? sender, RoutedEventArgs e)
//         {
//             if (RedRadio.IsChecked == true)
//                 ResultLabel.Text = "Твой любимый цвет — Красный!";
//             else if (BlueRadio.IsChecked == true)
//                 ResultLabel.Text = "Твой любимый цвет — Синий!";
//             else if (GreenRadio.IsChecked == true)
//                 ResultLabel.Text = "Твой любимый цвет — Зелёный!";
//             else
//                 ResultLabel.Text = "Выберите цвет!";
//         }
//     }
// }




// using Avalonia.Controls;
// using Avalonia.Interactivity;

// namespace HelloAvalonia
// {
//     public partial class MainWindow : Window
//     {
//         public MainWindow()
//         {
//             InitializeComponent();
//         }

//         private void GreetButton_Click(object? sender, RoutedEventArgs e)
//         {
//             string name = NameBox.Text.Trim();
//             if (string.IsNullOrEmpty(name))
//             {
//                 ResultLabel.Text = "Введите имя!";
//                 return;
//             }

//             if (LanguageBox.SelectedItem is ComboBoxItem selected)
//             {
//                 string lang = selected.Content.ToString();
//                 switch (lang)
//                 {
//                     case "Русский":
//                         ResultLabel.Text = $"Привет, {name}!";
//                         break;
//                     case "Английский":
//                         ResultLabel.Text = $"Hello, {name}!";
//                         break;
//                     case "Казахский":
//                         ResultLabel.Text = $"Сәлем, {name}!";
//                         break;
//                 }
//             }
//         }
//     }
// }




// using Avalonia.Controls;
// using Avalonia.Interactivity;
// using System;

// namespace HelloAvalonia
// {
//     public partial class MainWindow : Window
//     {
//         public MainWindow()
//         {
//             InitializeComponent();
//         }

//         private void CalculateButton_Click(object? sender, RoutedEventArgs e)
//         {
//             if (double.TryParse(Number1Box.Text, out double num1) &&
//                 double.TryParse(Number2Box.Text, out double num2))
//             {
//                 double sum = num1 + num2;

//                 if (DetailedCheck.IsChecked == true)
//                 {
//                     ResultLabel.Text = $"{num1} + {num2} = {sum}";
//                 }
//                 else
//                 {
//                     ResultLabel.Text = sum.ToString();
//                 }
//             }
//             else
//             {
//                 ResultLabel.Text = "Введите корректные числа!";
//             }
//         }
//     }
// }



// Practic task 17 chat bot

// using Avalonia.Controls;
// using Avalonia.Interactivity;
// using System;
// using System.Collections.Generic;
// using System.Threading.Tasks;

// namespace HelloAvalonia
// {
//     public partial class MainWindow : Window
//     {
        
//         private List<string> userHistory = new List<string>();

//         public MainWindow()
//         {
//             InitializeComponent();
//         }

//         private async void SendButton_Click(object? sender, RoutedEventArgs e)
//         {
//             string userMessage = UserInputBox.Text.Trim();
//             if (string.IsNullOrEmpty(userMessage))
//                 return;

            
//             AddMessage("Вы: " + userMessage);
//             userHistory.Add(userMessage);
//             UserInputBox.Text = "";

            
//             await Task.Delay(1000);

//             string botReply = GenerateBotReply(userMessage);
//             AddMessage("Бот: " + botReply);
//         }

//         private void ClearButton_Click(object? sender, RoutedEventArgs e)
//         {
//             ChatPanel.Children.Clear();
//             userHistory.Clear();
//         }

//         private void AddMessage(string text)
//         {
//             TextBlock message = new TextBlock
//             {
//                 Text = text,
//                 TextWrapping = Avalonia.Media.TextWrapping.Wrap
//             };
//             ChatPanel.Children.Add(message);
//         }

//         private string GenerateBotReply(string userMessage)
//         {
            
//             string lower = userMessage.ToLower();
//             if (lower.Contains("сколько тебе лет"))
//                 return "Мне 2 года.";
//             if (lower.Contains("что ты умеешь"))
//                 return "Я умею отвечать на простые вопросы!";
            
            
//             if (userHistory.Count > 1)
//                 return "Ранее вы сказали: " + userHistory[userHistory.Count - 2];

//             return "Извините, я не понимаю.";
//         }
//     }
// }


// Practic task 6

using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Media;
using System;

namespace HelloAvalonia
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeContextMenu();
            SetupHotkeys(); // Hotkeys qo'shish
        }

        // === CONTEXT MENU (o'ng tugma) ===
        private void InitializeContextMenu()
        {
            var ctx = new ContextMenu();

            var copyItem = new MenuItem { Header = "Копировать" };
            copyItem.Click += Copy_Click;

            var cutItem = new MenuItem { Header = "Вырезать" };
            cutItem.Click += Cut_Click;

            var pasteItem = new MenuItem { Header = "Вставить" };
            pasteItem.Click += Paste_Click;

            var clearItem = new MenuItem { Header = "Очистить" };
            clearItem.Click += Clear_Click;

            ctx.Items.Add(copyItem);
            ctx.Items.Add(cutItem);
            ctx.Items.Add(pasteItem);
            ctx.Items.Add(new Separator());
            ctx.Items.Add(clearItem);

            MainTextBox.ContextMenu = ctx;
        }

        // === HOTKEYS (Ctrl+O, Ctrl+S, Ctrl+Q) ===
        private void SetupHotkeys()
        {
            var openItem = this.FindControl<MenuItem>("OpenMenuItem");
            var saveItem = this.FindControl<MenuItem>("SaveMenuItem");
            var exitItem = this.FindControl<MenuItem>("ExitMenuItem");

            if (openItem != null)
                openItem.HotKey = new KeyGesture(Key.O, KeyModifiers.Control);

            if (saveItem != null)
                saveItem.HotKey = new KeyGesture(Key.S, KeyModifiers.Control);

            if (exitItem != null)
                exitItem.HotKey = new KeyGesture(Key.Q, KeyModifiers.Control);
        }

        // === FAYL MENU ===
        private void Open_Click(object? sender, RoutedEventArgs e) => ShowMessage("Открыть файл");
        private void Save_Click(object? sender, RoutedEventArgs e) => ShowMessage("Сохранить файл");
        private void Exit_Click(object? sender, RoutedEventArgs e) => this.Close();

        // === PRAVKA MENU ===
        private void Copy_Click(object? sender, RoutedEventArgs e) => MainTextBox.Copy();
        private void Cut_Click(object? sender, RoutedEventArgs e) => MainTextBox.Cut();
        private void Paste_Click(object? sender, RoutedEventArgs e) => MainTextBox.Paste();
        private void Clear_Click(object? sender, RoutedEventArgs e) => MainTextBox.Text = "";

        // === VID MENU ===
        private void LightBg_Click(object? sender, RoutedEventArgs e)
        {
            this.Background = Brushes.White;
            MainTextBox.Background = Brushes.White;
            MainTextBox.Foreground = Brushes.Black;
        }

        private void DarkBg_Click(object? sender, RoutedEventArgs e)
        {
            this.Background = Brushes.Black;
            MainTextBox.Background = Brushes.Black;
            MainTextBox.Foreground = Brushes.White;
        }

        private void Font_Click(object? sender, RoutedEventArgs e)
        {
            MainTextBox.FontSize = Math.Min(MainTextBox.FontSize + 2, 30); // maks 30
        }

        // === SPRAVKA ===
        private void About_Click(object? sender, RoutedEventArgs e)
        {
            ShowMessage("Программа для демонстрации меню и инструментов\n\nAvalonia UI + C#");
        }

        // === YAZIK ===
        private void Language_Click(object? sender, RoutedEventArgs e)
        {
            if (sender is MenuItem item && item.Tag is string lang)
            {
                ShowMessage($"Вы выбрали язык: {lang}");
            }
        }

        // === XABAR OYNASI ===
        private async void ShowMessage(string text)
        {
            var dialog = new Window
            {
                Title = "Информация",
                Width = 360,
                Height = 180,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                CanResize = false,
                Background = this.Background
            };

            var panel = new StackPanel { Margin = new Thickness(15), Spacing = 10 };
            panel.Children.Add(new TextBlock
            {
                Text = text,
                TextWrapping = Avalonia.Media.TextWrapping.Wrap,
                FontSize = 14
            });

            var okBtn = new Button
            {
                Content = "OK",
                HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center,
                MinWidth = 80
            };
            okBtn.Click += (_, __) => dialog.Close();

            panel.Children.Add(okBtn);
            dialog.Content = panel;

            await dialog.ShowDialog(this);
        }
    }
}