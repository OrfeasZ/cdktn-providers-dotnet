using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchomniAlert
{
    [JsiiInterface(nativeType: typeof(ICloudwatchomniAlertRule), fullyQualifiedName: "aws.cloudwatchomniAlert.CloudwatchomniAlertRule")]
    public interface ICloudwatchomniAlertRule
    {
        /// <summary>telemetry_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#telemetry_rule CloudwatchomniAlert#telemetry_rule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRule" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "telemetryRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TelemetryRule
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchomniAlertRule), fullyQualifiedName: "aws.cloudwatchomniAlert.CloudwatchomniAlertRule")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchomniAlert.ICloudwatchomniAlertRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>telemetry_rule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#telemetry_rule CloudwatchomniAlert#telemetry_rule}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRule" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "telemetryRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TelemetryRule
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
