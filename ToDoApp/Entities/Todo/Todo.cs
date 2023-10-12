using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Entities.Todo
{
    public class Todo
    {
        [Key]
        public int MyProperty { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "The title can not be more than 100 characters.")]
        public string Title { get; set; }
        [MaxLength(500, ErrorMessage = "The description can not be more than 500 characters.")]
        public string?  Description { get; set; }
        public bool IsDone { get; set; }
    }
}
