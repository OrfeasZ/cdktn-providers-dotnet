using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DynatraceTagRules
{
    [JsiiByValue(fqn: "azurerm.dynatraceTagRules.DynatraceTagRulesMetricRule")]
    public class DynatraceTagRulesMetricRule : azurerm.DynatraceTagRules.IDynatraceTagRulesMetricRule
    {
        private object? _filteringTag;

        /// <summary>filtering_tag block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/dynatrace_tag_rules#filtering_tag DynatraceTagRules#filtering_tag}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.DynatraceTagRules.IDynatraceTagRulesMetricRuleFilteringTag" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filteringTag", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.dynatraceTagRules.DynatraceTagRulesMetricRuleFilteringTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FilteringTag
        {
            get => _filteringTag;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.DynatraceTagRules.IDynatraceTagRulesMetricRuleFilteringTag[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.DynatraceTagRules.IDynatraceTagRulesMetricRuleFilteringTag).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _filteringTag = value;
            }
        }

        private object? _sendingMetricsEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/dynatrace_tag_rules#sending_metrics_enabled DynatraceTagRules#sending_metrics_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sendingMetricsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? SendingMetricsEnabled
        {
            get => _sendingMetricsEnabled;
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
                _sendingMetricsEnabled = value;
            }
        }
    }
}
