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
//     Build date: 01/02/2017 22:31:54
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the AndroidPublisher v2 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Lets Android application developers access their Google Play accounts.
// API Documentation Link https://developers.google.com/android-publisher
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/AndroidPublisher/v2/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.AndroidPublisher.v2/ 
// Install Command: PM>  Install-Package Google.Apis.AndroidPublisher.v2
//
//------------------------------------------------------------------------------  
using Google.Apis.AndroidPublisher.v2;
using Google.Apis.AndroidPublisher.v2.Data;
using System;

namespace GoogleSamplecSharpSample.AndroidPublisherv2.Methods
{
  
    public static class ListingsSample
    {


        /// <summary>
        /// Deletes the specified localized store listing from an edit. 
        /// Documentation https://developers.google.com/androidpublisher/v2/reference/listings/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated AndroidPublisher service.</param>  
        /// <param name="packageName">Unique identifier for the Android app that is being updated; for example, "com.spiffygame".</param>
        /// <param name="editId">Unique identifier for this edit.</param>
        /// <param name="language">The language code (a BCP-47 language tag) of the localized listing to read or modify. For example, to select Austrian German, pass "de-AT".</param>
        public static void Delete(AndroidPublisherService service, string packageName, string editId, string language)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (packageName == null)
                    throw new ArgumentNullException(packageName);
                if (editId == null)
                    throw new ArgumentNullException(editId);
                if (language == null)
                    throw new ArgumentNullException(language);

                // Make the request.
                return service.Listings.Delete(packageName, editId, language).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Listings.Delete failed.", ex);
            }
        }


        /// <summary>
        /// Deletes all localized listings from an edit. 
        /// Documentation https://developers.google.com/androidpublisher/v2/reference/listings/deleteall
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated AndroidPublisher service.</param>  
        /// <param name="packageName">Unique identifier for the Android app that is being updated; for example, "com.spiffygame".</param>
        /// <param name="editId">Unique identifier for this edit.</param>
        public static void Deleteall(AndroidPublisherService service, string packageName, string editId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (packageName == null)
                    throw new ArgumentNullException(packageName);
                if (editId == null)
                    throw new ArgumentNullException(editId);

                // Make the request.
                return service.Listings.Deleteall(packageName, editId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Listings.Deleteall failed.", ex);
            }
        }


        /// <summary>
        /// Fetches information about a localized store listing. 
        /// Documentation https://developers.google.com/androidpublisher/v2/reference/listings/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated AndroidPublisher service.</param>  
        /// <param name="packageName">Unique identifier for the Android app that is being updated; for example, "com.spiffygame".</param>
        /// <param name="editId">Unique identifier for this edit.</param>
        /// <param name="language">The language code (a BCP-47 language tag) of the localized listing to read or modify. For example, to select Austrian German, pass "de-AT".</param>
        /// <returns>ListingResponse</returns>
        public static Listing Get(AndroidPublisherService service, string packageName, string editId, string language)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (packageName == null)
                    throw new ArgumentNullException(packageName);
                if (editId == null)
                    throw new ArgumentNullException(editId);
                if (language == null)
                    throw new ArgumentNullException(language);

                // Make the request.
                return service.Listings.Get(packageName, editId, language).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Listings.Get failed.", ex);
            }
        }


        /// <summary>
        /// Returns all of the localized store listings attached to this edit. 
        /// Documentation https://developers.google.com/androidpublisher/v2/reference/listings/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated AndroidPublisher service.</param>  
        /// <param name="packageName">Unique identifier for the Android app that is being updated; for example, "com.spiffygame".</param>
        /// <param name="editId">Unique identifier for this edit.</param>
        /// <returns>ListingsListResponseResponse</returns>
        public static ListingsListResponse List(AndroidPublisherService service, string packageName, string editId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (packageName == null)
                    throw new ArgumentNullException(packageName);
                if (editId == null)
                    throw new ArgumentNullException(editId);

                // Make the request.
                return service.Listings.List(packageName, editId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Listings.List failed.", ex);
            }
        }


        /// <summary>
        /// Creates or updates a localized store listing. This method supports patch semantics. 
        /// Documentation https://developers.google.com/androidpublisher/v2/reference/listings/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated AndroidPublisher service.</param>  
        /// <param name="packageName">Unique identifier for the Android app that is being updated; for example, "com.spiffygame".</param>
        /// <param name="editId">Unique identifier for this edit.</param>
        /// <param name="language">The language code (a BCP-47 language tag) of the localized listing to read or modify. For example, to select Austrian German, pass "de-AT".</param>
        /// <param name="body">A valid AndroidPublisher v2 body.</param>
        /// <returns>ListingResponse</returns>
        public static Listing Patch(AndroidPublisherService service, string packageName, string editId, string language, Listing body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (packageName == null)
                    throw new ArgumentNullException(packageName);
                if (editId == null)
                    throw new ArgumentNullException(editId);
                if (language == null)
                    throw new ArgumentNullException(language);

                // Make the request.
                return service.Listings.Patch(body, packageName, editId, language).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Listings.Patch failed.", ex);
            }
        }


        /// <summary>
        /// Creates or updates a localized store listing. 
        /// Documentation https://developers.google.com/androidpublisher/v2/reference/listings/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated AndroidPublisher service.</param>  
        /// <param name="packageName">Unique identifier for the Android app that is being updated; for example, "com.spiffygame".</param>
        /// <param name="editId">Unique identifier for this edit.</param>
        /// <param name="language">The language code (a BCP-47 language tag) of the localized listing to read or modify. For example, to select Austrian German, pass "de-AT".</param>
        /// <param name="body">A valid AndroidPublisher v2 body.</param>
        /// <returns>ListingResponse</returns>
        public static Listing Update(AndroidPublisherService service, string packageName, string editId, string language, Listing body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (packageName == null)
                    throw new ArgumentNullException(packageName);
                if (editId == null)
                    throw new ArgumentNullException(editId);
                if (language == null)
                    throw new ArgumentNullException(language);

                // Make the request.
                return service.Listings.Update(body, packageName, editId, language).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Listings.Update failed.", ex);
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