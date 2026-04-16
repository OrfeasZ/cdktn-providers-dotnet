using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanGradientaiIndexingJobDataSources
{
    [JsiiClass(nativeType: typeof(digitalocean.DataDigitaloceanGradientaiIndexingJobDataSources.DataDigitaloceanGradientaiIndexingJobDataSourcesIndexedDataSourcesOutputReference), fullyQualifiedName: "digitalocean.dataDigitaloceanGradientaiIndexingJobDataSources.DataDigitaloceanGradientaiIndexingJobDataSourcesIndexedDataSourcesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataDigitaloceanGradientaiIndexingJobDataSourcesIndexedDataSourcesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataDigitaloceanGradientaiIndexingJobDataSourcesIndexedDataSourcesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataDigitaloceanGradientaiIndexingJobDataSourcesIndexedDataSourcesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanGradientaiIndexingJobDataSourcesIndexedDataSourcesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "completedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompletedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataSourceUuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataSourceUuid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "errorDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ErrorDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "errorMsg", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ErrorMsg
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "failedItemCount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FailedItemCount
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "indexedFileCount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IndexedFileCount
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "indexedItemCount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IndexedItemCount
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "removedItemCount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RemovedItemCount
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "skippedItemCount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SkippedItemCount
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "startedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalBytes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalBytes
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalBytesIndexed", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalBytesIndexed
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalFileCount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalFileCount
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiIndexingJobDataSources.DataDigitaloceanGradientaiIndexingJobDataSourcesIndexedDataSources\"}", isOptional: true)]
        public virtual digitalocean.DataDigitaloceanGradientaiIndexingJobDataSources.IDataDigitaloceanGradientaiIndexingJobDataSourcesIndexedDataSources? InternalValue
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiIndexingJobDataSources.IDataDigitaloceanGradientaiIndexingJobDataSourcesIndexedDataSources?>();
            set => SetInstanceProperty(value);
        }
    }
}
