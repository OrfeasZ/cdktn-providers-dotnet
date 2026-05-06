using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubSoftwareSource
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubSoftwareSourceCustomSoftwareSourceFilterModuleStreamProfileFilters), fullyQualifiedName: "oci.osManagementHubSoftwareSource.OsManagementHubSoftwareSourceCustomSoftwareSourceFilterModuleStreamProfileFilters")]
    public interface IOsManagementHubSoftwareSourceCustomSoftwareSourceFilterModuleStreamProfileFilters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source#filter_type OsManagementHubSoftwareSource#filter_type}.</summary>
        [JsiiProperty(name: "filterType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FilterType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source#module_name OsManagementHubSoftwareSource#module_name}.</summary>
        [JsiiProperty(name: "moduleName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ModuleName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source#profile_name OsManagementHubSoftwareSource#profile_name}.</summary>
        [JsiiProperty(name: "profileName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProfileName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source#stream_name OsManagementHubSoftwareSource#stream_name}.</summary>
        [JsiiProperty(name: "streamName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StreamName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubSoftwareSourceCustomSoftwareSourceFilterModuleStreamProfileFilters), fullyQualifiedName: "oci.osManagementHubSoftwareSource.OsManagementHubSoftwareSourceCustomSoftwareSourceFilterModuleStreamProfileFilters")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubSoftwareSource.IOsManagementHubSoftwareSourceCustomSoftwareSourceFilterModuleStreamProfileFilters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source#filter_type OsManagementHubSoftwareSource#filter_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "filterType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FilterType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source#module_name OsManagementHubSoftwareSource#module_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "moduleName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ModuleName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source#profile_name OsManagementHubSoftwareSource#profile_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "profileName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProfileName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source#stream_name OsManagementHubSoftwareSource#stream_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "streamName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StreamName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
