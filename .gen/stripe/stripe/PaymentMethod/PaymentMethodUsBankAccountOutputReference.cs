using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiClass(nativeType: typeof(stripe.PaymentMethod.PaymentMethodUsBankAccountOutputReference), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodUsBankAccountOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PaymentMethodUsBankAccountOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PaymentMethodUsBankAccountOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PaymentMethodUsBankAccountOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentMethodUsBankAccountOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAccountHolderType")]
        public virtual void ResetAccountHolderType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAccountNumber")]
        public virtual void ResetAccountNumber()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAccountType")]
        public virtual void ResetAccountType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFinancialConnectionsAccount")]
        public virtual void ResetFinancialConnectionsAccount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoutingNumber")]
        public virtual void ResetRoutingNumber()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "bankName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BankName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fingerprint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Fingerprint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "last4", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Last4
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networks", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodUsBankAccountNetworksOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodUsBankAccountNetworksOutputReference Networks
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodUsBankAccountNetworksOutputReference>()!;
        }

        [JsiiProperty(name: "statusDetails", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodUsBankAccountStatusDetailsOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodUsBankAccountStatusDetailsOutputReference StatusDetails
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodUsBankAccountStatusDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountHolderTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountHolderTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountNumberInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountNumberInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "financialConnectionsAccountInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FinancialConnectionsAccountInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routingNumberInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoutingNumberInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "accountHolderType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountHolderType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "accountNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountNumber
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "accountType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "financialConnectionsAccount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FinancialConnectionsAccount
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "routingNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoutingNumber
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethod.IPaymentMethodUsBankAccount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethod.PaymentMethodUsBankAccount\"}]}}", isOptional: true)]
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
                        case stripe.PaymentMethod.IPaymentMethodUsBankAccount cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.PaymentMethod.IPaymentMethodUsBankAccount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
