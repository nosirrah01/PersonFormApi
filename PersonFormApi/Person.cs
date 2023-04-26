using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonFormApi
{
    [Table("People")]
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Sex { get; set; }
    }
}
