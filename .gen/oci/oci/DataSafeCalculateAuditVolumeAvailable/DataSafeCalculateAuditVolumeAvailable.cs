using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeCalculateAuditVolumeAvailable
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_calculate_audit_volume_available oci_data_safe_calculate_audit_volume_available}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataSafeCalculateAuditVolumeAvailable.DataSafeCalculateAuditVolumeAvailable), fullyQualifiedName: "oci.dataSafeCalculateAuditVolumeAvailable.DataSafeCalculateAuditVolumeAvailable", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataSafeCalculateAuditVolumeAvailable.DataSafeCalculateAuditVolumeAvailableConfig\"}}]")]
    public class DataSafeCalculateAuditVolumeAvailable : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_calculate_audit_volume_available oci_data_safe_calculate_audit_volume_available} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataSafeCalculateAuditVolumeAvailable(Constructs.Construct scope, string id, oci.DataSafeCalculateAuditVolumeAvailable.IDataSafeCalculateAuditVolumeAvailableConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataSafeCalculateAuditVolumeAvailable.IDataSafeCalculateAuditVolumeAvailableConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataSafeCalculateAuditVolumeAvailable(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataSafeCalculateAuditVolumeAvailable(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataSafeCalculateAuditVolumeAvailable resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataSafeCalculateAuditVolumeAvailable to import.</param>
        /// <param name="importFromId">The id of the existing DataSafeCalculateAuditVolumeAvailable that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataSafeCalculateAuditVolumeAvailable to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataSafeCalculateAuditVolumeAvailable to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_calculate_audit_volume_available#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataSafeCalculateAuditVolumeAvailable that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataSafeCalculateAuditVolumeAvailable to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataSafeCalculateAuditVolumeAvailable.DataSafeCalculateAuditVolumeAvailable), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataSafeCalculateAuditVolumeAvailable.DataSafeCalculateAuditVolumeAvailableTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DataSafeCalculateAuditVolumeAvailable.IDataSafeCalculateAuditVolumeAvailableTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataSafeCalculateAuditVolumeAvailable.IDataSafeCalculateAuditVolumeAvailableTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAuditCollectionStartTime")]
        public virtual void ResetAuditCollectionStartTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDatabaseUniqueName")]
        public virtual void ResetDatabaseUniqueName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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

        [JsiiMethod(name: "resetTrailLocations")]
        public virtual void ResetTrailLocations()
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
        = GetStaticProperty<string>(typeof(oci.DataSafeCalculateAuditVolumeAvailable.DataSafeCalculateAuditVolumeAvailable))!;

        [JsiiProperty(name: "availableAuditVolumes", typeJson: "{\"fqn\":\"oci.dataSafeCalculateAuditVolumeAvailable.DataSafeCalculateAuditVolumeAvailableAvailableAuditVolumesList\"}")]
        public virtual oci.DataSafeCalculateAuditVolumeAvailable.DataSafeCalculateAuditVolumeAvailableAvailableAuditVolumesList AvailableAuditVolumes
        {
            get => GetInstanceProperty<oci.DataSafeCalculateAuditVolumeAvailable.DataSafeCalculateAuditVolumeAvailableAvailableAuditVolumesList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dataSafeCalculateAuditVolumeAvailable.DataSafeCalculateAuditVolumeAvailableTimeoutsOutputReference\"}")]
        public virtual oci.DataSafeCalculateAuditVolumeAvailable.DataSafeCalculateAuditVolumeAvailableTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DataSafeCalculateAuditVolumeAvailable.DataSafeCalculateAuditVolumeAvailableTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "auditCollectionStartTimeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuditCollectionStartTimeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "auditProfileIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuditProfileIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseUniqueNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatabaseUniqueNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.dataSafeCalculateAuditVolumeAvailable.DataSafeCalculateAuditVolumeAvailableTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trailLocationsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? TrailLocationsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "auditCollectionStartTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuditCollectionStartTime
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "auditProfileId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuditProfileId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "databaseUniqueName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseUniqueName
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

        [JsiiProperty(name: "trailLocations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TrailLocations
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
