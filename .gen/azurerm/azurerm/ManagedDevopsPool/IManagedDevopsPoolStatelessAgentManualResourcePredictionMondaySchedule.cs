using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedDevopsPool
{
    [JsiiInterface(nativeType: typeof(IManagedDevopsPoolStatelessAgentManualResourcePredictionMondaySchedule), fullyQualifiedName: "azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionMondaySchedule")]
    public interface IManagedDevopsPoolStatelessAgentManualResourcePredictionMondaySchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#count ManagedDevopsPool#count}.</summary>
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}")]
        double Count
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#time ManagedDevopsPool#time}.</summary>
        [JsiiProperty(name: "time", typeJson: "{\"primitive\":\"string\"}")]
        string Time
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IManagedDevopsPoolStatelessAgentManualResourcePredictionMondaySchedule), fullyQualifiedName: "azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePredictionMondaySchedule")]
        internal sealed class _Proxy : DeputyBase, azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePredictionMondaySchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#count ManagedDevopsPool#count}.</summary>
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}")]
            public double Count
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#time ManagedDevopsPool#time}.</summary>
            [JsiiProperty(name: "time", typeJson: "{\"primitive\":\"string\"}")]
            public string Time
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
