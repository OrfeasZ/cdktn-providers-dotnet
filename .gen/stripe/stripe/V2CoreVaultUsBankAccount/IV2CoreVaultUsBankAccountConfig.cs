using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2CoreVaultUsBankAccount
{
    [JsiiInterface(nativeType: typeof(IV2CoreVaultUsBankAccountConfig), fullyQualifiedName: "stripe.v2CoreVaultUsBankAccount.V2CoreVaultUsBankAccountConfig")]
    public interface IV2CoreVaultUsBankAccountConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The account number of the bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_vault_us_bank_account#account_number V2CoreVaultUsBankAccount#account_number}
        /// </remarks>
        [JsiiProperty(name: "accountNumber", typeJson: "{\"primitive\":\"string\"}")]
        string AccountNumber
        {
            get;
        }

        /// <summary>The currency of the bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_vault_us_bank_account#currency V2CoreVaultUsBankAccount#currency}
        /// </remarks>
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        string Currency
        {
            get;
        }

        /// <summary>Closed Enum. The type of bank account (checking or savings).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_vault_us_bank_account#bank_account_type V2CoreVaultUsBankAccount#bank_account_type}
        /// </remarks>
        [JsiiProperty(name: "bankAccountType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BankAccountType
        {
            get
            {
                return null;
            }
        }

        /// <summary>The fedwire routing number of the bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_vault_us_bank_account#fedwire_routing_number V2CoreVaultUsBankAccount#fedwire_routing_number}
        /// </remarks>
        [JsiiProperty(name: "fedwireRoutingNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FedwireRoutingNumber
        {
            get
            {
                return null;
            }
        }

        /// <summary>The ACH routing number of the bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_vault_us_bank_account#routing_number V2CoreVaultUsBankAccount#routing_number}
        /// </remarks>
        [JsiiProperty(name: "routingNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RoutingNumber
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IV2CoreVaultUsBankAccountConfig), fullyQualifiedName: "stripe.v2CoreVaultUsBankAccount.V2CoreVaultUsBankAccountConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.V2CoreVaultUsBankAccount.IV2CoreVaultUsBankAccountConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The account number of the bank account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_vault_us_bank_account#account_number V2CoreVaultUsBankAccount#account_number}
            /// </remarks>
            [JsiiProperty(name: "accountNumber", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountNumber
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The currency of the bank account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_vault_us_bank_account#currency V2CoreVaultUsBankAccount#currency}
            /// </remarks>
            [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
            public string Currency
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Closed Enum. The type of bank account (checking or savings).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_vault_us_bank_account#bank_account_type V2CoreVaultUsBankAccount#bank_account_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bankAccountType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BankAccountType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The fedwire routing number of the bank account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_vault_us_bank_account#fedwire_routing_number V2CoreVaultUsBankAccount#fedwire_routing_number}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fedwireRoutingNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FedwireRoutingNumber
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The ACH routing number of the bank account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_vault_us_bank_account#routing_number V2CoreVaultUsBankAccount#routing_number}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "routingNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RoutingNumber
            {
                get => GetInstanceProperty<string?>();
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
