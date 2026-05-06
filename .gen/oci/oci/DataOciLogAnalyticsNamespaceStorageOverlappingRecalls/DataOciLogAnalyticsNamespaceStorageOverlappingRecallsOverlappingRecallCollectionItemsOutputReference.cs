using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciLogAnalyticsNamespaceStorageOverlappingRecalls
{
    [JsiiClass(nativeType: typeof(oci.DataOciLogAnalyticsNamespaceStorageOverlappingRecalls.DataOciLogAnalyticsNamespaceStorageOverlappingRecallsOverlappingRecallCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciLogAnalyticsNamespaceStorageOverlappingRecalls.DataOciLogAnalyticsNamespaceStorageOverlappingRecallsOverlappingRecallCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciLogAnalyticsNamespaceStorageOverlappingRecallsOverlappingRecallCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciLogAnalyticsNamespaceStorageOverlappingRecallsOverlappingRecallCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciLogAnalyticsNamespaceStorageOverlappingRecallsOverlappingRecallCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciLogAnalyticsNamespaceStorageOverlappingRecallsOverlappingRecallCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "collectionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CollectionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logSets", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogSets
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "purpose", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Purpose
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "queryString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string QueryString
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "recallId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RecallId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeDataEnded", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeDataEnded
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeDataStarted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeDataStarted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeStarted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStarted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciLogAnalyticsNamespaceStorageOverlappingRecalls.DataOciLogAnalyticsNamespaceStorageOverlappingRecallsOverlappingRecallCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciLogAnalyticsNamespaceStorageOverlappingRecalls.IDataOciLogAnalyticsNamespaceStorageOverlappingRecallsOverlappingRecallCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciLogAnalyticsNamespaceStorageOverlappingRecalls.IDataOciLogAnalyticsNamespaceStorageOverlappingRecallsOverlappingRecallCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
