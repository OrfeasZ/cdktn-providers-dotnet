using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubSoftwareSourceChangeAvailabilityManagement
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubSoftwareSourceChangeAvailabilityManagementSoftwareSourceAvailabilities), fullyQualifiedName: "oci.osManagementHubSoftwareSourceChangeAvailabilityManagement.OsManagementHubSoftwareSourceChangeAvailabilityManagementSoftwareSourceAvailabilities")]
    public interface IOsManagementHubSoftwareSourceChangeAvailabilityManagementSoftwareSourceAvailabilities
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source_change_availability_management#software_source_id OsManagementHubSoftwareSourceChangeAvailabilityManagement#software_source_id}.</summary>
        [JsiiProperty(name: "softwareSourceId", typeJson: "{\"primitive\":\"string\"}")]
        string SoftwareSourceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source_change_availability_management#availability OsManagementHubSoftwareSourceChangeAvailabilityManagement#availability}.</summary>
        [JsiiProperty(name: "availability", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Availability
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source_change_availability_management#availability_at_oci OsManagementHubSoftwareSourceChangeAvailabilityManagement#availability_at_oci}.</summary>
        [JsiiProperty(name: "availabilityAtOci", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AvailabilityAtOci
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubSoftwareSourceChangeAvailabilityManagementSoftwareSourceAvailabilities), fullyQualifiedName: "oci.osManagementHubSoftwareSourceChangeAvailabilityManagement.OsManagementHubSoftwareSourceChangeAvailabilityManagementSoftwareSourceAvailabilities")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubSoftwareSourceChangeAvailabilityManagement.IOsManagementHubSoftwareSourceChangeAvailabilityManagementSoftwareSourceAvailabilities
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source_change_availability_management#software_source_id OsManagementHubSoftwareSourceChangeAvailabilityManagement#software_source_id}.</summary>
            [JsiiProperty(name: "softwareSourceId", typeJson: "{\"primitive\":\"string\"}")]
            public string SoftwareSourceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source_change_availability_management#availability OsManagementHubSoftwareSourceChangeAvailabilityManagement#availability}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "availability", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Availability
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_software_source_change_availability_management#availability_at_oci OsManagementHubSoftwareSourceChangeAvailabilityManagement#availability_at_oci}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "availabilityAtOci", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AvailabilityAtOci
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
