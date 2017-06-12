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
//     Build date: 01/02/2017 22:32:11
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the CloudUserAccounts alpha API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Creates and manages users and groups for accessing Google Compute Engine virtual machines.
// API Documentation Link https://cloud.google.com/compute/docs/access/user-accounts/api/latest/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/CloudUserAccounts/alpha/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.CloudUserAccounts.alpha/ 
// Install Command: PM>  Install-Package Google.Apis.CloudUserAccounts.alpha
//
//------------------------------------------------------------------------------  
using Google.Apis.CloudUserAccounts.alpha;
using Google.Apis.CloudUserAccounts.alpha.Data;
using System;

namespace GoogleSamplecSharpSample.CloudUserAccountsalpha.Methods
{
  
    public static class UsersSample
    {


        /// <summary>
        /// Adds a public key to the specified User resource with the data included in the request. 
        /// Documentation https://developers.google.com/clouduseraccounts/alpha/reference/users/addPublicKey
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated CloudUserAccounts service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="user">Name of the user for this request.</param>
        /// <param name="body">A valid CloudUserAccounts alpha body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation AddPublicKey(CloudUserAccountsService service, string project, string user, PublicKey body)
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
                if (user == null)
                    throw new ArgumentNullException(user);

                // Make the request.
                return service.Users.AddPublicKey(body, project, user).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Users.AddPublicKey failed.", ex);
            }
        }


        /// <summary>
        /// Deletes the specified User resource. 
        /// Documentation https://developers.google.com/clouduseraccounts/alpha/reference/users/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated CloudUserAccounts service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="user">Name of the user resource to delete.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Delete(CloudUserAccountsService service, string project, string user)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (user == null)
                    throw new ArgumentNullException(user);

                // Make the request.
                return service.Users.Delete(project, user).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Users.Delete failed.", ex);
            }
        }


        /// <summary>
        /// Returns the specified User resource. 
        /// Documentation https://developers.google.com/clouduseraccounts/alpha/reference/users/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated CloudUserAccounts service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="user">Name of the user resource to return.</param>
        /// <returns>UserResponse</returns>
        public static User Get(CloudUserAccountsService service, string project, string user)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (user == null)
                    throw new ArgumentNullException(user);

                // Make the request.
                return service.Users.Get(project, user).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Users.Get failed.", ex);
            }
        }


        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists. 
        /// Documentation https://developers.google.com/clouduseraccounts/alpha/reference/users/getIamPolicy
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated CloudUserAccounts service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="resource">Name of the resource for this request.</param>
        /// <returns>PolicyResponse</returns>
        public static Policy GetIamPolicy(CloudUserAccountsService service, string project, string resource)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (resource == null)
                    throw new ArgumentNullException(resource);

                // Make the request.
                return service.Users.GetIamPolicy(project, resource).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Users.GetIamPolicy failed.", ex);
            }
        }


        /// <summary>
        /// Creates a User resource in the specified project using the data included in the request. 
        /// Documentation https://developers.google.com/clouduseraccounts/alpha/reference/users/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated CloudUserAccounts service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="body">A valid CloudUserAccounts alpha body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Insert(CloudUserAccountsService service, string project, User body)
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

                // Make the request.
                return service.Users.Insert(body, project).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Users.Insert failed.", ex);
            }
        }

        public class UsersListOptionalParms
        {
            /// Sets a filter expression for filtering listed resources, in the form filter={expression}. Your {expression} must be in the format: field_name comparison_string literal_string.

The field_name is the name of the field you want to compare. Only atomic field types are supported (string, number, boolean). The comparison_string must be either eq (equals) or ne (not equals). The literal_string is the string value to filter to. The literal value must be valid for the type of field you are filtering by (string, number, boolean). For string fields, the literal value is interpreted as a regular expression using RE2 syntax. The literal value must match the entire field.

For example, to filter for instances that do not have a name of example-instance, you would use filter=name ne example-instance.

Compute Engine Beta API Only: If you use filtering in the Beta API, you can also filter on nested fields. For example, you could filter on instances that have set the scheduling.automaticRestart field to true. In particular, use filtering on nested fields to take advantage of instance labels to organize and filter results based on label values.

The Beta API also supports filtering on multiple expressions by providing each separate expression within parentheses. For example, (scheduling.automaticRestart eq true) (zone eq us-central1-f). Multiple expressions are treated as AND expressions, meaning that resources must match all expressions to pass the filters.
            public string Filter { get; set; }  
            /// The maximum number of results per page that should be returned. If the number of available results is larger than maxResults, Compute Engine returns a nextPageToken that can be used to get the next page of results in subsequent list requests.
            public int MaxResults { get; set; }  
            /// Sorts list results by a certain order. By default, results are returned in alphanumerical order based on the resource name.

You can also sort results in descending order based on the creation timestamp using orderBy="creationTimestamp desc". This sorts results based on the creationTimestamp field in reverse chronological order (newest result first). Use this to sort resources like operations so that the newest operation is returned first.

Currently, only sorting by name or creationTimestamp desc is supported.
            public string OrderBy { get; set; }  
            /// Specifies a page token to use. Set pageToken to the nextPageToken returned by a previous list request to get the next page of results.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves a list of users contained within the specified project. 
        /// Documentation https://developers.google.com/clouduseraccounts/alpha/reference/users/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated CloudUserAccounts service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>UserListResponse</returns>
        public static UserList List(CloudUserAccountsService service, string project, UsersListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);

                // Building the initial request.
                var request = service.Users.List(project);

                // Applying optional parameters to the request.                
                request = (UsersResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Users.List failed.", ex);
            }
        }


        /// <summary>
        /// Removes the specified public key from the user. 
        /// Documentation https://developers.google.com/clouduseraccounts/alpha/reference/users/removePublicKey
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated CloudUserAccounts service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="user">Name of the user for this request.</param>
        /// <param name="fingerprint">The fingerprint of the public key to delete. Public keys are identified by their fingerprint, which is defined by RFC4716 to be the MD5 digest of the public key.</param>
        /// <returns>OperationResponse</returns>
        public static Operation RemovePublicKey(CloudUserAccountsService service, string project, string user, string fingerprint)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (user == null)
                    throw new ArgumentNullException(user);
                if (fingerprint == null)
                    throw new ArgumentNullException(fingerprint);

                // Make the request.
                return service.Users.RemovePublicKey(project, user, fingerprint).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Users.RemovePublicKey failed.", ex);
            }
        }


        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy. 
        /// Documentation https://developers.google.com/clouduseraccounts/alpha/reference/users/setIamPolicy
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated CloudUserAccounts service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="resource">Name of the resource for this request.</param>
        /// <param name="body">A valid CloudUserAccounts alpha body.</param>
        /// <returns>PolicyResponse</returns>
        public static Policy SetIamPolicy(CloudUserAccountsService service, string project, string resource, Policy body)
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
                if (resource == null)
                    throw new ArgumentNullException(resource);

                // Make the request.
                return service.Users.SetIamPolicy(body, project, resource).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Users.SetIamPolicy failed.", ex);
            }
        }


        /// <summary>
        /// Returns permissions that a caller has on the specified resource. 
        /// Documentation https://developers.google.com/clouduseraccounts/alpha/reference/users/testIamPermissions
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated CloudUserAccounts service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="resource">Name of the resource for this request.</param>
        /// <param name="body">A valid CloudUserAccounts alpha body.</param>
        /// <returns>TestPermissionsResponseResponse</returns>
        public static TestPermissionsResponse TestIamPermissions(CloudUserAccountsService service, string project, string resource, TestPermissionsRequest body)
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
                if (resource == null)
                    throw new ArgumentNullException(resource);

                // Make the request.
                return service.Users.TestIamPermissions(body, project, resource).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Users.TestIamPermissions failed.", ex);
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