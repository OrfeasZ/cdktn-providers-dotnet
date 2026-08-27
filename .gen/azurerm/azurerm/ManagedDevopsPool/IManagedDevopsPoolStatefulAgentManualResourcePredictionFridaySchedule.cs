using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedDevopsPool
{
    [JsiiInterface(nativeType: typeof(IManagedDevopsPoolStatefulAgentManualResourcePredictionFridaySchedule), fullyQualifiedName: "azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionFridaySchedule")]
    public interface IManagedDevopsPoolStatefulAgentManualResourcePredictionFridaySchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/managed_devops_pool#count ManagedDevopsPool#count}.</summary>
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}")]
        double Count
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/managed_devops_pool#time ManagedDevopsPool#time}.</summary>
        [JsiiProperty(name: "time", typeJson: "{\"primitive\":\"string\"}")]
        string Time
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IManagedDevopsPoolStatefulAgentManualResourcePredictionFridaySchedule), fullyQualifiedName: "azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePredictionFridaySchedule")]
        internal sealed class _Proxy : DeputyBase, azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePredictionFridaySchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/managed_devops_pool#count ManagedDevopsPool#count}.</summary>
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}")]
            public double Count
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/managed_devops_pool#time ManagedDevopsPool#time}.</summary>
            [JsiiProperty(name: "time", typeJson: "{\"primitive\":\"string\"}")]
            public string Time
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
