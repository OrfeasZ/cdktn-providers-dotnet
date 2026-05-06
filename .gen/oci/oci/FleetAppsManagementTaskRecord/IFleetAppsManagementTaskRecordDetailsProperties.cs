using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementTaskRecord
{
    [JsiiInterface(nativeType: typeof(IFleetAppsManagementTaskRecordDetailsProperties), fullyQualifiedName: "oci.fleetAppsManagementTaskRecord.FleetAppsManagementTaskRecordDetailsProperties")]
    public interface IFleetAppsManagementTaskRecordDetailsProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_task_record#num_retries FleetAppsManagementTaskRecord#num_retries}.</summary>
        [JsiiProperty(name: "numRetries", typeJson: "{\"primitive\":\"number\"}")]
        double NumRetries
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_task_record#timeout_in_seconds FleetAppsManagementTaskRecord#timeout_in_seconds}.</summary>
        [JsiiProperty(name: "timeoutInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        double TimeoutInSeconds
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetAppsManagementTaskRecordDetailsProperties), fullyQualifiedName: "oci.fleetAppsManagementTaskRecord.FleetAppsManagementTaskRecordDetailsProperties")]
        internal sealed class _Proxy : DeputyBase, oci.FleetAppsManagementTaskRecord.IFleetAppsManagementTaskRecordDetailsProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_task_record#num_retries FleetAppsManagementTaskRecord#num_retries}.</summary>
            [JsiiProperty(name: "numRetries", typeJson: "{\"primitive\":\"number\"}")]
            public double NumRetries
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_task_record#timeout_in_seconds FleetAppsManagementTaskRecord#timeout_in_seconds}.</summary>
            [JsiiProperty(name: "timeoutInSeconds", typeJson: "{\"primitive\":\"number\"}")]
            public double TimeoutInSeconds
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
