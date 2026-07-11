using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermOracleGiVersions
{
    [JsiiByValue(fqn: "azurerm.dataAzurermOracleGiVersions.DataAzurermOracleGiVersionsTimeouts")]
    public class DataAzurermOracleGiVersionsTimeouts : azurerm.DataAzurermOracleGiVersions.IDataAzurermOracleGiVersionsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/data-sources/oracle_gi_versions#read DataAzurermOracleGiVersions#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
