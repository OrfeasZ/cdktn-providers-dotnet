using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermOracleAdbsNationalCharacterSets
{
    [JsiiByValue(fqn: "azurerm.dataAzurermOracleAdbsNationalCharacterSets.DataAzurermOracleAdbsNationalCharacterSetsTimeouts")]
    public class DataAzurermOracleAdbsNationalCharacterSetsTimeouts : azurerm.DataAzurermOracleAdbsNationalCharacterSets.IDataAzurermOracleAdbsNationalCharacterSetsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/data-sources/oracle_adbs_national_character_sets#read DataAzurermOracleAdbsNationalCharacterSets#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
