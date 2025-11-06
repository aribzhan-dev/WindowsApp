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



using Avalonia.Controls;
using Avalonia.Media;

namespace HelloAvalonia
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GreenButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Green);
            this.Title = "Цвет изменён на зелёный";
        }

        private void BlueButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Blue);
            this.Title = "Цвет изменён на синий";
        }
    }
}