using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedDevopsPool
{
    [JsiiInterface(nativeType: typeof(IManagedDevopsPoolStatelessAgent), fullyQualifiedName: "azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgent")]
    public interface IManagedDevopsPoolStatelessAgent
    {
        /// <summary>automatic_resource_prediction block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/managed_devops_pool#automatic_resource_prediction ManagedDevopsPool#automatic_resource_prediction}
        /// </remarks>
        [JsiiProperty(name: "automaticResourcePrediction", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentAutomaticResourcePrediction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentAutomaticResourcePrediction? AutomaticResourcePrediction
        {
            get
            {
                return null;
            }
        }

        /// <summary>manual_resource_prediction block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/managed_devops_pool#manual_resource_prediction ManagedDevopsPool#manual_resource_prediction}
        /// </remarks>
        [JsiiProperty(name: "manualResourcePrediction", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePrediction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePrediction? ManualResourcePrediction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IManagedDevopsPoolStatelessAgent), fullyQualifiedName: "azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgent")]
        internal sealed class _Proxy : DeputyBase, azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgent
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>automatic_resource_prediction block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/managed_devops_pool#automatic_resource_prediction ManagedDevopsPool#automatic_resource_prediction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "automaticResourcePrediction", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentAutomaticResourcePrediction\"}", isOptional: true)]
            public azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentAutomaticResourcePrediction? AutomaticResourcePrediction
            {
                get => GetInstanceProperty<azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentAutomaticResourcePrediction?>();
            }

            /// <summary>manual_resource_prediction block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/managed_devops_pool#manual_resource_prediction ManagedDevopsPool#manual_resource_prediction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "manualResourcePrediction", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatelessAgentManualResourcePrediction\"}", isOptional: true)]
            public azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePrediction? ManualResourcePrediction
            {
                get => GetInstanceProperty<azurerm.ManagedDevopsPool.IManagedDevopsPoolStatelessAgentManualResourcePrediction?>();
            }
        }
    }
}
