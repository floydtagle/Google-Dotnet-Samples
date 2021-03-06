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
//     Build date: 01/02/2017 22:33:46
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the mirror v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Interacts with Glass users via the timeline.
// API Documentation Link https://developers.google.com/glass
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/mirror/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.mirror.v1/ 
// Install Command: PM>  Install-Package Google.Apis.mirror.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.mirror.v1;
using Google.Apis.mirror.v1.Data;
using System;

namespace GoogleSamplecSharpSample.mirrorv1.Methods
{
  
    public static class AttachmentsSample
    {


        /// <summary>
        /// Deletes an attachment from a timeline item. 
        /// Documentation https://developers.google.com/mirror/v1/reference/attachments/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated mirror service.</param>  
        /// <param name="itemId">The ID of the timeline item the attachment belongs to.</param>
        /// <param name="attachmentId">The ID of the attachment.</param>
        public static void Delete(mirrorService service, string itemId, string attachmentId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (itemId == null)
                    throw new ArgumentNullException(itemId);
                if (attachmentId == null)
                    throw new ArgumentNullException(attachmentId);

                // Make the request.
                return service.Attachments.Delete(itemId, attachmentId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Attachments.Delete failed.", ex);
            }
        }


        /// <summary>
        /// Retrieves an attachment on a timeline item by item ID and attachment ID. 
        /// Documentation https://developers.google.com/mirror/v1/reference/attachments/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated mirror service.</param>  
        /// <param name="itemId">The ID of the timeline item the attachment belongs to.</param>
        /// <param name="attachmentId">The ID of the attachment.</param>
        /// <returns>AttachmentResponse</returns>
        public static Attachment Get(mirrorService service, string itemId, string attachmentId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (itemId == null)
                    throw new ArgumentNullException(itemId);
                if (attachmentId == null)
                    throw new ArgumentNullException(attachmentId);

                // Make the request.
                return service.Attachments.Get(itemId, attachmentId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Attachments.Get failed.", ex);
            }
        }


        /// <summary>
        /// Adds a new attachment to a timeline item. 
        /// Documentation https://developers.google.com/mirror/v1/reference/attachments/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated mirror service.</param>  
        /// <param name="itemId">The ID of the timeline item the attachment belongs to.</param>
        /// <returns>AttachmentResponse</returns>
        public static Attachment Insert(mirrorService service, string itemId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (itemId == null)
                    throw new ArgumentNullException(itemId);

                // Make the request.
                return service.Attachments.Insert(itemId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Attachments.Insert failed.", ex);
            }
        }


        /// <summary>
        /// Returns a list of attachments for a timeline item. 
        /// Documentation https://developers.google.com/mirror/v1/reference/attachments/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated mirror service.</param>  
        /// <param name="itemId">The ID of the timeline item whose attachments should be listed.</param>
        /// <returns>AttachmentsListResponseResponse</returns>
        public static AttachmentsListResponse List(mirrorService service, string itemId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (itemId == null)
                    throw new ArgumentNullException(itemId);

                // Make the request.
                return service.Attachments.List(itemId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Attachments.List failed.", ex);
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