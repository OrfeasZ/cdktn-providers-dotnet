using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciJmsUtilsJavaMigrationAnalysis
{
    [JsiiClass(nativeType: typeof(oci.DataOciJmsUtilsJavaMigrationAnalysis.DataOciJmsUtilsJavaMigrationAnalysisJavaMigrationAnalysisCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciJmsUtilsJavaMigrationAnalysis.DataOciJmsUtilsJavaMigrationAnalysisJavaMigrationAnalysisCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciJmsUtilsJavaMigrationAnalysisJavaMigrationAnalysisCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciJmsUtilsJavaMigrationAnalysisJavaMigrationAnalysisCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciJmsUtilsJavaMigrationAnalysisJavaMigrationAnalysisCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciJmsUtilsJavaMigrationAnalysisJavaMigrationAnalysisCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "analysisProjectName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AnalysisProjectName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "analysisResultFiles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AnalysisResultFiles
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "analysisResultObjectStoragePath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AnalysisResultObjectStoragePath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bucket
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdBy", typeJson: "{\"fqn\":\"oci.dataOciJmsUtilsJavaMigrationAnalysis.DataOciJmsUtilsJavaMigrationAnalysisJavaMigrationAnalysisCollectionItemsCreatedByList\"}")]
        public virtual oci.DataOciJmsUtilsJavaMigrationAnalysis.DataOciJmsUtilsJavaMigrationAnalysisJavaMigrationAnalysisCollectionItemsCreatedByList CreatedBy
        {
            get => GetInstanceProperty<oci.DataOciJmsUtilsJavaMigrationAnalysis.DataOciJmsUtilsJavaMigrationAnalysisJavaMigrationAnalysisCollectionItemsCreatedByList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "inputApplicationsObjectStoragePaths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] InputApplicationsObjectStoragePaths
        {
            get => GetInstanceProperty<string[]>()!;
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

        [JsiiProperty(name: "timeFinished", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeFinished
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeStarted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStarted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "workRequestId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkRequestId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciJmsUtilsJavaMigrationAnalysis.DataOciJmsUtilsJavaMigrationAnalysisJavaMigrationAnalysisCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciJmsUtilsJavaMigrationAnalysis.IDataOciJmsUtilsJavaMigrationAnalysisJavaMigrationAnalysisCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciJmsUtilsJavaMigrationAnalysis.IDataOciJmsUtilsJavaMigrationAnalysisJavaMigrationAnalysisCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
