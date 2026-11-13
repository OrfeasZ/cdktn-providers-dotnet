using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementOutboundSetupIntent
{
    [JsiiInterface(nativeType: typeof(IV2MoneyManagementOutboundSetupIntentConfig), fullyQualifiedName: "stripe.v2MoneyManagementOutboundSetupIntent.V2MoneyManagementOutboundSetupIntentConfig")]
    public interface IV2MoneyManagementOutboundSetupIntentConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Use the PayoutMethods API to list and interact with PayoutMethod objects.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_setup_intent#payout_method V2MoneyManagementOutboundSetupIntent#payout_method}
        /// </remarks>
        [JsiiProperty(name: "payoutMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PayoutMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>If no payout_method provided, used to create the underlying credential that is set up for outbound money movement.</summary>
        /// <remarks>
        /// If a payout_method provided, used to update data on the credential linked to this setup intent.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_setup_intent#payout_method_data V2MoneyManagementOutboundSetupIntent#payout_method_data}
        /// </remarks>
        [JsiiProperty(name: "payoutMethodData", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementOutboundSetupIntent.V2MoneyManagementOutboundSetupIntentPayoutMethodData\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.V2MoneyManagementOutboundSetupIntent.IV2MoneyManagementOutboundSetupIntentPayoutMethodData? PayoutMethodData
        {
            get
            {
                return null;
            }
        }

        /// <summary>The intended money movement flow this payout method should be set up for, specified in params.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_setup_intent#usage_intent V2MoneyManagementOutboundSetupIntent#usage_intent}
        /// </remarks>
        [JsiiProperty(name: "usageIntent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UsageIntent
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IV2MoneyManagementOutboundSetupIntentConfig), fullyQualifiedName: "stripe.v2MoneyManagementOutboundSetupIntent.V2MoneyManagementOutboundSetupIntentConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.V2MoneyManagementOutboundSetupIntent.IV2MoneyManagementOutboundSetupIntentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Use the PayoutMethods API to list and interact with PayoutMethod objects.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_setup_intent#payout_method V2MoneyManagementOutboundSetupIntent#payout_method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "payoutMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PayoutMethod
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>If no payout_method provided, used to create the underlying credential that is set up for outbound money movement.</summary>
            /// <remarks>
            /// If a payout_method provided, used to update data on the credential linked to this setup intent.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_setup_intent#payout_method_data V2MoneyManagementOutboundSetupIntent#payout_method_data}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "payoutMethodData", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementOutboundSetupIntent.V2MoneyManagementOutboundSetupIntentPayoutMethodData\"}", isOptional: true)]
            public stripe.V2MoneyManagementOutboundSetupIntent.IV2MoneyManagementOutboundSetupIntentPayoutMethodData? PayoutMethodData
            {
                get => GetInstanceProperty<stripe.V2MoneyManagementOutboundSetupIntent.IV2MoneyManagementOutboundSetupIntentPayoutMethodData?>();
            }

            /// <summary>The intended money movement flow this payout method should be set up for, specified in params.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_setup_intent#usage_intent V2MoneyManagementOutboundSetupIntent#usage_intent}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "usageIntent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UsageIntent
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
