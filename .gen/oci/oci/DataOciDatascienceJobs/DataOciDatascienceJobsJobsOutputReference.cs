using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatascienceJobs
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatascienceJobs.DataOciDatascienceJobsJobsOutputReference), fullyQualifiedName: "oci.dataOciDatascienceJobs.DataOciDatascienceJobsJobsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatascienceJobsJobsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatascienceJobsJobsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatascienceJobsJobsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatascienceJobsJobsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "artifactContentDisposition", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ArtifactContentDisposition
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "artifactContentLength", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ArtifactContentLength
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "artifactContentMd5", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ArtifactContentMd5
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "artifactLastModified", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ArtifactLastModified
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "deleteRelatedJobRuns", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DeleteRelatedJobRuns
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

        [JsiiProperty(name: "emptyArtifact", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EmptyArtifact
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
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

        [JsiiProperty(name: "jobArtifact", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobArtifact
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jobConfigurationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceJobs.DataOciDatascienceJobsJobsJobConfigurationDetailsList\"}")]
        public virtual oci.DataOciDatascienceJobs.DataOciDatascienceJobsJobsJobConfigurationDetailsList JobConfigurationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceJobs.DataOciDatascienceJobsJobsJobConfigurationDetailsList>()!;
        }

        [JsiiProperty(name: "jobEnvironmentConfigurationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceJobs.DataOciDatascienceJobsJobsJobEnvironmentConfigurationDetailsList\"}")]
        public virtual oci.DataOciDatascienceJobs.DataOciDatascienceJobsJobsJobEnvironmentConfigurationDetailsList JobEnvironmentConfigurationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceJobs.DataOciDatascienceJobsJobsJobEnvironmentConfigurationDetailsList>()!;
        }

        [JsiiProperty(name: "jobInfrastructureConfigurationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceJobs.DataOciDatascienceJobsJobsJobInfrastructureConfigurationDetailsList\"}")]
        public virtual oci.DataOciDatascienceJobs.DataOciDatascienceJobsJobsJobInfrastructureConfigurationDetailsList JobInfrastructureConfigurationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceJobs.DataOciDatascienceJobsJobsJobInfrastructureConfigurationDetailsList>()!;
        }

        [JsiiProperty(name: "jobLogConfigurationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceJobs.DataOciDatascienceJobsJobsJobLogConfigurationDetailsList\"}")]
        public virtual oci.DataOciDatascienceJobs.DataOciDatascienceJobsJobsJobLogConfigurationDetailsList JobLogConfigurationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceJobs.DataOciDatascienceJobsJobsJobLogConfigurationDetailsList>()!;
        }

        [JsiiProperty(name: "jobNodeConfigurationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceJobs.DataOciDatascienceJobsJobsJobNodeConfigurationDetailsList\"}")]
        public virtual oci.DataOciDatascienceJobs.DataOciDatascienceJobsJobsJobNodeConfigurationDetailsList JobNodeConfigurationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceJobs.DataOciDatascienceJobsJobsJobNodeConfigurationDetailsList>()!;
        }

        [JsiiProperty(name: "jobStorageMountConfigurationDetailsList", typeJson: "{\"fqn\":\"oci.dataOciDatascienceJobs.DataOciDatascienceJobsJobsJobStorageMountConfigurationDetailsListStructList\"}")]
        public virtual oci.DataOciDatascienceJobs.DataOciDatascienceJobsJobsJobStorageMountConfigurationDetailsListStructList JobStorageMountConfigurationDetailsList
        {
            get => GetInstanceProperty<oci.DataOciDatascienceJobs.DataOciDatascienceJobsJobsJobStorageMountConfigurationDetailsListStructList>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
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

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatascienceJobs.DataOciDatascienceJobsJobs\"}", isOptional: true)]
        public virtual oci.DataOciDatascienceJobs.IDataOciDatascienceJobsJobs? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatascienceJobs.IDataOciDatascienceJobsJobs?>();
            set => SetInstanceProperty(value);
        }
    }
}
