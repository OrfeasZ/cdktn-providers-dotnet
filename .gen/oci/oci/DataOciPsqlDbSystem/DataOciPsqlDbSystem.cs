using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciPsqlDbSystem
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/psql_db_system oci_psql_db_system}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciPsqlDbSystem.DataOciPsqlDbSystem), fullyQualifiedName: "oci.dataOciPsqlDbSystem.DataOciPsqlDbSystem", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciPsqlDbSystem.DataOciPsqlDbSystemConfig\"}}]")]
    public class DataOciPsqlDbSystem : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/psql_db_system oci_psql_db_system} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciPsqlDbSystem(Constructs.Construct scope, string id, oci.DataOciPsqlDbSystem.IDataOciPsqlDbSystemConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciPsqlDbSystem.IDataOciPsqlDbSystemConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciPsqlDbSystem(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciPsqlDbSystem(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciPsqlDbSystem resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciPsqlDbSystem to import.</param>
        /// <param name="importFromId">The id of the existing DataOciPsqlDbSystem that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciPsqlDbSystem to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciPsqlDbSystem to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/psql_db_system#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciPsqlDbSystem that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciPsqlDbSystem to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciPsqlDbSystem.DataOciPsqlDbSystem), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetExcludedFields")]
        public virtual void ResetExcludedFields()
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
        = GetStaticProperty<string>(typeof(oci.DataOciPsqlDbSystem.DataOciPsqlDbSystem))!;

        [JsiiProperty(name: "adminUsername", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminUsername
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "applyConfig", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplyConfig
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "credentials", typeJson: "{\"fqn\":\"oci.dataOciPsqlDbSystem.DataOciPsqlDbSystemCredentialsList\"}")]
        public virtual oci.DataOciPsqlDbSystem.DataOciPsqlDbSystemCredentialsList Credentials
        {
            get => GetInstanceProperty<oci.DataOciPsqlDbSystem.DataOciPsqlDbSystemCredentialsList>()!;
        }

        [JsiiProperty(name: "dbVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
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

        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InstanceCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "instanceMemorySizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InstanceMemorySizeInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "instanceOcpuCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InstanceOcpuCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "instances", typeJson: "{\"fqn\":\"oci.dataOciPsqlDbSystem.DataOciPsqlDbSystemInstancesList\"}")]
        public virtual oci.DataOciPsqlDbSystem.DataOciPsqlDbSystemInstancesList Instances
        {
            get => GetInstanceProperty<oci.DataOciPsqlDbSystem.DataOciPsqlDbSystemInstancesList>()!;
        }

        [JsiiProperty(name: "instancesDetails", typeJson: "{\"fqn\":\"oci.dataOciPsqlDbSystem.DataOciPsqlDbSystemInstancesDetailsList\"}")]
        public virtual oci.DataOciPsqlDbSystem.DataOciPsqlDbSystemInstancesDetailsList InstancesDetails
        {
            get => GetInstanceProperty<oci.DataOciPsqlDbSystem.DataOciPsqlDbSystemInstancesDetailsList>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managementPolicy", typeJson: "{\"fqn\":\"oci.dataOciPsqlDbSystem.DataOciPsqlDbSystemManagementPolicyList\"}")]
        public virtual oci.DataOciPsqlDbSystem.DataOciPsqlDbSystemManagementPolicyList ManagementPolicy
        {
            get => GetInstanceProperty<oci.DataOciPsqlDbSystem.DataOciPsqlDbSystemManagementPolicyList>()!;
        }

        [JsiiProperty(name: "networkDetails", typeJson: "{\"fqn\":\"oci.dataOciPsqlDbSystem.DataOciPsqlDbSystemNetworkDetailsList\"}")]
        public virtual oci.DataOciPsqlDbSystem.DataOciPsqlDbSystemNetworkDetailsList NetworkDetails
        {
            get => GetInstanceProperty<oci.DataOciPsqlDbSystem.DataOciPsqlDbSystemNetworkDetailsList>()!;
        }

        [JsiiProperty(name: "patchOperations", typeJson: "{\"fqn\":\"oci.dataOciPsqlDbSystem.DataOciPsqlDbSystemPatchOperationsList\"}")]
        public virtual oci.DataOciPsqlDbSystem.DataOciPsqlDbSystemPatchOperationsList PatchOperations
        {
            get => GetInstanceProperty<oci.DataOciPsqlDbSystem.DataOciPsqlDbSystemPatchOperationsList>()!;
        }

        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Shape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"oci.dataOciPsqlDbSystem.DataOciPsqlDbSystemSourceList\"}")]
        public virtual oci.DataOciPsqlDbSystem.DataOciPsqlDbSystemSourceList Source
        {
            get => GetInstanceProperty<oci.DataOciPsqlDbSystem.DataOciPsqlDbSystemSourceList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageDetails", typeJson: "{\"fqn\":\"oci.dataOciPsqlDbSystem.DataOciPsqlDbSystemStorageDetailsList\"}")]
        public virtual oci.DataOciPsqlDbSystem.DataOciPsqlDbSystemStorageDetailsList StorageDetails
        {
            get => GetInstanceProperty<oci.DataOciPsqlDbSystem.DataOciPsqlDbSystemStorageDetailsList>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "systemType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SystemType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbSystemIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DbSystemIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "excludedFieldsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExcludedFieldsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "dbSystemId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbSystemId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "excludedFields", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExcludedFields
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
