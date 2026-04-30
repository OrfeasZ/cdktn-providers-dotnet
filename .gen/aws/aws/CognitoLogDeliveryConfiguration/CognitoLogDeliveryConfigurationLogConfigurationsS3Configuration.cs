using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoLogDeliveryConfiguration
{
    [JsiiByValue(fqn: "aws.cognitoLogDeliveryConfiguration.CognitoLogDeliveryConfigurationLogConfigurationsS3Configuration")]
    public class CognitoLogDeliveryConfigurationLogConfigurationsS3Configuration : aws.CognitoLogDeliveryConfiguration.ICognitoLogDeliveryConfigurationLogConfigurationsS3Configuration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cognito_log_delivery_configuration#bucket_arn CognitoLogDeliveryConfiguration#bucket_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bucketArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BucketArn
        {
            get;
            set;
        }
    }
}
