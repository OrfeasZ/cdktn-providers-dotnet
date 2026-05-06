using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubSoftwareSource
{
    [JsiiByValue(fqn: "oci.osManagementHubSoftwareSource.OsManagementHubSoftwareSourceCustomSoftwareSourceFilterPackageFilters")]
    public class OsManagementHubSoftwareSourceCustomSoftwareSourceFilterPackageFilters : oci.OsManagementHubSoftwareSource.IOsManagementHubSoftwareSourceCustomSoftwareSourceFilterPackageFilters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source#filter_type OsManagementHubSoftwareSource#filter_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "filterType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FilterType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source#package_name OsManagementHubSoftwareSource#package_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "packageName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PackageName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source#package_name_pattern OsManagementHubSoftwareSource#package_name_pattern}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "packageNamePattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PackageNamePattern
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source#package_version OsManagementHubSoftwareSource#package_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "packageVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PackageVersion
        {
            get;
            set;
        }
    }
}
