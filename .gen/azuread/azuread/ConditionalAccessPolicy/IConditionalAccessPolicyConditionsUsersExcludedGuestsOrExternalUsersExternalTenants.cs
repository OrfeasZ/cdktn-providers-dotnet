using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ConditionalAccessPolicy
{
    [JsiiInterface(nativeType: typeof(IConditionalAccessPolicyConditionsUsersExcludedGuestsOrExternalUsersExternalTenants), fullyQualifiedName: "azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsUsersExcludedGuestsOrExternalUsersExternalTenants")]
    public interface IConditionalAccessPolicyConditionsUsersExcludedGuestsOrExternalUsersExternalTenants
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#membership_kind ConditionalAccessPolicy#membership_kind}.</summary>
        [JsiiProperty(name: "membershipKind", typeJson: "{\"primitive\":\"string\"}")]
        string MembershipKind
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#members ConditionalAccessPolicy#members}.</summary>
        [JsiiProperty(name: "members", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Members
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConditionalAccessPolicyConditionsUsersExcludedGuestsOrExternalUsersExternalTenants), fullyQualifiedName: "azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsUsersExcludedGuestsOrExternalUsersExternalTenants")]
        internal sealed class _Proxy : DeputyBase, azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsUsersExcludedGuestsOrExternalUsersExternalTenants
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#membership_kind ConditionalAccessPolicy#membership_kind}.</summary>
            [JsiiProperty(name: "membershipKind", typeJson: "{\"primitive\":\"string\"}")]
            public string MembershipKind
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#members ConditionalAccessPolicy#members}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "members", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Members
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
