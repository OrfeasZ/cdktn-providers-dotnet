using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.SelfSubscription
{
    [JsiiClass(nativeType: typeof(oci.SelfSubscription.SelfSubscriptionSubscriptionDetailsOutputReference), fullyQualifiedName: "oci.selfSubscription.SelfSubscriptionSubscriptionDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SelfSubscriptionSubscriptionDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SelfSubscriptionSubscriptionDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SelfSubscriptionSubscriptionDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SelfSubscriptionSubscriptionDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBillingDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.selfSubscription.SelfSubscriptionSubscriptionDetailsBillingDetails\"}}]")]
        public virtual void PutBillingDetails(oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsBillingDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsBillingDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPricingPlan", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.selfSubscription.SelfSubscriptionSubscriptionDetailsPricingPlan\"}}]")]
        public virtual void PutPricingPlan(oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsPricingPlan @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsPricingPlan)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAmount")]
        public virtual void ResetAmount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCurrency")]
        public virtual void ResetCurrency()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsAutoRenew")]
        public virtual void ResetIsAutoRenew()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "billingDetails", typeJson: "{\"fqn\":\"oci.selfSubscription.SelfSubscriptionSubscriptionDetailsBillingDetailsOutputReference\"}")]
        public virtual oci.SelfSubscription.SelfSubscriptionSubscriptionDetailsBillingDetailsOutputReference BillingDetails
        {
            get => GetInstanceProperty<oci.SelfSubscription.SelfSubscriptionSubscriptionDetailsBillingDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "pricingPlan", typeJson: "{\"fqn\":\"oci.selfSubscription.SelfSubscriptionSubscriptionDetailsPricingPlanOutputReference\"}")]
        public virtual oci.SelfSubscription.SelfSubscriptionSubscriptionDetailsPricingPlanOutputReference PricingPlan
        {
            get => GetInstanceProperty<oci.SelfSubscription.SelfSubscriptionSubscriptionDetailsPricingPlanOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "amountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AmountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "billingDetailsInput", typeJson: "{\"fqn\":\"oci.selfSubscription.SelfSubscriptionSubscriptionDetailsBillingDetails\"}", isOptional: true)]
        public virtual oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsBillingDetails? BillingDetailsInput
        {
            get => GetInstanceProperty<oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsBillingDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "currencyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CurrencyInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isAutoRenewInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsAutoRenewInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "partnerRegistrationUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PartnerRegistrationUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pricingPlanInput", typeJson: "{\"fqn\":\"oci.selfSubscription.SelfSubscriptionSubscriptionDetailsPricingPlan\"}", isOptional: true)]
        public virtual oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsPricingPlan? PricingPlanInput
        {
            get => GetInstanceProperty<oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsPricingPlan?>();
        }

        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Amount
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

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isAutoRenew", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsAutoRenew
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

        [JsiiProperty(name: "partnerRegistrationUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PartnerRegistrationUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.selfSubscription.SelfSubscriptionSubscriptionDetails\"}", isOptional: true)]
        public virtual oci.SelfSubscription.ISelfSubscriptionSubscriptionDetails? InternalValue
        {
            get => GetInstanceProperty<oci.SelfSubscription.ISelfSubscriptionSubscriptionDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
