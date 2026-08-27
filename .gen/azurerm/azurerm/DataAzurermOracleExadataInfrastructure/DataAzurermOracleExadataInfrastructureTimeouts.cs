using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermOracleExadataInfrastructure
{
    [JsiiByValue(fqn: "azurerm.dataAzurermOracleExadataInfrastructure.DataAzurermOracleExadataInfrastructureTimeouts")]
    public class DataAzurermOracleExadataInfrastructureTimeouts : azurerm.DataAzurermOracleExadataInfrastructure.IDataAzurermOracleExadataInfrastructureTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/data-sources/oracle_exadata_infrastructure#read DataAzurermOracleExadataInfrastructure#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
