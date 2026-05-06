using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubSoftwareSourceChangeAvailabilityManagement
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.osManagementHubSoftwareSourceChangeAvailabilityManagement.OsManagementHubSoftwareSourceChangeAvailabilityManagementSoftwareSourceAvailabilities")]
    public class OsManagementHubSoftwareSourceChangeAvailabilityManagementSoftwareSourceAvailabilities : oci.OsManagementHubSoftwareSourceChangeAvailabilityManagement.IOsManagementHubSoftwareSourceChangeAvailabilityManagementSoftwareSourceAvailabilities
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source_change_availability_management#software_source_id OsManagementHubSoftwareSourceChangeAvailabilityManagement#software_source_id}.</summary>
        [JsiiProperty(name: "softwareSourceId", typeJson: "{\"primitive\":\"string\"}")]
        public string SoftwareSourceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source_change_availability_management#availability OsManagementHubSoftwareSourceChangeAvailabilityManagement#availability}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "availability", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Availability
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source_change_availability_management#availability_at_oci OsManagementHubSoftwareSourceChangeAvailabilityManagement#availability_at_oci}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "availabilityAtOci", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AvailabilityAtOci
        {
            get;
            set;
        }
    }
}
