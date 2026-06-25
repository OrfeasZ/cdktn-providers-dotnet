using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationAssessmentAssessorAction
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_migration_assessment_assessor_action oci_database_migration_assessment_assessor_action}.</summary>
    [JsiiClass(nativeType: typeof(oci.DatabaseMigrationAssessmentAssessorAction.DatabaseMigrationAssessmentAssessorAction), fullyQualifiedName: "oci.databaseMigrationAssessmentAssessorAction.DatabaseMigrationAssessmentAssessorAction", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.databaseMigrationAssessmentAssessorAction.DatabaseMigrationAssessmentAssessorActionConfig\"}}]")]
    public class DatabaseMigrationAssessmentAssessorAction : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_migration_assessment_assessor_action oci_database_migration_assessment_assessor_action} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DatabaseMigrationAssessmentAssessorAction(Constructs.Construct scope, string id, oci.DatabaseMigrationAssessmentAssessorAction.IDatabaseMigrationAssessmentAssessorActionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DatabaseMigrationAssessmentAssessorAction.IDatabaseMigrationAssessmentAssessorActionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseMigrationAssessmentAssessorAction(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseMigrationAssessmentAssessorAction(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DatabaseMigrationAssessmentAssessorAction resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DatabaseMigrationAssessmentAssessorAction to import.</param>
        /// <param name="importFromId">The id of the existing DatabaseMigrationAssessmentAssessorAction that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DatabaseMigrationAssessmentAssessorAction to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DatabaseMigrationAssessmentAssessorAction to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_migration_assessment_assessor_action#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DatabaseMigrationAssessmentAssessorAction that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DatabaseMigrationAssessmentAssessorAction to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DatabaseMigrationAssessmentAssessorAction.DatabaseMigrationAssessmentAssessorAction), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatabaseMigrationAssessmentAssessorAction.IDatabaseMigrationAssessmentAssessorActionItems" />)[]</param>
        [JsiiMethod(name: "putItems", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseMigrationAssessmentAssessorAction.DatabaseMigrationAssessmentAssessorActionItems\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutItems(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DatabaseMigrationAssessmentAssessorAction.IDatabaseMigrationAssessmentAssessorActionItems[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseMigrationAssessmentAssessorAction.IDatabaseMigrationAssessmentAssessorActionItems).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseMigrationAssessmentAssessorAction.IDatabaseMigrationAssessmentAssessorActionItems).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseMigrationAssessmentAssessorAction.DatabaseMigrationAssessmentAssessorActionTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DatabaseMigrationAssessmentAssessorAction.IDatabaseMigrationAssessmentAssessorActionTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseMigrationAssessmentAssessorAction.IDatabaseMigrationAssessmentAssessorActionTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(oci.DatabaseMigrationAssessmentAssessorAction.DatabaseMigrationAssessmentAssessorAction))!;

        [JsiiProperty(name: "items", typeJson: "{\"fqn\":\"oci.databaseMigrationAssessmentAssessorAction.DatabaseMigrationAssessmentAssessorActionItemsList\"}")]
        public virtual oci.DatabaseMigrationAssessmentAssessorAction.DatabaseMigrationAssessmentAssessorActionItemsList Items
        {
            get => GetInstanceProperty<oci.DatabaseMigrationAssessmentAssessorAction.DatabaseMigrationAssessmentAssessorActionItemsList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseMigrationAssessmentAssessorAction.DatabaseMigrationAssessmentAssessorActionTimeoutsOutputReference\"}")]
        public virtual oci.DatabaseMigrationAssessmentAssessorAction.DatabaseMigrationAssessmentAssessorActionTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DatabaseMigrationAssessmentAssessorAction.DatabaseMigrationAssessmentAssessorActionTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "assessmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AssessmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "assessorActionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AssessorActionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "assessorNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AssessorNameInput
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatabaseMigrationAssessmentAssessorAction.IDatabaseMigrationAssessmentAssessorActionItems" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "itemsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseMigrationAssessmentAssessorAction.DatabaseMigrationAssessmentAssessorActionItems\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ItemsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.DatabaseMigrationAssessmentAssessorAction.IDatabaseMigrationAssessmentAssessorActionTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.databaseMigrationAssessmentAssessorAction.DatabaseMigrationAssessmentAssessorActionTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "assessmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssessmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "assessorAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssessorAction
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "assessorName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssessorName
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
