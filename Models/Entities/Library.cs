using System.ComponentModel.DataAnnotations;

namespace LibraryCRUD.Models.Entities
{
    public class Library
    {
        [Key]
        public Guid BookId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Please enter phone number")]
        [Display(Name = "Phone Number")]
        [Phone]
        public string Phone { get; set; }



        
    }
}
