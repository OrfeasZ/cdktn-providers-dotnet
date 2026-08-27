using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermOracleExascaleDatabaseStorageVault
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/data-sources/oracle_exascale_database_storage_vault azurerm_oracle_exascale_database_storage_vault}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermOracleExascaleDatabaseStorageVault.DataAzurermOracleExascaleDatabaseStorageVault), fullyQualifiedName: "azurerm.dataAzurermOracleExascaleDatabaseStorageVault.DataAzurermOracleExascaleDatabaseStorageVault", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataAzurermOracleExascaleDatabaseStorageVault.DataAzurermOracleExascaleDatabaseStorageVaultConfig\"}}]")]
    public class DataAzurermOracleExascaleDatabaseStorageVault : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/data-sources/oracle_exascale_database_storage_vault azurerm_oracle_exascale_database_storage_vault} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurermOracleExascaleDatabaseStorageVault(Constructs.Construct scope, string id, azurerm.DataAzurermOracleExascaleDatabaseStorageVault.IDataAzurermOracleExascaleDatabaseStorageVaultConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataAzurermOracleExascaleDatabaseStorageVault.IDataAzurermOracleExascaleDatabaseStorageVaultConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermOracleExascaleDatabaseStorageVault(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermOracleExascaleDatabaseStorageVault(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAzurermOracleExascaleDatabaseStorageVault resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurermOracleExascaleDatabaseStorageVault to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurermOracleExascaleDatabaseStorageVault that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurermOracleExascaleDatabaseStorageVault to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurermOracleExascaleDatabaseStorageVault to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/data-sources/oracle_exascale_database_storage_vault#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurermOracleExascaleDatabaseStorageVault that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurermOracleExascaleDatabaseStorageVault to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.DataAzurermOracleExascaleDatabaseStorageVault.DataAzurermOracleExascaleDatabaseStorageVault), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermOracleExascaleDatabaseStorageVault.DataAzurermOracleExascaleDatabaseStorageVaultTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataAzurermOracleExascaleDatabaseStorageVault.IDataAzurermOracleExascaleDatabaseStorageVaultTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermOracleExascaleDatabaseStorageVault.IDataAzurermOracleExascaleDatabaseStorageVaultTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.DataAzurermOracleExascaleDatabaseStorageVault.DataAzurermOracleExascaleDatabaseStorageVault))!;

        [JsiiProperty(name: "additionalFlashCachePercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AdditionalFlashCachePercentage
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "highCapacityDatabaseStorage", typeJson: "{\"fqn\":\"azurerm.dataAzurermOracleExascaleDatabaseStorageVault.DataAzurermOracleExascaleDatabaseStorageVaultHighCapacityDatabaseStorageList\"}")]
        public virtual azurerm.DataAzurermOracleExascaleDatabaseStorageVault.DataAzurermOracleExascaleDatabaseStorageVaultHighCapacityDatabaseStorageList HighCapacityDatabaseStorage
        {
            get => GetInstanceProperty<azurerm.DataAzurermOracleExascaleDatabaseStorageVault.DataAzurermOracleExascaleDatabaseStorageVaultHighCapacityDatabaseStorageList>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ocid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ociUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OciUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermOracleExascaleDatabaseStorageVault.DataAzurermOracleExascaleDatabaseStorageVaultTimeoutsOutputReference\"}")]
        public virtual azurerm.DataAzurermOracleExascaleDatabaseStorageVault.DataAzurermOracleExascaleDatabaseStorageVaultTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataAzurermOracleExascaleDatabaseStorageVault.DataAzurermOracleExascaleDatabaseStorageVaultTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeZone
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "virtualMachineClusterCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double VirtualMachineClusterCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "zones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Zones
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.DataAzurermOracleExascaleDatabaseStorageVault.IDataAzurermOracleExascaleDatabaseStorageVaultTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.dataAzurermOracleExascaleDatabaseStorageVault.DataAzurermOracleExascaleDatabaseStorageVaultTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
