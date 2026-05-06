using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoggingUnifiedAgentConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterParser")]
    public class LoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterParser : oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterParser
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#parser_type LoggingUnifiedAgentConfiguration#parser_type}.</summary>
        [JsiiProperty(name: "parserType", typeJson: "{\"primitive\":\"string\"}")]
        public string ParserType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#delimiter LoggingUnifiedAgentConfiguration#delimiter}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delimiter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#expression LoggingUnifiedAgentConfiguration#expression}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Expression
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#field_time_key LoggingUnifiedAgentConfiguration#field_time_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fieldTimeKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FieldTimeKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#format LoggingUnifiedAgentConfiguration#format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "format", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Format
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#format_firstline LoggingUnifiedAgentConfiguration#format_firstline}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "formatFirstline", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FormatFirstline
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#grok_failure_key LoggingUnifiedAgentConfiguration#grok_failure_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "grokFailureKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GrokFailureKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#grok_name_key LoggingUnifiedAgentConfiguration#grok_name_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "grokNameKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GrokNameKey
        {
            get;
            set;
        }

        private object? _isEstimateCurrentEvent;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#is_estimate_current_event LoggingUnifiedAgentConfiguration#is_estimate_current_event}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isEstimateCurrentEvent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsEstimateCurrentEvent
        {
            get => _isEstimateCurrentEvent;
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
                _isEstimateCurrentEvent = value;
            }
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

        private object? _isMergeCriFields;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#is_merge_cri_fields LoggingUnifiedAgentConfiguration#is_merge_cri_fields}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isMergeCriFields", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsMergeCriFields
        {
            get => _isMergeCriFields;
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
                _isMergeCriFields = value;
            }
        }

        private object? _isNullEmptyString;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#is_null_empty_string LoggingUnifiedAgentConfiguration#is_null_empty_string}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isNullEmptyString", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsNullEmptyString
        {
            get => _isNullEmptyString;
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
                _isNullEmptyString = value;
            }
        }

        private object? _isSupportColonlessIdent;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#is_support_colonless_ident LoggingUnifiedAgentConfiguration#is_support_colonless_ident}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isSupportColonlessIdent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsSupportColonlessIdent
        {
            get => _isSupportColonlessIdent;
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
                _isSupportColonlessIdent = value;
            }
        }

        private object? _isWithPriority;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#is_with_priority LoggingUnifiedAgentConfiguration#is_with_priority}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isWithPriority", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsWithPriority
        {
            get => _isWithPriority;
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
                _isWithPriority = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#keys LoggingUnifiedAgentConfiguration#keys}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Keys
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#message_format LoggingUnifiedAgentConfiguration#message_format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "messageFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MessageFormat
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#message_key LoggingUnifiedAgentConfiguration#message_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "messageKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MessageKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#multi_line_start_regexp LoggingUnifiedAgentConfiguration#multi_line_start_regexp}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "multiLineStartRegexp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MultiLineStartRegexp
        {
            get;
            set;
        }

        /// <summary>nested_parser block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#nested_parser LoggingUnifiedAgentConfiguration#nested_parser}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nestedParser", typeJson: "{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterParserNestedParser\"}", isOptional: true)]
        public oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterParserNestedParser? NestedParser
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#null_value_pattern LoggingUnifiedAgentConfiguration#null_value_pattern}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nullValuePattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NullValuePattern
        {
            get;
            set;
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

        private object? _patterns;

        /// <summary>patterns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#patterns LoggingUnifiedAgentConfiguration#patterns}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "patterns", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterParserPatterns\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Patterns
        {
            get => _patterns;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterParserPatterns[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterParserPatterns).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _patterns = value;
            }
        }

        /// <summary>record_input block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#record_input LoggingUnifiedAgentConfiguration#record_input}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "recordInput", typeJson: "{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterParserRecordInput\"}", isOptional: true)]
        public oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilterParserRecordInput? RecordInput
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#rfc5424time_format LoggingUnifiedAgentConfiguration#rfc5424time_format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rfc5424TimeFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Rfc5424TimeFormat
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#separator LoggingUnifiedAgentConfiguration#separator}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "separator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Separator
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#syslog_parser_type LoggingUnifiedAgentConfiguration#syslog_parser_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "syslogParserType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SyslogParserType
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#timeout_in_milliseconds LoggingUnifiedAgentConfiguration#timeout_in_milliseconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutInMilliseconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TimeoutInMilliseconds
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#types LoggingUnifiedAgentConfiguration#types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "types", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Types
        {
            get;
            set;
        }
    }
}
