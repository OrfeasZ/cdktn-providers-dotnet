using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FabricCapacity
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.fabricCapacity.FabricCapacitySku")]
    public class FabricCapacitySku : azurerm.FabricCapacity.IFabricCapacitySku
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/fabric_capacity#name FabricCapacity#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/fabric_capacity#tier FabricCapacity#tier}.</summary>
        [JsiiProperty(name: "tier", typeJson: "{\"primitive\":\"string\"}")]
        public string Tier
        {
            get;
            set;
        }
    }
}
