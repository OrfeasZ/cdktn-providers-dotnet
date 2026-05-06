using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsCloudGateMapping
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping oci_identity_domains_cloud_gate_mapping}.</summary>
    [JsiiClass(nativeType: typeof(oci.IdentityDomainsCloudGateMapping.IdentityDomainsCloudGateMapping), fullyQualifiedName: "oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMapping", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingConfig\"}}]")]
    public class IdentityDomainsCloudGateMapping : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping oci_identity_domains_cloud_gate_mapping} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public IdentityDomainsCloudGateMapping(Constructs.Construct scope, string id, oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IdentityDomainsCloudGateMapping(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IdentityDomainsCloudGateMapping(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a IdentityDomainsCloudGateMapping resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the IdentityDomainsCloudGateMapping to import.</param>
        /// <param name="importFromId">The id of the existing IdentityDomainsCloudGateMapping that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the IdentityDomainsCloudGateMapping to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the IdentityDomainsCloudGateMapping to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing IdentityDomainsCloudGateMapping that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the IdentityDomainsCloudGateMapping to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.IdentityDomainsCloudGateMapping.IdentityDomainsCloudGateMapping), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCloudGate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingCloudGate\"}}]")]
        public virtual void PutCloudGate(oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingCloudGate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingCloudGate)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGatewayApp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingGatewayApp\"}}]")]
        public virtual void PutGatewayApp(oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingGatewayApp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingGatewayApp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServer", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingServer\"}}]")]
        public virtual void PutServer(oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingServer @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingServer)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingTags\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTags(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingTags[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingTags).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingTags).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUpstreamServerGroup", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingUpstreamServerGroup\"}}]")]
        public virtual void PutUpstreamServerGroup(oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingUpstreamServerGroup @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingUpstreamServerGroup)}, new object[]{@value});
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

        [JsiiMethod(name: "resetNginxSettings")]
        public virtual void ResetNginxSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOcid")]
        public virtual void ResetOcid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProxyPass")]
        public virtual void ResetProxyPass()
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

        [JsiiMethod(name: "resetUpstreamServerGroup")]
        public virtual void ResetUpstreamServerGroup()
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
        = GetStaticProperty<string>(typeof(oci.IdentityDomainsCloudGateMapping.IdentityDomainsCloudGateMapping))!;

        [JsiiProperty(name: "cloudGate", typeJson: "{\"fqn\":\"oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingCloudGateOutputReference\"}")]
        public virtual oci.IdentityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingCloudGateOutputReference CloudGate
        {
            get => GetInstanceProperty<oci.IdentityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingCloudGateOutputReference>()!;
        }

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

        [JsiiProperty(name: "gatewayApp", typeJson: "{\"fqn\":\"oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingGatewayAppOutputReference\"}")]
        public virtual oci.IdentityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingGatewayAppOutputReference GatewayApp
        {
            get => GetInstanceProperty<oci.IdentityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingGatewayAppOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingIdcsCreatedByList\"}")]
        public virtual oci.IdentityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.IdentityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingIdcsLastModifiedByList\"}")]
        public virtual oci.IdentityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.IdentityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingIdcsLastModifiedByList>()!;
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

        [JsiiProperty(name: "isOpcService", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsOpcService
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingMetaList\"}")]
        public virtual oci.IdentityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingMetaList Meta
        {
            get => GetInstanceProperty<oci.IdentityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingMetaList>()!;
        }

        [JsiiProperty(name: "server", typeJson: "{\"fqn\":\"oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingServerOutputReference\"}")]
        public virtual oci.IdentityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingServerOutputReference Server
        {
            get => GetInstanceProperty<oci.IdentityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingServerOutputReference>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingTagsList\"}")]
        public virtual oci.IdentityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingTagsList Tags
        {
            get => GetInstanceProperty<oci.IdentityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingTagsList>()!;
        }

        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingTimeoutsOutputReference\"}")]
        public virtual oci.IdentityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.IdentityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "upstreamServerGroup", typeJson: "{\"fqn\":\"oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingUpstreamServerGroupOutputReference\"}")]
        public virtual oci.IdentityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingUpstreamServerGroupOutputReference UpstreamServerGroup
        {
            get => GetInstanceProperty<oci.IdentityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingUpstreamServerGroupOutputReference>()!;
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
        [JsiiProperty(name: "cloudGateInput", typeJson: "{\"fqn\":\"oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingCloudGate\"}", isOptional: true)]
        public virtual oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingCloudGate? CloudGateInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingCloudGate?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gatewayAppInput", typeJson: "{\"fqn\":\"oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingGatewayApp\"}", isOptional: true)]
        public virtual oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingGatewayApp? GatewayAppInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingGatewayApp?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idcsEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdcsEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nginxSettingsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NginxSettingsInput
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
        [JsiiProperty(name: "policyNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PolicyNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "proxyPassInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProxyPassInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourcePrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourcePrefixInput
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
        [JsiiProperty(name: "serverInput", typeJson: "{\"fqn\":\"oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingServer\"}", isOptional: true)]
        public virtual oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingServer? ServerInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingServer?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "upstreamServerGroupInput", typeJson: "{\"fqn\":\"oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingUpstreamServerGroup\"}", isOptional: true)]
        public virtual oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingUpstreamServerGroup? UpstreamServerGroupInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingUpstreamServerGroup?>();
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

        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nginxSettings", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NginxSettings
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

        [JsiiProperty(name: "policyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PolicyName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "proxyPass", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProxyPass
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourcePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourcePrefix
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
