using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeMaskingReportsMaskedColumns
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeMaskingReportsMaskedColumns.DataOciDataSafeMaskingReportsMaskedColumnsMaskedColumnCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDataSafeMaskingReportsMaskedColumns.DataOciDataSafeMaskingReportsMaskedColumnsMaskedColumnCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataSafeMaskingReportsMaskedColumnsMaskedColumnCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataSafeMaskingReportsMaskedColumnsMaskedColumnCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataSafeMaskingReportsMaskedColumnsMaskedColumnCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeMaskingReportsMaskedColumnsMaskedColumnCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "columnName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ColumnName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maskingColumnGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaskingColumnGroup
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maskingFormatUsed", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaskingFormatUsed
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Object
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "objectType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parentColumnKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentColumnKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "schemaName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SchemaName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sensitiveTypeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SensitiveTypeId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalMaskedValues", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalMaskedValues
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataSafeMaskingReportsMaskedColumns.DataOciDataSafeMaskingReportsMaskedColumnsMaskedColumnCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDataSafeMaskingReportsMaskedColumns.IDataOciDataSafeMaskingReportsMaskedColumnsMaskedColumnCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataSafeMaskingReportsMaskedColumns.IDataOciDataSafeMaskingReportsMaskedColumnsMaskedColumnCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
