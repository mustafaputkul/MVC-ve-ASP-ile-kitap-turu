using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace webuyglama.Models
{
    public class KitapTuru
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Kitap türü adı zorunludur.")]
        [DisplayName("Kitap Türü Adı")]
        [StringLength(100, ErrorMessage = "Kitap türü adı en fazla 100 karakter olabilir.")]
        public string Ad { get; set; }
    }
}
