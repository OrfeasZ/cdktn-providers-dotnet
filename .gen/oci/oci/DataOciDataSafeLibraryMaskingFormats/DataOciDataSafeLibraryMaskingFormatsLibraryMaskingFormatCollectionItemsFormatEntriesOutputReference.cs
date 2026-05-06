using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeLibraryMaskingFormats
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeLibraryMaskingFormats.DataOciDataSafeLibraryMaskingFormatsLibraryMaskingFormatCollectionItemsFormatEntriesOutputReference), fullyQualifiedName: "oci.dataOciDataSafeLibraryMaskingFormats.DataOciDataSafeLibraryMaskingFormatsLibraryMaskingFormatCollectionItemsFormatEntriesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataSafeLibraryMaskingFormatsLibraryMaskingFormatCollectionItemsFormatEntriesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataSafeLibraryMaskingFormatsLibraryMaskingFormatCollectionItemsFormatEntriesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataSafeLibraryMaskingFormatsLibraryMaskingFormatCollectionItemsFormatEntriesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeLibraryMaskingFormatsLibraryMaskingFormatCollectionItemsFormatEntriesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "columnName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ColumnName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EndLength
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "endValue", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EndValue
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "fixedNumber", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FixedNumber
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "fixedString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FixedString
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "groupingColumns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] GroupingColumns
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "length", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Length
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "libraryMaskingFormatId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LibraryMaskingFormatId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pattern", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Pattern
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "postProcessingFunction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PostProcessingFunction
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "randomList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RandomList
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "regularExpression", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegularExpression
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "replaceWith", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplaceWith
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "schemaName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SchemaName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sqlExpression", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SqlExpression
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "startDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "startLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StartLength
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "startPosition", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StartPosition
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "startValue", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StartValue
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TableName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userDefinedFunction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserDefinedFunction
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataSafeLibraryMaskingFormats.DataOciDataSafeLibraryMaskingFormatsLibraryMaskingFormatCollectionItemsFormatEntries\"}", isOptional: true)]
        public virtual oci.DataOciDataSafeLibraryMaskingFormats.IDataOciDataSafeLibraryMaskingFormatsLibraryMaskingFormatCollectionItemsFormatEntries? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataSafeLibraryMaskingFormats.IDataOciDataSafeLibraryMaskingFormatsLibraryMaskingFormatCollectionItemsFormatEntries?>();
            set => SetInstanceProperty(value);
        }
    }
}
