using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceMlApplicationInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.datascienceMlApplicationInstance.DatascienceMlApplicationInstanceAuthConfiguration")]
    public class DatascienceMlApplicationInstanceAuthConfiguration : oci.DatascienceMlApplicationInstance.IDatascienceMlApplicationInstanceAuthConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_ml_application_instance#type DatascienceMlApplicationInstance#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_ml_application_instance#application_name DatascienceMlApplicationInstance#application_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "applicationName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApplicationName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_ml_application_instance#domain_id DatascienceMlApplicationInstance#domain_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "domainId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DomainId
        {
            get;
            set;
        }
    }
}
