using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagementStationAssociateManagedInstancesManagement
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubManagementStationAssociateManagedInstancesManagementWorkRequestDetails), fullyQualifiedName: "oci.osManagementHubManagementStationAssociateManagedInstancesManagement.OsManagementHubManagementStationAssociateManagedInstancesManagementWorkRequestDetails")]
    public interface IOsManagementHubManagementStationAssociateManagedInstancesManagementWorkRequestDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_management_station_associate_managed_instances_management#description OsManagementHubManagementStationAssociateManagedInstancesManagement#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_management_station_associate_managed_instances_management#display_name OsManagementHubManagementStationAssociateManagedInstancesManagement#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubManagementStationAssociateManagedInstancesManagementWorkRequestDetails), fullyQualifiedName: "oci.osManagementHubManagementStationAssociateManagedInstancesManagement.OsManagementHubManagementStationAssociateManagedInstancesManagementWorkRequestDetails")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubManagementStationAssociateManagedInstancesManagement.IOsManagementHubManagementStationAssociateManagedInstancesManagementWorkRequestDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_management_station_associate_managed_instances_management#description OsManagementHubManagementStationAssociateManagedInstancesManagement#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_management_station_associate_managed_instances_management#display_name OsManagementHubManagementStationAssociateManagedInstancesManagement#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
