using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.FlagshipFlag
{
    [JsiiByValue(fqn: "cloudflare.flagshipFlag.FlagshipFlagRulesConditions")]
    public class FlagshipFlagRulesConditions : cloudflare.FlagshipFlag.IFlagshipFlagRulesConditions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.0/docs/resources/flagship_flag#attribute FlagshipFlag#attribute}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "attribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Attribute
        {
            get;
            set;
        }

        private object? _clauses;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.0/docs/resources/flagship_flag#clauses FlagshipFlag#clauses}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clauses", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.flagshipFlag.FlagshipFlagRulesConditionsClauses\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Clauses
        {
            get => _clauses;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.FlagshipFlag.IFlagshipFlagRulesConditionsClauses[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.FlagshipFlag.IFlagshipFlagRulesConditionsClauses).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _clauses = value;
            }
        }

        /// <summary>Available values: "AND", "OR".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.0/docs/resources/flagship_flag#logical_operator FlagshipFlag#logical_operator}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logicalOperator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogicalOperator
        {
            get;
            set;
        }

        /// <summary>Available values: "equals", "not_equals", "greater_than", "less_than", "greater_than_or_equals", "less_than_or_equals", "contains", "starts_with", "ends_with", "in", "not_in".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.0/docs/resources/flagship_flag#operator FlagshipFlag#operator}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Operator
        {
            get;
            set;
        }

        /// <summary>Value to compare against the context attribute.</summary>
        /// <remarks>
        /// Must be an array for <c>in</c> and <c>not_in</c>; numeric and ISO-8601 datetime strings are accepted by the ordering operators.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.0/docs/resources/flagship_flag#value FlagshipFlag#value}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}
