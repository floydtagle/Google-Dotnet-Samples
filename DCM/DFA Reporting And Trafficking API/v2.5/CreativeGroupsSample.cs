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
//     Build date: 01/02/2017 22:32:33
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the dfareporting v2.5 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Manages your DoubleClick Campaign Manager ad campaigns and reports.
// API Documentation Link https://developers.google.com/doubleclick-advertisers/reporting/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/dfareporting/v2_5/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.dfareporting.v2_5/ 
// Install Command: PM>  Install-Package Google.Apis.dfareporting.v2_5
//
//------------------------------------------------------------------------------  
using Google.Apis.dfareporting.v2_5;
using Google.Apis.dfareporting.v2_5.Data;
using System;

namespace GoogleSamplecSharpSample.dfareportingv2_5.Methods
{
  
    public static class CreativeGroupsSample
    {


        /// <summary>
        /// Gets one creative group by ID. 
        /// Documentation https://developers.google.com/dfareporting/v2.5/reference/creativeGroups/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="id">Creative group ID.</param>
        /// <returns>CreativeGroupResponse</returns>
        public static CreativeGroup Get(dfareportingService service, string profileId, string id)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (profileId == null)
                    throw new ArgumentNullException(profileId);
                if (id == null)
                    throw new ArgumentNullException(id);

                // Make the request.
                return service.CreativeGroups.Get(profileId, id).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request CreativeGroups.Get failed.", ex);
            }
        }


        /// <summary>
        /// Inserts a new creative group. 
        /// Documentation https://developers.google.com/dfareporting/v2.5/reference/creativeGroups/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="body">A valid dfareporting v2.5 body.</param>
        /// <returns>CreativeGroupResponse</returns>
        public static CreativeGroup Insert(dfareportingService service, string profileId, CreativeGroup body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (profileId == null)
                    throw new ArgumentNullException(profileId);

                // Make the request.
                return service.CreativeGroups.Insert(body, profileId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request CreativeGroups.Insert failed.", ex);
            }
        }

        public class CreativeGroupsListOptionalParms
        {
            /// Select only creative groups that belong to these advertisers.
            public string AdvertiserIds { get; set; }  
            /// Select only creative groups that belong to this subgroup.
            public int GroupNumber { get; set; }  
            /// Select only creative groups with these IDs.
            public string Ids { get; set; }  
            /// Maximum number of results to return.
            public int MaxResults { get; set; }  
            /// Value of the nextPageToken from the previous result page.
            public string PageToken { get; set; }  
            /// Allows searching for creative groups by name or ID. Wildcards (*) are allowed. For example, "creativegroup*2015" will return creative groups with names like "creativegroup June 2015", "creativegroup April 2015", or simply "creativegroup 2015". Most of the searches also add wild-cards implicitly at the start and the end of the search string. For example, a search string of "creativegroup" will match creative groups with the name "my creativegroup", "creativegroup 2015", or simply "creativegroup".
            public string SearchString { get; set; }  
            /// Field by which to sort the list.
            public string SortField { get; set; }  
            /// Order of sorted results, default is ASCENDING.
            public string SortOrder { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves a list of creative groups, possibly filtered. This method supports paging. 
        /// Documentation https://developers.google.com/dfareporting/v2.5/reference/creativeGroups/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>CreativeGroupsListResponseResponse</returns>
        public static CreativeGroupsListResponse List(dfareportingService service, string profileId, CreativeGroupsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (profileId == null)
                    throw new ArgumentNullException(profileId);

                // Building the initial request.
                var request = service.CreativeGroups.List(profileId);

                // Applying optional parameters to the request.                
                request = (CreativeGroupsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request CreativeGroups.List failed.", ex);
            }
        }


        /// <summary>
        /// Updates an existing creative group. This method supports patch semantics. 
        /// Documentation https://developers.google.com/dfareporting/v2.5/reference/creativeGroups/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="id">Creative group ID.</param>
        /// <param name="body">A valid dfareporting v2.5 body.</param>
        /// <returns>CreativeGroupResponse</returns>
        public static CreativeGroup Patch(dfareportingService service, string profileId, string id, CreativeGroup body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (profileId == null)
                    throw new ArgumentNullException(profileId);
                if (id == null)
                    throw new ArgumentNullException(id);

                // Make the request.
                return service.CreativeGroups.Patch(body, profileId, id).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request CreativeGroups.Patch failed.", ex);
            }
        }


        /// <summary>
        /// Updates an existing creative group. 
        /// Documentation https://developers.google.com/dfareporting/v2.5/reference/creativeGroups/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="body">A valid dfareporting v2.5 body.</param>
        /// <returns>CreativeGroupResponse</returns>
        public static CreativeGroup Update(dfareportingService service, string profileId, CreativeGroup body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (profileId == null)
                    throw new ArgumentNullException(profileId);

                // Make the request.
                return service.CreativeGroups.Update(body, profileId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request CreativeGroups.Update failed.", ex);
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