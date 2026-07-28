using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApplicationGateway
{
    [JsiiInterface(nativeType: typeof(IApplicationGatewayWafConfiguration), fullyQualifiedName: "azurerm.applicationGateway.ApplicationGatewayWafConfiguration")]
    public interface IApplicationGatewayWafConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/application_gateway#enabled ApplicationGateway#enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/application_gateway#firewall_mode ApplicationGateway#firewall_mode}.</summary>
        [JsiiProperty(name: "firewallMode", typeJson: "{\"primitive\":\"string\"}")]
        string FirewallMode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/application_gateway#rule_set_version ApplicationGateway#rule_set_version}.</summary>
        [JsiiProperty(name: "ruleSetVersion", typeJson: "{\"primitive\":\"string\"}")]
        string RuleSetVersion
        {
            get;
        }

        /// <summary>disabled_rule_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/application_gateway#disabled_rule_group ApplicationGateway#disabled_rule_group}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayWafConfigurationDisabledRuleGroup" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "disabledRuleGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayWafConfigurationDisabledRuleGroup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisabledRuleGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>exclusion block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/application_gateway#exclusion ApplicationGateway#exclusion}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayWafConfigurationExclusion" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "exclusion", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayWafConfigurationExclusion\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Exclusion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/application_gateway#file_upload_limit_mb ApplicationGateway#file_upload_limit_mb}.</summary>
        [JsiiProperty(name: "fileUploadLimitMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FileUploadLimitMb
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/application_gateway#max_request_body_size_kb ApplicationGateway#max_request_body_size_kb}.</summary>
        [JsiiProperty(name: "maxRequestBodySizeKb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxRequestBodySizeKb
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/application_gateway#request_body_check ApplicationGateway#request_body_check}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "requestBodyCheck", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequestBodyCheck
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/application_gateway#rule_set_type ApplicationGateway#rule_set_type}.</summary>
        [JsiiProperty(name: "ruleSetType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RuleSetType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApplicationGatewayWafConfiguration), fullyQualifiedName: "azurerm.applicationGateway.ApplicationGatewayWafConfiguration")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApplicationGateway.IApplicationGatewayWafConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/application_gateway#enabled ApplicationGateway#enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/application_gateway#firewall_mode ApplicationGateway#firewall_mode}.</summary>
            [JsiiProperty(name: "firewallMode", typeJson: "{\"primitive\":\"string\"}")]
            public string FirewallMode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/application_gateway#rule_set_version ApplicationGateway#rule_set_version}.</summary>
            [JsiiProperty(name: "ruleSetVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string RuleSetVersion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>disabled_rule_group block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/application_gateway#disabled_rule_group ApplicationGateway#disabled_rule_group}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayWafConfigurationDisabledRuleGroup" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "disabledRuleGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayWafConfigurationDisabledRuleGroup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DisabledRuleGroup
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>exclusion block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/application_gateway#exclusion ApplicationGateway#exclusion}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayWafConfigurationExclusion" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "exclusion", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayWafConfigurationExclusion\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Exclusion
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/application_gateway#file_upload_limit_mb ApplicationGateway#file_upload_limit_mb}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fileUploadLimitMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FileUploadLimitMb
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/application_gateway#max_request_body_size_kb ApplicationGateway#max_request_body_size_kb}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxRequestBodySizeKb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxRequestBodySizeKb
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/application_gateway#request_body_check ApplicationGateway#request_body_check}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestBodyCheck", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? RequestBodyCheck
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/application_gateway#rule_set_type ApplicationGateway#rule_set_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ruleSetType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RuleSetType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
