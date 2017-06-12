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
//     Build date: 01/02/2017 22:33:31
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the storagetransfer v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Transfers data from external data sources to a Google Cloud Storage bucket or between Google Cloud Storage buckets.
// API Documentation Link https://cloud.google.com/storage/transfer
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/storagetransfer/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.storagetransfer.v1/ 
// Install Command: PM>  Install-Package Google.Apis.storagetransfer.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.storagetransfer.v1;
using Google.Apis.storagetransfer.v1.Data;
using System;

namespace GoogleSamplecSharpSample.storagetransferv1.Methods
{
  
    public static class TransferOperationsSample
    {


        /// <summary>
        /// Pauses a transfer operation. 
        /// Documentation https://developers.google.com/storagetransfer/v1/reference/transferOperations/pause
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated storagetransfer service.</param>  
        /// <param name="name">The name of the transfer operation. Required.</param>
        /// <param name="body">A valid storagetransfer v1 body.</param>
        /// <returns>EmptyResponse</returns>
        public static Empty Pause(storagetransferService service, string name, PauseTransferOperationRequest body)
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
                return service.TransferOperations.Pause(body, name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TransferOperations.Pause failed.", ex);
            }
        }


        /// <summary>
        /// Resumes a transfer operation that is paused. 
        /// Documentation https://developers.google.com/storagetransfer/v1/reference/transferOperations/resume
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated storagetransfer service.</param>  
        /// <param name="name">The name of the transfer operation. Required.</param>
        /// <param name="body">A valid storagetransfer v1 body.</param>
        /// <returns>EmptyResponse</returns>
        public static Empty Resume(storagetransferService service, string name, ResumeTransferOperationRequest body)
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
                return service.TransferOperations.Resume(body, name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TransferOperations.Resume failed.", ex);
            }
        }


        /// <summary>
        /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation result at intervals as recommended by the API service. 
        /// Documentation https://developers.google.com/storagetransfer/v1/reference/transferOperations/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated storagetransfer service.</param>  
        /// <param name="name">The name of the operation resource.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Get(storagetransferService service, string name)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Make the request.
                return service.TransferOperations.Get(name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TransferOperations.Get failed.", ex);
            }
        }

        public class TransferOperationsListOptionalParms
        {
            /// The standard list filter.
            public string Filter { get; set; }  
            /// The standard list page size.
            public int PageSize { get; set; }  
            /// The standard list page token.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Lists operations that match the specified filter in the request. If the server doesn't support this method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding below allows API services to override the binding to use different resource name schemes, such as `users/*/operations`. 
        /// Documentation https://developers.google.com/storagetransfer/v1/reference/transferOperations/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated storagetransfer service.</param>  
        /// <param name="name">The value `transferOperations`.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>ListOperationsResponseResponse</returns>
        public static ListOperationsResponse List(storagetransferService service, string name, TransferOperationsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Building the initial request.
                var request = service.TransferOperations.List(name);

                // Applying optional parameters to the request.                
                request = (TransferOperationsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TransferOperations.List failed.", ex);
            }
        }


        /// <summary>
        /// Cancels a transfer. Use the get method to check whether the cancellation succeeded or whether the operation completed despite cancellation. 
        /// Documentation https://developers.google.com/storagetransfer/v1/reference/transferOperations/cancel
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated storagetransfer service.</param>  
        /// <param name="name">The name of the operation resource to be cancelled.</param>
        /// <returns>EmptyResponse</returns>
        public static Empty Cancel(storagetransferService service, string name)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Make the request.
                return service.TransferOperations.Cancel(name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TransferOperations.Cancel failed.", ex);
            }
        }


        /// <summary>
        /// This method is not supported and the server returns `UNIMPLEMENTED`. 
        /// Documentation https://developers.google.com/storagetransfer/v1/reference/transferOperations/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated storagetransfer service.</param>  
        /// <param name="name">The name of the operation resource to be deleted.</param>
        /// <returns>EmptyResponse</returns>
        public static Empty Delete(storagetransferService service, string name)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Make the request.
                return service.TransferOperations.Delete(name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TransferOperations.Delete failed.", ex);
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