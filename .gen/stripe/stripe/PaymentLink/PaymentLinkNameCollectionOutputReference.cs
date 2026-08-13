using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiClass(nativeType: typeof(stripe.PaymentLink.PaymentLinkNameCollectionOutputReference), fullyQualifiedName: "stripe.paymentLink.PaymentLinkNameCollectionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PaymentLinkNameCollectionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PaymentLinkNameCollectionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PaymentLinkNameCollectionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentLinkNameCollectionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBusiness", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentLink.PaymentLinkNameCollectionBusiness\"}}]")]
        public virtual void PutBusiness(stripe.PaymentLink.IPaymentLinkNameCollectionBusiness @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentLink.IPaymentLinkNameCollectionBusiness)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIndividual", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentLink.PaymentLinkNameCollectionIndividual\"}}]")]
        public virtual void PutIndividual(stripe.PaymentLink.IPaymentLinkNameCollectionIndividual @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentLink.IPaymentLinkNameCollectionIndividual)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBusiness")]
        public virtual void ResetBusiness()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIndividual")]
        public virtual void ResetIndividual()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "business", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkNameCollectionBusinessOutputReference\"}")]
        public virtual stripe.PaymentLink.PaymentLinkNameCollectionBusinessOutputReference Business
        {
            get => GetInstanceProperty<stripe.PaymentLink.PaymentLinkNameCollectionBusinessOutputReference>()!;
        }

        [JsiiProperty(name: "individual", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkNameCollectionIndividualOutputReference\"}")]
        public virtual stripe.PaymentLink.PaymentLinkNameCollectionIndividualOutputReference Individual
        {
            get => GetInstanceProperty<stripe.PaymentLink.PaymentLinkNameCollectionIndividualOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentLink.IPaymentLinkNameCollectionBusiness" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "businessInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentLink.PaymentLinkNameCollectionBusiness\"}]}}", isOptional: true)]
        public virtual object? BusinessInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentLink.IPaymentLinkNameCollectionIndividual" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "individualInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentLink.PaymentLinkNameCollectionIndividual\"}]}}", isOptional: true)]
        public virtual object? IndividualInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentLink.IPaymentLinkNameCollection" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentLink.PaymentLinkNameCollection\"}]}}", isOptional: true)]
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
                        case stripe.PaymentLink.IPaymentLinkNameCollection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.PaymentLink.IPaymentLinkNameCollection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
