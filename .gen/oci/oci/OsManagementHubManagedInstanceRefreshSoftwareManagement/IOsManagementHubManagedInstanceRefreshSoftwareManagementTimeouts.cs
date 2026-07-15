using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceRefreshSoftwareManagement
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubManagedInstanceRefreshSoftwareManagementTimeouts), fullyQualifiedName: "oci.osManagementHubManagedInstanceRefreshSoftwareManagement.OsManagementHubManagedInstanceRefreshSoftwareManagementTimeouts")]
    public interface IOsManagementHubManagedInstanceRefreshSoftwareManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/os_management_hub_managed_instance_refresh_software_management#create OsManagementHubManagedInstanceRefreshSoftwareManagement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/os_management_hub_managed_instance_refresh_software_management#delete OsManagementHubManagedInstanceRefreshSoftwareManagement#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/os_management_hub_managed_instance_refresh_software_management#update OsManagementHubManagedInstanceRefreshSoftwareManagement#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubManagedInstanceRefreshSoftwareManagementTimeouts), fullyQualifiedName: "oci.osManagementHubManagedInstanceRefreshSoftwareManagement.OsManagementHubManagedInstanceRefreshSoftwareManagementTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubManagedInstanceRefreshSoftwareManagement.IOsManagementHubManagedInstanceRefreshSoftwareManagementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/os_management_hub_managed_instance_refresh_software_management#create OsManagementHubManagedInstanceRefreshSoftwareManagement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/os_management_hub_managed_instance_refresh_software_management#delete OsManagementHubManagedInstanceRefreshSoftwareManagement#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/os_management_hub_managed_instance_refresh_software_management#update OsManagementHubManagedInstanceRefreshSoftwareManagement#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
