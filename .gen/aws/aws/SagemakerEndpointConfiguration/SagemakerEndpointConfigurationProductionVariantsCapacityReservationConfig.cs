using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerEndpointConfiguration
{
    [JsiiByValue(fqn: "aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationProductionVariantsCapacityReservationConfig")]
    public class SagemakerEndpointConfigurationProductionVariantsCapacityReservationConfig : aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationProductionVariantsCapacityReservationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/sagemaker_endpoint_configuration#capacity_reservation_preference SagemakerEndpointConfiguration#capacity_reservation_preference}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CapacityReservationPreference
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/sagemaker_endpoint_configuration#ml_reservation_arn SagemakerEndpointConfiguration#ml_reservation_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mlReservationArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MlReservationArn
        {
            get;
            set;
        }
    }
}
