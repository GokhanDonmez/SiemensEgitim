using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDo.Entities
{
    public class ToDoProgram
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(30)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Description { get; set; }

    }
}