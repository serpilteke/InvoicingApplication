﻿using System.ComponentModel.DataAnnotations;

namespace InvoicingApplication.Models.Classes
{
    public class Customers
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
        public string PhoneNumber { get; set; } = null!;

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Şifre alanı boş bırakılamaz.")]
        [Display(Name = "Şifre :")]
        [MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter olabilir")]
        public string Password { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string CitysId { get; set; } = null!;
        public string CountrysId { get; set; } = null!;
        public string WebSite { get; set; } = null!;

        public ICollection<Citys> Citys { get; set; } = null!; //her bir müşteri bir şehre ait olabilir.??
        public ICollection<Countrys> Countrys { get; set; } = null!;//her bir müşteri bir ülkeye ait olabilir.??
        
    }
}
