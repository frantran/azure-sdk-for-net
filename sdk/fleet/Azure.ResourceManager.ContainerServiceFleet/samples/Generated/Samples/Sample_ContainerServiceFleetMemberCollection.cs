// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.ContainerServiceFleet.Samples
{
    public partial class Sample_ContainerServiceFleetMemberCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreatesAFleetMemberResourceWithALongRunningOperation()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/fleet/stable/2025-03-01/examples/FleetMembers_Create.json
            // this example is just showing the usage of "FleetMembers_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerServiceFleetResource created on azure
            // for more information of creating ContainerServiceFleetResource, please refer to the document of ContainerServiceFleetResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string fleetName = "fleet1";
            ResourceIdentifier containerServiceFleetResourceId = ContainerServiceFleetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fleetName);
            ContainerServiceFleetResource containerServiceFleet = client.GetContainerServiceFleetResource(containerServiceFleetResourceId);

            // get the collection of this ContainerServiceFleetMemberResource
            ContainerServiceFleetMemberCollection collection = containerServiceFleet.GetContainerServiceFleetMembers();

            // invoke the operation
            string fleetMemberName = "member-1";
            ContainerServiceFleetMemberData data = new ContainerServiceFleetMemberData
            {
                ClusterResourceId = new ResourceIdentifier("/subscriptions/subid1/resourcegroups/rg1/providers/Microsoft.ContainerService/managedClusters/cluster-1"),
            };
            ArmOperation<ContainerServiceFleetMemberResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, fleetMemberName, data);
            ContainerServiceFleetMemberResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerServiceFleetMemberData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreatesAFleetMemberResourceWithALongRunningOperationGeneratedByMaximumSetRule()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/fleet/stable/2025-03-01/examples/FleetMembers_Create_MaximumSet_Gen.json
            // this example is just showing the usage of "FleetMembers_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerServiceFleetResource created on azure
            // for more information of creating ContainerServiceFleetResource, please refer to the document of ContainerServiceFleetResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rgfleets";
            string fleetName = "fleet1";
            ResourceIdentifier containerServiceFleetResourceId = ContainerServiceFleetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fleetName);
            ContainerServiceFleetResource containerServiceFleet = client.GetContainerServiceFleetResource(containerServiceFleetResourceId);

            // get the collection of this ContainerServiceFleetMemberResource
            ContainerServiceFleetMemberCollection collection = containerServiceFleet.GetContainerServiceFleetMembers();

            // invoke the operation
            string fleetMemberName = "fleet1";
            ContainerServiceFleetMemberData data = new ContainerServiceFleetMemberData
            {
                ClusterResourceId = new ResourceIdentifier("/subscriptions/subid1/resourcegroups/rg1/providers/Microsoft.ContainerService/managedClusters/cluster-1"),
                Group = "fleet1",
            };
            string ifMatch = "amkttadbw";
            string ifNoneMatch = "zoljoccbcg";
            ArmOperation<ContainerServiceFleetMemberResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, fleetMemberName, data, ifMatch: ifMatch, ifNoneMatch: ifNoneMatch);
            ContainerServiceFleetMemberResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerServiceFleetMemberData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetsAFleetMemberResource()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/fleet/stable/2025-03-01/examples/FleetMembers_Get.json
            // this example is just showing the usage of "FleetMembers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerServiceFleetResource created on azure
            // for more information of creating ContainerServiceFleetResource, please refer to the document of ContainerServiceFleetResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string fleetName = "fleet1";
            ResourceIdentifier containerServiceFleetResourceId = ContainerServiceFleetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fleetName);
            ContainerServiceFleetResource containerServiceFleet = client.GetContainerServiceFleetResource(containerServiceFleetResourceId);

            // get the collection of this ContainerServiceFleetMemberResource
            ContainerServiceFleetMemberCollection collection = containerServiceFleet.GetContainerServiceFleetMembers();

            // invoke the operation
            string fleetMemberName = "member-1";
            ContainerServiceFleetMemberResource result = await collection.GetAsync(fleetMemberName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerServiceFleetMemberData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetsAFleetMemberResourceGeneratedByMaximumSetRule()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/fleet/stable/2025-03-01/examples/FleetMembers_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "FleetMembers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerServiceFleetResource created on azure
            // for more information of creating ContainerServiceFleetResource, please refer to the document of ContainerServiceFleetResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rgfleets";
            string fleetName = "fleet1";
            ResourceIdentifier containerServiceFleetResourceId = ContainerServiceFleetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fleetName);
            ContainerServiceFleetResource containerServiceFleet = client.GetContainerServiceFleetResource(containerServiceFleetResourceId);

            // get the collection of this ContainerServiceFleetMemberResource
            ContainerServiceFleetMemberCollection collection = containerServiceFleet.GetContainerServiceFleetMembers();

            // invoke the operation
            string fleetMemberName = "fleet1";
            ContainerServiceFleetMemberResource result = await collection.GetAsync(fleetMemberName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerServiceFleetMemberData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListsTheMembersOfAFleet()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/fleet/stable/2025-03-01/examples/FleetMembers_ListByFleet.json
            // this example is just showing the usage of "FleetMembers_ListByFleet" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerServiceFleetResource created on azure
            // for more information of creating ContainerServiceFleetResource, please refer to the document of ContainerServiceFleetResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string fleetName = "fleet1";
            ResourceIdentifier containerServiceFleetResourceId = ContainerServiceFleetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fleetName);
            ContainerServiceFleetResource containerServiceFleet = client.GetContainerServiceFleetResource(containerServiceFleetResourceId);

            // get the collection of this ContainerServiceFleetMemberResource
            ContainerServiceFleetMemberCollection collection = containerServiceFleet.GetContainerServiceFleetMembers();

            // invoke the operation and iterate over the result
            await foreach (ContainerServiceFleetMemberResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerServiceFleetMemberData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListsTheMembersOfAFleetGeneratedByMaximumSetRule()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/fleet/stable/2025-03-01/examples/FleetMembers_ListByFleet_MaximumSet_Gen.json
            // this example is just showing the usage of "FleetMembers_ListByFleet" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerServiceFleetResource created on azure
            // for more information of creating ContainerServiceFleetResource, please refer to the document of ContainerServiceFleetResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rgfleets";
            string fleetName = "fleet1";
            ResourceIdentifier containerServiceFleetResourceId = ContainerServiceFleetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fleetName);
            ContainerServiceFleetResource containerServiceFleet = client.GetContainerServiceFleetResource(containerServiceFleetResourceId);

            // get the collection of this ContainerServiceFleetMemberResource
            ContainerServiceFleetMemberCollection collection = containerServiceFleet.GetContainerServiceFleetMembers();

            // invoke the operation and iterate over the result
            await foreach (ContainerServiceFleetMemberResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerServiceFleetMemberData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetsAFleetMemberResource()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/fleet/stable/2025-03-01/examples/FleetMembers_Get.json
            // this example is just showing the usage of "FleetMembers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerServiceFleetResource created on azure
            // for more information of creating ContainerServiceFleetResource, please refer to the document of ContainerServiceFleetResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string fleetName = "fleet1";
            ResourceIdentifier containerServiceFleetResourceId = ContainerServiceFleetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fleetName);
            ContainerServiceFleetResource containerServiceFleet = client.GetContainerServiceFleetResource(containerServiceFleetResourceId);

            // get the collection of this ContainerServiceFleetMemberResource
            ContainerServiceFleetMemberCollection collection = containerServiceFleet.GetContainerServiceFleetMembers();

            // invoke the operation
            string fleetMemberName = "member-1";
            bool result = await collection.ExistsAsync(fleetMemberName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetsAFleetMemberResourceGeneratedByMaximumSetRule()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/fleet/stable/2025-03-01/examples/FleetMembers_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "FleetMembers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerServiceFleetResource created on azure
            // for more information of creating ContainerServiceFleetResource, please refer to the document of ContainerServiceFleetResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rgfleets";
            string fleetName = "fleet1";
            ResourceIdentifier containerServiceFleetResourceId = ContainerServiceFleetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fleetName);
            ContainerServiceFleetResource containerServiceFleet = client.GetContainerServiceFleetResource(containerServiceFleetResourceId);

            // get the collection of this ContainerServiceFleetMemberResource
            ContainerServiceFleetMemberCollection collection = containerServiceFleet.GetContainerServiceFleetMembers();

            // invoke the operation
            string fleetMemberName = "fleet1";
            bool result = await collection.ExistsAsync(fleetMemberName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetsAFleetMemberResource()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/fleet/stable/2025-03-01/examples/FleetMembers_Get.json
            // this example is just showing the usage of "FleetMembers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerServiceFleetResource created on azure
            // for more information of creating ContainerServiceFleetResource, please refer to the document of ContainerServiceFleetResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string fleetName = "fleet1";
            ResourceIdentifier containerServiceFleetResourceId = ContainerServiceFleetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fleetName);
            ContainerServiceFleetResource containerServiceFleet = client.GetContainerServiceFleetResource(containerServiceFleetResourceId);

            // get the collection of this ContainerServiceFleetMemberResource
            ContainerServiceFleetMemberCollection collection = containerServiceFleet.GetContainerServiceFleetMembers();

            // invoke the operation
            string fleetMemberName = "member-1";
            NullableResponse<ContainerServiceFleetMemberResource> response = await collection.GetIfExistsAsync(fleetMemberName);
            ContainerServiceFleetMemberResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerServiceFleetMemberData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetsAFleetMemberResourceGeneratedByMaximumSetRule()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/fleet/stable/2025-03-01/examples/FleetMembers_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "FleetMembers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerServiceFleetResource created on azure
            // for more information of creating ContainerServiceFleetResource, please refer to the document of ContainerServiceFleetResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rgfleets";
            string fleetName = "fleet1";
            ResourceIdentifier containerServiceFleetResourceId = ContainerServiceFleetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fleetName);
            ContainerServiceFleetResource containerServiceFleet = client.GetContainerServiceFleetResource(containerServiceFleetResourceId);

            // get the collection of this ContainerServiceFleetMemberResource
            ContainerServiceFleetMemberCollection collection = containerServiceFleet.GetContainerServiceFleetMembers();

            // invoke the operation
            string fleetMemberName = "fleet1";
            NullableResponse<ContainerServiceFleetMemberResource> response = await collection.GetIfExistsAsync(fleetMemberName);
            ContainerServiceFleetMemberResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerServiceFleetMemberData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
