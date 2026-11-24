using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchomniAlert
{
    [JsiiInterface(nativeType: typeof(ICloudwatchomniAlertRuleTelemetryRuleEvaluation), fullyQualifiedName: "aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleEvaluation")]
    public interface ICloudwatchomniAlertRuleTelemetryRuleEvaluation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#interval_seconds CloudwatchomniAlert#interval_seconds}.</summary>
        [JsiiProperty(name: "intervalSeconds", typeJson: "{\"primitive\":\"number\"}")]
        double IntervalSeconds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#pending_duration_seconds CloudwatchomniAlert#pending_duration_seconds}.</summary>
        [JsiiProperty(name: "pendingDurationSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PendingDurationSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#recovery_duration_seconds CloudwatchomniAlert#recovery_duration_seconds}.</summary>
        [JsiiProperty(name: "recoveryDurationSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RecoveryDurationSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchomniAlertRuleTelemetryRuleEvaluation), fullyQualifiedName: "aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleEvaluation")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleEvaluation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#interval_seconds CloudwatchomniAlert#interval_seconds}.</summary>
            [JsiiProperty(name: "intervalSeconds", typeJson: "{\"primitive\":\"number\"}")]
            public double IntervalSeconds
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#pending_duration_seconds CloudwatchomniAlert#pending_duration_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pendingDurationSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PendingDurationSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#recovery_duration_seconds CloudwatchomniAlert#recovery_duration_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "recoveryDurationSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RecoveryDurationSeconds
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
