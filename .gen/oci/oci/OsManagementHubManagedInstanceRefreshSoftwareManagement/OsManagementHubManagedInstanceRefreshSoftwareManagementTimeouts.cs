using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceRefreshSoftwareManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubManagedInstanceRefreshSoftwareManagement.OsManagementHubManagedInstanceRefreshSoftwareManagementTimeouts")]
    public class OsManagementHubManagedInstanceRefreshSoftwareManagementTimeouts : oci.OsManagementHubManagedInstanceRefreshSoftwareManagement.IOsManagementHubManagedInstanceRefreshSoftwareManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_managed_instance_refresh_software_management#create OsManagementHubManagedInstanceRefreshSoftwareManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_managed_instance_refresh_software_management#delete OsManagementHubManagedInstanceRefreshSoftwareManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/os_management_hub_managed_instance_refresh_software_management#update OsManagementHubManagedInstanceRefreshSoftwareManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
