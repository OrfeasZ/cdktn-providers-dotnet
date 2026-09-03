using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstanceBdsCertificateConfiguration
{
    [JsiiByValue(fqn: "oci.bdsBdsInstanceBdsCertificateConfiguration.BdsBdsInstanceBdsCertificateConfigurationTimeouts")]
    public class BdsBdsInstanceBdsCertificateConfigurationTimeouts : oci.BdsBdsInstanceBdsCertificateConfiguration.IBdsBdsInstanceBdsCertificateConfigurationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/bds_bds_instance_bds_certificate_configuration#create BdsBdsInstanceBdsCertificateConfiguration#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/bds_bds_instance_bds_certificate_configuration#delete BdsBdsInstanceBdsCertificateConfiguration#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/bds_bds_instance_bds_certificate_configuration#update BdsBdsInstanceBdsCertificateConfiguration#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
