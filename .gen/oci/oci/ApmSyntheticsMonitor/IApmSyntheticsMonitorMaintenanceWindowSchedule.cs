using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmSyntheticsMonitor
{
    [JsiiInterface(nativeType: typeof(IApmSyntheticsMonitorMaintenanceWindowSchedule), fullyQualifiedName: "oci.apmSyntheticsMonitor.ApmSyntheticsMonitorMaintenanceWindowSchedule")]
    public interface IApmSyntheticsMonitorMaintenanceWindowSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#time_ended ApmSyntheticsMonitor#time_ended}.</summary>
        [JsiiProperty(name: "timeEnded", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeEnded
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#time_started ApmSyntheticsMonitor#time_started}.</summary>
        [JsiiProperty(name: "timeStarted", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeStarted
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApmSyntheticsMonitorMaintenanceWindowSchedule), fullyQualifiedName: "oci.apmSyntheticsMonitor.ApmSyntheticsMonitorMaintenanceWindowSchedule")]
        internal sealed class _Proxy : DeputyBase, oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorMaintenanceWindowSchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#time_ended ApmSyntheticsMonitor#time_ended}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeEnded", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeEnded
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#time_started ApmSyntheticsMonitor#time_started}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeStarted", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeStarted
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
