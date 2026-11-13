using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementOutboundPayment
{
    [JsiiClass(nativeType: typeof(stripe.V2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentToPayoutMethodOptionsBankAccountOutputReference), fullyQualifiedName: "stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentToPayoutMethodOptionsBankAccountOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class V2MoneyManagementOutboundPaymentToPayoutMethodOptionsBankAccountOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public V2MoneyManagementOutboundPaymentToPayoutMethodOptionsBankAccountOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected V2MoneyManagementOutboundPaymentToPayoutMethodOptionsBankAccountOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected V2MoneyManagementOutboundPaymentToPayoutMethodOptionsBankAccountOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPreferredNetworkOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentToPayoutMethodOptionsBankAccountPreferredNetworkOptions\"}}]")]
        public virtual void PutPreferredNetworkOptions(stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentToPayoutMethodOptionsBankAccountPreferredNetworkOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentToPayoutMethodOptionsBankAccountPreferredNetworkOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetPreferredNetworkOptions")]
        public virtual void ResetPreferredNetworkOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPreferredNetworks")]
        public virtual void ResetPreferredNetworks()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "preferredNetworkOptions", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentToPayoutMethodOptionsBankAccountPreferredNetworkOptionsOutputReference\"}")]
        public virtual stripe.V2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentToPayoutMethodOptionsBankAccountPreferredNetworkOptionsOutputReference PreferredNetworkOptions
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentToPayoutMethodOptionsBankAccountPreferredNetworkOptionsOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentToPayoutMethodOptionsBankAccountPreferredNetworkOptions" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "preferredNetworkOptionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentToPayoutMethodOptionsBankAccountPreferredNetworkOptions\"}]}}", isOptional: true)]
        public virtual object? PreferredNetworkOptionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "preferredNetworksInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? PreferredNetworksInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "preferredNetworks", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PreferredNetworks
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentToPayoutMethodOptionsBankAccount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentToPayoutMethodOptionsBankAccount\"}]}}", isOptional: true)]
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
                        case stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentToPayoutMethodOptionsBankAccount cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentToPayoutMethodOptionsBankAccount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
