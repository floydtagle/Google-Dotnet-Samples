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
//     Build date: 01/02/2017 22:31:37
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the AdExchangeBuyerII v2beta1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Accesses the latest features for managing Ad Exchange accounts, Real-Time Bidding configurations and auction metrics, and Marketplace programmatic deals.
// API Documentation Link https://developers.google.com/ad-exchange/buyer-rest/guides/client-access/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/AdExchangeBuyerII/v2beta1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.AdExchangeBuyerII.v2beta1/ 
// Install Command: PM>  Install-Package Google.Apis.AdExchangeBuyerII.v2beta1
//
//------------------------------------------------------------------------------  
using Google.Apis.AdExchangeBuyerII.v2beta1;
using Google.Apis.AdExchangeBuyerII.v2beta1.Data;
using System;

namespace GoogleSamplecSharpSample.AdExchangeBuyerIIv2beta1.Methods
{
  
    public static class UsersSample
    {


        /// <summary>
        /// Updates an existing client user.
Only the user status can be changed on update. 
        /// Documentation https://developers.google.com/adexchangebuyerii/v2beta1/reference/users/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated AdExchangeBuyerII service.</param>  
        /// <param name="accountId">Numerical account ID of the client's sponsor buyer. (required)</param>
        /// <param name="clientAccountId">Numerical account ID of the client buyer that the user to be retrieved
is associated with. (required)</param>
        /// <param name="userId">Numerical identifier of the user to retrieve. (required)</param>
        /// <param name="body">A valid AdExchangeBuyerII v2beta1 body.</param>
        /// <returns>ClientUserResponse</returns>
        public static ClientUser Update(AdExchangeBuyerIIService service, string accountId, string clientAccountId, string userId, ClientUser body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (accountId == null)
                    throw new ArgumentNullException(accountId);
                if (clientAccountId == null)
                    throw new ArgumentNullException(clientAccountId);
                if (userId == null)
                    throw new ArgumentNullException(userId);

                // Make the request.
                return service.Users.Update(body, accountId, clientAccountId, userId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Users.Update failed.", ex);
            }
        }


        /// <summary>
        /// Retrieves an existing client user. 
        /// Documentation https://developers.google.com/adexchangebuyerii/v2beta1/reference/users/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated AdExchangeBuyerII service.</param>  
        /// <param name="accountId">Numerical account ID of the client's sponsor buyer. (required)</param>
        /// <param name="clientAccountId">Numerical account ID of the client buyer
that the user to be retrieved is associated with. (required)</param>
        /// <param name="userId">Numerical identifier of the user to retrieve. (required)</param>
        /// <returns>ClientUserResponse</returns>
        public static ClientUser Get(AdExchangeBuyerIIService service, string accountId, string clientAccountId, string userId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (accountId == null)
                    throw new ArgumentNullException(accountId);
                if (clientAccountId == null)
                    throw new ArgumentNullException(clientAccountId);
                if (userId == null)
                    throw new ArgumentNullException(userId);

                // Make the request.
                return service.Users.Get(accountId, clientAccountId, userId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Users.Get failed.", ex);
            }
        }

        public class UsersListOptionalParms
        {
            /// Requested page size. The server may return fewer clients than requested.
If unspecified, the server will pick an appropriate default.
            public int PageSize { get; set; }  
            /// A token identifying a page of results the server should return.
Typically, this is the value of
ListClientUsersResponse.nextPageToken
returned from the previous call to the
accounts.clients.users.list method.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Lists all the known client users for a specified
sponsor buyer account ID. 
        /// Documentation https://developers.google.com/adexchangebuyerii/v2beta1/reference/users/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated AdExchangeBuyerII service.</param>  
        /// <param name="accountId">Numerical account ID of the sponsor buyer of the client to list users for.
(required)</param>
        /// <param name="clientAccountId">The account ID of the client buyer to list users for. (required)
You must specify either a string representation of a
numerical account identifier or the `-` character
to list all the client users for all the clients
of a given sponsor buyer.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>ListClientUsersResponseResponse</returns>
        public static ListClientUsersResponse List(AdExchangeBuyerIIService service, string accountId, string clientAccountId, UsersListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (accountId == null)
                    throw new ArgumentNullException(accountId);
                if (clientAccountId == null)
                    throw new ArgumentNullException(clientAccountId);

                // Building the initial request.
                var request = service.Users.List(accountId, clientAccountId);

                // Applying optional parameters to the request.                
                request = (UsersResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Users.List failed.", ex);
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