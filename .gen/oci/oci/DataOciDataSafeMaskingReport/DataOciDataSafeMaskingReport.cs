using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeMaskingReport
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_masking_report oci_data_safe_masking_report}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeMaskingReport.DataOciDataSafeMaskingReport), fullyQualifiedName: "oci.dataOciDataSafeMaskingReport.DataOciDataSafeMaskingReport", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDataSafeMaskingReport.DataOciDataSafeMaskingReportConfig\"}}]")]
    public class DataOciDataSafeMaskingReport : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_masking_report oci_data_safe_masking_report} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDataSafeMaskingReport(Constructs.Construct scope, string id, oci.DataOciDataSafeMaskingReport.IDataOciDataSafeMaskingReportConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDataSafeMaskingReport.IDataOciDataSafeMaskingReportConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeMaskingReport(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeMaskingReport(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDataSafeMaskingReport resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDataSafeMaskingReport to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDataSafeMaskingReport that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDataSafeMaskingReport to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDataSafeMaskingReport to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_masking_report#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDataSafeMaskingReport that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDataSafeMaskingReport to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDataSafeMaskingReport.DataOciDataSafeMaskingReport), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(oci.DataOciDataSafeMaskingReport.DataOciDataSafeMaskingReport))!;

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isDropTempTablesEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsDropTempTablesEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isRedoLoggingEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsRedoLoggingEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isRefreshStatsEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsRefreshStatsEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "maskingPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaskingPolicyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maskingStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaskingStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maskingWorkRequestId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaskingWorkRequestId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parallelDegree", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParallelDegree
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "recompile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Recompile
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeMaskingFinished", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeMaskingFinished
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeMaskingStarted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeMaskingStarted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalMaskedColumns", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalMaskedColumns
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalMaskedObjects", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalMaskedObjects
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalMaskedSchemas", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalMaskedSchemas
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalMaskedSensitiveTypes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalMaskedSensitiveTypes
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalMaskedValues", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalMaskedValues
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalPostMaskingScriptErrors", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalPostMaskingScriptErrors
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalPreMaskingScriptErrors", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalPreMaskingScriptErrors
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
        [JsiiProperty(name: "maskingReportIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaskingReportIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maskingReportId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaskingReportId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
