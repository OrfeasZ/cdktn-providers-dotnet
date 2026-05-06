using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoggingUnifiedAgentConfiguration
{
    [JsiiInterface(nativeType: typeof(ILoggingUnifiedAgentConfigurationServiceConfigurationSourcesParser), fullyQualifiedName: "oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationSourcesParser")]
    public interface ILoggingUnifiedAgentConfigurationServiceConfigurationSourcesParser
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#parser_type LoggingUnifiedAgentConfiguration#parser_type}.</summary>
        [JsiiProperty(name: "parserType", typeJson: "{\"primitive\":\"string\"}")]
        string ParserType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#delimiter LoggingUnifiedAgentConfiguration#delimiter}.</summary>
        [JsiiProperty(name: "delimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delimiter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#expression LoggingUnifiedAgentConfiguration#expression}.</summary>
        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Expression
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#field_time_key LoggingUnifiedAgentConfiguration#field_time_key}.</summary>
        [JsiiProperty(name: "fieldTimeKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FieldTimeKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#format LoggingUnifiedAgentConfiguration#format}.</summary>
        [JsiiProperty(name: "format", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Format
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#format_firstline LoggingUnifiedAgentConfiguration#format_firstline}.</summary>
        [JsiiProperty(name: "formatFirstline", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FormatFirstline
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#grok_failure_key LoggingUnifiedAgentConfiguration#grok_failure_key}.</summary>
        [JsiiProperty(name: "grokFailureKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GrokFailureKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#grok_name_key LoggingUnifiedAgentConfiguration#grok_name_key}.</summary>
        [JsiiProperty(name: "grokNameKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GrokNameKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#is_estimate_current_event LoggingUnifiedAgentConfiguration#is_estimate_current_event}.</summary>
        [JsiiProperty(name: "isEstimateCurrentEvent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsEstimateCurrentEvent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#is_keep_time_key LoggingUnifiedAgentConfiguration#is_keep_time_key}.</summary>
        [JsiiProperty(name: "isKeepTimeKey", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsKeepTimeKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#is_merge_cri_fields LoggingUnifiedAgentConfiguration#is_merge_cri_fields}.</summary>
        [JsiiProperty(name: "isMergeCriFields", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsMergeCriFields
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#is_null_empty_string LoggingUnifiedAgentConfiguration#is_null_empty_string}.</summary>
        [JsiiProperty(name: "isNullEmptyString", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsNullEmptyString
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#is_support_colonless_ident LoggingUnifiedAgentConfiguration#is_support_colonless_ident}.</summary>
        [JsiiProperty(name: "isSupportColonlessIdent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsSupportColonlessIdent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#is_with_priority LoggingUnifiedAgentConfiguration#is_with_priority}.</summary>
        [JsiiProperty(name: "isWithPriority", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsWithPriority
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#keys LoggingUnifiedAgentConfiguration#keys}.</summary>
        [JsiiProperty(name: "keys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Keys
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#message_format LoggingUnifiedAgentConfiguration#message_format}.</summary>
        [JsiiProperty(name: "messageFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MessageFormat
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#message_key LoggingUnifiedAgentConfiguration#message_key}.</summary>
        [JsiiProperty(name: "messageKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MessageKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#multi_line_start_regexp LoggingUnifiedAgentConfiguration#multi_line_start_regexp}.</summary>
        [JsiiProperty(name: "multiLineStartRegexp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MultiLineStartRegexp
        {
            get
            {
                return null;
            }
        }

        /// <summary>nested_parser block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#nested_parser LoggingUnifiedAgentConfiguration#nested_parser}
        /// </remarks>
        [JsiiProperty(name: "nestedParser", typeJson: "{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationSourcesParserNestedParser\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationSourcesParserNestedParser? NestedParser
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#null_value_pattern LoggingUnifiedAgentConfiguration#null_value_pattern}.</summary>
        [JsiiProperty(name: "nullValuePattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NullValuePattern
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#parse_nested LoggingUnifiedAgentConfiguration#parse_nested}.</summary>
        [JsiiProperty(name: "parseNested", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ParseNested
        {
            get
            {
                return null;
            }
        }

        /// <summary>patterns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#patterns LoggingUnifiedAgentConfiguration#patterns}
        /// </remarks>
        [JsiiProperty(name: "patterns", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationSourcesParserPatterns\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Patterns
        {
            get
            {
                return null;
            }
        }

        /// <summary>record_input block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#record_input LoggingUnifiedAgentConfiguration#record_input}
        /// </remarks>
        [JsiiProperty(name: "recordInput", typeJson: "{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationSourcesParserRecordInput\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationSourcesParserRecordInput? RecordInput
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#rfc5424time_format LoggingUnifiedAgentConfiguration#rfc5424time_format}.</summary>
        [JsiiProperty(name: "rfc5424TimeFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Rfc5424TimeFormat
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#separator LoggingUnifiedAgentConfiguration#separator}.</summary>
        [JsiiProperty(name: "separator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Separator
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#syslog_parser_type LoggingUnifiedAgentConfiguration#syslog_parser_type}.</summary>
        [JsiiProperty(name: "syslogParserType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SyslogParserType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#time_format LoggingUnifiedAgentConfiguration#time_format}.</summary>
        [JsiiProperty(name: "timeFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeFormat
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#timeout_in_milliseconds LoggingUnifiedAgentConfiguration#timeout_in_milliseconds}.</summary>
        [JsiiProperty(name: "timeoutInMilliseconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TimeoutInMilliseconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#time_type LoggingUnifiedAgentConfiguration#time_type}.</summary>
        [JsiiProperty(name: "timeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#types LoggingUnifiedAgentConfiguration#types}.</summary>
        [JsiiProperty(name: "types", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Types
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILoggingUnifiedAgentConfigurationServiceConfigurationSourcesParser), fullyQualifiedName: "oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationSourcesParser")]
        internal sealed class _Proxy : DeputyBase, oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationSourcesParser
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#parser_type LoggingUnifiedAgentConfiguration#parser_type}.</summary>
            [JsiiProperty(name: "parserType", typeJson: "{\"primitive\":\"string\"}")]
            public string ParserType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#delimiter LoggingUnifiedAgentConfiguration#delimiter}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delimiter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#expression LoggingUnifiedAgentConfiguration#expression}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Expression
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#field_time_key LoggingUnifiedAgentConfiguration#field_time_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fieldTimeKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FieldTimeKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#format LoggingUnifiedAgentConfiguration#format}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "format", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Format
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#format_firstline LoggingUnifiedAgentConfiguration#format_firstline}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "formatFirstline", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FormatFirstline
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#grok_failure_key LoggingUnifiedAgentConfiguration#grok_failure_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "grokFailureKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GrokFailureKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#grok_name_key LoggingUnifiedAgentConfiguration#grok_name_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "grokNameKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GrokNameKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#is_estimate_current_event LoggingUnifiedAgentConfiguration#is_estimate_current_event}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isEstimateCurrentEvent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsEstimateCurrentEvent
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#is_keep_time_key LoggingUnifiedAgentConfiguration#is_keep_time_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isKeepTimeKey", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsKeepTimeKey
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#is_merge_cri_fields LoggingUnifiedAgentConfiguration#is_merge_cri_fields}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isMergeCriFields", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsMergeCriFields
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#is_null_empty_string LoggingUnifiedAgentConfiguration#is_null_empty_string}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isNullEmptyString", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsNullEmptyString
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#is_support_colonless_ident LoggingUnifiedAgentConfiguration#is_support_colonless_ident}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isSupportColonlessIdent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsSupportColonlessIdent
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#is_with_priority LoggingUnifiedAgentConfiguration#is_with_priority}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isWithPriority", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsWithPriority
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#keys LoggingUnifiedAgentConfiguration#keys}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "keys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Keys
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#message_format LoggingUnifiedAgentConfiguration#message_format}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "messageFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MessageFormat
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#message_key LoggingUnifiedAgentConfiguration#message_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "messageKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MessageKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#multi_line_start_regexp LoggingUnifiedAgentConfiguration#multi_line_start_regexp}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "multiLineStartRegexp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MultiLineStartRegexp
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>nested_parser block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#nested_parser LoggingUnifiedAgentConfiguration#nested_parser}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nestedParser", typeJson: "{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationSourcesParserNestedParser\"}", isOptional: true)]
            public oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationSourcesParserNestedParser? NestedParser
            {
                get => GetInstanceProperty<oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationSourcesParserNestedParser?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#null_value_pattern LoggingUnifiedAgentConfiguration#null_value_pattern}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nullValuePattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NullValuePattern
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#parse_nested LoggingUnifiedAgentConfiguration#parse_nested}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "parseNested", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ParseNested
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>patterns block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#patterns LoggingUnifiedAgentConfiguration#patterns}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "patterns", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationSourcesParserPatterns\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Patterns
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>record_input block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#record_input LoggingUnifiedAgentConfiguration#record_input}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "recordInput", typeJson: "{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationSourcesParserRecordInput\"}", isOptional: true)]
            public oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationSourcesParserRecordInput? RecordInput
            {
                get => GetInstanceProperty<oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationSourcesParserRecordInput?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#rfc5424time_format LoggingUnifiedAgentConfiguration#rfc5424time_format}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rfc5424TimeFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Rfc5424TimeFormat
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#separator LoggingUnifiedAgentConfiguration#separator}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "separator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Separator
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#syslog_parser_type LoggingUnifiedAgentConfiguration#syslog_parser_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "syslogParserType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SyslogParserType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#time_format LoggingUnifiedAgentConfiguration#time_format}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeFormat
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#timeout_in_milliseconds LoggingUnifiedAgentConfiguration#timeout_in_milliseconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeoutInMilliseconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TimeoutInMilliseconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#time_type LoggingUnifiedAgentConfiguration#time_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#types LoggingUnifiedAgentConfiguration#types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "types", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Types
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}
