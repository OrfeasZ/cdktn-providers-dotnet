using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatascienceNotebookSession
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/datascience_notebook_session oci_datascience_notebook_session}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDatascienceNotebookSession.DataOciDatascienceNotebookSession), fullyQualifiedName: "oci.dataOciDatascienceNotebookSession.DataOciDatascienceNotebookSession", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDatascienceNotebookSession.DataOciDatascienceNotebookSessionConfig\"}}]")]
    public class DataOciDatascienceNotebookSession : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/datascience_notebook_session oci_datascience_notebook_session} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDatascienceNotebookSession(Constructs.Construct scope, string id, oci.DataOciDatascienceNotebookSession.IDataOciDatascienceNotebookSessionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDatascienceNotebookSession.IDataOciDatascienceNotebookSessionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatascienceNotebookSession(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatascienceNotebookSession(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDatascienceNotebookSession resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDatascienceNotebookSession to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDatascienceNotebookSession that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDatascienceNotebookSession to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDatascienceNotebookSession to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/datascience_notebook_session#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDatascienceNotebookSession that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDatascienceNotebookSession to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDatascienceNotebookSession.DataOciDatascienceNotebookSession), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDatascienceNotebookSession.DataOciDatascienceNotebookSession))!;

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

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "notebookSessionConfigDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceNotebookSession.DataOciDatascienceNotebookSessionNotebookSessionConfigDetailsList\"}")]
        public virtual oci.DataOciDatascienceNotebookSession.DataOciDatascienceNotebookSessionNotebookSessionConfigDetailsList NotebookSessionConfigDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceNotebookSession.DataOciDatascienceNotebookSessionNotebookSessionConfigDetailsList>()!;
        }

        [JsiiProperty(name: "notebookSessionConfigurationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceNotebookSession.DataOciDatascienceNotebookSessionNotebookSessionConfigurationDetailsList\"}")]
        public virtual oci.DataOciDatascienceNotebookSession.DataOciDatascienceNotebookSessionNotebookSessionConfigurationDetailsList NotebookSessionConfigurationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceNotebookSession.DataOciDatascienceNotebookSessionNotebookSessionConfigurationDetailsList>()!;
        }

        [JsiiProperty(name: "notebookSessionRuntimeConfigDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceNotebookSession.DataOciDatascienceNotebookSessionNotebookSessionRuntimeConfigDetailsList\"}")]
        public virtual oci.DataOciDatascienceNotebookSession.DataOciDatascienceNotebookSessionNotebookSessionRuntimeConfigDetailsList NotebookSessionRuntimeConfigDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceNotebookSession.DataOciDatascienceNotebookSessionNotebookSessionRuntimeConfigDetailsList>()!;
        }

        [JsiiProperty(name: "notebookSessionStorageMountConfigurationDetailsList", typeJson: "{\"fqn\":\"oci.dataOciDatascienceNotebookSession.DataOciDatascienceNotebookSessionNotebookSessionStorageMountConfigurationDetailsListStructList\"}")]
        public virtual oci.DataOciDatascienceNotebookSession.DataOciDatascienceNotebookSessionNotebookSessionStorageMountConfigurationDetailsListStructList NotebookSessionStorageMountConfigurationDetailsList
        {
            get => GetInstanceProperty<oci.DataOciDatascienceNotebookSession.DataOciDatascienceNotebookSessionNotebookSessionStorageMountConfigurationDetailsListStructList>()!;
        }

        [JsiiProperty(name: "notebookSessionUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NotebookSessionUrl
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
        [JsiiProperty(name: "notebookSessionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NotebookSessionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "notebookSessionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NotebookSessionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
