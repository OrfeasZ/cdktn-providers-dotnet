using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatasciencePipelines
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesStepDetailsOutputReference), fullyQualifiedName: "oci.dataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesStepDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatasciencePipelinesPipelinesStepDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatasciencePipelinesPipelinesStepDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatasciencePipelinesPipelinesStepDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatasciencePipelinesPipelinesStepDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "applicationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DependsOn
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isArtifactUploaded", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsArtifactUploaded
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "jobId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stepConfigurationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesStepDetailsStepConfigurationDetailsList\"}")]
        public virtual oci.DataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesStepDetailsStepConfigurationDetailsList StepConfigurationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesStepDetailsStepConfigurationDetailsList>()!;
        }

        [JsiiProperty(name: "stepContainerConfigurationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesStepDetailsStepContainerConfigurationDetailsList\"}")]
        public virtual oci.DataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesStepDetailsStepContainerConfigurationDetailsList StepContainerConfigurationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesStepDetailsStepContainerConfigurationDetailsList>()!;
        }

        [JsiiProperty(name: "stepDataflowConfigurationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesStepDetailsStepDataflowConfigurationDetailsList\"}")]
        public virtual oci.DataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesStepDetailsStepDataflowConfigurationDetailsList StepDataflowConfigurationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesStepDetailsStepDataflowConfigurationDetailsList>()!;
        }

        [JsiiProperty(name: "stepInfrastructureConfigurationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesStepDetailsStepInfrastructureConfigurationDetailsList\"}")]
        public virtual oci.DataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesStepDetailsStepInfrastructureConfigurationDetailsList StepInfrastructureConfigurationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesStepDetailsStepInfrastructureConfigurationDetailsList>()!;
        }

        [JsiiProperty(name: "stepName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StepName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stepParameters", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesStepDetailsStepParametersList\"}")]
        public virtual oci.DataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesStepDetailsStepParametersList StepParameters
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesStepDetailsStepParametersList>()!;
        }

        [JsiiProperty(name: "stepRunName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StepRunName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stepStorageMountConfigurationDetailsList", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesStepDetailsStepStorageMountConfigurationDetailsListStructList\"}")]
        public virtual oci.DataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesStepDetailsStepStorageMountConfigurationDetailsListStructList StepStorageMountConfigurationDetailsList
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesStepDetailsStepStorageMountConfigurationDetailsListStructList>()!;
        }

        [JsiiProperty(name: "stepType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StepType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesStepDetails\"}", isOptional: true)]
        public virtual oci.DataOciDatasciencePipelines.IDataOciDatasciencePipelinesPipelinesStepDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipelines.IDataOciDatasciencePipelinesPipelinesStepDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
