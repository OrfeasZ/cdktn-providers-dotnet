using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceInstallSnapsManagement
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubManagedInstanceInstallSnapsManagementWorkRequestDetails), fullyQualifiedName: "oci.osManagementHubManagedInstanceInstallSnapsManagement.OsManagementHubManagedInstanceInstallSnapsManagementWorkRequestDetails")]
    public interface IOsManagementHubManagedInstanceInstallSnapsManagementWorkRequestDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/os_management_hub_managed_instance_install_snaps_management#description OsManagementHubManagedInstanceInstallSnapsManagement#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/os_management_hub_managed_instance_install_snaps_management#display_name OsManagementHubManagedInstanceInstallSnapsManagement#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubManagedInstanceInstallSnapsManagementWorkRequestDetails), fullyQualifiedName: "oci.osManagementHubManagedInstanceInstallSnapsManagement.OsManagementHubManagedInstanceInstallSnapsManagementWorkRequestDetails")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubManagedInstanceInstallSnapsManagement.IOsManagementHubManagedInstanceInstallSnapsManagementWorkRequestDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/os_management_hub_managed_instance_install_snaps_management#description OsManagementHubManagedInstanceInstallSnapsManagement#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/os_management_hub_managed_instance_install_snaps_management#display_name OsManagementHubManagedInstanceInstallSnapsManagement#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
