using System.ComponentModel.DataAnnotations;

namespace Todo.Models
{
    public class TodoList
    {
        [Key] public int Id { get; set; }
        [Required, MinLength(3), MaxLength(10)] public string Header { get; set; }
        [MinLength(3), MaxLength(20)] public string? SubHeader { get; set; }
        [MaxLength(100)] public string? Description { get; set; }
        [Required] public DateTime SubmissionsDate { get; set; }
        public DateTime? DueDate { get; set; }
    }
}
