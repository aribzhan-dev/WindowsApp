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
// using Avalonia.Controls;
// using Avalonia.Interactivity;
// using Avalonia.Media;
// using System;

// namespace HelloAvalonia
// {
//     public partial class MainWindow : Window
//     {
//         public MainWindow()
//         {
//             InitializeComponent();
//             InitializeContextMenu();
//         }

//         private void InitializeContextMenu()
//         {
//             var ctx = new ContextMenu();

//             var copyItem = new MenuItem { Header = "Копировать", Tag="Copy" };
//             copyItem.Click += EditAction;

//             var pasteItem = new MenuItem { Header = "Вставить", Tag="Paste" };
//             pasteItem.Click += EditAction;

//             var clearItem = new MenuItem { Header = "Очистить", Tag="Clear" };
//             clearItem.Click += EditAction;

//             ctx.Items.Add(copyItem);
//             ctx.Items.Add(pasteItem);
//             ctx.Items.Add(clearItem);

//             MainTextBox.ContextMenu = ctx;
//         }

        
//         private void FileAction(object? sender, RoutedEventArgs e)
//         {
//             if (sender is Control ctl && ctl.Tag is string action)
//             {
//                 switch (action)
//                 {
//                     case "Open": ShowMessage("Открыть файл"); break;
//                     case "Save": ShowMessage("Сохранить файл"); break;
//                     case "Exit": this.Close(); break;
//                 }
//             }
//         }

       
//         private void EditAction(object? sender, RoutedEventArgs e)
//         {
//             if (sender is Control ctl && ctl.Tag is string action)
//             {
//                 switch (action)
//                 {
//                     case "Copy": MainTextBox.Copy(); break;
//                     case "Cut": MainTextBox.Cut(); break;
//                     case "Paste": MainTextBox.Paste(); break;
//                     case "Clear": MainTextBox.Text = ""; break;
//                 }
//             }
//         }

        
//         private void ViewAction(object? sender, RoutedEventArgs e)
//         {
//             if (sender is Control ctl && ctl.Tag is string action)
//             {
//                 switch (action)
//                 {
//                     case "Light":
//                         this.Background = Brushes.White;
//                         MainTextBox.Background = Brushes.White;
//                         MainTextBox.Foreground = Brushes.Black;
//                         break;
//                     case "Dark":
//                         this.Background = Brushes.Black;
//                         MainTextBox.Background = Brushes.Black;
//                         MainTextBox.Foreground = Brushes.White;
//                         break;
//                     case "Font":
//                         MainTextBox.FontSize = 16;
//                         break;
//                 }
//             }
//         }

        
//         private void HelpAction(object? sender, RoutedEventArgs e) => ShowMessage("Программа для демонстрации меню и инструментов");

        
//         private void LanguageAction(object? sender, RoutedEventArgs e)
//         {
//             if (sender is Control ctl && ctl.Tag is string lang)
//                 ShowMessage("Вы выбрали язык: " + lang);
//         }

//         private async void ShowMessage(string text)
//         {
//             var dlg = new Window
//             {
//                 Title = "Info",
//                 Width = 300,
//                 Height = 150,
//                 Content = new TextBlock { Text = text, Margin = new Avalonia.Thickness(10) }
//             };
//             await dlg.ShowDialog(this);
//         }
//     }
// }



// Practic task 9

// using Avalonia.Controls;
// using Avalonia.Interactivity;
// using System;

// namespace HelloAvalonia
// {
//     public partial class MainWindow : Window
//     {
//         private double _storedValue = 0;
//         private string? _currentOperator = "";
//         private bool _isNewEntry = true;

//         public MainWindow()
//         {
//             InitializeComponent();
//         }

//         private void NumberButton_Click(object? sender, RoutedEventArgs e)
//         {
//             if (sender is Button btn)
//             {
//                 var digit = btn.Content?.ToString() ?? "0";

//                 if (_isNewEntry || Display.Text == "0")
//                     Display.Text = digit;
//                 else
//                     Display.Text += digit;

//                 _isNewEntry = false;
//             }
//         }

//         private void DecimalButton_Click(object? sender, RoutedEventArgs e)
//         {
//             if (_isNewEntry)
//             {
//                 Display.Text = "0.";
//                 _isNewEntry = false;
//                 return;
//             }

//             if (!Display.Text.Contains("."))
//                 Display.Text += ".";
//         }

//         private void OperatorButton_Click(object? sender, RoutedEventArgs e)
//         {
//             if (sender is not Button btn) return;

//             if (double.TryParse(Display.Text, out var value))
//             {
//                 if (!_isNewEntry && !string.IsNullOrEmpty(_currentOperator))
//                 {
//                     try
//                     {
//                         _storedValue = Calculate(_storedValue, value, _currentOperator!);
//                         Display.Text = _storedValue.ToString();
//                     }
//                     catch (DivideByZeroException)
//                     {
//                         Display.Text = "Error";
//                     }
//                 }
//                 else
//                 {
//                     _storedValue = value;
//                 }
//             }

//             _currentOperator = btn.Content?.ToString();
//             _isNewEntry = true;
//         }

//         private void EqualsButton_Click(object? sender, RoutedEventArgs e)
//         {
//             if (string.IsNullOrEmpty(_currentOperator)) return;
//             if (!double.TryParse(Display.Text, out var value)) return;

//             try
//             {
//                 _storedValue = Calculate(_storedValue, value, _currentOperator!);
//                 Display.Text = _storedValue.ToString();
//             }
//             catch (DivideByZeroException)
//             {
//                 Display.Text = "Error";
//             }

//             _currentOperator = "";
//             _isNewEntry = true;
//         }

//         private void ClearButton_Click(object? sender, RoutedEventArgs e)
//         {
//             _storedValue = 0;
//             _currentOperator = "";
//             Display.Text = "0";
//             _isNewEntry = true;
//         }

//         private double Calculate(double left, double right, string op)
//         {
//             return op switch
//             {
//                 "+" => left + right,
//                 "-" => left - right,
//                 "*" => left * right,
//                 "/" => right == 0
//                         ? throw new DivideByZeroException()
//                         : left / right,
//                 "%" => right == 0
//                         ? throw new DivideByZeroException()
//                         : left % right,
//                 _ => right
//             };
//         }
//     }
// }




// Practic task 
// using Avalonia.Controls;
// using Avalonia.Interactivity;
// using Avalonia.Layout;

// namespace HelloAvalonia;

// public partial class MainWindow : Window
// {
//     public MainWindow()
//     {
//         InitializeComponent();
//     }

//     private void GotoSettings_Click(object? sender, RoutedEventArgs e)
//     {
//         MainTabs.SelectedIndex = 1;
//     }

//     private void EnableBox_Changed(object? sender, RoutedEventArgs e)
//     {
//         SettingsText.IsEnabled = EnableBox.IsChecked ?? false;
//     }

//     private void ToggleLabel_Click(object? sender, RoutedEventArgs e)
//     {
//         PanelLabel.IsVisible = !PanelLabel.IsVisible;
//     }
// }








using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Collections.ObjectModel;
using System.Linq;

namespace HelloAvalonia;

public partial class MainWindow : Window
{
    private readonly ObservableCollection<TodoItem> Tasks = new();
    private int nextId = 1;

    public MainWindow()
    {
        InitializeComponent();
        lstTasks.ItemsSource = Tasks;
    }

    private void btnAdd_Click(object? sender, RoutedEventArgs e)
    {
        var text = txtTaskInput.Text?.Trim();
        if (string.IsNullOrWhiteSpace(text)) return;

        Tasks.Add(new TodoItem
        {
            Id = nextId++,
            Text = text,
            Status = "Active",
            IsChecked = false
        });

        txtTaskInput.Text = string.Empty;
    }

    private void btnRemove_Click(object? sender, RoutedEventArgs e)
    {
        for (int i = Tasks.Count - 1; i >= 0; i--)
        {
            if (Tasks[i].IsChecked)
                Tasks.RemoveAt(i);
        }
    }
}