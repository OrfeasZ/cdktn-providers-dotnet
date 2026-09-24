using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.AuthenticationStrengthPolicyX509CombinationConfiguration
{
    [JsiiInterface(nativeType: typeof(IAuthenticationStrengthPolicyX509CombinationConfigurationConfig), fullyQualifiedName: "azuread.authenticationStrengthPolicyX509CombinationConfiguration.AuthenticationStrengthPolicyX509CombinationConfigurationConfig")]
    public interface IAuthenticationStrengthPolicyX509CombinationConfigurationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The x509 certificate authentication method combinations this configuration applies to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.10.0/docs/resources/authentication_strength_policy_x509_combination_configuration#applies_to_combinations AuthenticationStrengthPolicyX509CombinationConfiguration#applies_to_combinations}
        /// </remarks>
        [JsiiProperty(name: "appliesToCombinations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] AppliesToCombinations
        {
            get;
        }

        /// <summary>The object ID of the authentication strength policy to which this combination configuration applies.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.10.0/docs/resources/authentication_strength_policy_x509_combination_configuration#authentication_strength_policy_id AuthenticationStrengthPolicyX509CombinationConfiguration#authentication_strength_policy_id}
        /// </remarks>
        [JsiiProperty(name: "authenticationStrengthPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        string AuthenticationStrengthPolicyId
        {
            get;
        }

        /// <summary>A set of allowed certificate issuer subject key identifier values.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.10.0/docs/resources/authentication_strength_policy_x509_combination_configuration#allowed_issuer_skis AuthenticationStrengthPolicyX509CombinationConfiguration#allowed_issuer_skis}
        /// </remarks>
        [JsiiProperty(name: "allowedIssuerSkis", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedIssuerSkis
        {
            get
            {
                return null;
            }
        }

        /// <summary>A set of allowed certificate policy OIDs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.10.0/docs/resources/authentication_strength_policy_x509_combination_configuration#allowed_policy_oids AuthenticationStrengthPolicyX509CombinationConfiguration#allowed_policy_oids}
        /// </remarks>
        [JsiiProperty(name: "allowedPolicyOids", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedPolicyOids
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.10.0/docs/resources/authentication_strength_policy_x509_combination_configuration#id AuthenticationStrengthPolicyX509CombinationConfiguration#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.10.0/docs/resources/authentication_strength_policy_x509_combination_configuration#timeouts AuthenticationStrengthPolicyX509CombinationConfiguration#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.authenticationStrengthPolicyX509CombinationConfiguration.AuthenticationStrengthPolicyX509CombinationConfigurationTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.AuthenticationStrengthPolicyX509CombinationConfiguration.IAuthenticationStrengthPolicyX509CombinationConfigurationTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAuthenticationStrengthPolicyX509CombinationConfigurationConfig), fullyQualifiedName: "azuread.authenticationStrengthPolicyX509CombinationConfiguration.AuthenticationStrengthPolicyX509CombinationConfigurationConfig")]
        internal sealed class _Proxy : DeputyBase, azuread.AuthenticationStrengthPolicyX509CombinationConfiguration.IAuthenticationStrengthPolicyX509CombinationConfigurationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The x509 certificate authentication method combinations this configuration applies to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.10.0/docs/resources/authentication_strength_policy_x509_combination_configuration#applies_to_combinations AuthenticationStrengthPolicyX509CombinationConfiguration#applies_to_combinations}
            /// </remarks>
            [JsiiProperty(name: "appliesToCombinations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] AppliesToCombinations
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>The object ID of the authentication strength policy to which this combination configuration applies.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.10.0/docs/resources/authentication_strength_policy_x509_combination_configuration#authentication_strength_policy_id AuthenticationStrengthPolicyX509CombinationConfiguration#authentication_strength_policy_id}
            /// </remarks>
            [JsiiProperty(name: "authenticationStrengthPolicyId", typeJson: "{\"primitive\":\"string\"}")]
            public string AuthenticationStrengthPolicyId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A set of allowed certificate issuer subject key identifier values.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.10.0/docs/resources/authentication_strength_policy_x509_combination_configuration#allowed_issuer_skis AuthenticationStrengthPolicyX509CombinationConfiguration#allowed_issuer_skis}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowedIssuerSkis", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedIssuerSkis
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>A set of allowed certificate policy OIDs.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.10.0/docs/resources/authentication_strength_policy_x509_combination_configuration#allowed_policy_oids AuthenticationStrengthPolicyX509CombinationConfiguration#allowed_policy_oids}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowedPolicyOids", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedPolicyOids
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.10.0/docs/resources/authentication_strength_policy_x509_combination_configuration#id AuthenticationStrengthPolicyX509CombinationConfiguration#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.10.0/docs/resources/authentication_strength_policy_x509_combination_configuration#timeouts AuthenticationStrengthPolicyX509CombinationConfiguration#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.authenticationStrengthPolicyX509CombinationConfiguration.AuthenticationStrengthPolicyX509CombinationConfigurationTimeouts\"}", isOptional: true)]
            public azuread.AuthenticationStrengthPolicyX509CombinationConfiguration.IAuthenticationStrengthPolicyX509CombinationConfigurationTimeouts? Timeouts
            {
                get => GetInstanceProperty<azuread.AuthenticationStrengthPolicyX509CombinationConfiguration.IAuthenticationStrengthPolicyX509CombinationConfigurationTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
