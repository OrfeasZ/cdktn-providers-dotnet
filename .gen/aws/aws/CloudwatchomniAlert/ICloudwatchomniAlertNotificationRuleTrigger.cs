using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchomniAlert
{
    [JsiiInterface(nativeType: typeof(ICloudwatchomniAlertNotificationRuleTrigger), fullyQualifiedName: "aws.cloudwatchomniAlert.CloudwatchomniAlertNotificationRuleTrigger")]
    public interface ICloudwatchomniAlertNotificationRuleTrigger
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#state_values CloudwatchomniAlert#state_values}.</summary>
        [JsiiProperty(name: "stateValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? StateValues
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchomniAlertNotificationRuleTrigger), fullyQualifiedName: "aws.cloudwatchomniAlert.CloudwatchomniAlertNotificationRuleTrigger")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchomniAlert.ICloudwatchomniAlertNotificationRuleTrigger
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#state_values CloudwatchomniAlert#state_values}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stateValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? StateValues
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
