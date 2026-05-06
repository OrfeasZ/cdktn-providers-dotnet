using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeSecurityAssessmentTemplateBaselineComparison
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_security_assessment_template_baseline_comparison oci_data_safe_security_assessment_template_baseline_comparison}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeSecurityAssessmentTemplateBaselineComparison.DataOciDataSafeSecurityAssessmentTemplateBaselineComparison), fullyQualifiedName: "oci.dataOciDataSafeSecurityAssessmentTemplateBaselineComparison.DataOciDataSafeSecurityAssessmentTemplateBaselineComparison", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDataSafeSecurityAssessmentTemplateBaselineComparison.DataOciDataSafeSecurityAssessmentTemplateBaselineComparisonConfig\"}}]")]
    public class DataOciDataSafeSecurityAssessmentTemplateBaselineComparison : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_security_assessment_template_baseline_comparison oci_data_safe_security_assessment_template_baseline_comparison} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDataSafeSecurityAssessmentTemplateBaselineComparison(Constructs.Construct scope, string id, oci.DataOciDataSafeSecurityAssessmentTemplateBaselineComparison.IDataOciDataSafeSecurityAssessmentTemplateBaselineComparisonConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDataSafeSecurityAssessmentTemplateBaselineComparison.IDataOciDataSafeSecurityAssessmentTemplateBaselineComparisonConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeSecurityAssessmentTemplateBaselineComparison(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeSecurityAssessmentTemplateBaselineComparison(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDataSafeSecurityAssessmentTemplateBaselineComparison resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDataSafeSecurityAssessmentTemplateBaselineComparison to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDataSafeSecurityAssessmentTemplateBaselineComparison that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDataSafeSecurityAssessmentTemplateBaselineComparison to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDataSafeSecurityAssessmentTemplateBaselineComparison to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_security_assessment_template_baseline_comparison#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDataSafeSecurityAssessmentTemplateBaselineComparison that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDataSafeSecurityAssessmentTemplateBaselineComparison to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDataSafeSecurityAssessmentTemplateBaselineComparison.DataOciDataSafeSecurityAssessmentTemplateBaselineComparison), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetCategory")]
        public virtual void ResetCategory()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFindingKey")]
        public virtual void ResetFindingKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetId")]
        public virtual void ResetTargetId()
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
        = GetStaticProperty<string>(typeof(oci.DataOciDataSafeSecurityAssessmentTemplateBaselineComparison.DataOciDataSafeSecurityAssessmentTemplateBaselineComparison))!;

        [JsiiProperty(name: "auditing", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessmentTemplateBaselineComparison.DataOciDataSafeSecurityAssessmentTemplateBaselineComparisonAuditingList\"}")]
        public virtual oci.DataOciDataSafeSecurityAssessmentTemplateBaselineComparison.DataOciDataSafeSecurityAssessmentTemplateBaselineComparisonAuditingList Auditing
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessmentTemplateBaselineComparison.DataOciDataSafeSecurityAssessmentTemplateBaselineComparisonAuditingList>()!;
        }

        [JsiiProperty(name: "authorizationControl", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessmentTemplateBaselineComparison.DataOciDataSafeSecurityAssessmentTemplateBaselineComparisonAuthorizationControlList\"}")]
        public virtual oci.DataOciDataSafeSecurityAssessmentTemplateBaselineComparison.DataOciDataSafeSecurityAssessmentTemplateBaselineComparisonAuthorizationControlList AuthorizationControl
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessmentTemplateBaselineComparison.DataOciDataSafeSecurityAssessmentTemplateBaselineComparisonAuthorizationControlList>()!;
        }

        [JsiiProperty(name: "dataEncryption", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessmentTemplateBaselineComparison.DataOciDataSafeSecurityAssessmentTemplateBaselineComparisonDataEncryptionList\"}")]
        public virtual oci.DataOciDataSafeSecurityAssessmentTemplateBaselineComparison.DataOciDataSafeSecurityAssessmentTemplateBaselineComparisonDataEncryptionList DataEncryption
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessmentTemplateBaselineComparison.DataOciDataSafeSecurityAssessmentTemplateBaselineComparisonDataEncryptionList>()!;
        }

        [JsiiProperty(name: "dbConfiguration", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessmentTemplateBaselineComparison.DataOciDataSafeSecurityAssessmentTemplateBaselineComparisonDbConfigurationList\"}")]
        public virtual oci.DataOciDataSafeSecurityAssessmentTemplateBaselineComparison.DataOciDataSafeSecurityAssessmentTemplateBaselineComparisonDbConfigurationList DbConfiguration
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessmentTemplateBaselineComparison.DataOciDataSafeSecurityAssessmentTemplateBaselineComparisonDbConfigurationList>()!;
        }

        [JsiiProperty(name: "fineGrainedAccessControl", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessmentTemplateBaselineComparison.DataOciDataSafeSecurityAssessmentTemplateBaselineComparisonFineGrainedAccessControlList\"}")]
        public virtual oci.DataOciDataSafeSecurityAssessmentTemplateBaselineComparison.DataOciDataSafeSecurityAssessmentTemplateBaselineComparisonFineGrainedAccessControlList FineGrainedAccessControl
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessmentTemplateBaselineComparison.DataOciDataSafeSecurityAssessmentTemplateBaselineComparisonFineGrainedAccessControlList>()!;
        }

        [JsiiProperty(name: "privilegesAndRoles", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessmentTemplateBaselineComparison.DataOciDataSafeSecurityAssessmentTemplateBaselineComparisonPrivilegesAndRolesList\"}")]
        public virtual oci.DataOciDataSafeSecurityAssessmentTemplateBaselineComparison.DataOciDataSafeSecurityAssessmentTemplateBaselineComparisonPrivilegesAndRolesList PrivilegesAndRoles
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessmentTemplateBaselineComparison.DataOciDataSafeSecurityAssessmentTemplateBaselineComparisonPrivilegesAndRolesList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "templateBaselineId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TemplateBaselineId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "templateBaselineName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TemplateBaselineName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userAccounts", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessmentTemplateBaselineComparison.DataOciDataSafeSecurityAssessmentTemplateBaselineComparisonUserAccountsList\"}")]
        public virtual oci.DataOciDataSafeSecurityAssessmentTemplateBaselineComparison.DataOciDataSafeSecurityAssessmentTemplateBaselineComparisonUserAccountsList UserAccounts
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessmentTemplateBaselineComparison.DataOciDataSafeSecurityAssessmentTemplateBaselineComparisonUserAccountsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "categoryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CategoryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "comparisonSecurityAssessmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ComparisonSecurityAssessmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "findingKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FindingKeyInput
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
        [JsiiProperty(name: "securityAssessmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecurityAssessmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Category
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "comparisonSecurityAssessmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComparisonSecurityAssessmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "findingKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FindingKey
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

        [JsiiProperty(name: "securityAssessmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityAssessmentId
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
