using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsCloudGateMappings
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsCloudGateMappings.DataOciIdentityDomainsCloudGateMappingsCloudGateMappingsOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsCloudGateMappings.DataOciIdentityDomainsCloudGateMappingsCloudGateMappingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsCloudGateMappingsCloudGateMappingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsCloudGateMappingsCloudGateMappingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsCloudGateMappingsCloudGateMappingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsCloudGateMappingsCloudGateMappingsOutputReference(DeputyProps props): base(props)
        {
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

        [JsiiProperty(name: "cloudGate", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsCloudGateMappings.DataOciIdentityDomainsCloudGateMappingsCloudGateMappingsCloudGateList\"}")]
        public virtual oci.DataOciIdentityDomainsCloudGateMappings.DataOciIdentityDomainsCloudGateMappingsCloudGateMappingsCloudGateList CloudGate
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsCloudGateMappings.DataOciIdentityDomainsCloudGateMappingsCloudGateMappingsCloudGateList>()!;
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

        [JsiiProperty(name: "domainOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "gatewayApp", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsCloudGateMappings.DataOciIdentityDomainsCloudGateMappingsCloudGateMappingsGatewayAppList\"}")]
        public virtual oci.DataOciIdentityDomainsCloudGateMappings.DataOciIdentityDomainsCloudGateMappingsCloudGateMappingsGatewayAppList GatewayApp
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsCloudGateMappings.DataOciIdentityDomainsCloudGateMappingsCloudGateMappingsGatewayAppList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsCloudGateMappings.DataOciIdentityDomainsCloudGateMappingsCloudGateMappingsIdcsCreatedByList\"}")]
        public virtual oci.DataOciIdentityDomainsCloudGateMappings.DataOciIdentityDomainsCloudGateMappingsCloudGateMappingsIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsCloudGateMappings.DataOciIdentityDomainsCloudGateMappingsCloudGateMappingsIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsCloudGateMappings.DataOciIdentityDomainsCloudGateMappingsCloudGateMappingsIdcsLastModifiedByList\"}")]
        public virtual oci.DataOciIdentityDomainsCloudGateMappings.DataOciIdentityDomainsCloudGateMappingsCloudGateMappingsIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsCloudGateMappings.DataOciIdentityDomainsCloudGateMappingsCloudGateMappingsIdcsLastModifiedByList>()!;
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

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsCloudGateMappings.DataOciIdentityDomainsCloudGateMappingsCloudGateMappingsMetaList\"}")]
        public virtual oci.DataOciIdentityDomainsCloudGateMappings.DataOciIdentityDomainsCloudGateMappingsCloudGateMappingsMetaList Meta
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsCloudGateMappings.DataOciIdentityDomainsCloudGateMappingsCloudGateMappingsMetaList>()!;
        }

        [JsiiProperty(name: "nginxSettings", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NginxSettings
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ocid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "policyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PolicyName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "proxyPass", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProxyPass
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourcePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourcePrefix
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

        [JsiiProperty(name: "server", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsCloudGateMappings.DataOciIdentityDomainsCloudGateMappingsCloudGateMappingsServerList\"}")]
        public virtual oci.DataOciIdentityDomainsCloudGateMappings.DataOciIdentityDomainsCloudGateMappingsCloudGateMappingsServerList Server
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsCloudGateMappings.DataOciIdentityDomainsCloudGateMappingsCloudGateMappingsServerList>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsCloudGateMappings.DataOciIdentityDomainsCloudGateMappingsCloudGateMappingsTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsCloudGateMappings.DataOciIdentityDomainsCloudGateMappingsCloudGateMappingsTagsList Tags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsCloudGateMappings.DataOciIdentityDomainsCloudGateMappingsCloudGateMappingsTagsList>()!;
        }

        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "upstreamServerGroup", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsCloudGateMappings.DataOciIdentityDomainsCloudGateMappingsCloudGateMappingsUpstreamServerGroupList\"}")]
        public virtual oci.DataOciIdentityDomainsCloudGateMappings.DataOciIdentityDomainsCloudGateMappingsCloudGateMappingsUpstreamServerGroupList UpstreamServerGroup
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsCloudGateMappings.DataOciIdentityDomainsCloudGateMappingsCloudGateMappingsUpstreamServerGroupList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsCloudGateMappings.DataOciIdentityDomainsCloudGateMappingsCloudGateMappings\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsCloudGateMappings.IDataOciIdentityDomainsCloudGateMappingsCloudGateMappings? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsCloudGateMappings.IDataOciIdentityDomainsCloudGateMappingsCloudGateMappings?>();
            set => SetInstanceProperty(value);
        }
    }
}
