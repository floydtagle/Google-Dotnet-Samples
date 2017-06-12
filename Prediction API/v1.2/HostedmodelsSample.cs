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
//     Build date: 01/02/2017 22:33:59
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the prediction v1.2 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Lets you access a cloud hosted machine learning service that makes it easy to build smart apps
// API Documentation Link https://developers.google.com/prediction/docs/developer-guide
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/prediction/v1_2/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.prediction.v1_2/ 
// Install Command: PM>  Install-Package Google.Apis.prediction.v1_2
//
//------------------------------------------------------------------------------  
using Google.Apis.prediction.v1_2;
using Google.Apis.prediction.v1_2.Data;
using System;

namespace GoogleSamplecSharpSample.predictionv1_2.Methods
{
  
    public static class HostedmodelsSample
    {


        /// <summary>
        /// Submit input and request an output against a hosted model 
        /// Documentation https://developers.google.com/prediction/v1.2/reference/hostedmodels/predict
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated prediction service.</param>  
        /// <param name="hostedModelName">The name of a hosted model</param>
        /// <param name="body">A valid prediction v1.2 body.</param>
        /// <returns>OutputResponse</returns>
        public static Output Predict(predictionService service, string hostedModelName, Input body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (hostedModelName == null)
                    throw new ArgumentNullException(hostedModelName);

                // Make the request.
                return service.Hostedmodels.Predict(body, hostedModelName).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Hostedmodels.Predict failed.", ex);
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