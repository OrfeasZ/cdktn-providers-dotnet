using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ManagementAgentManagementAgentInstallKey
{
    [JsiiByValue(fqn: "oci.managementAgentManagementAgentInstallKey.ManagementAgentManagementAgentInstallKeyTimeouts")]
    public class ManagementAgentManagementAgentInstallKeyTimeouts : oci.ManagementAgentManagementAgentInstallKey.IManagementAgentManagementAgentInstallKeyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_management_agent_install_key#create ManagementAgentManagementAgentInstallKey#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_management_agent_install_key#delete ManagementAgentManagementAgentInstallKey#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_management_agent_install_key#update ManagementAgentManagementAgentInstallKey#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
