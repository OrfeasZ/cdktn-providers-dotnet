using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link stripe_payment_link}.</summary>
    [JsiiClass(nativeType: typeof(stripe.PaymentLink.PaymentLink), fullyQualifiedName: "stripe.paymentLink.PaymentLink", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"stripe.paymentLink.PaymentLinkConfig\"}}]")]
    public class PaymentLink : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link stripe_payment_link} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public PaymentLink(Constructs.Construct scope, string id, stripe.PaymentLink.IPaymentLinkConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, stripe.PaymentLink.IPaymentLinkConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentLink(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentLink(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a PaymentLink resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the PaymentLink to import.</param>
        /// <param name="importFromId">The id of the existing PaymentLink that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the PaymentLink to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the PaymentLink to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing PaymentLink that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the PaymentLink to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(stripe.PaymentLink.PaymentLink), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAfterCompletion", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentLink.PaymentLinkAfterCompletion\"}}]")]
        public virtual void PutAfterCompletion(stripe.PaymentLink.IPaymentLinkAfterCompletion @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentLink.IPaymentLinkAfterCompletion)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAutomaticTax", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentLink.PaymentLinkAutomaticTax\"}}]")]
        public virtual void PutAutomaticTax(stripe.PaymentLink.IPaymentLinkAutomaticTax @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentLink.IPaymentLinkAutomaticTax)}, new object[]{@value});
        }

        [JsiiMethod(name: "putConsentCollection", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentLink.PaymentLinkConsentCollection\"}}]")]
        public virtual void PutConsentCollection(stripe.PaymentLink.IPaymentLinkConsentCollection @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentLink.IPaymentLinkConsentCollection)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.PaymentLink.IPaymentLinkCustomFields" />)[]</param>
        [JsiiMethod(name: "putCustomFields", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomFields\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCustomFields(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case stripe.PaymentLink.IPaymentLinkCustomFields[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.PaymentLink.IPaymentLinkCustomFields).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.PaymentLink.IPaymentLinkCustomFields).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCustomText", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomText\"}}]")]
        public virtual void PutCustomText(stripe.PaymentLink.IPaymentLinkCustomText @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentLink.IPaymentLinkCustomText)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInvoiceCreation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentLink.PaymentLinkInvoiceCreation\"}}]")]
        public virtual void PutInvoiceCreation(stripe.PaymentLink.IPaymentLinkInvoiceCreation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentLink.IPaymentLinkInvoiceCreation)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.PaymentLink.IPaymentLinkLineItems" />)[]</param>
        [JsiiMethod(name: "putLineItems", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.paymentLink.PaymentLinkLineItems\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLineItems(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case stripe.PaymentLink.IPaymentLinkLineItems[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.PaymentLink.IPaymentLinkLineItems).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.PaymentLink.IPaymentLinkLineItems).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putManagedPayments", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentLink.PaymentLinkManagedPayments\"}}]")]
        public virtual void PutManagedPayments(stripe.PaymentLink.IPaymentLinkManagedPayments @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentLink.IPaymentLinkManagedPayments)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNameCollection", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentLink.PaymentLinkNameCollection\"}}]")]
        public virtual void PutNameCollection(stripe.PaymentLink.IPaymentLinkNameCollection @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentLink.IPaymentLinkNameCollection)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.PaymentLink.IPaymentLinkOptionalItems" />)[]</param>
        [JsiiMethod(name: "putOptionalItems", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.paymentLink.PaymentLinkOptionalItems\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutOptionalItems(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case stripe.PaymentLink.IPaymentLinkOptionalItems[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.PaymentLink.IPaymentLinkOptionalItems).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.PaymentLink.IPaymentLinkOptionalItems).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPaymentIntentData", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentLink.PaymentLinkPaymentIntentData\"}}]")]
        public virtual void PutPaymentIntentData(stripe.PaymentLink.IPaymentLinkPaymentIntentData @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentLink.IPaymentLinkPaymentIntentData)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPaymentMethodOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentLink.PaymentLinkPaymentMethodOptions\"}}]")]
        public virtual void PutPaymentMethodOptions(stripe.PaymentLink.IPaymentLinkPaymentMethodOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentLink.IPaymentLinkPaymentMethodOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPhoneNumberCollection", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentLink.PaymentLinkPhoneNumberCollection\"}}]")]
        public virtual void PutPhoneNumberCollection(stripe.PaymentLink.IPaymentLinkPhoneNumberCollection @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentLink.IPaymentLinkPhoneNumberCollection)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRestrictions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentLink.PaymentLinkRestrictions\"}}]")]
        public virtual void PutRestrictions(stripe.PaymentLink.IPaymentLinkRestrictions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentLink.IPaymentLinkRestrictions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putShippingAddressCollection", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentLink.PaymentLinkShippingAddressCollection\"}}]")]
        public virtual void PutShippingAddressCollection(stripe.PaymentLink.IPaymentLinkShippingAddressCollection @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentLink.IPaymentLinkShippingAddressCollection)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.PaymentLink.IPaymentLinkShippingOptions" />)[]</param>
        [JsiiMethod(name: "putShippingOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.paymentLink.PaymentLinkShippingOptions\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutShippingOptions(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case stripe.PaymentLink.IPaymentLinkShippingOptions[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.PaymentLink.IPaymentLinkShippingOptions).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.PaymentLink.IPaymentLinkShippingOptions).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSubscriptionData", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentLink.PaymentLinkSubscriptionData\"}}]")]
        public virtual void PutSubscriptionData(stripe.PaymentLink.IPaymentLinkSubscriptionData @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentLink.IPaymentLinkSubscriptionData)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTaxIdCollection", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentLink.PaymentLinkTaxIdCollection\"}}]")]
        public virtual void PutTaxIdCollection(stripe.PaymentLink.IPaymentLinkTaxIdCollection @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentLink.IPaymentLinkTaxIdCollection)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTransferData", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentLink.PaymentLinkTransferData\"}}]")]
        public virtual void PutTransferData(stripe.PaymentLink.IPaymentLinkTransferData @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentLink.IPaymentLinkTransferData)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetActive")]
        public virtual void ResetActive()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAfterCompletion")]
        public virtual void ResetAfterCompletion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAllowPromotionCodes")]
        public virtual void ResetAllowPromotionCodes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetApplicationFeeAmount")]
        public virtual void ResetApplicationFeeAmount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetApplicationFeePercent")]
        public virtual void ResetApplicationFeePercent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutomaticTax")]
        public virtual void ResetAutomaticTax()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBillingAddressCollection")]
        public virtual void ResetBillingAddressCollection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConsentCollection")]
        public virtual void ResetConsentCollection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCurrency")]
        public virtual void ResetCurrency()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomerCreation")]
        public virtual void ResetCustomerCreation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomFields")]
        public virtual void ResetCustomFields()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomText")]
        public virtual void ResetCustomText()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInactiveMessage")]
        public virtual void ResetInactiveMessage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInvoiceCreation")]
        public virtual void ResetInvoiceCreation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetManagedPayments")]
        public virtual void ResetManagedPayments()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetadata")]
        public virtual void ResetMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNameCollection")]
        public virtual void ResetNameCollection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOnBehalfOf")]
        public virtual void ResetOnBehalfOf()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOptionalItems")]
        public virtual void ResetOptionalItems()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPaymentIntentData")]
        public virtual void ResetPaymentIntentData()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPaymentMethodCollection")]
        public virtual void ResetPaymentMethodCollection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPaymentMethodOptions")]
        public virtual void ResetPaymentMethodOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPaymentMethodTypes")]
        public virtual void ResetPaymentMethodTypes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPhoneNumberCollection")]
        public virtual void ResetPhoneNumberCollection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRestrictions")]
        public virtual void ResetRestrictions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShippingAddressCollection")]
        public virtual void ResetShippingAddressCollection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShippingOptions")]
        public virtual void ResetShippingOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubmitType")]
        public virtual void ResetSubmitType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubscriptionData")]
        public virtual void ResetSubscriptionData()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTaxIdCollection")]
        public virtual void ResetTaxIdCollection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTransferData")]
        public virtual void ResetTransferData()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(stripe.PaymentLink.PaymentLink))!;

        [JsiiProperty(name: "afterCompletion", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkAfterCompletionOutputReference\"}")]
        public virtual stripe.PaymentLink.PaymentLinkAfterCompletionOutputReference AfterCompletion
        {
            get => GetInstanceProperty<stripe.PaymentLink.PaymentLinkAfterCompletionOutputReference>()!;
        }

        [JsiiProperty(name: "application", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Application
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "automaticTax", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkAutomaticTaxOutputReference\"}")]
        public virtual stripe.PaymentLink.PaymentLinkAutomaticTaxOutputReference AutomaticTax
        {
            get => GetInstanceProperty<stripe.PaymentLink.PaymentLinkAutomaticTaxOutputReference>()!;
        }

        [JsiiProperty(name: "consentCollection", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkConsentCollectionOutputReference\"}")]
        public virtual stripe.PaymentLink.PaymentLinkConsentCollectionOutputReference ConsentCollection
        {
            get => GetInstanceProperty<stripe.PaymentLink.PaymentLinkConsentCollectionOutputReference>()!;
        }

        [JsiiProperty(name: "customFields", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomFieldsList\"}")]
        public virtual stripe.PaymentLink.PaymentLinkCustomFieldsList CustomFields
        {
            get => GetInstanceProperty<stripe.PaymentLink.PaymentLinkCustomFieldsList>()!;
        }

        [JsiiProperty(name: "customText", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomTextOutputReference\"}")]
        public virtual stripe.PaymentLink.PaymentLinkCustomTextOutputReference CustomText
        {
            get => GetInstanceProperty<stripe.PaymentLink.PaymentLinkCustomTextOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "invoiceCreation", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkInvoiceCreationOutputReference\"}")]
        public virtual stripe.PaymentLink.PaymentLinkInvoiceCreationOutputReference InvoiceCreation
        {
            get => GetInstanceProperty<stripe.PaymentLink.PaymentLinkInvoiceCreationOutputReference>()!;
        }

        [JsiiProperty(name: "lineItems", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkLineItemsList\"}")]
        public virtual stripe.PaymentLink.PaymentLinkLineItemsList LineItems
        {
            get => GetInstanceProperty<stripe.PaymentLink.PaymentLinkLineItemsList>()!;
        }

        [JsiiProperty(name: "livemode", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Livemode
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "managedPayments", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkManagedPaymentsOutputReference\"}")]
        public virtual stripe.PaymentLink.PaymentLinkManagedPaymentsOutputReference ManagedPayments
        {
            get => GetInstanceProperty<stripe.PaymentLink.PaymentLinkManagedPaymentsOutputReference>()!;
        }

        [JsiiProperty(name: "nameCollection", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkNameCollectionOutputReference\"}")]
        public virtual stripe.PaymentLink.PaymentLinkNameCollectionOutputReference NameCollection
        {
            get => GetInstanceProperty<stripe.PaymentLink.PaymentLinkNameCollectionOutputReference>()!;
        }

        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Object
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "optionalItems", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkOptionalItemsList\"}")]
        public virtual stripe.PaymentLink.PaymentLinkOptionalItemsList OptionalItems
        {
            get => GetInstanceProperty<stripe.PaymentLink.PaymentLinkOptionalItemsList>()!;
        }

        [JsiiProperty(name: "paymentIntentData", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkPaymentIntentDataOutputReference\"}")]
        public virtual stripe.PaymentLink.PaymentLinkPaymentIntentDataOutputReference PaymentIntentData
        {
            get => GetInstanceProperty<stripe.PaymentLink.PaymentLinkPaymentIntentDataOutputReference>()!;
        }

        [JsiiProperty(name: "paymentMethodOptions", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkPaymentMethodOptionsOutputReference\"}")]
        public virtual stripe.PaymentLink.PaymentLinkPaymentMethodOptionsOutputReference PaymentMethodOptions
        {
            get => GetInstanceProperty<stripe.PaymentLink.PaymentLinkPaymentMethodOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "phoneNumberCollection", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkPhoneNumberCollectionOutputReference\"}")]
        public virtual stripe.PaymentLink.PaymentLinkPhoneNumberCollectionOutputReference PhoneNumberCollection
        {
            get => GetInstanceProperty<stripe.PaymentLink.PaymentLinkPhoneNumberCollectionOutputReference>()!;
        }

        [JsiiProperty(name: "restrictions", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkRestrictionsOutputReference\"}")]
        public virtual stripe.PaymentLink.PaymentLinkRestrictionsOutputReference Restrictions
        {
            get => GetInstanceProperty<stripe.PaymentLink.PaymentLinkRestrictionsOutputReference>()!;
        }

        [JsiiProperty(name: "shippingAddressCollection", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkShippingAddressCollectionOutputReference\"}")]
        public virtual stripe.PaymentLink.PaymentLinkShippingAddressCollectionOutputReference ShippingAddressCollection
        {
            get => GetInstanceProperty<stripe.PaymentLink.PaymentLinkShippingAddressCollectionOutputReference>()!;
        }

        [JsiiProperty(name: "shippingOptions", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkShippingOptionsList\"}")]
        public virtual stripe.PaymentLink.PaymentLinkShippingOptionsList ShippingOptions
        {
            get => GetInstanceProperty<stripe.PaymentLink.PaymentLinkShippingOptionsList>()!;
        }

        [JsiiProperty(name: "subscriptionData", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkSubscriptionDataOutputReference\"}")]
        public virtual stripe.PaymentLink.PaymentLinkSubscriptionDataOutputReference SubscriptionData
        {
            get => GetInstanceProperty<stripe.PaymentLink.PaymentLinkSubscriptionDataOutputReference>()!;
        }

        [JsiiProperty(name: "taxIdCollection", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkTaxIdCollectionOutputReference\"}")]
        public virtual stripe.PaymentLink.PaymentLinkTaxIdCollectionOutputReference TaxIdCollection
        {
            get => GetInstanceProperty<stripe.PaymentLink.PaymentLinkTaxIdCollectionOutputReference>()!;
        }

        [JsiiProperty(name: "transferData", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkTransferDataOutputReference\"}")]
        public virtual stripe.PaymentLink.PaymentLinkTransferDataOutputReference TransferData
        {
            get => GetInstanceProperty<stripe.PaymentLink.PaymentLinkTransferDataOutputReference>()!;
        }

        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Url
        {
            get => GetInstanceProperty<string>()!;
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "activeInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ActiveInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentLink.IPaymentLinkAfterCompletion" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "afterCompletionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentLink.PaymentLinkAfterCompletion\"}]}}", isOptional: true)]
        public virtual object? AfterCompletionInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowPromotionCodesInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AllowPromotionCodesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationFeeAmountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ApplicationFeeAmountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationFeePercentInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ApplicationFeePercentInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentLink.IPaymentLinkAutomaticTax" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "automaticTaxInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentLink.PaymentLinkAutomaticTax\"}]}}", isOptional: true)]
        public virtual object? AutomaticTaxInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "billingAddressCollectionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BillingAddressCollectionInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentLink.IPaymentLinkConsentCollection" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "consentCollectionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentLink.PaymentLinkConsentCollection\"}]}}", isOptional: true)]
        public virtual object? ConsentCollectionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "currencyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CurrencyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customerCreationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomerCreationInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.PaymentLink.IPaymentLinkCustomFields" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customFieldsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CustomFieldsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentLink.IPaymentLinkCustomText" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customTextInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomText\"}]}}", isOptional: true)]
        public virtual object? CustomTextInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inactiveMessageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InactiveMessageInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentLink.IPaymentLinkInvoiceCreation" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "invoiceCreationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentLink.PaymentLinkInvoiceCreation\"}]}}", isOptional: true)]
        public virtual object? InvoiceCreationInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.PaymentLink.IPaymentLinkLineItems" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lineItemsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.paymentLink.PaymentLinkLineItems\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LineItemsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentLink.IPaymentLinkManagedPayments" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "managedPaymentsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentLink.PaymentLinkManagedPayments\"}]}}", isOptional: true)]
        public virtual object? ManagedPaymentsInput
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentLink.IPaymentLinkNameCollection" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nameCollectionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentLink.PaymentLinkNameCollection\"}]}}", isOptional: true)]
        public virtual object? NameCollectionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "onBehalfOfInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OnBehalfOfInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.PaymentLink.IPaymentLinkOptionalItems" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "optionalItemsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.paymentLink.PaymentLinkOptionalItems\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? OptionalItemsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentLink.IPaymentLinkPaymentIntentData" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paymentIntentDataInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentLink.PaymentLinkPaymentIntentData\"}]}}", isOptional: true)]
        public virtual object? PaymentIntentDataInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "paymentMethodCollectionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PaymentMethodCollectionInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentLink.IPaymentLinkPaymentMethodOptions" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paymentMethodOptionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentLink.PaymentLinkPaymentMethodOptions\"}]}}", isOptional: true)]
        public virtual object? PaymentMethodOptionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "paymentMethodTypesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? PaymentMethodTypesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentLink.IPaymentLinkPhoneNumberCollection" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "phoneNumberCollectionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentLink.PaymentLinkPhoneNumberCollection\"}]}}", isOptional: true)]
        public virtual object? PhoneNumberCollectionInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentLink.IPaymentLinkRestrictions" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "restrictionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentLink.PaymentLinkRestrictions\"}]}}", isOptional: true)]
        public virtual object? RestrictionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentLink.IPaymentLinkShippingAddressCollection" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shippingAddressCollectionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentLink.PaymentLinkShippingAddressCollection\"}]}}", isOptional: true)]
        public virtual object? ShippingAddressCollectionInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.PaymentLink.IPaymentLinkShippingOptions" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shippingOptionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.paymentLink.PaymentLinkShippingOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ShippingOptionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "submitTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubmitTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentLink.IPaymentLinkSubscriptionData" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "subscriptionDataInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentLink.PaymentLinkSubscriptionData\"}]}}", isOptional: true)]
        public virtual object? SubscriptionDataInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentLink.IPaymentLinkTaxIdCollection" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "taxIdCollectionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentLink.PaymentLinkTaxIdCollection\"}]}}", isOptional: true)]
        public virtual object? TaxIdCollectionInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentLink.IPaymentLinkTransferData" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "transferDataInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentLink.PaymentLinkTransferData\"}]}}", isOptional: true)]
        public virtual object? TransferDataInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "active", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Active
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "allowPromotionCodes", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object AllowPromotionCodes
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "applicationFeeAmount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ApplicationFeeAmount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "applicationFeePercent", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ApplicationFeePercent
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "billingAddressCollection", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BillingAddressCollection
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Currency
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "customerCreation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerCreation
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "inactiveMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InactiveMessage
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

        [JsiiProperty(name: "onBehalfOf", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OnBehalfOf
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "paymentMethodCollection", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PaymentMethodCollection
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "paymentMethodTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PaymentMethodTypes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "submitType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubmitType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
