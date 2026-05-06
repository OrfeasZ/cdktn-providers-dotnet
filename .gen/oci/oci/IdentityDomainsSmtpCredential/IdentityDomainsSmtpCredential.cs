using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsSmtpCredential
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_smtp_credential oci_identity_domains_smtp_credential}.</summary>
    [JsiiClass(nativeType: typeof(oci.IdentityDomainsSmtpCredential.IdentityDomainsSmtpCredential), fullyQualifiedName: "oci.identityDomainsSmtpCredential.IdentityDomainsSmtpCredential", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.identityDomainsSmtpCredential.IdentityDomainsSmtpCredentialConfig\"}}]")]
    public class IdentityDomainsSmtpCredential : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_smtp_credential oci_identity_domains_smtp_credential} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public IdentityDomainsSmtpCredential(Constructs.Construct scope, string id, oci.IdentityDomainsSmtpCredential.IIdentityDomainsSmtpCredentialConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.IdentityDomainsSmtpCredential.IIdentityDomainsSmtpCredentialConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IdentityDomainsSmtpCredential(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IdentityDomainsSmtpCredential(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a IdentityDomainsSmtpCredential resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the IdentityDomainsSmtpCredential to import.</param>
        /// <param name="importFromId">The id of the existing IdentityDomainsSmtpCredential that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the IdentityDomainsSmtpCredential to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the IdentityDomainsSmtpCredential to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_smtp_credential#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing IdentityDomainsSmtpCredential that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the IdentityDomainsSmtpCredential to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.IdentityDomainsSmtpCredential.IdentityDomainsSmtpCredential), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsSmtpCredential.IdentityDomainsSmtpCredentialTags\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTags(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.IdentityDomainsSmtpCredential.IIdentityDomainsSmtpCredentialTags[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsSmtpCredential.IIdentityDomainsSmtpCredentialTags).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsSmtpCredential.IIdentityDomainsSmtpCredentialTags).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsSmtpCredential.IdentityDomainsSmtpCredentialTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.IdentityDomainsSmtpCredential.IIdentityDomainsSmtpCredentialTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsSmtpCredential.IIdentityDomainsSmtpCredentialTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUrnietfparamsscimschemasoracleidcsextensionselfChangeUser", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsSmtpCredential.IdentityDomainsSmtpCredentialUrnietfparamsscimschemasoracleidcsextensionselfChangeUser\"}}]")]
        public virtual void PutUrnietfparamsscimschemasoracleidcsextensionselfChangeUser(oci.IdentityDomainsSmtpCredential.IIdentityDomainsSmtpCredentialUrnietfparamsscimschemasoracleidcsextensionselfChangeUser @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsSmtpCredential.IIdentityDomainsSmtpCredentialUrnietfparamsscimschemasoracleidcsextensionselfChangeUser)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUser", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsSmtpCredential.IdentityDomainsSmtpCredentialUser\"}}]")]
        public virtual void PutUser(oci.IdentityDomainsSmtpCredential.IIdentityDomainsSmtpCredentialUser @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsSmtpCredential.IIdentityDomainsSmtpCredentialUser)}, new object[]{@value});
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

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExpiresOn")]
        public virtual void ResetExpiresOn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOcid")]
        public virtual void ResetOcid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceTypeSchemaVersion")]
        public virtual void ResetResourceTypeSchemaVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStatus")]
        public virtual void ResetStatus()
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

        [JsiiMethod(name: "resetUrnietfparamsscimschemasoracleidcsextensionselfChangeUser")]
        public virtual void ResetUrnietfparamsscimschemasoracleidcsextensionselfChangeUser()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUser")]
        public virtual void ResetUser()
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
        = GetStaticProperty<string>(typeof(oci.IdentityDomainsSmtpCredential.IdentityDomainsSmtpCredential))!;

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

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.identityDomainsSmtpCredential.IdentityDomainsSmtpCredentialIdcsCreatedByList\"}")]
        public virtual oci.IdentityDomainsSmtpCredential.IdentityDomainsSmtpCredentialIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.IdentityDomainsSmtpCredential.IdentityDomainsSmtpCredentialIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.identityDomainsSmtpCredential.IdentityDomainsSmtpCredentialIdcsLastModifiedByList\"}")]
        public virtual oci.IdentityDomainsSmtpCredential.IdentityDomainsSmtpCredentialIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.IdentityDomainsSmtpCredential.IdentityDomainsSmtpCredentialIdcsLastModifiedByList>()!;
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

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.identityDomainsSmtpCredential.IdentityDomainsSmtpCredentialMetaList\"}")]
        public virtual oci.IdentityDomainsSmtpCredential.IdentityDomainsSmtpCredentialMetaList Meta
        {
            get => GetInstanceProperty<oci.IdentityDomainsSmtpCredential.IdentityDomainsSmtpCredentialMetaList>()!;
        }

        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Password
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.identityDomainsSmtpCredential.IdentityDomainsSmtpCredentialTagsList\"}")]
        public virtual oci.IdentityDomainsSmtpCredential.IdentityDomainsSmtpCredentialTagsList Tags
        {
            get => GetInstanceProperty<oci.IdentityDomainsSmtpCredential.IdentityDomainsSmtpCredentialTagsList>()!;
        }

        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.identityDomainsSmtpCredential.IdentityDomainsSmtpCredentialTimeoutsOutputReference\"}")]
        public virtual oci.IdentityDomainsSmtpCredential.IdentityDomainsSmtpCredentialTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.IdentityDomainsSmtpCredential.IdentityDomainsSmtpCredentialTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionselfChangeUser", typeJson: "{\"fqn\":\"oci.identityDomainsSmtpCredential.IdentityDomainsSmtpCredentialUrnietfparamsscimschemasoracleidcsextensionselfChangeUserOutputReference\"}")]
        public virtual oci.IdentityDomainsSmtpCredential.IdentityDomainsSmtpCredentialUrnietfparamsscimschemasoracleidcsextensionselfChangeUserOutputReference UrnietfparamsscimschemasoracleidcsextensionselfChangeUser
        {
            get => GetInstanceProperty<oci.IdentityDomainsSmtpCredential.IdentityDomainsSmtpCredentialUrnietfparamsscimschemasoracleidcsextensionselfChangeUserOutputReference>()!;
        }

        [JsiiProperty(name: "user", typeJson: "{\"fqn\":\"oci.identityDomainsSmtpCredential.IdentityDomainsSmtpCredentialUserOutputReference\"}")]
        public virtual oci.IdentityDomainsSmtpCredential.IdentityDomainsSmtpCredentialUserOutputReference User
        {
            get => GetInstanceProperty<oci.IdentityDomainsSmtpCredential.IdentityDomainsSmtpCredentialUserOutputReference>()!;
        }

        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserName
        {
            get => GetInstanceProperty<string>()!;
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
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "expiresOnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExpiresOnInput
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
        [JsiiProperty(name: "ocidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OcidInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceTypeSchemaVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceTypeSchemaVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemasInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SchemasInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statusInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StatusInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsSmtpCredential.IdentityDomainsSmtpCredentialTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.identityDomainsSmtpCredential.IdentityDomainsSmtpCredentialTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionselfChangeUserInput", typeJson: "{\"fqn\":\"oci.identityDomainsSmtpCredential.IdentityDomainsSmtpCredentialUrnietfparamsscimschemasoracleidcsextensionselfChangeUser\"}", isOptional: true)]
        public virtual oci.IdentityDomainsSmtpCredential.IIdentityDomainsSmtpCredentialUrnietfparamsscimschemasoracleidcsextensionselfChangeUser? UrnietfparamsscimschemasoracleidcsextensionselfChangeUserInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsSmtpCredential.IIdentityDomainsSmtpCredentialUrnietfparamsscimschemasoracleidcsextensionselfChangeUser?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userInput", typeJson: "{\"fqn\":\"oci.identityDomainsSmtpCredential.IdentityDomainsSmtpCredentialUser\"}", isOptional: true)]
        public virtual oci.IdentityDomainsSmtpCredential.IIdentityDomainsSmtpCredentialUser? UserInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsSmtpCredential.IIdentityDomainsSmtpCredentialUser?>();
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

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "expiresOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExpiresOn
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

        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ocid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceTypeSchemaVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Schemas
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
