using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiClass(nativeType: typeof(stripe.SetupIntent.SetupIntentPaymentMethodOptionsCardThreeDSecureOutputReference), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodOptionsCardThreeDSecureOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SetupIntentPaymentMethodOptionsCardThreeDSecureOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SetupIntentPaymentMethodOptionsCardThreeDSecureOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SetupIntentPaymentMethodOptionsCardThreeDSecureOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SetupIntentPaymentMethodOptionsCardThreeDSecureOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putNetworkOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsCardThreeDSecureNetworkOptions\"}}]")]
        public virtual void PutNetworkOptions(stripe.SetupIntent.ISetupIntentPaymentMethodOptionsCardThreeDSecureNetworkOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.SetupIntent.ISetupIntentPaymentMethodOptionsCardThreeDSecureNetworkOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAresTransStatus")]
        public virtual void ResetAresTransStatus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCryptogram")]
        public virtual void ResetCryptogram()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetElectronicCommerceIndicator")]
        public virtual void ResetElectronicCommerceIndicator()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkOptions")]
        public virtual void ResetNetworkOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequestorChallengeIndicator")]
        public virtual void ResetRequestorChallengeIndicator()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTransactionId")]
        public virtual void ResetTransactionId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVersion")]
        public virtual void ResetVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "networkOptions", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsCardThreeDSecureNetworkOptionsOutputReference\"}")]
        public virtual stripe.SetupIntent.SetupIntentPaymentMethodOptionsCardThreeDSecureNetworkOptionsOutputReference NetworkOptions
        {
            get => GetInstanceProperty<stripe.SetupIntent.SetupIntentPaymentMethodOptionsCardThreeDSecureNetworkOptionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "aresTransStatusInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AresTransStatusInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cryptogramInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CryptogramInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "electronicCommerceIndicatorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ElectronicCommerceIndicatorInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SetupIntent.ISetupIntentPaymentMethodOptionsCardThreeDSecureNetworkOptions" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkOptionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsCardThreeDSecureNetworkOptions\"}]}}", isOptional: true)]
        public virtual object? NetworkOptionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestorChallengeIndicatorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RequestorChallengeIndicatorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "transactionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TransactionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "aresTransStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AresTransStatus
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cryptogram", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Cryptogram
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "electronicCommerceIndicator", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ElectronicCommerceIndicator
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requestorChallengeIndicator", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestorChallengeIndicator
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "transactionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransactionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SetupIntent.ISetupIntentPaymentMethodOptionsCardThreeDSecure" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsCardThreeDSecure\"}]}}", isOptional: true)]
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
                        case stripe.SetupIntent.ISetupIntentPaymentMethodOptionsCardThreeDSecure cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.SetupIntent.ISetupIntentPaymentMethodOptionsCardThreeDSecure).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
