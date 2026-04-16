using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreOauth2CredentialProvider
{
    [JsiiClass(nativeType: typeof(aws.BedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigOutputReference), fullyQualifiedName: "aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetClientCredentialsWoVersion")]
        public virtual void ResetClientCredentialsWoVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientId")]
        public virtual void ResetClientId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientIdWo")]
        public virtual void ResetClientIdWo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientSecret")]
        public virtual void ResetClientSecret()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientSecretWo")]
        public virtual void ResetClientSecretWo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "oauthDiscovery", typeJson: "{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigOauthDiscoveryList\"}")]
        public virtual aws.BedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigOauthDiscoveryList OauthDiscovery
        {
            get => GetInstanceProperty<aws.BedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigOauthDiscoveryList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientCredentialsWoVersionInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ClientCredentialsWoVersionInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientIdWoInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientIdWoInput
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
        [JsiiProperty(name: "clientSecretWoInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientSecretWoInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "clientCredentialsWoVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ClientCredentialsWoVersion
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clientIdWo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientIdWo
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

        [JsiiProperty(name: "clientSecretWo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientSecretWo
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfig\"}]}}", isOptional: true)]
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
                        case aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfig cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfig).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
