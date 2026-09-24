using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.AuthenticationStrengthPolicyX509CombinationConfiguration
{
    [JsiiInterface(nativeType: typeof(IAuthenticationStrengthPolicyX509CombinationConfigurationTimeouts), fullyQualifiedName: "azuread.authenticationStrengthPolicyX509CombinationConfiguration.AuthenticationStrengthPolicyX509CombinationConfigurationTimeouts")]
    public interface IAuthenticationStrengthPolicyX509CombinationConfigurationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.10.0/docs/resources/authentication_strength_policy_x509_combination_configuration#create AuthenticationStrengthPolicyX509CombinationConfiguration#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.10.0/docs/resources/authentication_strength_policy_x509_combination_configuration#delete AuthenticationStrengthPolicyX509CombinationConfiguration#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.10.0/docs/resources/authentication_strength_policy_x509_combination_configuration#read AuthenticationStrengthPolicyX509CombinationConfiguration#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.10.0/docs/resources/authentication_strength_policy_x509_combination_configuration#update AuthenticationStrengthPolicyX509CombinationConfiguration#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAuthenticationStrengthPolicyX509CombinationConfigurationTimeouts), fullyQualifiedName: "azuread.authenticationStrengthPolicyX509CombinationConfiguration.AuthenticationStrengthPolicyX509CombinationConfigurationTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuread.AuthenticationStrengthPolicyX509CombinationConfiguration.IAuthenticationStrengthPolicyX509CombinationConfigurationTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.10.0/docs/resources/authentication_strength_policy_x509_combination_configuration#create AuthenticationStrengthPolicyX509CombinationConfiguration#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.10.0/docs/resources/authentication_strength_policy_x509_combination_configuration#delete AuthenticationStrengthPolicyX509CombinationConfiguration#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.10.0/docs/resources/authentication_strength_policy_x509_combination_configuration#read AuthenticationStrengthPolicyX509CombinationConfiguration#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.10.0/docs/resources/authentication_strength_policy_x509_combination_configuration#update AuthenticationStrengthPolicyX509CombinationConfiguration#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
