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
//     Template File Name:  APIKey.tt
//     Build date: 01/02/2017 22:31:46
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the AdSense Host v4.1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Generates performance reports, generates ad codes, and provides publisher management capabilities for AdSense Hosts.
// API Documentation Link https://developers.google.com/adsense/host/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/AdSense Host/v4_1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.AdSense Host.v4_1/ 
// Install Command: PM>  Install-Package Google.Apis.AdSense Host.v4_1
//
//------------------------------------------------------------------------------  
using Google.Apis.AdSense Host.v4.1;
using Google.Apis.Services;
using System;

namespace GoogleSamplecSharpSample.AdSense Hostv4.1.Auth
{
    public static class ApiKeyExample
    {
        public static AdSense HostService GetService(string apiKey)
        {
            try
            {
                if (string.IsNullOrEmpty(apiKey))
                    throw new ArgumentNullException("api Key");

                return new AdSense HostService(new BaseClientService.Initializer()
                {
                    ApiKey = apiKey,
                    ApplicationName = "AdSense Host API key example",
                });
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to create new AdSense Host Service", ex);
            }
        }
    }
}
