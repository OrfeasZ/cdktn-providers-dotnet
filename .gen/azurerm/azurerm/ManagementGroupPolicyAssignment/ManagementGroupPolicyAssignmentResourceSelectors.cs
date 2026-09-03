using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagementGroupPolicyAssignment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.managementGroupPolicyAssignment.ManagementGroupPolicyAssignmentResourceSelectors")]
    public class ManagementGroupPolicyAssignmentResourceSelectors : azurerm.ManagementGroupPolicyAssignment.IManagementGroupPolicyAssignmentResourceSelectors
    {
        private object _selectors;

        /// <summary>selectors block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/management_group_policy_assignment#selectors ManagementGroupPolicyAssignment#selectors}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagementGroupPolicyAssignment.IManagementGroupPolicyAssignmentResourceSelectorsSelectors" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "selectors", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managementGroupPolicyAssignment.ManagementGroupPolicyAssignmentResourceSelectorsSelectors\"},\"kind\":\"array\"}}]}}")]
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
                        case azurerm.ManagementGroupPolicyAssignment.IManagementGroupPolicyAssignmentResourceSelectorsSelectors[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagementGroupPolicyAssignment.IManagementGroupPolicyAssignmentResourceSelectorsSelectors).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagementGroupPolicyAssignment.IManagementGroupPolicyAssignmentResourceSelectorsSelectors).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _selectors = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/management_group_policy_assignment#name ManagementGroupPolicyAssignment#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }
    }
}
