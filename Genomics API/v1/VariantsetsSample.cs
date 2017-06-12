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
//     Build date: 01/02/2017 22:33:19
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the genomics v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Stores, processes, explores and shares genomic data.
// API Documentation Link https://cloud.google.com/genomics/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/genomics/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.genomics.v1/ 
// Install Command: PM>  Install-Package Google.Apis.genomics.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.genomics.v1;
using Google.Apis.genomics.v1.Data;
using System;

namespace GoogleSamplecSharpSample.genomicsv1.Methods
{
  
    public static class VariantsetsSample
    {


        /// <summary>
        /// Creates a new variant set. For the definitions of variant sets and other genomics resources, see [Fundamentals of Google Genomics](https://cloud.google.com/genomics/fundamentals-of-google-genomics) The provided variant set must have a valid `datasetId` set - all other fields are optional. Note that the `id` field will be ignored, as this is assigned by the server. 
        /// Documentation https://developers.google.com/genomics/v1/reference/variantsets/create
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated genomics service.</param>  
        /// <param name="body">A valid genomics v1 body.</param>
        /// <returns>VariantSetResponse</returns>
        public static VariantSet Create(genomicsService service, VariantSet body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Variantsets.Create(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Variantsets.Create failed.", ex);
            }
        }


        /// <summary>
        /// Exports variant set data to an external destination. For the definitions of variant sets and other genomics resources, see [Fundamentals of Google Genomics](https://cloud.google.com/genomics/fundamentals-of-google-genomics) 
        /// Documentation https://developers.google.com/genomics/v1/reference/variantsets/export
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated genomics service.</param>  
        /// <param name="variantSetId">Required. The ID of the variant set that contains variant data which should be exported. The caller must have READ access to this variant set.</param>
        /// <param name="body">A valid genomics v1 body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Export(genomicsService service, string variantSetId, ExportVariantSetRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (variantSetId == null)
                    throw new ArgumentNullException(variantSetId);

                // Make the request.
                return service.Variantsets.Export(body, variantSetId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Variantsets.Export failed.", ex);
            }
        }


        /// <summary>
        /// Gets a variant set by ID. For the definitions of variant sets and other genomics resources, see [Fundamentals of Google Genomics](https://cloud.google.com/genomics/fundamentals-of-google-genomics) 
        /// Documentation https://developers.google.com/genomics/v1/reference/variantsets/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated genomics service.</param>  
        /// <param name="variantSetId">Required. The ID of the variant set.</param>
        /// <returns>VariantSetResponse</returns>
        public static VariantSet Get(genomicsService service, string variantSetId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (variantSetId == null)
                    throw new ArgumentNullException(variantSetId);

                // Make the request.
                return service.Variantsets.Get(variantSetId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Variantsets.Get failed.", ex);
            }
        }


        /// <summary>
        /// Returns a list of all variant sets matching search criteria. For the definitions of variant sets and other genomics resources, see [Fundamentals of Google Genomics](https://cloud.google.com/genomics/fundamentals-of-google-genomics) Implements [GlobalAllianceApi.searchVariantSets](https://github.com/ga4gh/schemas/blob/v0.5.1/src/main/resources/avro/variantmethods.avdl#L49). 
        /// Documentation https://developers.google.com/genomics/v1/reference/variantsets/search
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated genomics service.</param>  
        /// <param name="body">A valid genomics v1 body.</param>
        /// <returns>SearchVariantSetsResponseResponse</returns>
        public static SearchVariantSetsResponse Search(genomicsService service, SearchVariantSetsRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Variantsets.Search(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Variantsets.Search failed.", ex);
            }
        }


        /// <summary>
        /// Deletes a variant set including all variants, call sets, and calls within. This is not reversible. For the definitions of variant sets and other genomics resources, see [Fundamentals of Google Genomics](https://cloud.google.com/genomics/fundamentals-of-google-genomics) 
        /// Documentation https://developers.google.com/genomics/v1/reference/variantsets/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated genomics service.</param>  
        /// <param name="variantSetId">The ID of the variant set to be deleted.</param>
        /// <returns>EmptyResponse</returns>
        public static Empty Delete(genomicsService service, string variantSetId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (variantSetId == null)
                    throw new ArgumentNullException(variantSetId);

                // Make the request.
                return service.Variantsets.Delete(variantSetId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Variantsets.Delete failed.", ex);
            }
        }

        public class VariantsetsPatchOptionalParms
        {
            /// An optional mask specifying which fields to update. Supported fields: * metadata. * name. * description. Leaving `updateMask` unset is equivalent to specifying all mutable fields.
            public string UpdateMask { get; set; }  
        
        }
 
        /// <summary>
        /// Updates a variant set using patch semantics. For the definitions of variant sets and other genomics resources, see [Fundamentals of Google Genomics](https://cloud.google.com/genomics/fundamentals-of-google-genomics) 
        /// Documentation https://developers.google.com/genomics/v1/reference/variantsets/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated genomics service.</param>  
        /// <param name="variantSetId">The ID of the variant to be updated (must already exist).</param>
        /// <param name="body">A valid genomics v1 body.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>VariantSetResponse</returns>
        public static VariantSet Patch(genomicsService service, string variantSetId, VariantSet body, VariantsetsPatchOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (variantSetId == null)
                    throw new ArgumentNullException(variantSetId);

                // Building the initial request.
                var request = service.Variantsets.Patch(body, variantSetId);

                // Applying optional parameters to the request.                
                request = (VariantsetsResource.PatchRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Variantsets.Patch failed.", ex);
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