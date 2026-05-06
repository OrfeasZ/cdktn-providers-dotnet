using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatasciencePipelines
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesOutputReference), fullyQualifiedName: "oci.dataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatasciencePipelinesPipelinesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatasciencePipelinesPipelinesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatasciencePipelinesPipelinesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatasciencePipelinesPipelinesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configurationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesConfigurationDetailsList\"}")]
        public virtual oci.DataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesConfigurationDetailsList ConfigurationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesConfigurationDetailsList>()!;
        }

        [JsiiProperty(name: "createdBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "deleteRelatedPipelineRuns", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DeleteRelatedPipelineRuns
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
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

        [JsiiProperty(name: "infrastructureConfigurationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesInfrastructureConfigurationDetailsList\"}")]
        public virtual oci.DataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesInfrastructureConfigurationDetailsList InfrastructureConfigurationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesInfrastructureConfigurationDetailsList>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logConfigurationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesLogConfigurationDetailsList\"}")]
        public virtual oci.DataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesLogConfigurationDetailsList LogConfigurationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesLogConfigurationDetailsList>()!;
        }

        [JsiiProperty(name: "parameters", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Parameters
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stepArtifact", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesStepArtifactList\"}")]
        public virtual oci.DataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesStepArtifactList StepArtifact
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesStepArtifactList>()!;
        }

        [JsiiProperty(name: "stepDetails", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesStepDetailsList\"}")]
        public virtual oci.DataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesStepDetailsList StepDetails
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesStepDetailsList>()!;
        }

        [JsiiProperty(name: "storageMountConfigurationDetailsList", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesStorageMountConfigurationDetailsListStructList\"}")]
        public virtual oci.DataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesStorageMountConfigurationDetailsListStructList StorageMountConfigurationDetailsList
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelinesStorageMountConfigurationDetailsListStructList>()!;
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipelines.DataOciDatasciencePipelinesPipelines\"}", isOptional: true)]
        public virtual oci.DataOciDatasciencePipelines.IDataOciDatasciencePipelinesPipelines? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipelines.IDataOciDatasciencePipelinesPipelines?>();
            set => SetInstanceProperty(value);
        }
    }
}
