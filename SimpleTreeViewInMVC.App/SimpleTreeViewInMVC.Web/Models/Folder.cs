
namespace SimpleTreeViewInMVC.Web.Models
{
    public class Folder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
    }
}