using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2CoreVaultGbBankAccount
{
    [JsiiInterface(nativeType: typeof(IV2CoreVaultGbBankAccountConfig), fullyQualifiedName: "stripe.v2CoreVaultGbBankAccount.V2CoreVaultGbBankAccountConfig")]
    public interface IV2CoreVaultGbBankAccountConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The currency of the bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_vault_gb_bank_account#currency V2CoreVaultGbBankAccount#currency}
        /// </remarks>
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        string Currency
        {
            get;
        }

        /// <summary>The Account Number of the bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_vault_gb_bank_account#account_number V2CoreVaultGbBankAccount#account_number}
        /// </remarks>
        [JsiiProperty(name: "accountNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccountNumber
        {
            get
            {
                return null;
            }
        }

        /// <summary>Closed Enum. The type of the bank account (checking or savings).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_vault_gb_bank_account#bank_account_type V2CoreVaultGbBankAccount#bank_account_type}
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

        /// <summary>The IBAN of the bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_vault_gb_bank_account#iban V2CoreVaultGbBankAccount#iban}
        /// </remarks>
        [JsiiProperty(name: "iban", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Iban
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Sort Code of the bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_vault_gb_bank_account#sort_code V2CoreVaultGbBankAccount#sort_code}
        /// </remarks>
        [JsiiProperty(name: "sortCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SortCode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IV2CoreVaultGbBankAccountConfig), fullyQualifiedName: "stripe.v2CoreVaultGbBankAccount.V2CoreVaultGbBankAccountConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.V2CoreVaultGbBankAccount.IV2CoreVaultGbBankAccountConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The currency of the bank account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_vault_gb_bank_account#currency V2CoreVaultGbBankAccount#currency}
            /// </remarks>
            [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
            public string Currency
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The Account Number of the bank account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_vault_gb_bank_account#account_number V2CoreVaultGbBankAccount#account_number}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accountNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountNumber
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Closed Enum. The type of the bank account (checking or savings).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_vault_gb_bank_account#bank_account_type V2CoreVaultGbBankAccount#bank_account_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bankAccountType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BankAccountType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The IBAN of the bank account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_vault_gb_bank_account#iban V2CoreVaultGbBankAccount#iban}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "iban", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Iban
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Sort Code of the bank account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_vault_gb_bank_account#sort_code V2CoreVaultGbBankAccount#sort_code}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sortCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SortCode
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
