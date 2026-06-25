using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceDetachSoftwareSourcesManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubManagedInstanceDetachSoftwareSourcesManagement.OsManagementHubManagedInstanceDetachSoftwareSourcesManagementTimeouts")]
    public class OsManagementHubManagedInstanceDetachSoftwareSourcesManagementTimeouts : oci.OsManagementHubManagedInstanceDetachSoftwareSourcesManagement.IOsManagementHubManagedInstanceDetachSoftwareSourcesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/os_management_hub_managed_instance_detach_software_sources_management#create OsManagementHubManagedInstanceDetachSoftwareSourcesManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/os_management_hub_managed_instance_detach_software_sources_management#delete OsManagementHubManagedInstanceDetachSoftwareSourcesManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/os_management_hub_managed_instance_detach_software_sources_management#update OsManagementHubManagedInstanceDetachSoftwareSourcesManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
