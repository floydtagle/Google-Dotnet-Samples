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
//     Build date: 01/02/2017 22:33:48
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the CloudMachineLearning v1beta1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: An API to enable creating and using machine learning models.
// API Documentation Link https://cloud.google.com/ml/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/CloudMachineLearning/v1beta1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.CloudMachineLearning.v1beta1/ 
// Install Command: PM>  Install-Package Google.Apis.CloudMachineLearning.v1beta1
//
//------------------------------------------------------------------------------  
using Google.Apis.CloudMachineLearning.v1beta1;
using Google.Apis.CloudMachineLearning.v1beta1.Data;
using System;

namespace GoogleSamplecSharpSample.CloudMachineLearningv1beta1.Methods
{
  
    public static class OperationsSample
    {


        /// <summary>
        /// Gets the latest state of a long-running operation.  Clients can use this
method to poll the operation result at intervals as recommended by the API
service. 
        /// Documentation https://developers.google.com/cloudmachinelearning/v1beta1/reference/operations/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated CloudMachineLearning service.</param>  
        /// <param name="name">The name of the operation resource.</param>
        /// <returns>GoogleLongrunning__OperationResponse</returns>
        public static GoogleLongrunning__Operation Get(CloudMachineLearningService service, string name)
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
            /// The standard list page size.
            public int PageSize { get; set; }  
            /// The standard list filter.
            public string Filter { get; set; }  
            /// The standard list page token.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Lists operations that match the specified filter in the request. If the
server doesn't support this method, it returns `UNIMPLEMENTED`.

NOTE: the `name` binding below allows API services to override the binding
to use different resource name schemes, such as `users/*/operations`. 
        /// Documentation https://developers.google.com/cloudmachinelearning/v1beta1/reference/operations/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated CloudMachineLearning service.</param>  
        /// <param name="name">The name of the operation collection.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>GoogleLongrunning__ListOperationsResponseResponse</returns>
        public static GoogleLongrunning__ListOperationsResponse List(CloudMachineLearningService service, string name, OperationsListOptionalParms optional = null)
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
        /// Deletes a long-running operation. This method indicates that the client is
no longer interested in the operation result. It does not cancel the
operation. If the server doesn't support this method, it returns
`google.rpc.Code.UNIMPLEMENTED`. 
        /// Documentation https://developers.google.com/cloudmachinelearning/v1beta1/reference/operations/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated CloudMachineLearning service.</param>  
        /// <param name="name">The name of the operation resource to be deleted.</param>
        /// <returns>GoogleProtobuf__EmptyResponse</returns>
        public static GoogleProtobuf__Empty Delete(CloudMachineLearningService service, string name)
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


        /// <summary>
        /// Starts asynchronous cancellation on a long-running operation.  The server
makes a best effort to cancel the operation, but success is not
guaranteed.  If the server doesn't support this method, it returns
`google.rpc.Code.UNIMPLEMENTED`.  Clients can use
Operations.GetOperation or
other methods to check whether the cancellation succeeded or whether the
operation completed despite cancellation. On successful cancellation,
the operation is not deleted; instead, it becomes an operation with
an Operation.error value with a google.rpc.Status.code of 1,
corresponding to `Code.CANCELLED`. 
        /// Documentation https://developers.google.com/cloudmachinelearning/v1beta1/reference/operations/cancel
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated CloudMachineLearning service.</param>  
        /// <param name="name">The name of the operation resource to be cancelled.</param>
        /// <returns>GoogleProtobuf__EmptyResponse</returns>
        public static GoogleProtobuf__Empty Cancel(CloudMachineLearningService service, string name)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Make the request.
                return service.Operations.Cancel(name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Operations.Cancel failed.", ex);
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