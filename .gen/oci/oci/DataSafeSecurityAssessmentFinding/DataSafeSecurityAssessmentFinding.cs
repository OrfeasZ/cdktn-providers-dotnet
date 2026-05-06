using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSecurityAssessmentFinding
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_security_assessment_finding oci_data_safe_security_assessment_finding}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataSafeSecurityAssessmentFinding.DataSafeSecurityAssessmentFinding), fullyQualifiedName: "oci.dataSafeSecurityAssessmentFinding.DataSafeSecurityAssessmentFinding", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataSafeSecurityAssessmentFinding.DataSafeSecurityAssessmentFindingConfig\"}}]")]
    public class DataSafeSecurityAssessmentFinding : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_security_assessment_finding oci_data_safe_security_assessment_finding} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataSafeSecurityAssessmentFinding(Constructs.Construct scope, string id, oci.DataSafeSecurityAssessmentFinding.IDataSafeSecurityAssessmentFindingConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataSafeSecurityAssessmentFinding.IDataSafeSecurityAssessmentFindingConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataSafeSecurityAssessmentFinding(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataSafeSecurityAssessmentFinding(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataSafeSecurityAssessmentFinding resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataSafeSecurityAssessmentFinding to import.</param>
        /// <param name="importFromId">The id of the existing DataSafeSecurityAssessmentFinding that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataSafeSecurityAssessmentFinding to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataSafeSecurityAssessmentFinding to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_security_assessment_finding#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataSafeSecurityAssessmentFinding that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataSafeSecurityAssessmentFinding to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataSafeSecurityAssessmentFinding.DataSafeSecurityAssessmentFinding), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putPatchOperations", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataSafeSecurityAssessmentFinding.DataSafeSecurityAssessmentFindingPatchOperations\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPatchOperations(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataSafeSecurityAssessmentFinding.IDataSafeSecurityAssessmentFindingPatchOperations[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataSafeSecurityAssessmentFinding.IDataSafeSecurityAssessmentFindingPatchOperations).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataSafeSecurityAssessmentFinding.IDataSafeSecurityAssessmentFindingPatchOperations).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataSafeSecurityAssessmentFinding.DataSafeSecurityAssessmentFindingTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DataSafeSecurityAssessmentFinding.IDataSafeSecurityAssessmentFindingTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataSafeSecurityAssessmentFinding.IDataSafeSecurityAssessmentFindingTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPatchOperations")]
        public virtual void ResetPatchOperations()
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
        = GetStaticProperty<string>(typeof(oci.DataSafeSecurityAssessmentFinding.DataSafeSecurityAssessmentFinding))!;

        [JsiiProperty(name: "assessmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssessmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Category
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "details", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Details
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "hasTargetDbRiskLevelChanged", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable HasTargetDbRiskLevelChanged
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isRiskModified", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsRiskModified
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isTopFinding", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsTopFinding
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "justification", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Justification
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "oneline", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Oneline
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "oracleDefinedSeverity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OracleDefinedSeverity
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "patchOperations", typeJson: "{\"fqn\":\"oci.dataSafeSecurityAssessmentFinding.DataSafeSecurityAssessmentFindingPatchOperationsList\"}")]
        public virtual oci.DataSafeSecurityAssessmentFinding.DataSafeSecurityAssessmentFindingPatchOperationsList PatchOperations
        {
            get => GetInstanceProperty<oci.DataSafeSecurityAssessmentFinding.DataSafeSecurityAssessmentFindingPatchOperationsList>()!;
        }

        [JsiiProperty(name: "references", typeJson: "{\"fqn\":\"oci.dataSafeSecurityAssessmentFinding.DataSafeSecurityAssessmentFindingReferencesList\"}")]
        public virtual oci.DataSafeSecurityAssessmentFinding.DataSafeSecurityAssessmentFindingReferencesList References
        {
            get => GetInstanceProperty<oci.DataSafeSecurityAssessmentFinding.DataSafeSecurityAssessmentFindingReferencesList>()!;
        }

        [JsiiProperty(name: "remarks", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Remarks
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "severity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Severity
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "summary", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Summary
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dataSafeSecurityAssessmentFinding.DataSafeSecurityAssessmentFindingTimeoutsOutputReference\"}")]
        public virtual oci.DataSafeSecurityAssessmentFinding.DataSafeSecurityAssessmentFindingTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DataSafeSecurityAssessmentFinding.DataSafeSecurityAssessmentFindingTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeValidUntil", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeValidUntil
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Title
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
        [JsiiProperty(name: "patchOperationsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataSafeSecurityAssessmentFinding.DataSafeSecurityAssessmentFindingPatchOperations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PatchOperationsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityAssessmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecurityAssessmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.dataSafeSecurityAssessmentFinding.DataSafeSecurityAssessmentFindingTimeouts\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "securityAssessmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityAssessmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
