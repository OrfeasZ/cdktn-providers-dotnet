using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchomniAlert
{
    [JsiiByValue(fqn: "aws.cloudwatchomniAlert.CloudwatchomniAlertRule")]
    public class CloudwatchomniAlertRule : aws.CloudwatchomniAlert.ICloudwatchomniAlertRule
    {
        private object? _telemetryRule;

        /// <summary>telemetry_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#telemetry_rule CloudwatchomniAlert#telemetry_rule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "telemetryRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TelemetryRule
        {
            get => _telemetryRule;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _telemetryRule = value;
            }
        }
    }
}
