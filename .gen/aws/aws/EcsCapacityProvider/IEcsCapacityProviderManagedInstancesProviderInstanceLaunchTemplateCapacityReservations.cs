using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsCapacityProvider
{
    [JsiiInterface(nativeType: typeof(IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateCapacityReservations), fullyQualifiedName: "aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateCapacityReservations")]
    public interface IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateCapacityReservations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/ecs_capacity_provider#reservation_group_arn EcsCapacityProvider#reservation_group_arn}.</summary>
        [JsiiProperty(name: "reservationGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReservationGroupArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/ecs_capacity_provider#reservation_preference EcsCapacityProvider#reservation_preference}.</summary>
        [JsiiProperty(name: "reservationPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReservationPreference
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateCapacityReservations), fullyQualifiedName: "aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateCapacityReservations")]
        internal sealed class _Proxy : DeputyBase, aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateCapacityReservations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/ecs_capacity_provider#reservation_group_arn EcsCapacityProvider#reservation_group_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "reservationGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReservationGroupArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/ecs_capacity_provider#reservation_preference EcsCapacityProvider#reservation_preference}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "reservationPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReservationPreference
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
