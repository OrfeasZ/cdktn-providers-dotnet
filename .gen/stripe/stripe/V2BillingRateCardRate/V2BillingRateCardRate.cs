using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2BillingRateCardRate
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_rate_card_rate stripe_v2_billing_rate_card_rate}.</summary>
    [JsiiClass(nativeType: typeof(stripe.V2BillingRateCardRate.V2BillingRateCardRate), fullyQualifiedName: "stripe.v2BillingRateCardRate.V2BillingRateCardRate", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"stripe.v2BillingRateCardRate.V2BillingRateCardRateConfig\"}}]")]
    public class V2BillingRateCardRate : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_rate_card_rate stripe_v2_billing_rate_card_rate} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public V2BillingRateCardRate(Constructs.Construct scope, string id, stripe.V2BillingRateCardRate.IV2BillingRateCardRateConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, stripe.V2BillingRateCardRate.IV2BillingRateCardRateConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected V2BillingRateCardRate(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected V2BillingRateCardRate(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a V2BillingRateCardRate resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the V2BillingRateCardRate to import.</param>
        /// <param name="importFromId">The id of the existing V2BillingRateCardRate that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the V2BillingRateCardRate to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the V2BillingRateCardRate to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_rate_card_rate#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing V2BillingRateCardRate that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the V2BillingRateCardRate to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(stripe.V2BillingRateCardRate.V2BillingRateCardRate), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTiers", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.v2BillingRateCardRate.V2BillingRateCardRateTiers\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTiers(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case stripe.V2BillingRateCardRate.IV2BillingRateCardRateTiers[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.V2BillingRateCardRate.IV2BillingRateCardRateTiers).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.V2BillingRateCardRate.IV2BillingRateCardRateTiers).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMetadata")]
        public virtual void ResetMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTieringMode")]
        public virtual void ResetTieringMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTiers")]
        public virtual void ResetTiers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUnitAmount")]
        public virtual void ResetUnitAmount()
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
        = GetStaticProperty<string>(typeof(stripe.V2BillingRateCardRate.V2BillingRateCardRate))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rateCard", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RateCard
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rateCardVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RateCardVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tiers", typeJson: "{\"fqn\":\"stripe.v2BillingRateCardRate.V2BillingRateCardRateTiersList\"}")]
        public virtual stripe.V2BillingRateCardRate.V2BillingRateCardRateTiersList Tiers
        {
            get => GetInstanceProperty<stripe.V2BillingRateCardRate.V2BillingRateCardRateTiersList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "metadataInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? MetadataInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "meteredItemInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MeteredItemInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rateCardIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RateCardIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tieringModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TieringModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tiersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.v2BillingRateCardRate.V2BillingRateCardRateTiers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TiersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "unitAmountInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UnitAmountInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "meteredItem", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MeteredItem
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rateCardId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RateCardId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tieringMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TieringMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "unitAmount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UnitAmount
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
