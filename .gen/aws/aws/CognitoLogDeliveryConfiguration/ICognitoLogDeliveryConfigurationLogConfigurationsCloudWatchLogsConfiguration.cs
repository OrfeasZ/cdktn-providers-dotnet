using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoLogDeliveryConfiguration
{
    [JsiiInterface(nativeType: typeof(ICognitoLogDeliveryConfigurationLogConfigurationsCloudWatchLogsConfiguration), fullyQualifiedName: "aws.cognitoLogDeliveryConfiguration.CognitoLogDeliveryConfigurationLogConfigurationsCloudWatchLogsConfiguration")]
    public interface ICognitoLogDeliveryConfigurationLogConfigurationsCloudWatchLogsConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cognito_log_delivery_configuration#log_group_arn CognitoLogDeliveryConfiguration#log_group_arn}.</summary>
        [JsiiProperty(name: "logGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogGroupArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoLogDeliveryConfigurationLogConfigurationsCloudWatchLogsConfiguration), fullyQualifiedName: "aws.cognitoLogDeliveryConfiguration.CognitoLogDeliveryConfigurationLogConfigurationsCloudWatchLogsConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.CognitoLogDeliveryConfiguration.ICognitoLogDeliveryConfigurationLogConfigurationsCloudWatchLogsConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cognito_log_delivery_configuration#log_group_arn CognitoLogDeliveryConfiguration#log_group_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogGroupArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
