using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LogicAppWorkflow
{
    [JsiiInterface(nativeType: typeof(ILogicAppWorkflowAccessControlTriggerOpenAuthenticationPolicy), fullyQualifiedName: "azurerm.logicAppWorkflow.LogicAppWorkflowAccessControlTriggerOpenAuthenticationPolicy")]
    public interface ILogicAppWorkflowAccessControlTriggerOpenAuthenticationPolicy
    {
        /// <summary>claim block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/logic_app_workflow#claim LogicAppWorkflow#claim}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlTriggerOpenAuthenticationPolicyClaim" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "claim", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.logicAppWorkflow.LogicAppWorkflowAccessControlTriggerOpenAuthenticationPolicyClaim\"},\"kind\":\"array\"}}]}}")]
        object Claim
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/logic_app_workflow#name LogicAppWorkflow#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILogicAppWorkflowAccessControlTriggerOpenAuthenticationPolicy), fullyQualifiedName: "azurerm.logicAppWorkflow.LogicAppWorkflowAccessControlTriggerOpenAuthenticationPolicy")]
        internal sealed class _Proxy : DeputyBase, azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlTriggerOpenAuthenticationPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>claim block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/logic_app_workflow#claim LogicAppWorkflow#claim}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlTriggerOpenAuthenticationPolicyClaim" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "claim", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.logicAppWorkflow.LogicAppWorkflowAccessControlTriggerOpenAuthenticationPolicyClaim\"},\"kind\":\"array\"}}]}}")]
            public object Claim
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/logic_app_workflow#name LogicAppWorkflow#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
