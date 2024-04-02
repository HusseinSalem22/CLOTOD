namespace CLOTODO.Pages.Models
{
    public class todoItem
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public bool IsComplete { get; set; }
    }
}