using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DynatraceTagRules
{
    [JsiiInterface(nativeType: typeof(IDynatraceTagRulesMetricRule), fullyQualifiedName: "azurerm.dynatraceTagRules.DynatraceTagRulesMetricRule")]
    public interface IDynatraceTagRulesMetricRule
    {
        /// <summary>filtering_tag block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/dynatrace_tag_rules#filtering_tag DynatraceTagRules#filtering_tag}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.DynatraceTagRules.IDynatraceTagRulesMetricRuleFilteringTag" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "filteringTag", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.dynatraceTagRules.DynatraceTagRulesMetricRuleFilteringTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FilteringTag
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/dynatrace_tag_rules#sending_metrics_enabled DynatraceTagRules#sending_metrics_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "sendingMetricsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SendingMetricsEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDynatraceTagRulesMetricRule), fullyQualifiedName: "azurerm.dynatraceTagRules.DynatraceTagRulesMetricRule")]
        internal sealed class _Proxy : DeputyBase, azurerm.DynatraceTagRules.IDynatraceTagRulesMetricRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>filtering_tag block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/dynatrace_tag_rules#filtering_tag DynatraceTagRules#filtering_tag}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.DynatraceTagRules.IDynatraceTagRulesMetricRuleFilteringTag" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filteringTag", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.dynatraceTagRules.DynatraceTagRulesMetricRuleFilteringTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FilteringTag
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/dynatrace_tag_rules#sending_metrics_enabled DynatraceTagRules#sending_metrics_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sendingMetricsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SendingMetricsEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
