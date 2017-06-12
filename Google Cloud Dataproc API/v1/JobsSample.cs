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
//     Build date: 01/02/2017 22:33:15
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the dataproc v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: An API for managing Hadoop-based clusters and jobs on Google Cloud Platform.
// API Documentation Link https://cloud.google.com/dataproc/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/dataproc/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.dataproc.v1/ 
// Install Command: PM>  Install-Package Google.Apis.dataproc.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.dataproc.v1;
using Google.Apis.dataproc.v1.Data;
using System;

namespace GoogleSamplecSharpSample.dataprocv1.Methods
{
  
    public static class JobsSample
    {


        /// <summary>
        /// Submits a job to a cluster. 
        /// Documentation https://developers.google.com/dataproc/v1/reference/jobs/submit
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated dataproc service.</param>  
        /// <param name="projectId">[Required] The ID of the Google Cloud Platform project that the job belongs to.</param>
        /// <param name="region">[Required] The Cloud Dataproc region in which to handle the request.</param>
        /// <param name="body">A valid dataproc v1 body.</param>
        /// <returns>JobResponse</returns>
        public static Job Submit(dataprocService service, string projectId, string region, SubmitJobRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (projectId == null)
                    throw new ArgumentNullException(projectId);
                if (region == null)
                    throw new ArgumentNullException(region);

                // Make the request.
                return service.Jobs.Submit(body, projectId, region).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Jobs.Submit failed.", ex);
            }
        }


        /// <summary>
        /// Gets the resource representation for a job in a project. 
        /// Documentation https://developers.google.com/dataproc/v1/reference/jobs/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated dataproc service.</param>  
        /// <param name="projectId">[Required] The ID of the Google Cloud Platform project that the job belongs to.</param>
        /// <param name="region">[Required] The Cloud Dataproc region in which to handle the request.</param>
        /// <param name="jobId">[Required] The job ID.</param>
        /// <returns>JobResponse</returns>
        public static Job Get(dataprocService service, string projectId, string region, string jobId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (projectId == null)
                    throw new ArgumentNullException(projectId);
                if (region == null)
                    throw new ArgumentNullException(region);
                if (jobId == null)
                    throw new ArgumentNullException(jobId);

                // Make the request.
                return service.Jobs.Get(projectId, region, jobId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Jobs.Get failed.", ex);
            }
        }

        public class JobsListOptionalParms
        {
            /// [Optional] The number of results to return in each response.
            public int PageSize { get; set; }  
            /// [Optional] The page token, returned by a previous call, to request the next page of results.
            public string PageToken { get; set; }  
            /// [Optional] If set, the returned jobs list includes only jobs that were submitted to the named cluster.
            public string ClusterName { get; set; }  
            /// [Optional] Specifies enumerated categories of jobs to list (default = match ALL jobs).
            public string JobStateMatcher { get; set; }  
            /// [Optional] A filter constraining the jobs to list. Filters are case-sensitive and have the following syntax: field:value] ... or [field = value] AND [field [= value]] ... where **field** is `status.state` or `labels.[KEY]`, and `[KEY]` is a label key. **value** can be `*` to match all values. `status.state` can be either `ACTIVE` or `INACTIVE`. Only the logical `AND` operator is supported; space-separated items are treated as having an implicit `AND` operator. Example valid filters are: status.state:ACTIVE labels.env:staging labels.starred:* and status.state = ACTIVE AND labels.env = staging AND labels.starred = *
            public string Filter { get; set; }  
        
        }
 
        /// <summary>
        /// Lists regions/{region}/jobs in a project. 
        /// Documentation https://developers.google.com/dataproc/v1/reference/jobs/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated dataproc service.</param>  
        /// <param name="projectId">[Required] The ID of the Google Cloud Platform project that the job belongs to.</param>
        /// <param name="region">[Required] The Cloud Dataproc region in which to handle the request.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>ListJobsResponseResponse</returns>
        public static ListJobsResponse List(dataprocService service, string projectId, string region, JobsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (projectId == null)
                    throw new ArgumentNullException(projectId);
                if (region == null)
                    throw new ArgumentNullException(region);

                // Building the initial request.
                var request = service.Jobs.List(projectId, region);

                // Applying optional parameters to the request.                
                request = (JobsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Jobs.List failed.", ex);
            }
        }


        /// <summary>
        /// Starts a job cancellation request. To access the job resource after cancellation, call [regions/{region}/jobs.list](/dataproc/reference/rest/v1/projects.regions.jobs/list) or [regions/{region}/jobs.get](/dataproc/reference/rest/v1/projects.regions.jobs/get). 
        /// Documentation https://developers.google.com/dataproc/v1/reference/jobs/cancel
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated dataproc service.</param>  
        /// <param name="projectId">[Required] The ID of the Google Cloud Platform project that the job belongs to.</param>
        /// <param name="region">[Required] The Cloud Dataproc region in which to handle the request.</param>
        /// <param name="jobId">[Required] The job ID.</param>
        /// <param name="body">A valid dataproc v1 body.</param>
        /// <returns>JobResponse</returns>
        public static Job Cancel(dataprocService service, string projectId, string region, string jobId, CancelJobRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (projectId == null)
                    throw new ArgumentNullException(projectId);
                if (region == null)
                    throw new ArgumentNullException(region);
                if (jobId == null)
                    throw new ArgumentNullException(jobId);

                // Make the request.
                return service.Jobs.Cancel(body, projectId, region, jobId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Jobs.Cancel failed.", ex);
            }
        }


        /// <summary>
        /// Deletes the job from the project. If the job is active, the delete fails, and the response returns `FAILED_PRECONDITION`. 
        /// Documentation https://developers.google.com/dataproc/v1/reference/jobs/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated dataproc service.</param>  
        /// <param name="projectId">[Required] The ID of the Google Cloud Platform project that the job belongs to.</param>
        /// <param name="region">[Required] The Cloud Dataproc region in which to handle the request.</param>
        /// <param name="jobId">[Required] The job ID.</param>
        /// <returns>EmptyResponse</returns>
        public static Empty Delete(dataprocService service, string projectId, string region, string jobId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (projectId == null)
                    throw new ArgumentNullException(projectId);
                if (region == null)
                    throw new ArgumentNullException(region);
                if (jobId == null)
                    throw new ArgumentNullException(jobId);

                // Make the request.
                return service.Jobs.Delete(projectId, region, jobId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Jobs.Delete failed.", ex);
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