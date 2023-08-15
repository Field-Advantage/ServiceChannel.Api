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
    /// Checklist question details.
    /// </summary>
    [DataContract]
    public class SCServiceChannelServicesMessagingCheckListDetailsCheckListDetailQuestionsExtendedResponse : IEquatable<SCServiceChannelServicesMessagingCheckListDetailsCheckListDetailQuestionsExtendedResponse>
    {
        /// <summary>
        /// Date and time when the checklist was created.
        /// </summary>
        /// <value>Date and time when the checklist was created.</value>
        [DataMember(Name="CheckListCreatedDate", EmitDefaultValue=false)]
        public DateTime CheckListCreatedDate { get; set; }

        /// <summary>
        /// Name of the checklist the question belongs to.
        /// </summary>
        /// <value>Name of the checklist the question belongs to.</value>
        [DataMember(Name="CheckListName", EmitDefaultValue=false)]
        public string CheckListName { get; set; }

        /// <summary>
        /// Checklist question ID.
        /// </summary>
        /// <value>Checklist question ID.</value>
        [DataMember(Name="Id", EmitDefaultValue=true)]
        public int Id { get; set; }

        /// <summary>
        /// ID of the checklist the question belongs to.
        /// </summary>
        /// <value>ID of the checklist the question belongs to.</value>
        [DataMember(Name="CheckListId", EmitDefaultValue=true)]
        public int CheckListId { get; set; }

        /// <summary>
        /// Checklist question that a technician is prompted to answer when working on a service request.
        /// </summary>
        /// <value>Checklist question that a technician is prompted to answer when working on a service request.</value>
        [DataMember(Name="Question", EmitDefaultValue=false)]
        public string Question { get; set; }

        /// <summary>
        /// Not applicable to checklists.
        /// </summary>
        /// <value>Not applicable to checklists.</value>
        [DataMember(Name="ShortDescription", EmitDefaultValue=false)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Defines whether answering this checklist question is mandatory.
        /// </summary>
        /// <value>Defines whether answering this checklist question is mandatory.</value>
        [DataMember(Name="AnswerRequired", EmitDefaultValue=true)]
        public bool AnswerRequired { get; set; } = false;


        /// <summary>
        /// Defines whether a technician is required to upload an attachment when answering the question:               • 0 — Adding an attachment is optional.               • 1 — An attachment is not required.               • 2 — Uploading an attachment is mandatory.
        /// </summary>
        /// <value>Defines whether a technician is required to upload an attachment when answering the question:               • 0 — Adding an attachment is optional.               • 1 — An attachment is not required.               • 2 — Uploading an attachment is mandatory.</value>
        
        public enum PictureFlagEnum
        {
            
            /// <summary>
            /// Enum OptionalEnum for Optional
            /// </summary>
            [EnumMember(Value = "Optional")]
            OptionalEnum = 1,
            
            /// <summary>
            /// Enum NoEnum for No
            /// </summary>
            [EnumMember(Value = "No")]
            NoEnum = 2,
            
            /// <summary>
            /// Enum RequiredEnum for Required
            /// </summary>
            [EnumMember(Value = "Required")]
            RequiredEnum = 3
        }

        /// <summary>
        /// Defines whether a technician is required to upload an attachment when answering the question:               • 0 — Adding an attachment is optional.               • 1 — An attachment is not required.               • 2 — Uploading an attachment is mandatory.
        /// </summary>
        /// <value>Defines whether a technician is required to upload an attachment when answering the question:               • 0 — Adding an attachment is optional.               • 1 — An attachment is not required.               • 2 — Uploading an attachment is mandatory.</value>
        [DataMember(Name="PictureFlag", EmitDefaultValue=true)]
        public PictureFlagEnum PictureFlag { get; set; }

        /// <summary>
        /// Not applicable to checklists.
        /// </summary>
        /// <value>Not applicable to checklists.</value>
        [DataMember(Name="Sequence", EmitDefaultValue=true)]
        public int Sequence { get; set; }


        /// <summary>
        /// [Checklist question type](https://developer.servicechannel.com/guides/checklists/types-of-checklist-questions/):               • 0 — **Acknowledgement**: Represents an on/off toggle prompting a technician to give a positive or negative response to a question.               • 1 — **Selector**: Provides multiple configured answer options to choose from.               • 2 — **Text Entry**: Allows entering a text answer.               • 4 — **Numeric Input**: Prompts to submit a number as a response.
        /// </summary>
        /// <value>[Checklist question type](https://developer.servicechannel.com/guides/checklists/types-of-checklist-questions/):               • 0 — **Acknowledgement**: Represents an on/off toggle prompting a technician to give a positive or negative response to a question.               • 1 — **Selector**: Provides multiple configured answer options to choose from.               • 2 — **Text Entry**: Allows entering a text answer.               • 4 — **Numeric Input**: Prompts to submit a number as a response.</value>
        
        public enum QuestionTypeEnum
        {
            
            /// <summary>
            /// Enum CheckBoxEnum for CheckBox
            /// </summary>
            [EnumMember(Value = "CheckBox")]
            CheckBoxEnum = 1,
            
            /// <summary>
            /// Enum RadioButtonEnum for RadioButton
            /// </summary>
            [EnumMember(Value = "RadioButton")]
            RadioButtonEnum = 2,
            
            /// <summary>
            /// Enum TextEntryEnum for TextEntry
            /// </summary>
            [EnumMember(Value = "TextEntry")]
            TextEntryEnum = 3,
            
            /// <summary>
            /// Enum TriStateEnum for TriState
            /// </summary>
            [EnumMember(Value = "TriState")]
            TriStateEnum = 4,
            
            /// <summary>
            /// Enum NumericInputEnum for NumericInput
            /// </summary>
            [EnumMember(Value = "NumericInput")]
            NumericInputEnum = 5
        }

        /// <summary>
        /// [Checklist question type](https://developer.servicechannel.com/guides/checklists/types-of-checklist-questions/):               • 0 — **Acknowledgement**: Represents an on/off toggle prompting a technician to give a positive or negative response to a question.               • 1 — **Selector**: Provides multiple configured answer options to choose from.               • 2 — **Text Entry**: Allows entering a text answer.               • 4 — **Numeric Input**: Prompts to submit a number as a response.
        /// </summary>
        /// <value>[Checklist question type](https://developer.servicechannel.com/guides/checklists/types-of-checklist-questions/):               • 0 — **Acknowledgement**: Represents an on/off toggle prompting a technician to give a positive or negative response to a question.               • 1 — **Selector**: Provides multiple configured answer options to choose from.               • 2 — **Text Entry**: Allows entering a text answer.               • 4 — **Numeric Input**: Prompts to submit a number as a response.</value>
        [DataMember(Name="QuestionType", EmitDefaultValue=true)]
        public QuestionTypeEnum QuestionType { get; set; }

        /// <summary>
        /// Answer options for questions of the Selector type.
        /// </summary>
        /// <value>Answer options for questions of the Selector type.</value>
        [DataMember(Name="CheckListQuestionOptions", EmitDefaultValue=false)]
        public List<SCServiceChannelServicesMessagingCheckListDetailsCheckListQuestionOptionResponse> CheckListQuestionOptions { get; set; }

        /// <summary>
        /// Defines whether the answer to this question can persist. If the answer is persistent, the last submitted response populates on the question. A technician can either opt for the current response or update it.
        /// </summary>
        /// <value>Defines whether the answer to this question can persist. If the answer is persistent, the last submitted response populates on the question. A technician can either opt for the current response or update it.</value>
        [DataMember(Name="AnswerCanPersist", EmitDefaultValue=true)]
        public bool AnswerCanPersist { get; set; } = false;


        /// <summary>
        /// Defines the checklist segment the question belongs to: 1 — check-in segment, 2 — check-out segment.
        /// </summary>
        /// <value>Defines the checklist segment the question belongs to: 1 — check-in segment, 2 — check-out segment.</value>
        
        public enum CheckListTimingTypeEnum
        {
            
            /// <summary>
            /// Enum CheckInEnum for CheckIn
            /// </summary>
            [EnumMember(Value = "CheckIn")]
            CheckInEnum = 1,
            
            /// <summary>
            /// Enum CheckOutEnum for CheckOut
            /// </summary>
            [EnumMember(Value = "CheckOut")]
            CheckOutEnum = 2
        }

        /// <summary>
        /// Defines the checklist segment the question belongs to: 1 — check-in segment, 2 — check-out segment.
        /// </summary>
        /// <value>Defines the checklist segment the question belongs to: 1 — check-in segment, 2 — check-out segment.</value>
        [DataMember(Name="CheckListTimingType", EmitDefaultValue=true)]
        public CheckListTimingTypeEnum CheckListTimingType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingCheckListDetailsCheckListDetailQuestionsExtendedResponse {\n");
            sb.Append("  CheckListCreatedDate: ").Append(CheckListCreatedDate).Append("\n");
            sb.Append("  CheckListName: ").Append(CheckListName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CheckListId: ").Append(CheckListId).Append("\n");
            sb.Append("  Question: ").Append(Question).Append("\n");
            sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
            sb.Append("  AnswerRequired: ").Append(AnswerRequired).Append("\n");
            sb.Append("  PictureFlag: ").Append(PictureFlag).Append("\n");
            sb.Append("  Sequence: ").Append(Sequence).Append("\n");
            sb.Append("  QuestionType: ").Append(QuestionType).Append("\n");
            sb.Append("  CheckListQuestionOptions: ").Append(CheckListQuestionOptions).Append("\n");
            sb.Append("  AnswerCanPersist: ").Append(AnswerCanPersist).Append("\n");
            sb.Append("  CheckListTimingType: ").Append(CheckListTimingType).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingCheckListDetailsCheckListDetailQuestionsExtendedResponse)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingCheckListDetailsCheckListDetailQuestionsExtendedResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingCheckListDetailsCheckListDetailQuestionsExtendedResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingCheckListDetailsCheckListDetailQuestionsExtendedResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CheckListCreatedDate == other.CheckListCreatedDate ||
                    CheckListCreatedDate != null &&
                    CheckListCreatedDate.Equals(other.CheckListCreatedDate)
                ) && 
                (
                    CheckListName == other.CheckListName ||
                    CheckListName != null &&
                    CheckListName.Equals(other.CheckListName)
                ) && 
                (
                    Id == other.Id ||
                    
                    Id.Equals(other.Id)
                ) && 
                (
                    CheckListId == other.CheckListId ||
                    
                    CheckListId.Equals(other.CheckListId)
                ) && 
                (
                    Question == other.Question ||
                    Question != null &&
                    Question.Equals(other.Question)
                ) && 
                (
                    ShortDescription == other.ShortDescription ||
                    ShortDescription != null &&
                    ShortDescription.Equals(other.ShortDescription)
                ) && 
                (
                    AnswerRequired == other.AnswerRequired ||
                    
                    AnswerRequired.Equals(other.AnswerRequired)
                ) && 
                (
                    PictureFlag == other.PictureFlag ||
                    
                    PictureFlag.Equals(other.PictureFlag)
                ) && 
                (
                    Sequence == other.Sequence ||
                    
                    Sequence.Equals(other.Sequence)
                ) && 
                (
                    QuestionType == other.QuestionType ||
                    
                    QuestionType.Equals(other.QuestionType)
                ) && 
                (
                    CheckListQuestionOptions == other.CheckListQuestionOptions ||
                    CheckListQuestionOptions != null &&
                    other.CheckListQuestionOptions != null &&
                    CheckListQuestionOptions.SequenceEqual(other.CheckListQuestionOptions)
                ) && 
                (
                    AnswerCanPersist == other.AnswerCanPersist ||
                    
                    AnswerCanPersist.Equals(other.AnswerCanPersist)
                ) && 
                (
                    CheckListTimingType == other.CheckListTimingType ||
                    
                    CheckListTimingType.Equals(other.CheckListTimingType)
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
                    if (CheckListCreatedDate != null)
                    hashCode = hashCode * 59 + CheckListCreatedDate.GetHashCode();
                    if (CheckListName != null)
                    hashCode = hashCode * 59 + CheckListName.GetHashCode();
                    
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    
                    hashCode = hashCode * 59 + CheckListId.GetHashCode();
                    if (Question != null)
                    hashCode = hashCode * 59 + Question.GetHashCode();
                    if (ShortDescription != null)
                    hashCode = hashCode * 59 + ShortDescription.GetHashCode();
                    
                    hashCode = hashCode * 59 + AnswerRequired.GetHashCode();
                    
                    hashCode = hashCode * 59 + PictureFlag.GetHashCode();
                    
                    hashCode = hashCode * 59 + Sequence.GetHashCode();
                    
                    hashCode = hashCode * 59 + QuestionType.GetHashCode();
                    if (CheckListQuestionOptions != null)
                    hashCode = hashCode * 59 + CheckListQuestionOptions.GetHashCode();
                    
                    hashCode = hashCode * 59 + AnswerCanPersist.GetHashCode();
                    
                    hashCode = hashCode * 59 + CheckListTimingType.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingCheckListDetailsCheckListDetailQuestionsExtendedResponse left, SCServiceChannelServicesMessagingCheckListDetailsCheckListDetailQuestionsExtendedResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingCheckListDetailsCheckListDetailQuestionsExtendedResponse left, SCServiceChannelServicesMessagingCheckListDetailsCheckListDetailQuestionsExtendedResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}