using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ConditionalAccessPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsUsersIncludedGuestsOrExternalUsers")]
    public class ConditionalAccessPolicyConditionsUsersIncludedGuestsOrExternalUsers : azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsUsersIncludedGuestsOrExternalUsers
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#guest_or_external_user_types ConditionalAccessPolicy#guest_or_external_user_types}.</summary>
        [JsiiProperty(name: "guestOrExternalUserTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] GuestOrExternalUserTypes
        {
            get;
            set;
        }

        private object? _externalTenants;

        /// <summary>external_tenants block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#external_tenants ConditionalAccessPolicy#external_tenants}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsUsersIncludedGuestsOrExternalUsersExternalTenants" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "externalTenants", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsUsersIncludedGuestsOrExternalUsersExternalTenants\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ExternalTenants
        {
            get => _externalTenants;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsUsersIncludedGuestsOrExternalUsersExternalTenants[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsUsersIncludedGuestsOrExternalUsersExternalTenants).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _externalTenants = value;
            }
        }
    }
}
