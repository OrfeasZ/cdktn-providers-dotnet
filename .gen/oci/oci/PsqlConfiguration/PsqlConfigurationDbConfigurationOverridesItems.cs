using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.PsqlConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.psqlConfiguration.PsqlConfigurationDbConfigurationOverridesItems")]
    public class PsqlConfigurationDbConfigurationOverridesItems : oci.PsqlConfiguration.IPsqlConfigurationDbConfigurationOverridesItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_configuration#config_key PsqlConfiguration#config_key}.</summary>
        [JsiiProperty(name: "configKey", typeJson: "{\"primitive\":\"string\"}")]
        public string ConfigKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_configuration#overriden_config_value PsqlConfiguration#overriden_config_value}.</summary>
        [JsiiProperty(name: "overridenConfigValue", typeJson: "{\"primitive\":\"string\"}")]
        public string OverridenConfigValue
        {
            get;
            set;
        }
    }
}
