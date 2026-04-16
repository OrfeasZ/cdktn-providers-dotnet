using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsCapacityProvider
{
    [JsiiByValue(fqn: "aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsTotalLocalStorageGb")]
    public class EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsTotalLocalStorageGb : aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsTotalLocalStorageGb
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_capacity_provider#max EcsCapacityProvider#max}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "max", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Max
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/ecs_capacity_provider#min EcsCapacityProvider#min}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "min", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Min
        {
            get;
            set;
        }
    }
}
