using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsCapacityProvider
{
    [JsiiByValue(fqn: "aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInfrastructureOptimization")]
    public class EcsCapacityProviderManagedInstancesProviderInfrastructureOptimization : aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInfrastructureOptimization
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ecs_capacity_provider#scale_in_after EcsCapacityProvider#scale_in_after}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scaleInAfter", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ScaleInAfter
        {
            get;
            set;
        }
    }
}
