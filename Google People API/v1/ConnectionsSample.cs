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
//     Build date: 01/02/2017 22:33:25
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the people v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: The Google People API service gives access to information about profiles and contacts.
// API Documentation Link https://developers.google.com/people/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/people/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.people.v1/ 
// Install Command: PM>  Install-Package Google.Apis.people.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.people.v1;
using Google.Apis.people.v1.Data;
using System;

namespace GoogleSamplecSharpSample.peoplev1.Methods
{
  
    public static class ConnectionsSample
    {

        public class ConnectionsListOptionalParms
        {
            /// The token of the page to be returned.
            public string PageToken { get; set; }  
            /// The number of connections to include in the response. Valid values are between 1 and 500, inclusive. Defaults to 100.
            public int PageSize { get; set; }  
            /// The order in which the connections should be sorted. Defaults to `LAST_MODIFIED_ASCENDING`.
            public string SortOrder { get; set; }  
            /// A sync token, returned by a previous call to `people.connections.list`. Only resources changed since the sync token was created are returned.
            public string SyncToken { get; set; }  
            /// Comma-separated list of fields to be included in the response. Omitting this field will include all fields. Each path should start with `person.`: for example, `person.names` or `person.photos`.
            public string RequestMask.includeField { get; set; }  
        
        }
 
        /// <summary>
        /// Provides a list of the authenticated user's contacts merged with any linked profiles. 
        /// Documentation https://developers.google.com/people/v1/reference/connections/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated people service.</param>  
        /// <param name="resourceName">The resource name to return connections for. Only `people/me` is valid.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>ListConnectionsResponseResponse</returns>
        public static ListConnectionsResponse List(peopleService service, string resourceName, ConnectionsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (resourceName == null)
                    throw new ArgumentNullException(resourceName);

                // Building the initial request.
                var request = service.Connections.List(resourceName);

                // Applying optional parameters to the request.                
                request = (ConnectionsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Connections.List failed.", ex);
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