using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ProductCatalogTrialOffer
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/product_catalog_trial_offer stripe_product_catalog_trial_offer}.</summary>
    [JsiiClass(nativeType: typeof(stripe.ProductCatalogTrialOffer.ProductCatalogTrialOffer), fullyQualifiedName: "stripe.productCatalogTrialOffer.ProductCatalogTrialOffer", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"stripe.productCatalogTrialOffer.ProductCatalogTrialOfferConfig\"}}]")]
    public class ProductCatalogTrialOffer : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/product_catalog_trial_offer stripe_product_catalog_trial_offer} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ProductCatalogTrialOffer(Constructs.Construct scope, string id, stripe.ProductCatalogTrialOffer.IProductCatalogTrialOfferConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, stripe.ProductCatalogTrialOffer.IProductCatalogTrialOfferConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ProductCatalogTrialOffer(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ProductCatalogTrialOffer(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a ProductCatalogTrialOffer resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ProductCatalogTrialOffer to import.</param>
        /// <param name="importFromId">The id of the existing ProductCatalogTrialOffer that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ProductCatalogTrialOffer to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ProductCatalogTrialOffer to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/product_catalog_trial_offer#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ProductCatalogTrialOffer that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ProductCatalogTrialOffer to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(stripe.ProductCatalogTrialOffer.ProductCatalogTrialOffer), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putDuration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.productCatalogTrialOffer.ProductCatalogTrialOfferDuration\"}}]")]
        public virtual void PutDuration(stripe.ProductCatalogTrialOffer.IProductCatalogTrialOfferDuration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.ProductCatalogTrialOffer.IProductCatalogTrialOfferDuration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEndBehavior", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.productCatalogTrialOffer.ProductCatalogTrialOfferEndBehavior\"}}]")]
        public virtual void PutEndBehavior(stripe.ProductCatalogTrialOffer.IProductCatalogTrialOfferEndBehavior @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.ProductCatalogTrialOffer.IProductCatalogTrialOfferEndBehavior)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetActive")]
        public virtual void ResetActive()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNickname")]
        public virtual void ResetNickname()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(stripe.ProductCatalogTrialOffer.ProductCatalogTrialOffer))!;

        [JsiiProperty(name: "duration", typeJson: "{\"fqn\":\"stripe.productCatalogTrialOffer.ProductCatalogTrialOfferDurationOutputReference\"}")]
        public virtual stripe.ProductCatalogTrialOffer.ProductCatalogTrialOfferDurationOutputReference Duration
        {
            get => GetInstanceProperty<stripe.ProductCatalogTrialOffer.ProductCatalogTrialOfferDurationOutputReference>()!;
        }

        [JsiiProperty(name: "endBehavior", typeJson: "{\"fqn\":\"stripe.productCatalogTrialOffer.ProductCatalogTrialOfferEndBehaviorOutputReference\"}")]
        public virtual stripe.ProductCatalogTrialOffer.ProductCatalogTrialOfferEndBehaviorOutputReference EndBehavior
        {
            get => GetInstanceProperty<stripe.ProductCatalogTrialOffer.ProductCatalogTrialOfferEndBehaviorOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "livemode", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Livemode
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Object
        {
            get => GetInstanceProperty<string>()!;
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "activeInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ActiveInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.ProductCatalogTrialOffer.IProductCatalogTrialOfferDuration" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "durationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.productCatalogTrialOffer.ProductCatalogTrialOfferDuration\"}]}}", isOptional: true)]
        public virtual object? DurationInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.ProductCatalogTrialOffer.IProductCatalogTrialOfferEndBehavior" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "endBehaviorInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.productCatalogTrialOffer.ProductCatalogTrialOfferEndBehavior\"}]}}", isOptional: true)]
        public virtual object? EndBehaviorInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nicknameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NicknameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "priceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PriceInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "active", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Active
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "nickname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Nickname
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "price", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Price
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
