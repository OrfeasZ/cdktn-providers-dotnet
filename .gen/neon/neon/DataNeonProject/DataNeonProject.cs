using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace neon.DataNeonProject
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/data-sources/project neon_project}.</summary>
    [JsiiClass(nativeType: typeof(neon.DataNeonProject.DataNeonProject), fullyQualifiedName: "neon.dataNeonProject.DataNeonProject", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"neon.dataNeonProject.DataNeonProjectConfig\"}}]")]
    public class DataNeonProject : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/data-sources/project neon_project} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataNeonProject(Constructs.Construct scope, string id, neon.DataNeonProject.IDataNeonProjectConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, neon.DataNeonProject.IDataNeonProjectConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataNeonProject(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataNeonProject(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataNeonProject resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataNeonProject to import.</param>
        /// <param name="importFromId">The id of the existing DataNeonProject that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataNeonProject to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataNeonProject to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/data-sources/project#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataNeonProject that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataNeonProject to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(neon.DataNeonProject.DataNeonProject), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(neon.DataNeonProject.DataNeonProject))!;

        [JsiiProperty(name: "connectionUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionUri
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectionUriPooler", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionUriPooler
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseHostPooler", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseHostPooler
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databasePassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabasePassword
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseUser", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseUser
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultBranchId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultBranchId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
