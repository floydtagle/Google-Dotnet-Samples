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
//     Build date: 01/02/2017 22:32:26
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the customsearch v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Lets you search over a website or collection of websites
// API Documentation Link https://developers.google.com/custom-search/v1/using_rest
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/customsearch/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.customsearch.v1/ 
// Install Command: PM>  Install-Package Google.Apis.customsearch.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.customsearch.v1;
using Google.Apis.customsearch.v1.Data;
using System;

namespace GoogleSamplecSharpSample.customsearchv1.Methods
{
  
    public static class CseSample
    {

        public class CseListOptionalParms
        {
            /// Turns off the translation between zh-CN and zh-TW.
            public string C2coff { get; set; }  
            /// Country restrict(s).
            public string Cr { get; set; }  
            /// The URL of a linked custom search engine
            public string Cref { get; set; }  
            /// The custom search engine ID to scope this search query
            public string Cx { get; set; }  
            /// Specifies all search results are from a time period
            public string DateRestrict { get; set; }  
            /// Identifies a phrase that all documents in the search results must contain
            public string ExactTerms { get; set; }  
            /// Identifies a word or phrase that should not appear in any documents in the search results
            public string ExcludeTerms { get; set; }  
            /// Returns images of a specified type. Some of the allowed values are: bmp, gif, png, jpg, svg, pdf, ...
            public string FileType { get; set; }  
            /// Controls turning on or off the duplicate content filter.
            public string Filter { get; set; }  
            /// Geolocation of end user.
            public string Gl { get; set; }  
            /// The local Google domain to use to perform the search.
            public string Googlehost { get; set; }  
            /// Creates a range in form as_nlo value..as_nhi value and attempts to append it to query
            public string HighRange { get; set; }  
            /// Sets the user interface language.
            public string Hl { get; set; }  
            /// Appends the extra query terms to the query.
            public string Hq { get; set; }  
            /// Returns black and white, grayscale, or color images: mono, gray, and color.
            public string ImgColorType { get; set; }  
            /// Returns images of a specific dominant color: yellow, green, teal, blue, purple, pink, white, gray, black and brown.
            public string ImgDominantColor { get; set; }  
            /// Returns images of a specified size, where size can be one of: icon, small, medium, large, xlarge, xxlarge, and huge.
            public string ImgSize { get; set; }  
            /// Returns images of a type, which can be one of: clipart, face, lineart, news, and photo.
            public string ImgType { get; set; }  
            /// Specifies that all search results should contain a link to a particular URL
            public string LinkSite { get; set; }  
            /// Creates a range in form as_nlo value..as_nhi value and attempts to append it to query
            public string LowRange { get; set; }  
            /// The language restriction for the search results
            public string Lr { get; set; }  
            /// Number of search results to return
            public int Num { get; set; }  
            /// Provides additional search terms to check for in a document, where each document in the search results must contain at least one of the additional search terms
            public string OrTerms { get; set; }  
            /// Specifies that all search results should be pages that are related to the specified URL
            public string RelatedSite { get; set; }  
            /// Filters based on licensing. Supported values include: cc_publicdomain, cc_attribute, cc_sharealike, cc_noncommercial, cc_nonderived and combinations of these.
            public string Rights { get; set; }  
            /// Search safety level
            public string Safe { get; set; }  
            /// Specifies the search type: image.
            public string SearchType { get; set; }  
            /// Specifies all search results should be pages from a given site
            public string SiteSearch { get; set; }  
            /// Controls whether to include or exclude results from the site named in the as_sitesearch parameter
            public string SiteSearchFilter { get; set; }  
            /// The sort expression to apply to the results
            public string Sort { get; set; }  
            /// The index of the first result to return
            public int Start { get; set; }  
        
        }
 
        /// <summary>
        /// Returns metadata about the search performed, metadata about the custom search engine used for the search, and the search results. 
        /// Documentation https://developers.google.com/customsearch/v1/reference/cse/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated customsearch service.</param>  
        /// <param name="q">Query</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>SearchResponse</returns>
        public static Search List(customsearchService service, string q, CseListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (q == null)
                    throw new ArgumentNullException(q);

                // Building the initial request.
                var request = service.Cse.List(q);

                // Applying optional parameters to the request.                
                request = (CseResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Cse.List failed.", ex);
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