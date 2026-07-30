using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedDevopsPool
{
    [JsiiByValue(fqn: "azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgent")]
    public class ManagedDevopsPoolStatelessAgent : azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgent
    {
        /// <summary>automatic_resource_prediction block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_devops_pool#automatic_resource_prediction ManagedDevopsPool#automatic_resource_prediction}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "automaticResourcePrediction", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentAutomaticResourcePrediction\"}", isOptional: true)]
        public azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentAutomaticResourcePrediction? AutomaticResourcePrediction
        {
            get;
            set;
        }

        /// <summary>manual_resource_prediction block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_devops_pool#manual_resource_prediction ManagedDevopsPool#manual_resource_prediction}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "manualResourcePrediction", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePrediction\"}", isOptional: true)]
        public azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePrediction? ManualResourcePrediction
        {
            get;
            set;
        }
    }
}
