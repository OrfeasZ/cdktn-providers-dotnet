using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.Application
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application azuread_application}.</summary>
    [JsiiClass(nativeType: typeof(azuread.Application.Application), fullyQualifiedName: "azuread.application.Application", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azuread.application.ApplicationConfig\"}}]")]
    public class Application : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application azuread_application} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Application(Constructs.Construct scope, string id, azuread.Application.IApplicationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azuread.Application.IApplicationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Application(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Application(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a Application resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the Application to import.</param>
        /// <param name="importFromId">The id of the existing Application that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the Application to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the Application to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing Application that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the Application to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azuread.Application.Application), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putApi", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.application.ApplicationApi\"}}]")]
        public virtual void PutApi(azuread.Application.IApplicationApi @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.Application.IApplicationApi)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.Application.IApplicationAppRole" />)[]</param>
        [JsiiMethod(name: "putAppRole", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.application.ApplicationAppRole\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAppRole(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azuread.Application.IApplicationAppRole[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.Application.IApplicationAppRole).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.Application.IApplicationAppRole).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.Application.IApplicationFeatureTags" />)[]</param>
        [JsiiMethod(name: "putFeatureTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.application.ApplicationFeatureTags\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFeatureTags(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azuread.Application.IApplicationFeatureTags[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.Application.IApplicationFeatureTags).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.Application.IApplicationFeatureTags).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOptionalClaims", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.application.ApplicationOptionalClaims\"}}]")]
        public virtual void PutOptionalClaims(azuread.Application.IApplicationOptionalClaims @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.Application.IApplicationOptionalClaims)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPassword", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.application.ApplicationPassword\"}}]")]
        public virtual void PutPassword(azuread.Application.IApplicationPassword @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.Application.IApplicationPassword)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPublicClient", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.application.ApplicationPublicClient\"}}]")]
        public virtual void PutPublicClient(azuread.Application.IApplicationPublicClient @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.Application.IApplicationPublicClient)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.Application.IApplicationRequiredResourceAccess" />)[]</param>
        [JsiiMethod(name: "putRequiredResourceAccess", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.application.ApplicationRequiredResourceAccess\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRequiredResourceAccess(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azuread.Application.IApplicationRequiredResourceAccess[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.Application.IApplicationRequiredResourceAccess).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.Application.IApplicationRequiredResourceAccess).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSinglePageApplication", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.application.ApplicationSinglePageApplication\"}}]")]
        public virtual void PutSinglePageApplication(azuread.Application.IApplicationSinglePageApplication @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.Application.IApplicationSinglePageApplication)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.application.ApplicationTimeouts\"}}]")]
        public virtual void PutTimeouts(azuread.Application.IApplicationTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.Application.IApplicationTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWeb", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.application.ApplicationWeb\"}}]")]
        public virtual void PutWeb(azuread.Application.IApplicationWeb @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.Application.IApplicationWeb)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApi")]
        public virtual void ResetApi()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAppRole")]
        public virtual void ResetAppRole()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeviceOnlyAuthEnabled")]
        public virtual void ResetDeviceOnlyAuthEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFallbackPublicClientEnabled")]
        public virtual void ResetFallbackPublicClientEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFeatureTags")]
        public virtual void ResetFeatureTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGroupMembershipClaims")]
        public virtual void ResetGroupMembershipClaims()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdentifierUris")]
        public virtual void ResetIdentifierUris()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogoImage")]
        public virtual void ResetLogoImage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMarketingUrl")]
        public virtual void ResetMarketingUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNotes")]
        public virtual void ResetNotes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOauth2PostResponseRequired")]
        public virtual void ResetOauth2PostResponseRequired()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOptionalClaims")]
        public virtual void ResetOptionalClaims()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOwners")]
        public virtual void ResetOwners()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPassword")]
        public virtual void ResetPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPreventDuplicateNames")]
        public virtual void ResetPreventDuplicateNames()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivacyStatementUrl")]
        public virtual void ResetPrivacyStatementUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPublicClient")]
        public virtual void ResetPublicClient()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequiredResourceAccess")]
        public virtual void ResetRequiredResourceAccess()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceManagementReference")]
        public virtual void ResetServiceManagementReference()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSignInAudience")]
        public virtual void ResetSignInAudience()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSinglePageApplication")]
        public virtual void ResetSinglePageApplication()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSupportUrl")]
        public virtual void ResetSupportUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTemplateId")]
        public virtual void ResetTemplateId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTermsOfServiceUrl")]
        public virtual void ResetTermsOfServiceUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWeb")]
        public virtual void ResetWeb()
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
        = GetStaticProperty<string>(typeof(azuread.Application.Application))!;

        [JsiiProperty(name: "api", typeJson: "{\"fqn\":\"azuread.application.ApplicationApiOutputReference\"}")]
        public virtual azuread.Application.ApplicationApiOutputReference Api
        {
            get => GetInstanceProperty<azuread.Application.ApplicationApiOutputReference>()!;
        }

        [JsiiProperty(name: "appRole", typeJson: "{\"fqn\":\"azuread.application.ApplicationAppRoleList\"}")]
        public virtual azuread.Application.ApplicationAppRoleList AppRole
        {
            get => GetInstanceProperty<azuread.Application.ApplicationAppRoleList>()!;
        }

        [JsiiProperty(name: "appRoleIds", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap AppRoleIds
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "disabledByMicrosoft", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisabledByMicrosoft
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "featureTags", typeJson: "{\"fqn\":\"azuread.application.ApplicationFeatureTagsList\"}")]
        public virtual azuread.Application.ApplicationFeatureTagsList FeatureTags
        {
            get => GetInstanceProperty<azuread.Application.ApplicationFeatureTagsList>()!;
        }

        [JsiiProperty(name: "logoUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogoUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "oauth2PermissionScopeIds", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Oauth2PermissionScopeIds
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "objectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "optionalClaims", typeJson: "{\"fqn\":\"azuread.application.ApplicationOptionalClaimsOutputReference\"}")]
        public virtual azuread.Application.ApplicationOptionalClaimsOutputReference OptionalClaims
        {
            get => GetInstanceProperty<azuread.Application.ApplicationOptionalClaimsOutputReference>()!;
        }

        [JsiiProperty(name: "password", typeJson: "{\"fqn\":\"azuread.application.ApplicationPasswordOutputReference\"}")]
        public virtual azuread.Application.ApplicationPasswordOutputReference Password
        {
            get => GetInstanceProperty<azuread.Application.ApplicationPasswordOutputReference>()!;
        }

        [JsiiProperty(name: "publicClient", typeJson: "{\"fqn\":\"azuread.application.ApplicationPublicClientOutputReference\"}")]
        public virtual azuread.Application.ApplicationPublicClientOutputReference PublicClient
        {
            get => GetInstanceProperty<azuread.Application.ApplicationPublicClientOutputReference>()!;
        }

        [JsiiProperty(name: "publisherDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublisherDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requiredResourceAccess", typeJson: "{\"fqn\":\"azuread.application.ApplicationRequiredResourceAccessList\"}")]
        public virtual azuread.Application.ApplicationRequiredResourceAccessList RequiredResourceAccess
        {
            get => GetInstanceProperty<azuread.Application.ApplicationRequiredResourceAccessList>()!;
        }

        [JsiiProperty(name: "singlePageApplication", typeJson: "{\"fqn\":\"azuread.application.ApplicationSinglePageApplicationOutputReference\"}")]
        public virtual azuread.Application.ApplicationSinglePageApplicationOutputReference SinglePageApplication
        {
            get => GetInstanceProperty<azuread.Application.ApplicationSinglePageApplicationOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.application.ApplicationTimeoutsOutputReference\"}")]
        public virtual azuread.Application.ApplicationTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azuread.Application.ApplicationTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "web", typeJson: "{\"fqn\":\"azuread.application.ApplicationWebOutputReference\"}")]
        public virtual azuread.Application.ApplicationWebOutputReference Web
        {
            get => GetInstanceProperty<azuread.Application.ApplicationWebOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiInput", typeJson: "{\"fqn\":\"azuread.application.ApplicationApi\"}", isOptional: true)]
        public virtual azuread.Application.IApplicationApi? ApiInput
        {
            get => GetInstanceProperty<azuread.Application.IApplicationApi?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.Application.IApplicationAppRole" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "appRoleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.application.ApplicationAppRole\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AppRoleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deviceOnlyAuthEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DeviceOnlyAuthEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fallbackPublicClientEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? FallbackPublicClientEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.Application.IApplicationFeatureTags" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "featureTagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.application.ApplicationFeatureTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FeatureTagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupMembershipClaimsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? GroupMembershipClaimsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identifierUrisInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? IdentifierUrisInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logoImageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogoImageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "marketingUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MarketingUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "notesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NotesInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oauth2PostResponseRequiredInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? Oauth2PostResponseRequiredInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "optionalClaimsInput", typeJson: "{\"fqn\":\"azuread.application.ApplicationOptionalClaims\"}", isOptional: true)]
        public virtual azuread.Application.IApplicationOptionalClaims? OptionalClaimsInput
        {
            get => GetInstanceProperty<azuread.Application.IApplicationOptionalClaims?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ownersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? OwnersInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "passwordInput", typeJson: "{\"fqn\":\"azuread.application.ApplicationPassword\"}", isOptional: true)]
        public virtual azuread.Application.IApplicationPassword? PasswordInput
        {
            get => GetInstanceProperty<azuread.Application.IApplicationPassword?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "preventDuplicateNamesInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? PreventDuplicateNamesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privacyStatementUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrivacyStatementUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publicClientInput", typeJson: "{\"fqn\":\"azuread.application.ApplicationPublicClient\"}", isOptional: true)]
        public virtual azuread.Application.IApplicationPublicClient? PublicClientInput
        {
            get => GetInstanceProperty<azuread.Application.IApplicationPublicClient?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.Application.IApplicationRequiredResourceAccess" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requiredResourceAccessInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.application.ApplicationRequiredResourceAccess\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RequiredResourceAccessInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceManagementReferenceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceManagementReferenceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "signInAudienceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SignInAudienceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "singlePageApplicationInput", typeJson: "{\"fqn\":\"azuread.application.ApplicationSinglePageApplication\"}", isOptional: true)]
        public virtual azuread.Application.IApplicationSinglePageApplication? SinglePageApplicationInput
        {
            get => GetInstanceProperty<azuread.Application.IApplicationSinglePageApplication?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "supportUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SupportUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? TagsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "templateIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TemplateIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "termsOfServiceUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TermsOfServiceUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azuread.Application.IApplicationTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azuread.application.ApplicationTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "webInput", typeJson: "{\"fqn\":\"azuread.application.ApplicationWeb\"}", isOptional: true)]
        public virtual azuread.Application.IApplicationWeb? WebInput
        {
            get => GetInstanceProperty<azuread.Application.IApplicationWeb?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "deviceOnlyAuthEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object DeviceOnlyAuthEnabled
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

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "fallbackPublicClientEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object FallbackPublicClientEnabled
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

        [JsiiProperty(name: "groupMembershipClaims", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] GroupMembershipClaims
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "identifierUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IdentifierUris
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logoImage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogoImage
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "marketingUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MarketingUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "notes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Notes
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "oauth2PostResponseRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Oauth2PostResponseRequired
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

        [JsiiProperty(name: "owners", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Owners
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "preventDuplicateNames", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object PreventDuplicateNames
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

        [JsiiProperty(name: "privacyStatementUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivacyStatementUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceManagementReference", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceManagementReference
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "signInAudience", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SignInAudience
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "supportUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SupportUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tags
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "templateId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TemplateId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "termsOfServiceUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TermsOfServiceUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
