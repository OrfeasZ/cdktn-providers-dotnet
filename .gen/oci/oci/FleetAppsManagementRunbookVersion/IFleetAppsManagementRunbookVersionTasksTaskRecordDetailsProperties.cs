using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementRunbookVersion
{
    [JsiiInterface(nativeType: typeof(IFleetAppsManagementRunbookVersionTasksTaskRecordDetailsProperties), fullyQualifiedName: "oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksTaskRecordDetailsProperties")]
    public interface IFleetAppsManagementRunbookVersionTasksTaskRecordDetailsProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#num_retries FleetAppsManagementRunbookVersion#num_retries}.</summary>
        [JsiiProperty(name: "numRetries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NumRetries
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#timeout_in_seconds FleetAppsManagementRunbookVersion#timeout_in_seconds}.</summary>
        [JsiiProperty(name: "timeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TimeoutInSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetAppsManagementRunbookVersionTasksTaskRecordDetailsProperties), fullyQualifiedName: "oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksTaskRecordDetailsProperties")]
        internal sealed class _Proxy : DeputyBase, oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksTaskRecordDetailsProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#num_retries FleetAppsManagementRunbookVersion#num_retries}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "numRetries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NumRetries
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#timeout_in_seconds FleetAppsManagementRunbookVersion#timeout_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TimeoutInSeconds
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
