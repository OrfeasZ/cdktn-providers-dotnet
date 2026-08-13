using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiClass(nativeType: typeof(stripe.Subscription.SubscriptionItemsOutputReference), fullyQualifiedName: "stripe.subscription.SubscriptionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SubscriptionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public SubscriptionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SubscriptionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SubscriptionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBillingThresholds", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.subscription.SubscriptionItemsBillingThresholds\"}}]")]
        public virtual void PutBillingThresholds(stripe.Subscription.ISubscriptionItemsBillingThresholds @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Subscription.ISubscriptionItemsBillingThresholds)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Subscription.ISubscriptionItemsDiscounts" />)[]</param>
        [JsiiMethod(name: "putDiscounts", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.subscription.SubscriptionItemsDiscounts\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDiscounts(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case stripe.Subscription.ISubscriptionItemsDiscounts[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Subscription.ISubscriptionItemsDiscounts).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Subscription.ISubscriptionItemsDiscounts).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPriceData", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.subscription.SubscriptionItemsPriceData\"}}]")]
        public virtual void PutPriceData(stripe.Subscription.ISubscriptionItemsPriceData @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Subscription.ISubscriptionItemsPriceData)}, new object[]{@value});
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

        [JsiiProperty(name: "billingThresholds", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionItemsBillingThresholdsOutputReference\"}")]
        public virtual stripe.Subscription.SubscriptionItemsBillingThresholdsOutputReference BillingThresholds
        {
            get => GetInstanceProperty<stripe.Subscription.SubscriptionItemsBillingThresholdsOutputReference>()!;
        }

        [JsiiProperty(name: "discounts", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionItemsDiscountsList\"}")]
        public virtual stripe.Subscription.SubscriptionItemsDiscountsList Discounts
        {
            get => GetInstanceProperty<stripe.Subscription.SubscriptionItemsDiscountsList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "priceData", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionItemsPriceDataOutputReference\"}")]
        public virtual stripe.Subscription.SubscriptionItemsPriceDataOutputReference PriceData
        {
            get => GetInstanceProperty<stripe.Subscription.SubscriptionItemsPriceDataOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Subscription.ISubscriptionItemsBillingThresholds" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "billingThresholdsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.subscription.SubscriptionItemsBillingThresholds\"}]}}", isOptional: true)]
        public virtual object? BillingThresholdsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Subscription.ISubscriptionItemsDiscounts" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "discountsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.subscription.SubscriptionItemsDiscounts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Subscription.ISubscriptionItemsPriceData" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "priceDataInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.subscription.SubscriptionItemsPriceData\"}]}}", isOptional: true)]
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
        [JsiiProperty(name: "quantityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? QuantityInput
        {
            get => GetInstanceProperty<double?>();
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

        [JsiiProperty(name: "price", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Price
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "quantity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Quantity
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "taxRates", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TaxRates
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Subscription.ISubscriptionItems" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.subscription.SubscriptionItems\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case stripe.Subscription.ISubscriptionItems cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Subscription.ISubscriptionItems).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
