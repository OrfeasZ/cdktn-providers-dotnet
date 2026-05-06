using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ManagementAgentNamedCredential
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.managementAgentNamedCredential.ManagementAgentNamedCredentialProperties")]
    public class ManagementAgentNamedCredentialProperties : oci.ManagementAgentNamedCredential.IManagementAgentNamedCredentialProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_named_credential#name ManagementAgentNamedCredential#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_named_credential#value ManagementAgentNamedCredential#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_named_credential#value_category ManagementAgentNamedCredential#value_category}.</summary>
        [JsiiProperty(name: "valueCategory", typeJson: "{\"primitive\":\"string\"}")]
        public string ValueCategory
        {
            get;
            set;
        }
    }
}
