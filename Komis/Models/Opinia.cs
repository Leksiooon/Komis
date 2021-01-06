using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Komis.Models
{
    public class Opinia
    {
        [BindNever]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nazwa użytkownika jest wymagana")]
        [StringLength(100, ErrorMessage = "Nazwa użytkownika jest zadługa")]
        public string NazwaUzytkownika { get; set; }

        [Required(ErrorMessage = "Adres Email jest wymagany")]
        [StringLength(100, ErrorMessage = "Adres email jest za długi")]
        [DataType(DataType.EmailAddress)]
        //[RegularExpression("^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "To nie jest poprawny adres email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Wiadomość jest wymagana")]
        [StringLength(5000, ErrorMessage = "Wiadomość jest za długa")]
        public string Wiadomosc { get; set; }

        public bool OczekujeOdpowiedzi { get; set; }
    }
}
