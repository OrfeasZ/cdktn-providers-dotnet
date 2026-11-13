using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ProductCatalogTrialOffer
{
    [JsiiInterface(nativeType: typeof(IProductCatalogTrialOfferConfig), fullyQualifiedName: "stripe.productCatalogTrialOffer.ProductCatalogTrialOfferConfig")]
    public interface IProductCatalogTrialOfferConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/product_catalog_trial_offer#duration ProductCatalogTrialOffer#duration}.</summary>
        [JsiiProperty(name: "duration", typeJson: "{\"fqn\":\"stripe.productCatalogTrialOffer.ProductCatalogTrialOfferDuration\"}")]
        stripe.ProductCatalogTrialOffer.IProductCatalogTrialOfferDuration Duration
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/product_catalog_trial_offer#end_behavior ProductCatalogTrialOffer#end_behavior}.</summary>
        [JsiiProperty(name: "endBehavior", typeJson: "{\"fqn\":\"stripe.productCatalogTrialOffer.ProductCatalogTrialOfferEndBehavior\"}")]
        stripe.ProductCatalogTrialOffer.IProductCatalogTrialOfferEndBehavior EndBehavior
        {
            get;
        }

        /// <summary>The price during the trial offer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/product_catalog_trial_offer#price ProductCatalogTrialOffer#price}
        /// </remarks>
        [JsiiProperty(name: "price", typeJson: "{\"primitive\":\"string\"}")]
        string Price
        {
            get;
        }

        /// <summary>Whether the trial offer is active. Set to false to archive the trial offer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/product_catalog_trial_offer#active ProductCatalogTrialOffer#active}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "active", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Active
        {
            get
            {
                return null;
            }
        }

        /// <summary>A brief description of the trial offer, hidden from customers.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/product_catalog_trial_offer#nickname ProductCatalogTrialOffer#nickname}
        /// </remarks>
        [JsiiProperty(name: "nickname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Nickname
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IProductCatalogTrialOfferConfig), fullyQualifiedName: "stripe.productCatalogTrialOffer.ProductCatalogTrialOfferConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.ProductCatalogTrialOffer.IProductCatalogTrialOfferConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/product_catalog_trial_offer#duration ProductCatalogTrialOffer#duration}.</summary>
            [JsiiProperty(name: "duration", typeJson: "{\"fqn\":\"stripe.productCatalogTrialOffer.ProductCatalogTrialOfferDuration\"}")]
            public stripe.ProductCatalogTrialOffer.IProductCatalogTrialOfferDuration Duration
            {
                get => GetInstanceProperty<stripe.ProductCatalogTrialOffer.IProductCatalogTrialOfferDuration>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/product_catalog_trial_offer#end_behavior ProductCatalogTrialOffer#end_behavior}.</summary>
            [JsiiProperty(name: "endBehavior", typeJson: "{\"fqn\":\"stripe.productCatalogTrialOffer.ProductCatalogTrialOfferEndBehavior\"}")]
            public stripe.ProductCatalogTrialOffer.IProductCatalogTrialOfferEndBehavior EndBehavior
            {
                get => GetInstanceProperty<stripe.ProductCatalogTrialOffer.IProductCatalogTrialOfferEndBehavior>()!;
            }

            /// <summary>The price during the trial offer.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/product_catalog_trial_offer#price ProductCatalogTrialOffer#price}
            /// </remarks>
            [JsiiProperty(name: "price", typeJson: "{\"primitive\":\"string\"}")]
            public string Price
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Whether the trial offer is active. Set to false to archive the trial offer.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/product_catalog_trial_offer#active ProductCatalogTrialOffer#active}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "active", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Active
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>A brief description of the trial offer, hidden from customers.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/product_catalog_trial_offer#nickname ProductCatalogTrialOffer#nickname}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nickname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Nickname
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
