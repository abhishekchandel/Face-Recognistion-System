using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacePinPoint.Entities.Request
{
    public class UserLogin
    {
        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
        public Boolean RemeberMe { get; set; }
    }

    public class EmailRequest
    {
        [Required]
        public string Email { get; set; }
    }

    public class UserIdRequest
    {
        [Required]
        public int Id { get; set; }
    }

    public class AccountDetail
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [MinLength(8)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&])[A-Za-z\d$@$!%*?&]{8,10}")]
        public string Password { get; set; }

        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        [Required]
        public int ZipCode { get; set; }

        [Required]
        public string CountryCode { get; set; }
    }

    public class PhotoDetailRequest {
        public string ImageBase64 { get; set; }
        public string Email { get; set; }
    }

    public class PhotoDetail
    {
        //[Required]
        public string ImageBase64 { get; set; }
    }

    public class PlanDetail
    {
        [Required]
        public string SelectedPackType { get; set; }
        [Required]
        public string SelectPackageId { get; set; }
        [Required]
        public string SelectPackPrice { get; set; }

        public int? SearchAllowed { get; set; }
    }

    public class PaymentDetails
    {
        [Required]
        public string PaymentMethod { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public float Discount { get; set; }
        [Required]
        public float SubTotal { get; set; }
        [Required]
        public float TotalOrder { get; set; }

        public int? CouponId { get; set; }

        public int? LinksCount { get; set; }

        public int? PackageId { get; set; }
        
        public float? SalesTax { get; set; }

        public float? SaleTaxRate { get; set; }


    }
    public class SignUpDetailsRequest
    {
        public AccountDetail AccountDetails { get; set; }
        public PhotoDetail PhotoDetails { get; set; }
        public string[] LinksDetails { get; set; }
        public PlanDetail PlanDetails { get; set; }

        public PaymentDetails PaymentDetails { get; set; }

    }

    public class ForgetPasswordToken
    {
        public string Email { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ExpireDateTime { get; set; }
    }

    public class RestPassword
    {
        [Required]
        [MinLength(8)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&])[A-Za-z\d$@$!%*?&]{8,10}")]
        public string NewPassword { get; set; }

        [Compare("NewPassword")]
        public string ConfirmNewPassword { get; set; }
    }


    public class ChangePasswordRequest
    {
        [Required]
        public string OldPassword { get; set; }

        [Required]
        [MinLength(8)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&])[A-Za-z\d$@$!%*?&]{8,10}")]
        public string NewPassword { get; set; }

        [Compare("NewPassword")]
        public string ConfirmNewPassword { get; set; }
    }

    public class ImageNameRequest
    {
        public int[] ids { get; set; }
    }

    public class RemoveableImageLinksRequest
    {
        public string[] RemoveableImageLinks { get; set; }
    }

    public class SelectedLinkDetail
    {
        public int? SiteId { get; set; }
        public string Url { get; set; }
    }

    public class PaymentDetailRequest
    {
        public List<SelectedLinkDetail> LinksDetails { get; set; }
        public PaymentDetails PaymentDetails { get; set; }
        public PlanDetail PlanDetails { get; set; }
        public string Email { get; set; }
        public string amazonBillingAgreementId { get; set; }
    }

    public class PaymentInfoRequest
    {
        public PaymentDetails PaymentDetails { get; set; }
        public string Email { get; set; }
    }

    public class PaymentDetailsRequest
    {
        public List<SelectedLinkDetail> SelectedLinkDetail { get; set; }
        public PaymentDetails PaymentDetails { get; set; }
        public PlanDetail PlanDetails { get; set; }
        public string amazonBillingAgreementId { get; set; }
    }


    public class TicketRequest
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public string Priority { get; set; }
    }

    public class DMCANoticeEmailRequest
    {
        public string siteName { get; set; }
    }

    public class LawyerLetterEmailRequest
    {
        public string siteName { get; set; }
    }

    public class EnquiryRequest
    {
        public string Message { get; set; }
    }

    public class UpdatePackageRequest
    {
        public int PackageId { get; set; }
        public float PackagePrice { get; set; }
    }

    public class PaymentRequest
    {
        public int PaymentId { get; set; }

    }

    public class DMCANoticeGenerateRequest
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    public class TicketMailRequest
    {
        public string[] fileAttachments { get; set; }
        public int ticketId { get; set; }
        public string UserEmail { get; set; }
    }

    public class SignDocumentRequest
    {
        public int UserDocumentId { get; set; }
        public string Base64Image { get; set; }
    }

    public class TaxJarRequest
    {
        public string UserEmail { get; set; }
    }
    public class UpdatePlanRequest
    {
        public int PackageId { get; set; }
    }
    public class PayDetailsRequest
    {
        public string Source { get; set; }
        public string TrackingNumber { get; set; }
        public double Amount { get; set; }
        public int PaymentId { get; set; }
        public string PayerEmailId { get; set; }
    }

    public class InvokeSearchRequest
    {
        public int UserBiometricId { get; set; }
        public string UserEmail { get; set; }
    }

    public class GetAllFacesRequest
    {
        public int HitRecordRecordId { get; set; }
        public int PageNumber { get; set; }
    }


    public class UserEmailRegistrationToken
    {
        public string Email { get; set; }
        public int UserEmailRegistrationId { get; set; }
    }

    public class FaceBookRequest
    {
        public string after { get; set; }
        public string before { get; set; }
        public int limit { get; set; }
    }

}
