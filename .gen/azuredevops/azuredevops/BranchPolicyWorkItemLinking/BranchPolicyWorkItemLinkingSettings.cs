using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BranchPolicyWorkItemLinking
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.branchPolicyWorkItemLinking.BranchPolicyWorkItemLinkingSettings")]
    public class BranchPolicyWorkItemLinkingSettings : azuredevops.BranchPolicyWorkItemLinking.IBranchPolicyWorkItemLinkingSettings
    {
        private object _scope;

        /// <summary>scope block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/branch_policy_work_item_linking#scope BranchPolicyWorkItemLinking#scope}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuredevops.BranchPolicyWorkItemLinking.IBranchPolicyWorkItemLinkingSettingsScope" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "scope", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.branchPolicyWorkItemLinking.BranchPolicyWorkItemLinkingSettingsScope\"},\"kind\":\"array\"}}]}}")]
        public object Scope
        {
            get => _scope;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azuredevops.BranchPolicyWorkItemLinking.IBranchPolicyWorkItemLinkingSettingsScope[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuredevops.BranchPolicyWorkItemLinking.IBranchPolicyWorkItemLinkingSettingsScope).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuredevops.BranchPolicyWorkItemLinking.IBranchPolicyWorkItemLinkingSettingsScope).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _scope = value;
            }
        }
    }
}
