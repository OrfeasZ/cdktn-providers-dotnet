using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubSoftwareSourceGenerateMetadataManagement
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubSoftwareSourceGenerateMetadataManagementTimeouts), fullyQualifiedName: "oci.osManagementHubSoftwareSourceGenerateMetadataManagement.OsManagementHubSoftwareSourceGenerateMetadataManagementTimeouts")]
    public interface IOsManagementHubSoftwareSourceGenerateMetadataManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source_generate_metadata_management#create OsManagementHubSoftwareSourceGenerateMetadataManagement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source_generate_metadata_management#delete OsManagementHubSoftwareSourceGenerateMetadataManagement#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source_generate_metadata_management#update OsManagementHubSoftwareSourceGenerateMetadataManagement#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubSoftwareSourceGenerateMetadataManagementTimeouts), fullyQualifiedName: "oci.osManagementHubSoftwareSourceGenerateMetadataManagement.OsManagementHubSoftwareSourceGenerateMetadataManagementTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubSoftwareSourceGenerateMetadataManagement.IOsManagementHubSoftwareSourceGenerateMetadataManagementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source_generate_metadata_management#create OsManagementHubSoftwareSourceGenerateMetadataManagement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source_generate_metadata_management#delete OsManagementHubSoftwareSourceGenerateMetadataManagement#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source_generate_metadata_management#update OsManagementHubSoftwareSourceGenerateMetadataManagement#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
