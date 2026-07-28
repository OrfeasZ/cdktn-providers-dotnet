using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedDevopsPool
{
    [JsiiByValue(fqn: "azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentAutomaticResourcePrediction")]
    public class ManagedDevopsPoolStatefulAgentAutomaticResourcePrediction : azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentAutomaticResourcePrediction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/managed_devops_pool#prediction_preference ManagedDevopsPool#prediction_preference}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "predictionPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PredictionPreference
        {
            get;
            set;
        }
    }
}
