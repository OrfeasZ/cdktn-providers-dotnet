using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedDevopsPool
{
    [JsiiInterface(nativeType: typeof(IManagedDevopsPoolStatefulAgentAutomaticResourcePrediction), fullyQualifiedName: "azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentAutomaticResourcePrediction")]
    public interface IManagedDevopsPoolStatefulAgentAutomaticResourcePrediction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/managed_devops_pool#prediction_preference ManagedDevopsPool#prediction_preference}.</summary>
        [JsiiProperty(name: "predictionPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PredictionPreference
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IManagedDevopsPoolStatefulAgentAutomaticResourcePrediction), fullyQualifiedName: "azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentAutomaticResourcePrediction")]
        internal sealed class _Proxy : DeputyBase, azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentAutomaticResourcePrediction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/managed_devops_pool#prediction_preference ManagedDevopsPool#prediction_preference}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "predictionPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PredictionPreference
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
