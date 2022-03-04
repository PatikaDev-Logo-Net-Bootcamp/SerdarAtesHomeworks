
using System.ComponentModel.DataAnnotations;

namespace HomeworkOne.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Ad Soyad Girilmelidir")]
        public string adSoyad { get; set; }


        [Required(ErrorMessage = "Email girmelisiniz")]
        [RegularExpression("^[A-Za-z0-9._%+-]*@[A-Za-z0-9.-]*\\.[A-Za-z0-9-]{2,}$",
        ErrorMessage = "Email formatı uygun değil")]
        public string email { get; set; }
        [Required(ErrorMessage = "Şifre girmelisiniz")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)[a-zA-Z\\d\\W]{8,63}$", 
            ErrorMessage ="Şifreniz En az 1 büyük karakter 1 sayı ve 8 haneyi geçmelidir")]
        //[StringLength(8, ErrorMessage = "Şifreniz 8 karakterden büyük olamaz")]
        public string password { get; set; }


    }
}
