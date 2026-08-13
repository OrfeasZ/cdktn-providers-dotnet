using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TreasuryFinancialAccount
{
    [JsiiClass(nativeType: typeof(stripe.TreasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutputReference), fullyQualifiedName: "stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class TreasuryFinancialAccountFeaturesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public TreasuryFinancialAccountFeaturesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected TreasuryFinancialAccountFeaturesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TreasuryFinancialAccountFeaturesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCardIssuing", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesCardIssuing\"}}]")]
        public virtual void PutCardIssuing(stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesCardIssuing @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesCardIssuing)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDepositInsurance", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesDepositInsurance\"}}]")]
        public virtual void PutDepositInsurance(stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesDepositInsurance @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesDepositInsurance)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFinancialAddresses", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesFinancialAddresses\"}}]")]
        public virtual void PutFinancialAddresses(stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesFinancialAddresses @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesFinancialAddresses)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInboundTransfers", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesInboundTransfers\"}}]")]
        public virtual void PutInboundTransfers(stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesInboundTransfers @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesInboundTransfers)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIntraStripeFlows", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesIntraStripeFlows\"}}]")]
        public virtual void PutIntraStripeFlows(stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesIntraStripeFlows @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesIntraStripeFlows)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOutboundPayments", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundPayments\"}}]")]
        public virtual void PutOutboundPayments(stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundPayments @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundPayments)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOutboundTransfers", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundTransfers\"}}]")]
        public virtual void PutOutboundTransfers(stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundTransfers @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundTransfers)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCardIssuing")]
        public virtual void ResetCardIssuing()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDepositInsurance")]
        public virtual void ResetDepositInsurance()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFinancialAddresses")]
        public virtual void ResetFinancialAddresses()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInboundTransfers")]
        public virtual void ResetInboundTransfers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIntraStripeFlows")]
        public virtual void ResetIntraStripeFlows()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetObject")]
        public virtual void ResetObject()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutboundPayments")]
        public virtual void ResetOutboundPayments()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutboundTransfers")]
        public virtual void ResetOutboundTransfers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cardIssuing", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesCardIssuingOutputReference\"}")]
        public virtual stripe.TreasuryFinancialAccount.TreasuryFinancialAccountFeaturesCardIssuingOutputReference CardIssuing
        {
            get => GetInstanceProperty<stripe.TreasuryFinancialAccount.TreasuryFinancialAccountFeaturesCardIssuingOutputReference>()!;
        }

        [JsiiProperty(name: "depositInsurance", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesDepositInsuranceOutputReference\"}")]
        public virtual stripe.TreasuryFinancialAccount.TreasuryFinancialAccountFeaturesDepositInsuranceOutputReference DepositInsurance
        {
            get => GetInstanceProperty<stripe.TreasuryFinancialAccount.TreasuryFinancialAccountFeaturesDepositInsuranceOutputReference>()!;
        }

        [JsiiProperty(name: "financialAddresses", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesFinancialAddressesOutputReference\"}")]
        public virtual stripe.TreasuryFinancialAccount.TreasuryFinancialAccountFeaturesFinancialAddressesOutputReference FinancialAddresses
        {
            get => GetInstanceProperty<stripe.TreasuryFinancialAccount.TreasuryFinancialAccountFeaturesFinancialAddressesOutputReference>()!;
        }

        [JsiiProperty(name: "inboundTransfers", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesInboundTransfersOutputReference\"}")]
        public virtual stripe.TreasuryFinancialAccount.TreasuryFinancialAccountFeaturesInboundTransfersOutputReference InboundTransfers
        {
            get => GetInstanceProperty<stripe.TreasuryFinancialAccount.TreasuryFinancialAccountFeaturesInboundTransfersOutputReference>()!;
        }

        [JsiiProperty(name: "intraStripeFlows", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesIntraStripeFlowsOutputReference\"}")]
        public virtual stripe.TreasuryFinancialAccount.TreasuryFinancialAccountFeaturesIntraStripeFlowsOutputReference IntraStripeFlows
        {
            get => GetInstanceProperty<stripe.TreasuryFinancialAccount.TreasuryFinancialAccountFeaturesIntraStripeFlowsOutputReference>()!;
        }

        [JsiiProperty(name: "outboundPayments", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundPaymentsOutputReference\"}")]
        public virtual stripe.TreasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundPaymentsOutputReference OutboundPayments
        {
            get => GetInstanceProperty<stripe.TreasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundPaymentsOutputReference>()!;
        }

        [JsiiProperty(name: "outboundTransfers", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundTransfersOutputReference\"}")]
        public virtual stripe.TreasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundTransfersOutputReference OutboundTransfers
        {
            get => GetInstanceProperty<stripe.TreasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundTransfersOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesCardIssuing" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cardIssuingInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesCardIssuing\"}]}}", isOptional: true)]
        public virtual object? CardIssuingInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesDepositInsurance" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "depositInsuranceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesDepositInsurance\"}]}}", isOptional: true)]
        public virtual object? DepositInsuranceInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesFinancialAddresses" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "financialAddressesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesFinancialAddresses\"}]}}", isOptional: true)]
        public virtual object? FinancialAddressesInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesInboundTransfers" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inboundTransfersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesInboundTransfers\"}]}}", isOptional: true)]
        public virtual object? InboundTransfersInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesIntraStripeFlows" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "intraStripeFlowsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesIntraStripeFlows\"}]}}", isOptional: true)]
        public virtual object? IntraStripeFlowsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "objectInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ObjectInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundPayments" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "outboundPaymentsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundPayments\"}]}}", isOptional: true)]
        public virtual object? OutboundPaymentsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeaturesOutboundTransfers" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "outboundTransfersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeaturesOutboundTransfers\"}]}}", isOptional: true)]
        public virtual object? OutboundTransfersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Object
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeatures" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFeatures\"}]}}", isOptional: true)]
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
                        case stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeatures cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFeatures).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
