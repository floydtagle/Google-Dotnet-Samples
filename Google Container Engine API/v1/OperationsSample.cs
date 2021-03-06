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
//     Build date: 01/02/2017 22:33:12
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the container v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Builds and manages clusters that run container-based applications, powered by open source Kubernetes technology.
// API Documentation Link https://cloud.google.com/container-engine/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/container/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.container.v1/ 
// Install Command: PM>  Install-Package Google.Apis.container.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.container.v1;
using Google.Apis.container.v1.Data;
using System;

namespace GoogleSamplecSharpSample.containerv1.Methods
{
  
    public static class OperationsSample
    {


        /// <summary>
        /// Lists all operations in a project in a specific zone or all zones. 
        /// Documentation https://developers.google.com/container/v1/reference/operations/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated container service.</param>  
        /// <param name="projectId">The Google Developers Console [project ID or project number](https://support.google.com/cloud/answer/6158840).</param>
        /// <param name="zone">The name of the Google Compute Engine [zone](/compute/docs/zones#available) to return operations for, or `-` for all zones.</param>
        /// <returns>ListOperationsResponseResponse</returns>
        public static ListOperationsResponse List(containerService service, string projectId, string zone)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (projectId == null)
                    throw new ArgumentNullException(projectId);
                if (zone == null)
                    throw new ArgumentNullException(zone);

                // Make the request.
                return service.Operations.List(projectId, zone).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Operations.List failed.", ex);
            }
        }


        /// <summary>
        /// Gets the specified operation. 
        /// Documentation https://developers.google.com/container/v1/reference/operations/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated container service.</param>  
        /// <param name="projectId">The Google Developers Console [project ID or project number](https://support.google.com/cloud/answer/6158840).</param>
        /// <param name="zone">The name of the Google Compute Engine [zone](/compute/docs/zones#available) in which the cluster resides.</param>
        /// <param name="operationId">The server-assigned `name` of the operation.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Get(containerService service, string projectId, string zone, string operationId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (projectId == null)
                    throw new ArgumentNullException(projectId);
                if (zone == null)
                    throw new ArgumentNullException(zone);
                if (operationId == null)
                    throw new ArgumentNullException(operationId);

                // Make the request.
                return service.Operations.Get(projectId, zone, operationId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Operations.Get failed.", ex);
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