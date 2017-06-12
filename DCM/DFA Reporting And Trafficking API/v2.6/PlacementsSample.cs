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
  
    public static class PlacementsSample
    {

        public class PlacementsGeneratetagsOptionalParms
        {
            /// Generate placements belonging to this campaign. This is a required field.
            public string CampaignId { get; set; }  
            /// Generate tags for these placements.
            public string PlacementIds { get; set; }  
            /// Tag formats to generate for these placements.
            public string TagFormats { get; set; }  
        
        }
 
        /// <summary>
        /// Generates tags for a placement. 
        /// Documentation https://developers.google.com/dfareporting/v2.6/reference/placements/generatetags
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>PlacementsGenerateTagsResponseResponse</returns>
        public static PlacementsGenerateTagsResponse Generatetags(dfareportingService service, string profileId, PlacementsGeneratetagsOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (profileId == null)
                    throw new ArgumentNullException(profileId);

                // Building the initial request.
                var request = service.Placements.Generatetags(profileId);

                // Applying optional parameters to the request.                
                request = (PlacementsResource.GeneratetagsRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Placements.Generatetags failed.", ex);
            }
        }


        /// <summary>
        /// Gets one placement by ID. 
        /// Documentation https://developers.google.com/dfareporting/v2.6/reference/placements/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="id">Placement ID.</param>
        /// <returns>PlacementResponse</returns>
        public static Placement Get(dfareportingService service, string profileId, string id)
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
                return service.Placements.Get(profileId, id).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Placements.Get failed.", ex);
            }
        }


        /// <summary>
        /// Inserts a new placement. 
        /// Documentation https://developers.google.com/dfareporting/v2.6/reference/placements/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="body">A valid dfareporting v2.6 body.</param>
        /// <returns>PlacementResponse</returns>
        public static Placement Insert(dfareportingService service, string profileId, Placement body)
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
                return service.Placements.Insert(body, profileId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Placements.Insert failed.", ex);
            }
        }

        public class PlacementsListOptionalParms
        {
            /// Select only placements that belong to these advertisers.
            public string AdvertiserIds { get; set; }  
            /// Select only archived placements. Don't set this field to select both archived and non-archived placements.
            public bool Archived { get; set; }  
            /// Select only placements that belong to these campaigns.
            public string CampaignIds { get; set; }  
            /// Select only placements that are associated with these compatibilities. DISPLAY and DISPLAY_INTERSTITIAL refer to rendering either on desktop or on mobile devices for regular or interstitial ads respectively. APP and APP_INTERSTITIAL are for rendering in mobile apps. IN_STREAM_VIDEO refers to rendering in in-stream video ads developed with the VAST standard.
            public string Compatibilities { get; set; }  
            /// Select only placements that are associated with these content categories.
            public string ContentCategoryIds { get; set; }  
            /// Select only placements that are associated with these directory sites.
            public string DirectorySiteIds { get; set; }  
            /// Select only placements that belong to these placement groups.
            public string GroupIds { get; set; }  
            /// Select only placements with these IDs.
            public string Ids { get; set; }  
            /// Select only placements or placement groups whose end date is on or before the specified maxEndDate. The date should be formatted as "yyyy-MM-dd".
            public string MaxEndDate { get; set; }  
            /// Maximum number of results to return.
            public int MaxResults { get; set; }  
            /// Select only placements or placement groups whose start date is on or before the specified maxStartDate. The date should be formatted as "yyyy-MM-dd".
            public string MaxStartDate { get; set; }  
            /// Select only placements or placement groups whose end date is on or after the specified minEndDate. The date should be formatted as "yyyy-MM-dd".
            public string MinEndDate { get; set; }  
            /// Select only placements or placement groups whose start date is on or after the specified minStartDate. The date should be formatted as "yyyy-MM-dd".
            public string MinStartDate { get; set; }  
            /// Value of the nextPageToken from the previous result page.
            public string PageToken { get; set; }  
            /// Select only placements with this payment source.
            public string PaymentSource { get; set; }  
            /// Select only placements that are associated with these placement strategies.
            public string PlacementStrategyIds { get; set; }  
            /// Select only placements with these pricing types.
            public string PricingTypes { get; set; }  
            /// Allows searching for placements by name or ID. Wildcards (*) are allowed. For example, "placement*2015" will return placements with names like "placement June 2015", "placement May 2015", or simply "placements 2015". Most of the searches also add wildcards implicitly at the start and the end of the search string. For example, a search string of "placement" will match placements with name "my placement", "placement 2015", or simply "placement".
            public string SearchString { get; set; }  
            /// Select only placements that are associated with these sites.
            public string SiteIds { get; set; }  
            /// Select only placements that are associated with these sizes.
            public string SizeIds { get; set; }  
            /// Field by which to sort the list.
            public string SortField { get; set; }  
            /// Order of sorted results, default is ASCENDING.
            public string SortOrder { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves a list of placements, possibly filtered. This method supports paging. 
        /// Documentation https://developers.google.com/dfareporting/v2.6/reference/placements/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>PlacementsListResponseResponse</returns>
        public static PlacementsListResponse List(dfareportingService service, string profileId, PlacementsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (profileId == null)
                    throw new ArgumentNullException(profileId);

                // Building the initial request.
                var request = service.Placements.List(profileId);

                // Applying optional parameters to the request.                
                request = (PlacementsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Placements.List failed.", ex);
            }
        }


        /// <summary>
        /// Updates an existing placement. This method supports patch semantics. 
        /// Documentation https://developers.google.com/dfareporting/v2.6/reference/placements/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="id">Placement ID.</param>
        /// <param name="body">A valid dfareporting v2.6 body.</param>
        /// <returns>PlacementResponse</returns>
        public static Placement Patch(dfareportingService service, string profileId, string id, Placement body)
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
                return service.Placements.Patch(body, profileId, id).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Placements.Patch failed.", ex);
            }
        }


        /// <summary>
        /// Updates an existing placement. 
        /// Documentation https://developers.google.com/dfareporting/v2.6/reference/placements/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="body">A valid dfareporting v2.6 body.</param>
        /// <returns>PlacementResponse</returns>
        public static Placement Update(dfareportingService service, string profileId, Placement body)
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
                return service.Placements.Update(body, profileId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Placements.Update failed.", ex);
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