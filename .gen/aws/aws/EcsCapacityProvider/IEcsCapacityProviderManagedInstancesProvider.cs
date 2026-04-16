using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsCapacityProvider
{
    [JsiiInterface(nativeType: typeof(IEcsCapacityProviderManagedInstancesProvider), fullyQualifiedName: "aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProvider")]
    public interface IEcsCapacityProviderManagedInstancesProvider
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_capacity_provider#infrastructure_role_arn EcsCapacityProvider#infrastructure_role_arn}.</summary>
        [JsiiProperty(name: "infrastructureRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        string InfrastructureRoleArn
        {
            get;
        }

        /// <summary>instance_launch_template block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_capacity_provider#instance_launch_template EcsCapacityProvider#instance_launch_template}
        /// </remarks>
        [JsiiProperty(name: "instanceLaunchTemplate", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplate\"}")]
        aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplate InstanceLaunchTemplate
        {
            get;
        }

        /// <summary>infrastructure_optimization block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_capacity_provider#infrastructure_optimization EcsCapacityProvider#infrastructure_optimization}
        /// </remarks>
        [JsiiProperty(name: "infrastructureOptimization", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInfrastructureOptimization\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInfrastructureOptimization? InfrastructureOptimization
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_capacity_provider#propagate_tags EcsCapacityProvider#propagate_tags}.</summary>
        [JsiiProperty(name: "propagateTags", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PropagateTags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsCapacityProviderManagedInstancesProvider), fullyQualifiedName: "aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProvider")]
        internal sealed class _Proxy : DeputyBase, aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProvider
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_capacity_provider#infrastructure_role_arn EcsCapacityProvider#infrastructure_role_arn}.</summary>
            [JsiiProperty(name: "infrastructureRoleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string InfrastructureRoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>instance_launch_template block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_capacity_provider#instance_launch_template EcsCapacityProvider#instance_launch_template}
            /// </remarks>
            [JsiiProperty(name: "instanceLaunchTemplate", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplate\"}")]
            public aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplate InstanceLaunchTemplate
            {
                get => GetInstanceProperty<aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplate>()!;
            }

            /// <summary>infrastructure_optimization block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_capacity_provider#infrastructure_optimization EcsCapacityProvider#infrastructure_optimization}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "infrastructureOptimization", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInfrastructureOptimization\"}", isOptional: true)]
            public aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInfrastructureOptimization? InfrastructureOptimization
            {
                get => GetInstanceProperty<aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInfrastructureOptimization?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_capacity_provider#propagate_tags EcsCapacityProvider#propagate_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "propagateTags", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PropagateTags
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
