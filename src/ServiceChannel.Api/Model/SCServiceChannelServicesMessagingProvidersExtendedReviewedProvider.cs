/*
 * ServiceChannel API - v.3
 *
 * The ServiceChannel API is a RESTful and stateless API. It accepts standard HTTP verbs and supports OAuth 2.0 for authorizing requests.      Our API returns common HTTP status codes as well as JSON encapsulated data.      See [API Overview](https://developer.servicechannel.com/basics/introduction/overview/) for the intro to ServiceChannel API.<br>      <h3>Authentication and Authorization</h3>You should have a ServiceChannel account, register your application, and obtain `access_token` to integrate with our API.      See [Authentication and Authorization](https://developer.servicechannel.com/basics/general/authentication/) for more information.      To use this API playground, click **Authorize** and sign in to ServiceChannel.<br>      <h3>Environment</h3> All calls in this API Reference point to the **SB2 environment**.      See [Environments](https://developer.servicechannel.com/basics/general/environments/) for more information.<br>      <h3>API Version</h3>The current stable version of the ServiceChannel API is `v3`. In the request URL, `v3` is a version prefix that should be present.      When you omit the version prefix, calls point to the minimum supported version of the API.      We recommend you to always specify the API version to avoid possible errors.
 *
 * The version of the OpenAPI document: 3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = ServiceChannel.Api.Client.OpenAPIDateConverter;

namespace ServiceChannel.Api.Model
{
    /// <summary>
    /// A provider entity with common reviews information
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.Providers.ExtendedReviewedProvider")]
    public partial class SCServiceChannelServicesMessagingProvidersExtendedReviewedProvider : IEquatable<SCServiceChannelServicesMessagingProvidersExtendedReviewedProvider>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingProvidersExtendedReviewedProvider" /> class.
        /// </summary>
        /// <param name="reviewsInfo">reviewsInfo.</param>
        /// <param name="myProviderReview">myProviderReview.</param>
        /// <param name="anyMyReviews">Whether the provider has any reviews with current user (default to false).</param>
        /// <param name="trades">Trades which the provider serves for the current subscriber..</param>
        /// <param name="phone">phone.</param>
        /// <param name="fullName">Full Name.</param>
        /// <param name="address1">Address1.</param>
        /// <param name="address2">Adress2.</param>
        /// <param name="city">City.</param>
        /// <param name="state">State.</param>
        /// <param name="zip">Zip.</param>
        /// <param name="country">Country.</param>
        /// <param name="mainContact">Main Contact.</param>
        /// <param name="dateCreated">Date Created.</param>
        /// <param name="lastUserDate">Last User Date.</param>
        /// <param name="superUser">SuperUser.</param>
        /// <param name="webSite">WebSite.</param>
        /// <param name="email">Email.</param>
        /// <param name="taxId">Tax Id.</param>
        /// <param name="trade">Trade.</param>
        /// <param name="processingEmail">Processing Email.</param>
        /// <param name="faxNumber">Fax Number.</param>
        /// <param name="suiteFloor">Suite Floor.</param>
        /// <param name="mailInfo">Mail Info.</param>
        /// <param name="imageFile">Image File.</param>
        /// <param name="returnMail">Return Mail.</param>
        /// <param name="mailFrequency">Mail Frequency.</param>
        /// <param name="formId">Form Id.</param>
        /// <param name="pager">Pager.</param>
        /// <param name="nightRequest">NightRequest.</param>
        /// <param name="shortFormatEmail">Short Format Email.</param>
        /// <param name="lastTrainingDate">Last Training Date.</param>
        /// <param name="lastTrainingDateStr">Last Training Date as a string.</param>
        /// <param name="isInternal">Is Internal (default to false).</param>
        /// <param name="isOnOffShoreFeatureEnabled">Is OnOffShoreFeature Enabled (default to false).</param>
        /// <param name="id">Id.</param>
        /// <param name="name">Name.</param>
        /// <param name="doNotDispatch">DoNotDispatch enabled? (default to false).</param>
        public SCServiceChannelServicesMessagingProvidersExtendedReviewedProvider(SCServiceChannelServicesMessagingFeedbackReviewsInfo reviewsInfo = default(SCServiceChannelServicesMessagingFeedbackReviewsInfo), SCServiceChannelServicesMessagingFeedbackUserReview myProviderReview = default(SCServiceChannelServicesMessagingFeedbackUserReview), bool anyMyReviews = false, List<string> trades = default(List<string>), string phone = default(string), string fullName = default(string), string address1 = default(string), string address2 = default(string), string city = default(string), string state = default(string), string zip = default(string), string country = default(string), string mainContact = default(string), DateTime dateCreated = default(DateTime), string lastUserDate = default(string), string superUser = default(string), string webSite = default(string), string email = default(string), string taxId = default(string), string trade = default(string), string processingEmail = default(string), string faxNumber = default(string), string suiteFloor = default(string), string mailInfo = default(string), string imageFile = default(string), string returnMail = default(string), int mailFrequency = default(int), int formId = default(int), string pager = default(string), int nightRequest = default(int), string shortFormatEmail = default(string), DateTime lastTrainingDate = default(DateTime), string lastTrainingDateStr = default(string), bool isInternal = false, bool isOnOffShoreFeatureEnabled = false, int id = default(int), string name = default(string), bool doNotDispatch = false)
        {
            this.ReviewsInfo = reviewsInfo;
            this.MyProviderReview = myProviderReview;
            this.AnyMyReviews = anyMyReviews;
            this.Trades = trades;
            this.Phone = phone;
            this.FullName = fullName;
            this.Address1 = address1;
            this.Address2 = address2;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Country = country;
            this.MainContact = mainContact;
            this.DateCreated = dateCreated;
            this.LastUserDate = lastUserDate;
            this.SuperUser = superUser;
            this.WebSite = webSite;
            this.Email = email;
            this.TaxId = taxId;
            this.Trade = trade;
            this.ProcessingEmail = processingEmail;
            this.FaxNumber = faxNumber;
            this.SuiteFloor = suiteFloor;
            this.MailInfo = mailInfo;
            this.ImageFile = imageFile;
            this.ReturnMail = returnMail;
            this.MailFrequency = mailFrequency;
            this.FormId = formId;
            this.Pager = pager;
            this.NightRequest = nightRequest;
            this.ShortFormatEmail = shortFormatEmail;
            this.LastTrainingDate = lastTrainingDate;
            this.LastTrainingDateStr = lastTrainingDateStr;
            this.IsInternal = isInternal;
            this.IsOnOffShoreFeatureEnabled = isOnOffShoreFeatureEnabled;
            this.Id = id;
            this.Name = name;
            this.DoNotDispatch = doNotDispatch;
        }

        /// <summary>
        /// Gets or Sets ReviewsInfo
        /// </summary>
        [DataMember(Name = "ReviewsInfo", EmitDefaultValue = false)]
        public SCServiceChannelServicesMessagingFeedbackReviewsInfo ReviewsInfo { get; set; }

        /// <summary>
        /// Gets or Sets MyProviderReview
        /// </summary>
        [DataMember(Name = "MyProviderReview", EmitDefaultValue = false)]
        public SCServiceChannelServicesMessagingFeedbackUserReview MyProviderReview { get; set; }

        /// <summary>
        /// Whether the provider has any reviews with current user
        /// </summary>
        /// <value>Whether the provider has any reviews with current user</value>
        [DataMember(Name = "AnyMyReviews", EmitDefaultValue = true)]
        public bool AnyMyReviews { get; set; }

        /// <summary>
        /// Trades which the provider serves for the current subscriber.
        /// </summary>
        /// <value>Trades which the provider serves for the current subscriber.</value>
        [DataMember(Name = "Trades", EmitDefaultValue = false)]
        public List<string> Trades { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name = "Phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// Full Name
        /// </summary>
        /// <value>Full Name</value>
        [DataMember(Name = "FullName", EmitDefaultValue = false)]
        public string FullName { get; set; }

        /// <summary>
        /// Address1
        /// </summary>
        /// <value>Address1</value>
        [DataMember(Name = "Address1", EmitDefaultValue = false)]
        public string Address1 { get; set; }

        /// <summary>
        /// Adress2
        /// </summary>
        /// <value>Adress2</value>
        [DataMember(Name = "Address2", EmitDefaultValue = false)]
        public string Address2 { get; set; }

        /// <summary>
        /// City
        /// </summary>
        /// <value>City</value>
        [DataMember(Name = "City", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name = "State", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// Zip
        /// </summary>
        /// <value>Zip</value>
        [DataMember(Name = "Zip", EmitDefaultValue = false)]
        public string Zip { get; set; }

        /// <summary>
        /// Country
        /// </summary>
        /// <value>Country</value>
        [DataMember(Name = "Country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// Main Contact
        /// </summary>
        /// <value>Main Contact</value>
        [DataMember(Name = "MainContact", EmitDefaultValue = false)]
        public string MainContact { get; set; }

        /// <summary>
        /// Date Created
        /// </summary>
        /// <value>Date Created</value>
        [DataMember(Name = "DateCreated", EmitDefaultValue = false)]
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Last User Date
        /// </summary>
        /// <value>Last User Date</value>
        [DataMember(Name = "LastUserDate", EmitDefaultValue = false)]
        public string LastUserDate { get; set; }

        /// <summary>
        /// SuperUser
        /// </summary>
        /// <value>SuperUser</value>
        [DataMember(Name = "SuperUser", EmitDefaultValue = false)]
        public string SuperUser { get; set; }

        /// <summary>
        /// WebSite
        /// </summary>
        /// <value>WebSite</value>
        [DataMember(Name = "WebSite", EmitDefaultValue = false)]
        public string WebSite { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        /// <value>Email</value>
        [DataMember(Name = "Email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Tax Id
        /// </summary>
        /// <value>Tax Id</value>
        [DataMember(Name = "TaxId", EmitDefaultValue = false)]
        public string TaxId { get; set; }

        /// <summary>
        /// Trade
        /// </summary>
        /// <value>Trade</value>
        [DataMember(Name = "Trade", EmitDefaultValue = false)]
        public string Trade { get; set; }

        /// <summary>
        /// Processing Email
        /// </summary>
        /// <value>Processing Email</value>
        [DataMember(Name = "ProcessingEmail", EmitDefaultValue = false)]
        public string ProcessingEmail { get; set; }

        /// <summary>
        /// Fax Number
        /// </summary>
        /// <value>Fax Number</value>
        [DataMember(Name = "FaxNumber", EmitDefaultValue = false)]
        public string FaxNumber { get; set; }

        /// <summary>
        /// Suite Floor
        /// </summary>
        /// <value>Suite Floor</value>
        [DataMember(Name = "SuiteFloor", EmitDefaultValue = false)]
        public string SuiteFloor { get; set; }

        /// <summary>
        /// Mail Info
        /// </summary>
        /// <value>Mail Info</value>
        [DataMember(Name = "MailInfo", EmitDefaultValue = false)]
        public string MailInfo { get; set; }

        /// <summary>
        /// Image File
        /// </summary>
        /// <value>Image File</value>
        [DataMember(Name = "ImageFile", EmitDefaultValue = false)]
        public string ImageFile { get; set; }

        /// <summary>
        /// Return Mail
        /// </summary>
        /// <value>Return Mail</value>
        [DataMember(Name = "ReturnMail", EmitDefaultValue = false)]
        public string ReturnMail { get; set; }

        /// <summary>
        /// Mail Frequency
        /// </summary>
        /// <value>Mail Frequency</value>
        [DataMember(Name = "MailFrequency", EmitDefaultValue = false)]
        public int MailFrequency { get; set; }

        /// <summary>
        /// Form Id
        /// </summary>
        /// <value>Form Id</value>
        [DataMember(Name = "FormId", EmitDefaultValue = false)]
        public int FormId { get; set; }

        /// <summary>
        /// Pager
        /// </summary>
        /// <value>Pager</value>
        [DataMember(Name = "Pager", EmitDefaultValue = false)]
        public string Pager { get; set; }

        /// <summary>
        /// NightRequest
        /// </summary>
        /// <value>NightRequest</value>
        [DataMember(Name = "NightRequest", EmitDefaultValue = false)]
        public int NightRequest { get; set; }

        /// <summary>
        /// Short Format Email
        /// </summary>
        /// <value>Short Format Email</value>
        [DataMember(Name = "ShortFormatEmail", EmitDefaultValue = false)]
        public string ShortFormatEmail { get; set; }

        /// <summary>
        /// Last Training Date
        /// </summary>
        /// <value>Last Training Date</value>
        [DataMember(Name = "LastTrainingDate", EmitDefaultValue = false)]
        public DateTime LastTrainingDate { get; set; }

        /// <summary>
        /// Last Training Date as a string
        /// </summary>
        /// <value>Last Training Date as a string</value>
        [DataMember(Name = "LastTrainingDateStr", EmitDefaultValue = false)]
        public string LastTrainingDateStr { get; set; }

        /// <summary>
        /// Is Internal
        /// </summary>
        /// <value>Is Internal</value>
        [DataMember(Name = "IsInternal", EmitDefaultValue = true)]
        public bool IsInternal { get; set; }

        /// <summary>
        /// Is OnOffShoreFeature Enabled
        /// </summary>
        /// <value>Is OnOffShoreFeature Enabled</value>
        [DataMember(Name = "IsOnOffShoreFeatureEnabled", EmitDefaultValue = true)]
        public bool IsOnOffShoreFeatureEnabled { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        /// <value>Id</value>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// DoNotDispatch enabled?
        /// </summary>
        /// <value>DoNotDispatch enabled?</value>
        [DataMember(Name = "DoNotDispatch", EmitDefaultValue = true)]
        public bool DoNotDispatch { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingProvidersExtendedReviewedProvider {\n");
            sb.Append("  ReviewsInfo: ").Append(ReviewsInfo).Append("\n");
            sb.Append("  MyProviderReview: ").Append(MyProviderReview).Append("\n");
            sb.Append("  AnyMyReviews: ").Append(AnyMyReviews).Append("\n");
            sb.Append("  Trades: ").Append(Trades).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  MainContact: ").Append(MainContact).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  LastUserDate: ").Append(LastUserDate).Append("\n");
            sb.Append("  SuperUser: ").Append(SuperUser).Append("\n");
            sb.Append("  WebSite: ").Append(WebSite).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  TaxId: ").Append(TaxId).Append("\n");
            sb.Append("  Trade: ").Append(Trade).Append("\n");
            sb.Append("  ProcessingEmail: ").Append(ProcessingEmail).Append("\n");
            sb.Append("  FaxNumber: ").Append(FaxNumber).Append("\n");
            sb.Append("  SuiteFloor: ").Append(SuiteFloor).Append("\n");
            sb.Append("  MailInfo: ").Append(MailInfo).Append("\n");
            sb.Append("  ImageFile: ").Append(ImageFile).Append("\n");
            sb.Append("  ReturnMail: ").Append(ReturnMail).Append("\n");
            sb.Append("  MailFrequency: ").Append(MailFrequency).Append("\n");
            sb.Append("  FormId: ").Append(FormId).Append("\n");
            sb.Append("  Pager: ").Append(Pager).Append("\n");
            sb.Append("  NightRequest: ").Append(NightRequest).Append("\n");
            sb.Append("  ShortFormatEmail: ").Append(ShortFormatEmail).Append("\n");
            sb.Append("  LastTrainingDate: ").Append(LastTrainingDate).Append("\n");
            sb.Append("  LastTrainingDateStr: ").Append(LastTrainingDateStr).Append("\n");
            sb.Append("  IsInternal: ").Append(IsInternal).Append("\n");
            sb.Append("  IsOnOffShoreFeatureEnabled: ").Append(IsOnOffShoreFeatureEnabled).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DoNotDispatch: ").Append(DoNotDispatch).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SCServiceChannelServicesMessagingProvidersExtendedReviewedProvider);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingProvidersExtendedReviewedProvider instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingProvidersExtendedReviewedProvider to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingProvidersExtendedReviewedProvider input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ReviewsInfo == input.ReviewsInfo ||
                    (this.ReviewsInfo != null &&
                    this.ReviewsInfo.Equals(input.ReviewsInfo))
                ) && 
                (
                    this.MyProviderReview == input.MyProviderReview ||
                    (this.MyProviderReview != null &&
                    this.MyProviderReview.Equals(input.MyProviderReview))
                ) && 
                (
                    this.AnyMyReviews == input.AnyMyReviews ||
                    this.AnyMyReviews.Equals(input.AnyMyReviews)
                ) && 
                (
                    this.Trades == input.Trades ||
                    this.Trades != null &&
                    input.Trades != null &&
                    this.Trades.SequenceEqual(input.Trades)
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.FullName == input.FullName ||
                    (this.FullName != null &&
                    this.FullName.Equals(input.FullName))
                ) && 
                (
                    this.Address1 == input.Address1 ||
                    (this.Address1 != null &&
                    this.Address1.Equals(input.Address1))
                ) && 
                (
                    this.Address2 == input.Address2 ||
                    (this.Address2 != null &&
                    this.Address2.Equals(input.Address2))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Zip == input.Zip ||
                    (this.Zip != null &&
                    this.Zip.Equals(input.Zip))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.MainContact == input.MainContact ||
                    (this.MainContact != null &&
                    this.MainContact.Equals(input.MainContact))
                ) && 
                (
                    this.DateCreated == input.DateCreated ||
                    (this.DateCreated != null &&
                    this.DateCreated.Equals(input.DateCreated))
                ) && 
                (
                    this.LastUserDate == input.LastUserDate ||
                    (this.LastUserDate != null &&
                    this.LastUserDate.Equals(input.LastUserDate))
                ) && 
                (
                    this.SuperUser == input.SuperUser ||
                    (this.SuperUser != null &&
                    this.SuperUser.Equals(input.SuperUser))
                ) && 
                (
                    this.WebSite == input.WebSite ||
                    (this.WebSite != null &&
                    this.WebSite.Equals(input.WebSite))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.TaxId == input.TaxId ||
                    (this.TaxId != null &&
                    this.TaxId.Equals(input.TaxId))
                ) && 
                (
                    this.Trade == input.Trade ||
                    (this.Trade != null &&
                    this.Trade.Equals(input.Trade))
                ) && 
                (
                    this.ProcessingEmail == input.ProcessingEmail ||
                    (this.ProcessingEmail != null &&
                    this.ProcessingEmail.Equals(input.ProcessingEmail))
                ) && 
                (
                    this.FaxNumber == input.FaxNumber ||
                    (this.FaxNumber != null &&
                    this.FaxNumber.Equals(input.FaxNumber))
                ) && 
                (
                    this.SuiteFloor == input.SuiteFloor ||
                    (this.SuiteFloor != null &&
                    this.SuiteFloor.Equals(input.SuiteFloor))
                ) && 
                (
                    this.MailInfo == input.MailInfo ||
                    (this.MailInfo != null &&
                    this.MailInfo.Equals(input.MailInfo))
                ) && 
                (
                    this.ImageFile == input.ImageFile ||
                    (this.ImageFile != null &&
                    this.ImageFile.Equals(input.ImageFile))
                ) && 
                (
                    this.ReturnMail == input.ReturnMail ||
                    (this.ReturnMail != null &&
                    this.ReturnMail.Equals(input.ReturnMail))
                ) && 
                (
                    this.MailFrequency == input.MailFrequency ||
                    this.MailFrequency.Equals(input.MailFrequency)
                ) && 
                (
                    this.FormId == input.FormId ||
                    this.FormId.Equals(input.FormId)
                ) && 
                (
                    this.Pager == input.Pager ||
                    (this.Pager != null &&
                    this.Pager.Equals(input.Pager))
                ) && 
                (
                    this.NightRequest == input.NightRequest ||
                    this.NightRequest.Equals(input.NightRequest)
                ) && 
                (
                    this.ShortFormatEmail == input.ShortFormatEmail ||
                    (this.ShortFormatEmail != null &&
                    this.ShortFormatEmail.Equals(input.ShortFormatEmail))
                ) && 
                (
                    this.LastTrainingDate == input.LastTrainingDate ||
                    (this.LastTrainingDate != null &&
                    this.LastTrainingDate.Equals(input.LastTrainingDate))
                ) && 
                (
                    this.LastTrainingDateStr == input.LastTrainingDateStr ||
                    (this.LastTrainingDateStr != null &&
                    this.LastTrainingDateStr.Equals(input.LastTrainingDateStr))
                ) && 
                (
                    this.IsInternal == input.IsInternal ||
                    this.IsInternal.Equals(input.IsInternal)
                ) && 
                (
                    this.IsOnOffShoreFeatureEnabled == input.IsOnOffShoreFeatureEnabled ||
                    this.IsOnOffShoreFeatureEnabled.Equals(input.IsOnOffShoreFeatureEnabled)
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DoNotDispatch == input.DoNotDispatch ||
                    this.DoNotDispatch.Equals(input.DoNotDispatch)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ReviewsInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ReviewsInfo.GetHashCode();
                }
                if (this.MyProviderReview != null)
                {
                    hashCode = (hashCode * 59) + this.MyProviderReview.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AnyMyReviews.GetHashCode();
                if (this.Trades != null)
                {
                    hashCode = (hashCode * 59) + this.Trades.GetHashCode();
                }
                if (this.Phone != null)
                {
                    hashCode = (hashCode * 59) + this.Phone.GetHashCode();
                }
                if (this.FullName != null)
                {
                    hashCode = (hashCode * 59) + this.FullName.GetHashCode();
                }
                if (this.Address1 != null)
                {
                    hashCode = (hashCode * 59) + this.Address1.GetHashCode();
                }
                if (this.Address2 != null)
                {
                    hashCode = (hashCode * 59) + this.Address2.GetHashCode();
                }
                if (this.City != null)
                {
                    hashCode = (hashCode * 59) + this.City.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                if (this.Zip != null)
                {
                    hashCode = (hashCode * 59) + this.Zip.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.MainContact != null)
                {
                    hashCode = (hashCode * 59) + this.MainContact.GetHashCode();
                }
                if (this.DateCreated != null)
                {
                    hashCode = (hashCode * 59) + this.DateCreated.GetHashCode();
                }
                if (this.LastUserDate != null)
                {
                    hashCode = (hashCode * 59) + this.LastUserDate.GetHashCode();
                }
                if (this.SuperUser != null)
                {
                    hashCode = (hashCode * 59) + this.SuperUser.GetHashCode();
                }
                if (this.WebSite != null)
                {
                    hashCode = (hashCode * 59) + this.WebSite.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.TaxId != null)
                {
                    hashCode = (hashCode * 59) + this.TaxId.GetHashCode();
                }
                if (this.Trade != null)
                {
                    hashCode = (hashCode * 59) + this.Trade.GetHashCode();
                }
                if (this.ProcessingEmail != null)
                {
                    hashCode = (hashCode * 59) + this.ProcessingEmail.GetHashCode();
                }
                if (this.FaxNumber != null)
                {
                    hashCode = (hashCode * 59) + this.FaxNumber.GetHashCode();
                }
                if (this.SuiteFloor != null)
                {
                    hashCode = (hashCode * 59) + this.SuiteFloor.GetHashCode();
                }
                if (this.MailInfo != null)
                {
                    hashCode = (hashCode * 59) + this.MailInfo.GetHashCode();
                }
                if (this.ImageFile != null)
                {
                    hashCode = (hashCode * 59) + this.ImageFile.GetHashCode();
                }
                if (this.ReturnMail != null)
                {
                    hashCode = (hashCode * 59) + this.ReturnMail.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MailFrequency.GetHashCode();
                hashCode = (hashCode * 59) + this.FormId.GetHashCode();
                if (this.Pager != null)
                {
                    hashCode = (hashCode * 59) + this.Pager.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.NightRequest.GetHashCode();
                if (this.ShortFormatEmail != null)
                {
                    hashCode = (hashCode * 59) + this.ShortFormatEmail.GetHashCode();
                }
                if (this.LastTrainingDate != null)
                {
                    hashCode = (hashCode * 59) + this.LastTrainingDate.GetHashCode();
                }
                if (this.LastTrainingDateStr != null)
                {
                    hashCode = (hashCode * 59) + this.LastTrainingDateStr.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsInternal.GetHashCode();
                hashCode = (hashCode * 59) + this.IsOnOffShoreFeatureEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DoNotDispatch.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
