using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementRunbook
{
    [JsiiInterface(nativeType: typeof(IFleetAppsManagementRunbookRunbookVersionTasksTaskRecordDetailsProperties), fullyQualifiedName: "oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksTaskRecordDetailsProperties")]
    public interface IFleetAppsManagementRunbookRunbookVersionTasksTaskRecordDetailsProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#num_retries FleetAppsManagementRunbook#num_retries}.</summary>
        [JsiiProperty(name: "numRetries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NumRetries
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#timeout_in_seconds FleetAppsManagementRunbook#timeout_in_seconds}.</summary>
        [JsiiProperty(name: "timeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TimeoutInSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetAppsManagementRunbookRunbookVersionTasksTaskRecordDetailsProperties), fullyQualifiedName: "oci.fleetAppsManagementRunbook.FleetAppsManagementRunbookRunbookVersionTasksTaskRecordDetailsProperties")]
        internal sealed class _Proxy : DeputyBase, oci.FleetAppsManagementRunbook.IFleetAppsManagementRunbookRunbookVersionTasksTaskRecordDetailsProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#num_retries FleetAppsManagementRunbook#num_retries}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "numRetries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NumRetries
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook#timeout_in_seconds FleetAppsManagementRunbook#timeout_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TimeoutInSeconds
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
