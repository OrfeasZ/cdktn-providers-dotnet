using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustCasbIntegration
{
    [JsiiClass(nativeType: typeof(cloudflare.ZeroTrustCasbIntegration.ZeroTrustCasbIntegrationOpenaiOutputReference), fullyQualifiedName: "cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationOpenaiOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ZeroTrustCasbIntegrationOpenaiOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ZeroTrustCasbIntegrationOpenaiOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ZeroTrustCasbIntegrationOpenaiOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ZeroTrustCasbIntegrationOpenaiOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putChatgptComplianceApiKey", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationOpenaiChatgptComplianceApiKey\"}}]")]
        public virtual void PutChatgptComplianceApiKey(cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationOpenaiChatgptComplianceApiKey @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationOpenaiChatgptComplianceApiKey)}, new object[]{@value});
        }

        [JsiiMethod(name: "putChatgptStandardApiKey", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationOpenaiChatgptStandardApiKey\"}}]")]
        public virtual void PutChatgptStandardApiKey(cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationOpenaiChatgptStandardApiKey @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationOpenaiChatgptStandardApiKey)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetChatgptComplianceApiKey")]
        public virtual void ResetChatgptComplianceApiKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetChatgptStandardApiKey")]
        public virtual void ResetChatgptStandardApiKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "chatgptComplianceApiKey", typeJson: "{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationOpenaiChatgptComplianceApiKeyOutputReference\"}")]
        public virtual cloudflare.ZeroTrustCasbIntegration.ZeroTrustCasbIntegrationOpenaiChatgptComplianceApiKeyOutputReference ChatgptComplianceApiKey
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustCasbIntegration.ZeroTrustCasbIntegrationOpenaiChatgptComplianceApiKeyOutputReference>()!;
        }

        [JsiiProperty(name: "chatgptStandardApiKey", typeJson: "{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationOpenaiChatgptStandardApiKeyOutputReference\"}")]
        public virtual cloudflare.ZeroTrustCasbIntegration.ZeroTrustCasbIntegrationOpenaiChatgptStandardApiKeyOutputReference ChatgptStandardApiKey
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustCasbIntegration.ZeroTrustCasbIntegrationOpenaiChatgptStandardApiKeyOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationOpenaiChatgptComplianceApiKey" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "chatgptComplianceApiKeyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationOpenaiChatgptComplianceApiKey\"}]}}", isOptional: true)]
        public virtual object? ChatgptComplianceApiKeyInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationOpenaiChatgptStandardApiKey" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "chatgptStandardApiKeyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationOpenaiChatgptStandardApiKey\"}]}}", isOptional: true)]
        public virtual object? ChatgptStandardApiKeyInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationOpenai" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationOpenai\"}]}}", isOptional: true)]
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
                        case cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationOpenai cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationOpenai).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
