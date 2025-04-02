// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ContainerServiceFleet.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ContainerServiceFleet.Samples
{
    public partial class Sample_AutoUpgradeProfileResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetsAnAutoUpgradeProfileResource()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/fleet/stable/2025-03-01/examples/AutoUpgradeProfiles_Get.json
            // this example is just showing the usage of "AutoUpgradeProfiles_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutoUpgradeProfileResource created on azure
            // for more information of creating AutoUpgradeProfileResource, please refer to the document of AutoUpgradeProfileResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string fleetName = "fleet1";
            string autoUpgradeProfileName = "autoupgradeprofile1";
            ResourceIdentifier autoUpgradeProfileResourceId = AutoUpgradeProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fleetName, autoUpgradeProfileName);
            AutoUpgradeProfileResource autoUpgradeProfile = client.GetAutoUpgradeProfileResource(autoUpgradeProfileResourceId);

            // invoke the operation
            AutoUpgradeProfileResource result = await autoUpgradeProfile.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AutoUpgradeProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetsAnAutoUpgradeProfileResourceGeneratedByMaximumSetRule()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/fleet/stable/2025-03-01/examples/AutoUpgradeProfiles_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "AutoUpgradeProfiles_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutoUpgradeProfileResource created on azure
            // for more information of creating AutoUpgradeProfileResource, please refer to the document of AutoUpgradeProfileResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rgfleets";
            string fleetName = "fleet1";
            string autoUpgradeProfileName = "autoupgradeprofile1";
            ResourceIdentifier autoUpgradeProfileResourceId = AutoUpgradeProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fleetName, autoUpgradeProfileName);
            AutoUpgradeProfileResource autoUpgradeProfile = client.GetAutoUpgradeProfileResource(autoUpgradeProfileResourceId);

            // invoke the operation
            AutoUpgradeProfileResource result = await autoUpgradeProfile.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AutoUpgradeProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteAnAutoUpgradeProfileResource()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/fleet/stable/2025-03-01/examples/AutoUpgradeProfiles_Delete.json
            // this example is just showing the usage of "AutoUpgradeProfiles_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutoUpgradeProfileResource created on azure
            // for more information of creating AutoUpgradeProfileResource, please refer to the document of AutoUpgradeProfileResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string fleetName = "fleet1";
            string autoUpgradeProfileName = "autoupgradeprofile1";
            ResourceIdentifier autoUpgradeProfileResourceId = AutoUpgradeProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fleetName, autoUpgradeProfileName);
            AutoUpgradeProfileResource autoUpgradeProfile = client.GetAutoUpgradeProfileResource(autoUpgradeProfileResourceId);

            // invoke the operation
            await autoUpgradeProfile.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteAnAutoUpgradeProfileResourceGeneratedByMaximumSetRule()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/fleet/stable/2025-03-01/examples/AutoUpgradeProfiles_Delete_MaximumSet_Gen.json
            // this example is just showing the usage of "AutoUpgradeProfiles_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutoUpgradeProfileResource created on azure
            // for more information of creating AutoUpgradeProfileResource, please refer to the document of AutoUpgradeProfileResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rgfleets";
            string fleetName = "fleet1";
            string autoUpgradeProfileName = "autoupgradeprofile1";
            ResourceIdentifier autoUpgradeProfileResourceId = AutoUpgradeProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fleetName, autoUpgradeProfileName);
            AutoUpgradeProfileResource autoUpgradeProfile = client.GetAutoUpgradeProfileResource(autoUpgradeProfileResourceId);

            // invoke the operation
            string ifMatch = "qmdsmmawj";
            await autoUpgradeProfile.DeleteAsync(WaitUntil.Completed, ifMatch: ifMatch);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateAnAutoUpgradeProfile()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/fleet/stable/2025-03-01/examples/AutoUpgradeProfiles_CreateOrUpdate.json
            // this example is just showing the usage of "AutoUpgradeProfiles_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutoUpgradeProfileResource created on azure
            // for more information of creating AutoUpgradeProfileResource, please refer to the document of AutoUpgradeProfileResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string fleetName = "fleet1";
            string autoUpgradeProfileName = "autoupgradeprofile1";
            ResourceIdentifier autoUpgradeProfileResourceId = AutoUpgradeProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fleetName, autoUpgradeProfileName);
            AutoUpgradeProfileResource autoUpgradeProfile = client.GetAutoUpgradeProfileResource(autoUpgradeProfileResourceId);

            // invoke the operation
            AutoUpgradeProfileData data = new AutoUpgradeProfileData
            {
                Channel = ContainerServiceFleetUpgradeChannel.Stable,
            };
            ArmOperation<AutoUpgradeProfileResource> lro = await autoUpgradeProfile.UpdateAsync(WaitUntil.Completed, data);
            AutoUpgradeProfileResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AutoUpgradeProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateAnAutoUpgradeProfileGeneratedByMaximumSetRule()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/fleet/stable/2025-03-01/examples/AutoUpgradeProfiles_CreateOrUpdate_MaximumSet_Gen.json
            // this example is just showing the usage of "AutoUpgradeProfiles_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutoUpgradeProfileResource created on azure
            // for more information of creating AutoUpgradeProfileResource, please refer to the document of AutoUpgradeProfileResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rgfleets";
            string fleetName = "fleet1";
            string autoUpgradeProfileName = "autoupgradeprofile1";
            ResourceIdentifier autoUpgradeProfileResourceId = AutoUpgradeProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fleetName, autoUpgradeProfileName);
            AutoUpgradeProfileResource autoUpgradeProfile = client.GetAutoUpgradeProfileResource(autoUpgradeProfileResourceId);

            // invoke the operation
            AutoUpgradeProfileData data = new AutoUpgradeProfileData
            {
                UpdateStrategyId = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rgfleets/providers/Microsoft.ContainerService/fleets/fleet1/updateStrategies/strategy1"),
                Channel = ContainerServiceFleetUpgradeChannel.Stable,
                SelectionType = AutoUpgradeNodeImageSelectionType.Latest,
                Disabled = true,
                AutoUpgradeProfileStatus = new AutoUpgradeProfileStatus(),
            };
            string ifMatch = "teikqmg";
            string ifNoneMatch = "ghfmmyrekxincsxklbldnvhqd";
            ArmOperation<AutoUpgradeProfileResource> lro = await autoUpgradeProfile.UpdateAsync(WaitUntil.Completed, data, ifMatch: ifMatch, ifNoneMatch: ifNoneMatch);
            AutoUpgradeProfileResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AutoUpgradeProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GenerateUpdateRunAutoUpgradeProfileOperation_AutoUpgradeProfileOperationsGenerateUpdateRunMaximumSet()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/fleet/stable/2025-03-01/examples/AutoUpgradeProfileOperations_GenerateUpdateRun_MaximumSet_Gen.json
            // this example is just showing the usage of "AutoUpgradeProfileOperations_GenerateUpdateRun" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutoUpgradeProfileResource created on azure
            // for more information of creating AutoUpgradeProfileResource, please refer to the document of AutoUpgradeProfileResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rgfleets";
            string fleetName = "fleet1";
            string autoUpgradeProfileName = "aup1";
            ResourceIdentifier autoUpgradeProfileResourceId = AutoUpgradeProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fleetName, autoUpgradeProfileName);
            AutoUpgradeProfileResource autoUpgradeProfile = client.GetAutoUpgradeProfileResource(autoUpgradeProfileResourceId);

            // invoke the operation
            ArmOperation<GenerateResponse> lro = await autoUpgradeProfile.GenerateUpdateRunAutoUpgradeProfileOperationAsync(WaitUntil.Completed);
            GenerateResponse result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
