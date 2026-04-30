using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrserverlessApplication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfiguration")]
    public class EmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfiguration : aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfiguration
    {
        private object _enabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#enabled EmrserverlessApplication#enabled}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#encryption_key_arn EmrserverlessApplication#encryption_key_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EncryptionKeyArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#log_group_name EmrserverlessApplication#log_group_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#log_stream_name_prefix EmrserverlessApplication#log_stream_name_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logStreamNamePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogStreamNamePrefix
        {
            get;
            set;
        }

        private object? _logTypes;

        /// <summary>log_types block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#log_types EmrserverlessApplication#log_types}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logTypes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrserverlessApplication.EmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfigurationLogTypes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LogTypes
        {
            get => _logTypes;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfigurationLogTypes[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.EmrserverlessApplication.IEmrserverlessApplicationMonitoringConfigurationCloudwatchLoggingConfigurationLogTypes).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _logTypes = value;
            }
        }
    }
}
