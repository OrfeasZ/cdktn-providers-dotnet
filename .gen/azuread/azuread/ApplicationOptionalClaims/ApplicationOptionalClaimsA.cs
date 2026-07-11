using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ApplicationOptionalClaims
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_optional_claims azuread_application_optional_claims}.</summary>
    [JsiiClass(nativeType: typeof(azuread.ApplicationOptionalClaims.ApplicationOptionalClaimsA), fullyQualifiedName: "azuread.applicationOptionalClaims.ApplicationOptionalClaimsA", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azuread.applicationOptionalClaims.ApplicationOptionalClaimsAConfig\"}}]")]
    public class ApplicationOptionalClaimsA : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_optional_claims azuread_application_optional_claims} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ApplicationOptionalClaimsA(Constructs.Construct scope, string id, azuread.ApplicationOptionalClaims.IApplicationOptionalClaimsAConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azuread.ApplicationOptionalClaims.IApplicationOptionalClaimsAConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApplicationOptionalClaimsA(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApplicationOptionalClaimsA(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a ApplicationOptionalClaimsA resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ApplicationOptionalClaimsA to import.</param>
        /// <param name="importFromId">The id of the existing ApplicationOptionalClaimsA that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ApplicationOptionalClaimsA to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ApplicationOptionalClaimsA to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_optional_claims#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ApplicationOptionalClaimsA that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ApplicationOptionalClaimsA to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azuread.ApplicationOptionalClaims.ApplicationOptionalClaimsA), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.ApplicationOptionalClaims.IApplicationOptionalClaimsAccessTokenA" />)[]</param>
        [JsiiMethod(name: "putAccessToken", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.applicationOptionalClaims.ApplicationOptionalClaimsAccessTokenA\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAccessToken(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azuread.ApplicationOptionalClaims.IApplicationOptionalClaimsAccessTokenA[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.ApplicationOptionalClaims.IApplicationOptionalClaimsAccessTokenA).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.ApplicationOptionalClaims.IApplicationOptionalClaimsAccessTokenA).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.ApplicationOptionalClaims.IApplicationOptionalClaimsIdTokenA" />)[]</param>
        [JsiiMethod(name: "putIdToken", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.applicationOptionalClaims.ApplicationOptionalClaimsIdTokenA\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutIdToken(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azuread.ApplicationOptionalClaims.IApplicationOptionalClaimsIdTokenA[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.ApplicationOptionalClaims.IApplicationOptionalClaimsIdTokenA).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.ApplicationOptionalClaims.IApplicationOptionalClaimsIdTokenA).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.ApplicationOptionalClaims.IApplicationOptionalClaimsSaml2TokenA" />)[]</param>
        [JsiiMethod(name: "putSaml2Token", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.applicationOptionalClaims.ApplicationOptionalClaimsSaml2TokenA\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSaml2Token(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azuread.ApplicationOptionalClaims.IApplicationOptionalClaimsSaml2TokenA[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.ApplicationOptionalClaims.IApplicationOptionalClaimsSaml2TokenA).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.ApplicationOptionalClaims.IApplicationOptionalClaimsSaml2TokenA).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.applicationOptionalClaims.ApplicationOptionalClaimsTimeouts\"}}]")]
        public virtual void PutTimeouts(azuread.ApplicationOptionalClaims.IApplicationOptionalClaimsTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.ApplicationOptionalClaims.IApplicationOptionalClaimsTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccessToken")]
        public virtual void ResetAccessToken()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(azuread.ApplicationOptionalClaims.ApplicationOptionalClaimsA))!;

        [JsiiProperty(name: "accessToken", typeJson: "{\"fqn\":\"azuread.applicationOptionalClaims.ApplicationOptionalClaimsAccessTokenAList\"}")]
        public virtual azuread.ApplicationOptionalClaims.ApplicationOptionalClaimsAccessTokenAList AccessToken
        {
            get => GetInstanceProperty<azuread.ApplicationOptionalClaims.ApplicationOptionalClaimsAccessTokenAList>()!;
        }

        [JsiiProperty(name: "idToken", typeJson: "{\"fqn\":\"azuread.applicationOptionalClaims.ApplicationOptionalClaimsIdTokenAList\"}")]
        public virtual azuread.ApplicationOptionalClaims.ApplicationOptionalClaimsIdTokenAList IdToken
        {
            get => GetInstanceProperty<azuread.ApplicationOptionalClaims.ApplicationOptionalClaimsIdTokenAList>()!;
        }

        [JsiiProperty(name: "saml2Token", typeJson: "{\"fqn\":\"azuread.applicationOptionalClaims.ApplicationOptionalClaimsSaml2TokenAList\"}")]
        public virtual azuread.ApplicationOptionalClaims.ApplicationOptionalClaimsSaml2TokenAList Saml2Token
        {
            get => GetInstanceProperty<azuread.ApplicationOptionalClaims.ApplicationOptionalClaimsSaml2TokenAList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.applicationOptionalClaims.ApplicationOptionalClaimsTimeoutsOutputReference\"}")]
        public virtual azuread.ApplicationOptionalClaims.ApplicationOptionalClaimsTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azuread.ApplicationOptionalClaims.ApplicationOptionalClaimsTimeoutsOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.ApplicationOptionalClaims.IApplicationOptionalClaimsAccessTokenA" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accessTokenInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.applicationOptionalClaims.ApplicationOptionalClaimsAccessTokenA\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AccessTokenInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApplicationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.ApplicationOptionalClaims.IApplicationOptionalClaimsIdTokenA" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "idTokenInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.applicationOptionalClaims.ApplicationOptionalClaimsIdTokenA\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? IdTokenInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.ApplicationOptionalClaims.IApplicationOptionalClaimsSaml2TokenA" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "saml2TokenInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.applicationOptionalClaims.ApplicationOptionalClaimsSaml2TokenA\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? Saml2TokenInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azuread.ApplicationOptionalClaims.IApplicationOptionalClaimsTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azuread.applicationOptionalClaims.ApplicationOptionalClaimsTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "applicationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
