using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Customer
{
    [JsiiClass(nativeType: typeof(stripe.Customer.CustomerInvoiceSettingsRenderingOptionsOutputReference), fullyQualifiedName: "stripe.customer.CustomerInvoiceSettingsRenderingOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CustomerInvoiceSettingsRenderingOptionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CustomerInvoiceSettingsRenderingOptionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CustomerInvoiceSettingsRenderingOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CustomerInvoiceSettingsRenderingOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAmountTaxDisplay")]
        public virtual void ResetAmountTaxDisplay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTemplate")]
        public virtual void ResetTemplate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "amountTaxDisplayInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AmountTaxDisplayInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "templateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TemplateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "amountTaxDisplay", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AmountTaxDisplay
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "template", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Template
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.customer.CustomerInvoiceSettingsRenderingOptions\"}", isOptional: true)]
        public virtual stripe.Customer.ICustomerInvoiceSettingsRenderingOptions? InternalValue
        {
            get => GetInstanceProperty<stripe.Customer.ICustomerInvoiceSettingsRenderingOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
