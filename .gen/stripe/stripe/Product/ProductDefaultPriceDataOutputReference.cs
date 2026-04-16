using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Product
{
    [JsiiClass(nativeType: typeof(stripe.Product.ProductDefaultPriceDataOutputReference), fullyQualifiedName: "stripe.product.ProductDefaultPriceDataOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ProductDefaultPriceDataOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ProductDefaultPriceDataOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ProductDefaultPriceDataOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ProductDefaultPriceDataOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCurrencyOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.product.ProductDefaultPriceDataCurrencyOptions\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCurrencyOptions(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case stripe.Product.IProductDefaultPriceDataCurrencyOptions[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Product.IProductDefaultPriceDataCurrencyOptions).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Product.IProductDefaultPriceDataCurrencyOptions).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCustomUnitAmount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.product.ProductDefaultPriceDataCustomUnitAmount\"}}]")]
        public virtual void PutCustomUnitAmount(stripe.Product.IProductDefaultPriceDataCustomUnitAmount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Product.IProductDefaultPriceDataCustomUnitAmount)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRecurring", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.product.ProductDefaultPriceDataRecurring\"}}]")]
        public virtual void PutRecurring(stripe.Product.IProductDefaultPriceDataRecurring @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Product.IProductDefaultPriceDataRecurring)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCurrencyOptions")]
        public virtual void ResetCurrencyOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomUnitAmount")]
        public virtual void ResetCustomUnitAmount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetadata")]
        public virtual void ResetMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRecurring")]
        public virtual void ResetRecurring()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTaxBehavior")]
        public virtual void ResetTaxBehavior()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUnitAmount")]
        public virtual void ResetUnitAmount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUnitAmountDecimal")]
        public virtual void ResetUnitAmountDecimal()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "currencyOptions", typeJson: "{\"fqn\":\"stripe.product.ProductDefaultPriceDataCurrencyOptionsList\"}")]
        public virtual stripe.Product.ProductDefaultPriceDataCurrencyOptionsList CurrencyOptions
        {
            get => GetInstanceProperty<stripe.Product.ProductDefaultPriceDataCurrencyOptionsList>()!;
        }

        [JsiiProperty(name: "customUnitAmount", typeJson: "{\"fqn\":\"stripe.product.ProductDefaultPriceDataCustomUnitAmountOutputReference\"}")]
        public virtual stripe.Product.ProductDefaultPriceDataCustomUnitAmountOutputReference CustomUnitAmount
        {
            get => GetInstanceProperty<stripe.Product.ProductDefaultPriceDataCustomUnitAmountOutputReference>()!;
        }

        [JsiiProperty(name: "recurring", typeJson: "{\"fqn\":\"stripe.product.ProductDefaultPriceDataRecurringOutputReference\"}")]
        public virtual stripe.Product.ProductDefaultPriceDataRecurringOutputReference Recurring
        {
            get => GetInstanceProperty<stripe.Product.ProductDefaultPriceDataRecurringOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "currencyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CurrencyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "currencyOptionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.product.ProductDefaultPriceDataCurrencyOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CurrencyOptionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customUnitAmountInput", typeJson: "{\"fqn\":\"stripe.product.ProductDefaultPriceDataCustomUnitAmount\"}", isOptional: true)]
        public virtual stripe.Product.IProductDefaultPriceDataCustomUnitAmount? CustomUnitAmountInput
        {
            get => GetInstanceProperty<stripe.Product.IProductDefaultPriceDataCustomUnitAmount?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metadataInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? MetadataInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "recurringInput", typeJson: "{\"fqn\":\"stripe.product.ProductDefaultPriceDataRecurring\"}", isOptional: true)]
        public virtual stripe.Product.IProductDefaultPriceDataRecurring? RecurringInput
        {
            get => GetInstanceProperty<stripe.Product.IProductDefaultPriceDataRecurring?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taxBehaviorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TaxBehaviorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "unitAmountDecimalInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UnitAmountDecimalInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "unitAmountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? UnitAmountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Currency
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "taxBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaxBehavior
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "unitAmount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UnitAmount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "unitAmountDecimal", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UnitAmountDecimal
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.product.ProductDefaultPriceData\"}", isOptional: true)]
        public virtual stripe.Product.IProductDefaultPriceData? InternalValue
        {
            get => GetInstanceProperty<stripe.Product.IProductDefaultPriceData?>();
            set => SetInstanceProperty(value);
        }
    }
}
