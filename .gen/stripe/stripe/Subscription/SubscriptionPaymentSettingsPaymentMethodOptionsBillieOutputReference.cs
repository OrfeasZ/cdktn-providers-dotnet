using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiClass(nativeType: typeof(stripe.Subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBillieOutputReference), fullyQualifiedName: "stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBillieOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SubscriptionPaymentSettingsPaymentMethodOptionsBillieOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SubscriptionPaymentSettingsPaymentMethodOptionsBillieOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SubscriptionPaymentSettingsPaymentMethodOptionsBillieOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SubscriptionPaymentSettingsPaymentMethodOptionsBillieOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCompanyDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetails\"}}]")]
        public virtual void PutCompanyDetails(stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCompanyDetails")]
        public virtual void ResetCompanyDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "companyDetails", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetailsOutputReference\"}")]
        public virtual stripe.Subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetailsOutputReference CompanyDetails
        {
            get => GetInstanceProperty<stripe.Subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetailsOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetails" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "companyDetailsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetails\"}]}}", isOptional: true)]
        public virtual object? CompanyDetailsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsBillie" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBillie\"}]}}", isOptional: true)]
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
                        case stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsBillie cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsBillie).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
