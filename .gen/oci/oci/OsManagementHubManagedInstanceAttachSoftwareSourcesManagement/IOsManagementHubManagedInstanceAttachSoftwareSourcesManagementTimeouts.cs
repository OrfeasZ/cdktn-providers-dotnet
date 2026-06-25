using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceAttachSoftwareSourcesManagement
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubManagedInstanceAttachSoftwareSourcesManagementTimeouts), fullyQualifiedName: "oci.osManagementHubManagedInstanceAttachSoftwareSourcesManagement.OsManagementHubManagedInstanceAttachSoftwareSourcesManagementTimeouts")]
    public interface IOsManagementHubManagedInstanceAttachSoftwareSourcesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_managed_instance_attach_software_sources_management#create OsManagementHubManagedInstanceAttachSoftwareSourcesManagement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_managed_instance_attach_software_sources_management#delete OsManagementHubManagedInstanceAttachSoftwareSourcesManagement#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_managed_instance_attach_software_sources_management#update OsManagementHubManagedInstanceAttachSoftwareSourcesManagement#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubManagedInstanceAttachSoftwareSourcesManagementTimeouts), fullyQualifiedName: "oci.osManagementHubManagedInstanceAttachSoftwareSourcesManagement.OsManagementHubManagedInstanceAttachSoftwareSourcesManagementTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubManagedInstanceAttachSoftwareSourcesManagement.IOsManagementHubManagedInstanceAttachSoftwareSourcesManagementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_managed_instance_attach_software_sources_management#create OsManagementHubManagedInstanceAttachSoftwareSourcesManagement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_managed_instance_attach_software_sources_management#delete OsManagementHubManagedInstanceAttachSoftwareSourcesManagement#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_managed_instance_attach_software_sources_management#update OsManagementHubManagedInstanceAttachSoftwareSourcesManagement#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
