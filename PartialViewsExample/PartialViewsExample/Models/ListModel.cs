namespace PartialViewsExample.Models
{
    public class ListModel
    {
        public String ListTitle { get; set; }= "My List";
        public List<String> ListItems { get; set; } = new List<String>();
    }
}
