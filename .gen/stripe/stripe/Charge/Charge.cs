using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Charge
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge stripe_charge}.</summary>
    [JsiiClass(nativeType: typeof(stripe.Charge.Charge), fullyQualifiedName: "stripe.charge.Charge", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"stripe.charge.ChargeConfig\"}}]")]
    public class Charge : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge stripe_charge} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Charge(Constructs.Construct scope, string id, stripe.Charge.IChargeConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, stripe.Charge.IChargeConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Charge(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Charge(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a Charge resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the Charge to import.</param>
        /// <param name="importFromId">The id of the existing Charge that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the Charge to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the Charge to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/charge#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing Charge that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the Charge to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(stripe.Charge.Charge), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putDestination", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.charge.ChargeDestination\"}}]")]
        public virtual void PutDestination(stripe.Charge.IChargeDestination @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Charge.IChargeDestination)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFraudDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.charge.ChargeFraudDetails\"}}]")]
        public virtual void PutFraudDetails(stripe.Charge.IChargeFraudDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Charge.IChargeFraudDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRadarOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.charge.ChargeRadarOptions\"}}]")]
        public virtual void PutRadarOptions(stripe.Charge.IChargeRadarOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Charge.IChargeRadarOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putShipping", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.charge.ChargeShipping\"}}]")]
        public virtual void PutShipping(stripe.Charge.IChargeShipping @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Charge.IChargeShipping)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTransferData", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.charge.ChargeTransferData\"}}]")]
        public virtual void PutTransferData(stripe.Charge.IChargeTransferData @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Charge.IChargeTransferData)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAmount")]
        public virtual void ResetAmount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetApplicationFee")]
        public virtual void ResetApplicationFee()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetApplicationFeeAmount")]
        public virtual void ResetApplicationFeeAmount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCapture")]
        public virtual void ResetCapture()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCurrency")]
        public virtual void ResetCurrency()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomer")]
        public virtual void ResetCustomer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDestination")]
        public virtual void ResetDestination()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFraudDetails")]
        public virtual void ResetFraudDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetadata")]
        public virtual void ResetMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOnBehalfOf")]
        public virtual void ResetOnBehalfOf()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRadarOptions")]
        public virtual void ResetRadarOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReceiptEmail")]
        public virtual void ResetReceiptEmail()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShipping")]
        public virtual void ResetShipping()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSource")]
        public virtual void ResetSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStatementDescriptor")]
        public virtual void ResetStatementDescriptor()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStatementDescriptorSuffix")]
        public virtual void ResetStatementDescriptorSuffix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTransferData")]
        public virtual void ResetTransferData()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTransferGroup")]
        public virtual void ResetTransferGroup()
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
        = GetStaticProperty<string>(typeof(stripe.Charge.Charge))!;

        [JsiiProperty(name: "amountCaptured", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AmountCaptured
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "amountRefunded", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AmountRefunded
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "application", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Application
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "authorizationCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthorizationCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "balanceTransaction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BalanceTransaction
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "billingDetails", typeJson: "{\"fqn\":\"stripe.charge.ChargeBillingDetailsOutputReference\"}")]
        public virtual stripe.Charge.ChargeBillingDetailsOutputReference BillingDetails
        {
            get => GetInstanceProperty<stripe.Charge.ChargeBillingDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "calculatedStatementDescriptor", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CalculatedStatementDescriptor
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "captured", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Captured
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "created", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Created
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "destination", typeJson: "{\"fqn\":\"stripe.charge.ChargeDestinationOutputReference\"}")]
        public virtual stripe.Charge.ChargeDestinationOutputReference Destination
        {
            get => GetInstanceProperty<stripe.Charge.ChargeDestinationOutputReference>()!;
        }

        [JsiiProperty(name: "disputed", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Disputed
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "failureBalanceTransaction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FailureBalanceTransaction
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "failureCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FailureCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "failureMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FailureMessage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fraudDetails", typeJson: "{\"fqn\":\"stripe.charge.ChargeFraudDetailsOutputReference\"}")]
        public virtual stripe.Charge.ChargeFraudDetailsOutputReference FraudDetails
        {
            get => GetInstanceProperty<stripe.Charge.ChargeFraudDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "level3", typeJson: "{\"fqn\":\"stripe.charge.ChargeLevel3OutputReference\"}")]
        public virtual stripe.Charge.ChargeLevel3OutputReference Level3
        {
            get => GetInstanceProperty<stripe.Charge.ChargeLevel3OutputReference>()!;
        }

        [JsiiProperty(name: "livemode", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Livemode
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Object
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "outcome", typeJson: "{\"fqn\":\"stripe.charge.ChargeOutcomeOutputReference\"}")]
        public virtual stripe.Charge.ChargeOutcomeOutputReference Outcome
        {
            get => GetInstanceProperty<stripe.Charge.ChargeOutcomeOutputReference>()!;
        }

        [JsiiProperty(name: "paid", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Paid
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "paymentIntent", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PaymentIntent
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "paymentMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PaymentMethod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "paymentMethodDetails", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsOutputReference PaymentMethodDetails
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "presentmentDetails", typeJson: "{\"fqn\":\"stripe.charge.ChargePresentmentDetailsOutputReference\"}")]
        public virtual stripe.Charge.ChargePresentmentDetailsOutputReference PresentmentDetails
        {
            get => GetInstanceProperty<stripe.Charge.ChargePresentmentDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "radarOptions", typeJson: "{\"fqn\":\"stripe.charge.ChargeRadarOptionsOutputReference\"}")]
        public virtual stripe.Charge.ChargeRadarOptionsOutputReference RadarOptions
        {
            get => GetInstanceProperty<stripe.Charge.ChargeRadarOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "receiptNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReceiptNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "refunded", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Refunded
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "review", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Review
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shipping", typeJson: "{\"fqn\":\"stripe.charge.ChargeShippingOutputReference\"}")]
        public virtual stripe.Charge.ChargeShippingOutputReference Shipping
        {
            get => GetInstanceProperty<stripe.Charge.ChargeShippingOutputReference>()!;
        }

        [JsiiProperty(name: "sourceTransfer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceTransfer
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "transfer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Transfer
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "transferData", typeJson: "{\"fqn\":\"stripe.charge.ChargeTransferDataOutputReference\"}")]
        public virtual stripe.Charge.ChargeTransferDataOutputReference TransferData
        {
            get => GetInstanceProperty<stripe.Charge.ChargeTransferDataOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "amountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AmountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationFeeAmountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ApplicationFeeAmountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationFeeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ApplicationFeeInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "captureInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? CaptureInput
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
        [JsiiProperty(name: "customerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Charge.IChargeDestination" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "destinationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.charge.ChargeDestination\"}]}}", isOptional: true)]
        public virtual object? DestinationInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Charge.IChargeFraudDetails" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fraudDetailsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.charge.ChargeFraudDetails\"}]}}", isOptional: true)]
        public virtual object? FraudDetailsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metadataInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? MetadataInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "onBehalfOfInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OnBehalfOfInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Charge.IChargeRadarOptions" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "radarOptionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.charge.ChargeRadarOptions\"}]}}", isOptional: true)]
        public virtual object? RadarOptionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "receiptEmailInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReceiptEmailInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Charge.IChargeShipping" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shippingInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.charge.ChargeShipping\"}]}}", isOptional: true)]
        public virtual object? ShippingInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statementDescriptorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StatementDescriptorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statementDescriptorSuffixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StatementDescriptorSuffixInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Charge.IChargeTransferData" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "transferDataInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.charge.ChargeTransferData\"}]}}", isOptional: true)]
        public virtual object? TransferDataInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "transferGroupInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TransferGroupInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Amount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "applicationFee", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ApplicationFee
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "applicationFeeAmount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ApplicationFeeAmount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "capture", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Capture
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

        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Currency
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "customer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Customer
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
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

        [JsiiProperty(name: "receiptEmail", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReceiptEmail
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Source
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "statementDescriptor", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StatementDescriptor
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "statementDescriptorSuffix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StatementDescriptorSuffix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "transferGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransferGroup
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
