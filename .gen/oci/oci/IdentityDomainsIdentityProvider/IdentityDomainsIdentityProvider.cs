using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsIdentityProvider
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider oci_identity_domains_identity_provider}.</summary>
    [JsiiClass(nativeType: typeof(oci.IdentityDomainsIdentityProvider.IdentityDomainsIdentityProvider), fullyQualifiedName: "oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProvider", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderConfig\"}}]")]
    public class IdentityDomainsIdentityProvider : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider oci_identity_domains_identity_provider} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public IdentityDomainsIdentityProvider(Constructs.Construct scope, string id, oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IdentityDomainsIdentityProvider(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IdentityDomainsIdentityProvider(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a IdentityDomainsIdentityProvider resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the IdentityDomainsIdentityProvider to import.</param>
        /// <param name="importFromId">The id of the existing IdentityDomainsIdentityProvider that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the IdentityDomainsIdentityProvider to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the IdentityDomainsIdentityProvider to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_identity_provider#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing IdentityDomainsIdentityProvider that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the IdentityDomainsIdentityProvider to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.IdentityDomainsIdentityProvider.IdentityDomainsIdentityProvider), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCorrelationPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderCorrelationPolicy\"}}]")]
        public virtual void PutCorrelationPolicy(oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderCorrelationPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderCorrelationPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putJitUserProvAssignedGroups", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderJitUserProvAssignedGroups\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutJitUserProvAssignedGroups(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderJitUserProvAssignedGroups[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderJitUserProvAssignedGroups).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderJitUserProvAssignedGroups).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putJitUserProvAttributes", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderJitUserProvAttributes\"}}]")]
        public virtual void PutJitUserProvAttributes(oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderJitUserProvAttributes @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderJitUserProvAttributes)}, new object[]{@value});
        }

        [JsiiMethod(name: "putJitUserProvGroupMappings", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderJitUserProvGroupMappings\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutJitUserProvGroupMappings(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderJitUserProvGroupMappings[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderJitUserProvGroupMappings).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderJitUserProvGroupMappings).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderTags\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTags(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderTags[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderTags).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderTags).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProvider", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProvider\"}}]")]
        public virtual void PutUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProvider(oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProvider @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProvider)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUrnietfparamsscimschemasoracleidcsextensionx509IdentityProvider", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionx509IdentityProvider\"}}]")]
        public virtual void PutUrnietfparamsscimschemasoracleidcsextensionx509IdentityProvider(oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionx509IdentityProvider @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionx509IdentityProvider)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAssertionAttribute")]
        public virtual void ResetAssertionAttribute()
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

        [JsiiMethod(name: "resetAuthnRequestBinding")]
        public virtual void ResetAuthnRequestBinding()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthorization")]
        public virtual void ResetAuthorization()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCorrelationPolicy")]
        public virtual void ResetCorrelationPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncryptionCertificate")]
        public virtual void ResetEncryptionCertificate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExternalId")]
        public virtual void ResetExternalId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIconUrl")]
        public virtual void ResetIconUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdpSsoUrl")]
        public virtual void ResetIdpSsoUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIncludeSigningCertInSignature")]
        public virtual void ResetIncludeSigningCertInSignature()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJitUserProvAssignedGroups")]
        public virtual void ResetJitUserProvAssignedGroups()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJitUserProvAttributes")]
        public virtual void ResetJitUserProvAttributes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJitUserProvAttributeUpdateEnabled")]
        public virtual void ResetJitUserProvAttributeUpdateEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJitUserProvCreateUserEnabled")]
        public virtual void ResetJitUserProvCreateUserEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJitUserProvEnabled")]
        public virtual void ResetJitUserProvEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJitUserProvGroupAssertionAttributeEnabled")]
        public virtual void ResetJitUserProvGroupAssertionAttributeEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJitUserProvGroupAssignmentMethod")]
        public virtual void ResetJitUserProvGroupAssignmentMethod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJitUserProvGroupMappingMode")]
        public virtual void ResetJitUserProvGroupMappingMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJitUserProvGroupMappings")]
        public virtual void ResetJitUserProvGroupMappings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJitUserProvGroupSamlAttributeName")]
        public virtual void ResetJitUserProvGroupSamlAttributeName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJitUserProvGroupStaticListEnabled")]
        public virtual void ResetJitUserProvGroupStaticListEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJitUserProvIgnoreErrorOnAbsentGroups")]
        public virtual void ResetJitUserProvIgnoreErrorOnAbsentGroups()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogoutBinding")]
        public virtual void ResetLogoutBinding()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogoutEnabled")]
        public virtual void ResetLogoutEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogoutRequestUrl")]
        public virtual void ResetLogoutRequestUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogoutResponseUrl")]
        public virtual void ResetLogoutResponseUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetadata")]
        public virtual void ResetMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNameIdFormat")]
        public virtual void ResetNameIdFormat()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOcid")]
        public virtual void ResetOcid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPartnerProviderId")]
        public virtual void ResetPartnerProviderId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequestedAuthenticationContext")]
        public virtual void ResetRequestedAuthenticationContext()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequireForceAuthn")]
        public virtual void ResetRequireForceAuthn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequiresEncryptedAssertion")]
        public virtual void ResetRequiresEncryptedAssertion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceTypeSchemaVersion")]
        public virtual void ResetResourceTypeSchemaVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSamlHoKrequired")]
        public virtual void ResetSamlHoKrequired()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceInstanceIdentifier")]
        public virtual void ResetServiceInstanceIdentifier()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShownOnLoginPage")]
        public virtual void ResetShownOnLoginPage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSignatureHashAlgorithm")]
        public virtual void ResetSignatureHashAlgorithm()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSigningCertificate")]
        public virtual void ResetSigningCertificate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSuccinctId")]
        public virtual void ResetSuccinctId()
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

        [JsiiMethod(name: "resetType")]
        public virtual void ResetType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProvider")]
        public virtual void ResetUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProvider()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUrnietfparamsscimschemasoracleidcsextensionx509IdentityProvider")]
        public virtual void ResetUrnietfparamsscimschemasoracleidcsextensionx509IdentityProvider()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserMappingMethod")]
        public virtual void ResetUserMappingMethod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserMappingStoreAttribute")]
        public virtual void ResetUserMappingStoreAttribute()
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
        = GetStaticProperty<string>(typeof(oci.IdentityDomainsIdentityProvider.IdentityDomainsIdentityProvider))!;

        [JsiiProperty(name: "compartmentOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "correlationPolicy", typeJson: "{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderCorrelationPolicyOutputReference\"}")]
        public virtual oci.IdentityDomainsIdentityProvider.IdentityDomainsIdentityProviderCorrelationPolicyOutputReference CorrelationPolicy
        {
            get => GetInstanceProperty<oci.IdentityDomainsIdentityProvider.IdentityDomainsIdentityProviderCorrelationPolicyOutputReference>()!;
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

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderIdcsCreatedByList\"}")]
        public virtual oci.IdentityDomainsIdentityProvider.IdentityDomainsIdentityProviderIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.IdentityDomainsIdentityProvider.IdentityDomainsIdentityProviderIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderIdcsLastModifiedByList\"}")]
        public virtual oci.IdentityDomainsIdentityProvider.IdentityDomainsIdentityProviderIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.IdentityDomainsIdentityProvider.IdentityDomainsIdentityProviderIdcsLastModifiedByList>()!;
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

        [JsiiProperty(name: "jitUserProvAssignedGroups", typeJson: "{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderJitUserProvAssignedGroupsList\"}")]
        public virtual oci.IdentityDomainsIdentityProvider.IdentityDomainsIdentityProviderJitUserProvAssignedGroupsList JitUserProvAssignedGroups
        {
            get => GetInstanceProperty<oci.IdentityDomainsIdentityProvider.IdentityDomainsIdentityProviderJitUserProvAssignedGroupsList>()!;
        }

        [JsiiProperty(name: "jitUserProvAttributes", typeJson: "{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderJitUserProvAttributesOutputReference\"}")]
        public virtual oci.IdentityDomainsIdentityProvider.IdentityDomainsIdentityProviderJitUserProvAttributesOutputReference JitUserProvAttributes
        {
            get => GetInstanceProperty<oci.IdentityDomainsIdentityProvider.IdentityDomainsIdentityProviderJitUserProvAttributesOutputReference>()!;
        }

        [JsiiProperty(name: "jitUserProvGroupMappings", typeJson: "{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderJitUserProvGroupMappingsList\"}")]
        public virtual oci.IdentityDomainsIdentityProvider.IdentityDomainsIdentityProviderJitUserProvGroupMappingsList JitUserProvGroupMappings
        {
            get => GetInstanceProperty<oci.IdentityDomainsIdentityProvider.IdentityDomainsIdentityProviderJitUserProvGroupMappingsList>()!;
        }

        [JsiiProperty(name: "lastNotificationSentTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastNotificationSentTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderMetaList\"}")]
        public virtual oci.IdentityDomainsIdentityProvider.IdentityDomainsIdentityProviderMetaList Meta
        {
            get => GetInstanceProperty<oci.IdentityDomainsIdentityProvider.IdentityDomainsIdentityProviderMetaList>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderTagsList\"}")]
        public virtual oci.IdentityDomainsIdentityProvider.IdentityDomainsIdentityProviderTagsList Tags
        {
            get => GetInstanceProperty<oci.IdentityDomainsIdentityProvider.IdentityDomainsIdentityProviderTagsList>()!;
        }

        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tenantProviderId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenantProviderId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderTimeoutsOutputReference\"}")]
        public virtual oci.IdentityDomainsIdentityProvider.IdentityDomainsIdentityProviderTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.IdentityDomainsIdentityProvider.IdentityDomainsIdentityProviderTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionsocialIdentityProvider", typeJson: "{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProviderOutputReference\"}")]
        public virtual oci.IdentityDomainsIdentityProvider.IdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProviderOutputReference UrnietfparamsscimschemasoracleidcsextensionsocialIdentityProvider
        {
            get => GetInstanceProperty<oci.IdentityDomainsIdentityProvider.IdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProviderOutputReference>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionx509IdentityProvider", typeJson: "{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionx509IdentityProviderOutputReference\"}")]
        public virtual oci.IdentityDomainsIdentityProvider.IdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionx509IdentityProviderOutputReference Urnietfparamsscimschemasoracleidcsextensionx509IdentityProvider
        {
            get => GetInstanceProperty<oci.IdentityDomainsIdentityProvider.IdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionx509IdentityProviderOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "assertionAttributeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AssertionAttributeInput
        {
            get => GetInstanceProperty<string?>();
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
        [JsiiProperty(name: "authnRequestBindingInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthnRequestBindingInput
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
        [JsiiProperty(name: "correlationPolicyInput", typeJson: "{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderCorrelationPolicy\"}", isOptional: true)]
        public virtual oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderCorrelationPolicy? CorrelationPolicyInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderCorrelationPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionCertificateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EncryptionCertificateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "externalIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExternalIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "iconUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IconUrlInput
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
        [JsiiProperty(name: "idpSsoUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdpSsoUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "includeSigningCertInSignatureInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IncludeSigningCertInSignatureInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jitUserProvAssignedGroupsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderJitUserProvAssignedGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? JitUserProvAssignedGroupsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jitUserProvAttributesInput", typeJson: "{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderJitUserProvAttributes\"}", isOptional: true)]
        public virtual oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderJitUserProvAttributes? JitUserProvAttributesInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderJitUserProvAttributes?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jitUserProvAttributeUpdateEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? JitUserProvAttributeUpdateEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jitUserProvCreateUserEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? JitUserProvCreateUserEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jitUserProvEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? JitUserProvEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jitUserProvGroupAssertionAttributeEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? JitUserProvGroupAssertionAttributeEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jitUserProvGroupAssignmentMethodInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JitUserProvGroupAssignmentMethodInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jitUserProvGroupMappingModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JitUserProvGroupMappingModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jitUserProvGroupMappingsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderJitUserProvGroupMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? JitUserProvGroupMappingsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jitUserProvGroupSamlAttributeNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JitUserProvGroupSamlAttributeNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jitUserProvGroupStaticListEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? JitUserProvGroupStaticListEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jitUserProvIgnoreErrorOnAbsentGroupsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? JitUserProvIgnoreErrorOnAbsentGroupsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logoutBindingInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogoutBindingInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logoutEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? LogoutEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logoutRequestUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogoutRequestUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logoutResponseUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogoutResponseUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metadataInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MetadataInput
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
        [JsiiProperty(name: "ocidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OcidInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "partnerNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PartnerNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "partnerProviderIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PartnerProviderIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestedAuthenticationContextInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? RequestedAuthenticationContextInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requireForceAuthnInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? RequireForceAuthnInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requiresEncryptedAssertionInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? RequiresEncryptedAssertionInput
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
        [JsiiProperty(name: "samlHoKrequiredInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? SamlHoKrequiredInput
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
        [JsiiProperty(name: "serviceInstanceIdentifierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceInstanceIdentifierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shownOnLoginPageInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ShownOnLoginPageInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "signatureHashAlgorithmInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SignatureHashAlgorithmInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "signingCertificateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SigningCertificateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "succinctIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SuccinctIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionsocialIdentityProviderInput", typeJson: "{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProvider\"}", isOptional: true)]
        public virtual oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProvider? UrnietfparamsscimschemasoracleidcsextensionsocialIdentityProviderInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProvider?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionx509IdentityProviderInput", typeJson: "{\"fqn\":\"oci.identityDomainsIdentityProvider.IdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionx509IdentityProvider\"}", isOptional: true)]
        public virtual oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionx509IdentityProvider? Urnietfparamsscimschemasoracleidcsextensionx509IdentityProviderInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsIdentityProvider.IIdentityDomainsIdentityProviderUrnietfparamsscimschemasoracleidcsextensionx509IdentityProvider?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userMappingMethodInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserMappingMethodInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userMappingStoreAttributeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserMappingStoreAttributeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "assertionAttribute", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssertionAttribute
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
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

        [JsiiProperty(name: "authnRequestBinding", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthnRequestBinding
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Enabled
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

        [JsiiProperty(name: "encryptionCertificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EncryptionCertificate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "iconUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IconUrl
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

        [JsiiProperty(name: "idpSsoUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdpSsoUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "includeSigningCertInSignature", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IncludeSigningCertInSignature
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

        [JsiiProperty(name: "jitUserProvAttributeUpdateEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object JitUserProvAttributeUpdateEnabled
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

        [JsiiProperty(name: "jitUserProvCreateUserEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object JitUserProvCreateUserEnabled
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

        [JsiiProperty(name: "jitUserProvEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object JitUserProvEnabled
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

        [JsiiProperty(name: "jitUserProvGroupAssertionAttributeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object JitUserProvGroupAssertionAttributeEnabled
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

        [JsiiProperty(name: "jitUserProvGroupAssignmentMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JitUserProvGroupAssignmentMethod
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "jitUserProvGroupMappingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JitUserProvGroupMappingMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "jitUserProvGroupSamlAttributeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JitUserProvGroupSamlAttributeName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "jitUserProvGroupStaticListEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object JitUserProvGroupStaticListEnabled
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

        [JsiiProperty(name: "jitUserProvIgnoreErrorOnAbsentGroups", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object JitUserProvIgnoreErrorOnAbsentGroups
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

        [JsiiProperty(name: "logoutBinding", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogoutBinding
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logoutEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object LogoutEnabled
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

        [JsiiProperty(name: "logoutRequestUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogoutRequestUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logoutResponseUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogoutResponseUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Metadata
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

        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ocid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "partnerName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PartnerName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "partnerProviderId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PartnerProviderId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requestedAuthenticationContext", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RequestedAuthenticationContext
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requireForceAuthn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object RequireForceAuthn
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

        [JsiiProperty(name: "requiresEncryptedAssertion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object RequiresEncryptedAssertion
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

        [JsiiProperty(name: "samlHoKrequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object SamlHoKrequired
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

        [JsiiProperty(name: "serviceInstanceIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceInstanceIdentifier
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "shownOnLoginPage", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object ShownOnLoginPage
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

        [JsiiProperty(name: "signatureHashAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SignatureHashAlgorithm
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "signingCertificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SigningCertificate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "succinctId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SuccinctId
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

        [JsiiProperty(name: "userMappingMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserMappingMethod
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userMappingStoreAttribute", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserMappingStoreAttribute
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
