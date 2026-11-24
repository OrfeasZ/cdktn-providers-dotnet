using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchomniAlert
{
    [JsiiInterface(nativeType: typeof(ICloudwatchomniAlertRuleTelemetryRuleCondition), fullyQualifiedName: "aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleCondition")]
    public interface ICloudwatchomniAlertRuleTelemetryRuleCondition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#comparator CloudwatchomniAlert#comparator}.</summary>
        [JsiiProperty(name: "comparator", typeJson: "{\"primitive\":\"string\"}")]
        string Comparator
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#threshold_mode CloudwatchomniAlert#threshold_mode}.</summary>
        [JsiiProperty(name: "thresholdMode", typeJson: "{\"primitive\":\"string\"}")]
        string ThresholdMode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#critical_threshold CloudwatchomniAlert#critical_threshold}.</summary>
        [JsiiProperty(name: "criticalThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CriticalThreshold
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#threshold_field CloudwatchomniAlert#threshold_field}.</summary>
        [JsiiProperty(name: "thresholdField", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ThresholdField
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#warning_threshold CloudwatchomniAlert#warning_threshold}.</summary>
        [JsiiProperty(name: "warningThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? WarningThreshold
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchomniAlertRuleTelemetryRuleCondition), fullyQualifiedName: "aws.cloudwatchomniAlert.CloudwatchomniAlertRuleTelemetryRuleCondition")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchomniAlert.ICloudwatchomniAlertRuleTelemetryRuleCondition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#comparator CloudwatchomniAlert#comparator}.</summary>
            [JsiiProperty(name: "comparator", typeJson: "{\"primitive\":\"string\"}")]
            public string Comparator
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#threshold_mode CloudwatchomniAlert#threshold_mode}.</summary>
            [JsiiProperty(name: "thresholdMode", typeJson: "{\"primitive\":\"string\"}")]
            public string ThresholdMode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#critical_threshold CloudwatchomniAlert#critical_threshold}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "criticalThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CriticalThreshold
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#threshold_field CloudwatchomniAlert#threshold_field}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "thresholdField", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ThresholdField
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_alert#warning_threshold CloudwatchomniAlert#warning_threshold}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "warningThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WarningThreshold
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
