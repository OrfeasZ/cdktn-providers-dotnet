using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerEndpointConfiguration
{
    [JsiiByValue(fqn: "aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationShadowProductionVariantsCapacityReservationConfig")]
    public class SagemakerEndpointConfigurationShadowProductionVariantsCapacityReservationConfig : aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationShadowProductionVariantsCapacityReservationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.54.0/docs/resources/sagemaker_endpoint_configuration#capacity_reservation_preference SagemakerEndpointConfiguration#capacity_reservation_preference}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CapacityReservationPreference
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.54.0/docs/resources/sagemaker_endpoint_configuration#ml_reservation_arn SagemakerEndpointConfiguration#ml_reservation_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mlReservationArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MlReservationArn
        {
            get;
            set;
        }
    }
}
