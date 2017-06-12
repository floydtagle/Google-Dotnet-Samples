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
//     Build date: 01/02/2017 22:34:14
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the replicapoolupdater v1beta1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: [Deprecated. Please use compute.instanceGroupManagers.update method. replicapoolupdater API will be disabled after December 30th, 2016] Updates groups of Compute Engine instances.
// API Documentation Link https://cloud.google.com/compute/docs/instance-groups/manager/#applying_rolling_updates_using_the_updater_service
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/replicapoolupdater/v1beta1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.replicapoolupdater.v1beta1/ 
// Install Command: PM>  Install-Package Google.Apis.replicapoolupdater.v1beta1
//
//------------------------------------------------------------------------------  
using Google.Apis.replicapoolupdater.v1beta1;
using Google.Apis.replicapoolupdater.v1beta1.Data;
using System;

namespace GoogleSamplecSharpSample.replicapoolupdaterv1beta1.Methods
{
  
    public static class RollingUpdatesSample
    {


        /// <summary>
        /// Cancels an update. The update must be PAUSED before it can be cancelled. This has no effect if the update is already CANCELLED. 
        /// Documentation https://developers.google.com/replicapoolupdater/v1beta1/reference/rollingUpdates/cancel
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated replicapoolupdater service.</param>  
        /// <param name="project">The Google Developers Console project name.</param>
        /// <param name="zone">The name of the zone in which the update's target resides.</param>
        /// <param name="rollingUpdate">The name of the update.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Cancel(replicapoolupdaterService service, string project, string zone, string rollingUpdate)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (zone == null)
                    throw new ArgumentNullException(zone);
                if (rollingUpdate == null)
                    throw new ArgumentNullException(rollingUpdate);

                // Make the request.
                return service.RollingUpdates.Cancel(project, zone, rollingUpdate).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request RollingUpdates.Cancel failed.", ex);
            }
        }


        /// <summary>
        /// Returns information about an update. 
        /// Documentation https://developers.google.com/replicapoolupdater/v1beta1/reference/rollingUpdates/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated replicapoolupdater service.</param>  
        /// <param name="project">The Google Developers Console project name.</param>
        /// <param name="zone">The name of the zone in which the update's target resides.</param>
        /// <param name="rollingUpdate">The name of the update.</param>
        /// <returns>RollingUpdateResponse</returns>
        public static RollingUpdate Get(replicapoolupdaterService service, string project, string zone, string rollingUpdate)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (zone == null)
                    throw new ArgumentNullException(zone);
                if (rollingUpdate == null)
                    throw new ArgumentNullException(rollingUpdate);

                // Make the request.
                return service.RollingUpdates.Get(project, zone, rollingUpdate).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request RollingUpdates.Get failed.", ex);
            }
        }


        /// <summary>
        /// Inserts and starts a new update. 
        /// Documentation https://developers.google.com/replicapoolupdater/v1beta1/reference/rollingUpdates/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated replicapoolupdater service.</param>  
        /// <param name="project">The Google Developers Console project name.</param>
        /// <param name="zone">The name of the zone in which the update's target resides.</param>
        /// <param name="body">A valid replicapoolupdater v1beta1 body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Insert(replicapoolupdaterService service, string project, string zone, RollingUpdate body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (zone == null)
                    throw new ArgumentNullException(zone);

                // Make the request.
                return service.RollingUpdates.Insert(body, project, zone).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request RollingUpdates.Insert failed.", ex);
            }
        }

        public class RollingUpdatesListOptionalParms
        {
            /// Optional. Filter expression for filtering listed resources.
            public string Filter { get; set; }  
            /// Optional. Maximum count of results to be returned. Maximum value is 500 and default value is 500.
            public int MaxResults { get; set; }  
            /// Optional. Tag returned by a previous list request truncated by maxResults. Used to continue a previous list request.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Lists recent updates for a given managed instance group, in reverse chronological order and paginated format. 
        /// Documentation https://developers.google.com/replicapoolupdater/v1beta1/reference/rollingUpdates/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated replicapoolupdater service.</param>  
        /// <param name="project">The Google Developers Console project name.</param>
        /// <param name="zone">The name of the zone in which the update's target resides.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>RollingUpdateListResponse</returns>
        public static RollingUpdateList List(replicapoolupdaterService service, string project, string zone, RollingUpdatesListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (zone == null)
                    throw new ArgumentNullException(zone);

                // Building the initial request.
                var request = service.RollingUpdates.List(project, zone);

                // Applying optional parameters to the request.                
                request = (RollingUpdatesResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request RollingUpdates.List failed.", ex);
            }
        }

        public class RollingUpdatesListInstanceUpdatesOptionalParms
        {
            /// Optional. Filter expression for filtering listed resources.
            public string Filter { get; set; }  
            /// Optional. Maximum count of results to be returned. Maximum value is 500 and default value is 500.
            public int MaxResults { get; set; }  
            /// Optional. Tag returned by a previous list request truncated by maxResults. Used to continue a previous list request.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Lists the current status for each instance within a given update. 
        /// Documentation https://developers.google.com/replicapoolupdater/v1beta1/reference/rollingUpdates/listInstanceUpdates
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated replicapoolupdater service.</param>  
        /// <param name="project">The Google Developers Console project name.</param>
        /// <param name="zone">The name of the zone in which the update's target resides.</param>
        /// <param name="rollingUpdate">The name of the update.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>InstanceUpdateListResponse</returns>
        public static InstanceUpdateList ListInstanceUpdates(replicapoolupdaterService service, string project, string zone, string rollingUpdate, RollingUpdatesListInstanceUpdatesOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (zone == null)
                    throw new ArgumentNullException(zone);
                if (rollingUpdate == null)
                    throw new ArgumentNullException(rollingUpdate);

                // Building the initial request.
                var request = service.RollingUpdates.ListInstanceUpdates(project, zone, rollingUpdate);

                // Applying optional parameters to the request.                
                request = (RollingUpdatesResource.ListInstanceUpdatesRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request RollingUpdates.ListInstanceUpdates failed.", ex);
            }
        }


        /// <summary>
        /// Pauses the update in state from ROLLING_FORWARD or ROLLING_BACK. Has no effect if invoked when the state of the update is PAUSED. 
        /// Documentation https://developers.google.com/replicapoolupdater/v1beta1/reference/rollingUpdates/pause
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated replicapoolupdater service.</param>  
        /// <param name="project">The Google Developers Console project name.</param>
        /// <param name="zone">The name of the zone in which the update's target resides.</param>
        /// <param name="rollingUpdate">The name of the update.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Pause(replicapoolupdaterService service, string project, string zone, string rollingUpdate)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (zone == null)
                    throw new ArgumentNullException(zone);
                if (rollingUpdate == null)
                    throw new ArgumentNullException(rollingUpdate);

                // Make the request.
                return service.RollingUpdates.Pause(project, zone, rollingUpdate).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request RollingUpdates.Pause failed.", ex);
            }
        }


        /// <summary>
        /// Continues an update in PAUSED state. Has no effect if invoked when the state of the update is ROLLED_OUT. 
        /// Documentation https://developers.google.com/replicapoolupdater/v1beta1/reference/rollingUpdates/resume
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated replicapoolupdater service.</param>  
        /// <param name="project">The Google Developers Console project name.</param>
        /// <param name="zone">The name of the zone in which the update's target resides.</param>
        /// <param name="rollingUpdate">The name of the update.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Resume(replicapoolupdaterService service, string project, string zone, string rollingUpdate)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (zone == null)
                    throw new ArgumentNullException(zone);
                if (rollingUpdate == null)
                    throw new ArgumentNullException(rollingUpdate);

                // Make the request.
                return service.RollingUpdates.Resume(project, zone, rollingUpdate).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request RollingUpdates.Resume failed.", ex);
            }
        }


        /// <summary>
        /// Rolls back the update in state from ROLLING_FORWARD or PAUSED. Has no effect if invoked when the state of the update is ROLLED_BACK. 
        /// Documentation https://developers.google.com/replicapoolupdater/v1beta1/reference/rollingUpdates/rollback
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated replicapoolupdater service.</param>  
        /// <param name="project">The Google Developers Console project name.</param>
        /// <param name="zone">The name of the zone in which the update's target resides.</param>
        /// <param name="rollingUpdate">The name of the update.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Rollback(replicapoolupdaterService service, string project, string zone, string rollingUpdate)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (zone == null)
                    throw new ArgumentNullException(zone);
                if (rollingUpdate == null)
                    throw new ArgumentNullException(rollingUpdate);

                // Make the request.
                return service.RollingUpdates.Rollback(project, zone, rollingUpdate).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request RollingUpdates.Rollback failed.", ex);
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