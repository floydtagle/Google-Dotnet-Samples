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
//     Build date: 01/02/2017 22:35:02
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the YouTubeAnalytics v1beta1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Retrieves your YouTube Analytics data.
// API Documentation Link http://developers.google.com/youtube/analytics/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/YouTubeAnalytics/v1beta1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.YouTubeAnalytics.v1beta1/ 
// Install Command: PM>  Install-Package Google.Apis.YouTubeAnalytics.v1beta1
//
//------------------------------------------------------------------------------  
using Google.Apis.YouTubeAnalytics.v1beta1;
using Google.Apis.YouTubeAnalytics.v1beta1.Data;
using System;

namespace GoogleSamplecSharpSample.YouTubeAnalyticsv1beta1.Methods
{
  
    public static class GroupItemsSample
    {

        public class GroupItemsDeleteOptionalParms
        {
            /// Note: This parameter is intended exclusively for YouTube content partners.

The onBehalfOfContentOwner parameter indicates that the request's authorization credentials identify a YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This parameter is intended for YouTube content partners that own and manage many different YouTube channels. It allows content owners to authenticate once and get access to all their video and channel data, without having to provide authentication credentials for each individual channel. The CMS account that the user authenticates with must be linked to the specified YouTube content owner.
            public string OnBehalfOfContentOwner { get; set; }  
        
        }
 
        /// <summary>
        /// Removes an item from a group. 
        /// Documentation https://developers.google.com/youtubeanalytics/v1beta1/reference/groupItems/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated YouTubeAnalytics service.</param>  
        /// <param name="id">The id parameter specifies the YouTube group item ID for the group that is being deleted.</param>
        /// <param name="optional">Optional paramaters.</param>        public static void Delete(YouTubeAnalyticsService service, string id, GroupItemsDeleteOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (id == null)
                    throw new ArgumentNullException(id);

                // Building the initial request.
                var request = service.GroupItems.Delete(id);

                // Applying optional parameters to the request.                
                request = (GroupItemsResource.DeleteRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request GroupItems.Delete failed.", ex);
            }
        }

        public class GroupItemsInsertOptionalParms
        {
            /// Note: This parameter is intended exclusively for YouTube content partners.

The onBehalfOfContentOwner parameter indicates that the request's authorization credentials identify a YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This parameter is intended for YouTube content partners that own and manage many different YouTube channels. It allows content owners to authenticate once and get access to all their video and channel data, without having to provide authentication credentials for each individual channel. The CMS account that the user authenticates with must be linked to the specified YouTube content owner.
            public string OnBehalfOfContentOwner { get; set; }  
        
        }
 
        /// <summary>
        /// Creates a group item. 
        /// Documentation https://developers.google.com/youtubeanalytics/v1beta1/reference/groupItems/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated YouTubeAnalytics service.</param>  
        /// <param name="body">A valid YouTubeAnalytics v1beta1 body.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>GroupItemResponse</returns>
        public static GroupItem Insert(YouTubeAnalyticsService service, GroupItem body, GroupItemsInsertOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Building the initial request.
                var request = service.GroupItems.Insert(body);

                // Applying optional parameters to the request.                
                request = (GroupItemsResource.InsertRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request GroupItems.Insert failed.", ex);
            }
        }

        public class GroupItemsListOptionalParms
        {
            /// Note: This parameter is intended exclusively for YouTube content partners.

The onBehalfOfContentOwner parameter indicates that the request's authorization credentials identify a YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This parameter is intended for YouTube content partners that own and manage many different YouTube channels. It allows content owners to authenticate once and get access to all their video and channel data, without having to provide authentication credentials for each individual channel. The CMS account that the user authenticates with must be linked to the specified YouTube content owner.
            public string OnBehalfOfContentOwner { get; set; }  
        
        }
 
        /// <summary>
        /// Returns a collection of group items that match the API request parameters. 
        /// Documentation https://developers.google.com/youtubeanalytics/v1beta1/reference/groupItems/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated YouTubeAnalytics service.</param>  
        /// <param name="groupId">The id parameter specifies the unique ID of the group for which you want to retrieve group items.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>GroupItemListResponseResponse</returns>
        public static GroupItemListResponse List(YouTubeAnalyticsService service, string groupId, GroupItemsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (groupId == null)
                    throw new ArgumentNullException(groupId);

                // Building the initial request.
                var request = service.GroupItems.List(groupId);

                // Applying optional parameters to the request.                
                request = (GroupItemsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request GroupItems.List failed.", ex);
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