using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsIdentitySetting
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_setting oci_identity_domains_identity_setting}.</summary>
    [JsiiClass(nativeType: typeof(oci.IdentityDomainsIdentitySetting.IdentityDomainsIdentitySetting), fullyQualifiedName: "oci.identityDomainsIdentitySetting.IdentityDomainsIdentitySetting", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.identityDomainsIdentitySetting.IdentityDomainsIdentitySettingConfig\"}}]")]
    public class IdentityDomainsIdentitySetting : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_setting oci_identity_domains_identity_setting} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public IdentityDomainsIdentitySetting(Constructs.Construct scope, string id, oci.IdentityDomainsIdentitySetting.IIdentityDomainsIdentitySettingConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.IdentityDomainsIdentitySetting.IIdentityDomainsIdentitySettingConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IdentityDomainsIdentitySetting(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IdentityDomainsIdentitySetting(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a IdentityDomainsIdentitySetting resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the IdentityDomainsIdentitySetting to import.</param>
        /// <param name="importFromId">The id of the existing IdentityDomainsIdentitySetting that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the IdentityDomainsIdentitySetting to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the IdentityDomainsIdentitySetting to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_setting#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing IdentityDomainsIdentitySetting that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the IdentityDomainsIdentitySetting to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.IdentityDomainsIdentitySetting.IdentityDomainsIdentitySetting), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putMyProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsIdentitySetting.IdentityDomainsIdentitySettingMyProfile\"}}]")]
        public virtual void PutMyProfile(oci.IdentityDomainsIdentitySetting.IIdentityDomainsIdentitySettingMyProfile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsIdentitySetting.IIdentityDomainsIdentitySettingMyProfile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPosixGid", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsIdentitySetting.IdentityDomainsIdentitySettingPosixGid\"}}]")]
        public virtual void PutPosixGid(oci.IdentityDomainsIdentitySetting.IIdentityDomainsIdentitySettingPosixGid @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsIdentitySetting.IIdentityDomainsIdentitySettingPosixGid)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPosixUid", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsIdentitySetting.IdentityDomainsIdentitySettingPosixUid\"}}]")]
        public virtual void PutPosixUid(oci.IdentityDomainsIdentitySetting.IIdentityDomainsIdentitySettingPosixUid @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsIdentitySetting.IIdentityDomainsIdentitySettingPosixUid)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsIdentitySetting.IdentityDomainsIdentitySettingTags\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTags(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.IdentityDomainsIdentitySetting.IIdentityDomainsIdentitySettingTags[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsIdentitySetting.IIdentityDomainsIdentitySettingTags).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsIdentitySetting.IIdentityDomainsIdentitySettingTags).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsIdentitySetting.IdentityDomainsIdentitySettingTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.IdentityDomainsIdentitySetting.IIdentityDomainsIdentitySettingTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsIdentitySetting.IIdentityDomainsIdentitySettingTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTokens", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsIdentitySetting.IdentityDomainsIdentitySettingTokens\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTokens(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.IdentityDomainsIdentitySetting.IIdentityDomainsIdentitySettingTokens[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsIdentitySetting.IIdentityDomainsIdentitySettingTokens).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsIdentitySetting.IIdentityDomainsIdentitySettingTokens).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAttributes")]
        public virtual void ResetAttributes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAttributeSets")]
        public virtual void ResetAttributeSets()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthorization")]
        public virtual void ResetAuthorization()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmitLockedMessageWhenUserIsLocked")]
        public virtual void ResetEmitLockedMessageWhenUserIsLocked()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExternalId")]
        public virtual void ResetExternalId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMyProfile")]
        public virtual void ResetMyProfile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOcid")]
        public virtual void ResetOcid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPosixGid")]
        public virtual void ResetPosixGid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPosixUid")]
        public virtual void ResetPosixUid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrimaryEmailRequired")]
        public virtual void ResetPrimaryEmailRequired()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceTypeSchemaVersion")]
        public virtual void ResetResourceTypeSchemaVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReturnInactiveOverLockedMessage")]
        public virtual void ResetReturnInactiveOverLockedMessage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTokens")]
        public virtual void ResetTokens()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserAllowedToSetRecoveryEmail")]
        public virtual void ResetUserAllowedToSetRecoveryEmail()
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
        = GetStaticProperty<string>(typeof(oci.IdentityDomainsIdentitySetting.IdentityDomainsIdentitySetting))!;

        [JsiiProperty(name: "compartmentOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deleteInProgress", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DeleteInProgress
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "domainOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.identityDomainsIdentitySetting.IdentityDomainsIdentitySettingIdcsCreatedByList\"}")]
        public virtual oci.IdentityDomainsIdentitySetting.IdentityDomainsIdentitySettingIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.IdentityDomainsIdentitySetting.IdentityDomainsIdentitySettingIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.identityDomainsIdentitySetting.IdentityDomainsIdentitySettingIdcsLastModifiedByList\"}")]
        public virtual oci.IdentityDomainsIdentitySetting.IdentityDomainsIdentitySettingIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.IdentityDomainsIdentitySetting.IdentityDomainsIdentitySettingIdcsLastModifiedByList>()!;
        }

        [JsiiProperty(name: "idcsLastUpgradedInRelease", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsLastUpgradedInRelease
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsPreventedOperations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IdcsPreventedOperations
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.identityDomainsIdentitySetting.IdentityDomainsIdentitySettingMetaList\"}")]
        public virtual oci.IdentityDomainsIdentitySetting.IdentityDomainsIdentitySettingMetaList Meta
        {
            get => GetInstanceProperty<oci.IdentityDomainsIdentitySetting.IdentityDomainsIdentitySettingMetaList>()!;
        }

        [JsiiProperty(name: "myProfile", typeJson: "{\"fqn\":\"oci.identityDomainsIdentitySetting.IdentityDomainsIdentitySettingMyProfileOutputReference\"}")]
        public virtual oci.IdentityDomainsIdentitySetting.IdentityDomainsIdentitySettingMyProfileOutputReference MyProfile
        {
            get => GetInstanceProperty<oci.IdentityDomainsIdentitySetting.IdentityDomainsIdentitySettingMyProfileOutputReference>()!;
        }

        [JsiiProperty(name: "posixGid", typeJson: "{\"fqn\":\"oci.identityDomainsIdentitySetting.IdentityDomainsIdentitySettingPosixGidOutputReference\"}")]
        public virtual oci.IdentityDomainsIdentitySetting.IdentityDomainsIdentitySettingPosixGidOutputReference PosixGid
        {
            get => GetInstanceProperty<oci.IdentityDomainsIdentitySetting.IdentityDomainsIdentitySettingPosixGidOutputReference>()!;
        }

        [JsiiProperty(name: "posixUid", typeJson: "{\"fqn\":\"oci.identityDomainsIdentitySetting.IdentityDomainsIdentitySettingPosixUidOutputReference\"}")]
        public virtual oci.IdentityDomainsIdentitySetting.IdentityDomainsIdentitySettingPosixUidOutputReference PosixUid
        {
            get => GetInstanceProperty<oci.IdentityDomainsIdentitySetting.IdentityDomainsIdentitySettingPosixUidOutputReference>()!;
        }

        [JsiiProperty(name: "removeInvalidEmails", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable RemoveInvalidEmails
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.identityDomainsIdentitySetting.IdentityDomainsIdentitySettingTagsList\"}")]
        public virtual oci.IdentityDomainsIdentitySetting.IdentityDomainsIdentitySettingTagsList Tags
        {
            get => GetInstanceProperty<oci.IdentityDomainsIdentitySetting.IdentityDomainsIdentitySettingTagsList>()!;
        }

        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.identityDomainsIdentitySetting.IdentityDomainsIdentitySettingTimeoutsOutputReference\"}")]
        public virtual oci.IdentityDomainsIdentitySetting.IdentityDomainsIdentitySettingTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.IdentityDomainsIdentitySetting.IdentityDomainsIdentitySettingTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "tokens", typeJson: "{\"fqn\":\"oci.identityDomainsIdentitySetting.IdentityDomainsIdentitySettingTokensList\"}")]
        public virtual oci.IdentityDomainsIdentitySetting.IdentityDomainsIdentitySettingTokensList Tokens
        {
            get => GetInstanceProperty<oci.IdentityDomainsIdentitySetting.IdentityDomainsIdentitySettingTokensList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "attributeSetsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AttributeSetsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "attributesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AttributesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authorizationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthorizationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emitLockedMessageWhenUserIsLockedInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EmitLockedMessageWhenUserIsLockedInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "externalIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExternalIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idcsEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdcsEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identitySettingIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdentitySettingIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "myProfileInput", typeJson: "{\"fqn\":\"oci.identityDomainsIdentitySetting.IdentityDomainsIdentitySettingMyProfile\"}", isOptional: true)]
        public virtual oci.IdentityDomainsIdentitySetting.IIdentityDomainsIdentitySettingMyProfile? MyProfileInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsIdentitySetting.IIdentityDomainsIdentitySettingMyProfile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ocidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OcidInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "posixGidInput", typeJson: "{\"fqn\":\"oci.identityDomainsIdentitySetting.IdentityDomainsIdentitySettingPosixGid\"}", isOptional: true)]
        public virtual oci.IdentityDomainsIdentitySetting.IIdentityDomainsIdentitySettingPosixGid? PosixGidInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsIdentitySetting.IIdentityDomainsIdentitySettingPosixGid?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "posixUidInput", typeJson: "{\"fqn\":\"oci.identityDomainsIdentitySetting.IdentityDomainsIdentitySettingPosixUid\"}", isOptional: true)]
        public virtual oci.IdentityDomainsIdentitySetting.IIdentityDomainsIdentitySettingPosixUid? PosixUidInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsIdentitySetting.IIdentityDomainsIdentitySettingPosixUid?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "primaryEmailRequiredInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? PrimaryEmailRequiredInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceTypeSchemaVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceTypeSchemaVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "returnInactiveOverLockedMessageInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ReturnInactiveOverLockedMessageInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemasInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SchemasInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsIdentitySetting.IdentityDomainsIdentitySettingTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.identityDomainsIdentitySetting.IdentityDomainsIdentitySettingTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tokensInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsIdentitySetting.IdentityDomainsIdentitySettingTokens\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TokensInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userAllowedToSetRecoveryEmailInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? UserAllowedToSetRecoveryEmailInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "attributes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Attributes
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "attributeSets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AttributeSets
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Authorization
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "emitLockedMessageWhenUserIsLocked", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object EmitLockedMessageWhenUserIsLocked
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

        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "identitySettingId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdentitySettingId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ocid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "primaryEmailRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object PrimaryEmailRequired
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

        [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceTypeSchemaVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "returnInactiveOverLockedMessage", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object ReturnInactiveOverLockedMessage
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

        [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Schemas
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userAllowedToSetRecoveryEmail", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object UserAllowedToSetRecoveryEmail
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
    }
}
