using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsNamespaceLookup
{
    [JsiiByValue(fqn: "oci.logAnalyticsNamespaceLookup.LogAnalyticsNamespaceLookupFields")]
    public class LogAnalyticsNamespaceLookupFields : oci.LogAnalyticsNamespaceLookup.ILogAnalyticsNamespaceLookupFields
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookup#common_field_name LogAnalyticsNamespaceLookup#common_field_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "commonFieldName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CommonFieldName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookup#default_match_value LogAnalyticsNamespaceLookup#default_match_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultMatchValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultMatchValue
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookup#display_name LogAnalyticsNamespaceLookup#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }

        private object? _isCommonField;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookup#is_common_field LogAnalyticsNamespaceLookup#is_common_field}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isCommonField", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsCommonField
        {
            get => _isCommonField;
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
                _isCommonField = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookup#match_operator LogAnalyticsNamespaceLookup#match_operator}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "matchOperator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MatchOperator
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookup#name LogAnalyticsNamespaceLookup#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookup#position LogAnalyticsNamespaceLookup#position}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "position", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Position
        {
            get;
            set;
        }
    }
}
