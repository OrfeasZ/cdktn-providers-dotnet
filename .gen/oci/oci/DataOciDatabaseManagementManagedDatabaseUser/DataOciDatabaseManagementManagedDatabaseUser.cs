using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementManagedDatabaseUser
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_user oci_database_management_managed_database_user}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementManagedDatabaseUser.DataOciDatabaseManagementManagedDatabaseUser), fullyQualifiedName: "oci.dataOciDatabaseManagementManagedDatabaseUser.DataOciDatabaseManagementManagedDatabaseUser", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabaseUser.DataOciDatabaseManagementManagedDatabaseUserConfig\"}}]")]
    public class DataOciDatabaseManagementManagedDatabaseUser : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_user oci_database_management_managed_database_user} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDatabaseManagementManagedDatabaseUser(Constructs.Construct scope, string id, oci.DataOciDatabaseManagementManagedDatabaseUser.IDataOciDatabaseManagementManagedDatabaseUserConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDatabaseManagementManagedDatabaseUser.IDataOciDatabaseManagementManagedDatabaseUserConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementManagedDatabaseUser(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementManagedDatabaseUser(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDatabaseManagementManagedDatabaseUser resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDatabaseManagementManagedDatabaseUser to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDatabaseManagementManagedDatabaseUser that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDatabaseManagementManagedDatabaseUser to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDatabaseManagementManagedDatabaseUser to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_user#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDatabaseManagementManagedDatabaseUser that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDatabaseManagementManagedDatabaseUser to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDatabaseManagementManagedDatabaseUser.DataOciDatabaseManagementManagedDatabaseUser), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOpcNamedCredentialId")]
        public virtual void ResetOpcNamedCredentialId()
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
        = GetStaticProperty<string>(typeof(oci.DataOciDatabaseManagementManagedDatabaseUser.DataOciDatabaseManagementManagedDatabaseUser))!;

        [JsiiProperty(name: "allShared", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AllShared
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "authentication", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Authentication
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "common", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Common
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "consumerGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConsumerGroup
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultCollation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultCollation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultTablespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultTablespace
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "editionsEnabled", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EditionsEnabled
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "externalName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "externalShared", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalShared
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "implicit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Implicit
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "inherited", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Inherited
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "localTempTablespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LocalTempTablespace
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "oracleMaintained", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OracleMaintained
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "passwordVersions", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PasswordVersions
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "profile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Profile
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "proxyConnect", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProxyConnect
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tempTablespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TempTablespace
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeExpiring", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeExpiring
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLastLogin", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastLogin
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLocked", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLocked
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timePasswordChanged", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimePasswordChanged
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managedDatabaseIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ManagedDatabaseIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "opcNamedCredentialIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OpcNamedCredentialIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "managedDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedDatabaseId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "opcNamedCredentialId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpcNamedCredentialId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
