using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciGdpGdpPipelines
{
    [JsiiClass(nativeType: typeof(oci.DataOciGdpGdpPipelines.DataOciGdpGdpPipelinesGdpPipelineCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciGdpGdpPipelines.DataOciGdpGdpPipelinesGdpPipelineCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciGdpGdpPipelinesGdpPipelineCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciGdpGdpPipelinesGdpPipelineCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciGdpGdpPipelinesGdpPipelineCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciGdpGdpPipelinesGdpPipelineCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "approvalKeyVaultId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApprovalKeyVaultId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "authorizationDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthorizationDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bucketDetails", typeJson: "{\"fqn\":\"oci.dataOciGdpGdpPipelines.DataOciGdpGdpPipelinesGdpPipelineCollectionItemsBucketDetailsList\"}")]
        public virtual oci.DataOciGdpGdpPipelines.DataOciGdpGdpPipelinesGdpPipelineCollectionItemsBucketDetailsList BucketDetails
        {
            get => GetInstanceProperty<oci.DataOciGdpGdpPipelines.DataOciGdpGdpPipelinesGdpPipelineCollectionItemsBucketDetailsList>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "env", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Env
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fileTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] FileTypes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isApprovalNeeded", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsApprovalNeeded
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isChunkingEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsChunkingEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isFileOverrideInDestinationEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsFileOverrideInDestinationEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isScanningEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsScanningEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peeredGdpPipelineId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeeredGdpPipelineId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peeringRegion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeeringRegion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pipelineType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PipelineType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceLogGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceLogGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciGdpGdpPipelines.DataOciGdpGdpPipelinesGdpPipelineCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciGdpGdpPipelines.IDataOciGdpGdpPipelinesGdpPipelineCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciGdpGdpPipelines.IDataOciGdpGdpPipelinesGdpPipelineCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
