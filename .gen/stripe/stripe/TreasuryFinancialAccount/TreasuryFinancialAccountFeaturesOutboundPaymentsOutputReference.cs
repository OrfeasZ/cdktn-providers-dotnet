using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TreasuryFinancialAccount
{
    [JsiiClass(nativeType: typeof(stripe.TreasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundPaymentsOutputReference), fullyQualifiedName: "stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundPaymentsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class TreasuryFinancialAccountFeaturesOutboundPaymentsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public TreasuryFinancialAccountFeaturesOutboundPaymentsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected TreasuryFinancialAccountFeaturesOutboundPaymentsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TreasuryFinancialAccountFeaturesOutboundPaymentsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAch", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundPaymentsAch\"}}]")]
        public virtual void PutAch(stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundPaymentsAch @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundPaymentsAch)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUsDomesticWire", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundPaymentsUsDomesticWire\"}}]")]
        public virtual void PutUsDomesticWire(stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundPaymentsUsDomesticWire @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundPaymentsUsDomesticWire)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAch")]
        public virtual void ResetAch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUsDomesticWire")]
        public virtual void ResetUsDomesticWire()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "ach", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundPaymentsAchOutputReference\"}")]
        public virtual stripe.TreasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundPaymentsAchOutputReference Ach
        {
            get => GetInstanceProperty<stripe.TreasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundPaymentsAchOutputReference>()!;
        }

        [JsiiProperty(name: "usDomesticWire", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundPaymentsUsDomesticWireOutputReference\"}")]
        public virtual stripe.TreasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundPaymentsUsDomesticWireOutputReference UsDomesticWire
        {
            get => GetInstanceProperty<stripe.TreasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundPaymentsUsDomesticWireOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundPaymentsAch" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "achInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundPaymentsAch\"}]}}", isOptional: true)]
        public virtual object? AchInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundPaymentsUsDomesticWire" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "usDomesticWireInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundPaymentsUsDomesticWire\"}]}}", isOptional: true)]
        public virtual object? UsDomesticWireInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundPayments" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundPayments\"}]}}", isOptional: true)]
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
                        case stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundPayments cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundPayments).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
