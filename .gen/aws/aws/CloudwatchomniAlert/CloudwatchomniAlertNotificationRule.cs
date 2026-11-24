using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchomniAlert
{
    [JsiiByValue(fqn: "aws.cloudwatchomniAlert.CloudwatchomniAlertNotificationRule")]
    public class CloudwatchomniAlertNotificationRule : aws.CloudwatchomniAlert.ICloudwatchomniAlertNotificationRule
    {
        private object? _target;

        /// <summary>target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#target CloudwatchomniAlert#target}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniAlert.ICloudwatchomniAlertNotificationRuleTarget" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "target", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniAlert.CloudwatchomniAlertNotificationRuleTarget\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Target
        {
            get => _target;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudwatchomniAlert.ICloudwatchomniAlertNotificationRuleTarget[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchomniAlert.ICloudwatchomniAlertNotificationRuleTarget).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _target = value;
            }
        }

        private object? _trigger;

        /// <summary>trigger block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#trigger CloudwatchomniAlert#trigger}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniAlert.ICloudwatchomniAlertNotificationRuleTrigger" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trigger", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniAlert.CloudwatchomniAlertNotificationRuleTrigger\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Trigger
        {
            get => _trigger;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudwatchomniAlert.ICloudwatchomniAlertNotificationRuleTrigger[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchomniAlert.ICloudwatchomniAlertNotificationRuleTrigger).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _trigger = value;
            }
        }
    }
}
