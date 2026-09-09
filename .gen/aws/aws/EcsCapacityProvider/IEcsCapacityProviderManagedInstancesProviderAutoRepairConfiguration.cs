using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsCapacityProvider
{
    [JsiiInterface(nativeType: typeof(IEcsCapacityProviderManagedInstancesProviderAutoRepairConfiguration), fullyQualifiedName: "aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderAutoRepairConfiguration")]
    public interface IEcsCapacityProviderManagedInstancesProviderAutoRepairConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/ecs_capacity_provider#actions_status EcsCapacityProvider#actions_status}.</summary>
        [JsiiProperty(name: "actionsStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ActionsStatus
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsCapacityProviderManagedInstancesProviderAutoRepairConfiguration), fullyQualifiedName: "aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderAutoRepairConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderAutoRepairConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/ecs_capacity_provider#actions_status EcsCapacityProvider#actions_status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "actionsStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ActionsStatus
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
