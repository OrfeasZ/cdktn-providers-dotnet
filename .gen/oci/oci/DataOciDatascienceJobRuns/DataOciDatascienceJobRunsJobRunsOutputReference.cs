using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatascienceJobRuns
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatascienceJobRuns.DataOciDatascienceJobRunsJobRunsOutputReference), fullyQualifiedName: "oci.dataOciDatascienceJobRuns.DataOciDatascienceJobRunsJobRunsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatascienceJobRunsJobRunsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatascienceJobRunsJobRunsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatascienceJobRunsJobRunsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatascienceJobRunsJobRunsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "asynchronous", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Asynchronous
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "jobConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceJobRuns.DataOciDatascienceJobRunsJobRunsJobConfigurationOverrideDetailsList\"}")]
        public virtual oci.DataOciDatascienceJobRuns.DataOciDatascienceJobRunsJobRunsJobConfigurationOverrideDetailsList JobConfigurationOverrideDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceJobRuns.DataOciDatascienceJobRunsJobRunsJobConfigurationOverrideDetailsList>()!;
        }

        [JsiiProperty(name: "jobEnvironmentConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceJobRuns.DataOciDatascienceJobRunsJobRunsJobEnvironmentConfigurationOverrideDetailsList\"}")]
        public virtual oci.DataOciDatascienceJobRuns.DataOciDatascienceJobRunsJobRunsJobEnvironmentConfigurationOverrideDetailsList JobEnvironmentConfigurationOverrideDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceJobRuns.DataOciDatascienceJobRunsJobRunsJobEnvironmentConfigurationOverrideDetailsList>()!;
        }

        [JsiiProperty(name: "jobId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jobInfrastructureConfigurationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceJobRuns.DataOciDatascienceJobRunsJobRunsJobInfrastructureConfigurationDetailsList\"}")]
        public virtual oci.DataOciDatascienceJobRuns.DataOciDatascienceJobRunsJobRunsJobInfrastructureConfigurationDetailsList JobInfrastructureConfigurationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceJobRuns.DataOciDatascienceJobRunsJobRunsJobInfrastructureConfigurationDetailsList>()!;
        }

        [JsiiProperty(name: "jobInfrastructureConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceJobRuns.DataOciDatascienceJobRunsJobRunsJobInfrastructureConfigurationOverrideDetailsList\"}")]
        public virtual oci.DataOciDatascienceJobRuns.DataOciDatascienceJobRunsJobRunsJobInfrastructureConfigurationOverrideDetailsList JobInfrastructureConfigurationOverrideDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceJobRuns.DataOciDatascienceJobRunsJobRunsJobInfrastructureConfigurationOverrideDetailsList>()!;
        }

        [JsiiProperty(name: "jobLogConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceJobRuns.DataOciDatascienceJobRunsJobRunsJobLogConfigurationOverrideDetailsList\"}")]
        public virtual oci.DataOciDatascienceJobRuns.DataOciDatascienceJobRunsJobRunsJobLogConfigurationOverrideDetailsList JobLogConfigurationOverrideDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceJobRuns.DataOciDatascienceJobRunsJobRunsJobLogConfigurationOverrideDetailsList>()!;
        }

        [JsiiProperty(name: "jobNodeConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceJobRuns.DataOciDatascienceJobRunsJobRunsJobNodeConfigurationOverrideDetailsList\"}")]
        public virtual oci.DataOciDatascienceJobRuns.DataOciDatascienceJobRunsJobRunsJobNodeConfigurationOverrideDetailsList JobNodeConfigurationOverrideDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceJobRuns.DataOciDatascienceJobRunsJobRunsJobNodeConfigurationOverrideDetailsList>()!;
        }

        [JsiiProperty(name: "jobStorageMountConfigurationDetailsList", typeJson: "{\"fqn\":\"oci.dataOciDatascienceJobRuns.DataOciDatascienceJobRunsJobRunsJobStorageMountConfigurationDetailsListStructList\"}")]
        public virtual oci.DataOciDatascienceJobRuns.DataOciDatascienceJobRunsJobRunsJobStorageMountConfigurationDetailsListStructList JobStorageMountConfigurationDetailsList
        {
            get => GetInstanceProperty<oci.DataOciDatascienceJobRuns.DataOciDatascienceJobRunsJobRunsJobStorageMountConfigurationDetailsListStructList>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceJobRuns.DataOciDatascienceJobRunsJobRunsLogDetailsList\"}")]
        public virtual oci.DataOciDatascienceJobRuns.DataOciDatascienceJobRunsJobRunsLogDetailsList LogDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceJobRuns.DataOciDatascienceJobRunsJobRunsLogDetailsList>()!;
        }

        [JsiiProperty(name: "nodeGroupDetailsList", typeJson: "{\"fqn\":\"oci.dataOciDatascienceJobRuns.DataOciDatascienceJobRunsJobRunsNodeGroupDetailsListStructList\"}")]
        public virtual oci.DataOciDatascienceJobRuns.DataOciDatascienceJobRunsJobRunsNodeGroupDetailsListStructList NodeGroupDetailsList
        {
            get => GetInstanceProperty<oci.DataOciDatascienceJobRuns.DataOciDatascienceJobRunsJobRunsNodeGroupDetailsListStructList>()!;
        }

        [JsiiProperty(name: "opcParentRptUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpcParentRptUrl
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "timeAccepted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeAccepted
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

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatascienceJobRuns.DataOciDatascienceJobRunsJobRuns\"}", isOptional: true)]
        public virtual oci.DataOciDatascienceJobRuns.IDataOciDatascienceJobRunsJobRuns? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatascienceJobRuns.IDataOciDatascienceJobRunsJobRuns?>();
            set => SetInstanceProperty(value);
        }
    }
}
