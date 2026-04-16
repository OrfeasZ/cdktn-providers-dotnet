using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsCapacityProvider
{
    [JsiiInterface(nativeType: typeof(IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsTotalLocalStorageGb), fullyQualifiedName: "aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsTotalLocalStorageGb")]
    public interface IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsTotalLocalStorageGb
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_capacity_provider#max EcsCapacityProvider#max}.</summary>
        [JsiiProperty(name: "max", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Max
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_capacity_provider#min EcsCapacityProvider#min}.</summary>
        [JsiiProperty(name: "min", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Min
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsTotalLocalStorageGb), fullyQualifiedName: "aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsTotalLocalStorageGb")]
        internal sealed class _Proxy : DeputyBase, aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsTotalLocalStorageGb
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_capacity_provider#max EcsCapacityProvider#max}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "max", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Max
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_capacity_provider#min EcsCapacityProvider#min}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "min", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Min
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
