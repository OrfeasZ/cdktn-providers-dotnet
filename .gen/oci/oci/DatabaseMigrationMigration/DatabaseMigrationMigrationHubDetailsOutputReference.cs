using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationMigration
{
    [JsiiClass(nativeType: typeof(oci.DatabaseMigrationMigration.DatabaseMigrationMigrationHubDetailsOutputReference), fullyQualifiedName: "oci.databaseMigrationMigration.DatabaseMigrationMigrationHubDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatabaseMigrationMigrationHubDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatabaseMigrationMigrationHubDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseMigrationMigrationHubDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseMigrationMigrationHubDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putExtract", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationHubDetailsExtract\"}}]")]
        public virtual void PutExtract(oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationHubDetailsExtract @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationHubDetailsExtract)}, new object[]{@value});
        }

        [JsiiMethod(name: "putReplicat", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationHubDetailsReplicat\"}}]")]
        public virtual void PutReplicat(oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationHubDetailsReplicat @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationHubDetailsReplicat)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRestAdminCredentials", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationHubDetailsRestAdminCredentials\"}}]")]
        public virtual void PutRestAdminCredentials(oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationHubDetailsRestAdminCredentials @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationHubDetailsRestAdminCredentials)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAcceptableLag")]
        public virtual void ResetAcceptableLag()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetComputeId")]
        public virtual void ResetComputeId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExtract")]
        public virtual void ResetExtract()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReplicat")]
        public virtual void ResetReplicat()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "extract", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationHubDetailsExtractOutputReference\"}")]
        public virtual oci.DatabaseMigrationMigration.DatabaseMigrationMigrationHubDetailsExtractOutputReference Extract
        {
            get => GetInstanceProperty<oci.DatabaseMigrationMigration.DatabaseMigrationMigrationHubDetailsExtractOutputReference>()!;
        }

        [JsiiProperty(name: "replicat", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationHubDetailsReplicatOutputReference\"}")]
        public virtual oci.DatabaseMigrationMigration.DatabaseMigrationMigrationHubDetailsReplicatOutputReference Replicat
        {
            get => GetInstanceProperty<oci.DatabaseMigrationMigration.DatabaseMigrationMigrationHubDetailsReplicatOutputReference>()!;
        }

        [JsiiProperty(name: "restAdminCredentials", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationHubDetailsRestAdminCredentialsOutputReference\"}")]
        public virtual oci.DatabaseMigrationMigration.DatabaseMigrationMigrationHubDetailsRestAdminCredentialsOutputReference RestAdminCredentials
        {
            get => GetInstanceProperty<oci.DatabaseMigrationMigration.DatabaseMigrationMigrationHubDetailsRestAdminCredentialsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "acceptableLagInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AcceptableLagInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "computeIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ComputeIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "extractInput", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationHubDetailsExtract\"}", isOptional: true)]
        public virtual oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationHubDetailsExtract? ExtractInput
        {
            get => GetInstanceProperty<oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationHubDetailsExtract?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicatInput", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationHubDetailsReplicat\"}", isOptional: true)]
        public virtual oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationHubDetailsReplicat? ReplicatInput
        {
            get => GetInstanceProperty<oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationHubDetailsReplicat?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "restAdminCredentialsInput", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationHubDetailsRestAdminCredentials\"}", isOptional: true)]
        public virtual oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationHubDetailsRestAdminCredentials? RestAdminCredentialsInput
        {
            get => GetInstanceProperty<oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationHubDetailsRestAdminCredentials?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vaultIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VaultIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "acceptableLag", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AcceptableLag
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "computeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Url
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vaultId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VaultId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationHubDetails\"}", isOptional: true)]
        public virtual oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationHubDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationHubDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
