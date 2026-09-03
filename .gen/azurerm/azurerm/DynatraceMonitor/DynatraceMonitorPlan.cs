using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DynatraceMonitor
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.dynatraceMonitor.DynatraceMonitorPlan")]
    public class DynatraceMonitorPlan : azurerm.DynatraceMonitor.IDynatraceMonitorPlan
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/dynatrace_monitor#plan DynatraceMonitor#plan}.</summary>
        [JsiiProperty(name: "plan", typeJson: "{\"primitive\":\"string\"}")]
        public string Plan
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/dynatrace_monitor#billing_cycle DynatraceMonitor#billing_cycle}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "billingCycle", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BillingCycle
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/dynatrace_monitor#usage_type DynatraceMonitor#usage_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "usageType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UsageType
        {
            get;
            set;
        }
    }
}
