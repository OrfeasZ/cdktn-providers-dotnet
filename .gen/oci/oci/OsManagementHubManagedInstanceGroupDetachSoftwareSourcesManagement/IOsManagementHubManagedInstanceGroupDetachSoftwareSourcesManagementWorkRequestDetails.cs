using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagement
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagementWorkRequestDetails), fullyQualifiedName: "oci.osManagementHubManagedInstanceGroupDetachSoftwareSourcesManagement.OsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagementWorkRequestDetails")]
    public interface IOsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagementWorkRequestDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_detach_software_sources_management#description OsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagement#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_detach_software_sources_management#display_name OsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagement#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagementWorkRequestDetails), fullyQualifiedName: "oci.osManagementHubManagedInstanceGroupDetachSoftwareSourcesManagement.OsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagementWorkRequestDetails")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagement.IOsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagementWorkRequestDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_detach_software_sources_management#description OsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagement#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_detach_software_sources_management#display_name OsManagementHubManagedInstanceGroupDetachSoftwareSourcesManagement#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
