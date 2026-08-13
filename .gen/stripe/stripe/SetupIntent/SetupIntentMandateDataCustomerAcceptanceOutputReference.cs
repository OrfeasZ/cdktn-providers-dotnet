using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiClass(nativeType: typeof(stripe.SetupIntent.SetupIntentMandateDataCustomerAcceptanceOutputReference), fullyQualifiedName: "stripe.setupIntent.SetupIntentMandateDataCustomerAcceptanceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SetupIntentMandateDataCustomerAcceptanceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SetupIntentMandateDataCustomerAcceptanceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SetupIntentMandateDataCustomerAcceptanceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SetupIntentMandateDataCustomerAcceptanceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putOnline", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.setupIntent.SetupIntentMandateDataCustomerAcceptanceOnline\"}}]")]
        public virtual void PutOnline(stripe.SetupIntent.ISetupIntentMandateDataCustomerAcceptanceOnline @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.SetupIntent.ISetupIntentMandateDataCustomerAcceptanceOnline)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAcceptedAt")]
        public virtual void ResetAcceptedAt()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOnline")]
        public virtual void ResetOnline()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "online", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentMandateDataCustomerAcceptanceOnlineOutputReference\"}")]
        public virtual stripe.SetupIntent.SetupIntentMandateDataCustomerAcceptanceOnlineOutputReference Online
        {
            get => GetInstanceProperty<stripe.SetupIntent.SetupIntentMandateDataCustomerAcceptanceOnlineOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "acceptedAtInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AcceptedAtInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SetupIntent.ISetupIntentMandateDataCustomerAcceptanceOnline" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "onlineInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.setupIntent.SetupIntentMandateDataCustomerAcceptanceOnline\"}]}}", isOptional: true)]
        public virtual object? OnlineInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "acceptedAt", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AcceptedAt
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SetupIntent.ISetupIntentMandateDataCustomerAcceptance" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.setupIntent.SetupIntentMandateDataCustomerAcceptance\"}]}}", isOptional: true)]
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
                        case stripe.SetupIntent.ISetupIntentMandateDataCustomerAcceptance cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.SetupIntent.ISetupIntentMandateDataCustomerAcceptance).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
