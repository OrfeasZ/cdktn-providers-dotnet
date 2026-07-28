using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedDevopsPool
{
    [JsiiByValue(fqn: "azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgent")]
    public class ManagedDevopsPoolStatefulAgent : azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgent
    {
        /// <summary>automatic_resource_prediction block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/managed_devops_pool#automatic_resource_prediction ManagedDevopsPool#automatic_resource_prediction}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "automaticResourcePrediction", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentAutomaticResourcePrediction\"}", isOptional: true)]
        public azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentAutomaticResourcePrediction? AutomaticResourcePrediction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/managed_devops_pool#grace_period_time_span ManagedDevopsPool#grace_period_time_span}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gracePeriodTimeSpan", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GracePeriodTimeSpan
        {
            get;
            set;
        }

        /// <summary>manual_resource_prediction block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/managed_devops_pool#manual_resource_prediction ManagedDevopsPool#manual_resource_prediction}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "manualResourcePrediction", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePrediction\"}", isOptional: true)]
        public azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePrediction? ManualResourcePrediction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/managed_devops_pool#maximum_agent_lifetime ManagedDevopsPool#maximum_agent_lifetime}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumAgentLifetime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaximumAgentLifetime
        {
            get;
            set;
        }
    }
}
