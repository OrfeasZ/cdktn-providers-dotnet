using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementOutboundPayment
{
    [JsiiInterface(nativeType: typeof(IV2MoneyManagementOutboundPaymentConfig), fullyQualifiedName: "stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentConfig")]
    public interface IV2MoneyManagementOutboundPaymentConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The amount and currency requested for this OutboundPayment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#amount V2MoneyManagementOutboundPayment#amount}
        /// </remarks>
        [JsiiProperty(name: "amount", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentAmount\"}")]
        stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentAmount Amount
        {
            get;
        }

        /// <summary>The FinancialAccount that funds were pulled from.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#from V2MoneyManagementOutboundPayment#from}
        /// </remarks>
        [JsiiProperty(name: "from", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentFrom\"}")]
        stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentFrom From
        {
            get;
        }

        /// <summary>To which payout method the OutboundPayment was sent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#to V2MoneyManagementOutboundPayment#to}
        /// </remarks>
        [JsiiProperty(name: "to", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentTo\"}")]
        stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentTo To
        {
            get;
        }

        /// <summary>An arbitrary string attached to the OutboundPayment. Often useful for displaying to users.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#description V2MoneyManagementOutboundPayment#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set of key-value pairs that you can attach to an object.</summary>
        /// <remarks>
        /// This can be useful for storing additional information about the object in a structured format.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#metadata V2MoneyManagementOutboundPayment#metadata}
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>Details about the OutboundPayment notification settings for recipient.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#recipient_notification V2MoneyManagementOutboundPayment#recipient_notification}
        /// </remarks>
        [JsiiProperty(name: "recipientNotification", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentRecipientNotification\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentRecipientNotification? RecipientNotification
        {
            get
            {
                return null;
            }
        }

        /// <summary>The ID of the RecipientVerification for this OutboundPayment. Required where recipient-name verification is mandated before creating an OutboundPayment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#recipient_verification V2MoneyManagementOutboundPayment#recipient_verification}
        /// </remarks>
        [JsiiProperty(name: "recipientVerification", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RecipientVerification
        {
            get
            {
                return null;
            }
        }

        /// <summary>The description that appears on the receiving end of an OutboundPayment (for example, on a bank statement).</summary>
        /// <remarks>
        /// Defaults to <c>STRIPE</c> if not configured in the account settings.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#statement_descriptor V2MoneyManagementOutboundPayment#statement_descriptor}
        /// </remarks>
        [JsiiProperty(name: "statementDescriptor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StatementDescriptor
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IV2MoneyManagementOutboundPaymentConfig), fullyQualifiedName: "stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The amount and currency requested for this OutboundPayment.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#amount V2MoneyManagementOutboundPayment#amount}
            /// </remarks>
            [JsiiProperty(name: "amount", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentAmount\"}")]
            public stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentAmount Amount
            {
                get => GetInstanceProperty<stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentAmount>()!;
            }

            /// <summary>The FinancialAccount that funds were pulled from.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#from V2MoneyManagementOutboundPayment#from}
            /// </remarks>
            [JsiiProperty(name: "from", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentFrom\"}")]
            public stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentFrom From
            {
                get => GetInstanceProperty<stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentFrom>()!;
            }

            /// <summary>To which payout method the OutboundPayment was sent.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#to V2MoneyManagementOutboundPayment#to}
            /// </remarks>
            [JsiiProperty(name: "to", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentTo\"}")]
            public stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentTo To
            {
                get => GetInstanceProperty<stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentTo>()!;
            }

            /// <summary>An arbitrary string attached to the OutboundPayment. Often useful for displaying to users.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#description V2MoneyManagementOutboundPayment#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Set of key-value pairs that you can attach to an object.</summary>
            /// <remarks>
            /// This can be useful for storing additional information about the object in a structured format.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#metadata V2MoneyManagementOutboundPayment#metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Details about the OutboundPayment notification settings for recipient.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#recipient_notification V2MoneyManagementOutboundPayment#recipient_notification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "recipientNotification", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentRecipientNotification\"}", isOptional: true)]
            public stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentRecipientNotification? RecipientNotification
            {
                get => GetInstanceProperty<stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentRecipientNotification?>();
            }

            /// <summary>The ID of the RecipientVerification for this OutboundPayment. Required where recipient-name verification is mandated before creating an OutboundPayment.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#recipient_verification V2MoneyManagementOutboundPayment#recipient_verification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "recipientVerification", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RecipientVerification
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The description that appears on the receiving end of an OutboundPayment (for example, on a bank statement).</summary>
            /// <remarks>
            /// Defaults to <c>STRIPE</c> if not configured in the account settings.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#statement_descriptor V2MoneyManagementOutboundPayment#statement_descriptor}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "statementDescriptor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StatementDescriptor
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
