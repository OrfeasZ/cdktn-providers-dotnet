using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsCapacityProvider
{
    [JsiiByValue(fqn: "aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateCapacityReservations")]
    public class EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateCapacityReservations : aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateCapacityReservations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/ecs_capacity_provider#reservation_group_arn EcsCapacityProvider#reservation_group_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "reservationGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReservationGroupArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/ecs_capacity_provider#reservation_preference EcsCapacityProvider#reservation_preference}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "reservationPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReservationPreference
        {
            get;
            set;
        }
    }
}
