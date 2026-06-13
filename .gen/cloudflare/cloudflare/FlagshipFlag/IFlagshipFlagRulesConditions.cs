using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.FlagshipFlag
{
    [JsiiInterface(nativeType: typeof(IFlagshipFlagRulesConditions), fullyQualifiedName: "cloudflare.flagshipFlag.FlagshipFlagRulesConditions")]
    public interface IFlagshipFlagRulesConditions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.20.0/docs/resources/flagship_flag#attribute FlagshipFlag#attribute}.</summary>
        [JsiiProperty(name: "attribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Attribute
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.20.0/docs/resources/flagship_flag#clauses FlagshipFlag#clauses}.</summary>
        [JsiiProperty(name: "clauses", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.flagshipFlag.FlagshipFlagRulesConditionsClauses\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Clauses
        {
            get
            {
                return null;
            }
        }

        /// <summary>Available values: "AND", "OR".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.20.0/docs/resources/flagship_flag#logical_operator FlagshipFlag#logical_operator}
        /// </remarks>
        [JsiiProperty(name: "logicalOperator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogicalOperator
        {
            get
            {
                return null;
            }
        }

        /// <summary>Available values: "equals", "not_equals", "greater_than", "less_than", "greater_than_or_equals", "less_than_or_equals", "contains", "starts_with", "ends_with", "in", "not_in".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.20.0/docs/resources/flagship_flag#operator FlagshipFlag#operator}
        /// </remarks>
        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Operator
        {
            get
            {
                return null;
            }
        }

        /// <summary>Value to compare against the context attribute.</summary>
        /// <remarks>
        /// Must be an array for <c>in</c> and <c>not_in</c>; numeric and ISO-8601 datetime strings are accepted by the ordering operators.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.20.0/docs/resources/flagship_flag#value FlagshipFlag#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Value
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFlagshipFlagRulesConditions), fullyQualifiedName: "cloudflare.flagshipFlag.FlagshipFlagRulesConditions")]
        internal sealed class _Proxy : DeputyBase, cloudflare.FlagshipFlag.IFlagshipFlagRulesConditions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.20.0/docs/resources/flagship_flag#attribute FlagshipFlag#attribute}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "attribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Attribute
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.20.0/docs/resources/flagship_flag#clauses FlagshipFlag#clauses}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clauses", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.flagshipFlag.FlagshipFlagRulesConditionsClauses\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Clauses
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Available values: "AND", "OR".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.20.0/docs/resources/flagship_flag#logical_operator FlagshipFlag#logical_operator}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logicalOperator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogicalOperator
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Available values: "equals", "not_equals", "greater_than", "less_than", "greater_than_or_equals", "less_than_or_equals", "contains", "starts_with", "ends_with", "in", "not_in".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.20.0/docs/resources/flagship_flag#operator FlagshipFlag#operator}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Operator
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Value to compare against the context attribute.</summary>
            /// <remarks>
            /// Must be an array for <c>in</c> and <c>not_in</c>; numeric and ISO-8601 datetime strings are accepted by the ordering operators.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.20.0/docs/resources/flagship_flag#value FlagshipFlag#value}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Value
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
