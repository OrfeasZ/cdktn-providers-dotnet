using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    [JsiiClass(nativeType: typeof(cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppOutputReference), fullyQualifiedName: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ZeroTrustAccessApplicationSaasAppOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ZeroTrustAccessApplicationSaasAppOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ZeroTrustAccessApplicationSaasAppOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ZeroTrustAccessApplicationSaasAppOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCustomAttributes", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppCustomAttributes\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCustomAttributes(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationSaasAppCustomAttributes[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationSaasAppCustomAttributes).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationSaasAppCustomAttributes).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCustomClaims", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppCustomClaims\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCustomClaims(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationSaasAppCustomClaims[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationSaasAppCustomClaims).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationSaasAppCustomClaims).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHybridAndImplicitOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppHybridAndImplicitOptions\"}}]")]
        public virtual void PutHybridAndImplicitOptions(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationSaasAppHybridAndImplicitOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationSaasAppHybridAndImplicitOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRefreshTokenOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppRefreshTokenOptions\"}}]")]
        public virtual void PutRefreshTokenOptions(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationSaasAppRefreshTokenOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationSaasAppRefreshTokenOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccessTokenLifetime")]
        public virtual void ResetAccessTokenLifetime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAllowPkceWithoutClientSecret")]
        public virtual void ResetAllowPkceWithoutClientSecret()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAppLauncherUrl")]
        public virtual void ResetAppLauncherUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthType")]
        public virtual void ResetAuthType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConsumerServiceUrl")]
        public virtual void ResetConsumerServiceUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomAttributes")]
        public virtual void ResetCustomAttributes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomClaims")]
        public virtual void ResetCustomClaims()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultRelayState")]
        public virtual void ResetDefaultRelayState()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGrantTypes")]
        public virtual void ResetGrantTypes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGroupFilterRegex")]
        public virtual void ResetGroupFilterRegex()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHybridAndImplicitOptions")]
        public virtual void ResetHybridAndImplicitOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdpEntityId")]
        public virtual void ResetIdpEntityId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNameIdFormat")]
        public virtual void ResetNameIdFormat()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNameIdTransformJsonata")]
        public virtual void ResetNameIdTransformJsonata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRedirectUris")]
        public virtual void ResetRedirectUris()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRefreshTokenOptions")]
        public virtual void ResetRefreshTokenOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSamlAttributeTransformJsonata")]
        public virtual void ResetSamlAttributeTransformJsonata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScopes")]
        public virtual void ResetScopes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpEntityId")]
        public virtual void ResetSpEntityId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSsoEndpoint")]
        public virtual void ResetSsoEndpoint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientSecret
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customAttributes", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppCustomAttributesList\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppCustomAttributesList CustomAttributes
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppCustomAttributesList>()!;
        }

        [JsiiProperty(name: "customClaims", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppCustomClaimsList\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppCustomClaimsList CustomClaims
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppCustomClaimsList>()!;
        }

        [JsiiProperty(name: "hybridAndImplicitOptions", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppHybridAndImplicitOptionsOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppHybridAndImplicitOptionsOutputReference HybridAndImplicitOptions
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppHybridAndImplicitOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "publicKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "refreshTokenOptions", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppRefreshTokenOptionsOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppRefreshTokenOptionsOutputReference RefreshTokenOptions
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppRefreshTokenOptionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessTokenLifetimeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccessTokenLifetimeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowPkceWithoutClientSecretInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AllowPkceWithoutClientSecretInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "appLauncherUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AppLauncherUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "consumerServiceUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConsumerServiceUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customAttributesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppCustomAttributes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CustomAttributesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customClaimsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppCustomClaims\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CustomClaimsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultRelayStateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultRelayStateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "grantTypesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? GrantTypesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupFilterRegexInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GroupFilterRegexInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hybridAndImplicitOptionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppHybridAndImplicitOptions\"}]}}", isOptional: true)]
        public virtual object? HybridAndImplicitOptionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idpEntityIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdpEntityIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameIdFormatInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameIdFormatInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameIdTransformJsonataInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameIdTransformJsonataInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "redirectUrisInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? RedirectUrisInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "refreshTokenOptionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationSaasAppRefreshTokenOptions\"}]}}", isOptional: true)]
        public virtual object? RefreshTokenOptionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "samlAttributeTransformJsonataInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SamlAttributeTransformJsonataInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scopesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ScopesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spEntityIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SpEntityIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ssoEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SsoEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "accessTokenLifetime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccessTokenLifetime
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "allowPkceWithoutClientSecret", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object AllowPkceWithoutClientSecret
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

        [JsiiProperty(name: "appLauncherUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AppLauncherUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "authType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "consumerServiceUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConsumerServiceUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultRelayState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultRelayState
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "grantTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] GrantTypes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "groupFilterRegex", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GroupFilterRegex
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "idpEntityId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdpEntityId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nameIdFormat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameIdFormat
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nameIdTransformJsonata", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameIdTransformJsonata
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "redirectUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RedirectUris
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "samlAttributeTransformJsonata", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SamlAttributeTransformJsonata
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Scopes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "spEntityId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SpEntityId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ssoEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SsoEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationSaasApp\"}]}}", isOptional: true)]
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
                        case cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationSaasApp cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationSaasApp).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
