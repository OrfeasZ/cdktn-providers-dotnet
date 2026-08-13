using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiClass(nativeType: typeof(stripe.Invoice.InvoicePaymentSettingsPaymentMethodOptionsUpiOutputReference), fullyQualifiedName: "stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsUpiOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class InvoicePaymentSettingsPaymentMethodOptionsUpiOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public InvoicePaymentSettingsPaymentMethodOptionsUpiOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected InvoicePaymentSettingsPaymentMethodOptionsUpiOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected InvoicePaymentSettingsPaymentMethodOptionsUpiOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putMandateOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsUpiMandateOptions\"}}]")]
        public virtual void PutMandateOptions(stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsUpiMandateOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsUpiMandateOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMandateOptions")]
        public virtual void ResetMandateOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "mandateOptions", typeJson: "{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsUpiMandateOptionsOutputReference\"}")]
        public virtual stripe.Invoice.InvoicePaymentSettingsPaymentMethodOptionsUpiMandateOptionsOutputReference MandateOptions
        {
            get => GetInstanceProperty<stripe.Invoice.InvoicePaymentSettingsPaymentMethodOptionsUpiMandateOptionsOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsUpiMandateOptions" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mandateOptionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsUpiMandateOptions\"}]}}", isOptional: true)]
        public virtual object? MandateOptionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsUpi" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsUpi\"}]}}", isOptional: true)]
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
                        case stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsUpi cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsUpi).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
