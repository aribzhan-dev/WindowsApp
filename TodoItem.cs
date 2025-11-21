namespace HelloAvalonia;

public class TodoItem
{
    public int Id { get; set; }
    public string Text { get; set; } = "";
    public string Status { get; set; } = "Not Started";
    public bool IsChecked { get; set; } = false;
}