using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities.Response
{
    public class LoginResponse : BaseResponse
    {
        public bool IsLogin { get; set; }
        public string Token { get; set; }
        public string Email { get; set; }

    }

    public class EmailExistsResponse : BaseResponse
    {
        public bool IsEmailExists { get; set; }
    }
    public class IsCurrentUserEmailResponse : BaseResponse
    {
        public bool IsCurrentUserEmail { get; set; }
    }

    public class IsCurrentUserPasswordResponse : BaseResponse
    {
        public bool IsCurrentUserPassword { get; set; }
    }



    public class UserDetail
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Enabled { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string User_Role { get; set; }
    }

    public class UserDetailResponse : BaseResponse
    {
        public UserDetail UserDetail { get; set; }
    }

    public class LoggedUserDetailResponse : BaseResponse
    {
        public string Email { get; set; }
        public string PackageType { get; set; }
        public string Status { get; set; }
        public bool Verified { get; set; }
        public UserBiometricData UserBiometricData { get; set; }
        public DMCAStatus DMCAStatus { get; set; }
        public DMCALegalActionStatus DMCALegalActionStatus { get; set; }
        public UserSearchResultData UserSearchResultData { get; set; }
        public bool? AccessDMCANotice { get; set; }
    }

    public class ProfileDetailResponse : BaseResponse
    {
        public string Email { get; set; }
        public string Status { get; set; }
        public bool Verified { get; set; }
        public string PackageType { get; set; }
        public string PaymentMethod { get; set; }
        public UserBiometricData UserBiometricData { get; set; }
        public DMCAStatus DMCAStatus { get; set; }
        public DMCALegalActionStatus DMCALegalActionStatus { get; set; }
        public PackageFeatureDetail PackageFeatureDetail { get; set; }

    }


    public class AccountDetailReposne : BaseResponse
    {
        public string Email { get; set; }
    }

    public class SignUpReposne : BaseResponse
    {
    }

    public class CreateUserAPIResponse
    {
        public int pagesCount { get; set; }
        public int totalUsers { get; set; }
        public string actionMessage { get; set; }
        public string searchMessage { get; set; }
        public List<UserDetail> users { get; set; }
    }


    public class DetectSingleImageUserResponse
    {
        public List<TempFaceResponse> croppedTempFaceList { get; set; }
        public string status { get; set; }
    }

    public class TempFaceResponse
    {
        public int tempFaceId { get; set; }

        public string tempFaceBase64Str { get; set; }
    }


    public class UserBiometricData
    {
        public int id { get; set; }
        public string email { get; set; }
        public string faceFilePath { get; set; }
        public string biometricData { get; set; }
        public bool verified { get; set; }
        public int verificationAttempts { get; set; }

    }

    public class UserSearchResultData
    {
        public string queryFaceBase64str { get; set; }
        public int userBiometricsId { get; set; }
        public string userEmail { get; set; }
        public List<candidateFaceList> candidateFaceList { get; set; }
        public float queryTime { get; set; }
        public string status { get; set; }
    }

    public class candidateFaceList
    {
        public int mainFaceId { get; set; }
        public float score { get; set; }
        public string source { get; set; }
    }

    public class UserSearchResultDataResponse : BaseResponse
    {
        public UserSearchResultData UserSearchResultData { get; set; }
    }




    public class DMCALegalActionStatusResult
    {
        public DMCAStatus DMCAStatus { get; set; }
        public DMCALegalActionStatus DMCALegalActionStatus { get; set; }
    }

    public class DMCAStatus
    {
        public int? rcount { get; set; }
        public int? pcount { get; set; }
        public int? dcount { get; set; }

    }
    public class DMCALegalActionStatus
    {
        public int? wcount { get; set; }
        public int? ecount { get; set; }
        public int? ccount { get; set; }

    }

    public class DMCALegalActionStatusStringResult
    {
        public string DMCAStatus { get; set; }
        public string DMCALegalActionStatus { get; set; }
    }

    public class DMCALegalActionStatusResponse : BaseResponse
    {
        public DMCAStatus DMCAStatusResult { get; set; }
        public DMCALegalActionStatus DMCALegalActionStatusResult { get; set; }
    }

    public class HitRecord
    {
        public int id { get; set; }
        public Nullable<System.DateTime> datetime { get; set; }
        public int userbiometrics_id { get; set; }
    }

    public class HitRecordListResponse : BaseResponse
    {
        public List<UserSearchReport> HitRecordList { get; set; }
        public bool? ShowSearchResults { get; set; }
    }

    public class HitRecordResult
    {
        public int? resultid { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string parentfilename { get; set; }

        public string replace { get; set; }
    }

    public class MultipleFaceBiometricsListResponse : BaseResponse
    {
        public List<HitRecordResult> MultipleFaceBiometrics { get; set; }
        public DateTime? SearchDateTime { get; set; }
    }

    //public class MultipleFaceBiometric
    //{
    //    public int id { get; set; }

    //    public string facefilepath { get; set; }

    //    public string parentfilename { get; set; }
    //}


    public class UserInvoice
    {
        public int PaymentId { get; set; }
        public int? UserId { get; set; }
        public Nullable<System.DateTime> PaymentDate { get; set; }

        public float? Discount { get; set; }
        public float? TotalOrder { get; set; }
        public string PaymentMethod { get; set; }
        public string Type { get; set; }
    }

    public class UserInvoiceListResponse : BaseResponse
    {
        public List<UserInvoice> UserInvoices { get; set; }

        public String Email { get; set; }
    }

    public class UserTicket
    {
        public int TicketId { get; set; }
        public int? UserId { get; set; }
        public string Subject { get; set; }
        public string Department { get; set; }
        public int? Status { get; set; }
        public string Priority { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    }

    public class UserTicketListResponse : BaseResponse
    {
        public List<UserTicket> UserTickets { get; set; }
    }


    public class URLs
    {
        public string link { get; set; }
    }

    public class FaceLink
    {
        public int Id { get; set; }
        public string[] ImagePath { get; set; }
        public string[] ImageUrl { get; set; }
    }

    public class FaceLinksResponse : BaseResponse
    {
        public List<FaceLink> FaceLinks { get; set; }
    }

    public class Images
    {
        public DateTime updated { get; set; }
        public string image_path { get; set; }
        public int? site_id { get; set; }
        public string image_name { get; set; }
        public string image_url { get; set; }
        public String processed { get; set; }
        public int Id { get; set; }
    }

    public class ImageWithLink
    {
        public List<Images> imageslist { get; set; }
        public string replace { get; set; }
    }

    public class ImageWithLinksResponse : BaseResponse
    {
        public List<ImageWithLink> ImageWithLinks { get; set; }
    }

    public class DMCALink
    {
        public int LinkId { get; set; }
        public int? UserId { get; set; }
        public string Url { get; set; }
        public string Status { get; set; }
        public string LegalAction { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string Action { get; set; }
        public string Active { get; set; }
    }

    public class DMCALinksResponse : BaseResponse
    {
        public List<DMCALink> DMCALinks { get; set; }
        public bool? AccessDMCANotice { get; set; }
    }


    public class ChangePasswordResponse : BaseResponse
    {
        public string Token { get; set; }
    }

    public class UserLegalEnquiry
    {
        public int LegalEnquiryId { get; set; }
        public int? UserId { get; set; }
        public string Message { get; set; }
        public string Active { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    }

    public class UserLegalEnquiryListResponse : BaseResponse
    {
        public List<UserLegalEnquiry> UserLegalEnquiry { get; set; }
    }
    public class SiteDetail
    {
        public int SiteId { get; set; }
        public string SiteName { get; set; }
        public string WebsiteAddress { get; set; }
        public string AgentName { get; set; }
        public string AgentEmail { get; set; }
        public int Count { get; set; }
    }


    public class PayDMCANotice
    {
        public int UserDocumentId { get; set; }
        public int DocumentId { get; set; }
        public string DocumentName { get; set; }
        public string DocumentPath { get; set; }
        public string DocumentType { get; set; }
        public int? RequiresSignature { get; set; }
        public string Subject { get; set; }
        public int? Signed { get; set; }
        public Nullable<System.DateTime> DocumentDate { get; set; }
    }

    public class PayDMCANoticeList : BaseResponse
    {
        public List<PayDMCANotice> PayDMCANotice { get; set; }
        public int PendingSignDocument { get; set; }
        public bool? AccessDMCANotice { get; set; }
    }

    public class CheckUserStatus : BaseResponse
    {
        public string UserStatus { get; set; }
    }
    public class PdfResponse
    {
        public string Filename { get; set; }
        public string FilePath { get; set; }
        public string FullPath { get; set; }
    }

    public class TaxResponse : BaseResponse
    {
        public decimal combined_rate { get; set; }
    }

    public class SignDocumentResponse
    {
        public int DocumentId { get; set; }
        public int UserDocumentId { get; set; }
        public string DocumentName { get; set; }
        public string DocumentPath { get; set; }
        public string DocumentType { get; set; }
        public int? RequiresSignature { get; set; }
        public int? Signed { get; set; }
        public string AgentEmail { get; set; }
    }
    public class SignResponse : BaseResponse
    {
        public string DocumentPath { get; set; }
        public string TypeOfDocument { get; set; }
    }

    public class SavePaymentReponse : BaseResponse
    {
        public int? PaymentId { get; set; }

        public string AmazonParamters { get; set; }
    }

    public class PaymentDetailResponse : BaseResponse
    {
        public string Processed { get; set; }
    }
    public class UserDetailForSearchInvoked
    {
        public int UserId { get; set; }
        public DateTime? HitrecordDateTime { get; set; }
        public string Enabled { get; set; }
        public int UserBiometericId { get; set; }
        public int? HitrecordId { get; set; }
        public int SearchAllowed { get; set; }
        public string PackageType { get; set; }
        public int packageid { get; set; }
        public string Email { get; set; }
    }

    public class UserDetailForSearchInvokedJson
    {
        public string UserDetailForSearchInvokedJsonString { get; set; }
    }

    public class UserEmailResponse : BaseResponse
    {
        public string Email { get; set; }
    }
    public class UserDetailWithBiometricResponse
    {
        public int UserId { get; set; }
        public int UserBiomerticId { get; set; }
        public string UserEmail { get; set; }
    }

    public class PaymentFunctionResponse
    {
        public int UID { get; set; }
        public string UEmail { get; set; }
        public string PType { get; set; }
        public int? UBID { get; set; }
    }

    public class UserSearchReport
    {
        public int UserSearchId { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    public class UserSearchReportResponse
    {
        public bool ShowSearchResults { get; set; }
        public List<UserSearchReport> searchReports { get; set; }

    }

    public class AgeVerificationAPIResponse
    {
        public string tid { get; set; }
        public int? mc { get; set; }
        public string mc_desc { get; set; }
        public int? err_code { get; set; }
        public string err_desc { get; set; }
    }

    public class IsUserBlockedResponse : BaseResponse
    {
        public bool? Blocked { get; set; }
    }

    public class UnsignedUser
    {
        public int? dunning_signed { get; set; }
        public int? dmca_signed { get; set; }
        public int id { get; set; }
        public string email { get; set; }
    }

    public class DunningLetter
    {
        public string AgentEmail { get; set; }
        public int? DunningDocumentId { get; set; }
        public string DocumentPath { get; set; }
    }

    public class UserEmailRegistrationRequest
    {
        public string Email { get; set; }
    }

    public class EmailToRegisterUsers
    {
        public int UserEmailRegistrationId { get; set; }
        public string Email { get; set; }

    }

    public class AmzonRecurringPayment
    {
        public int CouponId { get; set; }
        public int SearchAllowed { get; set; }
        public float SubTotal { get; set; }
        public float Price { get; set; }
        public float Discount { get; set; }
        public string BillingId { get; set; }
        public float? TotalOrder { get; set; }
        public int id { get; set; }
        public float? SalesTax { get; set; }
        public int PackageId { get; set; }
    }
    public class paging
    {
        public cursors cursors { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
    }

    public class cursors
    {
        public string before { get; set; }
        public string after { get; set; }
    }

    public class FaceBookPostsList
    {
        public List<FaceBookPosts> data { get; set; }
        public paging paging { get; set; }
    }

    public class FaceBookPosts
    {
        public string full_picture { get; set; }
        public string picture { get; set; }
        public string link { get; set; }
        public string message { get; set; }
        public string created_time { get; set; }
        public string id { get; set; }
        public string permalink_url { get; set; }
        public string description { get; set; }
    }

    public class FaceBookPostsBaseResponse : BaseResponse
    {
        public FaceBookPostsList faceBookPostsList { get; set; }
    }

    public class FaceBookAccessToken
    {
        public string access_token { get; set; }
        public string token_type { get; set; }

    }
    public class AdminUserRegistration
    {

        public int UserEmailRegistrationId { get; set; }
        public string Email { get; set; }
        public bool IsProcessed { get; set; }
        public string CreatedDate { get; set; }

    }
    public class AdminUserRegistrationList
    {
        public List<AdminUserRegistration> resultdata { get; set; }
        public int totalcount { get; set; }
    }
    public class AdminUserRegistrationListResponse : BaseResponse
    {
        public List<AdminUserRegistration> resultdata { get; set; }
        public int totalcount { get; set; }
    }
}
