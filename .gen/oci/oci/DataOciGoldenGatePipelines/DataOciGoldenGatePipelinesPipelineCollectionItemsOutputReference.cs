using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciGoldenGatePipelines
{
    [JsiiClass(nativeType: typeof(oci.DataOciGoldenGatePipelines.DataOciGoldenGatePipelinesPipelineCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciGoldenGatePipelines.DataOciGoldenGatePipelinesPipelineCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciGoldenGatePipelinesPipelineCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciGoldenGatePipelinesPipelineCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciGoldenGatePipelinesPipelineCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciGoldenGatePipelinesPipelineCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cpuCoreCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpuCoreCount
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "isAutoScalingEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAutoScalingEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "licenseModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LicenseModel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleSubState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleSubState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "locks", typeJson: "{\"fqn\":\"oci.dataOciGoldenGatePipelines.DataOciGoldenGatePipelinesPipelineCollectionItemsLocksList\"}")]
        public virtual oci.DataOciGoldenGatePipelines.DataOciGoldenGatePipelinesPipelineCollectionItemsLocksList Locks
        {
            get => GetInstanceProperty<oci.DataOciGoldenGatePipelines.DataOciGoldenGatePipelinesPipelineCollectionItemsLocksList>()!;
        }

        [JsiiProperty(name: "mappingRules", typeJson: "{\"fqn\":\"oci.dataOciGoldenGatePipelines.DataOciGoldenGatePipelinesPipelineCollectionItemsMappingRulesList\"}")]
        public virtual oci.DataOciGoldenGatePipelines.DataOciGoldenGatePipelinesPipelineCollectionItemsMappingRulesList MappingRules
        {
            get => GetInstanceProperty<oci.DataOciGoldenGatePipelines.DataOciGoldenGatePipelinesPipelineCollectionItemsMappingRulesList>()!;
        }

        [JsiiProperty(name: "pipelineDiagnosticData", typeJson: "{\"fqn\":\"oci.dataOciGoldenGatePipelines.DataOciGoldenGatePipelinesPipelineCollectionItemsPipelineDiagnosticDataList\"}")]
        public virtual oci.DataOciGoldenGatePipelines.DataOciGoldenGatePipelinesPipelineCollectionItemsPipelineDiagnosticDataList PipelineDiagnosticData
        {
            get => GetInstanceProperty<oci.DataOciGoldenGatePipelines.DataOciGoldenGatePipelinesPipelineCollectionItemsPipelineDiagnosticDataList>()!;
        }

        [JsiiProperty(name: "processOptions", typeJson: "{\"fqn\":\"oci.dataOciGoldenGatePipelines.DataOciGoldenGatePipelinesPipelineCollectionItemsProcessOptionsList\"}")]
        public virtual oci.DataOciGoldenGatePipelines.DataOciGoldenGatePipelinesPipelineCollectionItemsProcessOptionsList ProcessOptions
        {
            get => GetInstanceProperty<oci.DataOciGoldenGatePipelines.DataOciGoldenGatePipelinesPipelineCollectionItemsProcessOptionsList>()!;
        }

        [JsiiProperty(name: "recipeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RecipeType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceConnectionDetails", typeJson: "{\"fqn\":\"oci.dataOciGoldenGatePipelines.DataOciGoldenGatePipelinesPipelineCollectionItemsSourceConnectionDetailsList\"}")]
        public virtual oci.DataOciGoldenGatePipelines.DataOciGoldenGatePipelinesPipelineCollectionItemsSourceConnectionDetailsList SourceConnectionDetails
        {
            get => GetInstanceProperty<oci.DataOciGoldenGatePipelines.DataOciGoldenGatePipelinesPipelineCollectionItemsSourceConnectionDetailsList>()!;
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

        [JsiiProperty(name: "targetConnectionDetails", typeJson: "{\"fqn\":\"oci.dataOciGoldenGatePipelines.DataOciGoldenGatePipelinesPipelineCollectionItemsTargetConnectionDetailsList\"}")]
        public virtual oci.DataOciGoldenGatePipelines.DataOciGoldenGatePipelinesPipelineCollectionItemsTargetConnectionDetailsList TargetConnectionDetails
        {
            get => GetInstanceProperty<oci.DataOciGoldenGatePipelines.DataOciGoldenGatePipelinesPipelineCollectionItemsTargetConnectionDetailsList>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLastRecorded", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastRecorded
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciGoldenGatePipelines.DataOciGoldenGatePipelinesPipelineCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciGoldenGatePipelines.IDataOciGoldenGatePipelinesPipelineCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciGoldenGatePipelines.IDataOciGoldenGatePipelinesPipelineCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
