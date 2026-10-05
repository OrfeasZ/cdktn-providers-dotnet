using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustCasbIntegration
{
    [JsiiClass(nativeType: typeof(cloudflare.ZeroTrustCasbIntegration.ZeroTrustCasbIntegrationGoogleWorkspaceOutputReference), fullyQualifiedName: "cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationGoogleWorkspaceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ZeroTrustCasbIntegrationGoogleWorkspaceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ZeroTrustCasbIntegrationGoogleWorkspaceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ZeroTrustCasbIntegrationGoogleWorkspaceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ZeroTrustCasbIntegrationGoogleWorkspaceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putGoogleDomainWideDelegationServiceAccount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationGoogleWorkspaceGoogleDomainWideDelegationServiceAccount\"}}]")]
        public virtual void PutGoogleDomainWideDelegationServiceAccount(cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationGoogleWorkspaceGoogleDomainWideDelegationServiceAccount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationGoogleWorkspaceGoogleDomainWideDelegationServiceAccount)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetGoogleDomainWideDelegationServiceAccount")]
        public virtual void ResetGoogleDomainWideDelegationServiceAccount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "googleDomainWideDelegationServiceAccount", typeJson: "{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationGoogleWorkspaceGoogleDomainWideDelegationServiceAccountOutputReference\"}")]
        public virtual cloudflare.ZeroTrustCasbIntegration.ZeroTrustCasbIntegrationGoogleWorkspaceGoogleDomainWideDelegationServiceAccountOutputReference GoogleDomainWideDelegationServiceAccount
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustCasbIntegration.ZeroTrustCasbIntegrationGoogleWorkspaceGoogleDomainWideDelegationServiceAccountOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationGoogleWorkspaceGoogleDomainWideDelegationServiceAccount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "googleDomainWideDelegationServiceAccountInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationGoogleWorkspaceGoogleDomainWideDelegationServiceAccount\"}]}}", isOptional: true)]
        public virtual object? GoogleDomainWideDelegationServiceAccountInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationGoogleWorkspace" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationGoogleWorkspace\"}]}}", isOptional: true)]
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
                        case cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationGoogleWorkspace cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationGoogleWorkspace).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
