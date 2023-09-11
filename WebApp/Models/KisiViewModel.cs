using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class KisiViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Kişinin Tam Adi")]
        public string TamAdi { get; set; }
    }
}
