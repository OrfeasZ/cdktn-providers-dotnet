using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiClass(nativeType: typeof(stripe.Invoice.InvoicePaymentSettingsPaymentMethodOptionsOutputReference), fullyQualifiedName: "stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class InvoicePaymentSettingsPaymentMethodOptionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public InvoicePaymentSettingsPaymentMethodOptionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected InvoicePaymentSettingsPaymentMethodOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected InvoicePaymentSettingsPaymentMethodOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAcssDebit", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsAcssDebit\"}}]")]
        public virtual void PutAcssDebit(stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsAcssDebit @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsAcssDebit)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBancontact", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsBancontact\"}}]")]
        public virtual void PutBancontact(stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsBancontact @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsBancontact)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCard", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsCard\"}}]")]
        public virtual void PutCard(stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsCard @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsCard)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCustomerBalance", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsCustomerBalance\"}}]")]
        public virtual void PutCustomerBalance(stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsCustomerBalance @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsCustomerBalance)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPayto", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsPayto\"}}]")]
        public virtual void PutPayto(stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsPayto @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsPayto)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPix", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsPix\"}}]")]
        public virtual void PutPix(stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsPix @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsPix)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUpi", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsUpi\"}}]")]
        public virtual void PutUpi(stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsUpi @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsUpi)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUsBankAccount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsUsBankAccount\"}}]")]
        public virtual void PutUsBankAccount(stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsUsBankAccount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsUsBankAccount)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAcssDebit")]
        public virtual void ResetAcssDebit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBancontact")]
        public virtual void ResetBancontact()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCard")]
        public virtual void ResetCard()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomerBalance")]
        public virtual void ResetCustomerBalance()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPayto")]
        public virtual void ResetPayto()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPix")]
        public virtual void ResetPix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUpi")]
        public virtual void ResetUpi()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUsBankAccount")]
        public virtual void ResetUsBankAccount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "acssDebit", typeJson: "{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsAcssDebitOutputReference\"}")]
        public virtual stripe.Invoice.InvoicePaymentSettingsPaymentMethodOptionsAcssDebitOutputReference AcssDebit
        {
            get => GetInstanceProperty<stripe.Invoice.InvoicePaymentSettingsPaymentMethodOptionsAcssDebitOutputReference>()!;
        }

        [JsiiProperty(name: "bancontact", typeJson: "{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsBancontactOutputReference\"}")]
        public virtual stripe.Invoice.InvoicePaymentSettingsPaymentMethodOptionsBancontactOutputReference Bancontact
        {
            get => GetInstanceProperty<stripe.Invoice.InvoicePaymentSettingsPaymentMethodOptionsBancontactOutputReference>()!;
        }

        [JsiiProperty(name: "card", typeJson: "{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsCardOutputReference\"}")]
        public virtual stripe.Invoice.InvoicePaymentSettingsPaymentMethodOptionsCardOutputReference Card
        {
            get => GetInstanceProperty<stripe.Invoice.InvoicePaymentSettingsPaymentMethodOptionsCardOutputReference>()!;
        }

        [JsiiProperty(name: "customerBalance", typeJson: "{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsCustomerBalanceOutputReference\"}")]
        public virtual stripe.Invoice.InvoicePaymentSettingsPaymentMethodOptionsCustomerBalanceOutputReference CustomerBalance
        {
            get => GetInstanceProperty<stripe.Invoice.InvoicePaymentSettingsPaymentMethodOptionsCustomerBalanceOutputReference>()!;
        }

        [JsiiProperty(name: "payto", typeJson: "{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsPaytoOutputReference\"}")]
        public virtual stripe.Invoice.InvoicePaymentSettingsPaymentMethodOptionsPaytoOutputReference Payto
        {
            get => GetInstanceProperty<stripe.Invoice.InvoicePaymentSettingsPaymentMethodOptionsPaytoOutputReference>()!;
        }

        [JsiiProperty(name: "pix", typeJson: "{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsPixOutputReference\"}")]
        public virtual stripe.Invoice.InvoicePaymentSettingsPaymentMethodOptionsPixOutputReference Pix
        {
            get => GetInstanceProperty<stripe.Invoice.InvoicePaymentSettingsPaymentMethodOptionsPixOutputReference>()!;
        }

        [JsiiProperty(name: "upi", typeJson: "{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsUpiOutputReference\"}")]
        public virtual stripe.Invoice.InvoicePaymentSettingsPaymentMethodOptionsUpiOutputReference Upi
        {
            get => GetInstanceProperty<stripe.Invoice.InvoicePaymentSettingsPaymentMethodOptionsUpiOutputReference>()!;
        }

        [JsiiProperty(name: "usBankAccount", typeJson: "{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsUsBankAccountOutputReference\"}")]
        public virtual stripe.Invoice.InvoicePaymentSettingsPaymentMethodOptionsUsBankAccountOutputReference UsBankAccount
        {
            get => GetInstanceProperty<stripe.Invoice.InvoicePaymentSettingsPaymentMethodOptionsUsBankAccountOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsAcssDebit" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acssDebitInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsAcssDebit\"}]}}", isOptional: true)]
        public virtual object? AcssDebitInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsBancontact" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bancontactInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsBancontact\"}]}}", isOptional: true)]
        public virtual object? BancontactInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsCard" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cardInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsCard\"}]}}", isOptional: true)]
        public virtual object? CardInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsCustomerBalance" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customerBalanceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsCustomerBalance\"}]}}", isOptional: true)]
        public virtual object? CustomerBalanceInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsPayto" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paytoInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsPayto\"}]}}", isOptional: true)]
        public virtual object? PaytoInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsPix" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pixInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsPix\"}]}}", isOptional: true)]
        public virtual object? PixInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsUpi" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "upiInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsUpi\"}]}}", isOptional: true)]
        public virtual object? UpiInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsUsBankAccount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "usBankAccountInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsUsBankAccount\"}]}}", isOptional: true)]
        public virtual object? UsBankAccountInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptions" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptions\"}]}}", isOptional: true)]
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
                        case stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptions cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptions).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
