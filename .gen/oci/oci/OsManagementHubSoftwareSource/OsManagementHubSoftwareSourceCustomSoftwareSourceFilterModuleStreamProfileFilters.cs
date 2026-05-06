using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubSoftwareSource
{
    [JsiiByValue(fqn: "oci.osManagementHubSoftwareSource.OsManagementHubSoftwareSourceCustomSoftwareSourceFilterModuleStreamProfileFilters")]
    public class OsManagementHubSoftwareSourceCustomSoftwareSourceFilterModuleStreamProfileFilters : oci.OsManagementHubSoftwareSource.IOsManagementHubSoftwareSourceCustomSoftwareSourceFilterModuleStreamProfileFilters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source#filter_type OsManagementHubSoftwareSource#filter_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "filterType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FilterType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source#module_name OsManagementHubSoftwareSource#module_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "moduleName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ModuleName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source#profile_name OsManagementHubSoftwareSource#profile_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "profileName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProfileName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source#stream_name OsManagementHubSoftwareSource#stream_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "streamName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StreamName
        {
            get;
            set;
        }
    }
}
