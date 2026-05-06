using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatasciencePipelineRun
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunStepOverrideDetailsOutputReference), fullyQualifiedName: "oci.dataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunStepOverrideDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatasciencePipelineRunStepOverrideDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatasciencePipelineRunStepOverrideDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatasciencePipelineRunStepOverrideDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatasciencePipelineRunStepOverrideDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "stepConfigurationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunStepOverrideDetailsStepConfigurationDetailsList\"}")]
        public virtual oci.DataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunStepOverrideDetailsStepConfigurationDetailsList StepConfigurationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunStepOverrideDetailsStepConfigurationDetailsList>()!;
        }

        [JsiiProperty(name: "stepContainerConfigurationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunStepOverrideDetailsStepContainerConfigurationDetailsList\"}")]
        public virtual oci.DataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunStepOverrideDetailsStepContainerConfigurationDetailsList StepContainerConfigurationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunStepOverrideDetailsStepContainerConfigurationDetailsList>()!;
        }

        [JsiiProperty(name: "stepDataflowConfigurationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetailsList\"}")]
        public virtual oci.DataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetailsList StepDataflowConfigurationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetailsList>()!;
        }

        [JsiiProperty(name: "stepInfrastructureConfigurationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunStepOverrideDetailsStepInfrastructureConfigurationDetailsList\"}")]
        public virtual oci.DataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunStepOverrideDetailsStepInfrastructureConfigurationDetailsList StepInfrastructureConfigurationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunStepOverrideDetailsStepInfrastructureConfigurationDetailsList>()!;
        }

        [JsiiProperty(name: "stepName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StepName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stepStorageMountConfigurationDetailsList", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunStepOverrideDetailsStepStorageMountConfigurationDetailsListStructList\"}")]
        public virtual oci.DataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunStepOverrideDetailsStepStorageMountConfigurationDetailsListStructList StepStorageMountConfigurationDetailsList
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunStepOverrideDetailsStepStorageMountConfigurationDetailsListStructList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunStepOverrideDetails\"}", isOptional: true)]
        public virtual oci.DataOciDatasciencePipelineRun.IDataOciDatasciencePipelineRunStepOverrideDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipelineRun.IDataOciDatasciencePipelineRunStepOverrideDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
