using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciJmsFleetJavaMigrationAnalysisResults
{
    [JsiiClass(nativeType: typeof(oci.DataOciJmsFleetJavaMigrationAnalysisResults.DataOciJmsFleetJavaMigrationAnalysisResultsJavaMigrationAnalysisResultCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciJmsFleetJavaMigrationAnalysisResults.DataOciJmsFleetJavaMigrationAnalysisResultsJavaMigrationAnalysisResultCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciJmsFleetJavaMigrationAnalysisResultsJavaMigrationAnalysisResultCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciJmsFleetJavaMigrationAnalysisResultsJavaMigrationAnalysisResultCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciJmsFleetJavaMigrationAnalysisResultsJavaMigrationAnalysisResultCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciJmsFleetJavaMigrationAnalysisResultsJavaMigrationAnalysisResultCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "applicationExecutionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationExecutionType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "applicationKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "applicationName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "applicationPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationPath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bucket
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fleetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FleetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hostName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managedInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedInstanceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Metadata
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Namespace
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "objectList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ObjectList
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "objectStorageUploadDirPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectStorageUploadDirPath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceJdkVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceJdkVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetJdkVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetJdkVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "workRequestId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkRequestId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciJmsFleetJavaMigrationAnalysisResults.DataOciJmsFleetJavaMigrationAnalysisResultsJavaMigrationAnalysisResultCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciJmsFleetJavaMigrationAnalysisResults.IDataOciJmsFleetJavaMigrationAnalysisResultsJavaMigrationAnalysisResultCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciJmsFleetJavaMigrationAnalysisResults.IDataOciJmsFleetJavaMigrationAnalysisResultsJavaMigrationAnalysisResultCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
