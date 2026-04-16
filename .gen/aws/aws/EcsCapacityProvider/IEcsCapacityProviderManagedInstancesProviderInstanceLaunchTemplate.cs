using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsCapacityProvider
{
    [JsiiInterface(nativeType: typeof(IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplate), fullyQualifiedName: "aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplate")]
    public interface IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_capacity_provider#ec2_instance_profile_arn EcsCapacityProvider#ec2_instance_profile_arn}.</summary>
        [JsiiProperty(name: "ec2InstanceProfileArn", typeJson: "{\"primitive\":\"string\"}")]
        string Ec2InstanceProfileArn
        {
            get;
        }

        /// <summary>network_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_capacity_provider#network_configuration EcsCapacityProvider#network_configuration}
        /// </remarks>
        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateNetworkConfiguration\"}")]
        aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateNetworkConfiguration NetworkConfiguration
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_capacity_provider#capacity_option_type EcsCapacityProvider#capacity_option_type}.</summary>
        [JsiiProperty(name: "capacityOptionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CapacityOptionType
        {
            get
            {
                return null;
            }
        }

        /// <summary>instance_requirements block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_capacity_provider#instance_requirements EcsCapacityProvider#instance_requirements}
        /// </remarks>
        [JsiiProperty(name: "instanceRequirements", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirements\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirements? InstanceRequirements
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_capacity_provider#monitoring EcsCapacityProvider#monitoring}.</summary>
        [JsiiProperty(name: "monitoring", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Monitoring
        {
            get
            {
                return null;
            }
        }

        /// <summary>storage_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_capacity_provider#storage_configuration EcsCapacityProvider#storage_configuration}
        /// </remarks>
        [JsiiProperty(name: "storageConfiguration", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateStorageConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateStorageConfiguration? StorageConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplate), fullyQualifiedName: "aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplate")]
        internal sealed class _Proxy : DeputyBase, aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_capacity_provider#ec2_instance_profile_arn EcsCapacityProvider#ec2_instance_profile_arn}.</summary>
            [JsiiProperty(name: "ec2InstanceProfileArn", typeJson: "{\"primitive\":\"string\"}")]
            public string Ec2InstanceProfileArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>network_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_capacity_provider#network_configuration EcsCapacityProvider#network_configuration}
            /// </remarks>
            [JsiiProperty(name: "networkConfiguration", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateNetworkConfiguration\"}")]
            public aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateNetworkConfiguration NetworkConfiguration
            {
                get => GetInstanceProperty<aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateNetworkConfiguration>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_capacity_provider#capacity_option_type EcsCapacityProvider#capacity_option_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "capacityOptionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CapacityOptionType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>instance_requirements block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_capacity_provider#instance_requirements EcsCapacityProvider#instance_requirements}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "instanceRequirements", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirements\"}", isOptional: true)]
            public aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirements? InstanceRequirements
            {
                get => GetInstanceProperty<aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirements?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_capacity_provider#monitoring EcsCapacityProvider#monitoring}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "monitoring", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Monitoring
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>storage_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_capacity_provider#storage_configuration EcsCapacityProvider#storage_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageConfiguration", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateStorageConfiguration\"}", isOptional: true)]
            public aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateStorageConfiguration? StorageConfiguration
            {
                get => GetInstanceProperty<aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateStorageConfiguration?>();
            }
        }
    }
}
