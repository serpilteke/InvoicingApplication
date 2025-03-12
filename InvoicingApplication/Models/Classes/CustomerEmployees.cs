using System.ComponentModel.DataAnnotations;

namespace InvoicingApplication.Models.Classes
{
    public class CustomerEmployees
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "Kullanıcı Ad alanı boş bırakılamaz.")]
        [Display(Name = "Kullanıcı Adı :")]
        public string UserName { get; set; } = null!;

        [Required(ErrorMessage = "Ad alanı boş bırakılamaz.")]
        [Display(Name = "Ad :")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Soyad alanı boş bırakılamaz.")]
        [Display(Name = "Soyad :")]
        public string Surname { get; set; } = null!;

        [EmailAddress(ErrorMessage = "Email formatı yanlıştır.")]
        [Required(ErrorMessage = "Email alanı boş bırakılamaz.")]
        [Display(Name = "Email :")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Telefon alanı boş bırakılamaz.")]
        [Display(Name = "Telefon :")]
        public string Phone { get; set; } = null!;

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Şifre alanı boş bırakılamaz.")]
        [Display(Name = "Şifre :")]
        [MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter olabilir")]
        public string Password { get; set; } = null!;

        public ICollection<Customers> Customers { get; set; } = null!; //her bir çalışan bir müşteriye ait olabilir.??


    }
}
