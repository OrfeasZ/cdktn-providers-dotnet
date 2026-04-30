using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoLogDeliveryConfiguration
{
    [JsiiInterface(nativeType: typeof(ICognitoLogDeliveryConfigurationLogConfigurationsS3Configuration), fullyQualifiedName: "aws.cognitoLogDeliveryConfiguration.CognitoLogDeliveryConfigurationLogConfigurationsS3Configuration")]
    public interface ICognitoLogDeliveryConfigurationLogConfigurationsS3Configuration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cognito_log_delivery_configuration#bucket_arn CognitoLogDeliveryConfiguration#bucket_arn}.</summary>
        [JsiiProperty(name: "bucketArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BucketArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoLogDeliveryConfigurationLogConfigurationsS3Configuration), fullyQualifiedName: "aws.cognitoLogDeliveryConfiguration.CognitoLogDeliveryConfigurationLogConfigurationsS3Configuration")]
        internal sealed class _Proxy : DeputyBase, aws.CognitoLogDeliveryConfiguration.ICognitoLogDeliveryConfigurationLogConfigurationsS3Configuration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cognito_log_delivery_configuration#bucket_arn CognitoLogDeliveryConfiguration#bucket_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bucketArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BucketArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
