using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationAssessment
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_migration_assessment oci_database_migration_assessment}.</summary>
    [JsiiClass(nativeType: typeof(oci.DatabaseMigrationAssessment.DatabaseMigrationAssessment), fullyQualifiedName: "oci.databaseMigrationAssessment.DatabaseMigrationAssessment", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.databaseMigrationAssessment.DatabaseMigrationAssessmentConfig\"}}]")]
    public class DatabaseMigrationAssessment : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_migration_assessment oci_database_migration_assessment} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DatabaseMigrationAssessment(Constructs.Construct scope, string id, oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseMigrationAssessment(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseMigrationAssessment(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DatabaseMigrationAssessment resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DatabaseMigrationAssessment to import.</param>
        /// <param name="importFromId">The id of the existing DatabaseMigrationAssessment that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DatabaseMigrationAssessment to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DatabaseMigrationAssessment to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_migration_assessment#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DatabaseMigrationAssessment that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DatabaseMigrationAssessment to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DatabaseMigrationAssessment.DatabaseMigrationAssessment), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentExcludeObjects" />)[]</param>
        [JsiiMethod(name: "putExcludeObjects", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseMigrationAssessment.DatabaseMigrationAssessmentExcludeObjects\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutExcludeObjects(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentExcludeObjects[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentExcludeObjects).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentExcludeObjects).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentIncludeObjects" />)[]</param>
        [JsiiMethod(name: "putIncludeObjects", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseMigrationAssessment.DatabaseMigrationAssessmentIncludeObjects\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutIncludeObjects(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentIncludeObjects[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentIncludeObjects).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentIncludeObjects).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourceDatabaseConnection", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseMigrationAssessment.DatabaseMigrationAssessmentSourceDatabaseConnection\"}}]")]
        public virtual void PutSourceDatabaseConnection(oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentSourceDatabaseConnection @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentSourceDatabaseConnection)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTargetDatabaseConnection", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseMigrationAssessment.DatabaseMigrationAssessmentTargetDatabaseConnection\"}}]")]
        public virtual void PutTargetDatabaseConnection(oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentTargetDatabaseConnection @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentTargetDatabaseConnection)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseMigrationAssessment.DatabaseMigrationAssessmentTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBulkIncludeExcludeData")]
        public virtual void ResetBulkIncludeExcludeData()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreationType")]
        public virtual void ResetCreationType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExcludeObjects")]
        public virtual void ResetExcludeObjects()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreeformTags")]
        public virtual void ResetFreeformTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIncludeObjects")]
        public virtual void ResetIncludeObjects()
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
        = GetStaticProperty<string>(typeof(oci.DatabaseMigrationAssessment.DatabaseMigrationAssessment))!;

        [JsiiProperty(name: "assessmentMigrationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssessmentMigrationType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "excludeObjects", typeJson: "{\"fqn\":\"oci.databaseMigrationAssessment.DatabaseMigrationAssessmentExcludeObjectsList\"}")]
        public virtual oci.DatabaseMigrationAssessment.DatabaseMigrationAssessmentExcludeObjectsList ExcludeObjects
        {
            get => GetInstanceProperty<oci.DatabaseMigrationAssessment.DatabaseMigrationAssessmentExcludeObjectsList>()!;
        }

        [JsiiProperty(name: "includeObjects", typeJson: "{\"fqn\":\"oci.databaseMigrationAssessment.DatabaseMigrationAssessmentIncludeObjectsList\"}")]
        public virtual oci.DatabaseMigrationAssessment.DatabaseMigrationAssessmentIncludeObjectsList IncludeObjects
        {
            get => GetInstanceProperty<oci.DatabaseMigrationAssessment.DatabaseMigrationAssessmentIncludeObjectsList>()!;
        }

        [JsiiProperty(name: "isCdbSupported", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsCdbSupported
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "migrationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MigrationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceDatabaseConnection", typeJson: "{\"fqn\":\"oci.databaseMigrationAssessment.DatabaseMigrationAssessmentSourceDatabaseConnectionOutputReference\"}")]
        public virtual oci.DatabaseMigrationAssessment.DatabaseMigrationAssessmentSourceDatabaseConnectionOutputReference SourceDatabaseConnection
        {
            get => GetInstanceProperty<oci.DatabaseMigrationAssessment.DatabaseMigrationAssessmentSourceDatabaseConnectionOutputReference>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "targetDatabaseConnection", typeJson: "{\"fqn\":\"oci.databaseMigrationAssessment.DatabaseMigrationAssessmentTargetDatabaseConnectionOutputReference\"}")]
        public virtual oci.DatabaseMigrationAssessment.DatabaseMigrationAssessmentTargetDatabaseConnectionOutputReference TargetDatabaseConnection
        {
            get => GetInstanceProperty<oci.DatabaseMigrationAssessment.DatabaseMigrationAssessmentTargetDatabaseConnectionOutputReference>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseMigrationAssessment.DatabaseMigrationAssessmentTimeoutsOutputReference\"}")]
        public virtual oci.DatabaseMigrationAssessment.DatabaseMigrationAssessmentTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DatabaseMigrationAssessment.DatabaseMigrationAssessmentTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "acceptableDowntimeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AcceptableDowntimeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bulkIncludeExcludeDataInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BulkIncludeExcludeDataInput
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
        [JsiiProperty(name: "creationTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CreationTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseCombinationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatabaseCombinationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseDataSizeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatabaseDataSizeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ddlExpectationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DdlExpectationInput
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
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentExcludeObjects" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "excludeObjectsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseMigrationAssessment.DatabaseMigrationAssessmentExcludeObjects\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ExcludeObjectsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "freeformTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? FreeformTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentIncludeObjects" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "includeObjectsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseMigrationAssessment.DatabaseMigrationAssessmentIncludeObjects\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? IncludeObjectsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkSpeedMegabitPerSecondInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NetworkSpeedMegabitPerSecondInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceDatabaseConnectionInput", typeJson: "{\"fqn\":\"oci.databaseMigrationAssessment.DatabaseMigrationAssessmentSourceDatabaseConnection\"}", isOptional: true)]
        public virtual oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentSourceDatabaseConnection? SourceDatabaseConnectionInput
        {
            get => GetInstanceProperty<oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentSourceDatabaseConnection?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetDatabaseConnectionInput", typeJson: "{\"fqn\":\"oci.databaseMigrationAssessment.DatabaseMigrationAssessmentTargetDatabaseConnection\"}", isOptional: true)]
        public virtual oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentTargetDatabaseConnection? TargetDatabaseConnectionInput
        {
            get => GetInstanceProperty<oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentTargetDatabaseConnection?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.DatabaseMigrationAssessment.IDatabaseMigrationAssessmentTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.databaseMigrationAssessment.DatabaseMigrationAssessmentTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "acceptableDowntime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AcceptableDowntime
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bulkIncludeExcludeData", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BulkIncludeExcludeData
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

        [JsiiProperty(name: "creationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreationType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "databaseCombination", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseCombination
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "databaseDataSize", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseDataSize
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ddlExpectation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DdlExpectation
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

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> FreeformTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "networkSpeedMegabitPerSecond", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkSpeedMegabitPerSecond
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
