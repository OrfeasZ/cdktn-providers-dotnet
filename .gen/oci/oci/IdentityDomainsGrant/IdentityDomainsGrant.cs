using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsGrant
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant oci_identity_domains_grant}.</summary>
    [JsiiClass(nativeType: typeof(oci.IdentityDomainsGrant.IdentityDomainsGrant), fullyQualifiedName: "oci.identityDomainsGrant.IdentityDomainsGrant", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.identityDomainsGrant.IdentityDomainsGrantConfig\"}}]")]
    public class IdentityDomainsGrant : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant oci_identity_domains_grant} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public IdentityDomainsGrant(Constructs.Construct scope, string id, oci.IdentityDomainsGrant.IIdentityDomainsGrantConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.IdentityDomainsGrant.IIdentityDomainsGrantConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IdentityDomainsGrant(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IdentityDomainsGrant(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a IdentityDomainsGrant resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the IdentityDomainsGrant to import.</param>
        /// <param name="importFromId">The id of the existing IdentityDomainsGrant that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the IdentityDomainsGrant to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the IdentityDomainsGrant to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing IdentityDomainsGrant that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the IdentityDomainsGrant to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.IdentityDomainsGrant.IdentityDomainsGrant), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putApp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsGrant.IdentityDomainsGrantApp\"}}]")]
        public virtual void PutApp(oci.IdentityDomainsGrant.IIdentityDomainsGrantApp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsGrant.IIdentityDomainsGrantApp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAppEntitlementCollection", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsGrant.IdentityDomainsGrantAppEntitlementCollection\"}}]")]
        public virtual void PutAppEntitlementCollection(oci.IdentityDomainsGrant.IIdentityDomainsGrantAppEntitlementCollection @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsGrant.IIdentityDomainsGrantAppEntitlementCollection)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEntitlement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsGrant.IdentityDomainsGrantEntitlement\"}}]")]
        public virtual void PutEntitlement(oci.IdentityDomainsGrant.IIdentityDomainsGrantEntitlement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsGrant.IIdentityDomainsGrantEntitlement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGrantee", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsGrant.IdentityDomainsGrantGrantee\"}}]")]
        public virtual void PutGrantee(oci.IdentityDomainsGrant.IIdentityDomainsGrantGrantee @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsGrant.IIdentityDomainsGrantGrantee)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsGrant.IdentityDomainsGrantTags\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTags(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.IdentityDomainsGrant.IIdentityDomainsGrantTags[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsGrant.IIdentityDomainsGrantTags).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsGrant.IIdentityDomainsGrantTags).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsGrant.IdentityDomainsGrantTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.IdentityDomainsGrant.IIdentityDomainsGrantTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsGrant.IIdentityDomainsGrantTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApp")]
        public virtual void ResetApp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAppEntitlementCollection")]
        public virtual void ResetAppEntitlementCollection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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

        [JsiiMethod(name: "resetEntitlement")]
        public virtual void ResetEntitlement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGrantedAttributeValuesJson")]
        public virtual void ResetGrantedAttributeValuesJson()
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
        = GetStaticProperty<string>(typeof(oci.IdentityDomainsGrant.IdentityDomainsGrant))!;

        [JsiiProperty(name: "app", typeJson: "{\"fqn\":\"oci.identityDomainsGrant.IdentityDomainsGrantAppOutputReference\"}")]
        public virtual oci.IdentityDomainsGrant.IdentityDomainsGrantAppOutputReference App
        {
            get => GetInstanceProperty<oci.IdentityDomainsGrant.IdentityDomainsGrantAppOutputReference>()!;
        }

        [JsiiProperty(name: "appEntitlementCollection", typeJson: "{\"fqn\":\"oci.identityDomainsGrant.IdentityDomainsGrantAppEntitlementCollectionOutputReference\"}")]
        public virtual oci.IdentityDomainsGrant.IdentityDomainsGrantAppEntitlementCollectionOutputReference AppEntitlementCollection
        {
            get => GetInstanceProperty<oci.IdentityDomainsGrant.IdentityDomainsGrantAppEntitlementCollectionOutputReference>()!;
        }

        [JsiiProperty(name: "compartmentOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compositeKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompositeKey
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

        [JsiiProperty(name: "entitlement", typeJson: "{\"fqn\":\"oci.identityDomainsGrant.IdentityDomainsGrantEntitlementOutputReference\"}")]
        public virtual oci.IdentityDomainsGrant.IdentityDomainsGrantEntitlementOutputReference Entitlement
        {
            get => GetInstanceProperty<oci.IdentityDomainsGrant.IdentityDomainsGrantEntitlementOutputReference>()!;
        }

        [JsiiProperty(name: "grantee", typeJson: "{\"fqn\":\"oci.identityDomainsGrant.IdentityDomainsGrantGranteeOutputReference\"}")]
        public virtual oci.IdentityDomainsGrant.IdentityDomainsGrantGranteeOutputReference Grantee
        {
            get => GetInstanceProperty<oci.IdentityDomainsGrant.IdentityDomainsGrantGranteeOutputReference>()!;
        }

        [JsiiProperty(name: "grantor", typeJson: "{\"fqn\":\"oci.identityDomainsGrant.IdentityDomainsGrantGrantorList\"}")]
        public virtual oci.IdentityDomainsGrant.IdentityDomainsGrantGrantorList Grantor
        {
            get => GetInstanceProperty<oci.IdentityDomainsGrant.IdentityDomainsGrantGrantorList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.identityDomainsGrant.IdentityDomainsGrantIdcsCreatedByList\"}")]
        public virtual oci.IdentityDomainsGrant.IdentityDomainsGrantIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.IdentityDomainsGrant.IdentityDomainsGrantIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.identityDomainsGrant.IdentityDomainsGrantIdcsLastModifiedByList\"}")]
        public virtual oci.IdentityDomainsGrant.IdentityDomainsGrantIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.IdentityDomainsGrant.IdentityDomainsGrantIdcsLastModifiedByList>()!;
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

        [JsiiProperty(name: "isFulfilled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsFulfilled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.identityDomainsGrant.IdentityDomainsGrantMetaList\"}")]
        public virtual oci.IdentityDomainsGrant.IdentityDomainsGrantMetaList Meta
        {
            get => GetInstanceProperty<oci.IdentityDomainsGrant.IdentityDomainsGrantMetaList>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.identityDomainsGrant.IdentityDomainsGrantTagsList\"}")]
        public virtual oci.IdentityDomainsGrant.IdentityDomainsGrantTagsList Tags
        {
            get => GetInstanceProperty<oci.IdentityDomainsGrant.IdentityDomainsGrantTagsList>()!;
        }

        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.identityDomainsGrant.IdentityDomainsGrantTimeoutsOutputReference\"}")]
        public virtual oci.IdentityDomainsGrant.IdentityDomainsGrantTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.IdentityDomainsGrant.IdentityDomainsGrantTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "appEntitlementCollectionInput", typeJson: "{\"fqn\":\"oci.identityDomainsGrant.IdentityDomainsGrantAppEntitlementCollection\"}", isOptional: true)]
        public virtual oci.IdentityDomainsGrant.IIdentityDomainsGrantAppEntitlementCollection? AppEntitlementCollectionInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsGrant.IIdentityDomainsGrantAppEntitlementCollection?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "appInput", typeJson: "{\"fqn\":\"oci.identityDomainsGrant.IdentityDomainsGrantApp\"}", isOptional: true)]
        public virtual oci.IdentityDomainsGrant.IIdentityDomainsGrantApp? AppInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsGrant.IIdentityDomainsGrantApp?>();
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
        [JsiiProperty(name: "entitlementInput", typeJson: "{\"fqn\":\"oci.identityDomainsGrant.IdentityDomainsGrantEntitlement\"}", isOptional: true)]
        public virtual oci.IdentityDomainsGrant.IIdentityDomainsGrantEntitlement? EntitlementInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsGrant.IIdentityDomainsGrantEntitlement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "grantedAttributeValuesJsonInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GrantedAttributeValuesJsonInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "granteeInput", typeJson: "{\"fqn\":\"oci.identityDomainsGrant.IdentityDomainsGrantGrantee\"}", isOptional: true)]
        public virtual oci.IdentityDomainsGrant.IIdentityDomainsGrantGrantee? GranteeInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsGrant.IIdentityDomainsGrantGrantee?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "grantMechanismInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GrantMechanismInput
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
        [JsiiProperty(name: "tagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsGrant.IdentityDomainsGrantTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.identityDomainsGrant.IdentityDomainsGrantTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
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

        [JsiiProperty(name: "grantedAttributeValuesJson", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GrantedAttributeValuesJson
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "grantMechanism", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GrantMechanism
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
    }
}
