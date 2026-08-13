using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiClass(nativeType: typeof(stripe.Invoice.InvoicePaymentSettingsPaymentMethodOptionsCustomerBalanceOutputReference), fullyQualifiedName: "stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsCustomerBalanceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class InvoicePaymentSettingsPaymentMethodOptionsCustomerBalanceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public InvoicePaymentSettingsPaymentMethodOptionsCustomerBalanceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected InvoicePaymentSettingsPaymentMethodOptionsCustomerBalanceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected InvoicePaymentSettingsPaymentMethodOptionsCustomerBalanceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBankTransfer", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransfer\"}}]")]
        public virtual void PutBankTransfer(stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransfer @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransfer)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBankTransfer")]
        public virtual void ResetBankTransfer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFundingType")]
        public virtual void ResetFundingType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "bankTransfer", typeJson: "{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransferOutputReference\"}")]
        public virtual stripe.Invoice.InvoicePaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransferOutputReference BankTransfer
        {
            get => GetInstanceProperty<stripe.Invoice.InvoicePaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransferOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransfer" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bankTransferInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransfer\"}]}}", isOptional: true)]
        public virtual object? BankTransferInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fundingTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FundingTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "fundingType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FundingType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsCustomerBalance" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsCustomerBalance\"}]}}", isOptional: true)]
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
                        case stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsCustomerBalance cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsCustomerBalance).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
