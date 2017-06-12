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
//     Build date: 01/02/2017 22:32:52
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the fitness v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Stores and accesses user data in the fitness store from apps on any platform.
// API Documentation Link https://developers.google.com/fit/rest/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/fitness/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.fitness.v1/ 
// Install Command: PM>  Install-Package Google.Apis.fitness.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.fitness.v1;
using Google.Apis.fitness.v1.Data;
using System;

namespace GoogleSamplecSharpSample.fitnessv1.Methods
{
  
    public static class SessionsSample
    {

        public class SessionsDeleteOptionalParms
        {
            /// The client's current time in milliseconds since epoch.
            public string CurrentTimeMillis { get; set; }  
        
        }
 
        /// <summary>
        /// Deletes a session specified by the given session ID. 
        /// Documentation https://developers.google.com/fitness/v1/reference/sessions/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated fitness service.</param>  
        /// <param name="userId">Delete a session for the person identified. Use me to indicate the authenticated user. Only me is supported at this time.</param>
        /// <param name="sessionId">The ID of the session to be deleted.</param>
        /// <param name="optional">Optional paramaters.</param>        public static void Delete(fitnessService service, string userId, string sessionId, SessionsDeleteOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (userId == null)
                    throw new ArgumentNullException(userId);
                if (sessionId == null)
                    throw new ArgumentNullException(sessionId);

                // Building the initial request.
                var request = service.Sessions.Delete(userId, sessionId);

                // Applying optional parameters to the request.                
                request = (SessionsResource.DeleteRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Sessions.Delete failed.", ex);
            }
        }

        public class SessionsListOptionalParms
        {
            /// An RFC3339 timestamp. Only sessions ending between the start and end times will be included in the response.
            public string EndTime { get; set; }  
            /// If true, deleted sessions will be returned. When set to true, sessions returned in this response will only have an ID and will not have any other fields.
            public bool IncludeDeleted { get; set; }  
            /// The continuation token, which is used to page through large result sets. To get the next page of results, set this parameter to the value of nextPageToken from the previous response.
            public string PageToken { get; set; }  
            /// An RFC3339 timestamp. Only sessions ending between the start and end times will be included in the response.
            public string StartTime { get; set; }  
        
        }
 
        /// <summary>
        /// Lists sessions previously created. 
        /// Documentation https://developers.google.com/fitness/v1/reference/sessions/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated fitness service.</param>  
        /// <param name="userId">List sessions for the person identified. Use me to indicate the authenticated user. Only me is supported at this time.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>ListSessionsResponseResponse</returns>
        public static ListSessionsResponse List(fitnessService service, string userId, SessionsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (userId == null)
                    throw new ArgumentNullException(userId);

                // Building the initial request.
                var request = service.Sessions.List(userId);

                // Applying optional parameters to the request.                
                request = (SessionsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Sessions.List failed.", ex);
            }
        }

        public class SessionsUpdateOptionalParms
        {
            /// The client's current time in milliseconds since epoch.
            public string CurrentTimeMillis { get; set; }  
        
        }
 
        /// <summary>
        /// Updates or insert a given session. 
        /// Documentation https://developers.google.com/fitness/v1/reference/sessions/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated fitness service.</param>  
        /// <param name="userId">Create sessions for the person identified. Use me to indicate the authenticated user. Only me is supported at this time.</param>
        /// <param name="sessionId">The ID of the session to be created.</param>
        /// <param name="body">A valid fitness v1 body.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>SessionResponse</returns>
        public static Session Update(fitnessService service, string userId, string sessionId, Session body, SessionsUpdateOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (userId == null)
                    throw new ArgumentNullException(userId);
                if (sessionId == null)
                    throw new ArgumentNullException(sessionId);

                // Building the initial request.
                var request = service.Sessions.Update(body, userId, sessionId);

                // Applying optional parameters to the request.                
                request = (SessionsResource.UpdateRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Sessions.Update failed.", ex);
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