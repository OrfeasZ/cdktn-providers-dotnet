using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDevicePostureIntegration
{
    [JsiiClass(nativeType: typeof(cloudflare.ZeroTrustDevicePostureIntegration.ZeroTrustDevicePostureIntegrationConfigAOutputReference), fullyQualifiedName: "cloudflare.zeroTrustDevicePostureIntegration.ZeroTrustDevicePostureIntegrationConfigAOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ZeroTrustDevicePostureIntegrationConfigAOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ZeroTrustDevicePostureIntegrationConfigAOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ZeroTrustDevicePostureIntegrationConfigAOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ZeroTrustDevicePostureIntegrationConfigAOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAccessClientId")]
        public virtual void ResetAccessClientId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAccessClientSecret")]
        public virtual void ResetAccessClientSecret()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetApiUrl")]
        public virtual void ResetApiUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthUrl")]
        public virtual void ResetAuthUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientId")]
        public virtual void ResetClientId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientKey")]
        public virtual void ResetClientKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientSecret")]
        public virtual void ResetClientSecret()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomerId")]
        public virtual void ResetCustomerId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessClientIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccessClientIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessClientSecretInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccessClientSecretInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApiUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientSecretInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientSecretInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customerIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomerIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "accessClientId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccessClientId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "accessClientSecret", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccessClientSecret
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "apiUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApiUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "authUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clientKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientSecret
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "customerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustDevicePostureIntegration.ZeroTrustDevicePostureIntegrationConfigA\"}]}}", isOptional: true)]
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
                        case cloudflare.ZeroTrustDevicePostureIntegration.IZeroTrustDevicePostureIntegrationConfigA cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustDevicePostureIntegration.IZeroTrustDevicePostureIntegrationConfigA).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
