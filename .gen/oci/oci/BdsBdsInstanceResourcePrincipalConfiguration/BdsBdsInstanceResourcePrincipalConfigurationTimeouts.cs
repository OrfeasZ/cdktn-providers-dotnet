using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstanceResourcePrincipalConfiguration
{
    [JsiiByValue(fqn: "oci.bdsBdsInstanceResourcePrincipalConfiguration.BdsBdsInstanceResourcePrincipalConfigurationTimeouts")]
    public class BdsBdsInstanceResourcePrincipalConfigurationTimeouts : oci.BdsBdsInstanceResourcePrincipalConfiguration.IBdsBdsInstanceResourcePrincipalConfigurationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_resource_principal_configuration#create BdsBdsInstanceResourcePrincipalConfiguration#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_resource_principal_configuration#delete BdsBdsInstanceResourcePrincipalConfiguration#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_resource_principal_configuration#update BdsBdsInstanceResourcePrincipalConfiguration#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
