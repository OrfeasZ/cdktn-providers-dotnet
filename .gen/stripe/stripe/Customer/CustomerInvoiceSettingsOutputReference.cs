using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Customer
{
    [JsiiClass(nativeType: typeof(stripe.Customer.CustomerInvoiceSettingsOutputReference), fullyQualifiedName: "stripe.customer.CustomerInvoiceSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CustomerInvoiceSettingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CustomerInvoiceSettingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CustomerInvoiceSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CustomerInvoiceSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRenderingOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.customer.CustomerInvoiceSettingsRenderingOptions\"}}]")]
        public virtual void PutRenderingOptions(stripe.Customer.ICustomerInvoiceSettingsRenderingOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Customer.ICustomerInvoiceSettingsRenderingOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCustomFields")]
        public virtual void ResetCustomFields()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultPaymentMethod")]
        public virtual void ResetDefaultPaymentMethod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFooter")]
        public virtual void ResetFooter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRenderingOptions")]
        public virtual void ResetRenderingOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "renderingOptions", typeJson: "{\"fqn\":\"stripe.customer.CustomerInvoiceSettingsRenderingOptionsOutputReference\"}")]
        public virtual stripe.Customer.CustomerInvoiceSettingsRenderingOptionsOutputReference RenderingOptions
        {
            get => GetInstanceProperty<stripe.Customer.CustomerInvoiceSettingsRenderingOptionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "customFieldsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CustomFieldsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultPaymentMethodInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultPaymentMethodInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "footerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FooterInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "renderingOptionsInput", typeJson: "{\"fqn\":\"stripe.customer.CustomerInvoiceSettingsRenderingOptions\"}", isOptional: true)]
        public virtual stripe.Customer.ICustomerInvoiceSettingsRenderingOptions? RenderingOptionsInput
        {
            get => GetInstanceProperty<stripe.Customer.ICustomerInvoiceSettingsRenderingOptions?>();
        }

        [JsiiProperty(name: "customFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"array\"}}]}}")]
        public virtual object CustomFields
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case string[][] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, string[][]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, string[][]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "defaultPaymentMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultPaymentMethod
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "footer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Footer
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.customer.CustomerInvoiceSettings\"}", isOptional: true)]
        public virtual stripe.Customer.ICustomerInvoiceSettings? InternalValue
        {
            get => GetInstanceProperty<stripe.Customer.ICustomerInvoiceSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
