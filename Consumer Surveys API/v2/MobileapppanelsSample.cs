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
//     Build date: 01/02/2017 22:32:22
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the ConsumerSurveys v2 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Creates and conducts surveys, lists the surveys that an authenticated user owns, and retrieves survey results and information about specified surveys.
// API Documentation Link 
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/ConsumerSurveys/v2/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.ConsumerSurveys.v2/ 
// Install Command: PM>  Install-Package Google.Apis.ConsumerSurveys.v2
//
//------------------------------------------------------------------------------  
using Google.Apis.ConsumerSurveys.v2;
using Google.Apis.ConsumerSurveys.v2.Data;
using System;

namespace GoogleSamplecSharpSample.ConsumerSurveysv2.Methods
{
  
    public static class MobileapppanelsSample
    {


        /// <summary>
        /// Retrieves a MobileAppPanel that is available to the authenticated user. 
        /// Documentation https://developers.google.com/consumersurveys/v2/reference/mobileapppanels/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated ConsumerSurveys service.</param>  
        /// <param name="panelId">External URL ID for the panel.</param>
        /// <returns>MobileAppPanelResponse</returns>
        public static MobileAppPanel Get(ConsumerSurveysService service, string panelId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (panelId == null)
                    throw new ArgumentNullException(panelId);

                // Make the request.
                return service.Mobileapppanels.Get(panelId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Mobileapppanels.Get failed.", ex);
            }
        }

        public class MobileapppanelsListOptionalParms
        {
            /// NA
            public int MaxResults { get; set; }  
            /// NA
            public int StartIndex { get; set; }  
            /// NA
            public string Token { get; set; }  
        
        }
 
        /// <summary>
        /// Lists the MobileAppPanels available to the authenticated user. 
        /// Documentation https://developers.google.com/consumersurveys/v2/reference/mobileapppanels/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated ConsumerSurveys service.</param>  
        /// <param name="optional">Optional paramaters.</param>        /// <returns>MobileAppPanelsListResponseResponse</returns>
        public static MobileAppPanelsListResponse List(ConsumerSurveysService service, MobileapppanelsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Building the initial request.
                var request = service.Mobileapppanels.List();

                // Applying optional parameters to the request.                
                request = (MobileapppanelsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Mobileapppanels.List failed.", ex);
            }
        }


        /// <summary>
        /// Updates a MobileAppPanel. Currently the only property that can be updated is the owners property. 
        /// Documentation https://developers.google.com/consumersurveys/v2/reference/mobileapppanels/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated ConsumerSurveys service.</param>  
        /// <param name="panelId">External URL ID for the panel.</param>
        /// <param name="body">A valid ConsumerSurveys v2 body.</param>
        /// <returns>MobileAppPanelResponse</returns>
        public static MobileAppPanel Update(ConsumerSurveysService service, string panelId, MobileAppPanel body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (panelId == null)
                    throw new ArgumentNullException(panelId);

                // Make the request.
                return service.Mobileapppanels.Update(body, panelId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Mobileapppanels.Update failed.", ex);
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