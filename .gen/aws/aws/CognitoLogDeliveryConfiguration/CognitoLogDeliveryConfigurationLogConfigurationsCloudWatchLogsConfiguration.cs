using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoLogDeliveryConfiguration
{
    [JsiiByValue(fqn: "aws.cognitoLogDeliveryConfiguration.CognitoLogDeliveryConfigurationLogConfigurationsCloudWatchLogsConfiguration")]
    public class CognitoLogDeliveryConfigurationLogConfigurationsCloudWatchLogsConfiguration : aws.CognitoLogDeliveryConfiguration.ICognitoLogDeliveryConfigurationLogConfigurationsCloudWatchLogsConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cognito_log_delivery_configuration#log_group_arn CognitoLogDeliveryConfiguration#log_group_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogGroupArn
        {
            get;
            set;
        }
    }
}
