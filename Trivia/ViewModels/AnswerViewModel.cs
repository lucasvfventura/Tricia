namespace Trivia.ViewModels
{
    public class AnswerViewModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool IsChecked { get { return false;} private set{} }
    }
}