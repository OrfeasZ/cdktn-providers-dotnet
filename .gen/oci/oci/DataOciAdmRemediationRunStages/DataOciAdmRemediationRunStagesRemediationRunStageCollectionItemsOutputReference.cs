using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciAdmRemediationRunStages
{
    [JsiiClass(nativeType: typeof(oci.DataOciAdmRemediationRunStages.DataOciAdmRemediationRunStagesRemediationRunStageCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciAdmRemediationRunStages.DataOciAdmRemediationRunStagesRemediationRunStageCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciAdmRemediationRunStagesRemediationRunStageCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciAdmRemediationRunStagesRemediationRunStageCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciAdmRemediationRunStagesRemediationRunStageCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciAdmRemediationRunStagesRemediationRunStageCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "auditId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuditId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nextStageType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NextStageType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pipelineProperties", typeJson: "{\"fqn\":\"oci.dataOciAdmRemediationRunStages.DataOciAdmRemediationRunStagesRemediationRunStageCollectionItemsPipelinePropertiesList\"}")]
        public virtual oci.DataOciAdmRemediationRunStages.DataOciAdmRemediationRunStagesRemediationRunStageCollectionItemsPipelinePropertiesList PipelineProperties
        {
            get => GetInstanceProperty<oci.DataOciAdmRemediationRunStages.DataOciAdmRemediationRunStagesRemediationRunStageCollectionItemsPipelinePropertiesList>()!;
        }

        [JsiiProperty(name: "previousStageType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreviousStageType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pullRequestProperties", typeJson: "{\"fqn\":\"oci.dataOciAdmRemediationRunStages.DataOciAdmRemediationRunStagesRemediationRunStageCollectionItemsPullRequestPropertiesList\"}")]
        public virtual oci.DataOciAdmRemediationRunStages.DataOciAdmRemediationRunStagesRemediationRunStageCollectionItemsPullRequestPropertiesList PullRequestProperties
        {
            get => GetInstanceProperty<oci.DataOciAdmRemediationRunStages.DataOciAdmRemediationRunStagesRemediationRunStageCollectionItemsPullRequestPropertiesList>()!;
        }

        [JsiiProperty(name: "recommendedUpdatesCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RecommendedUpdatesCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "remediationRunId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RemediationRunId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "summary", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Summary
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

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciAdmRemediationRunStages.DataOciAdmRemediationRunStagesRemediationRunStageCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciAdmRemediationRunStages.IDataOciAdmRemediationRunStagesRemediationRunStageCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciAdmRemediationRunStages.IDataOciAdmRemediationRunStagesRemediationRunStageCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
