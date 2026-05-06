using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsNamespaceLookup
{
    [JsiiInterface(nativeType: typeof(ILogAnalyticsNamespaceLookupFields), fullyQualifiedName: "oci.logAnalyticsNamespaceLookup.LogAnalyticsNamespaceLookupFields")]
    public interface ILogAnalyticsNamespaceLookupFields
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookup#common_field_name LogAnalyticsNamespaceLookup#common_field_name}.</summary>
        [JsiiProperty(name: "commonFieldName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CommonFieldName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookup#default_match_value LogAnalyticsNamespaceLookup#default_match_value}.</summary>
        [JsiiProperty(name: "defaultMatchValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultMatchValue
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookup#display_name LogAnalyticsNamespaceLookup#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookup#is_common_field LogAnalyticsNamespaceLookup#is_common_field}.</summary>
        [JsiiProperty(name: "isCommonField", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsCommonField
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookup#match_operator LogAnalyticsNamespaceLookup#match_operator}.</summary>
        [JsiiProperty(name: "matchOperator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MatchOperator
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookup#name LogAnalyticsNamespaceLookup#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookup#position LogAnalyticsNamespaceLookup#position}.</summary>
        [JsiiProperty(name: "position", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Position
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILogAnalyticsNamespaceLookupFields), fullyQualifiedName: "oci.logAnalyticsNamespaceLookup.LogAnalyticsNamespaceLookupFields")]
        internal sealed class _Proxy : DeputyBase, oci.LogAnalyticsNamespaceLookup.ILogAnalyticsNamespaceLookupFields
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookup#common_field_name LogAnalyticsNamespaceLookup#common_field_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "commonFieldName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CommonFieldName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookup#default_match_value LogAnalyticsNamespaceLookup#default_match_value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultMatchValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultMatchValue
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookup#display_name LogAnalyticsNamespaceLookup#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookup#is_common_field LogAnalyticsNamespaceLookup#is_common_field}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isCommonField", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsCommonField
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookup#match_operator LogAnalyticsNamespaceLookup#match_operator}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "matchOperator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MatchOperator
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookup#name LogAnalyticsNamespaceLookup#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookup#position LogAnalyticsNamespaceLookup#position}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "position", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Position
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
