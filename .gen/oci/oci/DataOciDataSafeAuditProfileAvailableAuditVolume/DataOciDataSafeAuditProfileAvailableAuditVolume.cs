using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeAuditProfileAvailableAuditVolume
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_audit_profile_available_audit_volume oci_data_safe_audit_profile_available_audit_volume}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeAuditProfileAvailableAuditVolume.DataOciDataSafeAuditProfileAvailableAuditVolume), fullyQualifiedName: "oci.dataOciDataSafeAuditProfileAvailableAuditVolume.DataOciDataSafeAuditProfileAvailableAuditVolume", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDataSafeAuditProfileAvailableAuditVolume.DataOciDataSafeAuditProfileAvailableAuditVolumeConfig\"}}]")]
    public class DataOciDataSafeAuditProfileAvailableAuditVolume : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_audit_profile_available_audit_volume oci_data_safe_audit_profile_available_audit_volume} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDataSafeAuditProfileAvailableAuditVolume(Constructs.Construct scope, string id, oci.DataOciDataSafeAuditProfileAvailableAuditVolume.IDataOciDataSafeAuditProfileAvailableAuditVolumeConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDataSafeAuditProfileAvailableAuditVolume.IDataOciDataSafeAuditProfileAvailableAuditVolumeConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeAuditProfileAvailableAuditVolume(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeAuditProfileAvailableAuditVolume(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDataSafeAuditProfileAvailableAuditVolume resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDataSafeAuditProfileAvailableAuditVolume to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDataSafeAuditProfileAvailableAuditVolume that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDataSafeAuditProfileAvailableAuditVolume to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDataSafeAuditProfileAvailableAuditVolume to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_audit_profile_available_audit_volume#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDataSafeAuditProfileAvailableAuditVolume that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDataSafeAuditProfileAvailableAuditVolume to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDataSafeAuditProfileAvailableAuditVolume.DataOciDataSafeAuditProfileAvailableAuditVolume), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMonthInConsiderationGreaterThan")]
        public virtual void ResetMonthInConsiderationGreaterThan()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMonthInConsiderationLessThan")]
        public virtual void ResetMonthInConsiderationLessThan()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTrailLocation")]
        public virtual void ResetTrailLocation()
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
        = GetStaticProperty<string>(typeof(oci.DataOciDataSafeAuditProfileAvailableAuditVolume.DataOciDataSafeAuditProfileAvailableAuditVolume))!;

        [JsiiProperty(name: "items", typeJson: "{\"fqn\":\"oci.dataOciDataSafeAuditProfileAvailableAuditVolume.DataOciDataSafeAuditProfileAvailableAuditVolumeItemsList\"}")]
        public virtual oci.DataOciDataSafeAuditProfileAvailableAuditVolume.DataOciDataSafeAuditProfileAvailableAuditVolumeItemsList Items
        {
            get => GetInstanceProperty<oci.DataOciDataSafeAuditProfileAvailableAuditVolume.DataOciDataSafeAuditProfileAvailableAuditVolumeItemsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "auditProfileIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuditProfileIdInput
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
        [JsiiProperty(name: "monthInConsiderationGreaterThanInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MonthInConsiderationGreaterThanInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "monthInConsiderationLessThanInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MonthInConsiderationLessThanInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trailLocationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TrailLocationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workRequestIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WorkRequestIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "auditProfileId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuditProfileId
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

        [JsiiProperty(name: "monthInConsiderationGreaterThan", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MonthInConsiderationGreaterThan
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "monthInConsiderationLessThan", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MonthInConsiderationLessThan
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "trailLocation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TrailLocation
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "workRequestId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkRequestId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
