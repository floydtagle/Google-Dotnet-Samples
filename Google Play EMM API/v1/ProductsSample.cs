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
//     Build date: 01/02/2017 22:31:51
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the AndroidEnterprise v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Manages the deployment of apps to Android for Work users.
// API Documentation Link https://developers.google.com/android/work/play/emm-api
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/AndroidEnterprise/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.AndroidEnterprise.v1/ 
// Install Command: PM>  Install-Package Google.Apis.AndroidEnterprise.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.AndroidEnterprise.v1;
using Google.Apis.AndroidEnterprise.v1.Data;
using System;

namespace GoogleSamplecSharpSample.AndroidEnterprisev1.Methods
{
  
    public static class ProductsSample
    {


        /// <summary>
        /// Approves the specified product and the relevant app permissions, if any. The maximum number of products that you can approve per enterprise customer is 1,000.

To learn how to use Google Play for Work to design and create a store layout to display approved products to your users, see Store Layout Design. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/products/approve
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated AndroidEnterprise service.</param>  
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="productId">The ID of the product.</param>
        /// <param name="body">A valid AndroidEnterprise v1 body.</param>
        public static void Approve(AndroidEnterpriseService service, string enterpriseId, string productId, ProductsApproveRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (enterpriseId == null)
                    throw new ArgumentNullException(enterpriseId);
                if (productId == null)
                    throw new ArgumentNullException(productId);

                // Make the request.
                return service.Products.Approve(body, enterpriseId, productId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Products.Approve failed.", ex);
            }
        }

        public class ProductsGenerateApprovalUrlOptionalParms
        {
            /// The BCP 47 language code used for permission names and descriptions in the returned iframe, for instance "en-US".
            public string LanguageCode { get; set; }  
        
        }
 
        /// <summary>
        /// Generates a URL that can be rendered in an iframe to display the permissions (if any) of a product. An enterprise admin must view these permissions and accept them on behalf of their organization in order to approve that product.

Admins should accept the displayed permissions by interacting with a separate UI element in the EMM console, which in turn should trigger the use of this URL as the approvalUrlInfo.approvalUrl property in a Products.approve call to approve the product. This URL can only be used to display permissions for up to 1 day. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/products/generateApprovalUrl
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated AndroidEnterprise service.</param>  
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="productId">The ID of the product.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>ProductsGenerateApprovalUrlResponseResponse</returns>
        public static ProductsGenerateApprovalUrlResponse GenerateApprovalUrl(AndroidEnterpriseService service, string enterpriseId, string productId, ProductsGenerateApprovalUrlOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (enterpriseId == null)
                    throw new ArgumentNullException(enterpriseId);
                if (productId == null)
                    throw new ArgumentNullException(productId);

                // Building the initial request.
                var request = service.Products.GenerateApprovalUrl(enterpriseId, productId);

                // Applying optional parameters to the request.                
                request = (ProductsResource.GenerateApprovalUrlRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Products.GenerateApprovalUrl failed.", ex);
            }
        }

        public class ProductsGetOptionalParms
        {
            /// The BCP47 tag for the user's preferred language (e.g. "en-US", "de").
            public string Language { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves details of a product for display to an enterprise admin. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/products/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated AndroidEnterprise service.</param>  
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="productId">The ID of the product, e.g. "app:com.google.android.gm".</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>ProductResponse</returns>
        public static Product Get(AndroidEnterpriseService service, string enterpriseId, string productId, ProductsGetOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (enterpriseId == null)
                    throw new ArgumentNullException(enterpriseId);
                if (productId == null)
                    throw new ArgumentNullException(productId);

                // Building the initial request.
                var request = service.Products.Get(enterpriseId, productId);

                // Applying optional parameters to the request.                
                request = (ProductsResource.GetRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Products.Get failed.", ex);
            }
        }

        public class ProductsGetAppRestrictionsSchemaOptionalParms
        {
            /// The BCP47 tag for the user's preferred language (e.g. "en-US", "de").
            public string Language { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves the schema that defines the configurable properties for this product. All products have a schema, but this schema may be empty if no managed configurations have been defined. This schema can be used to populate a UI that allows an administrator to configure the product. To apply a managed configuration based on the schema obtained using this API, see Managed Configurations through Play. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/products/getAppRestrictionsSchema
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated AndroidEnterprise service.</param>  
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="productId">The ID of the product.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>AppRestrictionsSchemaResponse</returns>
        public static AppRestrictionsSchema GetAppRestrictionsSchema(AndroidEnterpriseService service, string enterpriseId, string productId, ProductsGetAppRestrictionsSchemaOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (enterpriseId == null)
                    throw new ArgumentNullException(enterpriseId);
                if (productId == null)
                    throw new ArgumentNullException(productId);

                // Building the initial request.
                var request = service.Products.GetAppRestrictionsSchema(enterpriseId, productId);

                // Applying optional parameters to the request.                
                request = (ProductsResource.GetAppRestrictionsSchemaRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Products.GetAppRestrictionsSchema failed.", ex);
            }
        }


        /// <summary>
        /// Retrieves the Android app permissions required by this app. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/products/getPermissions
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated AndroidEnterprise service.</param>  
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="productId">The ID of the product.</param>
        /// <returns>ProductPermissionsResponse</returns>
        public static ProductPermissions GetPermissions(AndroidEnterpriseService service, string enterpriseId, string productId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (enterpriseId == null)
                    throw new ArgumentNullException(enterpriseId);
                if (productId == null)
                    throw new ArgumentNullException(productId);

                // Make the request.
                return service.Products.GetPermissions(enterpriseId, productId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Products.GetPermissions failed.", ex);
            }
        }

        public class ProductsListOptionalParms
        {
            /// Specifies whether to search among all products (false) or among only products that have been approved (true). Only "true" is supported, and should be specified.
            public bool Approved { get; set; }  
            /// The BCP47 tag for the user's preferred language (e.g. "en-US", "de"). Results are returned in the language best matching the preferred language.
            public string Language { get; set; }  
            /// Specifies the maximum number of products that can be returned per request. If not specified, uses a default value of 100, which is also the maximum retrievable within a single response.
            public int MaxResults { get; set; }  
            /// The search query as typed in the Google Play Store search box. If omitted, all approved apps will be returned (using the pagination parameters), including apps that are not available in the store (e.g. unpublished apps).
            public string Query { get; set; }  
            /// A pagination token is contained in a requests response when there are more products. The token can be used in a subsequent request to obtain more products, and so forth. This parameter cannot be used in the initial request.
            public string Token { get; set; }  
        
        }
 
        /// <summary>
        /// Finds approved products that match a query, or all approved products if there is no query. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/products/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated AndroidEnterprise service.</param>  
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>ProductsListResponseResponse</returns>
        public static ProductsListResponse List(AndroidEnterpriseService service, string enterpriseId, ProductsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (enterpriseId == null)
                    throw new ArgumentNullException(enterpriseId);

                // Building the initial request.
                var request = service.Products.List(enterpriseId);

                // Applying optional parameters to the request.                
                request = (ProductsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Products.List failed.", ex);
            }
        }


        /// <summary>
        /// Unapproves the specified product (and the relevant app permissions, if any) 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/products/unapprove
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated AndroidEnterprise service.</param>  
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="productId">The ID of the product.</param>
        public static void Unapprove(AndroidEnterpriseService service, string enterpriseId, string productId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (enterpriseId == null)
                    throw new ArgumentNullException(enterpriseId);
                if (productId == null)
                    throw new ArgumentNullException(productId);

                // Make the request.
                return service.Products.Unapprove(enterpriseId, productId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Products.Unapprove failed.", ex);
            }
        }


        /// <summary>
        /// This method has been deprecated. To programmatically approve applications, you must use the iframe mechanism via the  generateApprovalUrl and  approve methods of the Products resource. For more information, see the  Play EMM API usage requirements.

The updatePermissions method (deprecated) updates the set of Android app permissions for this app that have been accepted by the enterprise. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/products/updatePermissions
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated AndroidEnterprise service.</param>  
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="productId">The ID of the product.</param>
        /// <param name="body">A valid AndroidEnterprise v1 body.</param>
        /// <returns>ProductPermissionsResponse</returns>
        public static ProductPermissions UpdatePermissions(AndroidEnterpriseService service, string enterpriseId, string productId, ProductPermissions body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (enterpriseId == null)
                    throw new ArgumentNullException(enterpriseId);
                if (productId == null)
                    throw new ArgumentNullException(productId);

                // Make the request.
                return service.Products.UpdatePermissions(body, enterpriseId, productId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Products.UpdatePermissions failed.", ex);
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