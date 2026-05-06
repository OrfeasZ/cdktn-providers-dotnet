using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OspGatewaySubscription
{
    [JsiiClass(nativeType: typeof(oci.OspGatewaySubscription.OspGatewaySubscriptionSubscriptionPaymentOptionsOutputReference), fullyQualifiedName: "oci.ospGatewaySubscription.OspGatewaySubscriptionSubscriptionPaymentOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class OspGatewaySubscriptionSubscriptionPaymentOptionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public OspGatewaySubscriptionSubscriptionPaymentOptionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected OspGatewaySubscriptionSubscriptionPaymentOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OspGatewaySubscriptionSubscriptionPaymentOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCreditCardType")]
        public virtual void ResetCreditCardType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmailAddress")]
        public virtual void ResetEmailAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExtBillingAgreementId")]
        public virtual void ResetExtBillingAgreementId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFirstName")]
        public virtual void ResetFirstName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLastDigits")]
        public virtual void ResetLastDigits()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLastName")]
        public virtual void ResetLastName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNameOnCard")]
        public virtual void ResetNameOnCard()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeExpiration")]
        public virtual void ResetTimeExpiration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWalletInstrumentId")]
        public virtual void ResetWalletInstrumentId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWalletTransactionId")]
        public virtual void ResetWalletTransactionId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "creditCardTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CreditCardTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailAddressInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EmailAddressInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "extBillingAgreementIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExtBillingAgreementIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "firstNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FirstNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lastDigitsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LastDigitsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lastNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LastNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameOnCardInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameOnCardInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "paymentMethodInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PaymentMethodInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeExpirationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeExpirationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "walletInstrumentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WalletInstrumentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "walletTransactionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WalletTransactionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "creditCardType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreditCardType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "emailAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmailAddress
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "extBillingAgreementId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExtBillingAgreementId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "firstName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FirstName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lastDigits", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastDigits
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lastName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nameOnCard", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameOnCard
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "paymentMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PaymentMethod
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeExpiration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeExpiration
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "walletInstrumentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WalletInstrumentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "walletTransactionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WalletTransactionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.ospGatewaySubscription.OspGatewaySubscriptionSubscriptionPaymentOptions\"}]}}", isOptional: true)]
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
                        case oci.OspGatewaySubscription.IOspGatewaySubscriptionSubscriptionPaymentOptions cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.OspGatewaySubscription.IOspGatewaySubscriptionSubscriptionPaymentOptions).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
