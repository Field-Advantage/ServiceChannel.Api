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
    public class SCServiceChannelServicesMessagingMenuItem : IEquatable<SCServiceChannelServicesMessagingMenuItem>
    {
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="Url", EmitDefaultValue=false)]
        public string Url { get; set; }


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        
        public enum IdEnum
        {
            
            /// <summary>
            /// Enum NoneEnum for None
            /// </summary>
            [EnumMember(Value = "None")]
            NoneEnum = 1,
            
            /// <summary>
            /// Enum TrackWOPOEnum for Track_WOPO
            /// </summary>
            [EnumMember(Value = "Track_WOPO")]
            TrackWOPOEnum = 2,
            
            /// <summary>
            /// Enum ConsoleEnum for Console
            /// </summary>
            [EnumMember(Value = "Console")]
            ConsoleEnum = 3,
            
            /// <summary>
            /// Enum WorkOrdersWorkOrderListEnum for WorkOrders_WorkOrderList
            /// </summary>
            [EnumMember(Value = "WorkOrders_WorkOrderList")]
            WorkOrdersWorkOrderListEnum = 4,
            
            /// <summary>
            /// Enum ProposalsEnum for Proposals
            /// </summary>
            [EnumMember(Value = "Proposals")]
            ProposalsEnum = 5,
            
            /// <summary>
            /// Enum RFPsProposalsCreateProposalEnum for RFPsProposals_CreateProposal
            /// </summary>
            [EnumMember(Value = "RFPsProposals_CreateProposal")]
            RFPsProposalsCreateProposalEnum = 6,
            
            /// <summary>
            /// Enum RFPsProposalsViewProposalsEnum for RFPsProposals_ViewProposals
            /// </summary>
            [EnumMember(Value = "RFPsProposals_ViewProposals")]
            RFPsProposalsViewProposalsEnum = 7,
            
            /// <summary>
            /// Enum RFPsProposalsViewProcessRFPEnum for RFPsProposals_ViewProcessRFP
            /// </summary>
            [EnumMember(Value = "RFPsProposals_ViewProcessRFP")]
            RFPsProposalsViewProcessRFPEnum = 8,
            
            /// <summary>
            /// Enum RFPsProposalsViewProcessBulkRFPEnum for RFPsProposals_ViewProcessBulkRFP
            /// </summary>
            [EnumMember(Value = "RFPsProposals_ViewProcessBulkRFP")]
            RFPsProposalsViewProcessBulkRFPEnum = 9,
            
            /// <summary>
            /// Enum RFPsProposalsMySavedProposalReportsEnum for RFPsProposals_MySavedProposalReports
            /// </summary>
            [EnumMember(Value = "RFPsProposals_MySavedProposalReports")]
            RFPsProposalsMySavedProposalReportsEnum = 10,
            
            /// <summary>
            /// Enum RFPsProposalsViewProcessProposalsEnum for RFPsProposals_ViewProcessProposals
            /// </summary>
            [EnumMember(Value = "RFPsProposals_ViewProcessProposals")]
            RFPsProposalsViewProcessProposalsEnum = 11,
            
            /// <summary>
            /// Enum RFPsProposalsCreateRFPEnum for RFPsProposals_CreateRFP
            /// </summary>
            [EnumMember(Value = "RFPsProposals_CreateRFP")]
            RFPsProposalsCreateRFPEnum = 12,
            
            /// <summary>
            /// Enum InvoicesEnum for Invoices
            /// </summary>
            [EnumMember(Value = "Invoices")]
            InvoicesEnum = 13,
            
            /// <summary>
            /// Enum PaymentManagerEnum for PaymentManager
            /// </summary>
            [EnumMember(Value = "PaymentManager")]
            PaymentManagerEnum = 14,
            
            /// <summary>
            /// Enum ServiceHealthEnum for ServiceHealth
            /// </summary>
            [EnumMember(Value = "ServiceHealth")]
            ServiceHealthEnum = 15,
            
            /// <summary>
            /// Enum HomeEnum for Home
            /// </summary>
            [EnumMember(Value = "Home")]
            HomeEnum = 16,
            
            /// <summary>
            /// Enum CreateServiceRequestServiceRequestDashboardEnum for CreateServiceRequest_ServiceRequestDashboard
            /// </summary>
            [EnumMember(Value = "CreateServiceRequest_ServiceRequestDashboard")]
            CreateServiceRequestServiceRequestDashboardEnum = 17,
            
            /// <summary>
            /// Enum CreateServiceRequestClassicServiceRequestEnum for CreateServiceRequest_ClassicServiceRequest
            /// </summary>
            [EnumMember(Value = "CreateServiceRequest_ClassicServiceRequest")]
            CreateServiceRequestClassicServiceRequestEnum = 18,
            
            /// <summary>
            /// Enum WorkOrdersMySavedLiveReportsEnum for WorkOrders_MySavedLiveReports
            /// </summary>
            [EnumMember(Value = "WorkOrders_MySavedLiveReports")]
            WorkOrdersMySavedLiveReportsEnum = 19,
            
            /// <summary>
            /// Enum WorkOrdersOpenCallsOnlyEnum for WorkOrders_OpenCallsOnly
            /// </summary>
            [EnumMember(Value = "WorkOrders_OpenCallsOnly")]
            WorkOrdersOpenCallsOnlyEnum = 20,
            
            /// <summary>
            /// Enum WorkOrdersInProgressCallsOnlyEnum for WorkOrders_InProgressCallsOnly
            /// </summary>
            [EnumMember(Value = "WorkOrders_InProgressCallsOnly")]
            WorkOrdersInProgressCallsOnlyEnum = 21,
            
            /// <summary>
            /// Enum WorkOrdersOpenAndInProgressEnum for WorkOrders_OpenAndInProgress
            /// </summary>
            [EnumMember(Value = "WorkOrders_OpenAndInProgress")]
            WorkOrdersOpenAndInProgressEnum = 22,
            
            /// <summary>
            /// Enum WorkOrdersOpenAndInProgressExcludingPartsOnOrderEnum for WorkOrders_OpenAndInProgressExcludingPartsOnOrder
            /// </summary>
            [EnumMember(Value = "WorkOrders_OpenAndInProgressExcludingPartsOnOrder")]
            WorkOrdersOpenAndInProgressExcludingPartsOnOrderEnum = 23,
            
            /// <summary>
            /// Enum WorkOrdersOpenAndInProgressExcludingReferredToFMEnum for WorkOrders_OpenAndInProgressExcludingReferredToFM
            /// </summary>
            [EnumMember(Value = "WorkOrders_OpenAndInProgressExcludingReferredToFM")]
            WorkOrdersOpenAndInProgressExcludingReferredToFMEnum = 24,
            
            /// <summary>
            /// Enum WorkOrdersOpenAndInProgressExcludingMaintenanceEnum for WorkOrders_OpenAndInProgressExcludingMaintenance
            /// </summary>
            [EnumMember(Value = "WorkOrders_OpenAndInProgressExcludingMaintenance")]
            WorkOrdersOpenAndInProgressExcludingMaintenanceEnum = 25,
            
            /// <summary>
            /// Enum WorkOrdersCompletedCallsOnlyEnum for WorkOrders_CompletedCallsOnly
            /// </summary>
            [EnumMember(Value = "WorkOrders_CompletedCallsOnly")]
            WorkOrdersCompletedCallsOnlyEnum = 26,
            
            /// <summary>
            /// Enum WorkOrdersInvoicedCallsOnlyEnum for WorkOrders_InvoicedCallsOnly
            /// </summary>
            [EnumMember(Value = "WorkOrders_InvoicedCallsOnly")]
            WorkOrdersInvoicedCallsOnlyEnum = 27,
            
            /// <summary>
            /// Enum WorkOrdersAllCallsEnum for WorkOrders_AllCalls
            /// </summary>
            [EnumMember(Value = "WorkOrders_AllCalls")]
            WorkOrdersAllCallsEnum = 28,
            
            /// <summary>
            /// Enum WorkOrdersAllCallsLongFormatEnum for WorkOrders_AllCallsLongFormat
            /// </summary>
            [EnumMember(Value = "WorkOrders_AllCallsLongFormat")]
            WorkOrdersAllCallsLongFormatEnum = 29,
            
            /// <summary>
            /// Enum WorkOrdersAllCallsUserAssignmentEnum for WorkOrders_AllCallsUserAssignment
            /// </summary>
            [EnumMember(Value = "WorkOrders_AllCallsUserAssignment")]
            WorkOrdersAllCallsUserAssignmentEnum = 30,
            
            /// <summary>
            /// Enum WorkOrdersArchiveReportsMySavedArchiveReportsEnum for WorkOrders_ArchiveReports_MySavedArchiveReports
            /// </summary>
            [EnumMember(Value = "WorkOrders_ArchiveReports_MySavedArchiveReports")]
            WorkOrdersArchiveReportsMySavedArchiveReportsEnum = 31,
            
            /// <summary>
            /// Enum WorkOrdersArchiveReportsCallHistoryEnum for WorkOrders_ArchiveReports_CallHistory
            /// </summary>
            [EnumMember(Value = "WorkOrders_ArchiveReports_CallHistory")]
            WorkOrdersArchiveReportsCallHistoryEnum = 32,
            
            /// <summary>
            /// Enum WorkOrdersArchiveReportsAccrualReportEnum for WorkOrders_ArchiveReports_AccrualReport
            /// </summary>
            [EnumMember(Value = "WorkOrders_ArchiveReports_AccrualReport")]
            WorkOrdersArchiveReportsAccrualReportEnum = 33,
            
            /// <summary>
            /// Enum WorkOrdersArchiveReportsOriginalETAMmissedEnum for WorkOrders_ArchiveReports_OriginalETAMmissed
            /// </summary>
            [EnumMember(Value = "WorkOrders_ArchiveReports_OriginalETAMmissed")]
            WorkOrdersArchiveReportsOriginalETAMmissedEnum = 34,
            
            /// <summary>
            /// Enum WorkOrdersArchiveReportsExcessiveCallsEnum for WorkOrders_ArchiveReports_ExcessiveCalls
            /// </summary>
            [EnumMember(Value = "WorkOrders_ArchiveReports_ExcessiveCalls")]
            WorkOrdersArchiveReportsExcessiveCallsEnum = 35,
            
            /// <summary>
            /// Enum WorkOrdersAuditReportsDataExtractEnum for WorkOrders_AuditReports_DataExtract
            /// </summary>
            [EnumMember(Value = "WorkOrders_AuditReports_DataExtract")]
            WorkOrdersAuditReportsDataExtractEnum = 36,
            
            /// <summary>
            /// Enum QuickViewEnum for QuickView
            /// </summary>
            [EnumMember(Value = "QuickView")]
            QuickViewEnum = 37,
            
            /// <summary>
            /// Enum LocationsAndProviderAssignmentsEnum for LocationsAndProviderAssignments
            /// </summary>
            [EnumMember(Value = "LocationsAndProviderAssignments")]
            LocationsAndProviderAssignmentsEnum = 38,
            
            /// <summary>
            /// Enum PlannedMaintenancePMServicesEnum for PlannedMaintenance_PMServices
            /// </summary>
            [EnumMember(Value = "PlannedMaintenance_PMServices")]
            PlannedMaintenancePMServicesEnum = 39,
            
            /// <summary>
            /// Enum PlannedMaintenancePMLocationsEnum for PlannedMaintenance_PMLocations
            /// </summary>
            [EnumMember(Value = "PlannedMaintenance_PMLocations")]
            PlannedMaintenancePMLocationsEnum = 40,
            
            /// <summary>
            /// Enum PlannedMaintenancePMTemplatesEnum for PlannedMaintenance_PMTemplates
            /// </summary>
            [EnumMember(Value = "PlannedMaintenance_PMTemplates")]
            PlannedMaintenancePMTemplatesEnum = 41,
            
            /// <summary>
            /// Enum SitePlanningReportsEnum for SitePlanningReports
            /// </summary>
            [EnumMember(Value = "SitePlanningReports")]
            SitePlanningReportsEnum = 42,
            
            /// <summary>
            /// Enum AssetsEquipmentAdministrationEnum for AssetsEquipment_Administration
            /// </summary>
            [EnumMember(Value = "AssetsEquipment_Administration")]
            AssetsEquipmentAdministrationEnum = 43,
            
            /// <summary>
            /// Enum AssetsEquipmentSummaryEnum for AssetsEquipment_Summary
            /// </summary>
            [EnumMember(Value = "AssetsEquipment_Summary")]
            AssetsEquipmentSummaryEnum = 44,
            
            /// <summary>
            /// Enum AssetsEquipmentManageAssetsEnum for AssetsEquipment_ManageAssets
            /// </summary>
            [EnumMember(Value = "AssetsEquipment_ManageAssets")]
            AssetsEquipmentManageAssetsEnum = 45,
            
            /// <summary>
            /// Enum AssetsEquipmentManageAssetTypesEnum for AssetsEquipment_ManageAssetTypes
            /// </summary>
            [EnumMember(Value = "AssetsEquipment_ManageAssetTypes")]
            AssetsEquipmentManageAssetTypesEnum = 46,
            
            /// <summary>
            /// Enum AssetsEquipmentRefrigerantLeakEventsEnum for AssetsEquipment_RefrigerantLeakEvents
            /// </summary>
            [EnumMember(Value = "AssetsEquipment_RefrigerantLeakEvents")]
            AssetsEquipmentRefrigerantLeakEventsEnum = 47,
            
            /// <summary>
            /// Enum AssetsEquipmentImportedAssetsEnum for AssetsEquipment_ImportedAssets
            /// </summary>
            [EnumMember(Value = "AssetsEquipment_ImportedAssets")]
            AssetsEquipmentImportedAssetsEnum = 48,
            
            /// <summary>
            /// Enum InventoryEnum for Inventory
            /// </summary>
            [EnumMember(Value = "Inventory")]
            InventoryEnum = 49,
            
            /// <summary>
            /// Enum CompliancePrivateNetworkEnum for CompliancePrivateNetwork
            /// </summary>
            [EnumMember(Value = "CompliancePrivateNetwork")]
            CompliancePrivateNetworkEnum = 50,
            
            /// <summary>
            /// Enum AdminLocationSettingsLocationNoteHeadersEnum for Admin_LocationSettings_LocationNoteHeaders
            /// </summary>
            [EnumMember(Value = "Admin_LocationSettings_LocationNoteHeaders")]
            AdminLocationSettingsLocationNoteHeadersEnum = 51,
            
            /// <summary>
            /// Enum AdminLocationSettingsBusinessHoursEnum for Admin_LocationSettings_BusinessHours
            /// </summary>
            [EnumMember(Value = "Admin_LocationSettings_BusinessHours")]
            AdminLocationSettingsBusinessHoursEnum = 52,
            
            /// <summary>
            /// Enum AdminWOPropertiesCategoriesEnum for Admin_WOProperties_Categories
            /// </summary>
            [EnumMember(Value = "Admin_WOProperties_Categories")]
            AdminWOPropertiesCategoriesEnum = 53,
            
            /// <summary>
            /// Enum AdminWOPropertiesPrioritiesEnum for Admin_WOProperties_Priorities
            /// </summary>
            [EnumMember(Value = "Admin_WOProperties_Priorities")]
            AdminWOPropertiesPrioritiesEnum = 54,
            
            /// <summary>
            /// Enum AdminWOPropertiesStatusesEnum for Admin_WOProperties_Statuses
            /// </summary>
            [EnumMember(Value = "Admin_WOProperties_Statuses")]
            AdminWOPropertiesStatusesEnum = 55,
            
            /// <summary>
            /// Enum AdminWOPropertiesTradesNTEsEnum for Admin_WOProperties_TradesNTEs
            /// </summary>
            [EnumMember(Value = "Admin_WOProperties_TradesNTEs")]
            AdminWOPropertiesTradesNTEsEnum = 56,
            
            /// <summary>
            /// Enum AdminAccountingAdditionalApprovalCodesEnum for Admin_Accounting_AdditionalApprovalCodes
            /// </summary>
            [EnumMember(Value = "Admin_Accounting_AdditionalApprovalCodes")]
            AdminAccountingAdditionalApprovalCodesEnum = 57,
            
            /// <summary>
            /// Enum AdminAccountingGLCodesEnum for Admin_Accounting_GLCodes
            /// </summary>
            [EnumMember(Value = "Admin_Accounting_GLCodes")]
            AdminAccountingGLCodesEnum = 58,
            
            /// <summary>
            /// Enum AdminAccountingImportGLCodeTemplateEnum for Admin_Accounting_ImportGLCodeTemplate
            /// </summary>
            [EnumMember(Value = "Admin_Accounting_ImportGLCodeTemplate")]
            AdminAccountingImportGLCodeTemplateEnum = 59,
            
            /// <summary>
            /// Enum AdminInvoicesGeneralEnum for Admin_Invoices_General
            /// </summary>
            [EnumMember(Value = "Admin_Invoices_General")]
            AdminInvoicesGeneralEnum = 60,
            
            /// <summary>
            /// Enum AdminInvoicesMLIConfigurationEnum for Admin_Invoices_MLIConfiguration
            /// </summary>
            [EnumMember(Value = "Admin_Invoices_MLIConfiguration")]
            AdminInvoicesMLIConfigurationEnum = 61,
            
            /// <summary>
            /// Enum AdminInvoicesAutoApprovalEnum for Admin_Invoices_AutoApproval
            /// </summary>
            [EnumMember(Value = "Admin_Invoices_AutoApproval")]
            AdminInvoicesAutoApprovalEnum = 62,
            
            /// <summary>
            /// Enum AdminProposalsMLPConfigurationEnum for Admin_Proposals_MLPConfiguration
            /// </summary>
            [EnumMember(Value = "Admin_Proposals_MLPConfiguration")]
            AdminProposalsMLPConfigurationEnum = 63,
            
            /// <summary>
            /// Enum AdminProposalsAutoApprovalEnum for Admin_Proposals_AutoApproval
            /// </summary>
            [EnumMember(Value = "Admin_Proposals_AutoApproval")]
            AdminProposalsAutoApprovalEnum = 64,
            
            /// <summary>
            /// Enum AdminProposalsGeneralEnum for Admin_Proposals_General
            /// </summary>
            [EnumMember(Value = "Admin_Proposals_General")]
            AdminProposalsGeneralEnum = 65,
            
            /// <summary>
            /// Enum AdminProposalsProposalApproveReasonsEnum for Admin_Proposals_ProposalApproveReasons
            /// </summary>
            [EnumMember(Value = "Admin_Proposals_ProposalApproveReasons")]
            AdminProposalsProposalApproveReasonsEnum = 66,
            
            /// <summary>
            /// Enum AdminProposalsProposalAssignReasonsEnum for Admin_Proposals_ProposalAssignReasons
            /// </summary>
            [EnumMember(Value = "Admin_Proposals_ProposalAssignReasons")]
            AdminProposalsProposalAssignReasonsEnum = 67,
            
            /// <summary>
            /// Enum AdminPermissionsUsersEnum for Admin_Permissions_Users
            /// </summary>
            [EnumMember(Value = "Admin_Permissions_Users")]
            AdminPermissionsUsersEnum = 68,
            
            /// <summary>
            /// Enum AdminPermissionsMobileEnum for Admin_Permissions_Mobile
            /// </summary>
            [EnumMember(Value = "Admin_Permissions_Mobile")]
            AdminPermissionsMobileEnum = 69,
            
            /// <summary>
            /// Enum AdminPermissionsSecurityEnum for Admin_Permissions_Security
            /// </summary>
            [EnumMember(Value = "Admin_Permissions_Security")]
            AdminPermissionsSecurityEnum = 70,
            
            /// <summary>
            /// Enum AdminPermissionsImpersonateUserEnum for Admin_Permissions_ImpersonateUser
            /// </summary>
            [EnumMember(Value = "Admin_Permissions_ImpersonateUser")]
            AdminPermissionsImpersonateUserEnum = 71,
            
            /// <summary>
            /// Enum AdminPermissionsAPIIntegrationEnum for Admin_Permissions_APIIntegration
            /// </summary>
            [EnumMember(Value = "Admin_Permissions_APIIntegration")]
            AdminPermissionsAPIIntegrationEnum = 72,
            
            /// <summary>
            /// Enum AdminPermissionsWebhooksEnum for Admin_Permissions_Webhooks
            /// </summary>
            [EnumMember(Value = "Admin_Permissions_Webhooks")]
            AdminPermissionsWebhooksEnum = 73,
            
            /// <summary>
            /// Enum AdminPermissionsNotificationsEnum for Admin_Permissions_Notifications
            /// </summary>
            [EnumMember(Value = "Admin_Permissions_Notifications")]
            AdminPermissionsNotificationsEnum = 74,
            
            /// <summary>
            /// Enum AdminSiteAccessRulesEnum for Admin_SiteAccessRules
            /// </summary>
            [EnumMember(Value = "Admin_SiteAccessRules")]
            AdminSiteAccessRulesEnum = 75,
            
            /// <summary>
            /// Enum AdminSitePlanningSetupEnum for Admin_SitePlanningSetup
            /// </summary>
            [EnumMember(Value = "Admin_SitePlanningSetup")]
            AdminSitePlanningSetupEnum = 76,
            
            /// <summary>
            /// Enum AdminProvidersEnum for Admin_Providers
            /// </summary>
            [EnumMember(Value = "Admin_Providers")]
            AdminProvidersEnum = 77,
            
            /// <summary>
            /// Enum AdminSubscribersEnum for Admin_Subscribers
            /// </summary>
            [EnumMember(Value = "Admin_Subscribers")]
            AdminSubscribersEnum = 78,
            
            /// <summary>
            /// Enum AdminConnectorEnum for Admin_Connector
            /// </summary>
            [EnumMember(Value = "Admin_Connector")]
            AdminConnectorEnum = 79,
            
            /// <summary>
            /// Enum AdminUserAccountEnum for Admin_UserAccount
            /// </summary>
            [EnumMember(Value = "Admin_UserAccount")]
            AdminUserAccountEnum = 80,
            
            /// <summary>
            /// Enum AdminToolsSurveysEnum for Admin_Tools_Surveys
            /// </summary>
            [EnumMember(Value = "Admin_Tools_Surveys")]
            AdminToolsSurveysEnum = 81,
            
            /// <summary>
            /// Enum AdminToolsCheckListsEnum for Admin_Tools_CheckLists
            /// </summary>
            [EnumMember(Value = "Admin_Tools_CheckLists")]
            AdminToolsCheckListsEnum = 82,
            
            /// <summary>
            /// Enum AdminToolsAnnouncementsEnum for Admin_Tools_Announcements
            /// </summary>
            [EnumMember(Value = "Admin_Tools_Announcements")]
            AdminToolsAnnouncementsEnum = 83,
            
            /// <summary>
            /// Enum AdminToolsRemapProvidersEnum for Admin_Tools_RemapProviders
            /// </summary>
            [EnumMember(Value = "Admin_Tools_RemapProviders")]
            AdminToolsRemapProvidersEnum = 84,
            
            /// <summary>
            /// Enum AdminToolsUploadTemplatesEnum for Admin_Tools_UploadTemplates
            /// </summary>
            [EnumMember(Value = "Admin_Tools_UploadTemplates")]
            AdminToolsUploadTemplatesEnum = 85,
            
            /// <summary>
            /// Enum AdminToolsSuppressionListRemovalEnum for Admin_Tools_SuppressionListRemoval
            /// </summary>
            [EnumMember(Value = "Admin_Tools_SuppressionListRemoval")]
            AdminToolsSuppressionListRemovalEnum = 86,
            
            /// <summary>
            /// Enum AdminToolsQuickViewEnum for Admin_Tools_QuickView
            /// </summary>
            [EnumMember(Value = "Admin_Tools_QuickView")]
            AdminToolsQuickViewEnum = 87,
            
            /// <summary>
            /// Enum AdminQualitySurveySurveyQuestionsEnum for Admin_QualitySurvey_SurveyQuestions
            /// </summary>
            [EnumMember(Value = "Admin_QualitySurvey_SurveyQuestions")]
            AdminQualitySurveySurveyQuestionsEnum = 88,
            
            /// <summary>
            /// Enum AdminQualitySurveySurveyReportEnum for Admin_QualitySurvey_SurveyReport
            /// </summary>
            [EnumMember(Value = "Admin_QualitySurvey_SurveyReport")]
            AdminQualitySurveySurveyReportEnum = 89,
            
            /// <summary>
            /// Enum AdminMobileCIWOEnum for Admin_Mobile_CIWO
            /// </summary>
            [EnumMember(Value = "Admin_Mobile_CIWO")]
            AdminMobileCIWOEnum = 90,
            
            /// <summary>
            /// Enum AdminMobileGPSEnum for Admin_Mobile_GPS
            /// </summary>
            [EnumMember(Value = "Admin_Mobile_GPS")]
            AdminMobileGPSEnum = 91,
            
            /// <summary>
            /// Enum AdminUserManagementEnum for Admin_UserManagement
            /// </summary>
            [EnumMember(Value = "Admin_UserManagement")]
            AdminUserManagementEnum = 92,
            
            /// <summary>
            /// Enum AdminLocationsEnum for Admin_Locations
            /// </summary>
            [EnumMember(Value = "Admin_Locations")]
            AdminLocationsEnum = 93,
            
            /// <summary>
            /// Enum ServiceProvidersEnum for ServiceProviders
            /// </summary>
            [EnumMember(Value = "ServiceProviders")]
            ServiceProvidersEnum = 94,
            
            /// <summary>
            /// Enum AnalyticsProViewEnum for AnalyticsProView
            /// </summary>
            [EnumMember(Value = "AnalyticsProView")]
            AnalyticsProViewEnum = 95,
            
            /// <summary>
            /// Enum LogoutEnum for Logout
            /// </summary>
            [EnumMember(Value = "Logout")]
            LogoutEnum = 96,
            
            /// <summary>
            /// Enum ReportAnIssueEnum for ReportAnIssue
            /// </summary>
            [EnumMember(Value = "ReportAnIssue")]
            ReportAnIssueEnum = 97,
            
            /// <summary>
            /// Enum MobileAccessCodeEnum for MobileAccessCode
            /// </summary>
            [EnumMember(Value = "MobileAccessCode")]
            MobileAccessCodeEnum = 98,
            
            /// <summary>
            /// Enum HelpLinkForSubscribersEnum for HelpLinkForSubscribers
            /// </summary>
            [EnumMember(Value = "HelpLinkForSubscribers")]
            HelpLinkForSubscribersEnum = 99,
            
            /// <summary>
            /// Enum HelpLinkForProvidersEnum for HelpLinkForProviders
            /// </summary>
            [EnumMember(Value = "HelpLinkForProviders")]
            HelpLinkForProvidersEnum = 100,
            
            /// <summary>
            /// Enum ProviderSearchEnum for ProviderSearch
            /// </summary>
            [EnumMember(Value = "ProviderSearch")]
            ProviderSearchEnum = 101,
            
            /// <summary>
            /// Enum ProjectsEnum for Projects
            /// </summary>
            [EnumMember(Value = "Projects")]
            ProjectsEnum = 102,
            
            /// <summary>
            /// Enum AdminProjectsApprovalConfigurationEnum for Admin_Projects_ApprovalConfiguration
            /// </summary>
            [EnumMember(Value = "Admin_Projects_ApprovalConfiguration")]
            AdminProjectsApprovalConfigurationEnum = 103,
            
            /// <summary>
            /// Enum AdminProjectsTypesAndCategoriesEnum for Admin_Projects_TypesAndCategories
            /// </summary>
            [EnumMember(Value = "Admin_Projects_TypesAndCategories")]
            AdminProjectsTypesAndCategoriesEnum = 104,
            
            /// <summary>
            /// Enum AdminProjectsConfigEnum for Admin_Projects_Config
            /// </summary>
            [EnumMember(Value = "Admin_Projects_Config")]
            AdminProjectsConfigEnum = 105,
            
            /// <summary>
            /// Enum AdminSpacesSpacesManagerEnum for Admin_Spaces_SpacesManager
            /// </summary>
            [EnumMember(Value = "Admin_Spaces_SpacesManager")]
            AdminSpacesSpacesManagerEnum = 106,
            
            /// <summary>
            /// Enum AdminToolsUniversalConnectorSetupEnum for Admin_Tools_UniversalConnectorSetup
            /// </summary>
            [EnumMember(Value = "Admin_Tools_UniversalConnectorSetup")]
            AdminToolsUniversalConnectorSetupEnum = 107,
            
            /// <summary>
            /// Enum SpacesAnalyticsEnum for Spaces_Analytics
            /// </summary>
            [EnumMember(Value = "Spaces_Analytics")]
            SpacesAnalyticsEnum = 108,
            
            /// <summary>
            /// Enum SpacesDashboardEnum for Spaces_Dashboard
            /// </summary>
            [EnumMember(Value = "Spaces_Dashboard")]
            SpacesDashboardEnum = 109,
            
            /// <summary>
            /// Enum SpacesManagerEnum for Spaces_Manager
            /// </summary>
            [EnumMember(Value = "Spaces_Manager")]
            SpacesManagerEnum = 110,
            
            /// <summary>
            /// Enum SpacesPlotterEnum for Spaces_Plotter
            /// </summary>
            [EnumMember(Value = "Spaces_Plotter")]
            SpacesPlotterEnum = 111,
            
            /// <summary>
            /// Enum SpacesViewerEnum for Spaces_Viewer
            /// </summary>
            [EnumMember(Value = "Spaces_Viewer")]
            SpacesViewerEnum = 112,
            
            /// <summary>
            /// Enum AdminUniversalConnectorConfigEnum for Admin_UniversalConnectorConfig
            /// </summary>
            [EnumMember(Value = "Admin_UniversalConnectorConfig")]
            AdminUniversalConnectorConfigEnum = 113,
            
            /// <summary>
            /// Enum AdminIssueListSetupEnum for Admin_IssueListSetup
            /// </summary>
            [EnumMember(Value = "Admin_IssueListSetup")]
            AdminIssueListSetupEnum = 114,
            
            /// <summary>
            /// Enum AdminDashboardSettingsEnum for Admin_DashboardSettings
            /// </summary>
            [EnumMember(Value = "Admin_DashboardSettings")]
            AdminDashboardSettingsEnum = 115,
            
            /// <summary>
            /// Enum AdminProposalsNewMLPConfigurationEnum for Admin_Proposals_NewMLPConfiguration
            /// </summary>
            [EnumMember(Value = "Admin_Proposals_NewMLPConfiguration")]
            AdminProposalsNewMLPConfigurationEnum = 116
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=true)]
        public IdEnum Id { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="Items", EmitDefaultValue=false)]
        public List<SCServiceChannelServicesMessagingMenuItem> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingMenuItem {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingMenuItem)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingMenuItem instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingMenuItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingMenuItem other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Url == other.Url ||
                    Url != null &&
                    Url.Equals(other.Url)
                ) && 
                (
                    Id == other.Id ||
                    
                    Id.Equals(other.Id)
                ) && 
                (
                    Items == other.Items ||
                    Items != null &&
                    other.Items != null &&
                    Items.SequenceEqual(other.Items)
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
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Url != null)
                    hashCode = hashCode * 59 + Url.GetHashCode();
                    
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Items != null)
                    hashCode = hashCode * 59 + Items.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingMenuItem left, SCServiceChannelServicesMessagingMenuItem right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingMenuItem left, SCServiceChannelServicesMessagingMenuItem right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}