using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PromotionCode
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code stripe_promotion_code}.</summary>
    [JsiiClass(nativeType: typeof(stripe.PromotionCode.PromotionCode), fullyQualifiedName: "stripe.promotionCode.PromotionCode", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"stripe.promotionCode.PromotionCodeConfig\"}}]")]
    public class PromotionCode : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code stripe_promotion_code} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public PromotionCode(Constructs.Construct scope, string id, stripe.PromotionCode.IPromotionCodeConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, stripe.PromotionCode.IPromotionCodeConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PromotionCode(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PromotionCode(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a PromotionCode resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the PromotionCode to import.</param>
        /// <param name="importFromId">The id of the existing PromotionCode that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the PromotionCode to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the PromotionCode to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing PromotionCode that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the PromotionCode to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(stripe.PromotionCode.PromotionCode), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putPromotion", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.promotionCode.PromotionCodePromotion\"}}]")]
        public virtual void PutPromotion(stripe.PromotionCode.IPromotionCodePromotion @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PromotionCode.IPromotionCodePromotion)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRestrictions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.promotionCode.PromotionCodeRestrictions\"}}]")]
        public virtual void PutRestrictions(stripe.PromotionCode.IPromotionCodeRestrictions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PromotionCode.IPromotionCodeRestrictions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetActive")]
        public virtual void ResetActive()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCode")]
        public virtual void ResetCode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomer")]
        public virtual void ResetCustomer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomerAccount")]
        public virtual void ResetCustomerAccount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExpiresAt")]
        public virtual void ResetExpiresAt()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxRedemptions")]
        public virtual void ResetMaxRedemptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetadata")]
        public virtual void ResetMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRestrictions")]
        public virtual void ResetRestrictions()
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
        = GetStaticProperty<string>(typeof(stripe.PromotionCode.PromotionCode))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "promotion", typeJson: "{\"fqn\":\"stripe.promotionCode.PromotionCodePromotionOutputReference\"}")]
        public virtual stripe.PromotionCode.PromotionCodePromotionOutputReference Promotion
        {
            get => GetInstanceProperty<stripe.PromotionCode.PromotionCodePromotionOutputReference>()!;
        }

        [JsiiProperty(name: "restrictions", typeJson: "{\"fqn\":\"stripe.promotionCode.PromotionCodeRestrictionsOutputReference\"}")]
        public virtual stripe.PromotionCode.PromotionCodeRestrictionsOutputReference Restrictions
        {
            get => GetInstanceProperty<stripe.PromotionCode.PromotionCodeRestrictionsOutputReference>()!;
        }

        [JsiiProperty(name: "timesRedeemed", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TimesRedeemed
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "activeInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ActiveInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "codeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CodeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customerAccountInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomerAccountInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "expiresAtInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ExpiresAtInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxRedemptionsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxRedemptionsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metadataInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? MetadataInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "promotionInput", typeJson: "{\"fqn\":\"stripe.promotionCode.PromotionCodePromotion\"}", isOptional: true)]
        public virtual stripe.PromotionCode.IPromotionCodePromotion? PromotionInput
        {
            get => GetInstanceProperty<stripe.PromotionCode.IPromotionCodePromotion?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "restrictionsInput", typeJson: "{\"fqn\":\"stripe.promotionCode.PromotionCodeRestrictions\"}", isOptional: true)]
        public virtual stripe.PromotionCode.IPromotionCodeRestrictions? RestrictionsInput
        {
            get => GetInstanceProperty<stripe.PromotionCode.IPromotionCodeRestrictions?>();
        }

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

        [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Code
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "customer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Customer
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "customerAccount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerAccount
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "expiresAt", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ExpiresAt
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxRedemptions", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxRedemptions
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
