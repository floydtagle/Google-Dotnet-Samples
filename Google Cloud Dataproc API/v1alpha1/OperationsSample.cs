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
//     Build date: 01/02/2017 22:33:14
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the dataproc v1alpha1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: An API for managing Hadoop-based clusters and jobs on Google Cloud Platform.
// API Documentation Link https://cloud.google.com/dataproc/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/dataproc/v1alpha1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.dataproc.v1alpha1/ 
// Install Command: PM>  Install-Package Google.Apis.dataproc.v1alpha1
//
//------------------------------------------------------------------------------  
using Google.Apis.dataproc.v1alpha1;
using Google.Apis.dataproc.v1alpha1.Data;
using System;

namespace GoogleSamplecSharpSample.dataprocv1alpha1.Methods
{
  
    public static class OperationsSample
    {


        /// <summary>
        /// Gets the latest state of a long-running operation. Clients may use this method to poll the operation result at intervals as recommended by the API service. 
        /// Documentation https://developers.google.com/dataproc/v1alpha1/reference/operations/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated dataproc service.</param>  
        /// <param name="name">The operation resource name.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Get(dataprocService service, string name)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Make the request.
                return service.Operations.Get(name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Operations.Get failed.", ex);
            }
        }

        public class OperationsListOptionalParms
        {
            /// [Required] A JSON object that contains filters for the list operation, in the format {"key1":"value1","key2":"value2", ..., }. Possible keys include project_id, cluster_name, and operation_state_matcher. If project_id is set, requests the list of operations that belong to the specified Google Cloud Platform project ID. This key is required. If cluster_name is set, requests the list of operations that were submitted to the specified cluster name. This key is optional. If operation_state_matcher is set, requests the list of operations that match one of the following status options: ALL, ACTIVE, or NON_ACTIVE.
            public string Filter { get; set; }  
            /// The standard List page size.
            public int PageSize { get; set; }  
            /// The standard List page token.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Lists operations that match the specified filter in the request. If the server doesn't support this method, it returns `google.rpc.Code.UNIMPLEMENTED`. 
        /// Documentation https://developers.google.com/dataproc/v1alpha1/reference/operations/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated dataproc service.</param>  
        /// <param name="name">The operation collection name.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>ListOperationsResponseResponse</returns>
        public static ListOperationsResponse List(dataprocService service, string name, OperationsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Building the initial request.
                var request = service.Operations.List(name);

                // Applying optional parameters to the request.                
                request = (OperationsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Operations.List failed.", ex);
            }
        }


        /// <summary>
        /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to cancel the operation, but success is not guaranteed. If the server doesn't support this method, it returns `google.rpc.Code.UNIMPLEMENTED`. Clients may use [Operations.GetOperation] or other methods to check whether the cancellation succeeded or the operation completed despite cancellation. 
        /// Documentation https://developers.google.com/dataproc/v1alpha1/reference/operations/cancel
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated dataproc service.</param>  
        /// <param name="name">The name of the operation resource to be cancelled.</param>
        /// <param name="body">A valid dataproc v1alpha1 body.</param>
        /// <returns>EmptyResponse</returns>
        public static Empty Cancel(dataprocService service, string name, CancelOperationRequest body)
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
                return service.Operations.Cancel(body, name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Operations.Cancel failed.", ex);
            }
        }


        /// <summary>
        /// Deletes a long-running operation. It indicates the client is no longer interested in the operation result. It does not cancel the operation. 
        /// Documentation https://developers.google.com/dataproc/v1alpha1/reference/operations/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated dataproc service.</param>  
        /// <param name="name">The name of the operation resource to be deleted.</param>
        /// <returns>EmptyResponse</returns>
        public static Empty Delete(dataprocService service, string name)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Make the request.
                return service.Operations.Delete(name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Operations.Delete failed.", ex);
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