using App.Repository.IRepository;
using App.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities.Request;
using App.Entities.Response;
using RestSharp;
using App.Entities.Common;
using System.Configuration;
using System.Net;
using System.Web.UI.WebControls;
using System.IO;
using App.Repository;

namespace App.Service.Service
{
    public class AccountService : IAccountService
    {
        #region Private

        private IAccountRepository _IAccountRepository;

        #endregion

        public AccountService(IAccountRepository IAccountRepository)
        {
            _IAccountRepository = IAccountRepository;
        }

        #region Public Function

        public async Task<LoginResponse> Login(UserLogin userLogin)
        {
            return await _IAccountRepository.Login(userLogin);
        }
        public BaseResponse EnrollUserIDPhoto(PhotoDetailRequest photoDetail)
        {
            return _IAccountRepository.EnrollUserIDPhoto(photoDetail);
        }
        public async Task<SavePaymentReponse> SavePaymentDetail(PaymentDetailRequest paymentDetailsRequest)
        {
            return await _IAccountRepository.SavePaymentDetail(paymentDetailsRequest);
        }

        public async Task<EmailExistsResponse> EmailExists(string email)
        {
            return await _IAccountRepository.EmailExists(email);
        }

        public IRestResponse UserCreate(usercreate userDetail)
        {
            return _IAccountRepository.UserCreate(userDetail);
        }

        public BaseResponse SaveUserImage(UserImageRequest userImageRequest)
        {
            return _IAccountRepository.SaveUserImage(userImageRequest);
        }
        public async Task<SignUpReposne> SignUpUser(SignUpDetailsRequest signUpDetails)
        {
            return await _IAccountRepository.SignUpUser(signUpDetails);
        }

        public AccountDetailReposne SaveAccountDetail(AccountDetail accountDetail)
        {
            return _IAccountRepository.SaveAccountDetail(accountDetail);
        }


        public async Task<TaxResponse> GetTax(TaxJarRequest taxJarRequest)
        {
            return await _IAccountRepository.GetTax(taxJarRequest);
        }

        public async Task<TaxResponse> GetLoggedInUserTax()
        {
            return await _IAccountRepository.GetLoggedInUserTax();
        }

        public async Task<LoggedUserDetailResponse> GetLoggedInUserDetail()
        {
            return await _IAccountRepository.GetLoggedInUserDetail();
        }

        public async Task<BaseResponse> ForgetPasswordLink(string email)
        {
            return await _IAccountRepository.ForgetPasswordLink(email);
        }

        public async Task<BaseResponse> RestForgetPassword(string token, RestPassword RestPassword)
        {
            return await _IAccountRepository.RestForgetPassword(token, RestPassword);
        }
        
        public BaseResponse ValidateForgetPasswordLink(string token)
        {
            return _IAccountRepository.ValidateForgetPasswordLink(token);
        }

        
        public async Task<ChangePasswordResponse> ChangePassword(ChangePasswordRequest changePasswordRequest)
        {
            return await _IAccountRepository.ChangePassword(changePasswordRequest);
        }

        public UserSearchResultDataResponse SearchByResultByEmail()
        {
            return _IAccountRepository.SearchByResultByEmail();
        }

        public UserSearchResultDataResponse GetReconizeFaceByUserBiometericsId()
        {
            return _IAccountRepository.GetReconizeFaceByUserBiometericsId();
        }

        public async Task<ProfileDetailResponse> GetUserProfileDetail()
        {
            return await _IAccountRepository.GetUserProfileDetail();
        }

        //public async Task<DMCALegalActionStatusResponse> GetDMCALegalActionStatus(string loggedInUser)
        //{
        //    return await _IAccountRepository.GetDMCALegalActionStatus(loggedInUser);
        //}

        public async Task<HitRecordListResponse> GetHitRecords()
        {
            return await _IAccountRepository.GetHitRecords();
        }

        public async Task<MultipleFaceBiometricsListResponse> GetMultipleFaceBiometricsByHitRecordRecordId(int hitRecordRecordId)
        {
            return await _IAccountRepository.GetMultipleFaceBiometricsByHitRecordRecordId(hitRecordRecordId);
        }

        public async Task<UserInvoiceListResponse> GetUserInvoice(bool viewAll)
        {
            return await _IAccountRepository.GetUserInvoice(viewAll);
        }

        public async Task<UserTicketListResponse> GetUserTicket(bool viewAll)
        {
            return await _IAccountRepository.GetUserTicket(viewAll);
        }
        public async Task<ImageWithLinksResponse> GetFaceLinks(ImageNameRequest ImageNameRequest)
        {
            return await _IAccountRepository.GetFaceLinks(ImageNameRequest);
        }

        public async Task<BaseResponse> SaveDMCALinks(RemoveableImageLinksRequest removeableImageLinksRequest)
        {
            return await _IAccountRepository.SaveDMCALinks(removeableImageLinksRequest);
        }

        public async Task<SavePaymentReponse> SavePaymentDetails(PaymentDetailsRequest paymentDetailsRequest)
        {
            return await _IAccountRepository.SavePaymentDetails(paymentDetailsRequest);
        }

        public async Task<int> SaveDocument(Document documentRequest)
        {
            return await _IAccountRepository.SaveDocument(documentRequest);
        }

        public async Task<int> SaveTicketAttachment(TicketAttachment ticketAttachmentRequest)
        {
            return await _IAccountRepository.SaveTicketAttachment(ticketAttachmentRequest);
        }

        public async Task<int> SaveTickets(TicketRequest ticketRequest)
        {
            return await _IAccountRepository.SaveTickets(ticketRequest);
        }

        public async Task<DMCALinksResponse> GetDMCARemovalLinks()
        {
            return await _IAccountRepository.GetDMCARemovalLinks();
        }

        public async Task<DMCALinksResponse> GetLegalActionRemovalLinks()
        {
            return await _IAccountRepository.GetLegalActionRemovalLinks();
        }
        public async Task<BaseResponse> CheckOldPassword(string OldPassword)
        {
            return await _IAccountRepository.CheckOldPassword(OldPassword);
        }

        public async Task<BaseResponse> EmailDMCANotice(DMCANoticeEmailRequest DMCANoticeEmailRequest)
        {
            return await _IAccountRepository.EmailDMCANotice(DMCANoticeEmailRequest);
        }

        public async Task<BaseResponse> EmailLawyerLetter(LawyerLetterEmailRequest lawyerLetterEmailRequest)
        {
            return await _IAccountRepository.EmailLawyerLetter(lawyerLetterEmailRequest);
        }

        public async Task<BaseResponse> SaveEnquiry(EnquiryRequest enquiryRequest)
        {
            return await _IAccountRepository.SaveEnquiry(enquiryRequest);
        }

        public async Task<BaseResponse> UpdatePackage(UpdatePackageRequest updatePackageRequest)
        {
            return await _IAccountRepository.UpdatePackage(updatePackageRequest);
        }

        public async Task<Stream> DownloadInvoice(int InvoiceId)
        {
            return await _IAccountRepository.DownloadInvoice(InvoiceId);


        }

        public async Task<BaseResponse> DeactiveUserStatus()
        {
            return await _IAccountRepository.DeactiveUserStatus();
        }

        public IsCurrentUserEmailResponse IsCurrentUserEmail(string email)
        {
            return _IAccountRepository.IsCurrentUserEmail(email);
        }

        public async Task<IsCurrentUserPasswordResponse> IsCurrentUserPassword(string password)
        {
            return await _IAccountRepository.IsCurrentUserPassword(password);
        }

        public async Task<BaseResponse> GenerateDMCANotice(DMCANoticeGenerateRequest DMCAnoticeGenerateRequest)
        {
            return await _IAccountRepository.GenerateDMCANotice(DMCAnoticeGenerateRequest);
        }

        public async Task<PayDMCANoticeList> GetDMCADocuments()
        {
            return await _IAccountRepository.GetDMCADocuments();
        }

        public async Task<bool> CheckAccessOnNoticeGenerater()
        {
            return await _IAccountRepository.CheckAccessOnNoticeGenerater();
        }

        public async Task<CheckUserStatus> CheckStatusOfCurrentUser()
        {
            return await _IAccountRepository.CheckStatusOfCurrentUser();
        }

        public async Task<bool> SendTicketMail(TicketMailRequest TicketMail)
        {
            return await _IAccountRepository.SendTicketMail(TicketMail);
        }
        
        public async Task<SignResponse> SignDocument(SignDocumentRequest signDocumentRequest)
        {
            return await _IAccountRepository.SignDocument(signDocumentRequest);
        }

        public async Task<UserDetailResponse> GetUserDetailByUserEmail(string email)
        {
            return await _IAccountRepository.GetUserDetailByUserEmail(email);
        }

        public async Task<BaseResponse> SavePayDetail(PayDetailsRequest payDetailsRequest)
        {
            return await _IAccountRepository.SavePayDetail(payDetailsRequest);
        }

        public async Task<BaseResponse> UpdatePaymentDetail(int paymentId)
        {
            return await _IAccountRepository.UpdatePaymentDetail(paymentId);
        }
        public async Task<BaseResponse> DMCAUpdatePaymentDetail(int paymentId)
        {
            return await _IAccountRepository.DMCAUpdatePaymentDetail(paymentId);
        }
        public async Task<BaseResponse> FRUpdatePaymentDetail(int paymentId)
        {
            return await _IAccountRepository.FRUpdatePaymentDetail(paymentId);
        }

        public async Task<PaymentDetailResponse> GetPaymentDetailByPaymentId(int paymentId)
        {
            return await _IAccountRepository.GetPaymentDetailByPaymentId(paymentId);
        }

        public async Task<BaseResponse> GetUserDetailForSearchInvoked()
        {
            return await _IAccountRepository.GetUserDetailForSearchInvoked();
        }

        public UserEmailResponse GetCurrentUserEmail()
        {
            return _IAccountRepository.GetCurrentUserEmail();
        }

        public async Task<IsUserBlockedResponse> IsUserBlocked()
        {
            return await _IAccountRepository.IsUserBlocked();
        }

        public async Task<BaseResponse> SendMailToUnSigned()
        {
            return await _IAccountRepository.SendMailToUnSigned();
        }

        public async Task<BaseResponse> DunningLetter()
        {
            return await _IAccountRepository.DunningLetter();
        }
        public async Task<BaseResponse> SaveUserEmailRegistration(UserEmailRegistrationRequest userEmailRegistrationRequest)
        {
            return await _IAccountRepository.SaveUserEmailRegistration(userEmailRegistrationRequest);
        }
        public async Task<BaseResponse> UserEmailRegistrationToken(string token)
        {
            return await _IAccountRepository.UserEmailRegistrationToken(token);
        }

        public async Task<BaseResponse> SendEmailToRegisterUser()
        {
            return await _IAccountRepository.SendEmailToRegisterUser();
        }

        public async Task<BaseResponse> AmazonPaymentScheduling()
        {
            return await _IAccountRepository.AmazonPaymentScheduling();
        }

        public FaceBookPostsBaseResponse GetFaceBookPosts(FaceBookRequest faceBookRequest)
        {
            return _IAccountRepository.GetFaceBookPosts(faceBookRequest);
        }

        #endregion
    }
}
