using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Practica01032023.UI.AppWebMVC.Models
{
    public class User
    {
        [Required(ErrorMessage ="El Id es obligatorio")]
        [DisplayName("ID")]
        public int Id { get;set; }
        [Required(ErrorMessage = "El Nombre es obligatorio")]
        [StringLength(20)]
        [DisplayName("Nombre")]
        public string Name { get;set; }
    }
}
