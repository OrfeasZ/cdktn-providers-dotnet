using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsCloudGates
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsCloudGates.DataOciIdentityDomainsCloudGatesCloudGatesOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsCloudGates.DataOciIdentityDomainsCloudGatesCloudGatesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsCloudGatesCloudGatesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsCloudGatesCloudGatesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsCloudGatesCloudGatesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsCloudGatesCloudGatesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "active", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Active
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "attributes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Attributes
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "attributeSets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AttributeSets
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Authorization
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsCloudGates.DataOciIdentityDomainsCloudGatesCloudGatesIdcsCreatedByList\"}")]
        public virtual oci.DataOciIdentityDomainsCloudGates.DataOciIdentityDomainsCloudGatesCloudGatesIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsCloudGates.DataOciIdentityDomainsCloudGatesCloudGatesIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsCloudGates.DataOciIdentityDomainsCloudGatesCloudGatesIdcsLastModifiedByList\"}")]
        public virtual oci.DataOciIdentityDomainsCloudGates.DataOciIdentityDomainsCloudGatesCloudGatesIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsCloudGates.DataOciIdentityDomainsCloudGatesCloudGatesIdcsLastModifiedByList>()!;
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

        [JsiiProperty(name: "lastModifiedTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastModifiedTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mappings", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsCloudGates.DataOciIdentityDomainsCloudGatesCloudGatesMappingsList\"}")]
        public virtual oci.DataOciIdentityDomainsCloudGates.DataOciIdentityDomainsCloudGatesCloudGatesMappingsList Mappings
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsCloudGates.DataOciIdentityDomainsCloudGatesCloudGatesMappingsList>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsCloudGates.DataOciIdentityDomainsCloudGatesCloudGatesMetaList\"}")]
        public virtual oci.DataOciIdentityDomainsCloudGates.DataOciIdentityDomainsCloudGatesCloudGatesMetaList Meta
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsCloudGates.DataOciIdentityDomainsCloudGatesCloudGatesMetaList>()!;
        }

        [JsiiProperty(name: "oauthClient", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsCloudGates.DataOciIdentityDomainsCloudGatesCloudGatesOauthClientList\"}")]
        public virtual oci.DataOciIdentityDomainsCloudGates.DataOciIdentityDomainsCloudGatesCloudGatesOauthClientList OauthClient
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsCloudGates.DataOciIdentityDomainsCloudGatesCloudGatesOauthClientList>()!;
        }

        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ocid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceTypeSchemaVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Schemas
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "servers", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsCloudGates.DataOciIdentityDomainsCloudGatesCloudGatesServersList\"}")]
        public virtual oci.DataOciIdentityDomainsCloudGates.DataOciIdentityDomainsCloudGatesCloudGatesServersList Servers
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsCloudGates.DataOciIdentityDomainsCloudGatesCloudGatesServersList>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsCloudGates.DataOciIdentityDomainsCloudGatesCloudGatesTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsCloudGates.DataOciIdentityDomainsCloudGatesCloudGatesTagsList Tags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsCloudGates.DataOciIdentityDomainsCloudGatesCloudGatesTagsList>()!;
        }

        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "upstreamServerGroups", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsCloudGates.DataOciIdentityDomainsCloudGatesCloudGatesUpstreamServerGroupsList\"}")]
        public virtual oci.DataOciIdentityDomainsCloudGates.DataOciIdentityDomainsCloudGatesCloudGatesUpstreamServerGroupsList UpstreamServerGroups
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsCloudGates.DataOciIdentityDomainsCloudGatesCloudGatesUpstreamServerGroupsList>()!;
        }

        [JsiiProperty(name: "upstreamServers", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsCloudGates.DataOciIdentityDomainsCloudGatesCloudGatesUpstreamServersList\"}")]
        public virtual oci.DataOciIdentityDomainsCloudGates.DataOciIdentityDomainsCloudGatesCloudGatesUpstreamServersList UpstreamServers
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsCloudGates.DataOciIdentityDomainsCloudGatesCloudGatesUpstreamServersList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsCloudGates.DataOciIdentityDomainsCloudGatesCloudGates\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsCloudGates.IDataOciIdentityDomainsCloudGatesCloudGates? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsCloudGates.IDataOciIdentityDomainsCloudGatesCloudGates?>();
            set => SetInstanceProperty(value);
        }
    }
}
