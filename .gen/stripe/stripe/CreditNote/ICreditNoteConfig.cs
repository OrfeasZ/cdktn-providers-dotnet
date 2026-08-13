using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.CreditNote
{
    [JsiiInterface(nativeType: typeof(ICreditNoteConfig), fullyQualifiedName: "stripe.creditNote.CreditNoteConfig")]
    public interface ICreditNoteConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>ID of the invoice.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#invoice CreditNote#invoice}
        /// </remarks>
        [JsiiProperty(name: "invoice", typeJson: "{\"primitive\":\"string\"}")]
        string Invoice
        {
            get;
        }

        /// <summary>The integer amount in cents (or local equivalent) representing the total amount of the credit note, including tax.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#amount CreditNote#amount}
        /// </remarks>
        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Amount
        {
            get
            {
                return null;
            }
        }

        /// <summary>The integer amount in cents (or local equivalent) representing the amount to credit the customer's balance, which will be automatically applied to their next invoice.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#credit_amount CreditNote#credit_amount}
        /// </remarks>
        [JsiiProperty(name: "creditAmount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CreditAmount
        {
            get
            {
                return null;
            }
        }

        /// <summary>The date when this credit note is in effect.</summary>
        /// <remarks>
        /// Same as <c>created</c> unless overwritten. When defined, this value replaces the system-generated 'Date of issue' printed on the credit note PDF.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#effective_at CreditNote#effective_at}
        /// </remarks>
        [JsiiProperty(name: "effectiveAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? EffectiveAt
        {
            get
            {
                return null;
            }
        }

        /// <summary>Type of email to send to the customer, one of `credit_note` or `none` and the default is `credit_note`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#email_type CreditNote#email_type}
        /// </remarks>
        [JsiiProperty(name: "emailType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EmailType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Customer-facing text that appears on the credit note PDF.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#memo CreditNote#memo}
        /// </remarks>
        [JsiiProperty(name: "memo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Memo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#metadata CreditNote#metadata}
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

        /// <summary>Amount that was credited outside of Stripe.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#out_of_band_amount CreditNote#out_of_band_amount}
        /// </remarks>
        [JsiiProperty(name: "outOfBandAmount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? OutOfBandAmount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Reason for issuing this credit note, one of `duplicate`, `fraudulent`, `order_change`, or `product_unsatisfactory`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#reason CreditNote#reason}
        /// </remarks>
        [JsiiProperty(name: "reason", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Reason
        {
            get
            {
                return null;
            }
        }

        /// <summary>The integer amount in cents (or local equivalent) representing the amount to refund.</summary>
        /// <remarks>
        /// If set, a refund will be created for the charge associated with the invoice.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#refund_amount CreditNote#refund_amount}
        /// </remarks>
        [JsiiProperty(name: "refundAmount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RefundAmount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Refunds related to this credit note.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#refunds CreditNote#refunds}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.CreditNote.ICreditNoteRefunds" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "refunds", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.creditNote.CreditNoteRefunds\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Refunds
        {
            get
            {
                return null;
            }
        }

        /// <summary>The details of the cost of shipping, including the ShippingRate applied to the invoice.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#shipping_cost CreditNote#shipping_cost}
        /// </remarks>
        [JsiiProperty(name: "shippingCost", typeJson: "{\"fqn\":\"stripe.creditNote.CreditNoteShippingCost\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.CreditNote.ICreditNoteShippingCost? ShippingCost
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICreditNoteConfig), fullyQualifiedName: "stripe.creditNote.CreditNoteConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.CreditNote.ICreditNoteConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ID of the invoice.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#invoice CreditNote#invoice}
            /// </remarks>
            [JsiiProperty(name: "invoice", typeJson: "{\"primitive\":\"string\"}")]
            public string Invoice
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The integer amount in cents (or local equivalent) representing the total amount of the credit note, including tax.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#amount CreditNote#amount}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Amount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The integer amount in cents (or local equivalent) representing the amount to credit the customer's balance, which will be automatically applied to their next invoice.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#credit_amount CreditNote#credit_amount}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "creditAmount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CreditAmount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The date when this credit note is in effect.</summary>
            /// <remarks>
            /// Same as <c>created</c> unless overwritten. When defined, this value replaces the system-generated 'Date of issue' printed on the credit note PDF.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#effective_at CreditNote#effective_at}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "effectiveAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? EffectiveAt
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Type of email to send to the customer, one of `credit_note` or `none` and the default is `credit_note`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#email_type CreditNote#email_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "emailType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EmailType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Customer-facing text that appears on the credit note PDF.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#memo CreditNote#memo}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "memo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Memo
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#metadata CreditNote#metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Amount that was credited outside of Stripe.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#out_of_band_amount CreditNote#out_of_band_amount}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "outOfBandAmount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? OutOfBandAmount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Reason for issuing this credit note, one of `duplicate`, `fraudulent`, `order_change`, or `product_unsatisfactory`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#reason CreditNote#reason}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "reason", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Reason
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The integer amount in cents (or local equivalent) representing the amount to refund.</summary>
            /// <remarks>
            /// If set, a refund will be created for the charge associated with the invoice.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#refund_amount CreditNote#refund_amount}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "refundAmount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RefundAmount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Refunds related to this credit note.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#refunds CreditNote#refunds}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.CreditNote.ICreditNoteRefunds" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "refunds", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.creditNote.CreditNoteRefunds\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Refunds
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The details of the cost of shipping, including the ShippingRate applied to the invoice.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#shipping_cost CreditNote#shipping_cost}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shippingCost", typeJson: "{\"fqn\":\"stripe.creditNote.CreditNoteShippingCost\"}", isOptional: true)]
            public stripe.CreditNote.ICreditNoteShippingCost? ShippingCost
            {
                get => GetInstanceProperty<stripe.CreditNote.ICreditNoteShippingCost?>();
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
