using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciPsqlInsightCapabilities
{
    [JsiiClass(nativeType: typeof(oci.DataOciPsqlInsightCapabilities.DataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilitiesSortingOutputReference), fullyQualifiedName: "oci.dataOciPsqlInsightCapabilities.DataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilitiesSortingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilitiesSortingOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilitiesSortingOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilitiesSortingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilitiesSortingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "defaultSort", typeJson: "{\"fqn\":\"oci.dataOciPsqlInsightCapabilities.DataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilitiesSortingDefaultSortList\"}")]
        public virtual oci.DataOciPsqlInsightCapabilities.DataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilitiesSortingDefaultSortList DefaultSort
        {
            get => GetInstanceProperty<oci.DataOciPsqlInsightCapabilities.DataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilitiesSortingDefaultSortList>()!;
        }

        [JsiiProperty(name: "fields", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Fields
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "isSupported", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSupported
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciPsqlInsightCapabilities.DataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilitiesSorting\"}", isOptional: true)]
        public virtual oci.DataOciPsqlInsightCapabilities.IDataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilitiesSorting? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciPsqlInsightCapabilities.IDataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilitiesSorting?>();
            set => SetInstanceProperty(value);
        }
    }
}
