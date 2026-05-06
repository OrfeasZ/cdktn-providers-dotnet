using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceGroupAttachSoftwareSourcesManagement
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubManagedInstanceGroupAttachSoftwareSourcesManagementTimeouts), fullyQualifiedName: "oci.osManagementHubManagedInstanceGroupAttachSoftwareSourcesManagement.OsManagementHubManagedInstanceGroupAttachSoftwareSourcesManagementTimeouts")]
    public interface IOsManagementHubManagedInstanceGroupAttachSoftwareSourcesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_attach_software_sources_management#create OsManagementHubManagedInstanceGroupAttachSoftwareSourcesManagement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_attach_software_sources_management#delete OsManagementHubManagedInstanceGroupAttachSoftwareSourcesManagement#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_attach_software_sources_management#update OsManagementHubManagedInstanceGroupAttachSoftwareSourcesManagement#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubManagedInstanceGroupAttachSoftwareSourcesManagementTimeouts), fullyQualifiedName: "oci.osManagementHubManagedInstanceGroupAttachSoftwareSourcesManagement.OsManagementHubManagedInstanceGroupAttachSoftwareSourcesManagementTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubManagedInstanceGroupAttachSoftwareSourcesManagement.IOsManagementHubManagedInstanceGroupAttachSoftwareSourcesManagementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_attach_software_sources_management#create OsManagementHubManagedInstanceGroupAttachSoftwareSourcesManagement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_attach_software_sources_management#delete OsManagementHubManagedInstanceGroupAttachSoftwareSourcesManagement#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_group_attach_software_sources_management#update OsManagementHubManagedInstanceGroupAttachSoftwareSourcesManagement#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
