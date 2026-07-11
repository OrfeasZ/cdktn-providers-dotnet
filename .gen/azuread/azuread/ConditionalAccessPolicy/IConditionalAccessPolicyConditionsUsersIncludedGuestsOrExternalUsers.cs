using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ConditionalAccessPolicy
{
    [JsiiInterface(nativeType: typeof(IConditionalAccessPolicyConditionsUsersIncludedGuestsOrExternalUsers), fullyQualifiedName: "azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsUsersIncludedGuestsOrExternalUsers")]
    public interface IConditionalAccessPolicyConditionsUsersIncludedGuestsOrExternalUsers
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#guest_or_external_user_types ConditionalAccessPolicy#guest_or_external_user_types}.</summary>
        [JsiiProperty(name: "guestOrExternalUserTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] GuestOrExternalUserTypes
        {
            get;
        }

        /// <summary>external_tenants block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#external_tenants ConditionalAccessPolicy#external_tenants}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsUsersIncludedGuestsOrExternalUsersExternalTenants" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "externalTenants", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsUsersIncludedGuestsOrExternalUsersExternalTenants\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExternalTenants
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConditionalAccessPolicyConditionsUsersIncludedGuestsOrExternalUsers), fullyQualifiedName: "azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsUsersIncludedGuestsOrExternalUsers")]
        internal sealed class _Proxy : DeputyBase, azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsUsersIncludedGuestsOrExternalUsers
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#guest_or_external_user_types ConditionalAccessPolicy#guest_or_external_user_types}.</summary>
            [JsiiProperty(name: "guestOrExternalUserTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] GuestOrExternalUserTypes
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>external_tenants block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#external_tenants ConditionalAccessPolicy#external_tenants}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsUsersIncludedGuestsOrExternalUsersExternalTenants" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "externalTenants", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsUsersIncludedGuestsOrExternalUsersExternalTenants\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ExternalTenants
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
