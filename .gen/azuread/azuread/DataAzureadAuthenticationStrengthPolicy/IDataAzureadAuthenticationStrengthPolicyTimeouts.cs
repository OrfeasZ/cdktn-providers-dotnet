using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DataAzureadAuthenticationStrengthPolicy
{
    [JsiiInterface(nativeType: typeof(IDataAzureadAuthenticationStrengthPolicyTimeouts), fullyQualifiedName: "azuread.dataAzureadAuthenticationStrengthPolicy.DataAzureadAuthenticationStrengthPolicyTimeouts")]
    public interface IDataAzureadAuthenticationStrengthPolicyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.10.0/docs/data-sources/authentication_strength_policy#read DataAzureadAuthenticationStrengthPolicy#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzureadAuthenticationStrengthPolicyTimeouts), fullyQualifiedName: "azuread.dataAzureadAuthenticationStrengthPolicy.DataAzureadAuthenticationStrengthPolicyTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuread.DataAzureadAuthenticationStrengthPolicy.IDataAzureadAuthenticationStrengthPolicyTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.10.0/docs/data-sources/authentication_strength_policy#read DataAzureadAuthenticationStrengthPolicy#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
