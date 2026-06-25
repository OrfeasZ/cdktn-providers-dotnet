using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciPsqlInsightCapabilities
{
    [JsiiClass(nativeType: typeof(oci.DataOciPsqlInsightCapabilities.DataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilitiesOutputReference), fullyQualifiedName: "oci.dataOciPsqlInsightCapabilities.DataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilitiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilitiesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilitiesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilitiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilitiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "dataContract", typeJson: "{\"fqn\":\"oci.dataOciPsqlInsightCapabilities.DataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilitiesDataContractList\"}")]
        public virtual oci.DataOciPsqlInsightCapabilities.DataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilitiesDataContractList DataContract
        {
            get => GetInstanceProperty<oci.DataOciPsqlInsightCapabilities.DataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilitiesDataContractList>()!;
        }

        [JsiiProperty(name: "dateTimeRangeSupport", typeJson: "{\"fqn\":\"oci.dataOciPsqlInsightCapabilities.DataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilitiesDateTimeRangeSupportList\"}")]
        public virtual oci.DataOciPsqlInsightCapabilities.DataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilitiesDateTimeRangeSupportList DateTimeRangeSupport
        {
            get => GetInstanceProperty<oci.DataOciPsqlInsightCapabilities.DataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilitiesDateTimeRangeSupportList>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "filters", typeJson: "{\"fqn\":\"oci.dataOciPsqlInsightCapabilities.DataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilitiesFiltersList\"}")]
        public virtual oci.DataOciPsqlInsightCapabilities.DataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilitiesFiltersList Filters
        {
            get => GetInstanceProperty<oci.DataOciPsqlInsightCapabilities.DataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilitiesFiltersList>()!;
        }

        [JsiiProperty(name: "granularity", typeJson: "{\"fqn\":\"oci.dataOciPsqlInsightCapabilities.DataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilitiesGranularityList\"}")]
        public virtual oci.DataOciPsqlInsightCapabilities.DataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilitiesGranularityList Granularity
        {
            get => GetInstanceProperty<oci.DataOciPsqlInsightCapabilities.DataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilitiesGranularityList>()!;
        }

        [JsiiProperty(name: "insightDataType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InsightDataType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "limits", typeJson: "{\"fqn\":\"oci.dataOciPsqlInsightCapabilities.DataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilitiesLimitsList\"}")]
        public virtual oci.DataOciPsqlInsightCapabilities.DataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilitiesLimitsList Limits
        {
            get => GetInstanceProperty<oci.DataOciPsqlInsightCapabilities.DataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilitiesLimitsList>()!;
        }

        [JsiiProperty(name: "pagination", typeJson: "{\"fqn\":\"oci.dataOciPsqlInsightCapabilities.DataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilitiesPaginationList\"}")]
        public virtual oci.DataOciPsqlInsightCapabilities.DataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilitiesPaginationList Pagination
        {
            get => GetInstanceProperty<oci.DataOciPsqlInsightCapabilities.DataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilitiesPaginationList>()!;
        }

        [JsiiProperty(name: "sorting", typeJson: "{\"fqn\":\"oci.dataOciPsqlInsightCapabilities.DataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilitiesSortingList\"}")]
        public virtual oci.DataOciPsqlInsightCapabilities.DataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilitiesSortingList Sorting
        {
            get => GetInstanceProperty<oci.DataOciPsqlInsightCapabilities.DataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilitiesSortingList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciPsqlInsightCapabilities.DataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilities\"}", isOptional: true)]
        public virtual oci.DataOciPsqlInsightCapabilities.IDataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilities? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciPsqlInsightCapabilities.IDataOciPsqlInsightCapabilitiesInsightCapabilityCollectionItemsDataTypeCapabilities?>();
            set => SetInstanceProperty(value);
        }
    }
}
