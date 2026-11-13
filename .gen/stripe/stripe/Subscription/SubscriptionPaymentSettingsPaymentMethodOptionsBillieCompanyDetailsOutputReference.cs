using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiClass(nativeType: typeof(stripe.Subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetailsOutputReference), fullyQualifiedName: "stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRegisteredAddress", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetailsRegisteredAddress\"}}]")]
        public virtual void PutRegisteredAddress(stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetailsRegisteredAddress @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetailsRegisteredAddress)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetRegisteredAddress")]
        public virtual void ResetRegisteredAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegisteredName")]
        public virtual void ResetRegisteredName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegistrationNumber")]
        public virtual void ResetRegistrationNumber()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegistrationType")]
        public virtual void ResetRegistrationType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVat")]
        public virtual void ResetVat()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "registeredAddress", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetailsRegisteredAddressOutputReference\"}")]
        public virtual stripe.Subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetailsRegisteredAddressOutputReference RegisteredAddress
        {
            get => GetInstanceProperty<stripe.Subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetailsRegisteredAddressOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetailsRegisteredAddress" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "registeredAddressInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetailsRegisteredAddress\"}]}}", isOptional: true)]
        public virtual object? RegisteredAddressInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "registeredNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegisteredNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "registrationNumberInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegistrationNumberInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "registrationTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegistrationTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vatInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VatInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "registeredName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegisteredName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "registrationNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegistrationNumber
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "registrationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegistrationType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Vat
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetails" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetails\"}]}}", isOptional: true)]
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
                        case stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetails cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetails).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
