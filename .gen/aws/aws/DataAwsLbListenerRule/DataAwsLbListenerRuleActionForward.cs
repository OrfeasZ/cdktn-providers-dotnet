using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsLbListenerRule
{
    [JsiiByValue(fqn: "aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionForward")]
    public class DataAwsLbListenerRuleActionForward : aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleActionForward
    {
        private object? _stickiness;

        /// <summary>stickiness block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/lb_listener_rule#stickiness DataAwsLbListenerRule#stickiness}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stickiness", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionForwardStickiness\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Stickiness
        {
            get => _stickiness;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleActionForwardStickiness[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleActionForwardStickiness).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _stickiness = value;
            }
        }

        private object? _targetGroup;

        /// <summary>target_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/lb_listener_rule#target_group DataAwsLbListenerRule#target_group}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionForwardTargetGroup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TargetGroup
        {
            get => _targetGroup;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleActionForwardTargetGroup[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleActionForwardTargetGroup).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _targetGroup = value;
            }
        }
    }
}
