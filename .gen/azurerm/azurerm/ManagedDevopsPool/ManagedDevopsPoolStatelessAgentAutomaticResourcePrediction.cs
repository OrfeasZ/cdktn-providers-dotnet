using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedDevopsPool
{
    [JsiiByValue(fqn: "azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentAutomaticResourcePrediction")]
    public class ManagedDevopsPoolStatelessAgentAutomaticResourcePrediction : azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentAutomaticResourcePrediction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_devops_pool#prediction_preference ManagedDevopsPool#prediction_preference}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "predictionPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PredictionPreference
        {
            get;
            set;
        }
    }
}
