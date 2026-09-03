using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ResourcePolicyAssignment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.resourcePolicyAssignment.ResourcePolicyAssignmentOverrides")]
    public class ResourcePolicyAssignmentOverrides : azurerm.ResourcePolicyAssignment.IResourcePolicyAssignmentOverrides
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/resource_policy_assignment#value ResourcePolicyAssignment#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }

        private object? _selectors;

        /// <summary>selectors block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/resource_policy_assignment#selectors ResourcePolicyAssignment#selectors}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ResourcePolicyAssignment.IResourcePolicyAssignmentOverridesSelectors" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "selectors", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourcePolicyAssignment.ResourcePolicyAssignmentOverridesSelectors\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Selectors
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
                        case azurerm.ResourcePolicyAssignment.IResourcePolicyAssignmentOverridesSelectors[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ResourcePolicyAssignment.IResourcePolicyAssignmentOverridesSelectors).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _selectors = value;
            }
        }
    }
}
