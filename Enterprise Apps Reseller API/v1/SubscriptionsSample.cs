﻿// Copyright 2017 DAIMTO :  www.daimto.com
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by DAIMTO-Google-apis-Sample-generator 1.0.0
//     Template File Name:  Methodtemplate.tt
//     Build date: 01/02/2017 22:34:15
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the reseller v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Creates and manages your customers and their subscriptions.
// API Documentation Link https://developers.google.com/google-apps/reseller/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/reseller/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.reseller.v1/ 
// Install Command: PM>  Install-Package Google.Apis.reseller.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.reseller.v1;
using Google.Apis.reseller.v1.Data;
using System;

namespace GoogleSamplecSharpSample.resellerv1.Methods
{
  
    public static class SubscriptionsSample
    {


        /// <summary>
        /// Activates a subscription previously suspended by the reseller 
        /// Documentation https://developers.google.com/reseller/v1/reference/subscriptions/activate
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated reseller service.</param>  
        /// <param name="customerId">Id of the Customer</param>
        /// <param name="subscriptionId">Id of the subscription, which is unique for a customer</param>
        /// <returns>SubscriptionResponse</returns>
        public static Subscription Activate(resellerService service, string customerId, string subscriptionId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (customerId == null)
                    throw new ArgumentNullException(customerId);
                if (subscriptionId == null)
                    throw new ArgumentNullException(subscriptionId);

                // Make the request.
                return service.Subscriptions.Activate(customerId, subscriptionId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Subscriptions.Activate failed.", ex);
            }
        }


        /// <summary>
        /// Changes the plan of a subscription 
        /// Documentation https://developers.google.com/reseller/v1/reference/subscriptions/changePlan
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated reseller service.</param>  
        /// <param name="customerId">Id of the Customer</param>
        /// <param name="subscriptionId">Id of the subscription, which is unique for a customer</param>
        /// <param name="body">A valid reseller v1 body.</param>
        /// <returns>SubscriptionResponse</returns>
        public static Subscription ChangePlan(resellerService service, string customerId, string subscriptionId, ChangePlanRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (customerId == null)
                    throw new ArgumentNullException(customerId);
                if (subscriptionId == null)
                    throw new ArgumentNullException(subscriptionId);

                // Make the request.
                return service.Subscriptions.ChangePlan(body, customerId, subscriptionId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Subscriptions.ChangePlan failed.", ex);
            }
        }


        /// <summary>
        /// Changes the renewal settings of a subscription 
        /// Documentation https://developers.google.com/reseller/v1/reference/subscriptions/changeRenewalSettings
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated reseller service.</param>  
        /// <param name="customerId">Id of the Customer</param>
        /// <param name="subscriptionId">Id of the subscription, which is unique for a customer</param>
        /// <param name="body">A valid reseller v1 body.</param>
        /// <returns>SubscriptionResponse</returns>
        public static Subscription ChangeRenewalSettings(resellerService service, string customerId, string subscriptionId, RenewalSettings body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (customerId == null)
                    throw new ArgumentNullException(customerId);
                if (subscriptionId == null)
                    throw new ArgumentNullException(subscriptionId);

                // Make the request.
                return service.Subscriptions.ChangeRenewalSettings(body, customerId, subscriptionId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Subscriptions.ChangeRenewalSettings failed.", ex);
            }
        }


        /// <summary>
        /// Changes the seats configuration of a subscription 
        /// Documentation https://developers.google.com/reseller/v1/reference/subscriptions/changeSeats
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated reseller service.</param>  
        /// <param name="customerId">Id of the Customer</param>
        /// <param name="subscriptionId">Id of the subscription, which is unique for a customer</param>
        /// <param name="body">A valid reseller v1 body.</param>
        /// <returns>SubscriptionResponse</returns>
        public static Subscription ChangeSeats(resellerService service, string customerId, string subscriptionId, Seats body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (customerId == null)
                    throw new ArgumentNullException(customerId);
                if (subscriptionId == null)
                    throw new ArgumentNullException(subscriptionId);

                // Make the request.
                return service.Subscriptions.ChangeSeats(body, customerId, subscriptionId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Subscriptions.ChangeSeats failed.", ex);
            }
        }


        /// <summary>
        /// Cancels/Downgrades a subscription. 
        /// Documentation https://developers.google.com/reseller/v1/reference/subscriptions/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated reseller service.</param>  
        /// <param name="customerId">Id of the Customer</param>
        /// <param name="subscriptionId">Id of the subscription, which is unique for a customer</param>
        /// <param name="deletionType">Whether the subscription is to be fully cancelled or downgraded</param>
        public static void Delete(resellerService service, string customerId, string subscriptionId, string deletionType)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (customerId == null)
                    throw new ArgumentNullException(customerId);
                if (subscriptionId == null)
                    throw new ArgumentNullException(subscriptionId);
                if (deletionType == null)
                    throw new ArgumentNullException(deletionType);

                // Make the request.
                return service.Subscriptions.Delete(customerId, subscriptionId, deletionType).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Subscriptions.Delete failed.", ex);
            }
        }


        /// <summary>
        /// Gets a subscription of the customer. 
        /// Documentation https://developers.google.com/reseller/v1/reference/subscriptions/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated reseller service.</param>  
        /// <param name="customerId">Id of the Customer</param>
        /// <param name="subscriptionId">Id of the subscription, which is unique for a customer</param>
        /// <returns>SubscriptionResponse</returns>
        public static Subscription Get(resellerService service, string customerId, string subscriptionId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (customerId == null)
                    throw new ArgumentNullException(customerId);
                if (subscriptionId == null)
                    throw new ArgumentNullException(subscriptionId);

                // Make the request.
                return service.Subscriptions.Get(customerId, subscriptionId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Subscriptions.Get failed.", ex);
            }
        }

        public class SubscriptionsInsertOptionalParms
        {
            /// An auth token needed for transferring a subscription. Can be generated at https://www.google.com/a/cpanel/customer-domain/TransferToken. Optional.
            public string CustomerAuthToken { get; set; }  
        
        }
 
        /// <summary>
        /// Creates/Transfers a subscription for the customer. 
        /// Documentation https://developers.google.com/reseller/v1/reference/subscriptions/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated reseller service.</param>  
        /// <param name="customerId">Id of the Customer</param>
        /// <param name="body">A valid reseller v1 body.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>SubscriptionResponse</returns>
        public static Subscription Insert(resellerService service, string customerId, Subscription body, SubscriptionsInsertOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (customerId == null)
                    throw new ArgumentNullException(customerId);

                // Building the initial request.
                var request = service.Subscriptions.Insert(body, customerId);

                // Applying optional parameters to the request.                
                request = (SubscriptionsResource.InsertRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Subscriptions.Insert failed.", ex);
            }
        }

        public class SubscriptionsListOptionalParms
        {
            /// An auth token needed if the customer is not a resold customer of this reseller. Can be generated at https://www.google.com/a/cpanel/customer-domain/TransferToken.Optional.
            public string CustomerAuthToken { get; set; }  
            /// Id of the Customer
            public string CustomerId { get; set; }  
            /// Prefix of the customer's domain name by which the subscriptions should be filtered. Optional
            public string CustomerNamePrefix { get; set; }  
            /// Maximum number of results to return
            public int MaxResults { get; set; }  
            /// Token to specify next page in the list
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Lists subscriptions of a reseller, optionally filtered by a customer name prefix. 
        /// Documentation https://developers.google.com/reseller/v1/reference/subscriptions/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated reseller service.</param>  
        /// <param name="optional">Optional paramaters.</param>        /// <returns>SubscriptionsResponse</returns>
        public static Subscriptions List(resellerService service, SubscriptionsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Building the initial request.
                var request = service.Subscriptions.List();

                // Applying optional parameters to the request.                
                request = (SubscriptionsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Subscriptions.List failed.", ex);
            }
        }


        /// <summary>
        /// Starts paid service of a trial subscription 
        /// Documentation https://developers.google.com/reseller/v1/reference/subscriptions/startPaidService
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated reseller service.</param>  
        /// <param name="customerId">Id of the Customer</param>
        /// <param name="subscriptionId">Id of the subscription, which is unique for a customer</param>
        /// <returns>SubscriptionResponse</returns>
        public static Subscription StartPaidService(resellerService service, string customerId, string subscriptionId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (customerId == null)
                    throw new ArgumentNullException(customerId);
                if (subscriptionId == null)
                    throw new ArgumentNullException(subscriptionId);

                // Make the request.
                return service.Subscriptions.StartPaidService(customerId, subscriptionId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Subscriptions.StartPaidService failed.", ex);
            }
        }


        /// <summary>
        /// Suspends an active subscription 
        /// Documentation https://developers.google.com/reseller/v1/reference/subscriptions/suspend
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated reseller service.</param>  
        /// <param name="customerId">Id of the Customer</param>
        /// <param name="subscriptionId">Id of the subscription, which is unique for a customer</param>
        /// <returns>SubscriptionResponse</returns>
        public static Subscription Suspend(resellerService service, string customerId, string subscriptionId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (customerId == null)
                    throw new ArgumentNullException(customerId);
                if (subscriptionId == null)
                    throw new ArgumentNullException(subscriptionId);

                // Make the request.
                return service.Subscriptions.Suspend(customerId, subscriptionId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Subscriptions.Suspend failed.", ex);
            }
        }

        
	}
		public static class SampleHelpers
    {

        /// <summary>
        /// Using reflection to apply optional parameters to the request.  
        /// 
        /// If the optonal parameters are null then we will just return the request as is.
        /// </summary>
        /// <param name="request">The request. </param>
        /// <param name="optional">The optional parameters. </param>
        /// <returns></returns>
        public static object ApplyOptionalParms(object request, object optional)
        {
            if (optional == null)
                return request;

            System.Reflection.PropertyInfo[] optionalProperties = (optional.GetType()).GetProperties();

            foreach (System.Reflection.PropertyInfo property in optionalProperties)
            {
                // Copy value from optional parms to the request.  They should have the same names and datatypes.
                System.Reflection.PropertyInfo piShared = (request.GetType()).GetProperty(property.Name);
				if (property.GetValue(optional, null) != null) // TODO Test that we do not add values for items that are null
					piShared.SetValue(request, property.GetValue(optional, null), null);
            }

            return request;
        }
    }
}