using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchomniAlert
{
    [JsiiInterface(nativeType: typeof(ICloudwatchomniAlertRuleTelemetryRuleQuery), fullyQualifiedName: "aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleQuery")]
    public interface ICloudwatchomniAlertRuleTelemetryRuleQuery
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#expression CloudwatchomniAlert#expression}.</summary>
        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}")]
        string Expression
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#language CloudwatchomniAlert#language}.</summary>
        [JsiiProperty(name: "language", typeJson: "{\"primitive\":\"string\"}")]
        string Language
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchomniAlertRuleTelemetryRuleQuery), fullyQualifiedName: "aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleQuery")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleQuery
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#expression CloudwatchomniAlert#expression}.</summary>
            [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}")]
            public string Expression
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#language CloudwatchomniAlert#language}.</summary>
            [JsiiProperty(name: "language", typeJson: "{\"primitive\":\"string\"}")]
            public string Language
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
