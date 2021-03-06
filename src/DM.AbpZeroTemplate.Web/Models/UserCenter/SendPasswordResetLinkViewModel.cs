using System.ComponentModel.DataAnnotations;

namespace DM.AbpZeroTemplate.Web.Models.UserCenter
{
    public class SendPasswordResetLinkViewModel
    {
        public string TenancyName { get; set; }

        [Required]
        public string EmailAddress { get; set; }
    }
}