using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedDevopsPool
{
    [JsiiInterface(nativeType: typeof(IManagedDevopsPoolStatefulAgent), fullyQualifiedName: "azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgent")]
    public interface IManagedDevopsPoolStatefulAgent
    {
        /// <summary>automatic_resource_prediction block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#automatic_resource_prediction ManagedDevopsPool#automatic_resource_prediction}
        /// </remarks>
        [JsiiProperty(name: "automaticResourcePrediction", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentAutomaticResourcePrediction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentAutomaticResourcePrediction? AutomaticResourcePrediction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#grace_period_time_span ManagedDevopsPool#grace_period_time_span}.</summary>
        [JsiiProperty(name: "gracePeriodTimeSpan", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GracePeriodTimeSpan
        {
            get
            {
                return null;
            }
        }

        /// <summary>manual_resource_prediction block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#manual_resource_prediction ManagedDevopsPool#manual_resource_prediction}
        /// </remarks>
        [JsiiProperty(name: "manualResourcePrediction", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePrediction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePrediction? ManualResourcePrediction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#maximum_agent_lifetime ManagedDevopsPool#maximum_agent_lifetime}.</summary>
        [JsiiProperty(name: "maximumAgentLifetime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaximumAgentLifetime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IManagedDevopsPoolStatefulAgent), fullyQualifiedName: "azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgent")]
        internal sealed class _Proxy : DeputyBase, azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgent
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>automatic_resource_prediction block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#automatic_resource_prediction ManagedDevopsPool#automatic_resource_prediction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "automaticResourcePrediction", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentAutomaticResourcePrediction\"}", isOptional: true)]
            public azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentAutomaticResourcePrediction? AutomaticResourcePrediction
            {
                get => GetInstanceProperty<azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentAutomaticResourcePrediction?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#grace_period_time_span ManagedDevopsPool#grace_period_time_span}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "gracePeriodTimeSpan", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GracePeriodTimeSpan
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>manual_resource_prediction block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#manual_resource_prediction ManagedDevopsPool#manual_resource_prediction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "manualResourcePrediction", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolStatefulAgentManualResourcePrediction\"}", isOptional: true)]
            public azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePrediction? ManualResourcePrediction
            {
                get => GetInstanceProperty<azurerm.ManagedDevopsPool.IManagedDevopsPoolStatefulAgentManualResourcePrediction?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#maximum_agent_lifetime ManagedDevopsPool#maximum_agent_lifetime}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumAgentLifetime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaximumAgentLifetime
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
