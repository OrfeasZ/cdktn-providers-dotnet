using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchLogDeliveryDestination
{
    [JsiiByValue(fqn: "aws.cloudwatchLogDeliveryDestination.CloudwatchLogDeliveryDestinationDeliveryDestinationConfiguration")]
    public class CloudwatchLogDeliveryDestinationDeliveryDestinationConfiguration : aws.CloudwatchLogDeliveryDestination.ICloudwatchLogDeliveryDestinationDeliveryDestinationConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudwatch_log_delivery_destination#destination_resource_arn CloudwatchLogDeliveryDestination#destination_resource_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationResourceArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationResourceArn
        {
            get;
            set;
        }
    }
}
