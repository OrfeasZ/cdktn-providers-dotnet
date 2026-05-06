using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceGroupRemovePackagesManagement
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubManagedInstanceGroupRemovePackagesManagementWorkRequestDetails), fullyQualifiedName: "oci.osManagementHubManagedInstanceGroupRemovePackagesManagement.OsManagementHubManagedInstanceGroupRemovePackagesManagementWorkRequestDetails")]
    public interface IOsManagementHubManagedInstanceGroupRemovePackagesManagementWorkRequestDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_remove_packages_management#description OsManagementHubManagedInstanceGroupRemovePackagesManagement#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_remove_packages_management#display_name OsManagementHubManagedInstanceGroupRemovePackagesManagement#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubManagedInstanceGroupRemovePackagesManagementWorkRequestDetails), fullyQualifiedName: "oci.osManagementHubManagedInstanceGroupRemovePackagesManagement.OsManagementHubManagedInstanceGroupRemovePackagesManagementWorkRequestDetails")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubManagedInstanceGroupRemovePackagesManagement.IOsManagementHubManagedInstanceGroupRemovePackagesManagementWorkRequestDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_remove_packages_management#description OsManagementHubManagedInstanceGroupRemovePackagesManagement#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_remove_packages_management#display_name OsManagementHubManagedInstanceGroupRemovePackagesManagement#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
