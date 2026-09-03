using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FrontdoorRulesEngine
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.frontdoorRulesEngine.FrontdoorRulesEngineRule")]
    public class FrontdoorRulesEngineRule : azurerm.FrontdoorRulesEngine.IFrontdoorRulesEngineRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/frontdoor_rules_engine#name FrontdoorRulesEngine#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/frontdoor_rules_engine#priority FrontdoorRulesEngine#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public double Priority
        {
            get;
            set;
        }

        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/frontdoor_rules_engine#action FrontdoorRulesEngine#action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"azurerm.frontdoorRulesEngine.FrontdoorRulesEngineRuleAction\"}", isOptional: true)]
        public azurerm.FrontdoorRulesEngine.IFrontdoorRulesEngineRuleAction? Action
        {
            get;
            set;
        }

        private object? _matchCondition;

        /// <summary>match_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/frontdoor_rules_engine#match_condition FrontdoorRulesEngine#match_condition}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.FrontdoorRulesEngine.IFrontdoorRulesEngineRuleMatchCondition" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "matchCondition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.frontdoorRulesEngine.FrontdoorRulesEngineRuleMatchCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MatchCondition
        {
            get => _matchCondition;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.FrontdoorRulesEngine.IFrontdoorRulesEngineRuleMatchCondition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.FrontdoorRulesEngine.IFrontdoorRulesEngineRuleMatchCondition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _matchCondition = value;
            }
        }
    }
}
