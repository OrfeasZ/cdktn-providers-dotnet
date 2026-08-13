using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiClass(nativeType: typeof(stripe.SetupIntent.SetupIntentPaymentMethodOptionsUsBankAccountOutputReference), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodOptionsUsBankAccountOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SetupIntentPaymentMethodOptionsUsBankAccountOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SetupIntentPaymentMethodOptionsUsBankAccountOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SetupIntentPaymentMethodOptionsUsBankAccountOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SetupIntentPaymentMethodOptionsUsBankAccountOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFinancialConnections", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnections\"}}]")]
        public virtual void PutFinancialConnections(stripe.SetupIntent.ISetupIntentPaymentMethodOptionsUsBankAccountFinancialConnections @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.SetupIntent.ISetupIntentPaymentMethodOptionsUsBankAccountFinancialConnections)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMandateOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsUsBankAccountMandateOptions\"}}]")]
        public virtual void PutMandateOptions(stripe.SetupIntent.ISetupIntentPaymentMethodOptionsUsBankAccountMandateOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.SetupIntent.ISetupIntentPaymentMethodOptionsUsBankAccountMandateOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworks", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsUsBankAccountNetworks\"}}]")]
        public virtual void PutNetworks(stripe.SetupIntent.ISetupIntentPaymentMethodOptionsUsBankAccountNetworks @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.SetupIntent.ISetupIntentPaymentMethodOptionsUsBankAccountNetworks)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFinancialConnections")]
        public virtual void ResetFinancialConnections()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMandateOptions")]
        public virtual void ResetMandateOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworks")]
        public virtual void ResetNetworks()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVerificationMethod")]
        public virtual void ResetVerificationMethod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "financialConnections", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsOutputReference\"}")]
        public virtual stripe.SetupIntent.SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsOutputReference FinancialConnections
        {
            get => GetInstanceProperty<stripe.SetupIntent.SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsOutputReference>()!;
        }

        [JsiiProperty(name: "mandateOptions", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsUsBankAccountMandateOptionsOutputReference\"}")]
        public virtual stripe.SetupIntent.SetupIntentPaymentMethodOptionsUsBankAccountMandateOptionsOutputReference MandateOptions
        {
            get => GetInstanceProperty<stripe.SetupIntent.SetupIntentPaymentMethodOptionsUsBankAccountMandateOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "networks", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsUsBankAccountNetworksOutputReference\"}")]
        public virtual stripe.SetupIntent.SetupIntentPaymentMethodOptionsUsBankAccountNetworksOutputReference Networks
        {
            get => GetInstanceProperty<stripe.SetupIntent.SetupIntentPaymentMethodOptionsUsBankAccountNetworksOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SetupIntent.ISetupIntentPaymentMethodOptionsUsBankAccountFinancialConnections" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "financialConnectionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnections\"}]}}", isOptional: true)]
        public virtual object? FinancialConnectionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SetupIntent.ISetupIntentPaymentMethodOptionsUsBankAccountMandateOptions" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mandateOptionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsUsBankAccountMandateOptions\"}]}}", isOptional: true)]
        public virtual object? MandateOptionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SetupIntent.ISetupIntentPaymentMethodOptionsUsBankAccountNetworks" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networksInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsUsBankAccountNetworks\"}]}}", isOptional: true)]
        public virtual object? NetworksInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "verificationMethodInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VerificationMethodInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "verificationMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VerificationMethod
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SetupIntent.ISetupIntentPaymentMethodOptionsUsBankAccount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsUsBankAccount\"}]}}", isOptional: true)]
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
                        case stripe.SetupIntent.ISetupIntentPaymentMethodOptionsUsBankAccount cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.SetupIntent.ISetupIntentPaymentMethodOptionsUsBankAccount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
