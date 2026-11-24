using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchomniAlert
{
    [JsiiInterface(nativeType: typeof(ICloudwatchomniAlertRuleTelemetryRule), fullyQualifiedName: "aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRule")]
    public interface ICloudwatchomniAlertRuleTelemetryRule
    {
        /// <summary>condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#condition CloudwatchomniAlert#condition}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleCondition" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "condition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Condition
        {
            get
            {
                return null;
            }
        }

        /// <summary>evaluation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#evaluation CloudwatchomniAlert#evaluation}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleEvaluation" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "evaluation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleEvaluation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Evaluation
        {
            get
            {
                return null;
            }
        }

        /// <summary>no_data block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#no_data CloudwatchomniAlert#no_data}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleNoData" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "noData", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleNoData\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NoData
        {
            get
            {
                return null;
            }
        }

        /// <summary>query block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#query CloudwatchomniAlert#query}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleQuery" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "query", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleQuery\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Query
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchomniAlertRuleTelemetryRule), fullyQualifiedName: "aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRule")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#condition CloudwatchomniAlert#condition}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleCondition" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "condition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Condition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>evaluation block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#evaluation CloudwatchomniAlert#evaluation}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleEvaluation" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "evaluation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleEvaluation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Evaluation
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>no_data block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#no_data CloudwatchomniAlert#no_data}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleNoData" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "noData", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleNoData\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NoData
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>query block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#query CloudwatchomniAlert#query}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleQuery" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "query", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleQuery\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Query
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
