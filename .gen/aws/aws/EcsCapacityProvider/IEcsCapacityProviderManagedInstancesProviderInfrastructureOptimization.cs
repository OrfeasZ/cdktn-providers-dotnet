using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsCapacityProvider
{
    [JsiiInterface(nativeType: typeof(IEcsCapacityProviderManagedInstancesProviderInfrastructureOptimization), fullyQualifiedName: "aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInfrastructureOptimization")]
    public interface IEcsCapacityProviderManagedInstancesProviderInfrastructureOptimization
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_capacity_provider#scale_in_after EcsCapacityProvider#scale_in_after}.</summary>
        [JsiiProperty(name: "scaleInAfter", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ScaleInAfter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsCapacityProviderManagedInstancesProviderInfrastructureOptimization), fullyQualifiedName: "aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInfrastructureOptimization")]
        internal sealed class _Proxy : DeputyBase, aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInfrastructureOptimization
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_capacity_provider#scale_in_after EcsCapacityProvider#scale_in_after}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scaleInAfter", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ScaleInAfter
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
