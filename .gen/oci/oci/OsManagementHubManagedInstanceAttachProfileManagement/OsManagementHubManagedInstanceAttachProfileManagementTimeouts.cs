using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstanceAttachProfileManagement
{
    [JsiiByValue(fqn: "oci.osManagementHubManagedInstanceAttachProfileManagement.OsManagementHubManagedInstanceAttachProfileManagementTimeouts")]
    public class OsManagementHubManagedInstanceAttachProfileManagementTimeouts : oci.OsManagementHubManagedInstanceAttachProfileManagement.IOsManagementHubManagedInstanceAttachProfileManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_attach_profile_management#create OsManagementHubManagedInstanceAttachProfileManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_attach_profile_management#delete OsManagementHubManagedInstanceAttachProfileManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance_attach_profile_management#update OsManagementHubManagedInstanceAttachProfileManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
