using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDnsZones
{
    [JsiiClass(nativeType: typeof(oci.DataOciDnsZones.DataOciDnsZonesZonesDnssecConfigZskDnssecKeyVersionsOutputReference), fullyQualifiedName: "oci.dataOciDnsZones.DataOciDnsZonesZonesDnssecConfigZskDnssecKeyVersionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDnsZonesZonesDnssecConfigZskDnssecKeyVersionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDnsZonesZonesDnssecConfigZskDnssecKeyVersionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDnsZonesZonesDnssecConfigZskDnssecKeyVersionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDnsZonesZonesDnssecConfigZskDnssecKeyVersionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "algorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Algorithm
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyTag", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double KeyTag
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "lengthInBytes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LengthInBytes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "predecessorDnssecKeyVersionUuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PredecessorDnssecKeyVersionUuid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "successorDnssecKeyVersionUuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SuccessorDnssecKeyVersionUuid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeActivated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeActivated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeExpired", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeExpired
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeInactivated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeInactivated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timePromoted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimePromoted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timePublished", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimePublished
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUnpublished", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUnpublished
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Uuid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDnsZones.DataOciDnsZonesZonesDnssecConfigZskDnssecKeyVersions\"}", isOptional: true)]
        public virtual oci.DataOciDnsZones.IDataOciDnsZonesZonesDnssecConfigZskDnssecKeyVersions? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDnsZones.IDataOciDnsZonesZonesDnssecConfigZskDnssecKeyVersions?>();
            set => SetInstanceProperty(value);
        }
    }
}
