using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HelloAvalonia;

public class TodoItem : INotifyPropertyChanged
{
    private int _id;
    private string _text = "";
    private bool _isChecked;
    private string _status = "Active";

    public int Id
    {
        get => _id;
        set { _id = value; OnPropertyChanged(); }
    }

    public string Text
    {
        get => _text;
        set { _text = value; OnPropertyChanged(); }
    }

    public bool IsChecked
    {
        get => _isChecked;
        set
        {
            if (_isChecked != value)
            {
                _isChecked = value;
                Status = value ? "Done" : "Active";  // <--- Checkbox bosilganda status o'zgaradi
                OnPropertyChanged();
            }
        }
    }

    public string Status
    {
        get => _status;
        set
        {
            if (_status != value)
            {
                _status = value;
                OnPropertyChanged();
            }
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string? prop = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
}