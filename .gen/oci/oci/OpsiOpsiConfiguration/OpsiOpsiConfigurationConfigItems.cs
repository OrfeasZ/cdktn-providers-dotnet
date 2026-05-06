using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpsiOpsiConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.opsiOpsiConfiguration.OpsiOpsiConfigurationConfigItems")]
    public class OpsiOpsiConfigurationConfigItems : oci.OpsiOpsiConfiguration.IOpsiOpsiConfigurationConfigItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_opsi_configuration#config_item_type OpsiOpsiConfiguration#config_item_type}.</summary>
        [JsiiProperty(name: "configItemType", typeJson: "{\"primitive\":\"string\"}")]
        public string ConfigItemType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_opsi_configuration#name OpsiOpsiConfiguration#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_opsi_configuration#value OpsiOpsiConfiguration#value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}
