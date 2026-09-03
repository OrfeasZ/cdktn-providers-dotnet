using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DynatraceMonitor
{
    [JsiiInterface(nativeType: typeof(IDynatraceMonitorPlan), fullyQualifiedName: "azurerm.dynatraceMonitor.DynatraceMonitorPlan")]
    public interface IDynatraceMonitorPlan
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/dynatrace_monitor#plan DynatraceMonitor#plan}.</summary>
        [JsiiProperty(name: "plan", typeJson: "{\"primitive\":\"string\"}")]
        string Plan
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/dynatrace_monitor#billing_cycle DynatraceMonitor#billing_cycle}.</summary>
        [JsiiProperty(name: "billingCycle", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BillingCycle
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/dynatrace_monitor#usage_type DynatraceMonitor#usage_type}.</summary>
        [JsiiProperty(name: "usageType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UsageType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDynatraceMonitorPlan), fullyQualifiedName: "azurerm.dynatraceMonitor.DynatraceMonitorPlan")]
        internal sealed class _Proxy : DeputyBase, azurerm.DynatraceMonitor.IDynatraceMonitorPlan
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/dynatrace_monitor#plan DynatraceMonitor#plan}.</summary>
            [JsiiProperty(name: "plan", typeJson: "{\"primitive\":\"string\"}")]
            public string Plan
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/dynatrace_monitor#billing_cycle DynatraceMonitor#billing_cycle}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "billingCycle", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BillingCycle
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/dynatrace_monitor#usage_type DynatraceMonitor#usage_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "usageType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UsageType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
