/*
 * ServiceChannel API - v.3
 *
 * The ServiceChannel API is a RESTful and stateless API. It accepts standard HTTP verbs and supports OAuth 2.0 for authorizing requests.      Our API returns common HTTP status codes as well as JSON encapsulated data.      See [API Overview](https://developer.servicechannel.com/basics/introduction/overview/) for the intro to ServiceChannel API.<br>      <h3>Authentication and Authorization</h3>You should have a ServiceChannel account, register your application, and obtain `access_token` to integrate with our API.      See [Authentication and Authorization](https://developer.servicechannel.com/basics/general/authentication/) for more information.      To use this API playground, click **Authorize** and sign in to ServiceChannel.<br>      <h3>Environment</h3> All calls in this API Reference point to the **SB2 environment**.      See [Environments](https://developer.servicechannel.com/basics/general/environments/) for more information.<br>      <h3>API Version</h3>The current stable version of the ServiceChannel API is `v3`. In the request URL, `v3` is a version prefix that should be present.      When you omit the version prefix, calls point to the minimum supported version of the API.      We recommend you to always specify the API version to avoid possible errors.
 *
 * The version of the OpenAPI document: 3
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json;
using ServiceChannel.OpenAPIGenerated.Api.Converters;

namespace ServiceChannel.OpenAPIGenerated.Api.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class SCServiceChannelApiModelDashboardSettingsSetupGeneral : IEquatable<SCServiceChannelApiModelDashboardSettingsSetupGeneral>
    {
        /// <summary>
        /// Gets or Sets SetupId
        /// </summary>
        [DataMember(Name="SetupId", EmitDefaultValue=true)]
        public int SetupId { get; set; }

        /// <summary>
        /// Gets or Sets SubscriberId
        /// </summary>
        [DataMember(Name="SubscriberId", EmitDefaultValue=true)]
        public int SubscriberId { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyId
        /// </summary>
        [DataMember(Name="CurrencyId", EmitDefaultValue=true)]
        public int CurrencyId { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="Title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Theme
        /// </summary>
        [DataMember(Name="Theme", EmitDefaultValue=false)]
        public string Theme { get; set; }

        /// <summary>
        /// Gets or Sets NavigationMap
        /// </summary>
        [DataMember(Name="NavigationMap", EmitDefaultValue=false)]
        public string NavigationMap { get; set; }

        /// <summary>
        /// Gets or Sets IssueList
        /// </summary>
        [DataMember(Name="IssueList", EmitDefaultValue=false)]
        public string IssueList { get; set; }

        /// <summary>
        /// Gets or Sets FavIcon
        /// </summary>
        [DataMember(Name="FavIcon", EmitDefaultValue=false)]
        public string FavIcon { get; set; }

        /// <summary>
        /// Gets or Sets Culture
        /// </summary>
        [DataMember(Name="Culture", EmitDefaultValue=false)]
        public string Culture { get; set; }

        /// <summary>
        /// Gets or Sets SecondCulture
        /// </summary>
        [DataMember(Name="SecondCulture", EmitDefaultValue=false)]
        public string SecondCulture { get; set; }

        /// <summary>
        /// Gets or Sets DefaultUri
        /// </summary>
        [DataMember(Name="DefaultUri", EmitDefaultValue=false)]
        public string DefaultUri { get; set; }

        /// <summary>
        /// Gets or Sets RedirectUri
        /// </summary>
        [DataMember(Name="RedirectUri", EmitDefaultValue=false)]
        public string RedirectUri { get; set; }

        /// <summary>
        /// Gets or Sets AllowAddingAttachments
        /// </summary>
        [DataMember(Name="AllowAddingAttachments", EmitDefaultValue=true)]
        public bool AllowAddingAttachments { get; set; } = false;

        /// <summary>
        /// Gets or Sets RequireAttachments
        /// </summary>
        [DataMember(Name="RequireAttachments", EmitDefaultValue=true)]
        public bool RequireAttachments { get; set; } = false;

        /// <summary>
        /// Gets or Sets UseObjectIssueList
        /// </summary>
        [DataMember(Name="UseObjectIssueList", EmitDefaultValue=true)]
        public bool UseObjectIssueList { get; set; } = false;

        /// <summary>
        /// Gets or Sets ShowOtherCategories
        /// </summary>
        [DataMember(Name="ShowOtherCategories", EmitDefaultValue=true)]
        public bool ShowOtherCategories { get; set; } = false;

        /// <summary>
        /// Gets or Sets HideDashboardSelection
        /// </summary>
        [DataMember(Name="HideDashboardSelection", EmitDefaultValue=true)]
        public bool HideDashboardSelection { get; set; } = false;

        /// <summary>
        /// Gets or Sets HideLateToArrive
        /// </summary>
        [DataMember(Name="HideLateToArrive", EmitDefaultValue=true)]
        public bool HideLateToArrive { get; set; } = false;

        /// <summary>
        /// Gets or Sets DashboardDescription
        /// </summary>
        [DataMember(Name="DashboardDescription", EmitDefaultValue=false)]
        public string DashboardDescription { get; set; }

        /// <summary>
        /// Gets or Sets SpacesWoPlacementConfirmation
        /// </summary>
        [DataMember(Name="SpacesWoPlacementConfirmation", EmitDefaultValue=true)]
        public bool SpacesWoPlacementConfirmation { get; set; } = false;

        /// <summary>
        /// Gets or Sets DateFormat
        /// </summary>
        [DataMember(Name="DateFormat", EmitDefaultValue=false)]
        public string DateFormat { get; set; }

        /// <summary>
        /// Gets or Sets TimeFormat
        /// </summary>
        [DataMember(Name="TimeFormat", EmitDefaultValue=false)]
        public string TimeFormat { get; set; }

        /// <summary>
        /// Gets or Sets DecimalSeparator
        /// </summary>
        [DataMember(Name="DecimalSeparator", EmitDefaultValue=false)]
        public string DecimalSeparator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelApiModelDashboardSettingsSetupGeneral {\n");
            sb.Append("  SetupId: ").Append(SetupId).Append("\n");
            sb.Append("  SubscriberId: ").Append(SubscriberId).Append("\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Theme: ").Append(Theme).Append("\n");
            sb.Append("  NavigationMap: ").Append(NavigationMap).Append("\n");
            sb.Append("  IssueList: ").Append(IssueList).Append("\n");
            sb.Append("  FavIcon: ").Append(FavIcon).Append("\n");
            sb.Append("  Culture: ").Append(Culture).Append("\n");
            sb.Append("  SecondCulture: ").Append(SecondCulture).Append("\n");
            sb.Append("  DefaultUri: ").Append(DefaultUri).Append("\n");
            sb.Append("  RedirectUri: ").Append(RedirectUri).Append("\n");
            sb.Append("  AllowAddingAttachments: ").Append(AllowAddingAttachments).Append("\n");
            sb.Append("  RequireAttachments: ").Append(RequireAttachments).Append("\n");
            sb.Append("  UseObjectIssueList: ").Append(UseObjectIssueList).Append("\n");
            sb.Append("  ShowOtherCategories: ").Append(ShowOtherCategories).Append("\n");
            sb.Append("  HideDashboardSelection: ").Append(HideDashboardSelection).Append("\n");
            sb.Append("  HideLateToArrive: ").Append(HideLateToArrive).Append("\n");
            sb.Append("  DashboardDescription: ").Append(DashboardDescription).Append("\n");
            sb.Append("  SpacesWoPlacementConfirmation: ").Append(SpacesWoPlacementConfirmation).Append("\n");
            sb.Append("  DateFormat: ").Append(DateFormat).Append("\n");
            sb.Append("  TimeFormat: ").Append(TimeFormat).Append("\n");
            sb.Append("  DecimalSeparator: ").Append(DecimalSeparator).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            return JsonSerializer.Serialize(this, options);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((SCServiceChannelApiModelDashboardSettingsSetupGeneral)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelApiModelDashboardSettingsSetupGeneral instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelApiModelDashboardSettingsSetupGeneral to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelApiModelDashboardSettingsSetupGeneral other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    SetupId == other.SetupId ||
                    
                    SetupId.Equals(other.SetupId)
                ) && 
                (
                    SubscriberId == other.SubscriberId ||
                    
                    SubscriberId.Equals(other.SubscriberId)
                ) && 
                (
                    CurrencyId == other.CurrencyId ||
                    
                    CurrencyId.Equals(other.CurrencyId)
                ) && 
                (
                    Title == other.Title ||
                    Title != null &&
                    Title.Equals(other.Title)
                ) && 
                (
                    Theme == other.Theme ||
                    Theme != null &&
                    Theme.Equals(other.Theme)
                ) && 
                (
                    NavigationMap == other.NavigationMap ||
                    NavigationMap != null &&
                    NavigationMap.Equals(other.NavigationMap)
                ) && 
                (
                    IssueList == other.IssueList ||
                    IssueList != null &&
                    IssueList.Equals(other.IssueList)
                ) && 
                (
                    FavIcon == other.FavIcon ||
                    FavIcon != null &&
                    FavIcon.Equals(other.FavIcon)
                ) && 
                (
                    Culture == other.Culture ||
                    Culture != null &&
                    Culture.Equals(other.Culture)
                ) && 
                (
                    SecondCulture == other.SecondCulture ||
                    SecondCulture != null &&
                    SecondCulture.Equals(other.SecondCulture)
                ) && 
                (
                    DefaultUri == other.DefaultUri ||
                    DefaultUri != null &&
                    DefaultUri.Equals(other.DefaultUri)
                ) && 
                (
                    RedirectUri == other.RedirectUri ||
                    RedirectUri != null &&
                    RedirectUri.Equals(other.RedirectUri)
                ) && 
                (
                    AllowAddingAttachments == other.AllowAddingAttachments ||
                    
                    AllowAddingAttachments.Equals(other.AllowAddingAttachments)
                ) && 
                (
                    RequireAttachments == other.RequireAttachments ||
                    
                    RequireAttachments.Equals(other.RequireAttachments)
                ) && 
                (
                    UseObjectIssueList == other.UseObjectIssueList ||
                    
                    UseObjectIssueList.Equals(other.UseObjectIssueList)
                ) && 
                (
                    ShowOtherCategories == other.ShowOtherCategories ||
                    
                    ShowOtherCategories.Equals(other.ShowOtherCategories)
                ) && 
                (
                    HideDashboardSelection == other.HideDashboardSelection ||
                    
                    HideDashboardSelection.Equals(other.HideDashboardSelection)
                ) && 
                (
                    HideLateToArrive == other.HideLateToArrive ||
                    
                    HideLateToArrive.Equals(other.HideLateToArrive)
                ) && 
                (
                    DashboardDescription == other.DashboardDescription ||
                    DashboardDescription != null &&
                    DashboardDescription.Equals(other.DashboardDescription)
                ) && 
                (
                    SpacesWoPlacementConfirmation == other.SpacesWoPlacementConfirmation ||
                    
                    SpacesWoPlacementConfirmation.Equals(other.SpacesWoPlacementConfirmation)
                ) && 
                (
                    DateFormat == other.DateFormat ||
                    DateFormat != null &&
                    DateFormat.Equals(other.DateFormat)
                ) && 
                (
                    TimeFormat == other.TimeFormat ||
                    TimeFormat != null &&
                    TimeFormat.Equals(other.TimeFormat)
                ) && 
                (
                    DecimalSeparator == other.DecimalSeparator ||
                    DecimalSeparator != null &&
                    DecimalSeparator.Equals(other.DecimalSeparator)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    
                    hashCode = hashCode * 59 + SetupId.GetHashCode();
                    
                    hashCode = hashCode * 59 + SubscriberId.GetHashCode();
                    
                    hashCode = hashCode * 59 + CurrencyId.GetHashCode();
                    if (Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();
                    if (Theme != null)
                    hashCode = hashCode * 59 + Theme.GetHashCode();
                    if (NavigationMap != null)
                    hashCode = hashCode * 59 + NavigationMap.GetHashCode();
                    if (IssueList != null)
                    hashCode = hashCode * 59 + IssueList.GetHashCode();
                    if (FavIcon != null)
                    hashCode = hashCode * 59 + FavIcon.GetHashCode();
                    if (Culture != null)
                    hashCode = hashCode * 59 + Culture.GetHashCode();
                    if (SecondCulture != null)
                    hashCode = hashCode * 59 + SecondCulture.GetHashCode();
                    if (DefaultUri != null)
                    hashCode = hashCode * 59 + DefaultUri.GetHashCode();
                    if (RedirectUri != null)
                    hashCode = hashCode * 59 + RedirectUri.GetHashCode();
                    
                    hashCode = hashCode * 59 + AllowAddingAttachments.GetHashCode();
                    
                    hashCode = hashCode * 59 + RequireAttachments.GetHashCode();
                    
                    hashCode = hashCode * 59 + UseObjectIssueList.GetHashCode();
                    
                    hashCode = hashCode * 59 + ShowOtherCategories.GetHashCode();
                    
                    hashCode = hashCode * 59 + HideDashboardSelection.GetHashCode();
                    
                    hashCode = hashCode * 59 + HideLateToArrive.GetHashCode();
                    if (DashboardDescription != null)
                    hashCode = hashCode * 59 + DashboardDescription.GetHashCode();
                    
                    hashCode = hashCode * 59 + SpacesWoPlacementConfirmation.GetHashCode();
                    if (DateFormat != null)
                    hashCode = hashCode * 59 + DateFormat.GetHashCode();
                    if (TimeFormat != null)
                    hashCode = hashCode * 59 + TimeFormat.GetHashCode();
                    if (DecimalSeparator != null)
                    hashCode = hashCode * 59 + DecimalSeparator.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelApiModelDashboardSettingsSetupGeneral left, SCServiceChannelApiModelDashboardSettingsSetupGeneral right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelApiModelDashboardSettingsSetupGeneral left, SCServiceChannelApiModelDashboardSettingsSetupGeneral right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
