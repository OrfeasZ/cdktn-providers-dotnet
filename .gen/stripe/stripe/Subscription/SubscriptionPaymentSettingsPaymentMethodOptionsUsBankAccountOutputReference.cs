using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiClass(nativeType: typeof(stripe.Subscription.SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountOutputReference), fullyQualifiedName: "stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFinancialConnections", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnections\"}}]")]
        public virtual void PutFinancialConnections(stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnections @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnections)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFinancialConnections")]
        public virtual void ResetFinancialConnections()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVerificationMethod")]
        public virtual void ResetVerificationMethod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "financialConnections", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsOutputReference\"}")]
        public virtual stripe.Subscription.SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsOutputReference FinancialConnections
        {
            get => GetInstanceProperty<stripe.Subscription.SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnections" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "financialConnectionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnections\"}]}}", isOptional: true)]
        public virtual object? FinancialConnectionsInput
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccount\"}]}}", isOptional: true)]
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
                        case stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccount cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
