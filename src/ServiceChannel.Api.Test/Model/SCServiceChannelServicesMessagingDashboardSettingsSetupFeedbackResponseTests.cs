/*
 * ServiceChannel API - v.3
 *
 * The ServiceChannel API is a RESTful and stateless API. It accepts standard HTTP verbs and supports OAuth 2.0 for authorizing requests.      Our API returns common HTTP status codes as well as JSON encapsulated data.      See [API Overview](https://developer.servicechannel.com/basics/introduction/overview/) for the intro to ServiceChannel API.<br>      <h3>Authentication and Authorization</h3>You should have a ServiceChannel account, register your application, and obtain `access_token` to integrate with our API.      See [Authentication and Authorization](https://developer.servicechannel.com/basics/general/authentication/) for more information.      To use this API playground, click **Authorize** and sign in to ServiceChannel.<br>      <h3>Environment</h3> All calls in this API Reference point to the **SB2 environment**.      See [Environments](https://developer.servicechannel.com/basics/general/environments/) for more information.<br>      <h3>API Version</h3>The current stable version of the ServiceChannel API is `v3`. In the request URL, `v3` is a version prefix that should be present.      When you omit the version prefix, calls point to the minimum supported version of the API.      We recommend you to always specify the API version to avoid possible errors.
 *
 * The version of the OpenAPI document: 3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using ServiceChannel.Api.Model;
using ServiceChannel.Api.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace ServiceChannel.Api.Test.Model
{
    /// <summary>
    ///  Class for testing SCServiceChannelServicesMessagingDashboardSettingsSetupFeedbackResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SCServiceChannelServicesMessagingDashboardSettingsSetupFeedbackResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SCServiceChannelServicesMessagingDashboardSettingsSetupFeedbackResponse
        //private SCServiceChannelServicesMessagingDashboardSettingsSetupFeedbackResponse instance;

        public SCServiceChannelServicesMessagingDashboardSettingsSetupFeedbackResponseTests()
        {
            // TODO uncomment below to create an instance of SCServiceChannelServicesMessagingDashboardSettingsSetupFeedbackResponse
            //instance = new SCServiceChannelServicesMessagingDashboardSettingsSetupFeedbackResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SCServiceChannelServicesMessagingDashboardSettingsSetupFeedbackResponse
        /// </summary>
        [Fact]
        public void SCServiceChannelServicesMessagingDashboardSettingsSetupFeedbackResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" SCServiceChannelServicesMessagingDashboardSettingsSetupFeedbackResponse
            //Assert.IsType<SCServiceChannelServicesMessagingDashboardSettingsSetupFeedbackResponse>(instance);
        }


        /// <summary>
        /// Test the property 'SetupId'
        /// </summary>
        [Fact]
        public void SetupIdTest()
        {
            // TODO unit test for the property 'SetupId'
        }
        /// <summary>
        /// Test the property 'EnableFeedback'
        /// </summary>
        [Fact]
        public void EnableFeedbackTest()
        {
            // TODO unit test for the property 'EnableFeedback'
        }
        /// <summary>
        /// Test the property 'EmailHeader'
        /// </summary>
        [Fact]
        public void EmailHeaderTest()
        {
            // TODO unit test for the property 'EmailHeader'
        }
        /// <summary>
        /// Test the property 'CustomUnsatisfactoryMessage'
        /// </summary>
        [Fact]
        public void CustomUnsatisfactoryMessageTest()
        {
            // TODO unit test for the property 'CustomUnsatisfactoryMessage'
        }
        /// <summary>
        /// Test the property 'EnableNegativeFeedback'
        /// </summary>
        [Fact]
        public void EnableNegativeFeedbackTest()
        {
            // TODO unit test for the property 'EnableNegativeFeedback'
        }
        /// <summary>
        /// Test the property 'EnablePositiveFeedback'
        /// </summary>
        [Fact]
        public void EnablePositiveFeedbackTest()
        {
            // TODO unit test for the property 'EnablePositiveFeedback'
        }
        /// <summary>
        /// Test the property 'ShowDays'
        /// </summary>
        [Fact]
        public void ShowDaysTest()
        {
            // TODO unit test for the property 'ShowDays'
        }
        /// <summary>
        /// Test the property 'ShowCompletedDate'
        /// </summary>
        [Fact]
        public void ShowCompletedDateTest()
        {
            // TODO unit test for the property 'ShowCompletedDate'
        }
        /// <summary>
        /// Test the property 'ShowResolution'
        /// </summary>
        [Fact]
        public void ShowResolutionTest()
        {
            // TODO unit test for the property 'ShowResolution'
        }
        /// <summary>
        /// Test the property 'EnableNegFeedNotification'
        /// </summary>
        [Fact]
        public void EnableNegFeedNotificationTest()
        {
            // TODO unit test for the property 'EnableNegFeedNotification'
        }
        /// <summary>
        /// Test the property 'EnableAutoConfirm'
        /// </summary>
        [Fact]
        public void EnableAutoConfirmTest()
        {
            // TODO unit test for the property 'EnableAutoConfirm'
        }
        /// <summary>
        /// Test the property 'DaysPeriod'
        /// </summary>
        [Fact]
        public void DaysPeriodTest()
        {
            // TODO unit test for the property 'DaysPeriod'
        }
        /// <summary>
        /// Test the property 'CustomMessage'
        /// </summary>
        [Fact]
        public void CustomMessageTest()
        {
            // TODO unit test for the property 'CustomMessage'
        }
        /// <summary>
        /// Test the property 'Statuses'
        /// </summary>
        [Fact]
        public void StatusesTest()
        {
            // TODO unit test for the property 'Statuses'
        }
        /// <summary>
        /// Test the property 'EnableScheduledDate'
        /// </summary>
        [Fact]
        public void EnableScheduledDateTest()
        {
            // TODO unit test for the property 'EnableScheduledDate'
        }
        /// <summary>
        /// Test the property 'SkipUnsatisfactoryAlertsToProviders'
        /// </summary>
        [Fact]
        public void SkipUnsatisfactoryAlertsToProvidersTest()
        {
            // TODO unit test for the property 'SkipUnsatisfactoryAlertsToProviders'
        }
        /// <summary>
        /// Test the property 'UnsatisfactorySubmitAttemptsNotification'
        /// </summary>
        [Fact]
        public void UnsatisfactorySubmitAttemptsNotificationTest()
        {
            // TODO unit test for the property 'UnsatisfactorySubmitAttemptsNotification'
        }
        /// <summary>
        /// Test the property 'SendFeedbackToCreatedByUser'
        /// </summary>
        [Fact]
        public void SendFeedbackToCreatedByUserTest()
        {
            // TODO unit test for the property 'SendFeedbackToCreatedByUser'
        }
        /// <summary>
        /// Test the property 'EnableSupplyManagerEmailConfirmation'
        /// </summary>
        [Fact]
        public void EnableSupplyManagerEmailConfirmationTest()
        {
            // TODO unit test for the property 'EnableSupplyManagerEmailConfirmation'
        }
        /// <summary>
        /// Test the property 'SupplyManagerEmailConfirmationHoursAfter'
        /// </summary>
        [Fact]
        public void SupplyManagerEmailConfirmationHoursAfterTest()
        {
            // TODO unit test for the property 'SupplyManagerEmailConfirmationHoursAfter'
        }
        /// <summary>
        /// Test the property 'SupplyManagerEmailConfirmationCustomNotificationMessage'
        /// </summary>
        [Fact]
        public void SupplyManagerEmailConfirmationCustomNotificationMessageTest()
        {
            // TODO unit test for the property 'SupplyManagerEmailConfirmationCustomNotificationMessage'
        }
        /// <summary>
        /// Test the property 'AnsweringCustomQuestionOptional'
        /// </summary>
        [Fact]
        public void AnsweringCustomQuestionOptionalTest()
        {
            // TODO unit test for the property 'AnsweringCustomQuestionOptional'
        }

    }

}