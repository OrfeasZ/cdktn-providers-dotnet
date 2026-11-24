using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataProtectionBackupVaultResourceGuardAssociation
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/data_protection_backup_vault_resource_guard_association azurerm_data_protection_backup_vault_resource_guard_association}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataProtectionBackupVaultResourceGuardAssociation.DataProtectionBackupVaultResourceGuardAssociation), fullyQualifiedName: "azurerm.dataProtectionBackupVaultResourceGuardAssociation.DataProtectionBackupVaultResourceGuardAssociation", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataProtectionBackupVaultResourceGuardAssociation.DataProtectionBackupVaultResourceGuardAssociationConfig\"}}]")]
    public class DataProtectionBackupVaultResourceGuardAssociation : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/data_protection_backup_vault_resource_guard_association azurerm_data_protection_backup_vault_resource_guard_association} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataProtectionBackupVaultResourceGuardAssociation(Constructs.Construct scope, string id, azurerm.DataProtectionBackupVaultResourceGuardAssociation.IDataProtectionBackupVaultResourceGuardAssociationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataProtectionBackupVaultResourceGuardAssociation.IDataProtectionBackupVaultResourceGuardAssociationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataProtectionBackupVaultResourceGuardAssociation(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataProtectionBackupVaultResourceGuardAssociation(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataProtectionBackupVaultResourceGuardAssociation resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataProtectionBackupVaultResourceGuardAssociation to import.</param>
        /// <param name="importFromId">The id of the existing DataProtectionBackupVaultResourceGuardAssociation that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataProtectionBackupVaultResourceGuardAssociation to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataProtectionBackupVaultResourceGuardAssociation to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/data_protection_backup_vault_resource_guard_association#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataProtectionBackupVaultResourceGuardAssociation that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataProtectionBackupVaultResourceGuardAssociation to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.DataProtectionBackupVaultResourceGuardAssociation.DataProtectionBackupVaultResourceGuardAssociation), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataProtectionBackupVaultResourceGuardAssociation.DataProtectionBackupVaultResourceGuardAssociationTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataProtectionBackupVaultResourceGuardAssociation.IDataProtectionBackupVaultResourceGuardAssociationTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataProtectionBackupVaultResourceGuardAssociation.IDataProtectionBackupVaultResourceGuardAssociationTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.DataProtectionBackupVaultResourceGuardAssociation.DataProtectionBackupVaultResourceGuardAssociation))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataProtectionBackupVaultResourceGuardAssociation.DataProtectionBackupVaultResourceGuardAssociationTimeoutsOutputReference\"}")]
        public virtual azurerm.DataProtectionBackupVaultResourceGuardAssociation.DataProtectionBackupVaultResourceGuardAssociationTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataProtectionBackupVaultResourceGuardAssociation.DataProtectionBackupVaultResourceGuardAssociationTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataProtectionBackupVaultIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DataProtectionBackupVaultIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataProtectionResourceGuardIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DataProtectionResourceGuardIdInput
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.DataProtectionBackupVaultResourceGuardAssociation.IDataProtectionBackupVaultResourceGuardAssociationTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.dataProtectionBackupVaultResourceGuardAssociation.DataProtectionBackupVaultResourceGuardAssociationTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "dataProtectionBackupVaultId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataProtectionBackupVaultId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dataProtectionResourceGuardId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataProtectionResourceGuardId
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
