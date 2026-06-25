using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAdvancedClusterFileSystemUnmount
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_advanced_cluster_file_system_unmount oci_database_advanced_cluster_file_system_unmount}.</summary>
    [JsiiClass(nativeType: typeof(oci.DatabaseAdvancedClusterFileSystemUnmount.DatabaseAdvancedClusterFileSystemUnmount), fullyQualifiedName: "oci.databaseAdvancedClusterFileSystemUnmount.DatabaseAdvancedClusterFileSystemUnmount", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.databaseAdvancedClusterFileSystemUnmount.DatabaseAdvancedClusterFileSystemUnmountConfig\"}}]")]
    public class DatabaseAdvancedClusterFileSystemUnmount : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_advanced_cluster_file_system_unmount oci_database_advanced_cluster_file_system_unmount} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DatabaseAdvancedClusterFileSystemUnmount(Constructs.Construct scope, string id, oci.DatabaseAdvancedClusterFileSystemUnmount.IDatabaseAdvancedClusterFileSystemUnmountConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DatabaseAdvancedClusterFileSystemUnmount.IDatabaseAdvancedClusterFileSystemUnmountConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseAdvancedClusterFileSystemUnmount(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseAdvancedClusterFileSystemUnmount(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DatabaseAdvancedClusterFileSystemUnmount resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DatabaseAdvancedClusterFileSystemUnmount to import.</param>
        /// <param name="importFromId">The id of the existing DatabaseAdvancedClusterFileSystemUnmount that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DatabaseAdvancedClusterFileSystemUnmount to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DatabaseAdvancedClusterFileSystemUnmount to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_advanced_cluster_file_system_unmount#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DatabaseAdvancedClusterFileSystemUnmount that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DatabaseAdvancedClusterFileSystemUnmount to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DatabaseAdvancedClusterFileSystemUnmount.DatabaseAdvancedClusterFileSystemUnmount), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseAdvancedClusterFileSystemUnmount.DatabaseAdvancedClusterFileSystemUnmountTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DatabaseAdvancedClusterFileSystemUnmount.IDatabaseAdvancedClusterFileSystemUnmountTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseAdvancedClusterFileSystemUnmount.IDatabaseAdvancedClusterFileSystemUnmountTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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
        = GetStaticProperty<string>(typeof(oci.DatabaseAdvancedClusterFileSystemUnmount.DatabaseAdvancedClusterFileSystemUnmount))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseAdvancedClusterFileSystemUnmount.DatabaseAdvancedClusterFileSystemUnmountTimeoutsOutputReference\"}")]
        public virtual oci.DatabaseAdvancedClusterFileSystemUnmount.DatabaseAdvancedClusterFileSystemUnmountTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DatabaseAdvancedClusterFileSystemUnmount.DatabaseAdvancedClusterFileSystemUnmountTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "advancedClusterFileSystemIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdvancedClusterFileSystemIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.DatabaseAdvancedClusterFileSystemUnmount.IDatabaseAdvancedClusterFileSystemUnmountTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.databaseAdvancedClusterFileSystemUnmount.DatabaseAdvancedClusterFileSystemUnmountTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "advancedClusterFileSystemId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdvancedClusterFileSystemId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
