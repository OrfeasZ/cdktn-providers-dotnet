using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiClass(nativeType: typeof(stripe.PaymentMethod.PaymentMethodCardOutputReference), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodCardOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PaymentMethodCardOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PaymentMethodCardOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PaymentMethodCardOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentMethodCardOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putNetworks", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethod.PaymentMethodCardNetworks\"}}]")]
        public virtual void PutNetworks(stripe.PaymentMethod.IPaymentMethodCardNetworks @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethod.IPaymentMethodCardNetworks)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCvc")]
        public virtual void ResetCvc()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExpMonth")]
        public virtual void ResetExpMonth()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExpYear")]
        public virtual void ResetExpYear()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworks")]
        public virtual void ResetNetworks()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNumber")]
        public virtual void ResetNumber()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetToken")]
        public virtual void ResetToken()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "brand", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Brand
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "checks", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodCardChecksOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodCardChecksOutputReference Checks
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodCardChecksOutputReference>()!;
        }

        [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Country
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayBrand", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayBrand
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fingerprint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Fingerprint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "funding", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Funding
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "generatedFrom", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodCardGeneratedFromOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodCardGeneratedFromOutputReference GeneratedFrom
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodCardGeneratedFromOutputReference>()!;
        }

        [JsiiProperty(name: "iin", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Iin
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Issuer
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "last4", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Last4
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networks", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodCardNetworksOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodCardNetworksOutputReference Networks
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodCardNetworksOutputReference>()!;
        }

        [JsiiProperty(name: "regulatedStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegulatedStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "threeDSecureUsage", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodCardThreeDSecureUsageOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodCardThreeDSecureUsageOutputReference ThreeDSecureUsage
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodCardThreeDSecureUsageOutputReference>()!;
        }

        [JsiiProperty(name: "wallet", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodCardWalletOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodCardWalletOutputReference Wallet
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodCardWalletOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cvcInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CvcInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "expMonthInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ExpMonthInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "expYearInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ExpYearInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethod.IPaymentMethodCardNetworks" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networksInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethod.PaymentMethodCardNetworks\"}]}}", isOptional: true)]
        public virtual object? NetworksInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "numberInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NumberInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tokenInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TokenInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "cvc", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Cvc
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "expMonth", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ExpMonth
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "expYear", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ExpYear
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "number", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Number
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Token
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethod.IPaymentMethodCard" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethod.PaymentMethodCard\"}]}}", isOptional: true)]
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
                        case stripe.PaymentMethod.IPaymentMethodCard cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.PaymentMethod.IPaymentMethodCard).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
