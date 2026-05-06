using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatasciencePipelineRun
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetailsOutputReference), fullyQualifiedName: "oci.dataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetailsOutputReference(DeputyProps props): base(props)
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

        [JsiiProperty(name: "driverShapeConfigDetails", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetailsDriverShapeConfigDetailsList\"}")]
        public virtual oci.DataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetailsDriverShapeConfigDetailsList DriverShapeConfigDetails
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetailsDriverShapeConfigDetailsList>()!;
        }

        [JsiiProperty(name: "executorShape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutorShape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "executorShapeConfigDetails", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetailsExecutorShapeConfigDetailsList\"}")]
        public virtual oci.DataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetailsExecutorShapeConfigDetailsList ExecutorShapeConfigDetails
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetailsExecutorShapeConfigDetailsList>()!;
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetails\"}", isOptional: true)]
        public virtual oci.DataOciDatasciencePipelineRun.IDataOciDatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipelineRun.IDataOciDatasciencePipelineRunStepOverrideDetailsStepDataflowConfigurationDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
