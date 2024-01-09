using System.ComponentModel.DataAnnotations;
namespace DevCard.Models
{
    public class Form
    {
        [Required(ErrorMessage ="این فیلد اجباری است!!")]
        [MinLength(3,ErrorMessage ="حداقل سه کاراکتر!")]
        [MaxLength(60,ErrorMessage ="حداکثر 60 کاراکتر")]
        public string Name { get; set; }
        [Required(ErrorMessage = "این فیلد اجباری است!!")]
        [EmailAddress(ErrorMessage ="لطفا یک ایمیل معتبر بنویسید")]
        public string Email { get; set; }
        [Required(ErrorMessage = "لطفا سرویس خود را وارد کنید")]
        public string Service { get; set; }
        [Required(ErrorMessage = "لطفا پیام خود را وارد کنید")]
        public string Message { get; set; }
    }
}
