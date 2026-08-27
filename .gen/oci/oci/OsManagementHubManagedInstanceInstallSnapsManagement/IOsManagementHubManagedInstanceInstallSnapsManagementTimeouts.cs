using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceInstallSnapsManagement
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubManagedInstanceInstallSnapsManagementTimeouts), fullyQualifiedName: "oci.osManagementHubManagedInstanceInstallSnapsManagement.OsManagementHubManagedInstanceInstallSnapsManagementTimeouts")]
    public interface IOsManagementHubManagedInstanceInstallSnapsManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/os_management_hub_managed_instance_install_snaps_management#create OsManagementHubManagedInstanceInstallSnapsManagement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/os_management_hub_managed_instance_install_snaps_management#delete OsManagementHubManagedInstanceInstallSnapsManagement#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/os_management_hub_managed_instance_install_snaps_management#update OsManagementHubManagedInstanceInstallSnapsManagement#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubManagedInstanceInstallSnapsManagementTimeouts), fullyQualifiedName: "oci.osManagementHubManagedInstanceInstallSnapsManagement.OsManagementHubManagedInstanceInstallSnapsManagementTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubManagedInstanceInstallSnapsManagement.IOsManagementHubManagedInstanceInstallSnapsManagementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/os_management_hub_managed_instance_install_snaps_management#create OsManagementHubManagedInstanceInstallSnapsManagement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/os_management_hub_managed_instance_install_snaps_management#delete OsManagementHubManagedInstanceInstallSnapsManagement#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/os_management_hub_managed_instance_install_snaps_management#update OsManagementHubManagedInstanceInstallSnapsManagement#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
