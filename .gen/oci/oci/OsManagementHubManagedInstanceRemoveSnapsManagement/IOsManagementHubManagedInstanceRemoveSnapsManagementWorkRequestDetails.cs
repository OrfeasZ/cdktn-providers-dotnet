using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceRemoveSnapsManagement
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubManagedInstanceRemoveSnapsManagementWorkRequestDetails), fullyQualifiedName: "oci.osManagementHubManagedInstanceRemoveSnapsManagement.OsManagementHubManagedInstanceRemoveSnapsManagementWorkRequestDetails")]
    public interface IOsManagementHubManagedInstanceRemoveSnapsManagementWorkRequestDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_managed_instance_remove_snaps_management#description OsManagementHubManagedInstanceRemoveSnapsManagement#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_managed_instance_remove_snaps_management#display_name OsManagementHubManagedInstanceRemoveSnapsManagement#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubManagedInstanceRemoveSnapsManagementWorkRequestDetails), fullyQualifiedName: "oci.osManagementHubManagedInstanceRemoveSnapsManagement.OsManagementHubManagedInstanceRemoveSnapsManagementWorkRequestDetails")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubManagedInstanceRemoveSnapsManagement.IOsManagementHubManagedInstanceRemoveSnapsManagementWorkRequestDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_managed_instance_remove_snaps_management#description OsManagementHubManagedInstanceRemoveSnapsManagement#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_managed_instance_remove_snaps_management#display_name OsManagementHubManagedInstanceRemoveSnapsManagement#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
