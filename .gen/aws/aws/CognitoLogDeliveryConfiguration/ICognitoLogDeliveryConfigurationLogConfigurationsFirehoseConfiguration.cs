using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoLogDeliveryConfiguration
{
    [JsiiInterface(nativeType: typeof(ICognitoLogDeliveryConfigurationLogConfigurationsFirehoseConfiguration), fullyQualifiedName: "aws.cognitoLogDeliveryConfiguration.CognitoLogDeliveryConfigurationLogConfigurationsFirehoseConfiguration")]
    public interface ICognitoLogDeliveryConfigurationLogConfigurationsFirehoseConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cognito_log_delivery_configuration#stream_arn CognitoLogDeliveryConfiguration#stream_arn}.</summary>
        [JsiiProperty(name: "streamArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StreamArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoLogDeliveryConfigurationLogConfigurationsFirehoseConfiguration), fullyQualifiedName: "aws.cognitoLogDeliveryConfiguration.CognitoLogDeliveryConfigurationLogConfigurationsFirehoseConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.CognitoLogDeliveryConfiguration.ICognitoLogDeliveryConfigurationLogConfigurationsFirehoseConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cognito_log_delivery_configuration#stream_arn CognitoLogDeliveryConfiguration#stream_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "streamArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StreamArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
