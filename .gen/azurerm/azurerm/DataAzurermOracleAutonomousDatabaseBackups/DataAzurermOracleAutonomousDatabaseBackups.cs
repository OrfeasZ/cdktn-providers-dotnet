using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermOracleAutonomousDatabaseBackups
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/data-sources/oracle_autonomous_database_backups azurerm_oracle_autonomous_database_backups}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermOracleAutonomousDatabaseBackups.DataAzurermOracleAutonomousDatabaseBackups), fullyQualifiedName: "azurerm.dataAzurermOracleAutonomousDatabaseBackups.DataAzurermOracleAutonomousDatabaseBackups", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataAzurermOracleAutonomousDatabaseBackups.DataAzurermOracleAutonomousDatabaseBackupsConfig\"}}]")]
    public class DataAzurermOracleAutonomousDatabaseBackups : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/data-sources/oracle_autonomous_database_backups azurerm_oracle_autonomous_database_backups} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurermOracleAutonomousDatabaseBackups(Constructs.Construct scope, string id, azurerm.DataAzurermOracleAutonomousDatabaseBackups.IDataAzurermOracleAutonomousDatabaseBackupsConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataAzurermOracleAutonomousDatabaseBackups.IDataAzurermOracleAutonomousDatabaseBackupsConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermOracleAutonomousDatabaseBackups(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermOracleAutonomousDatabaseBackups(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAzurermOracleAutonomousDatabaseBackups resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurermOracleAutonomousDatabaseBackups to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurermOracleAutonomousDatabaseBackups that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurermOracleAutonomousDatabaseBackups to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurermOracleAutonomousDatabaseBackups to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/data-sources/oracle_autonomous_database_backups#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurermOracleAutonomousDatabaseBackups that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurermOracleAutonomousDatabaseBackups to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.DataAzurermOracleAutonomousDatabaseBackups.DataAzurermOracleAutonomousDatabaseBackups), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermOracleAutonomousDatabaseBackups.DataAzurermOracleAutonomousDatabaseBackupsTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataAzurermOracleAutonomousDatabaseBackups.IDataAzurermOracleAutonomousDatabaseBackupsTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermOracleAutonomousDatabaseBackups.IDataAzurermOracleAutonomousDatabaseBackupsTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.DataAzurermOracleAutonomousDatabaseBackups.DataAzurermOracleAutonomousDatabaseBackups))!;

        [JsiiProperty(name: "autonomousDatabaseBackups", typeJson: "{\"fqn\":\"azurerm.dataAzurermOracleAutonomousDatabaseBackups.DataAzurermOracleAutonomousDatabaseBackupsAutonomousDatabaseBackupsList\"}")]
        public virtual azurerm.DataAzurermOracleAutonomousDatabaseBackups.DataAzurermOracleAutonomousDatabaseBackupsAutonomousDatabaseBackupsList AutonomousDatabaseBackups
        {
            get => GetInstanceProperty<azurerm.DataAzurermOracleAutonomousDatabaseBackups.DataAzurermOracleAutonomousDatabaseBackupsAutonomousDatabaseBackupsList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermOracleAutonomousDatabaseBackups.DataAzurermOracleAutonomousDatabaseBackupsTimeoutsOutputReference\"}")]
        public virtual azurerm.DataAzurermOracleAutonomousDatabaseBackups.DataAzurermOracleAutonomousDatabaseBackupsTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataAzurermOracleAutonomousDatabaseBackups.DataAzurermOracleAutonomousDatabaseBackupsTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autonomousDatabaseIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AutonomousDatabaseIdInput
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.DataAzurermOracleAutonomousDatabaseBackups.IDataAzurermOracleAutonomousDatabaseBackupsTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.dataAzurermOracleAutonomousDatabaseBackups.DataAzurermOracleAutonomousDatabaseBackupsTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "autonomousDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutonomousDatabaseId
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
