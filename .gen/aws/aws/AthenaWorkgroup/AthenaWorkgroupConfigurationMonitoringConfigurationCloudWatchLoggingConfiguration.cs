using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AthenaWorkgroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.athenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfigurationCloudWatchLoggingConfiguration")]
    public class AthenaWorkgroupConfigurationMonitoringConfigurationCloudWatchLoggingConfiguration : aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationMonitoringConfigurationCloudWatchLoggingConfiguration
    {
        private object _enabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#enabled AthenaWorkgroup#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object Enabled
        {
            get => _enabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#log_group AthenaWorkgroup#log_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#log_stream_name_prefix AthenaWorkgroup#log_stream_name_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logStreamNamePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogStreamNamePrefix
        {
            get;
            set;
        }

        private object? _logType;

        /// <summary>log_type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/athena_workgroup#log_type AthenaWorkgroup#log_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logType", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationMonitoringConfigurationCloudWatchLoggingConfigurationLogType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LogType
        {
            get => _logType;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationMonitoringConfigurationCloudWatchLoggingConfigurationLogType[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationMonitoringConfigurationCloudWatchLoggingConfigurationLogType).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _logType = value;
            }
        }
    }
}
