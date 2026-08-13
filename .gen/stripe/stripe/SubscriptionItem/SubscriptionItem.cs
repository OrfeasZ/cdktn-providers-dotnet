using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionItem
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_item stripe_subscription_item}.</summary>
    [JsiiClass(nativeType: typeof(stripe.SubscriptionItem.SubscriptionItem), fullyQualifiedName: "stripe.subscriptionItem.SubscriptionItem", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"stripe.subscriptionItem.SubscriptionItemConfig\"}}]")]
    public class SubscriptionItem : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_item stripe_subscription_item} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SubscriptionItem(Constructs.Construct scope, string id, stripe.SubscriptionItem.ISubscriptionItemConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, stripe.SubscriptionItem.ISubscriptionItemConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SubscriptionItem(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SubscriptionItem(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a SubscriptionItem resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the SubscriptionItem to import.</param>
        /// <param name="importFromId">The id of the existing SubscriptionItem that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the SubscriptionItem to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the SubscriptionItem to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_item#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing SubscriptionItem that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the SubscriptionItem to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(stripe.SubscriptionItem.SubscriptionItem), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putBillingThresholds", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.subscriptionItem.SubscriptionItemBillingThresholds\"}}]")]
        public virtual void PutBillingThresholds(stripe.SubscriptionItem.ISubscriptionItemBillingThresholds @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.SubscriptionItem.ISubscriptionItemBillingThresholds)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.SubscriptionItem.ISubscriptionItemDiscounts" />)[]</param>
        [JsiiMethod(name: "putDiscounts", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.subscriptionItem.SubscriptionItemDiscounts\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDiscounts(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case stripe.SubscriptionItem.ISubscriptionItemDiscounts[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.SubscriptionItem.ISubscriptionItemDiscounts).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.SubscriptionItem.ISubscriptionItemDiscounts).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPriceData", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.subscriptionItem.SubscriptionItemPriceData\"}}]")]
        public virtual void PutPriceData(stripe.SubscriptionItem.ISubscriptionItemPriceData @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.SubscriptionItem.ISubscriptionItemPriceData)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBillingThresholds")]
        public virtual void ResetBillingThresholds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDiscounts")]
        public virtual void ResetDiscounts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetadata")]
        public virtual void ResetMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPaymentBehavior")]
        public virtual void ResetPaymentBehavior()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlan")]
        public virtual void ResetPlan()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrice")]
        public virtual void ResetPrice()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPriceData")]
        public virtual void ResetPriceData()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProrationBehavior")]
        public virtual void ResetProrationBehavior()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProrationDate")]
        public virtual void ResetProrationDate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQuantity")]
        public virtual void ResetQuantity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTaxRates")]
        public virtual void ResetTaxRates()
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
        = GetStaticProperty<string>(typeof(stripe.SubscriptionItem.SubscriptionItem))!;

        [JsiiProperty(name: "billedUntil", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BilledUntil
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "billingThresholds", typeJson: "{\"fqn\":\"stripe.subscriptionItem.SubscriptionItemBillingThresholdsOutputReference\"}")]
        public virtual stripe.SubscriptionItem.SubscriptionItemBillingThresholdsOutputReference BillingThresholds
        {
            get => GetInstanceProperty<stripe.SubscriptionItem.SubscriptionItemBillingThresholdsOutputReference>()!;
        }

        [JsiiProperty(name: "created", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Created
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "currentPeriodEnd", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CurrentPeriodEnd
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "currentPeriodStart", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CurrentPeriodStart
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "discounts", typeJson: "{\"fqn\":\"stripe.subscriptionItem.SubscriptionItemDiscountsList\"}")]
        public virtual stripe.SubscriptionItem.SubscriptionItemDiscountsList Discounts
        {
            get => GetInstanceProperty<stripe.SubscriptionItem.SubscriptionItemDiscountsList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Object
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "priceData", typeJson: "{\"fqn\":\"stripe.subscriptionItem.SubscriptionItemPriceDataOutputReference\"}")]
        public virtual stripe.SubscriptionItem.SubscriptionItemPriceDataOutputReference PriceData
        {
            get => GetInstanceProperty<stripe.SubscriptionItem.SubscriptionItemPriceDataOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SubscriptionItem.ISubscriptionItemBillingThresholds" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "billingThresholdsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.subscriptionItem.SubscriptionItemBillingThresholds\"}]}}", isOptional: true)]
        public virtual object? BillingThresholdsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.SubscriptionItem.ISubscriptionItemDiscounts" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "discountsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.subscriptionItem.SubscriptionItemDiscounts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DiscountsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metadataInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? MetadataInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "paymentBehaviorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PaymentBehaviorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "planInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PlanInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SubscriptionItem.ISubscriptionItemPriceData" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "priceDataInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.subscriptionItem.SubscriptionItemPriceData\"}]}}", isOptional: true)]
        public virtual object? PriceDataInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "priceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PriceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "prorationBehaviorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProrationBehaviorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "prorationDateInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ProrationDateInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "quantityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? QuantityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subscriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubscriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taxRatesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? TaxRatesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "paymentBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PaymentBehavior
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "plan", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Plan
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

        [JsiiProperty(name: "prorationBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProrationBehavior
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "prorationDate", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ProrationDate
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "quantity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Quantity
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subscription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Subscription
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "taxRates", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TaxRates
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
