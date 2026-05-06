using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatasciencePipeline
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatasciencePipeline.DataOciDatasciencePipelineStepDetailsOutputReference), fullyQualifiedName: "oci.dataOciDatasciencePipeline.DataOciDatasciencePipelineStepDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatasciencePipelineStepDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatasciencePipelineStepDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatasciencePipelineStepDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatasciencePipelineStepDetailsOutputReference(DeputyProps props): base(props)
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

        [JsiiProperty(name: "stepConfigurationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipeline.DataOciDatasciencePipelineStepDetailsStepConfigurationDetailsList\"}")]
        public virtual oci.DataOciDatasciencePipeline.DataOciDatasciencePipelineStepDetailsStepConfigurationDetailsList StepConfigurationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipeline.DataOciDatasciencePipelineStepDetailsStepConfigurationDetailsList>()!;
        }

        [JsiiProperty(name: "stepContainerConfigurationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipeline.DataOciDatasciencePipelineStepDetailsStepContainerConfigurationDetailsList\"}")]
        public virtual oci.DataOciDatasciencePipeline.DataOciDatasciencePipelineStepDetailsStepContainerConfigurationDetailsList StepContainerConfigurationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipeline.DataOciDatasciencePipelineStepDetailsStepContainerConfigurationDetailsList>()!;
        }

        [JsiiProperty(name: "stepDataflowConfigurationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipeline.DataOciDatasciencePipelineStepDetailsStepDataflowConfigurationDetailsList\"}")]
        public virtual oci.DataOciDatasciencePipeline.DataOciDatasciencePipelineStepDetailsStepDataflowConfigurationDetailsList StepDataflowConfigurationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipeline.DataOciDatasciencePipelineStepDetailsStepDataflowConfigurationDetailsList>()!;
        }

        [JsiiProperty(name: "stepInfrastructureConfigurationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipeline.DataOciDatasciencePipelineStepDetailsStepInfrastructureConfigurationDetailsList\"}")]
        public virtual oci.DataOciDatasciencePipeline.DataOciDatasciencePipelineStepDetailsStepInfrastructureConfigurationDetailsList StepInfrastructureConfigurationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipeline.DataOciDatasciencePipelineStepDetailsStepInfrastructureConfigurationDetailsList>()!;
        }

        [JsiiProperty(name: "stepName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StepName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stepParameters", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipeline.DataOciDatasciencePipelineStepDetailsStepParametersList\"}")]
        public virtual oci.DataOciDatasciencePipeline.DataOciDatasciencePipelineStepDetailsStepParametersList StepParameters
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipeline.DataOciDatasciencePipelineStepDetailsStepParametersList>()!;
        }

        [JsiiProperty(name: "stepRunName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StepRunName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stepStorageMountConfigurationDetailsList", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipeline.DataOciDatasciencePipelineStepDetailsStepStorageMountConfigurationDetailsListStructList\"}")]
        public virtual oci.DataOciDatasciencePipeline.DataOciDatasciencePipelineStepDetailsStepStorageMountConfigurationDetailsListStructList StepStorageMountConfigurationDetailsList
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipeline.DataOciDatasciencePipelineStepDetailsStepStorageMountConfigurationDetailsListStructList>()!;
        }

        [JsiiProperty(name: "stepType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StepType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipeline.DataOciDatasciencePipelineStepDetails\"}", isOptional: true)]
        public virtual oci.DataOciDatasciencePipeline.IDataOciDatasciencePipelineStepDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipeline.IDataOciDatasciencePipelineStepDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
