using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatascienceJob
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/datascience_job oci_datascience_job}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDatascienceJob.DataOciDatascienceJob), fullyQualifiedName: "oci.dataOciDatascienceJob.DataOciDatascienceJob", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDatascienceJob.DataOciDatascienceJobConfig\"}}]")]
    public class DataOciDatascienceJob : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/datascience_job oci_datascience_job} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDatascienceJob(Constructs.Construct scope, string id, oci.DataOciDatascienceJob.IDataOciDatascienceJobConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDatascienceJob.IDataOciDatascienceJobConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatascienceJob(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatascienceJob(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDatascienceJob resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDatascienceJob to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDatascienceJob that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDatascienceJob to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDatascienceJob to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/datascience_job#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDatascienceJob that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDatascienceJob to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDatascienceJob.DataOciDatascienceJob), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(oci.DataOciDatascienceJob.DataOciDatascienceJob))!;

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

        [JsiiProperty(name: "jobConfigurationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceJob.DataOciDatascienceJobJobConfigurationDetailsList\"}")]
        public virtual oci.DataOciDatascienceJob.DataOciDatascienceJobJobConfigurationDetailsList JobConfigurationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceJob.DataOciDatascienceJobJobConfigurationDetailsList>()!;
        }

        [JsiiProperty(name: "jobEnvironmentConfigurationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceJob.DataOciDatascienceJobJobEnvironmentConfigurationDetailsList\"}")]
        public virtual oci.DataOciDatascienceJob.DataOciDatascienceJobJobEnvironmentConfigurationDetailsList JobEnvironmentConfigurationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceJob.DataOciDatascienceJobJobEnvironmentConfigurationDetailsList>()!;
        }

        [JsiiProperty(name: "jobInfrastructureConfigurationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceJob.DataOciDatascienceJobJobInfrastructureConfigurationDetailsList\"}")]
        public virtual oci.DataOciDatascienceJob.DataOciDatascienceJobJobInfrastructureConfigurationDetailsList JobInfrastructureConfigurationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceJob.DataOciDatascienceJobJobInfrastructureConfigurationDetailsList>()!;
        }

        [JsiiProperty(name: "jobLogConfigurationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceJob.DataOciDatascienceJobJobLogConfigurationDetailsList\"}")]
        public virtual oci.DataOciDatascienceJob.DataOciDatascienceJobJobLogConfigurationDetailsList JobLogConfigurationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceJob.DataOciDatascienceJobJobLogConfigurationDetailsList>()!;
        }

        [JsiiProperty(name: "jobNodeConfigurationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceJob.DataOciDatascienceJobJobNodeConfigurationDetailsList\"}")]
        public virtual oci.DataOciDatascienceJob.DataOciDatascienceJobJobNodeConfigurationDetailsList JobNodeConfigurationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceJob.DataOciDatascienceJobJobNodeConfigurationDetailsList>()!;
        }

        [JsiiProperty(name: "jobStorageMountConfigurationDetailsList", typeJson: "{\"fqn\":\"oci.dataOciDatascienceJob.DataOciDatascienceJobJobStorageMountConfigurationDetailsListStructList\"}")]
        public virtual oci.DataOciDatascienceJob.DataOciDatascienceJobJobStorageMountConfigurationDetailsListStructList JobStorageMountConfigurationDetailsList
        {
            get => GetInstanceProperty<oci.DataOciDatascienceJob.DataOciDatascienceJobJobStorageMountConfigurationDetailsListStructList>()!;
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
        [JsiiProperty(name: "jobIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JobIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "jobId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
