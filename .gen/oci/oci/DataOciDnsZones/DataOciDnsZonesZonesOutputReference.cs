using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDnsZones
{
    [JsiiClass(nativeType: typeof(oci.DataOciDnsZones.DataOciDnsZonesZonesOutputReference), fullyQualifiedName: "oci.dataOciDnsZones.DataOciDnsZonesZonesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDnsZonesZonesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDnsZonesZonesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDnsZonesZonesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDnsZonesZonesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "dnssecConfig", typeJson: "{\"fqn\":\"oci.dataOciDnsZones.DataOciDnsZonesZonesDnssecConfigList\"}")]
        public virtual oci.DataOciDnsZones.DataOciDnsZonesZonesDnssecConfigList DnssecConfig
        {
            get => GetInstanceProperty<oci.DataOciDnsZones.DataOciDnsZonesZonesDnssecConfigList>()!;
        }

        [JsiiProperty(name: "dnssecState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DnssecState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "externalDownstreams", typeJson: "{\"fqn\":\"oci.dataOciDnsZones.DataOciDnsZonesZonesExternalDownstreamsList\"}")]
        public virtual oci.DataOciDnsZones.DataOciDnsZonesZonesExternalDownstreamsList ExternalDownstreams
        {
            get => GetInstanceProperty<oci.DataOciDnsZones.DataOciDnsZonesZonesExternalDownstreamsList>()!;
        }

        [JsiiProperty(name: "externalMasters", typeJson: "{\"fqn\":\"oci.dataOciDnsZones.DataOciDnsZonesZonesExternalMastersList\"}")]
        public virtual oci.DataOciDnsZones.DataOciDnsZonesZonesExternalMastersList ExternalMasters
        {
            get => GetInstanceProperty<oci.DataOciDnsZones.DataOciDnsZonesZonesExternalMastersList>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isProtected", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsProtected
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nameservers", typeJson: "{\"fqn\":\"oci.dataOciDnsZones.DataOciDnsZonesZonesNameserversList\"}")]
        public virtual oci.DataOciDnsZones.DataOciDnsZonesZonesNameserversList Nameservers
        {
            get => GetInstanceProperty<oci.DataOciDnsZones.DataOciDnsZonesZonesNameserversList>()!;
        }

        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Scope
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "selfAttribute", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SelfAttribute
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serial", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Serial
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "viewId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ViewId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "zoneTransferServers", typeJson: "{\"fqn\":\"oci.dataOciDnsZones.DataOciDnsZonesZonesZoneTransferServersList\"}")]
        public virtual oci.DataOciDnsZones.DataOciDnsZonesZonesZoneTransferServersList ZoneTransferServers
        {
            get => GetInstanceProperty<oci.DataOciDnsZones.DataOciDnsZonesZonesZoneTransferServersList>()!;
        }

        [JsiiProperty(name: "zoneType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ZoneType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDnsZones.DataOciDnsZonesZones\"}", isOptional: true)]
        public virtual oci.DataOciDnsZones.IDataOciDnsZonesZones? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDnsZones.IDataOciDnsZonesZones?>();
            set => SetInstanceProperty(value);
        }
    }
}
