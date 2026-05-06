using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatasciencePipelineRuns
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatasciencePipelineRuns.DataOciDatasciencePipelineRunsPipelineRunsStepOverrideDetailsStepDataflowConfigurationDetailsOutputReference), fullyQualifiedName: "oci.dataOciDatasciencePipelineRuns.DataOciDatasciencePipelineRunsPipelineRunsStepOverrideDetailsStepDataflowConfigurationDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatasciencePipelineRunsPipelineRunsStepOverrideDetailsStepDataflowConfigurationDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatasciencePipelineRunsPipelineRunsStepOverrideDetailsStepDataflowConfigurationDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatasciencePipelineRunsPipelineRunsStepOverrideDetailsStepDataflowConfigurationDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatasciencePipelineRunsPipelineRunsStepOverrideDetailsStepDataflowConfigurationDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "configuration", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Configuration
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "driverShape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DriverShape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "driverShapeConfigDetails", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipelineRuns.DataOciDatasciencePipelineRunsPipelineRunsStepOverrideDetailsStepDataflowConfigurationDetailsDriverShapeConfigDetailsList\"}")]
        public virtual oci.DataOciDatasciencePipelineRuns.DataOciDatasciencePipelineRunsPipelineRunsStepOverrideDetailsStepDataflowConfigurationDetailsDriverShapeConfigDetailsList DriverShapeConfigDetails
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipelineRuns.DataOciDatasciencePipelineRunsPipelineRunsStepOverrideDetailsStepDataflowConfigurationDetailsDriverShapeConfigDetailsList>()!;
        }

        [JsiiProperty(name: "executorShape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutorShape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "executorShapeConfigDetails", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipelineRuns.DataOciDatasciencePipelineRunsPipelineRunsStepOverrideDetailsStepDataflowConfigurationDetailsExecutorShapeConfigDetailsList\"}")]
        public virtual oci.DataOciDatasciencePipelineRuns.DataOciDatasciencePipelineRunsPipelineRunsStepOverrideDetailsStepDataflowConfigurationDetailsExecutorShapeConfigDetailsList ExecutorShapeConfigDetails
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipelineRuns.DataOciDatasciencePipelineRunsPipelineRunsStepOverrideDetailsStepDataflowConfigurationDetailsExecutorShapeConfigDetailsList>()!;
        }

        [JsiiProperty(name: "logsBucketUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogsBucketUri
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "numExecutors", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumExecutors
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "warehouseBucketUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WarehouseBucketUri
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipelineRuns.DataOciDatasciencePipelineRunsPipelineRunsStepOverrideDetailsStepDataflowConfigurationDetails\"}", isOptional: true)]
        public virtual oci.DataOciDatasciencePipelineRuns.IDataOciDatasciencePipelineRunsPipelineRunsStepOverrideDetailsStepDataflowConfigurationDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipelineRuns.IDataOciDatasciencePipelineRunsPipelineRunsStepOverrideDetailsStepDataflowConfigurationDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
