using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerEndpointConfiguration
{
    [JsiiInterface(nativeType: typeof(ISagemakerEndpointConfigurationProductionVariantsCapacityReservationConfig), fullyQualifiedName: "aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationProductionVariantsCapacityReservationConfig")]
    public interface ISagemakerEndpointConfigurationProductionVariantsCapacityReservationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/sagemaker_endpoint_configuration#capacity_reservation_preference SagemakerEndpointConfiguration#capacity_reservation_preference}.</summary>
        [JsiiProperty(name: "capacityReservationPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CapacityReservationPreference
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/sagemaker_endpoint_configuration#ml_reservation_arn SagemakerEndpointConfiguration#ml_reservation_arn}.</summary>
        [JsiiProperty(name: "mlReservationArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MlReservationArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerEndpointConfigurationProductionVariantsCapacityReservationConfig), fullyQualifiedName: "aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationProductionVariantsCapacityReservationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationProductionVariantsCapacityReservationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/sagemaker_endpoint_configuration#capacity_reservation_preference SagemakerEndpointConfiguration#capacity_reservation_preference}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "capacityReservationPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CapacityReservationPreference
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/sagemaker_endpoint_configuration#ml_reservation_arn SagemakerEndpointConfiguration#ml_reservation_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mlReservationArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MlReservationArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
