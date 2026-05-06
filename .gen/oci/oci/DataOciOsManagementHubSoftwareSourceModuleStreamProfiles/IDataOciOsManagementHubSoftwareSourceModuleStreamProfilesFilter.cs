using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOsManagementHubSoftwareSourceModuleStreamProfiles
{
    [JsiiInterface(nativeType: typeof(IDataOciOsManagementHubSoftwareSourceModuleStreamProfilesFilter), fullyQualifiedName: "oci.dataOciOsManagementHubSoftwareSourceModuleStreamProfiles.DataOciOsManagementHubSoftwareSourceModuleStreamProfilesFilter")]
    public interface IDataOciOsManagementHubSoftwareSourceModuleStreamProfilesFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/os_management_hub_software_source_module_stream_profiles#name DataOciOsManagementHubSoftwareSourceModuleStreamProfiles#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/os_management_hub_software_source_module_stream_profiles#values DataOciOsManagementHubSoftwareSourceModuleStreamProfiles#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/os_management_hub_software_source_module_stream_profiles#regex DataOciOsManagementHubSoftwareSourceModuleStreamProfiles#regex}.</summary>
        [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Regex
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciOsManagementHubSoftwareSourceModuleStreamProfilesFilter), fullyQualifiedName: "oci.dataOciOsManagementHubSoftwareSourceModuleStreamProfiles.DataOciOsManagementHubSoftwareSourceModuleStreamProfilesFilter")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciOsManagementHubSoftwareSourceModuleStreamProfiles.IDataOciOsManagementHubSoftwareSourceModuleStreamProfilesFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/os_management_hub_software_source_module_stream_profiles#name DataOciOsManagementHubSoftwareSourceModuleStreamProfiles#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/os_management_hub_software_source_module_stream_profiles#values DataOciOsManagementHubSoftwareSourceModuleStreamProfiles#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/os_management_hub_software_source_module_stream_profiles#regex DataOciOsManagementHubSoftwareSourceModuleStreamProfiles#regex}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Regex
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
