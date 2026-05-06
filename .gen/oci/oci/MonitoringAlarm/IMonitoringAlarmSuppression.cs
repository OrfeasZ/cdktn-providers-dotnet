using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MonitoringAlarm
{
    [JsiiInterface(nativeType: typeof(IMonitoringAlarmSuppression), fullyQualifiedName: "oci.monitoringAlarm.MonitoringAlarmSuppression")]
    public interface IMonitoringAlarmSuppression
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/monitoring_alarm#time_suppress_from MonitoringAlarm#time_suppress_from}.</summary>
        [JsiiProperty(name: "timeSuppressFrom", typeJson: "{\"primitive\":\"string\"}")]
        string TimeSuppressFrom
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/monitoring_alarm#time_suppress_until MonitoringAlarm#time_suppress_until}.</summary>
        [JsiiProperty(name: "timeSuppressUntil", typeJson: "{\"primitive\":\"string\"}")]
        string TimeSuppressUntil
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/monitoring_alarm#description MonitoringAlarm#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMonitoringAlarmSuppression), fullyQualifiedName: "oci.monitoringAlarm.MonitoringAlarmSuppression")]
        internal sealed class _Proxy : DeputyBase, oci.MonitoringAlarm.IMonitoringAlarmSuppression
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/monitoring_alarm#time_suppress_from MonitoringAlarm#time_suppress_from}.</summary>
            [JsiiProperty(name: "timeSuppressFrom", typeJson: "{\"primitive\":\"string\"}")]
            public string TimeSuppressFrom
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/monitoring_alarm#time_suppress_until MonitoringAlarm#time_suppress_until}.</summary>
            [JsiiProperty(name: "timeSuppressUntil", typeJson: "{\"primitive\":\"string\"}")]
            public string TimeSuppressUntil
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/monitoring_alarm#description MonitoringAlarm#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
