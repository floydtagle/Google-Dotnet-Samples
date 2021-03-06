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
//     Build date: 01/02/2017 22:32:51
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the FirebaseRulesAPI v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Creates and manages rules that determine when a Firebase Rules-enabled service should permit a request.

// API Documentation Link https://firebase.google.com/docs/storage/security
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/FirebaseRulesAPI/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.FirebaseRulesAPI.v1/ 
// Install Command: PM>  Install-Package Google.Apis.FirebaseRulesAPI.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.FirebaseRulesAPI.v1;
using Google.Apis.FirebaseRulesAPI.v1.Data;
using System;

namespace GoogleSamplecSharpSample.FirebaseRulesAPIv1.Methods
{
  
    public static class RulesetsSample
    {


        /// <summary>
        /// Create a `Ruleset` from `Source`.

The `Ruleset` is given a unique generated name which is returned to the
caller. `Source` containing syntactic or semantics errors will result in an
error response indicating the first error encountered. For a detailed view
of `Source` issues, use TestRuleset. 
        /// Documentation https://developers.google.com/firebaserulesapi/v1/reference/rulesets/create
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated FirebaseRulesAPI service.</param>  
        /// <param name="name">Resource name for Project which owns this `Ruleset`.

Format: `projects/{project_id}`</param>
        /// <param name="body">A valid FirebaseRulesAPI v1 body.</param>
        /// <returns>RulesetResponse</returns>
        public static Ruleset Create(FirebaseRulesAPIService service, string name, Ruleset body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Make the request.
                return service.Rulesets.Create(body, name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Rulesets.Create failed.", ex);
            }
        }


        /// <summary>
        /// Get a `Ruleset` by name including the full `Source` contents. 
        /// Documentation https://developers.google.com/firebaserulesapi/v1/reference/rulesets/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated FirebaseRulesAPI service.</param>  
        /// <param name="name">Resource name for the ruleset to get.

Format: `projects/{project_id}/rulesets/{ruleset_id}`</param>
        /// <returns>RulesetResponse</returns>
        public static Ruleset Get(FirebaseRulesAPIService service, string name)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Make the request.
                return service.Rulesets.Get(name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Rulesets.Get failed.", ex);
            }
        }

        public class RulesetsListOptionalParms
        {
            /// Page size to load. Maximum of 100. Defaults to 10.
Note: `page_size` is just a hint and the service may choose to load less
than `page_size` due to the size of the output. To traverse all of the
releases, caller should iterate until the `page_token` is empty.
            public int PageSize { get; set; }  
            /// Next page token for loading the next batch of `Ruleset` instances.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// List `Ruleset` metadata only and optionally filter the results by Ruleset
name.

The full `Source` contents of a `Ruleset` may be retrieved with
GetRuleset. 
        /// Documentation https://developers.google.com/firebaserulesapi/v1/reference/rulesets/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated FirebaseRulesAPI service.</param>  
        /// <param name="name">Resource name for the project.

Format: `projects/{project_id}`</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>ListRulesetsResponseResponse</returns>
        public static ListRulesetsResponse List(FirebaseRulesAPIService service, string name, RulesetsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Building the initial request.
                var request = service.Rulesets.List(name);

                // Applying optional parameters to the request.                
                request = (RulesetsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Rulesets.List failed.", ex);
            }
        }


        /// <summary>
        /// Delete a `Ruleset` by resource name.

If the `Ruleset` is referenced by a `Release` the operation will fail. 
        /// Documentation https://developers.google.com/firebaserulesapi/v1/reference/rulesets/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated FirebaseRulesAPI service.</param>  
        /// <param name="name">Resource name for the ruleset to delete.

Format: `projects/{project_id}/rulesets/{ruleset_id}`</param>
        /// <returns>EmptyResponse</returns>
        public static Empty Delete(FirebaseRulesAPIService service, string name)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Make the request.
                return service.Rulesets.Delete(name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Rulesets.Delete failed.", ex);
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