using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingCardholder
{
    [JsiiInterface(nativeType: typeof(IIssuingCardholderConfig), fullyQualifiedName: "stripe.issuingCardholder.IssuingCardholderConfig")]
    public interface IIssuingCardholderConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#billing IssuingCardholder#billing}.</summary>
        [JsiiProperty(name: "billing", typeJson: "{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderBilling\"}")]
        stripe.IssuingCardholder.IIssuingCardholderBilling Billing
        {
            get;
        }

        /// <summary>The cardholder's name. This will be printed on cards issued to them.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#name IssuingCardholder#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Additional information about a `company` cardholder.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#company IssuingCardholder#company}
        /// </remarks>
        [JsiiProperty(name: "company", typeJson: "{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderCompany\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.IssuingCardholder.IIssuingCardholderCompany? Company
        {
            get
            {
                return null;
            }
        }

        /// <summary>The cardholder's email address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#email IssuingCardholder#email}
        /// </remarks>
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Email
        {
            get
            {
                return null;
            }
        }

        /// <summary>Additional information about an `individual` cardholder.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#individual IssuingCardholder#individual}
        /// </remarks>
        [JsiiProperty(name: "individual", typeJson: "{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderIndividual\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.IssuingCardholder.IIssuingCardholderIndividual? Individual
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#metadata IssuingCardholder#metadata}
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

        /// <summary>The cardholder's phone number.</summary>
        /// <remarks>
        /// This is required for all cardholders who will be creating EU cards. See the <a href="https://docs.stripe.com/issuing/3d-secure#when-is-3d-secure-applied">3D Secure documentation</a> for more details.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#phone_number IssuingCardholder#phone_number}
        /// </remarks>
        [JsiiProperty(name: "phoneNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PhoneNumber
        {
            get
            {
                return null;
            }
        }

        /// <summary>The cardholder’s preferred locales (languages), ordered by preference.</summary>
        /// <remarks>
        /// Locales can be <c>da</c>, <c>de</c>, <c>en</c>, <c>es</c>, <c>fr</c>, <c>it</c>, <c>pl</c>, or <c>sv</c>.
        /// This changes the language of the <a href="https://docs.stripe.com/issuing/3d-secure">3D Secure flow</a> and one-time password messages sent to the cardholder.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#preferred_locales IssuingCardholder#preferred_locales}
        /// </remarks>
        [JsiiProperty(name: "preferredLocales", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PreferredLocales
        {
            get
            {
                return null;
            }
        }

        /// <summary>Rules that control spending across this cardholder's cards. Refer to our [documentation](https://docs.stripe.com/issuing/controls/spending-controls) for more details.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#spending_controls IssuingCardholder#spending_controls}
        /// </remarks>
        [JsiiProperty(name: "spendingControls", typeJson: "{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderSpendingControls\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.IssuingCardholder.IIssuingCardholderSpendingControls? SpendingControls
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies whether to permit authorizations on this cardholder's cards.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#status IssuingCardholder#status}
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

        /// <summary>One of `individual` or `company`. See [Choose a cardholder type](https://docs.stripe.com/issuing/other/choose-cardholder) for more details.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#type IssuingCardholder#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIssuingCardholderConfig), fullyQualifiedName: "stripe.issuingCardholder.IssuingCardholderConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.IssuingCardholder.IIssuingCardholderConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#billing IssuingCardholder#billing}.</summary>
            [JsiiProperty(name: "billing", typeJson: "{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderBilling\"}")]
            public stripe.IssuingCardholder.IIssuingCardholderBilling Billing
            {
                get => GetInstanceProperty<stripe.IssuingCardholder.IIssuingCardholderBilling>()!;
            }

            /// <summary>The cardholder's name. This will be printed on cards issued to them.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#name IssuingCardholder#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Additional information about a `company` cardholder.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#company IssuingCardholder#company}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "company", typeJson: "{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderCompany\"}", isOptional: true)]
            public stripe.IssuingCardholder.IIssuingCardholderCompany? Company
            {
                get => GetInstanceProperty<stripe.IssuingCardholder.IIssuingCardholderCompany?>();
            }

            /// <summary>The cardholder's email address.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#email IssuingCardholder#email}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Email
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Additional information about an `individual` cardholder.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#individual IssuingCardholder#individual}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "individual", typeJson: "{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderIndividual\"}", isOptional: true)]
            public stripe.IssuingCardholder.IIssuingCardholderIndividual? Individual
            {
                get => GetInstanceProperty<stripe.IssuingCardholder.IIssuingCardholderIndividual?>();
            }

            /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#metadata IssuingCardholder#metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>The cardholder's phone number.</summary>
            /// <remarks>
            /// This is required for all cardholders who will be creating EU cards. See the <a href="https://docs.stripe.com/issuing/3d-secure#when-is-3d-secure-applied">3D Secure documentation</a> for more details.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#phone_number IssuingCardholder#phone_number}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "phoneNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PhoneNumber
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The cardholder’s preferred locales (languages), ordered by preference.</summary>
            /// <remarks>
            /// Locales can be <c>da</c>, <c>de</c>, <c>en</c>, <c>es</c>, <c>fr</c>, <c>it</c>, <c>pl</c>, or <c>sv</c>.
            /// This changes the language of the <a href="https://docs.stripe.com/issuing/3d-secure">3D Secure flow</a> and one-time password messages sent to the cardholder.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#preferred_locales IssuingCardholder#preferred_locales}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preferredLocales", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PreferredLocales
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Rules that control spending across this cardholder's cards. Refer to our [documentation](https://docs.stripe.com/issuing/controls/spending-controls) for more details.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#spending_controls IssuingCardholder#spending_controls}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spendingControls", typeJson: "{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderSpendingControls\"}", isOptional: true)]
            public stripe.IssuingCardholder.IIssuingCardholderSpendingControls? SpendingControls
            {
                get => GetInstanceProperty<stripe.IssuingCardholder.IIssuingCardholderSpendingControls?>();
            }

            /// <summary>Specifies whether to permit authorizations on this cardholder's cards.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#status IssuingCardholder#status}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>One of `individual` or `company`. See [Choose a cardholder type](https://docs.stripe.com/issuing/other/choose-cardholder) for more details.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#type IssuingCardholder#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
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
