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
//     Build date: 01/02/2017 22:32:37
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the dfareporting v2.6 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Manages your DoubleClick Campaign Manager ad campaigns and reports.
// API Documentation Link https://developers.google.com/doubleclick-advertisers/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/dfareporting/v2_6/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.dfareporting.v2_6/ 
// Install Command: PM>  Install-Package Google.Apis.dfareporting.v2_6
//
//------------------------------------------------------------------------------  
using Google.Apis.dfareporting.v2_6;
using Google.Apis.dfareporting.v2_6.Data;
using System;

namespace GoogleSamplecSharpSample.dfareportingv2_6.Methods
{
  
    public static class FloodlightActivitiesSample
    {


        /// <summary>
        /// Deletes an existing floodlight activity. 
        /// Documentation https://developers.google.com/dfareporting/v2.6/reference/floodlightActivities/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="id">Floodlight activity ID.</param>
        public static void Delete(dfareportingService service, string profileId, string id)
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
                return service.FloodlightActivities.Delete(profileId, id).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request FloodlightActivities.Delete failed.", ex);
            }
        }

        public class FloodlightActivitiesGeneratetagOptionalParms
        {
            /// Floodlight activity ID for which we want to generate a tag.
            public string FloodlightActivityId { get; set; }  
        
        }
 
        /// <summary>
        /// Generates a tag for a floodlight activity. 
        /// Documentation https://developers.google.com/dfareporting/v2.6/reference/floodlightActivities/generatetag
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>FloodlightActivitiesGenerateTagResponseResponse</returns>
        public static FloodlightActivitiesGenerateTagResponse Generatetag(dfareportingService service, string profileId, FloodlightActivitiesGeneratetagOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (profileId == null)
                    throw new ArgumentNullException(profileId);

                // Building the initial request.
                var request = service.FloodlightActivities.Generatetag(profileId);

                // Applying optional parameters to the request.                
                request = (FloodlightActivitiesResource.GeneratetagRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request FloodlightActivities.Generatetag failed.", ex);
            }
        }


        /// <summary>
        /// Gets one floodlight activity by ID. 
        /// Documentation https://developers.google.com/dfareporting/v2.6/reference/floodlightActivities/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="id">Floodlight activity ID.</param>
        /// <returns>FloodlightActivityResponse</returns>
        public static FloodlightActivity Get(dfareportingService service, string profileId, string id)
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
                return service.FloodlightActivities.Get(profileId, id).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request FloodlightActivities.Get failed.", ex);
            }
        }


        /// <summary>
        /// Inserts a new floodlight activity. 
        /// Documentation https://developers.google.com/dfareporting/v2.6/reference/floodlightActivities/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="body">A valid dfareporting v2.6 body.</param>
        /// <returns>FloodlightActivityResponse</returns>
        public static FloodlightActivity Insert(dfareportingService service, string profileId, FloodlightActivity body)
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
                return service.FloodlightActivities.Insert(body, profileId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request FloodlightActivities.Insert failed.", ex);
            }
        }

        public class FloodlightActivitiesListOptionalParms
        {
            /// Select only floodlight activities for the specified advertiser ID. Must specify either ids, advertiserId, or floodlightConfigurationId for a non-empty result.
            public string AdvertiserId { get; set; }  
            /// Select only floodlight activities with the specified floodlight activity group IDs.
            public string FloodlightActivityGroupIds { get; set; }  
            /// Select only floodlight activities with the specified floodlight activity group name.
            public string FloodlightActivityGroupName { get; set; }  
            /// Select only floodlight activities with the specified floodlight activity group tag string.
            public string FloodlightActivityGroupTagString { get; set; }  
            /// Select only floodlight activities with the specified floodlight activity group type.
            public string FloodlightActivityGroupType { get; set; }  
            /// Select only floodlight activities for the specified floodlight configuration ID. Must specify either ids, advertiserId, or floodlightConfigurationId for a non-empty result.
            public string FloodlightConfigurationId { get; set; }  
            /// Select only floodlight activities with the specified IDs. Must specify either ids, advertiserId, or floodlightConfigurationId for a non-empty result.
            public string Ids { get; set; }  
            /// Maximum number of results to return.
            public int MaxResults { get; set; }  
            /// Value of the nextPageToken from the previous result page.
            public string PageToken { get; set; }  
            /// Allows searching for objects by name or ID. Wildcards (*) are allowed. For example, "floodlightactivity*2015" will return objects with names like "floodlightactivity June 2015", "floodlightactivity April 2015", or simply "floodlightactivity 2015". Most of the searches also add wildcards implicitly at the start and the end of the search string. For example, a search string of "floodlightactivity" will match objects with name "my floodlightactivity activity", "floodlightactivity 2015", or simply "floodlightactivity".
            public string SearchString { get; set; }  
            /// Field by which to sort the list.
            public string SortField { get; set; }  
            /// Order of sorted results, default is ASCENDING.
            public string SortOrder { get; set; }  
            /// Select only floodlight activities with the specified tag string.
            public string TagString { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves a list of floodlight activities, possibly filtered. This method supports paging. 
        /// Documentation https://developers.google.com/dfareporting/v2.6/reference/floodlightActivities/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>FloodlightActivitiesListResponseResponse</returns>
        public static FloodlightActivitiesListResponse List(dfareportingService service, string profileId, FloodlightActivitiesListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (profileId == null)
                    throw new ArgumentNullException(profileId);

                // Building the initial request.
                var request = service.FloodlightActivities.List(profileId);

                // Applying optional parameters to the request.                
                request = (FloodlightActivitiesResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request FloodlightActivities.List failed.", ex);
            }
        }


        /// <summary>
        /// Updates an existing floodlight activity. This method supports patch semantics. 
        /// Documentation https://developers.google.com/dfareporting/v2.6/reference/floodlightActivities/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="id">Floodlight activity ID.</param>
        /// <param name="body">A valid dfareporting v2.6 body.</param>
        /// <returns>FloodlightActivityResponse</returns>
        public static FloodlightActivity Patch(dfareportingService service, string profileId, string id, FloodlightActivity body)
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
                return service.FloodlightActivities.Patch(body, profileId, id).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request FloodlightActivities.Patch failed.", ex);
            }
        }


        /// <summary>
        /// Updates an existing floodlight activity. 
        /// Documentation https://developers.google.com/dfareporting/v2.6/reference/floodlightActivities/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="body">A valid dfareporting v2.6 body.</param>
        /// <returns>FloodlightActivityResponse</returns>
        public static FloodlightActivity Update(dfareportingService service, string profileId, FloodlightActivity body)
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
                return service.FloodlightActivities.Update(body, profileId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request FloodlightActivities.Update failed.", ex);
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