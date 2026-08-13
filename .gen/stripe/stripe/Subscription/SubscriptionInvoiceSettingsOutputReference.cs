using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiClass(nativeType: typeof(stripe.Subscription.SubscriptionInvoiceSettingsOutputReference), fullyQualifiedName: "stripe.subscription.SubscriptionInvoiceSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SubscriptionInvoiceSettingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SubscriptionInvoiceSettingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SubscriptionInvoiceSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SubscriptionInvoiceSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIssuer", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.subscription.SubscriptionInvoiceSettingsIssuer\"}}]")]
        public virtual void PutIssuer(stripe.Subscription.ISubscriptionInvoiceSettingsIssuer @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Subscription.ISubscriptionInvoiceSettingsIssuer)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccountTaxIds")]
        public virtual void ResetAccountTaxIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIssuer")]
        public virtual void ResetIssuer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "issuer", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionInvoiceSettingsIssuerOutputReference\"}")]
        public virtual stripe.Subscription.SubscriptionInvoiceSettingsIssuerOutputReference Issuer
        {
            get => GetInstanceProperty<stripe.Subscription.SubscriptionInvoiceSettingsIssuerOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountTaxIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AccountTaxIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Subscription.ISubscriptionInvoiceSettingsIssuer" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "issuerInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.subscription.SubscriptionInvoiceSettingsIssuer\"}]}}", isOptional: true)]
        public virtual object? IssuerInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "accountTaxIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AccountTaxIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Subscription.ISubscriptionInvoiceSettings" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.subscription.SubscriptionInvoiceSettings\"}]}}", isOptional: true)]
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
                        case stripe.Subscription.ISubscriptionInvoiceSettings cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Subscription.ISubscriptionInvoiceSettings).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
