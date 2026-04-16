using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Coupon
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon stripe_coupon}.</summary>
    [JsiiClass(nativeType: typeof(stripe.Coupon.Coupon), fullyQualifiedName: "stripe.coupon.Coupon", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"stripe.coupon.CouponConfig\"}}]")]
    public class Coupon : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon stripe_coupon} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Coupon(Constructs.Construct scope, string id, stripe.Coupon.ICouponConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, stripe.Coupon.ICouponConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Coupon(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Coupon(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a Coupon resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the Coupon to import.</param>
        /// <param name="importFromId">The id of the existing Coupon that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the Coupon to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the Coupon to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing Coupon that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the Coupon to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(stripe.Coupon.Coupon), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAppliesTo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.coupon.CouponAppliesTo\"}}]")]
        public virtual void PutAppliesTo(stripe.Coupon.ICouponAppliesTo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Coupon.ICouponAppliesTo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCurrencyOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.coupon.CouponCurrencyOptions\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCurrencyOptions(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case stripe.Coupon.ICouponCurrencyOptions[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Coupon.ICouponCurrencyOptions).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Coupon.ICouponCurrencyOptions).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putScript", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.coupon.CouponScript\"}}]")]
        public virtual void PutScript(stripe.Coupon.ICouponScript @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Coupon.ICouponScript)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAmountOff")]
        public virtual void ResetAmountOff()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAppliesTo")]
        public virtual void ResetAppliesTo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCurrency")]
        public virtual void ResetCurrency()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCurrencyOptions")]
        public virtual void ResetCurrencyOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDuration")]
        public virtual void ResetDuration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDurationInMonths")]
        public virtual void ResetDurationInMonths()
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

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPercentOff")]
        public virtual void ResetPercentOff()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRedeemBy")]
        public virtual void ResetRedeemBy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScript")]
        public virtual void ResetScript()
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
        = GetStaticProperty<string>(typeof(stripe.Coupon.Coupon))!;

        [JsiiProperty(name: "appliesTo", typeJson: "{\"fqn\":\"stripe.coupon.CouponAppliesToOutputReference\"}")]
        public virtual stripe.Coupon.CouponAppliesToOutputReference AppliesTo
        {
            get => GetInstanceProperty<stripe.Coupon.CouponAppliesToOutputReference>()!;
        }

        [JsiiProperty(name: "currencyOptions", typeJson: "{\"fqn\":\"stripe.coupon.CouponCurrencyOptionsList\"}")]
        public virtual stripe.Coupon.CouponCurrencyOptionsList CurrencyOptions
        {
            get => GetInstanceProperty<stripe.Coupon.CouponCurrencyOptionsList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "script", typeJson: "{\"fqn\":\"stripe.coupon.CouponScriptOutputReference\"}")]
        public virtual stripe.Coupon.CouponScriptOutputReference Script
        {
            get => GetInstanceProperty<stripe.Coupon.CouponScriptOutputReference>()!;
        }

        [JsiiProperty(name: "timesRedeemed", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TimesRedeemed
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "valid", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Valid
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "amountOffInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AmountOffInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "appliesToInput", typeJson: "{\"fqn\":\"stripe.coupon.CouponAppliesTo\"}", isOptional: true)]
        public virtual stripe.Coupon.ICouponAppliesTo? AppliesToInput
        {
            get => GetInstanceProperty<stripe.Coupon.ICouponAppliesTo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "currencyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CurrencyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "currencyOptionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.coupon.CouponCurrencyOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CurrencyOptionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "durationInMonthsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DurationInMonthsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "durationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DurationInput
        {
            get => GetInstanceProperty<string?>();
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
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "percentOffInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PercentOffInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "redeemByInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RedeemByInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scriptInput", typeJson: "{\"fqn\":\"stripe.coupon.CouponScript\"}", isOptional: true)]
        public virtual stripe.Coupon.ICouponScript? ScriptInput
        {
            get => GetInstanceProperty<stripe.Coupon.ICouponScript?>();
        }

        [JsiiProperty(name: "amountOff", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AmountOff
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Currency
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Duration
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "durationInMonths", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DurationInMonths
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "percentOff", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PercentOff
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "redeemBy", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RedeemBy
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
