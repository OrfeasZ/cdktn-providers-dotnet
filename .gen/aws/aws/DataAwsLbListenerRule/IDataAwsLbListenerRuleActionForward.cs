using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsLbListenerRule
{
    [JsiiInterface(nativeType: typeof(IDataAwsLbListenerRuleActionForward), fullyQualifiedName: "aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionForward")]
    public interface IDataAwsLbListenerRuleActionForward
    {
        /// <summary>stickiness block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/data-sources/lb_listener_rule#stickiness DataAwsLbListenerRule#stickiness}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleActionForwardStickiness" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "stickiness", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionForwardStickiness\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Stickiness
        {
            get
            {
                return null;
            }
        }

        /// <summary>target_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/data-sources/lb_listener_rule#target_group DataAwsLbListenerRule#target_group}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleActionForwardTargetGroup" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "targetGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionForwardTargetGroup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TargetGroup
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsLbListenerRuleActionForward), fullyQualifiedName: "aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionForward")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleActionForward
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>stickiness block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/data-sources/lb_listener_rule#stickiness DataAwsLbListenerRule#stickiness}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleActionForwardStickiness" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stickiness", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionForwardStickiness\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Stickiness
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>target_group block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/data-sources/lb_listener_rule#target_group DataAwsLbListenerRule#target_group}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleActionForwardTargetGroup" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "targetGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionForwardTargetGroup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TargetGroup
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
