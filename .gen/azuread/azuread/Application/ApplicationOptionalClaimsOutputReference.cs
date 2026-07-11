using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.Application
{
    [JsiiClass(nativeType: typeof(azuread.Application.ApplicationOptionalClaimsOutputReference), fullyQualifiedName: "azuread.application.ApplicationOptionalClaimsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApplicationOptionalClaimsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApplicationOptionalClaimsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ApplicationOptionalClaimsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApplicationOptionalClaimsOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.Application.IApplicationOptionalClaimsAccessToken" />)[]</param>
        [JsiiMethod(name: "putAccessToken", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.application.ApplicationOptionalClaimsAccessToken\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAccessToken(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azuread.Application.IApplicationOptionalClaimsAccessToken[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.Application.IApplicationOptionalClaimsAccessToken).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.Application.IApplicationOptionalClaimsAccessToken).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.Application.IApplicationOptionalClaimsIdToken" />)[]</param>
        [JsiiMethod(name: "putIdToken", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.application.ApplicationOptionalClaimsIdToken\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutIdToken(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azuread.Application.IApplicationOptionalClaimsIdToken[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.Application.IApplicationOptionalClaimsIdToken).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.Application.IApplicationOptionalClaimsIdToken).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.Application.IApplicationOptionalClaimsSaml2Token" />)[]</param>
        [JsiiMethod(name: "putSaml2Token", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.application.ApplicationOptionalClaimsSaml2Token\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSaml2Token(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azuread.Application.IApplicationOptionalClaimsSaml2Token[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.Application.IApplicationOptionalClaimsSaml2Token).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.Application.IApplicationOptionalClaimsSaml2Token).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccessToken")]
        public virtual void ResetAccessToken()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdToken")]
        public virtual void ResetIdToken()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSaml2Token")]
        public virtual void ResetSaml2Token()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "accessToken", typeJson: "{\"fqn\":\"azuread.application.ApplicationOptionalClaimsAccessTokenList\"}")]
        public virtual azuread.Application.ApplicationOptionalClaimsAccessTokenList AccessToken
        {
            get => GetInstanceProperty<azuread.Application.ApplicationOptionalClaimsAccessTokenList>()!;
        }

        [JsiiProperty(name: "idToken", typeJson: "{\"fqn\":\"azuread.application.ApplicationOptionalClaimsIdTokenList\"}")]
        public virtual azuread.Application.ApplicationOptionalClaimsIdTokenList IdToken
        {
            get => GetInstanceProperty<azuread.Application.ApplicationOptionalClaimsIdTokenList>()!;
        }

        [JsiiProperty(name: "saml2Token", typeJson: "{\"fqn\":\"azuread.application.ApplicationOptionalClaimsSaml2TokenList\"}")]
        public virtual azuread.Application.ApplicationOptionalClaimsSaml2TokenList Saml2Token
        {
            get => GetInstanceProperty<azuread.Application.ApplicationOptionalClaimsSaml2TokenList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.Application.IApplicationOptionalClaimsAccessToken" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accessTokenInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.application.ApplicationOptionalClaimsAccessToken\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AccessTokenInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.Application.IApplicationOptionalClaimsIdToken" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "idTokenInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.application.ApplicationOptionalClaimsIdToken\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? IdTokenInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.Application.IApplicationOptionalClaimsSaml2Token" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "saml2TokenInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.application.ApplicationOptionalClaimsSaml2Token\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? Saml2TokenInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azuread.application.ApplicationOptionalClaims\"}", isOptional: true)]
        public virtual azuread.Application.IApplicationOptionalClaims? InternalValue
        {
            get => GetInstanceProperty<azuread.Application.IApplicationOptionalClaims?>();
            set => SetInstanceProperty(value);
        }
    }
}
