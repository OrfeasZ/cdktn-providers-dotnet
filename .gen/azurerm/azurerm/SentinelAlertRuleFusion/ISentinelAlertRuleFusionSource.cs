using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SentinelAlertRuleFusion
{
    [JsiiInterface(nativeType: typeof(ISentinelAlertRuleFusionSource), fullyQualifiedName: "azurerm.sentinelAlertRuleFusion.SentinelAlertRuleFusionSource")]
    public interface ISentinelAlertRuleFusionSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/sentinel_alert_rule_fusion#name SentinelAlertRuleFusion#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/sentinel_alert_rule_fusion#enabled SentinelAlertRuleFusion#enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>sub_type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/sentinel_alert_rule_fusion#sub_type SentinelAlertRuleFusion#sub_type}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SentinelAlertRuleFusion.ISentinelAlertRuleFusionSourceSubType" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "subType", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.sentinelAlertRuleFusion.SentinelAlertRuleFusionSourceSubType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SubType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISentinelAlertRuleFusionSource), fullyQualifiedName: "azurerm.sentinelAlertRuleFusion.SentinelAlertRuleFusionSource")]
        internal sealed class _Proxy : DeputyBase, azurerm.SentinelAlertRuleFusion.ISentinelAlertRuleFusionSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/sentinel_alert_rule_fusion#name SentinelAlertRuleFusion#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/sentinel_alert_rule_fusion#enabled SentinelAlertRuleFusion#enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>sub_type block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/sentinel_alert_rule_fusion#sub_type SentinelAlertRuleFusion#sub_type}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SentinelAlertRuleFusion.ISentinelAlertRuleFusionSourceSubType" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "subType", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.sentinelAlertRuleFusion.SentinelAlertRuleFusionSourceSubType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SubType
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
