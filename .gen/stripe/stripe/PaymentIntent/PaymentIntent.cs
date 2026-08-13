using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent stripe_payment_intent}.</summary>
    [JsiiClass(nativeType: typeof(stripe.PaymentIntent.PaymentIntent), fullyQualifiedName: "stripe.paymentIntent.PaymentIntent", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentConfig\"}}]")]
    public class PaymentIntent : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent stripe_payment_intent} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public PaymentIntent(Constructs.Construct scope, string id, stripe.PaymentIntent.IPaymentIntentConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, stripe.PaymentIntent.IPaymentIntentConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentIntent(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentIntent(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a PaymentIntent resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the PaymentIntent to import.</param>
        /// <param name="importFromId">The id of the existing PaymentIntent that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the PaymentIntent to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the PaymentIntent to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing PaymentIntent that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the PaymentIntent to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(stripe.PaymentIntent.PaymentIntent), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAutomaticPaymentMethods", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentAutomaticPaymentMethods\"}}]")]
        public virtual void PutAutomaticPaymentMethods(stripe.PaymentIntent.IPaymentIntentAutomaticPaymentMethods @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentAutomaticPaymentMethods)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHooks", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentHooks\"}}]")]
        public virtual void PutHooks(stripe.PaymentIntent.IPaymentIntentHooks @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentHooks)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMandateData", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentMandateData\"}}]")]
        public virtual void PutMandateData(stripe.PaymentIntent.IPaymentIntentMandateData @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentMandateData)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPaymentDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentDetails\"}}]")]
        public virtual void PutPaymentDetails(stripe.PaymentIntent.IPaymentIntentPaymentDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPaymentMethodData", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodData\"}}]")]
        public virtual void PutPaymentMethodData(stripe.PaymentIntent.IPaymentIntentPaymentMethodData @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodData)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPaymentMethodOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptions\"}}]")]
        public virtual void PutPaymentMethodOptions(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRadarOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentRadarOptions\"}}]")]
        public virtual void PutRadarOptions(stripe.PaymentIntent.IPaymentIntentRadarOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentRadarOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putShipping", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentShipping\"}}]")]
        public virtual void PutShipping(stripe.PaymentIntent.IPaymentIntentShipping @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentShipping)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTransferData", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentTransferData\"}}]")]
        public virtual void PutTransferData(stripe.PaymentIntent.IPaymentIntentTransferData @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentTransferData)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApplicationFeeAmount")]
        public virtual void ResetApplicationFeeAmount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutomaticPaymentMethods")]
        public virtual void ResetAutomaticPaymentMethods()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCaptureMethod")]
        public virtual void ResetCaptureMethod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConfirm")]
        public virtual void ResetConfirm()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConfirmationMethod")]
        public virtual void ResetConfirmationMethod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConfirmationToken")]
        public virtual void ResetConfirmationToken()
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

        [JsiiMethod(name: "resetErrorOnRequiresAction")]
        public virtual void ResetErrorOnRequiresAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExcludedPaymentMethodTypes")]
        public virtual void ResetExcludedPaymentMethodTypes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHooks")]
        public virtual void ResetHooks()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMandate")]
        public virtual void ResetMandate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMandateData")]
        public virtual void ResetMandateData()
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

        [JsiiMethod(name: "resetPaymentDetails")]
        public virtual void ResetPaymentDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPaymentMethod")]
        public virtual void ResetPaymentMethod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPaymentMethodConfiguration")]
        public virtual void ResetPaymentMethodConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPaymentMethodData")]
        public virtual void ResetPaymentMethodData()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPaymentMethodOptions")]
        public virtual void ResetPaymentMethodOptions()
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

        [JsiiMethod(name: "resetReturnUrl")]
        public virtual void ResetReturnUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSetupFutureUsage")]
        public virtual void ResetSetupFutureUsage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShipping")]
        public virtual void ResetShipping()
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

        [JsiiMethod(name: "resetUseStripeSdk")]
        public virtual void ResetUseStripeSdk()
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
        = GetStaticProperty<string>(typeof(stripe.PaymentIntent.PaymentIntent))!;

        [JsiiProperty(name: "amountCapturable", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AmountCapturable
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "amountReceived", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AmountReceived
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "application", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Application
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "automaticPaymentMethods", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentAutomaticPaymentMethodsOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentAutomaticPaymentMethodsOutputReference AutomaticPaymentMethods
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentAutomaticPaymentMethodsOutputReference>()!;
        }

        [JsiiProperty(name: "canceledAt", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CanceledAt
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "cancellationReason", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CancellationReason
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientSecret
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "created", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Created
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "hooks", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentHooksOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentHooksOutputReference Hooks
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentHooksOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastPaymentError", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentLastPaymentErrorOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentLastPaymentErrorOutputReference LastPaymentError
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentLastPaymentErrorOutputReference>()!;
        }

        [JsiiProperty(name: "latestCharge", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LatestCharge
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "livemode", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Livemode
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "managedPayments", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentManagedPaymentsOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentManagedPaymentsOutputReference ManagedPayments
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentManagedPaymentsOutputReference>()!;
        }

        [JsiiProperty(name: "mandateData", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentMandateDataOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentMandateDataOutputReference MandateData
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentMandateDataOutputReference>()!;
        }

        [JsiiProperty(name: "nextAction", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentNextActionOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentNextActionOutputReference NextAction
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentNextActionOutputReference>()!;
        }

        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Object
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "paymentDetails", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentDetailsOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentDetailsOutputReference PaymentDetails
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "paymentMethodConfigurationDetails", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodConfigurationDetailsOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodConfigurationDetailsOutputReference PaymentMethodConfigurationDetails
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodConfigurationDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "paymentMethodData", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodDataOutputReference PaymentMethodData
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodDataOutputReference>()!;
        }

        [JsiiProperty(name: "paymentMethodOptions", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsOutputReference PaymentMethodOptions
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "presentmentDetails", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPresentmentDetailsOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPresentmentDetailsOutputReference PresentmentDetails
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPresentmentDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "processing", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentProcessingOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentProcessingOutputReference Processing
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentProcessingOutputReference>()!;
        }

        [JsiiProperty(name: "radarOptions", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentRadarOptionsOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentRadarOptionsOutputReference RadarOptions
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentRadarOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "review", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Review
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shipping", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentShippingOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentShippingOutputReference Shipping
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentShippingOutputReference>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Source
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "transferData", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentTransferDataOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentTransferDataOutputReference TransferData
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentTransferDataOutputReference>()!;
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

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentAutomaticPaymentMethods" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "automaticPaymentMethodsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentAutomaticPaymentMethods\"}]}}", isOptional: true)]
        public virtual object? AutomaticPaymentMethodsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "captureMethodInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CaptureMethodInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "confirmationMethodInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConfirmationMethodInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "confirmationTokenInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConfirmationTokenInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "confirmInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ConfirmInput
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
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "errorOnRequiresActionInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ErrorOnRequiresActionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "excludedPaymentMethodTypesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ExcludedPaymentMethodTypesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentHooks" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hooksInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentHooks\"}]}}", isOptional: true)]
        public virtual object? HooksInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentMandateData" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mandateDataInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentMandateData\"}]}}", isOptional: true)]
        public virtual object? MandateDataInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mandateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MandateInput
        {
            get => GetInstanceProperty<string?>();
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentDetails" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paymentDetailsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentDetails\"}]}}", isOptional: true)]
        public virtual object? PaymentDetailsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "paymentMethodConfigurationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PaymentMethodConfigurationInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodData" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paymentMethodDataInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodData\"}]}}", isOptional: true)]
        public virtual object? PaymentMethodDataInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "paymentMethodInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PaymentMethodInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodOptions" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paymentMethodOptionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptions\"}]}}", isOptional: true)]
        public virtual object? PaymentMethodOptionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentRadarOptions" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "radarOptionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentRadarOptions\"}]}}", isOptional: true)]
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

        [JsiiOptional]
        [JsiiProperty(name: "returnUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReturnUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "setupFutureUsageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SetupFutureUsageInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentShipping" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shippingInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentShipping\"}]}}", isOptional: true)]
        public virtual object? ShippingInput
        {
            get => GetInstanceProperty<object?>();
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentTransferData" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "transferDataInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentTransferData\"}]}}", isOptional: true)]
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

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "useStripeSdkInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? UseStripeSdkInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Amount
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

        [JsiiProperty(name: "captureMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CaptureMethod
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "confirm", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Confirm
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

        [JsiiProperty(name: "confirmationMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfirmationMethod
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "confirmationToken", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfirmationToken
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

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "errorOnRequiresAction", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object ErrorOnRequiresAction
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

        [JsiiProperty(name: "excludedPaymentMethodTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ExcludedPaymentMethodTypes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mandate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Mandate
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

        [JsiiProperty(name: "paymentMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PaymentMethod
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "paymentMethodConfiguration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PaymentMethodConfiguration
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

        [JsiiProperty(name: "returnUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReturnUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "setupFutureUsage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SetupFutureUsage
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

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "useStripeSdk", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object UseStripeSdk
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
    }
}
