using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsCapacityProvider
{
    [JsiiByValue(fqn: "aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderAutoRepairConfiguration")]
    public class EcsCapacityProviderManagedInstancesProviderAutoRepairConfiguration : aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderAutoRepairConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/ecs_capacity_provider#actions_status EcsCapacityProvider#actions_status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "actionsStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ActionsStatus
        {
            get;
            set;
        }
    }
}
