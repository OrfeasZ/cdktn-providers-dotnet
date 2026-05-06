using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmConfigConfig
{
    [JsiiInterface(nativeType: typeof(IApmConfigConfigRules), fullyQualifiedName: "oci.apmConfigConfig.ApmConfigConfigRules")]
    public interface IApmConfigConfigRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_config_config#display_name ApmConfigConfig#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_config_config#filter_text ApmConfigConfig#filter_text}.</summary>
        [JsiiProperty(name: "filterText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FilterText
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_config_config#is_apply_to_error_spans ApmConfigConfig#is_apply_to_error_spans}.</summary>
        [JsiiProperty(name: "isApplyToErrorSpans", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsApplyToErrorSpans
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_config_config#is_enabled ApmConfigConfig#is_enabled}.</summary>
        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_config_config#priority ApmConfigConfig#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Priority
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_config_config#satisfied_response_time ApmConfigConfig#satisfied_response_time}.</summary>
        [JsiiProperty(name: "satisfiedResponseTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SatisfiedResponseTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_config_config#tolerating_response_time ApmConfigConfig#tolerating_response_time}.</summary>
        [JsiiProperty(name: "toleratingResponseTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ToleratingResponseTime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApmConfigConfigRules), fullyQualifiedName: "oci.apmConfigConfig.ApmConfigConfigRules")]
        internal sealed class _Proxy : DeputyBase, oci.ApmConfigConfig.IApmConfigConfigRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_config_config#display_name ApmConfigConfig#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_config_config#filter_text ApmConfigConfig#filter_text}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "filterText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FilterText
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_config_config#is_apply_to_error_spans ApmConfigConfig#is_apply_to_error_spans}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isApplyToErrorSpans", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsApplyToErrorSpans
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_config_config#is_enabled ApmConfigConfig#is_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_config_config#priority ApmConfigConfig#priority}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Priority
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_config_config#satisfied_response_time ApmConfigConfig#satisfied_response_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "satisfiedResponseTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SatisfiedResponseTime
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_config_config#tolerating_response_time ApmConfigConfig#tolerating_response_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "toleratingResponseTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ToleratingResponseTime
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
