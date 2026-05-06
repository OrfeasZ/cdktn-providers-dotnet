using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFleetSoftwareUpdateFsuCollection
{
    [JsiiClass(nativeType: typeof(oci.DataOciFleetSoftwareUpdateFsuCollection.DataOciFleetSoftwareUpdateFsuCollectionFleetDiscoveryFiltersOutputReference), fullyQualifiedName: "oci.dataOciFleetSoftwareUpdateFsuCollection.DataOciFleetSoftwareUpdateFsuCollectionFleetDiscoveryFiltersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciFleetSoftwareUpdateFsuCollectionFleetDiscoveryFiltersOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciFleetSoftwareUpdateFsuCollectionFleetDiscoveryFiltersOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciFleetSoftwareUpdateFsuCollectionFleetDiscoveryFiltersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFleetSoftwareUpdateFsuCollectionFleetDiscoveryFiltersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "entityType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EntityType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "exadataReleases", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ExadataReleases
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "identifiers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Identifiers
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Mode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "names", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Names
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Operator
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.dataOciFleetSoftwareUpdateFsuCollection.DataOciFleetSoftwareUpdateFsuCollectionFleetDiscoveryFiltersTagsList\"}")]
        public virtual oci.DataOciFleetSoftwareUpdateFsuCollection.DataOciFleetSoftwareUpdateFsuCollectionFleetDiscoveryFiltersTagsList Tags
        {
            get => GetInstanceProperty<oci.DataOciFleetSoftwareUpdateFsuCollection.DataOciFleetSoftwareUpdateFsuCollectionFleetDiscoveryFiltersTagsList>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "versions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Versions
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciFleetSoftwareUpdateFsuCollection.DataOciFleetSoftwareUpdateFsuCollectionFleetDiscoveryFilters\"}", isOptional: true)]
        public virtual oci.DataOciFleetSoftwareUpdateFsuCollection.IDataOciFleetSoftwareUpdateFsuCollectionFleetDiscoveryFilters? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciFleetSoftwareUpdateFsuCollection.IDataOciFleetSoftwareUpdateFsuCollectionFleetDiscoveryFilters?>();
            set => SetInstanceProperty(value);
        }
    }
}
