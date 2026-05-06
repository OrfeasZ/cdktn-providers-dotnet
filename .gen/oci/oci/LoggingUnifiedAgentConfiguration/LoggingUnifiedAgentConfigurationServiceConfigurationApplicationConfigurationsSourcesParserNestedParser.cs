using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoggingUnifiedAgentConfiguration
{
    [JsiiByValue(fqn: "oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurationsSourcesParserNestedParser")]
    public class LoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurationsSourcesParserNestedParser : oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurationsSourcesParserNestedParser
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#field_time_key LoggingUnifiedAgentConfiguration#field_time_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fieldTimeKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FieldTimeKey
        {
            get;
            set;
        }

        private object? _isKeepTimeKey;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#is_keep_time_key LoggingUnifiedAgentConfiguration#is_keep_time_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isKeepTimeKey", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsKeepTimeKey
        {
            get => _isKeepTimeKey;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isKeepTimeKey = value;
            }
        }

        private object? _parseNested;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#parse_nested LoggingUnifiedAgentConfiguration#parse_nested}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parseNested", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ParseNested
        {
            get => _parseNested;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _parseNested = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#separator LoggingUnifiedAgentConfiguration#separator}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "separator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Separator
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#time_format LoggingUnifiedAgentConfiguration#time_format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeFormat
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#time_type LoggingUnifiedAgentConfiguration#time_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeType
        {
            get;
            set;
        }
    }
}
