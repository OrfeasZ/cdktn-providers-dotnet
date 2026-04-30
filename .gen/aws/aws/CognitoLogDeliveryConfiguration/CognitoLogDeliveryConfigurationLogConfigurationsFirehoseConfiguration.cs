using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoLogDeliveryConfiguration
{
    [JsiiByValue(fqn: "aws.cognitoLogDeliveryConfiguration.CognitoLogDeliveryConfigurationLogConfigurationsFirehoseConfiguration")]
    public class CognitoLogDeliveryConfigurationLogConfigurationsFirehoseConfiguration : aws.CognitoLogDeliveryConfiguration.ICognitoLogDeliveryConfigurationLogConfigurationsFirehoseConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cognito_log_delivery_configuration#stream_arn CognitoLogDeliveryConfiguration#stream_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "streamArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StreamArn
        {
            get;
            set;
        }
    }
}
