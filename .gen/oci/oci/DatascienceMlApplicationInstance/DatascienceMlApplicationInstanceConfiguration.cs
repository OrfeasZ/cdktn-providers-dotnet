using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceMlApplicationInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.datascienceMlApplicationInstance.DatascienceMlApplicationInstanceConfiguration")]
    public class DatascienceMlApplicationInstanceConfiguration : oci.DatascienceMlApplicationInstance.IDatascienceMlApplicationInstanceConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_ml_application_instance#key DatascienceMlApplicationInstance#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_ml_application_instance#value DatascienceMlApplicationInstance#value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}
