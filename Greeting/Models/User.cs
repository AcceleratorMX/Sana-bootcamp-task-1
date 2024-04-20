using System.ComponentModel.DataAnnotations;

namespace Sana_bootcamp_task_1.Models;

public class User
{
    [Required(ErrorMessage = "This field is required!")]
    public string? FullName { get; set; }
    public User() { }
}