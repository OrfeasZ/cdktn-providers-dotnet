using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceUpdatePackagesManagement
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubManagedInstanceUpdatePackagesManagementWorkRequestDetails), fullyQualifiedName: "oci.osManagementHubManagedInstanceUpdatePackagesManagement.OsManagementHubManagedInstanceUpdatePackagesManagementWorkRequestDetails")]
    public interface IOsManagementHubManagedInstanceUpdatePackagesManagementWorkRequestDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_update_packages_management#description OsManagementHubManagedInstanceUpdatePackagesManagement#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_update_packages_management#display_name OsManagementHubManagedInstanceUpdatePackagesManagement#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubManagedInstanceUpdatePackagesManagementWorkRequestDetails), fullyQualifiedName: "oci.osManagementHubManagedInstanceUpdatePackagesManagement.OsManagementHubManagedInstanceUpdatePackagesManagementWorkRequestDetails")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubManagedInstanceUpdatePackagesManagement.IOsManagementHubManagedInstanceUpdatePackagesManagementWorkRequestDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_update_packages_management#description OsManagementHubManagedInstanceUpdatePackagesManagement#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_update_packages_management#display_name OsManagementHubManagedInstanceUpdatePackagesManagement#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
