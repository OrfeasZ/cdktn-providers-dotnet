using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchomniAlert
{
    [JsiiByValue(fqn: "aws.cloudwatchomniAlert.CloudwatchomniAlertNotificationRuleTrigger")]
    public class CloudwatchomniAlertNotificationRuleTrigger : aws.CloudwatchomniAlert.ICloudwatchomniAlertNotificationRuleTrigger
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#state_values CloudwatchomniAlert#state_values}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stateValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? StateValues
        {
            get;
            set;
        }
    }
}
