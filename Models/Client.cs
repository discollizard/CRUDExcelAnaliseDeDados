using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDExcelAnaliseDeDados.Models
{
    [Table("Clients")]
    public class Client
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The name field is required", AllowEmptyStrings = false)]
        public string Name { get; set; }

        //TODO: IMPLEMENT REGEX IF TIME LEFT
        public string? Phone { get; set; }
        [Required(ErrorMessage = "The address field is required", AllowEmptyStrings = false)]
        public string Address { get; set; }

    }
}
