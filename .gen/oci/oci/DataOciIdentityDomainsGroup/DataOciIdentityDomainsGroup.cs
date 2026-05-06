using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsGroup
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_group oci_identity_domains_group}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroup), fullyQualifiedName: "oci.dataOciIdentityDomainsGroup.DataOciIdentityDomainsGroup", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupConfig\"}}]")]
    public class DataOciIdentityDomainsGroup : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_group oci_identity_domains_group} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciIdentityDomainsGroup(Constructs.Construct scope, string id, oci.DataOciIdentityDomainsGroup.IDataOciIdentityDomainsGroupConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciIdentityDomainsGroup.IDataOciIdentityDomainsGroupConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsGroup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsGroup(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciIdentityDomainsGroup resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciIdentityDomainsGroup to import.</param>
        /// <param name="importFromId">The id of the existing DataOciIdentityDomainsGroup that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciIdentityDomainsGroup to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciIdentityDomainsGroup to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_group#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciIdentityDomainsGroup that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciIdentityDomainsGroup to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroup), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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

        [JsiiMethod(name: "resetResourceTypeSchemaVersion")]
        public virtual void ResetResourceTypeSchemaVersion()
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
        = GetStaticProperty<string>(typeof(oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroup))!;

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

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "domainOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "forceDelete", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ForceDelete
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupIdcsCreatedByList\"}")]
        public virtual oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupIdcsLastModifiedByList\"}")]
        public virtual oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupIdcsLastModifiedByList>()!;
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

        [JsiiProperty(name: "members", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupMembersList\"}")]
        public virtual oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupMembersList Members
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupMembersList>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupMetaList\"}")]
        public virtual oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupMetaList Meta
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupMetaList>()!;
        }

        [JsiiProperty(name: "nonUniqueDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NonUniqueDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ocid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Schemas
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupTagsList Tags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupTagsList>()!;
        }

        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensiondbcsGroup", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiondbcsGroupList\"}")]
        public virtual oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiondbcsGroupList UrnietfparamsscimschemasoracleidcsextensiondbcsGroup
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiondbcsGroupList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensiondynamicGroup", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiondynamicGroupList\"}")]
        public virtual oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiondynamicGroupList UrnietfparamsscimschemasoracleidcsextensiondynamicGroup
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiondynamicGroupList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensiongroupGroup", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiongroupGroupList\"}")]
        public virtual oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiongroupGroupList UrnietfparamsscimschemasoracleidcsextensiongroupGroup
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiongroupGroupList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionOciTags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsList UrnietfparamsscimschemasoracleidcsextensionOciTags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionOciTagsList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionposixGroup", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionposixGroupList\"}")]
        public virtual oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionposixGroupList UrnietfparamsscimschemasoracleidcsextensionposixGroup
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionposixGroupList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionrequestableGroup", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionrequestableGroupList\"}")]
        public virtual oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionrequestableGroupList UrnietfparamsscimschemasoracleidcsextensionrequestableGroup
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsGroup.DataOciIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionrequestableGroupList>()!;
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
        [JsiiProperty(name: "groupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GroupIdInput
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
        [JsiiProperty(name: "resourceTypeSchemaVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceTypeSchemaVersionInput
        {
            get => GetInstanceProperty<string?>();
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

        [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GroupId
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

        [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceTypeSchemaVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
