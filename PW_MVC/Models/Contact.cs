using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PW_MVC.Models
{
    public class Contact
    {
        [DisplayName("نام")]
        [Required(ErrorMessage ="لطفاً {0} را وارد نمائید.")]
        [MinLength(3,ErrorMessage ="حداقل طول {0} {1} کاراکتر می باشد.")]
        [MaxLength(50, ErrorMessage = "حداکثر طول {0} {1} کاراکتر می باشد.")]
        public string Name { get; set; }

        [DisplayName("ایمیل")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمائید.")]
        [EmailAddress(ErrorMessage = "لطفا فرمت صحیح {0} را وارد نمائید.")]
        public string Email { get; set; }
        public string Service { get; set; }
        public string Message { get; set; }

    }
}
