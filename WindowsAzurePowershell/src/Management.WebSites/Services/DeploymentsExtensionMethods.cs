﻿// ----------------------------------------------------------------------------------
//
// Copyright 2011 Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.WindowsAzure.Management.Websites.Services
{
    using DeploymentEntities;

    public static class DeploymentsExtensionMethods
    {
        public static Deployments GetDeployments(this IDeploymentServiceManagement proxy, int maxItems)
        {
            return proxy.EndGetDeployments(proxy.BeginGetDeployments(maxItems, null, null));
        }

        public static Logs GetDeploymentLogs(this IDeploymentServiceManagement proxy, string commitId, string logId)
        {
            return proxy.EndGetDeploymentLogs(proxy.BeginGetDeploymentLogs(commitId, logId, null, null));
        }

        public static void Deploy(this IDeploymentServiceManagement proxy, string commitId)
        {
            proxy.EndDeploy(proxy.BeginDeploy(commitId, null, null));
        }
    }
}