using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceDetachSoftwareSourcesManagement
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubManagedInstanceDetachSoftwareSourcesManagementWorkRequestDetails), fullyQualifiedName: "oci.osManagementHubManagedInstanceDetachSoftwareSourcesManagement.OsManagementHubManagedInstanceDetachSoftwareSourcesManagementWorkRequestDetails")]
    public interface IOsManagementHubManagedInstanceDetachSoftwareSourcesManagementWorkRequestDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/os_management_hub_managed_instance_detach_software_sources_management#description OsManagementHubManagedInstanceDetachSoftwareSourcesManagement#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/os_management_hub_managed_instance_detach_software_sources_management#display_name OsManagementHubManagedInstanceDetachSoftwareSourcesManagement#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubManagedInstanceDetachSoftwareSourcesManagementWorkRequestDetails), fullyQualifiedName: "oci.osManagementHubManagedInstanceDetachSoftwareSourcesManagement.OsManagementHubManagedInstanceDetachSoftwareSourcesManagementWorkRequestDetails")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubManagedInstanceDetachSoftwareSourcesManagement.IOsManagementHubManagedInstanceDetachSoftwareSourcesManagementWorkRequestDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/os_management_hub_managed_instance_detach_software_sources_management#description OsManagementHubManagedInstanceDetachSoftwareSourcesManagement#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/os_management_hub_managed_instance_detach_software_sources_management#display_name OsManagementHubManagedInstanceDetachSoftwareSourcesManagement#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
