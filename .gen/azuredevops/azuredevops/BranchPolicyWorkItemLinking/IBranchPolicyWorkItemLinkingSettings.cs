using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BranchPolicyWorkItemLinking
{
    [JsiiInterface(nativeType: typeof(IBranchPolicyWorkItemLinkingSettings), fullyQualifiedName: "azuredevops.branchPolicyWorkItemLinking.BranchPolicyWorkItemLinkingSettings")]
    public interface IBranchPolicyWorkItemLinkingSettings
    {
        /// <summary>scope block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/branch_policy_work_item_linking#scope BranchPolicyWorkItemLinking#scope}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuredevops.BranchPolicyWorkItemLinking.IBranchPolicyWorkItemLinkingSettingsScope" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "scope", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.branchPolicyWorkItemLinking.BranchPolicyWorkItemLinkingSettingsScope\"},\"kind\":\"array\"}}]}}")]
        object Scope
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBranchPolicyWorkItemLinkingSettings), fullyQualifiedName: "azuredevops.branchPolicyWorkItemLinking.BranchPolicyWorkItemLinkingSettings")]
        internal sealed class _Proxy : DeputyBase, azuredevops.BranchPolicyWorkItemLinking.IBranchPolicyWorkItemLinkingSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>scope block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/branch_policy_work_item_linking#scope BranchPolicyWorkItemLinking#scope}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuredevops.BranchPolicyWorkItemLinking.IBranchPolicyWorkItemLinkingSettingsScope" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "scope", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.branchPolicyWorkItemLinking.BranchPolicyWorkItemLinkingSettingsScope\"},\"kind\":\"array\"}}]}}")]
            public object Scope
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
