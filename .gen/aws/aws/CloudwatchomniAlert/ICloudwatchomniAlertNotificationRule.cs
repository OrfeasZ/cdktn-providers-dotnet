using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchomniAlert
{
    [JsiiInterface(nativeType: typeof(ICloudwatchomniAlertNotificationRule), fullyQualifiedName: "aws.cloudwatchomniAlert.CloudwatchomniAlertNotificationRule")]
    public interface ICloudwatchomniAlertNotificationRule
    {
        /// <summary>target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#target CloudwatchomniAlert#target}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniAlert.ICloudwatchomniAlertNotificationRuleTarget" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "target", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniAlert.CloudwatchomniAlertNotificationRuleTarget\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Target
        {
            get
            {
                return null;
            }
        }

        /// <summary>trigger block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#trigger CloudwatchomniAlert#trigger}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniAlert.ICloudwatchomniAlertNotificationRuleTrigger" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "trigger", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniAlert.CloudwatchomniAlertNotificationRuleTrigger\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Trigger
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchomniAlertNotificationRule), fullyQualifiedName: "aws.cloudwatchomniAlert.CloudwatchomniAlertNotificationRule")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchomniAlert.ICloudwatchomniAlertNotificationRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>target block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#target CloudwatchomniAlert#target}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniAlert.ICloudwatchomniAlertNotificationRuleTarget" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "target", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniAlert.CloudwatchomniAlertNotificationRuleTarget\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Target
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>trigger block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#trigger CloudwatchomniAlert#trigger}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniAlert.ICloudwatchomniAlertNotificationRuleTrigger" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trigger", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniAlert.CloudwatchomniAlertNotificationRuleTrigger\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Trigger
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
