using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ThreeDSecureAuthentication
{
    [JsiiClass(nativeType: typeof(stripe.ThreeDSecureAuthentication.ThreeDSecureAuthenticationAcquirerDetailsOutputReference), fullyQualifiedName: "stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationAcquirerDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ThreeDSecureAuthenticationAcquirerDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ThreeDSecureAuthenticationAcquirerDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ThreeDSecureAuthenticationAcquirerDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ThreeDSecureAuthenticationAcquirerDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetMcc")]
        public virtual void ResetMcc()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMerchantName")]
        public virtual void ResetMerchantName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequestorId")]
        public virtual void ResetRequestorId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "acquirerBinInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AcquirerBinInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "acquirerCountryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AcquirerCountryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "acquirerMerchantIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AcquirerMerchantIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mccInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MccInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "merchantNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MerchantNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestorIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RequestorIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "acquirerBin", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AcquirerBin
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "acquirerCountry", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AcquirerCountry
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "acquirerMerchantId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AcquirerMerchantId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mcc", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Mcc
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "merchantName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MerchantName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requestorId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestorId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationAcquirerDetails" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationAcquirerDetails\"}]}}", isOptional: true)]
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
                        case stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationAcquirerDetails cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationAcquirerDetails).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
