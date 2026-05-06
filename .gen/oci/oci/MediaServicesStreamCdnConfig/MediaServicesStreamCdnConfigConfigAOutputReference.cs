using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MediaServicesStreamCdnConfig
{
    [JsiiClass(nativeType: typeof(oci.MediaServicesStreamCdnConfig.MediaServicesStreamCdnConfigConfigAOutputReference), fullyQualifiedName: "oci.mediaServicesStreamCdnConfig.MediaServicesStreamCdnConfigConfigAOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MediaServicesStreamCdnConfigConfigAOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MediaServicesStreamCdnConfigConfigAOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MediaServicesStreamCdnConfigConfigAOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MediaServicesStreamCdnConfigConfigAOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetEdgeHostname")]
        public virtual void ResetEdgeHostname()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEdgePathPrefix")]
        public virtual void ResetEdgePathPrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEdgeTokenKey")]
        public virtual void ResetEdgeTokenKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEdgeTokenSalt")]
        public virtual void ResetEdgeTokenSalt()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsEdgeTokenAuth")]
        public virtual void ResetIsEdgeTokenAuth()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOriginAuthSecretKeyA")]
        public virtual void ResetOriginAuthSecretKeyA()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOriginAuthSecretKeyB")]
        public virtual void ResetOriginAuthSecretKeyB()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOriginAuthSecretKeyNonceA")]
        public virtual void ResetOriginAuthSecretKeyNonceA()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOriginAuthSecretKeyNonceB")]
        public virtual void ResetOriginAuthSecretKeyNonceB()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOriginAuthSignEncryption")]
        public virtual void ResetOriginAuthSignEncryption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOriginAuthSignType")]
        public virtual void ResetOriginAuthSignType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "edgeHostnameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EdgeHostnameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "edgePathPrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EdgePathPrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "edgeTokenKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EdgeTokenKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "edgeTokenSaltInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EdgeTokenSaltInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isEdgeTokenAuthInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsEdgeTokenAuthInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "originAuthSecretKeyAInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OriginAuthSecretKeyAInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "originAuthSecretKeyBInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OriginAuthSecretKeyBInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "originAuthSecretKeyNonceAInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OriginAuthSecretKeyNonceAInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "originAuthSecretKeyNonceBInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OriginAuthSecretKeyNonceBInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "originAuthSignEncryptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OriginAuthSignEncryptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "originAuthSignTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OriginAuthSignTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "edgeHostname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EdgeHostname
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "edgePathPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EdgePathPrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "edgeTokenKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EdgeTokenKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "edgeTokenSalt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EdgeTokenSalt
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isEdgeTokenAuth", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsEdgeTokenAuth
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "originAuthSecretKeyA", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OriginAuthSecretKeyA
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "originAuthSecretKeyB", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OriginAuthSecretKeyB
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "originAuthSecretKeyNonceA", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OriginAuthSecretKeyNonceA
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "originAuthSecretKeyNonceB", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OriginAuthSecretKeyNonceB
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "originAuthSignEncryption", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OriginAuthSignEncryption
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "originAuthSignType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OriginAuthSignType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.mediaServicesStreamCdnConfig.MediaServicesStreamCdnConfigConfigA\"}", isOptional: true)]
        public virtual oci.MediaServicesStreamCdnConfig.IMediaServicesStreamCdnConfigConfigA? InternalValue
        {
            get => GetInstanceProperty<oci.MediaServicesStreamCdnConfig.IMediaServicesStreamCdnConfigConfigA?>();
            set => SetInstanceProperty(value);
        }
    }
}
