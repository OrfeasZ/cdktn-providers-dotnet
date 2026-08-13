using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiClass(nativeType: typeof(stripe.SetupIntent.SetupIntentPaymentMethodDataKlarnaOutputReference), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodDataKlarnaOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SetupIntentPaymentMethodDataKlarnaOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SetupIntentPaymentMethodDataKlarnaOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SetupIntentPaymentMethodDataKlarnaOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SetupIntentPaymentMethodDataKlarnaOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDob", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataKlarnaDob\"}}]")]
        public virtual void PutDob(stripe.SetupIntent.ISetupIntentPaymentMethodDataKlarnaDob @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.SetupIntent.ISetupIntentPaymentMethodDataKlarnaDob)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDob")]
        public virtual void ResetDob()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "dob", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataKlarnaDobOutputReference\"}")]
        public virtual stripe.SetupIntent.SetupIntentPaymentMethodDataKlarnaDobOutputReference Dob
        {
            get => GetInstanceProperty<stripe.SetupIntent.SetupIntentPaymentMethodDataKlarnaDobOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SetupIntent.ISetupIntentPaymentMethodDataKlarnaDob" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dobInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataKlarnaDob\"}]}}", isOptional: true)]
        public virtual object? DobInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SetupIntent.ISetupIntentPaymentMethodDataKlarna" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataKlarna\"}]}}", isOptional: true)]
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
                        case stripe.SetupIntent.ISetupIntentPaymentMethodDataKlarna cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.SetupIntent.ISetupIntentPaymentMethodDataKlarna).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
