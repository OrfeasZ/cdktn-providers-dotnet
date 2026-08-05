using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceRemoveSnapsManagement
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubManagedInstanceRemoveSnapsManagementSnapDetails), fullyQualifiedName: "oci.osManagementHubManagedInstanceRemoveSnapsManagement.OsManagementHubManagedInstanceRemoveSnapsManagementSnapDetails")]
    public interface IOsManagementHubManagedInstanceRemoveSnapsManagementSnapDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_managed_instance_remove_snaps_management#name OsManagementHubManagedInstanceRemoveSnapsManagement#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_managed_instance_remove_snaps_management#revision OsManagementHubManagedInstanceRemoveSnapsManagement#revision}.</summary>
        [JsiiProperty(name: "revision", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Revision
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubManagedInstanceRemoveSnapsManagementSnapDetails), fullyQualifiedName: "oci.osManagementHubManagedInstanceRemoveSnapsManagement.OsManagementHubManagedInstanceRemoveSnapsManagementSnapDetails")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubManagedInstanceRemoveSnapsManagement.IOsManagementHubManagedInstanceRemoveSnapsManagementSnapDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_managed_instance_remove_snaps_management#name OsManagementHubManagedInstanceRemoveSnapsManagement#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_managed_instance_remove_snaps_management#revision OsManagementHubManagedInstanceRemoveSnapsManagement#revision}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "revision", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Revision
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
