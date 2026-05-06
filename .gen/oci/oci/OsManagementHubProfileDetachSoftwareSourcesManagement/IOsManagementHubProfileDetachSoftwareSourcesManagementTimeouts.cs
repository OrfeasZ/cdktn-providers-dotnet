using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubProfileDetachSoftwareSourcesManagement
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubProfileDetachSoftwareSourcesManagementTimeouts), fullyQualifiedName: "oci.osManagementHubProfileDetachSoftwareSourcesManagement.OsManagementHubProfileDetachSoftwareSourcesManagementTimeouts")]
    public interface IOsManagementHubProfileDetachSoftwareSourcesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_profile_detach_software_sources_management#create OsManagementHubProfileDetachSoftwareSourcesManagement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_profile_detach_software_sources_management#delete OsManagementHubProfileDetachSoftwareSourcesManagement#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_profile_detach_software_sources_management#update OsManagementHubProfileDetachSoftwareSourcesManagement#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubProfileDetachSoftwareSourcesManagementTimeouts), fullyQualifiedName: "oci.osManagementHubProfileDetachSoftwareSourcesManagement.OsManagementHubProfileDetachSoftwareSourcesManagementTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubProfileDetachSoftwareSourcesManagement.IOsManagementHubProfileDetachSoftwareSourcesManagementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_profile_detach_software_sources_management#create OsManagementHubProfileDetachSoftwareSourcesManagement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_profile_detach_software_sources_management#delete OsManagementHubProfileDetachSoftwareSourcesManagement#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_profile_detach_software_sources_management#update OsManagementHubProfileDetachSoftwareSourcesManagement#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
