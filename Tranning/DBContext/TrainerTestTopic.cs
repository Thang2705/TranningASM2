using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Tranning.DBContext
{
    public class TrainerTestTopic
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("CourseId")]
        public int CourseId { get; set; }
        public TrainerTestCourse TrainerTestCourse { get; set; }  // reference navigation

        [Column("NameTopic", TypeName = "Varchar(50)")]
        public string NameTopic { get; set; }

        [Column("Description", TypeName = "Varchar(200)")]
        public string Description { get; set; }

        [Column("Video", TypeName = "Varchar(200)")]
        public string? Video { get; set; }
        [Column("Document", TypeName = "Varchar(150)")]
        public string Document { get; set; }
        [Column("AttachFile", TypeName = "Varchar(150)")]
        public string? AttachFile { get; set; }

        [Column("Status", TypeName = "Integer")]
        public int Status { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
