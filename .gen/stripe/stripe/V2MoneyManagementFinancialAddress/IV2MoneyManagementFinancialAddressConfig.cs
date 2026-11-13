using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementFinancialAddress
{
    [JsiiInterface(nativeType: typeof(IV2MoneyManagementFinancialAddressConfig), fullyQualifiedName: "stripe.v2MoneyManagementFinancialAddress.V2MoneyManagementFinancialAddressConfig")]
    public interface IV2MoneyManagementFinancialAddressConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The ID of the FinancialAccount this FinancialAddress corresponds to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_financial_address#financial_account V2MoneyManagementFinancialAddress#financial_account}
        /// </remarks>
        [JsiiProperty(name: "financialAccount", typeJson: "{\"primitive\":\"string\"}")]
        string FinancialAccount
        {
            get;
        }

        /// <summary>Open Enum. The type of FinancialAddress.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_financial_address#type V2MoneyManagementFinancialAddress#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Bank account details for this FinancialAddress.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_financial_address#bank_account V2MoneyManagementFinancialAddress#bank_account}
        /// </remarks>
        [JsiiProperty(name: "bankAccount", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementFinancialAddress.V2MoneyManagementFinancialAddressBankAccount\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.V2MoneyManagementFinancialAddress.IV2MoneyManagementFinancialAddressBankAccount? BankAccount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IV2MoneyManagementFinancialAddressConfig), fullyQualifiedName: "stripe.v2MoneyManagementFinancialAddress.V2MoneyManagementFinancialAddressConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.V2MoneyManagementFinancialAddress.IV2MoneyManagementFinancialAddressConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of the FinancialAccount this FinancialAddress corresponds to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_financial_address#financial_account V2MoneyManagementFinancialAddress#financial_account}
            /// </remarks>
            [JsiiProperty(name: "financialAccount", typeJson: "{\"primitive\":\"string\"}")]
            public string FinancialAccount
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Open Enum. The type of FinancialAddress.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_financial_address#type V2MoneyManagementFinancialAddress#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Bank account details for this FinancialAddress.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_financial_address#bank_account V2MoneyManagementFinancialAddress#bank_account}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bankAccount", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementFinancialAddress.V2MoneyManagementFinancialAddressBankAccount\"}", isOptional: true)]
            public stripe.V2MoneyManagementFinancialAddress.IV2MoneyManagementFinancialAddressBankAccount? BankAccount
            {
                get => GetInstanceProperty<stripe.V2MoneyManagementFinancialAddress.IV2MoneyManagementFinancialAddressBankAccount?>();
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
