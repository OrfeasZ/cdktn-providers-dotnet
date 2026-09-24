using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciGenerativeAiModelDiscoveries
{
    [JsiiClass(nativeType: typeof(oci.DataOciGenerativeAiModelDiscoveries.DataOciGenerativeAiModelDiscoveriesModelDiscoveryCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciGenerativeAiModelDiscoveries.DataOciGenerativeAiModelDiscoveriesModelDiscoveryCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciGenerativeAiModelDiscoveriesModelDiscoveryCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciGenerativeAiModelDiscoveriesModelDiscoveryCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciGenerativeAiModelDiscoveriesModelDiscoveryCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciGenerativeAiModelDiscoveriesModelDiscoveryCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "apiCapability", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ApiCapability
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "availability", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiModelDiscoveries.DataOciGenerativeAiModelDiscoveriesModelDiscoveryCollectionItemsAvailabilityList\"}")]
        public virtual oci.DataOciGenerativeAiModelDiscoveries.DataOciGenerativeAiModelDiscoveriesModelDiscoveryCollectionItemsAvailabilityList Availability
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiModelDiscoveries.DataOciGenerativeAiModelDiscoveriesModelDiscoveryCollectionItemsAvailabilityList>()!;
        }

        [JsiiProperty(name: "capabilities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Capabilities
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "modalitySupport", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiModelDiscoveries.DataOciGenerativeAiModelDiscoveriesModelDiscoveryCollectionItemsModalitySupportList\"}")]
        public virtual oci.DataOciGenerativeAiModelDiscoveries.DataOciGenerativeAiModelDiscoveriesModelDiscoveryCollectionItemsModalitySupportList ModalitySupport
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiModelDiscoveries.DataOciGenerativeAiModelDiscoveriesModelDiscoveryCollectionItemsModalitySupportList>()!;
        }

        [JsiiProperty(name: "modelAccess", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelAccess
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parameters", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiModelDiscoveries.DataOciGenerativeAiModelDiscoveriesModelDiscoveryCollectionItemsParametersList\"}")]
        public virtual oci.DataOciGenerativeAiModelDiscoveries.DataOciGenerativeAiModelDiscoveriesModelDiscoveryCollectionItemsParametersList Parameters
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiModelDiscoveries.DataOciGenerativeAiModelDiscoveriesModelDiscoveryCollectionItemsParametersList>()!;
        }

        [JsiiProperty(name: "vendor", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Vendor
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiModelDiscoveries.DataOciGenerativeAiModelDiscoveriesModelDiscoveryCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciGenerativeAiModelDiscoveries.IDataOciGenerativeAiModelDiscoveriesModelDiscoveryCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiModelDiscoveries.IDataOciGenerativeAiModelDiscoveriesModelDiscoveryCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
