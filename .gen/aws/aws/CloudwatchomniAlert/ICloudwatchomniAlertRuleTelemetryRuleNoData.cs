using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchomniAlert
{
    [JsiiInterface(nativeType: typeof(ICloudwatchomniAlertRuleTelemetryRuleNoData), fullyQualifiedName: "aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleNoData")]
    public interface ICloudwatchomniAlertRuleTelemetryRuleNoData
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#treat_as CloudwatchomniAlert#treat_as}.</summary>
        [JsiiProperty(name: "treatAs", typeJson: "{\"primitive\":\"string\"}")]
        string TreatAs
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchomniAlertRuleTelemetryRuleNoData), fullyQualifiedName: "aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleNoData")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleNoData
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#treat_as CloudwatchomniAlert#treat_as}.</summary>
            [JsiiProperty(name: "treatAs", typeJson: "{\"primitive\":\"string\"}")]
            public string TreatAs
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
