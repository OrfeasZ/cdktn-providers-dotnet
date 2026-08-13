using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingCard
{
    [JsiiInterface(nativeType: typeof(IIssuingCardConfig), fullyQualifiedName: "stripe.issuingCard.IssuingCardConfig")]
    public interface IIssuingCardConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Three-letter [ISO currency code](https://www.iso.org/iso-4217-currency-codes.html), in lowercase. Supported currencies are `usd` in the US, `eur` in the EU, and `gbp` in the UK.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#currency IssuingCard#currency}
        /// </remarks>
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        string Currency
        {
            get;
        }

        /// <summary>The type of the card.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#type IssuingCard#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>An Issuing `Cardholder` object represents an individual or business entity who is [issued](https://docs.stripe.com/issuing) cards.</summary>
        /// <remarks>
        /// Related guide: <a href="https://docs.stripe.com/issuing/cards/virtual/issue-cards#create-cardholder">How to create a cardholder</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#cardholder IssuingCard#cardholder}
        /// </remarks>
        [JsiiProperty(name: "cardholder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Cardholder
        {
            get
            {
                return null;
            }
        }

        /// <summary>The expiration month of the card.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#exp_month IssuingCard#exp_month}
        /// </remarks>
        [JsiiProperty(name: "expMonth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ExpMonth
        {
            get
            {
                return null;
            }
        }

        /// <summary>The expiration year of the card.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#exp_year IssuingCard#exp_year}
        /// </remarks>
        [JsiiProperty(name: "expYear", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ExpYear
        {
            get
            {
                return null;
            }
        }

        /// <summary>The financial account this card is attached to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#financial_account IssuingCard#financial_account}
        /// </remarks>
        [JsiiProperty(name: "financialAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FinancialAccount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Rules that control the lifecycle of this card, such as automatic cancellation. Refer to our [documentation](/issuing/controls/lifecycle-controls) for more details.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#lifecycle_controls IssuingCard#lifecycle_controls}
        /// </remarks>
        [JsiiProperty(name: "lifecycleControls", typeJson: "{\"fqn\":\"stripe.issuingCard.IssuingCardLifecycleControls\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.IssuingCard.IIssuingCardLifecycleControls? LifecycleControls
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#metadata IssuingCard#metadata}
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

        /// <summary>The personalization design object belonging to this card.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#personalization_design IssuingCard#personalization_design}
        /// </remarks>
        [JsiiProperty(name: "personalizationDesign", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PersonalizationDesign
        {
            get
            {
                return null;
            }
        }

        /// <summary>The desired PIN for this card.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#pin IssuingCard#pin}
        /// </remarks>
        [JsiiProperty(name: "pin", typeJson: "{\"fqn\":\"stripe.issuingCard.IssuingCardPin\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.IssuingCard.IIssuingCardPin? Pin
        {
            get
            {
                return null;
            }
        }

        /// <summary>The card this card replaces, if any.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#replacement_for IssuingCard#replacement_for}
        /// </remarks>
        [JsiiProperty(name: "replacementFor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReplacementFor
        {
            get
            {
                return null;
            }
        }

        /// <summary>The reason why the previous card needed to be replaced.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#replacement_reason IssuingCard#replacement_reason}
        /// </remarks>
        [JsiiProperty(name: "replacementReason", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReplacementReason
        {
            get
            {
                return null;
            }
        }

        /// <summary>Where and how the card will be shipped.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#shipping IssuingCard#shipping}
        /// </remarks>
        [JsiiProperty(name: "shipping", typeJson: "{\"fqn\":\"stripe.issuingCard.IssuingCardShipping\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.IssuingCard.IIssuingCardShipping? Shipping
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#spending_controls IssuingCard#spending_controls}.</summary>
        [JsiiProperty(name: "spendingControls", typeJson: "{\"fqn\":\"stripe.issuingCard.IssuingCardSpendingControls\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.IssuingCard.IIssuingCardSpendingControls? SpendingControls
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether authorizations can be approved on this card.</summary>
        /// <remarks>
        /// May be blocked from activating cards depending on past-due Cardholder requirements. Defaults to <c>inactive</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#status IssuingCard#status}
        /// </remarks>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Status
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIssuingCardConfig), fullyQualifiedName: "stripe.issuingCard.IssuingCardConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.IssuingCard.IIssuingCardConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Three-letter [ISO currency code](https://www.iso.org/iso-4217-currency-codes.html), in lowercase. Supported currencies are `usd` in the US, `eur` in the EU, and `gbp` in the UK.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#currency IssuingCard#currency}
            /// </remarks>
            [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
            public string Currency
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The type of the card.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#type IssuingCard#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>An Issuing `Cardholder` object represents an individual or business entity who is [issued](https://docs.stripe.com/issuing) cards.</summary>
            /// <remarks>
            /// Related guide: <a href="https://docs.stripe.com/issuing/cards/virtual/issue-cards#create-cardholder">How to create a cardholder</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#cardholder IssuingCard#cardholder}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cardholder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Cardholder
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The expiration month of the card.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#exp_month IssuingCard#exp_month}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "expMonth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ExpMonth
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The expiration year of the card.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#exp_year IssuingCard#exp_year}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "expYear", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ExpYear
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The financial account this card is attached to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#financial_account IssuingCard#financial_account}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "financialAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FinancialAccount
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Rules that control the lifecycle of this card, such as automatic cancellation. Refer to our [documentation](/issuing/controls/lifecycle-controls) for more details.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#lifecycle_controls IssuingCard#lifecycle_controls}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycleControls", typeJson: "{\"fqn\":\"stripe.issuingCard.IssuingCardLifecycleControls\"}", isOptional: true)]
            public stripe.IssuingCard.IIssuingCardLifecycleControls? LifecycleControls
            {
                get => GetInstanceProperty<stripe.IssuingCard.IIssuingCardLifecycleControls?>();
            }

            /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#metadata IssuingCard#metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>The personalization design object belonging to this card.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#personalization_design IssuingCard#personalization_design}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "personalizationDesign", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PersonalizationDesign
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The desired PIN for this card.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#pin IssuingCard#pin}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pin", typeJson: "{\"fqn\":\"stripe.issuingCard.IssuingCardPin\"}", isOptional: true)]
            public stripe.IssuingCard.IIssuingCardPin? Pin
            {
                get => GetInstanceProperty<stripe.IssuingCard.IIssuingCardPin?>();
            }

            /// <summary>The card this card replaces, if any.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#replacement_for IssuingCard#replacement_for}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "replacementFor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReplacementFor
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The reason why the previous card needed to be replaced.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#replacement_reason IssuingCard#replacement_reason}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "replacementReason", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReplacementReason
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Where and how the card will be shipped.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#shipping IssuingCard#shipping}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shipping", typeJson: "{\"fqn\":\"stripe.issuingCard.IssuingCardShipping\"}", isOptional: true)]
            public stripe.IssuingCard.IIssuingCardShipping? Shipping
            {
                get => GetInstanceProperty<stripe.IssuingCard.IIssuingCardShipping?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#spending_controls IssuingCard#spending_controls}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "spendingControls", typeJson: "{\"fqn\":\"stripe.issuingCard.IssuingCardSpendingControls\"}", isOptional: true)]
            public stripe.IssuingCard.IIssuingCardSpendingControls? SpendingControls
            {
                get => GetInstanceProperty<stripe.IssuingCard.IIssuingCardSpendingControls?>();
            }

            /// <summary>Whether authorizations can be approved on this card.</summary>
            /// <remarks>
            /// May be blocked from activating cards depending on past-due Cardholder requirements. Defaults to <c>inactive</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#status IssuingCard#status}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
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
