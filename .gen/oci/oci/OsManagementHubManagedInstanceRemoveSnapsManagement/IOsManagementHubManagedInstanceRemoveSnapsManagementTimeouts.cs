using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceRemoveSnapsManagement
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubManagedInstanceRemoveSnapsManagementTimeouts), fullyQualifiedName: "oci.osManagementHubManagedInstanceRemoveSnapsManagement.OsManagementHubManagedInstanceRemoveSnapsManagementTimeouts")]
    public interface IOsManagementHubManagedInstanceRemoveSnapsManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_managed_instance_remove_snaps_management#create OsManagementHubManagedInstanceRemoveSnapsManagement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_managed_instance_remove_snaps_management#delete OsManagementHubManagedInstanceRemoveSnapsManagement#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_managed_instance_remove_snaps_management#update OsManagementHubManagedInstanceRemoveSnapsManagement#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubManagedInstanceRemoveSnapsManagementTimeouts), fullyQualifiedName: "oci.osManagementHubManagedInstanceRemoveSnapsManagement.OsManagementHubManagedInstanceRemoveSnapsManagementTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubManagedInstanceRemoveSnapsManagement.IOsManagementHubManagedInstanceRemoveSnapsManagementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_managed_instance_remove_snaps_management#create OsManagementHubManagedInstanceRemoveSnapsManagement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_managed_instance_remove_snaps_management#delete OsManagementHubManagedInstanceRemoveSnapsManagement#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_managed_instance_remove_snaps_management#update OsManagementHubManagedInstanceRemoveSnapsManagement#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
