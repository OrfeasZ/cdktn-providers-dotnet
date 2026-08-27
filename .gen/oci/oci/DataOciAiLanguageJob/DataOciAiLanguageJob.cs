using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciAiLanguageJob
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/ai_language_job oci_ai_language_job}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciAiLanguageJob.DataOciAiLanguageJob), fullyQualifiedName: "oci.dataOciAiLanguageJob.DataOciAiLanguageJob", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciAiLanguageJob.DataOciAiLanguageJobConfig\"}}]")]
    public class DataOciAiLanguageJob : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/ai_language_job oci_ai_language_job} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciAiLanguageJob(Constructs.Construct scope, string id, oci.DataOciAiLanguageJob.IDataOciAiLanguageJobConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciAiLanguageJob.IDataOciAiLanguageJobConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciAiLanguageJob(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciAiLanguageJob(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciAiLanguageJob resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciAiLanguageJob to import.</param>
        /// <param name="importFromId">The id of the existing DataOciAiLanguageJob that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciAiLanguageJob to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciAiLanguageJob to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/data-sources/ai_language_job#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciAiLanguageJob that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciAiLanguageJob to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciAiLanguageJob.DataOciAiLanguageJob), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciAiLanguageJob.DataOciAiLanguageJob))!;

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "completedDocuments", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CompletedDocuments
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "createdBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedBy
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "failedDocuments", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FailedDocuments
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "inputConfiguration", typeJson: "{\"fqn\":\"oci.dataOciAiLanguageJob.DataOciAiLanguageJobInputConfigurationList\"}")]
        public virtual oci.DataOciAiLanguageJob.DataOciAiLanguageJobInputConfigurationList InputConfiguration
        {
            get => GetInstanceProperty<oci.DataOciAiLanguageJob.DataOciAiLanguageJobInputConfigurationList>()!;
        }

        [JsiiProperty(name: "inputLocation", typeJson: "{\"fqn\":\"oci.dataOciAiLanguageJob.DataOciAiLanguageJobInputLocationList\"}")]
        public virtual oci.DataOciAiLanguageJob.DataOciAiLanguageJobInputLocationList InputLocation
        {
            get => GetInstanceProperty<oci.DataOciAiLanguageJob.DataOciAiLanguageJobInputLocationList>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modelMetadataDetails", typeJson: "{\"fqn\":\"oci.dataOciAiLanguageJob.DataOciAiLanguageJobModelMetadataDetailsList\"}")]
        public virtual oci.DataOciAiLanguageJob.DataOciAiLanguageJobModelMetadataDetailsList ModelMetadataDetails
        {
            get => GetInstanceProperty<oci.DataOciAiLanguageJob.DataOciAiLanguageJobModelMetadataDetailsList>()!;
        }

        [JsiiProperty(name: "outputLocation", typeJson: "{\"fqn\":\"oci.dataOciAiLanguageJob.DataOciAiLanguageJobOutputLocationList\"}")]
        public virtual oci.DataOciAiLanguageJob.DataOciAiLanguageJobOutputLocationList OutputLocation
        {
            get => GetInstanceProperty<oci.DataOciAiLanguageJob.DataOciAiLanguageJobOutputLocationList>()!;
        }

        [JsiiProperty(name: "pendingDocuments", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PendingDocuments
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "percentComplete", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PercentComplete
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "timeCompleted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCompleted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeStarted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStarted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalDocuments", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalDocuments
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ttlInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TtlInDays
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "warningsCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WarningsCount
        {
            get => GetInstanceProperty<double>()!;
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
