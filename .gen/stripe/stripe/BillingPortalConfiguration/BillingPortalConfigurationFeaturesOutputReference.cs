using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingPortalConfiguration
{
    [JsiiClass(nativeType: typeof(stripe.BillingPortalConfiguration.BillingPortalConfigurationFeaturesOutputReference), fullyQualifiedName: "stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class BillingPortalConfigurationFeaturesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public BillingPortalConfigurationFeaturesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected BillingPortalConfigurationFeaturesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BillingPortalConfigurationFeaturesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCustomerUpdate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesCustomerUpdate\"}}]")]
        public virtual void PutCustomerUpdate(stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesCustomerUpdate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesCustomerUpdate)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInvoiceHistory", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesInvoiceHistory\"}}]")]
        public virtual void PutInvoiceHistory(stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesInvoiceHistory @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesInvoiceHistory)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPaymentMethodUpdate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesPaymentMethodUpdate\"}}]")]
        public virtual void PutPaymentMethodUpdate(stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesPaymentMethodUpdate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesPaymentMethodUpdate)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSubscriptionCancel", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionCancel\"}}]")]
        public virtual void PutSubscriptionCancel(stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionCancel @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionCancel)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSubscriptionUpdate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionUpdate\"}}]")]
        public virtual void PutSubscriptionUpdate(stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionUpdate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionUpdate)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCustomerUpdate")]
        public virtual void ResetCustomerUpdate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInvoiceHistory")]
        public virtual void ResetInvoiceHistory()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPaymentMethodUpdate")]
        public virtual void ResetPaymentMethodUpdate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubscriptionCancel")]
        public virtual void ResetSubscriptionCancel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubscriptionUpdate")]
        public virtual void ResetSubscriptionUpdate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "customerUpdate", typeJson: "{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesCustomerUpdateOutputReference\"}")]
        public virtual stripe.BillingPortalConfiguration.BillingPortalConfigurationFeaturesCustomerUpdateOutputReference CustomerUpdate
        {
            get => GetInstanceProperty<stripe.BillingPortalConfiguration.BillingPortalConfigurationFeaturesCustomerUpdateOutputReference>()!;
        }

        [JsiiProperty(name: "invoiceHistory", typeJson: "{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesInvoiceHistoryOutputReference\"}")]
        public virtual stripe.BillingPortalConfiguration.BillingPortalConfigurationFeaturesInvoiceHistoryOutputReference InvoiceHistory
        {
            get => GetInstanceProperty<stripe.BillingPortalConfiguration.BillingPortalConfigurationFeaturesInvoiceHistoryOutputReference>()!;
        }

        [JsiiProperty(name: "paymentMethodUpdate", typeJson: "{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesPaymentMethodUpdateOutputReference\"}")]
        public virtual stripe.BillingPortalConfiguration.BillingPortalConfigurationFeaturesPaymentMethodUpdateOutputReference PaymentMethodUpdate
        {
            get => GetInstanceProperty<stripe.BillingPortalConfiguration.BillingPortalConfigurationFeaturesPaymentMethodUpdateOutputReference>()!;
        }

        [JsiiProperty(name: "subscriptionCancel", typeJson: "{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionCancelOutputReference\"}")]
        public virtual stripe.BillingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionCancelOutputReference SubscriptionCancel
        {
            get => GetInstanceProperty<stripe.BillingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionCancelOutputReference>()!;
        }

        [JsiiProperty(name: "subscriptionUpdate", typeJson: "{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionUpdateOutputReference\"}")]
        public virtual stripe.BillingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionUpdateOutputReference SubscriptionUpdate
        {
            get => GetInstanceProperty<stripe.BillingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionUpdateOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesCustomerUpdate" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customerUpdateInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesCustomerUpdate\"}]}}", isOptional: true)]
        public virtual object? CustomerUpdateInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesInvoiceHistory" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "invoiceHistoryInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesInvoiceHistory\"}]}}", isOptional: true)]
        public virtual object? InvoiceHistoryInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesPaymentMethodUpdate" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paymentMethodUpdateInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesPaymentMethodUpdate\"}]}}", isOptional: true)]
        public virtual object? PaymentMethodUpdateInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionCancel" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "subscriptionCancelInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionCancel\"}]}}", isOptional: true)]
        public virtual object? SubscriptionCancelInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionUpdate" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "subscriptionUpdateInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionUpdate\"}]}}", isOptional: true)]
        public virtual object? SubscriptionUpdateInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeatures" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeatures\"}]}}", isOptional: true)]
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
                        case stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeatures cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeatures).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
