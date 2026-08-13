using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CognitiveAccount
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cognitiveAccount.CognitiveAccountNetworkInjection")]
    public class CognitiveAccountNetworkInjection : azurerm.CognitiveAccount.ICognitiveAccountNetworkInjection
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/cognitive_account#scenario CognitiveAccount#scenario}.</summary>
        [JsiiProperty(name: "scenario", typeJson: "{\"primitive\":\"string\"}")]
        public string Scenario
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/cognitive_account#subnet_id CognitiveAccount#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public string SubnetId
        {
            get;
            set;
        }
    }
}
