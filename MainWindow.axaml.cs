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




