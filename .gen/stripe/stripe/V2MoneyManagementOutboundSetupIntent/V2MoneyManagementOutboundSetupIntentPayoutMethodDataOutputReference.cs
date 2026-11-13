using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementOutboundSetupIntent
{
    [JsiiClass(nativeType: typeof(stripe.V2MoneyManagementOutboundSetupIntent.V2MoneyManagementOutboundSetupIntentPayoutMethodDataOutputReference), fullyQualifiedName: "stripe.v2MoneyManagementOutboundSetupIntent.V2MoneyManagementOutboundSetupIntentPayoutMethodDataOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class V2MoneyManagementOutboundSetupIntentPayoutMethodDataOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public V2MoneyManagementOutboundSetupIntentPayoutMethodDataOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected V2MoneyManagementOutboundSetupIntentPayoutMethodDataOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected V2MoneyManagementOutboundSetupIntentPayoutMethodDataOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBankAccount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.v2MoneyManagementOutboundSetupIntent.V2MoneyManagementOutboundSetupIntentPayoutMethodDataBankAccount\"}}]")]
        public virtual void PutBankAccount(stripe.V2MoneyManagementOutboundSetupIntent.IV2MoneyManagementOutboundSetupIntentPayoutMethodDataBankAccount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.V2MoneyManagementOutboundSetupIntent.IV2MoneyManagementOutboundSetupIntentPayoutMethodDataBankAccount)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBankAccount")]
        public virtual void ResetBankAccount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "bankAccount", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementOutboundSetupIntent.V2MoneyManagementOutboundSetupIntentPayoutMethodDataBankAccountOutputReference\"}")]
        public virtual stripe.V2MoneyManagementOutboundSetupIntent.V2MoneyManagementOutboundSetupIntentPayoutMethodDataBankAccountOutputReference BankAccount
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementOutboundSetupIntent.V2MoneyManagementOutboundSetupIntentPayoutMethodDataBankAccountOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.V2MoneyManagementOutboundSetupIntent.IV2MoneyManagementOutboundSetupIntentPayoutMethodDataBankAccount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bankAccountInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.v2MoneyManagementOutboundSetupIntent.V2MoneyManagementOutboundSetupIntentPayoutMethodDataBankAccount\"}]}}", isOptional: true)]
        public virtual object? BankAccountInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.V2MoneyManagementOutboundSetupIntent.IV2MoneyManagementOutboundSetupIntentPayoutMethodData" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.v2MoneyManagementOutboundSetupIntent.V2MoneyManagementOutboundSetupIntentPayoutMethodData\"}]}}", isOptional: true)]
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
                        case stripe.V2MoneyManagementOutboundSetupIntent.IV2MoneyManagementOutboundSetupIntentPayoutMethodData cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.V2MoneyManagementOutboundSetupIntent.IV2MoneyManagementOutboundSetupIntentPayoutMethodData).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
