using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSubsettingPolicyHealthReportManagement
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_health_report_management oci_data_safe_subsetting_policy_health_report_management}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataSafeSubsettingPolicyHealthReportManagement.DataSafeSubsettingPolicyHealthReportManagement), fullyQualifiedName: "oci.dataSafeSubsettingPolicyHealthReportManagement.DataSafeSubsettingPolicyHealthReportManagement", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataSafeSubsettingPolicyHealthReportManagement.DataSafeSubsettingPolicyHealthReportManagementConfig\"}}]")]
    public class DataSafeSubsettingPolicyHealthReportManagement : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_health_report_management oci_data_safe_subsetting_policy_health_report_management} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataSafeSubsettingPolicyHealthReportManagement(Constructs.Construct scope, string id, oci.DataSafeSubsettingPolicyHealthReportManagement.IDataSafeSubsettingPolicyHealthReportManagementConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataSafeSubsettingPolicyHealthReportManagement.IDataSafeSubsettingPolicyHealthReportManagementConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataSafeSubsettingPolicyHealthReportManagement(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataSafeSubsettingPolicyHealthReportManagement(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataSafeSubsettingPolicyHealthReportManagement resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataSafeSubsettingPolicyHealthReportManagement to import.</param>
        /// <param name="importFromId">The id of the existing DataSafeSubsettingPolicyHealthReportManagement that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataSafeSubsettingPolicyHealthReportManagement to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataSafeSubsettingPolicyHealthReportManagement to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_health_report_management#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataSafeSubsettingPolicyHealthReportManagement that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataSafeSubsettingPolicyHealthReportManagement to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataSafeSubsettingPolicyHealthReportManagement.DataSafeSubsettingPolicyHealthReportManagement), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTargetCredentials", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataSafeSubsettingPolicyHealthReportManagement.DataSafeSubsettingPolicyHealthReportManagementTargetCredentials\"}}]")]
        public virtual void PutTargetCredentials(oci.DataSafeSubsettingPolicyHealthReportManagement.IDataSafeSubsettingPolicyHealthReportManagementTargetCredentials @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataSafeSubsettingPolicyHealthReportManagement.IDataSafeSubsettingPolicyHealthReportManagementTargetCredentials)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataSafeSubsettingPolicyHealthReportManagement.DataSafeSubsettingPolicyHealthReportManagementTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DataSafeSubsettingPolicyHealthReportManagement.IDataSafeSubsettingPolicyHealthReportManagementTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataSafeSubsettingPolicyHealthReportManagement.IDataSafeSubsettingPolicyHealthReportManagementTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCheckType")]
        public virtual void ResetCheckType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCompartmentId")]
        public virtual void ResetCompartmentId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreeformTags")]
        public virtual void ResetFreeformTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTablespace")]
        public virtual void ResetTablespace()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetId")]
        public virtual void ResetTargetId()
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
        = GetStaticProperty<string>(typeof(oci.DataSafeSubsettingPolicyHealthReportManagement.DataSafeSubsettingPolicyHealthReportManagement))!;

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "errorCount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ErrorCount
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetCredentials", typeJson: "{\"fqn\":\"oci.dataSafeSubsettingPolicyHealthReportManagement.DataSafeSubsettingPolicyHealthReportManagementTargetCredentialsOutputReference\"}")]
        public virtual oci.DataSafeSubsettingPolicyHealthReportManagement.DataSafeSubsettingPolicyHealthReportManagementTargetCredentialsOutputReference TargetCredentials
        {
            get => GetInstanceProperty<oci.DataSafeSubsettingPolicyHealthReportManagement.DataSafeSubsettingPolicyHealthReportManagementTargetCredentialsOutputReference>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dataSafeSubsettingPolicyHealthReportManagement.DataSafeSubsettingPolicyHealthReportManagementTimeoutsOutputReference\"}")]
        public virtual oci.DataSafeSubsettingPolicyHealthReportManagement.DataSafeSubsettingPolicyHealthReportManagementTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DataSafeSubsettingPolicyHealthReportManagement.DataSafeSubsettingPolicyHealthReportManagementTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "warningCount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WarningCount
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "checkTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CheckTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "freeformTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? FreeformTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subsettingPolicyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubsettingPolicyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tablespaceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TablespaceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetCredentialsInput", typeJson: "{\"fqn\":\"oci.dataSafeSubsettingPolicyHealthReportManagement.DataSafeSubsettingPolicyHealthReportManagementTargetCredentials\"}", isOptional: true)]
        public virtual oci.DataSafeSubsettingPolicyHealthReportManagement.IDataSafeSubsettingPolicyHealthReportManagementTargetCredentials? TargetCredentialsInput
        {
            get => GetInstanceProperty<oci.DataSafeSubsettingPolicyHealthReportManagement.IDataSafeSubsettingPolicyHealthReportManagementTargetCredentials?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.DataSafeSubsettingPolicyHealthReportManagement.IDataSafeSubsettingPolicyHealthReportManagementTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.dataSafeSubsettingPolicyHealthReportManagement.DataSafeSubsettingPolicyHealthReportManagementTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "checkType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CheckType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> DefinedTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> FreeformTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subsettingPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubsettingPolicyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tablespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tablespace
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
