using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SubscriptionPolicyAssignment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.subscriptionPolicyAssignment.SubscriptionPolicyAssignmentOverrides")]
    public class SubscriptionPolicyAssignmentOverrides : azurerm.SubscriptionPolicyAssignment.ISubscriptionPolicyAssignmentOverrides
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/subscription_policy_assignment#value SubscriptionPolicyAssignment#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }

        private object? _selectors;

        /// <summary>selectors block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/subscription_policy_assignment#selectors SubscriptionPolicyAssignment#selectors}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SubscriptionPolicyAssignment.ISubscriptionPolicyAssignmentOverridesSelectors" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "selectors", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.subscriptionPolicyAssignment.SubscriptionPolicyAssignmentOverridesSelectors\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.SubscriptionPolicyAssignment.ISubscriptionPolicyAssignmentOverridesSelectors[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.SubscriptionPolicyAssignment.ISubscriptionPolicyAssignmentOverridesSelectors).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _selectors = value;
            }
        }
    }
}
