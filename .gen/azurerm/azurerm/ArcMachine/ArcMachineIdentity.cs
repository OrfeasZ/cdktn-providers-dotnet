using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ArcMachine
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.arcMachine.ArcMachineIdentity")]
    public class ArcMachineIdentity : azurerm.ArcMachine.IArcMachineIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/arc_machine#type ArcMachine#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
