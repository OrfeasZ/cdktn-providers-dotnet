using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoLogDeliveryConfiguration
{
    [JsiiInterface(nativeType: typeof(ICognitoLogDeliveryConfigurationLogConfigurations), fullyQualifiedName: "aws.cognitoLogDeliveryConfiguration.CognitoLogDeliveryConfigurationLogConfigurations")]
    public interface ICognitoLogDeliveryConfigurationLogConfigurations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cognito_log_delivery_configuration#event_source CognitoLogDeliveryConfiguration#event_source}.</summary>
        [JsiiProperty(name: "eventSource", typeJson: "{\"primitive\":\"string\"}")]
        string EventSource
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cognito_log_delivery_configuration#log_level CognitoLogDeliveryConfiguration#log_level}.</summary>
        [JsiiProperty(name: "logLevel", typeJson: "{\"primitive\":\"string\"}")]
        string LogLevel
        {
            get;
        }

        /// <summary>cloud_watch_logs_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cognito_log_delivery_configuration#cloud_watch_logs_configuration CognitoLogDeliveryConfiguration#cloud_watch_logs_configuration}
        /// </remarks>
        [JsiiProperty(name: "cloudWatchLogsConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cognitoLogDeliveryConfiguration.CognitoLogDeliveryConfigurationLogConfigurationsCloudWatchLogsConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CloudWatchLogsConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>firehose_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cognito_log_delivery_configuration#firehose_configuration CognitoLogDeliveryConfiguration#firehose_configuration}
        /// </remarks>
        [JsiiProperty(name: "firehoseConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cognitoLogDeliveryConfiguration.CognitoLogDeliveryConfigurationLogConfigurationsFirehoseConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FirehoseConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cognito_log_delivery_configuration#s3_configuration CognitoLogDeliveryConfiguration#s3_configuration}
        /// </remarks>
        [JsiiProperty(name: "s3Configuration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cognitoLogDeliveryConfiguration.CognitoLogDeliveryConfigurationLogConfigurationsS3Configuration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? S3Configuration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoLogDeliveryConfigurationLogConfigurations), fullyQualifiedName: "aws.cognitoLogDeliveryConfiguration.CognitoLogDeliveryConfigurationLogConfigurations")]
        internal sealed class _Proxy : DeputyBase, aws.CognitoLogDeliveryConfiguration.ICognitoLogDeliveryConfigurationLogConfigurations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cognito_log_delivery_configuration#event_source CognitoLogDeliveryConfiguration#event_source}.</summary>
            [JsiiProperty(name: "eventSource", typeJson: "{\"primitive\":\"string\"}")]
            public string EventSource
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cognito_log_delivery_configuration#log_level CognitoLogDeliveryConfiguration#log_level}.</summary>
            [JsiiProperty(name: "logLevel", typeJson: "{\"primitive\":\"string\"}")]
            public string LogLevel
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>cloud_watch_logs_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cognito_log_delivery_configuration#cloud_watch_logs_configuration CognitoLogDeliveryConfiguration#cloud_watch_logs_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudWatchLogsConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cognitoLogDeliveryConfiguration.CognitoLogDeliveryConfigurationLogConfigurationsCloudWatchLogsConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CloudWatchLogsConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>firehose_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cognito_log_delivery_configuration#firehose_configuration CognitoLogDeliveryConfiguration#firehose_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "firehoseConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cognitoLogDeliveryConfiguration.CognitoLogDeliveryConfigurationLogConfigurationsFirehoseConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FirehoseConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>s3_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cognito_log_delivery_configuration#s3_configuration CognitoLogDeliveryConfiguration#s3_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3Configuration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cognitoLogDeliveryConfiguration.CognitoLogDeliveryConfigurationLogConfigurationsS3Configuration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? S3Configuration
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
