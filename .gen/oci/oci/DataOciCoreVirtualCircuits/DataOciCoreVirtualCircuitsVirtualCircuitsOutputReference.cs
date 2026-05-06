using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCoreVirtualCircuits
{
    [JsiiClass(nativeType: typeof(oci.DataOciCoreVirtualCircuits.DataOciCoreVirtualCircuitsVirtualCircuitsOutputReference), fullyQualifiedName: "oci.dataOciCoreVirtualCircuits.DataOciCoreVirtualCircuitsVirtualCircuitsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCoreVirtualCircuitsVirtualCircuitsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCoreVirtualCircuitsVirtualCircuitsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCoreVirtualCircuitsVirtualCircuitsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreVirtualCircuitsVirtualCircuitsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "bandwidthShapeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BandwidthShapeName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bgpAdminState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BgpAdminState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bgpIpv6SessionState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BgpIpv6SessionState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bgpManagement", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BgpManagement
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bgpSessionState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BgpSessionState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "crossConnectMappings", typeJson: "{\"fqn\":\"oci.dataOciCoreVirtualCircuits.DataOciCoreVirtualCircuitsVirtualCircuitsCrossConnectMappingsList\"}")]
        public virtual oci.DataOciCoreVirtualCircuits.DataOciCoreVirtualCircuitsVirtualCircuitsCrossConnectMappingsList CrossConnectMappings
        {
            get => GetInstanceProperty<oci.DataOciCoreVirtualCircuits.DataOciCoreVirtualCircuitsVirtualCircuitsCrossConnectMappingsList>()!;
        }

        [JsiiProperty(name: "customerAsn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerAsn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customerBgpAsn", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CustomerBgpAsn
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "gatewayId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GatewayId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipMtu", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpMtu
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isBfdEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsBfdEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isTransportMode", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsTransportMode
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "oracleBgpAsn", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OracleBgpAsn
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "providerServiceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProviderServiceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "providerServiceKeyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProviderServiceKeyName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "providerState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProviderState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicPrefixes", typeJson: "{\"fqn\":\"oci.dataOciCoreVirtualCircuits.DataOciCoreVirtualCircuitsVirtualCircuitsPublicPrefixesList\"}")]
        public virtual oci.DataOciCoreVirtualCircuits.DataOciCoreVirtualCircuitsVirtualCircuitsPublicPrefixesList PublicPrefixes
        {
            get => GetInstanceProperty<oci.DataOciCoreVirtualCircuits.DataOciCoreVirtualCircuitsVirtualCircuitsPublicPrefixesList>()!;
        }

        [JsiiProperty(name: "referenceComment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReferenceComment
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "routingPolicy", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RoutingPolicy
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "serviceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "virtualCircuitId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VirtualCircuitId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "virtualCircuitRedundancyMetadata", typeJson: "{\"fqn\":\"oci.dataOciCoreVirtualCircuits.DataOciCoreVirtualCircuitsVirtualCircuitsVirtualCircuitRedundancyMetadataList\"}")]
        public virtual oci.DataOciCoreVirtualCircuits.DataOciCoreVirtualCircuitsVirtualCircuitsVirtualCircuitRedundancyMetadataList VirtualCircuitRedundancyMetadata
        {
            get => GetInstanceProperty<oci.DataOciCoreVirtualCircuits.DataOciCoreVirtualCircuitsVirtualCircuitsVirtualCircuitRedundancyMetadataList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCoreVirtualCircuits.DataOciCoreVirtualCircuitsVirtualCircuits\"}", isOptional: true)]
        public virtual oci.DataOciCoreVirtualCircuits.IDataOciCoreVirtualCircuitsVirtualCircuits? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCoreVirtualCircuits.IDataOciCoreVirtualCircuitsVirtualCircuits?>();
            set => SetInstanceProperty(value);
        }
    }
}
