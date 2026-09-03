using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedDevopsPool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionWednesdaySchedule")]
    public class ManagedDevopsPoolStatefulAgentManualResourcePredictionWednesdaySchedule : azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionWednesdaySchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/managed_devops_pool#count ManagedDevopsPool#count}.</summary>
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}")]
        public double Count
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/managed_devops_pool#time ManagedDevopsPool#time}.</summary>
        [JsiiProperty(name: "time", typeJson: "{\"primitive\":\"string\"}")]
        public string Time
        {
            get;
            set;
        }
    }
}
