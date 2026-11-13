using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiClass(nativeType: typeof(stripe.Invoice.InvoicePaymentSettingsPaymentMethodOptionsBillieOutputReference), fullyQualifiedName: "stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsBillieOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class InvoicePaymentSettingsPaymentMethodOptionsBillieOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public InvoicePaymentSettingsPaymentMethodOptionsBillieOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected InvoicePaymentSettingsPaymentMethodOptionsBillieOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected InvoicePaymentSettingsPaymentMethodOptionsBillieOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCompanyDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsBillieCompanyDetails\"}}]")]
        public virtual void PutCompanyDetails(stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsBillieCompanyDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsBillieCompanyDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCompanyDetails")]
        public virtual void ResetCompanyDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReference")]
        public virtual void ResetReference()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "companyDetails", typeJson: "{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsBillieCompanyDetailsOutputReference\"}")]
        public virtual stripe.Invoice.InvoicePaymentSettingsPaymentMethodOptionsBillieCompanyDetailsOutputReference CompanyDetails
        {
            get => GetInstanceProperty<stripe.Invoice.InvoicePaymentSettingsPaymentMethodOptionsBillieCompanyDetailsOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsBillieCompanyDetails" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "companyDetailsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsBillieCompanyDetails\"}]}}", isOptional: true)]
        public virtual object? CompanyDetailsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "referenceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReferenceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "reference", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Reference
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsBillie" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsBillie\"}]}}", isOptional: true)]
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
                        case stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsBillie cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsBillie).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
