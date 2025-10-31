using Avalonia.Controls;
using Avalonia.Interactivity;
using MsBox.Avalonia;
using MsBox.Avalonia.Enums;

namespace HelloAvalonia;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private async void ButtonHello_Click(object? sender, RoutedEventArgs e)
    {
        var box = MessageBoxManager.GetMessageBoxStandard(
            "Приветствие",
            "Привет, меня зовут Aribzhan!",
            ButtonEnum.Ok);
        await box.ShowAsync();
    }
}


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