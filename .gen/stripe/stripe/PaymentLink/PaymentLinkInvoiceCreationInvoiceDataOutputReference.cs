using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiClass(nativeType: typeof(stripe.PaymentLink.PaymentLinkInvoiceCreationInvoiceDataOutputReference), fullyQualifiedName: "stripe.paymentLink.PaymentLinkInvoiceCreationInvoiceDataOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PaymentLinkInvoiceCreationInvoiceDataOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PaymentLinkInvoiceCreationInvoiceDataOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PaymentLinkInvoiceCreationInvoiceDataOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentLinkInvoiceCreationInvoiceDataOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.PaymentLink.IPaymentLinkInvoiceCreationInvoiceDataCustomFields" />)[]</param>
        [JsiiMethod(name: "putCustomFields", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.paymentLink.PaymentLinkInvoiceCreationInvoiceDataCustomFields\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCustomFields(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case stripe.PaymentLink.IPaymentLinkInvoiceCreationInvoiceDataCustomFields[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.PaymentLink.IPaymentLinkInvoiceCreationInvoiceDataCustomFields).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.PaymentLink.IPaymentLinkInvoiceCreationInvoiceDataCustomFields).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIssuer", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentLink.PaymentLinkInvoiceCreationInvoiceDataIssuer\"}}]")]
        public virtual void PutIssuer(stripe.PaymentLink.IPaymentLinkInvoiceCreationInvoiceDataIssuer @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentLink.IPaymentLinkInvoiceCreationInvoiceDataIssuer)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRenderingOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentLink.PaymentLinkInvoiceCreationInvoiceDataRenderingOptions\"}}]")]
        public virtual void PutRenderingOptions(stripe.PaymentLink.IPaymentLinkInvoiceCreationInvoiceDataRenderingOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentLink.IPaymentLinkInvoiceCreationInvoiceDataRenderingOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccountTaxIds")]
        public virtual void ResetAccountTaxIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomFields")]
        public virtual void ResetCustomFields()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFooter")]
        public virtual void ResetFooter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIssuer")]
        public virtual void ResetIssuer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetadata")]
        public virtual void ResetMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRenderingOptions")]
        public virtual void ResetRenderingOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "customFields", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkInvoiceCreationInvoiceDataCustomFieldsList\"}")]
        public virtual stripe.PaymentLink.PaymentLinkInvoiceCreationInvoiceDataCustomFieldsList CustomFields
        {
            get => GetInstanceProperty<stripe.PaymentLink.PaymentLinkInvoiceCreationInvoiceDataCustomFieldsList>()!;
        }

        [JsiiProperty(name: "issuer", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkInvoiceCreationInvoiceDataIssuerOutputReference\"}")]
        public virtual stripe.PaymentLink.PaymentLinkInvoiceCreationInvoiceDataIssuerOutputReference Issuer
        {
            get => GetInstanceProperty<stripe.PaymentLink.PaymentLinkInvoiceCreationInvoiceDataIssuerOutputReference>()!;
        }

        [JsiiProperty(name: "renderingOptions", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkInvoiceCreationInvoiceDataRenderingOptionsOutputReference\"}")]
        public virtual stripe.PaymentLink.PaymentLinkInvoiceCreationInvoiceDataRenderingOptionsOutputReference RenderingOptions
        {
            get => GetInstanceProperty<stripe.PaymentLink.PaymentLinkInvoiceCreationInvoiceDataRenderingOptionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountTaxIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AccountTaxIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.PaymentLink.IPaymentLinkInvoiceCreationInvoiceDataCustomFields" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customFieldsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.paymentLink.PaymentLinkInvoiceCreationInvoiceDataCustomFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CustomFieldsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "footerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FooterInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentLink.IPaymentLinkInvoiceCreationInvoiceDataIssuer" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "issuerInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentLink.PaymentLinkInvoiceCreationInvoiceDataIssuer\"}]}}", isOptional: true)]
        public virtual object? IssuerInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metadataInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? MetadataInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentLink.IPaymentLinkInvoiceCreationInvoiceDataRenderingOptions" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "renderingOptionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentLink.PaymentLinkInvoiceCreationInvoiceDataRenderingOptions\"}]}}", isOptional: true)]
        public virtual object? RenderingOptionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "accountTaxIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AccountTaxIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
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

        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentLink.IPaymentLinkInvoiceCreationInvoiceData" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentLink.PaymentLinkInvoiceCreationInvoiceData\"}]}}", isOptional: true)]
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
                        case stripe.PaymentLink.IPaymentLinkInvoiceCreationInvoiceData cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.PaymentLink.IPaymentLinkInvoiceCreationInvoiceData).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
