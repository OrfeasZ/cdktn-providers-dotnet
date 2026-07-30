using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LighthouseDefinition
{
    [JsiiByValue(fqn: "azurerm.lighthouseDefinition.LighthouseDefinitionEligibleAuthorizationJustInTimeAccessPolicy")]
    public class LighthouseDefinitionEligibleAuthorizationJustInTimeAccessPolicy : azurerm.LighthouseDefinition.ILighthouseDefinitionEligibleAuthorizationJustInTimeAccessPolicy
    {
        private object? _approver;

        /// <summary>approver block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/lighthouse_definition#approver LighthouseDefinition#approver}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.LighthouseDefinition.ILighthouseDefinitionEligibleAuthorizationJustInTimeAccessPolicyApprover" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "approver", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.lighthouseDefinition.LighthouseDefinitionEligibleAuthorizationJustInTimeAccessPolicyApprover\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Approver
        {
            get => _approver;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.LighthouseDefinition.ILighthouseDefinitionEligibleAuthorizationJustInTimeAccessPolicyApprover[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.LighthouseDefinition.ILighthouseDefinitionEligibleAuthorizationJustInTimeAccessPolicyApprover).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _approver = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/lighthouse_definition#maximum_activation_duration LighthouseDefinition#maximum_activation_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumActivationDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaximumActivationDuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/lighthouse_definition#multi_factor_auth_provider LighthouseDefinition#multi_factor_auth_provider}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "multiFactorAuthProvider", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MultiFactorAuthProvider
        {
            get;
            set;
        }
    }
}
