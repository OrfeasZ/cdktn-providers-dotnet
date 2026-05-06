using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MonitoringAlarmSuppression
{
    [JsiiInterface(nativeType: typeof(IMonitoringAlarmSuppressionSuppressionConditions), fullyQualifiedName: "oci.monitoringAlarmSuppression.MonitoringAlarmSuppressionSuppressionConditions")]
    public interface IMonitoringAlarmSuppressionSuppressionConditions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/monitoring_alarm_suppression#condition_type MonitoringAlarmSuppressionA#condition_type}.</summary>
        [JsiiProperty(name: "conditionType", typeJson: "{\"primitive\":\"string\"}")]
        string ConditionType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/monitoring_alarm_suppression#suppression_duration MonitoringAlarmSuppressionA#suppression_duration}.</summary>
        [JsiiProperty(name: "suppressionDuration", typeJson: "{\"primitive\":\"string\"}")]
        string SuppressionDuration
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/monitoring_alarm_suppression#suppression_recurrence MonitoringAlarmSuppressionA#suppression_recurrence}.</summary>
        [JsiiProperty(name: "suppressionRecurrence", typeJson: "{\"primitive\":\"string\"}")]
        string SuppressionRecurrence
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMonitoringAlarmSuppressionSuppressionConditions), fullyQualifiedName: "oci.monitoringAlarmSuppression.MonitoringAlarmSuppressionSuppressionConditions")]
        internal sealed class _Proxy : DeputyBase, oci.MonitoringAlarmSuppression.IMonitoringAlarmSuppressionSuppressionConditions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/monitoring_alarm_suppression#condition_type MonitoringAlarmSuppressionA#condition_type}.</summary>
            [JsiiProperty(name: "conditionType", typeJson: "{\"primitive\":\"string\"}")]
            public string ConditionType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/monitoring_alarm_suppression#suppression_duration MonitoringAlarmSuppressionA#suppression_duration}.</summary>
            [JsiiProperty(name: "suppressionDuration", typeJson: "{\"primitive\":\"string\"}")]
            public string SuppressionDuration
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/monitoring_alarm_suppression#suppression_recurrence MonitoringAlarmSuppressionA#suppression_recurrence}.</summary>
            [JsiiProperty(name: "suppressionRecurrence", typeJson: "{\"primitive\":\"string\"}")]
            public string SuppressionRecurrence
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
