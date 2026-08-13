using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiClass(nativeType: typeof(stripe.SetupIntent.SetupIntentPaymentMethodOptionsKlarnaOutputReference), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodOptionsKlarnaOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SetupIntentPaymentMethodOptionsKlarnaOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SetupIntentPaymentMethodOptionsKlarnaOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SetupIntentPaymentMethodOptionsKlarnaOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SetupIntentPaymentMethodOptionsKlarnaOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putOnDemand", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsKlarnaOnDemand\"}}]")]
        public virtual void PutOnDemand(stripe.SetupIntent.ISetupIntentPaymentMethodOptionsKlarnaOnDemand @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.SetupIntent.ISetupIntentPaymentMethodOptionsKlarnaOnDemand)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.SetupIntent.ISetupIntentPaymentMethodOptionsKlarnaSubscriptions" />)[]</param>
        [JsiiMethod(name: "putSubscriptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsKlarnaSubscriptions\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSubscriptions(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case stripe.SetupIntent.ISetupIntentPaymentMethodOptionsKlarnaSubscriptions[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.SetupIntent.ISetupIntentPaymentMethodOptionsKlarnaSubscriptions).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.SetupIntent.ISetupIntentPaymentMethodOptionsKlarnaSubscriptions).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCurrency")]
        public virtual void ResetCurrency()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOnDemand")]
        public virtual void ResetOnDemand()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPreferredLocale")]
        public virtual void ResetPreferredLocale()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubscriptions")]
        public virtual void ResetSubscriptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "onDemand", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsKlarnaOnDemandOutputReference\"}")]
        public virtual stripe.SetupIntent.SetupIntentPaymentMethodOptionsKlarnaOnDemandOutputReference OnDemand
        {
            get => GetInstanceProperty<stripe.SetupIntent.SetupIntentPaymentMethodOptionsKlarnaOnDemandOutputReference>()!;
        }

        [JsiiProperty(name: "subscriptions", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsKlarnaSubscriptionsList\"}")]
        public virtual stripe.SetupIntent.SetupIntentPaymentMethodOptionsKlarnaSubscriptionsList Subscriptions
        {
            get => GetInstanceProperty<stripe.SetupIntent.SetupIntentPaymentMethodOptionsKlarnaSubscriptionsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "currencyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CurrencyInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SetupIntent.ISetupIntentPaymentMethodOptionsKlarnaOnDemand" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "onDemandInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsKlarnaOnDemand\"}]}}", isOptional: true)]
        public virtual object? OnDemandInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "preferredLocaleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PreferredLocaleInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.SetupIntent.ISetupIntentPaymentMethodOptionsKlarnaSubscriptions" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "subscriptionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsKlarnaSubscriptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SubscriptionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Currency
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "preferredLocale", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreferredLocale
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SetupIntent.ISetupIntentPaymentMethodOptionsKlarna" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsKlarna\"}]}}", isOptional: true)]
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
                        case stripe.SetupIntent.ISetupIntentPaymentMethodOptionsKlarna cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.SetupIntent.ISetupIntentPaymentMethodOptionsKlarna).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
