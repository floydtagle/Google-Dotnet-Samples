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
//     Build date: 01/02/2017 22:31:34
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the AdExchangeBuyer v1.3 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Accesses your bidding-account information, submits creatives for validation, finds available direct deals, and retrieves performance reports.
// API Documentation Link https://developers.google.com/ad-exchange/buyer-rest
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/AdExchangeBuyer/v1_3/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.AdExchangeBuyer.v1_3/ 
// Install Command: PM>  Install-Package Google.Apis.AdExchangeBuyer.v1_3
//
//------------------------------------------------------------------------------  
using Google.Apis.AdExchangeBuyer.v1_3;
using Google.Apis.AdExchangeBuyer.v1_3.Data;
using System;

namespace GoogleSamplecSharpSample.AdExchangeBuyerv1_3.Methods
{
  
    public static class BudgetSample
    {


        /// <summary>
        /// Returns the budget information for the adgroup specified by the accountId and billingId. 
        /// Documentation https://developers.google.com/adexchangebuyer/v1.3/reference/budget/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated AdExchangeBuyer service.</param>  
        /// <param name="accountId">The account id to get the budget information for.</param>
        /// <param name="billingId">The billing id to get the budget information for.</param>
        /// <returns>BudgetResponse</returns>
        public static Budget Get(AdExchangeBuyerService service, string accountId, string billingId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (accountId == null)
                    throw new ArgumentNullException(accountId);
                if (billingId == null)
                    throw new ArgumentNullException(billingId);

                // Make the request.
                return service.Budget.Get(accountId, billingId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Budget.Get failed.", ex);
            }
        }


        /// <summary>
        /// Updates the budget amount for the budget of the adgroup specified by the accountId and billingId, with the budget amount in the request. This method supports patch semantics. 
        /// Documentation https://developers.google.com/adexchangebuyer/v1.3/reference/budget/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated AdExchangeBuyer service.</param>  
        /// <param name="accountId">The account id associated with the budget being updated.</param>
        /// <param name="billingId">The billing id associated with the budget being updated.</param>
        /// <param name="body">A valid AdExchangeBuyer v1.3 body.</param>
        /// <returns>BudgetResponse</returns>
        public static Budget Patch(AdExchangeBuyerService service, string accountId, string billingId, Budget body)
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
                if (billingId == null)
                    throw new ArgumentNullException(billingId);

                // Make the request.
                return service.Budget.Patch(body, accountId, billingId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Budget.Patch failed.", ex);
            }
        }


        /// <summary>
        /// Updates the budget amount for the budget of the adgroup specified by the accountId and billingId, with the budget amount in the request. 
        /// Documentation https://developers.google.com/adexchangebuyer/v1.3/reference/budget/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated AdExchangeBuyer service.</param>  
        /// <param name="accountId">The account id associated with the budget being updated.</param>
        /// <param name="billingId">The billing id associated with the budget being updated.</param>
        /// <param name="body">A valid AdExchangeBuyer v1.3 body.</param>
        /// <returns>BudgetResponse</returns>
        public static Budget Update(AdExchangeBuyerService service, string accountId, string billingId, Budget body)
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
                if (billingId == null)
                    throw new ArgumentNullException(billingId);

                // Make the request.
                return service.Budget.Update(body, accountId, billingId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Budget.Update failed.", ex);
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