using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ThreeDSecureAuthentication
{
    [JsiiClass(nativeType: typeof(stripe.ThreeDSecureAuthentication.ThreeDSecureAuthenticationPaymentMethodDataOutputReference), fullyQualifiedName: "stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationPaymentMethodDataOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ThreeDSecureAuthenticationPaymentMethodDataOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ThreeDSecureAuthenticationPaymentMethodDataOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ThreeDSecureAuthenticationPaymentMethodDataOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ThreeDSecureAuthenticationPaymentMethodDataOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBillingDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationPaymentMethodDataBillingDetails\"}}]")]
        public virtual void PutBillingDetails(stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationPaymentMethodDataBillingDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationPaymentMethodDataBillingDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCard", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationPaymentMethodDataCard\"}}]")]
        public virtual void PutCard(stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationPaymentMethodDataCard @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationPaymentMethodDataCard)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBillingDetails")]
        public virtual void ResetBillingDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "billingDetails", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationPaymentMethodDataBillingDetailsOutputReference\"}")]
        public virtual stripe.ThreeDSecureAuthentication.ThreeDSecureAuthenticationPaymentMethodDataBillingDetailsOutputReference BillingDetails
        {
            get => GetInstanceProperty<stripe.ThreeDSecureAuthentication.ThreeDSecureAuthenticationPaymentMethodDataBillingDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "card", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationPaymentMethodDataCardOutputReference\"}")]
        public virtual stripe.ThreeDSecureAuthentication.ThreeDSecureAuthenticationPaymentMethodDataCardOutputReference Card
        {
            get => GetInstanceProperty<stripe.ThreeDSecureAuthentication.ThreeDSecureAuthenticationPaymentMethodDataCardOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationPaymentMethodDataBillingDetails" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "billingDetailsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationPaymentMethodDataBillingDetails\"}]}}", isOptional: true)]
        public virtual object? BillingDetailsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationPaymentMethodDataCard" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cardInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationPaymentMethodDataCard\"}]}}", isOptional: true)]
        public virtual object? CardInput
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationPaymentMethodData" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationPaymentMethodData\"}]}}", isOptional: true)]
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
                        case stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationPaymentMethodData cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationPaymentMethodData).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
