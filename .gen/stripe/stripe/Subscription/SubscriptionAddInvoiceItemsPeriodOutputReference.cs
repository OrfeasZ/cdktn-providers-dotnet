using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiClass(nativeType: typeof(stripe.Subscription.SubscriptionAddInvoiceItemsPeriodOutputReference), fullyQualifiedName: "stripe.subscription.SubscriptionAddInvoiceItemsPeriodOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SubscriptionAddInvoiceItemsPeriodOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SubscriptionAddInvoiceItemsPeriodOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SubscriptionAddInvoiceItemsPeriodOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SubscriptionAddInvoiceItemsPeriodOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEnd", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.subscription.SubscriptionAddInvoiceItemsPeriodEnd\"}}]")]
        public virtual void PutEnd(stripe.Subscription.ISubscriptionAddInvoiceItemsPeriodEnd @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Subscription.ISubscriptionAddInvoiceItemsPeriodEnd)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStart", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.subscription.SubscriptionAddInvoiceItemsPeriodStart\"}}]")]
        public virtual void PutStart(stripe.Subscription.ISubscriptionAddInvoiceItemsPeriodStart @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Subscription.ISubscriptionAddInvoiceItemsPeriodStart)}, new object[]{@value});
        }

        [JsiiProperty(name: "end", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionAddInvoiceItemsPeriodEndOutputReference\"}")]
        public virtual stripe.Subscription.SubscriptionAddInvoiceItemsPeriodEndOutputReference End
        {
            get => GetInstanceProperty<stripe.Subscription.SubscriptionAddInvoiceItemsPeriodEndOutputReference>()!;
        }

        [JsiiProperty(name: "start", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionAddInvoiceItemsPeriodStartOutputReference\"}")]
        public virtual stripe.Subscription.SubscriptionAddInvoiceItemsPeriodStartOutputReference Start
        {
            get => GetInstanceProperty<stripe.Subscription.SubscriptionAddInvoiceItemsPeriodStartOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Subscription.ISubscriptionAddInvoiceItemsPeriodEnd" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "endInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.subscription.SubscriptionAddInvoiceItemsPeriodEnd\"}]}}", isOptional: true)]
        public virtual object? EndInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Subscription.ISubscriptionAddInvoiceItemsPeriodStart" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "startInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.subscription.SubscriptionAddInvoiceItemsPeriodStart\"}]}}", isOptional: true)]
        public virtual object? StartInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Subscription.ISubscriptionAddInvoiceItemsPeriod" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.subscription.SubscriptionAddInvoiceItemsPeriod\"}]}}", isOptional: true)]
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
                        case stripe.Subscription.ISubscriptionAddInvoiceItemsPeriod cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Subscription.ISubscriptionAddInvoiceItemsPeriod).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
