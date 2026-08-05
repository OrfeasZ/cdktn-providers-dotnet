using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstancesUpdatePackagesManagement
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubManagedInstancesUpdatePackagesManagementWorkRequestDetails), fullyQualifiedName: "oci.osManagementHubManagedInstancesUpdatePackagesManagement.OsManagementHubManagedInstancesUpdatePackagesManagementWorkRequestDetails")]
    public interface IOsManagementHubManagedInstancesUpdatePackagesManagementWorkRequestDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_managed_instances_update_packages_management#description OsManagementHubManagedInstancesUpdatePackagesManagement#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_managed_instances_update_packages_management#display_name OsManagementHubManagedInstancesUpdatePackagesManagement#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubManagedInstancesUpdatePackagesManagementWorkRequestDetails), fullyQualifiedName: "oci.osManagementHubManagedInstancesUpdatePackagesManagement.OsManagementHubManagedInstancesUpdatePackagesManagementWorkRequestDetails")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubManagedInstancesUpdatePackagesManagement.IOsManagementHubManagedInstancesUpdatePackagesManagementWorkRequestDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_managed_instances_update_packages_management#description OsManagementHubManagedInstancesUpdatePackagesManagement#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_managed_instances_update_packages_management#display_name OsManagementHubManagedInstancesUpdatePackagesManagement#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
