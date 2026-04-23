using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AthenaWorkgroup
{
    [JsiiInterface(nativeType: typeof(IAthenaWorkgroupConfigurationMonitoringConfigurationCloudWatchLoggingConfiguration), fullyQualifiedName: "aws.athenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfigurationCloudWatchLoggingConfiguration")]
    public interface IAthenaWorkgroupConfigurationMonitoringConfigurationCloudWatchLoggingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/athena_workgroup#enabled AthenaWorkgroup#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/athena_workgroup#log_group AthenaWorkgroup#log_group}.</summary>
        [JsiiProperty(name: "logGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/athena_workgroup#log_stream_name_prefix AthenaWorkgroup#log_stream_name_prefix}.</summary>
        [JsiiProperty(name: "logStreamNamePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogStreamNamePrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>log_type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/athena_workgroup#log_type AthenaWorkgroup#log_type}
        /// </remarks>
        [JsiiProperty(name: "logType", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfigurationCloudWatchLoggingConfigurationLogType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LogType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAthenaWorkgroupConfigurationMonitoringConfigurationCloudWatchLoggingConfiguration), fullyQualifiedName: "aws.athenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfigurationCloudWatchLoggingConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationMonitoringConfigurationCloudWatchLoggingConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/athena_workgroup#enabled AthenaWorkgroup#enabled}.</summary>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/athena_workgroup#log_group AthenaWorkgroup#log_group}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogGroup
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/athena_workgroup#log_stream_name_prefix AthenaWorkgroup#log_stream_name_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logStreamNamePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogStreamNamePrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>log_type block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/athena_workgroup#log_type AthenaWorkgroup#log_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logType", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfigurationCloudWatchLoggingConfigurationLogType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LogType
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
