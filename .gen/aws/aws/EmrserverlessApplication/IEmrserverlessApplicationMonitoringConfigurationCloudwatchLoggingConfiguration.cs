using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrserverlessApplication
{
    [JsiiInterface(nativeType: typeof(IEmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfiguration), fullyQualifiedName: "aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfiguration")]
    public interface IEmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#enabled EmrserverlessApplication#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#encryption_key_arn EmrserverlessApplication#encryption_key_arn}.</summary>
        [JsiiProperty(name: "encryptionKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EncryptionKeyArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#log_group_name EmrserverlessApplication#log_group_name}.</summary>
        [JsiiProperty(name: "logGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogGroupName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#log_stream_name_prefix EmrserverlessApplication#log_stream_name_prefix}.</summary>
        [JsiiProperty(name: "logStreamNamePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogStreamNamePrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>log_types block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#log_types EmrserverlessApplication#log_types}
        /// </remarks>
        [JsiiProperty(name: "logTypes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfigurationLogTypes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LogTypes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfiguration), fullyQualifiedName: "aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#enabled EmrserverlessApplication#enabled}.</summary>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#encryption_key_arn EmrserverlessApplication#encryption_key_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EncryptionKeyArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#log_group_name EmrserverlessApplication#log_group_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogGroupName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#log_stream_name_prefix EmrserverlessApplication#log_stream_name_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logStreamNamePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogStreamNamePrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>log_types block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#log_types EmrserverlessApplication#log_types}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logTypes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfigurationLogTypes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LogTypes
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
