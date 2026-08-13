using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TreasuryFinancialAccount
{
    [JsiiClass(nativeType: typeof(stripe.TreasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundTransfersOutputReference), fullyQualifiedName: "stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundTransfersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class TreasuryFinancialAccountFeaturesOutboundTransfersOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public TreasuryFinancialAccountFeaturesOutboundTransfersOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected TreasuryFinancialAccountFeaturesOutboundTransfersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TreasuryFinancialAccountFeaturesOutboundTransfersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAch", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundTransfersAch\"}}]")]
        public virtual void PutAch(stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundTransfersAch @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundTransfersAch)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUsDomesticWire", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundTransfersUsDomesticWire\"}}]")]
        public virtual void PutUsDomesticWire(stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundTransfersUsDomesticWire @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundTransfersUsDomesticWire)}, new object[]{@value});
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

        [JsiiProperty(name: "ach", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundTransfersAchOutputReference\"}")]
        public virtual stripe.TreasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundTransfersAchOutputReference Ach
        {
            get => GetInstanceProperty<stripe.TreasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundTransfersAchOutputReference>()!;
        }

        [JsiiProperty(name: "usDomesticWire", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundTransfersUsDomesticWireOutputReference\"}")]
        public virtual stripe.TreasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundTransfersUsDomesticWireOutputReference UsDomesticWire
        {
            get => GetInstanceProperty<stripe.TreasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundTransfersUsDomesticWireOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundTransfersAch" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "achInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundTransfersAch\"}]}}", isOptional: true)]
        public virtual object? AchInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundTransfersUsDomesticWire" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "usDomesticWireInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundTransfersUsDomesticWire\"}]}}", isOptional: true)]
        public virtual object? UsDomesticWireInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundTransfers" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundTransfers\"}]}}", isOptional: true)]
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
                        case stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundTransfers cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundTransfers).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
