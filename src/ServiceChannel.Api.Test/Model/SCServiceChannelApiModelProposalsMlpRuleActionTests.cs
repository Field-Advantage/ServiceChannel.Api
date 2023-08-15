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
    ///  Class for testing SCServiceChannelApiModelProposalsMlpRuleAction
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SCServiceChannelApiModelProposalsMlpRuleActionTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SCServiceChannelApiModelProposalsMlpRuleAction
        //private SCServiceChannelApiModelProposalsMlpRuleAction instance;

        public SCServiceChannelApiModelProposalsMlpRuleActionTests()
        {
            // TODO uncomment below to create an instance of SCServiceChannelApiModelProposalsMlpRuleAction
            //instance = new SCServiceChannelApiModelProposalsMlpRuleAction();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SCServiceChannelApiModelProposalsMlpRuleAction
        /// </summary>
        [Fact]
        public void SCServiceChannelApiModelProposalsMlpRuleActionInstanceTest()
        {
            // TODO uncomment below to test "IsType" SCServiceChannelApiModelProposalsMlpRuleAction
            //Assert.IsType<SCServiceChannelApiModelProposalsMlpRuleAction>(instance);
        }


        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Limit'
        /// </summary>
        [Fact]
        public void LimitTest()
        {
            // TODO unit test for the property 'Limit'
        }
        /// <summary>
        /// Test the property 'ForwardTo'
        /// </summary>
        [Fact]
        public void ForwardToTest()
        {
            // TODO unit test for the property 'ForwardTo'
        }
        /// <summary>
        /// Test the property 'ForwardToLevelName'
        /// </summary>
        [Fact]
        public void ForwardToLevelNameTest()
        {
            // TODO unit test for the property 'ForwardToLevelName'
        }
        /// <summary>
        /// Test the property 'EndStatus'
        /// </summary>
        [Fact]
        public void EndStatusTest()
        {
            // TODO unit test for the property 'EndStatus'
        }
        /// <summary>
        /// Test the property 'AutoEscalateInDays'
        /// </summary>
        [Fact]
        public void AutoEscalateInDaysTest()
        {
            // TODO unit test for the property 'AutoEscalateInDays'
        }
        /// <summary>
        /// Test the property 'EntryLevel'
        /// </summary>
        [Fact]
        public void EntryLevelTest()
        {
            // TODO unit test for the property 'EntryLevel'
        }
        /// <summary>
        /// Test the property 'CodeChange'
        /// </summary>
        [Fact]
        public void CodeChangeTest()
        {
            // TODO unit test for the property 'CodeChange'
        }
        /// <summary>
        /// Test the property 'CategoryChange'
        /// </summary>
        [Fact]
        public void CategoryChangeTest()
        {
            // TODO unit test for the property 'CategoryChange'
        }
        /// <summary>
        /// Test the property 'LevelId'
        /// </summary>
        [Fact]
        public void LevelIdTest()
        {
            // TODO unit test for the property 'LevelId'
        }
        /// <summary>
        /// Test the property 'LevelName'
        /// </summary>
        [Fact]
        public void LevelNameTest()
        {
            // TODO unit test for the property 'LevelName'
        }
        /// <summary>
        /// Test the property 'RuleNumber'
        /// </summary>
        [Fact]
        public void RuleNumberTest()
        {
            // TODO unit test for the property 'RuleNumber'
        }
        /// <summary>
        /// Test the property 'RuleOrder'
        /// </summary>
        [Fact]
        public void RuleOrderTest()
        {
            // TODO unit test for the property 'RuleOrder'
        }
        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'RuleSetId'
        /// </summary>
        [Fact]
        public void RuleSetIdTest()
        {
            // TODO unit test for the property 'RuleSetId'
        }
        /// <summary>
        /// Test the property 'Override'
        /// </summary>
        [Fact]
        public void OverrideTest()
        {
            // TODO unit test for the property 'Override'
        }
        /// <summary>
        /// Test the property 'SkipOverLimit'
        /// </summary>
        [Fact]
        public void SkipOverLimitTest()
        {
            // TODO unit test for the property 'SkipOverLimit'
        }
        /// <summary>
        /// Test the property 'ActionNotification'
        /// </summary>
        [Fact]
        public void ActionNotificationTest()
        {
            // TODO unit test for the property 'ActionNotification'
        }
        /// <summary>
        /// Test the property 'LocationId'
        /// </summary>
        [Fact]
        public void LocationIdTest()
        {
            // TODO unit test for the property 'LocationId'
        }
        /// <summary>
        /// Test the property 'UserId'
        /// </summary>
        [Fact]
        public void UserIdTest()
        {
            // TODO unit test for the property 'UserId'
        }

    }

}