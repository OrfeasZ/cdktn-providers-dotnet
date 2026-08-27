using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ResourceGroupPolicyAssignment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.resourceGroupPolicyAssignment.ResourceGroupPolicyAssignmentResourceSelectors")]
    public class ResourceGroupPolicyAssignmentResourceSelectors : azurerm.ResourceGroupPolicyAssignment.IResourceGroupPolicyAssignmentResourceSelectors
    {
        private object _selectors;

        /// <summary>selectors block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_group_policy_assignment#selectors ResourceGroupPolicyAssignment#selectors}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ResourceGroupPolicyAssignment.IResourceGroupPolicyAssignmentResourceSelectorsSelectors" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "selectors", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourceGroupPolicyAssignment.ResourceGroupPolicyAssignmentResourceSelectorsSelectors\"},\"kind\":\"array\"}}]}}")]
        public object Selectors
        {
            get => _selectors;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ResourceGroupPolicyAssignment.IResourceGroupPolicyAssignmentResourceSelectorsSelectors[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ResourceGroupPolicyAssignment.IResourceGroupPolicyAssignmentResourceSelectorsSelectors).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ResourceGroupPolicyAssignment.IResourceGroupPolicyAssignmentResourceSelectorsSelectors).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _selectors = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_group_policy_assignment#name ResourceGroupPolicyAssignment#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }
    }
}
