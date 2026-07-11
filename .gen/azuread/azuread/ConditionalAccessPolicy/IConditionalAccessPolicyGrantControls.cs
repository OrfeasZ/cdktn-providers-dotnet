using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ConditionalAccessPolicy
{
    [JsiiInterface(nativeType: typeof(IConditionalAccessPolicyGrantControls), fullyQualifiedName: "azuread.conditionalAccessPolicy.ConditionalAccessPolicyGrantControls")]
    public interface IConditionalAccessPolicyGrantControls
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#operator ConditionalAccessPolicy#operator}.</summary>
        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
        string Operator
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#authentication_strength_policy_id ConditionalAccessPolicy#authentication_strength_policy_id}.</summary>
        [JsiiProperty(name: "authenticationStrengthPolicyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuthenticationStrengthPolicyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#built_in_controls ConditionalAccessPolicy#built_in_controls}.</summary>
        [JsiiProperty(name: "builtInControls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? BuiltInControls
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#custom_authentication_factors ConditionalAccessPolicy#custom_authentication_factors}.</summary>
        [JsiiProperty(name: "customAuthenticationFactors", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CustomAuthenticationFactors
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#terms_of_use ConditionalAccessPolicy#terms_of_use}.</summary>
        [JsiiProperty(name: "termsOfUse", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TermsOfUse
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConditionalAccessPolicyGrantControls), fullyQualifiedName: "azuread.conditionalAccessPolicy.ConditionalAccessPolicyGrantControls")]
        internal sealed class _Proxy : DeputyBase, azuread.ConditionalAccessPolicy.IConditionalAccessPolicyGrantControls
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#operator ConditionalAccessPolicy#operator}.</summary>
            [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
            public string Operator
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#authentication_strength_policy_id ConditionalAccessPolicy#authentication_strength_policy_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authenticationStrengthPolicyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuthenticationStrengthPolicyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#built_in_controls ConditionalAccessPolicy#built_in_controls}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "builtInControls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? BuiltInControls
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#custom_authentication_factors ConditionalAccessPolicy#custom_authentication_factors}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customAuthenticationFactors", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CustomAuthenticationFactors
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#terms_of_use ConditionalAccessPolicy#terms_of_use}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "termsOfUse", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TermsOfUse
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
