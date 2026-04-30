using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsCapacityProvider
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplate")]
    public class EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplate : aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecs_capacity_provider#ec2_instance_profile_arn EcsCapacityProvider#ec2_instance_profile_arn}.</summary>
        [JsiiProperty(name: "ec2InstanceProfileArn", typeJson: "{\"primitive\":\"string\"}")]
        public string Ec2InstanceProfileArn
        {
            get;
            set;
        }

        /// <summary>network_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecs_capacity_provider#network_configuration EcsCapacityProvider#network_configuration}
        /// </remarks>
        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateNetworkConfiguration\"}")]
        public aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateNetworkConfiguration NetworkConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecs_capacity_provider#capacity_option_type EcsCapacityProvider#capacity_option_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "capacityOptionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CapacityOptionType
        {
            get;
            set;
        }

        /// <summary>instance_requirements block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecs_capacity_provider#instance_requirements EcsCapacityProvider#instance_requirements}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "instanceRequirements", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirements\"}", isOptional: true)]
        public aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirements? InstanceRequirements
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecs_capacity_provider#monitoring EcsCapacityProvider#monitoring}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "monitoring", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Monitoring
        {
            get;
            set;
        }

        /// <summary>storage_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecs_capacity_provider#storage_configuration EcsCapacityProvider#storage_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "storageConfiguration", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateStorageConfiguration\"}", isOptional: true)]
        public aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateStorageConfiguration? StorageConfiguration
        {
            get;
            set;
        }
    }
}
