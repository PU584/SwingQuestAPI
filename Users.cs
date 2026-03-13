using System.ComponentModel.DataAnnotations;

namespace SwingQuestBackEnd.Models
{
    public class Questions
    {
        [Key]
        public int questionId { get; set; }

        [Required]
        public String question { get; set; } = "";

        [Required]
        public String answer1 { get; set; } = "";

        [Required]
        public String answer2 { get; set; } = "";

        [Required]
        public String answer3 { get; set; } = "";

        [Required]
        public String answer4 { get; set; } = "";

        [Required]
        public int correctAnswer { get; set; } = 0;
    }
}
