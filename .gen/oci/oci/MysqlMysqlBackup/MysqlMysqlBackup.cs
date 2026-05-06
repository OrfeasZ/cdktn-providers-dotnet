using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlBackup
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_backup oci_mysql_mysql_backup}.</summary>
    [JsiiClass(nativeType: typeof(oci.MysqlMysqlBackup.MysqlMysqlBackup), fullyQualifiedName: "oci.mysqlMysqlBackup.MysqlMysqlBackup", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"oci.mysqlMysqlBackup.MysqlMysqlBackupConfig\"}}]")]
    public class MysqlMysqlBackup : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_backup oci_mysql_mysql_backup} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public MysqlMysqlBackup(Constructs.Construct scope, string id, oci.MysqlMysqlBackup.IMysqlMysqlBackupConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.MysqlMysqlBackup.IMysqlMysqlBackupConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MysqlMysqlBackup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MysqlMysqlBackup(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a MysqlMysqlBackup resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the MysqlMysqlBackup to import.</param>
        /// <param name="importFromId">The id of the existing MysqlMysqlBackup that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the MysqlMysqlBackup to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the MysqlMysqlBackup to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_mysql_backup#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing MysqlMysqlBackup that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the MysqlMysqlBackup to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.MysqlMysqlBackup.MysqlMysqlBackup), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putDbSystemSnapshotSummary", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.mysqlMysqlBackup.MysqlMysqlBackupDbSystemSnapshotSummary\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDbSystemSnapshotSummary(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.MysqlMysqlBackup.IMysqlMysqlBackupDbSystemSnapshotSummary[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.MysqlMysqlBackup.IMysqlMysqlBackupDbSystemSnapshotSummary).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.MysqlMysqlBackup.IMysqlMysqlBackupDbSystemSnapshotSummary).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEncryptData", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.mysqlMysqlBackup.MysqlMysqlBackupEncryptData\"}}]")]
        public virtual void PutEncryptData(oci.MysqlMysqlBackup.IMysqlMysqlBackupEncryptData @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.MysqlMysqlBackup.IMysqlMysqlBackupEncryptData)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourceDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.mysqlMysqlBackup.MysqlMysqlBackupSourceDetails\"}}]")]
        public virtual void PutSourceDetails(oci.MysqlMysqlBackup.IMysqlMysqlBackupSourceDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.MysqlMysqlBackup.IMysqlMysqlBackupSourceDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.mysqlMysqlBackup.MysqlMysqlBackupTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.MysqlMysqlBackup.IMysqlMysqlBackupTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.MysqlMysqlBackup.IMysqlMysqlBackupTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putValidateBackupDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.mysqlMysqlBackup.MysqlMysqlBackupValidateBackupDetails\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutValidateBackupDetails(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.MysqlMysqlBackup.IMysqlMysqlBackupValidateBackupDetails[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.MysqlMysqlBackup.IMysqlMysqlBackupValidateBackupDetails).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.MysqlMysqlBackup.IMysqlMysqlBackupValidateBackupDetails).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBackupType")]
        public virtual void ResetBackupType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCompartmentId")]
        public virtual void ResetCompartmentId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDbSystemId")]
        public virtual void ResetDbSystemId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDbSystemSnapshotSummary")]
        public virtual void ResetDbSystemSnapshotSummary()
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

        [JsiiMethod(name: "resetEncryptData")]
        public virtual void ResetEncryptData()
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

        [JsiiMethod(name: "resetRetentionInDays")]
        public virtual void ResetRetentionInDays()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSoftDelete")]
        public virtual void ResetSoftDelete()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceDetails")]
        public virtual void ResetSourceDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetValidateBackupDetails")]
        public virtual void ResetValidateBackupDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetValidateTrigger")]
        public virtual void ResetValidateTrigger()
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
        = GetStaticProperty<string>(typeof(oci.MysqlMysqlBackup.MysqlMysqlBackup))!;

        [JsiiProperty(name: "backupSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BackupSizeInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "backupValidationDetails", typeJson: "{\"fqn\":\"oci.mysqlMysqlBackup.MysqlMysqlBackupBackupValidationDetailsList\"}")]
        public virtual oci.MysqlMysqlBackup.MysqlMysqlBackupBackupValidationDetailsList BackupValidationDetails
        {
            get => GetInstanceProperty<oci.MysqlMysqlBackup.MysqlMysqlBackupBackupValidationDetailsList>()!;
        }

        [JsiiProperty(name: "creationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreationType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataStorageSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataStorageSizeInGb
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dbSystemSnapshot", typeJson: "{\"fqn\":\"oci.mysqlMysqlBackup.MysqlMysqlBackupDbSystemSnapshotList\"}")]
        public virtual oci.MysqlMysqlBackup.MysqlMysqlBackupDbSystemSnapshotList DbSystemSnapshot
        {
            get => GetInstanceProperty<oci.MysqlMysqlBackup.MysqlMysqlBackupDbSystemSnapshotList>()!;
        }

        [JsiiProperty(name: "dbSystemSnapshotSummary", typeJson: "{\"fqn\":\"oci.mysqlMysqlBackup.MysqlMysqlBackupDbSystemSnapshotSummaryList\"}")]
        public virtual oci.MysqlMysqlBackup.MysqlMysqlBackupDbSystemSnapshotSummaryList DbSystemSnapshotSummary
        {
            get => GetInstanceProperty<oci.MysqlMysqlBackup.MysqlMysqlBackupDbSystemSnapshotSummaryList>()!;
        }

        [JsiiProperty(name: "encryptData", typeJson: "{\"fqn\":\"oci.mysqlMysqlBackup.MysqlMysqlBackupEncryptDataOutputReference\"}")]
        public virtual oci.MysqlMysqlBackup.MysqlMysqlBackupEncryptDataOutputReference EncryptData
        {
            get => GetInstanceProperty<oci.MysqlMysqlBackup.MysqlMysqlBackupEncryptDataOutputReference>()!;
        }

        [JsiiProperty(name: "immediateSourceBackupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImmediateSourceBackupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mysqlVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MysqlVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "originalSourceBackupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OriginalSourceBackupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shapeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShapeName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceDetails", typeJson: "{\"fqn\":\"oci.mysqlMysqlBackup.MysqlMysqlBackupSourceDetailsOutputReference\"}")]
        public virtual oci.MysqlMysqlBackup.MysqlMysqlBackupSourceDetailsOutputReference SourceDetails
        {
            get => GetInstanceProperty<oci.MysqlMysqlBackup.MysqlMysqlBackupSourceDetailsOutputReference>()!;
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

        [JsiiProperty(name: "timeCopyCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCopyCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.mysqlMysqlBackup.MysqlMysqlBackupTimeoutsOutputReference\"}")]
        public virtual oci.MysqlMysqlBackup.MysqlMysqlBackupTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.MysqlMysqlBackup.MysqlMysqlBackupTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "validateBackupDetails", typeJson: "{\"fqn\":\"oci.mysqlMysqlBackup.MysqlMysqlBackupValidateBackupDetailsList\"}")]
        public virtual oci.MysqlMysqlBackup.MysqlMysqlBackupValidateBackupDetailsList ValidateBackupDetails
        {
            get => GetInstanceProperty<oci.MysqlMysqlBackup.MysqlMysqlBackupValidateBackupDetailsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "backupTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BackupTypeInput
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
        [JsiiProperty(name: "dbSystemIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DbSystemIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbSystemSnapshotSummaryInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.mysqlMysqlBackup.MysqlMysqlBackupDbSystemSnapshotSummary\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DbSystemSnapshotSummaryInput
        {
            get => GetInstanceProperty<object?>();
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

        [JsiiOptional]
        [JsiiProperty(name: "encryptDataInput", typeJson: "{\"fqn\":\"oci.mysqlMysqlBackup.MysqlMysqlBackupEncryptData\"}", isOptional: true)]
        public virtual oci.MysqlMysqlBackup.IMysqlMysqlBackupEncryptData? EncryptDataInput
        {
            get => GetInstanceProperty<oci.MysqlMysqlBackup.IMysqlMysqlBackupEncryptData?>();
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

        [JsiiOptional]
        [JsiiProperty(name: "retentionInDaysInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RetentionInDaysInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "softDeleteInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SoftDeleteInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceDetailsInput", typeJson: "{\"fqn\":\"oci.mysqlMysqlBackup.MysqlMysqlBackupSourceDetails\"}", isOptional: true)]
        public virtual oci.MysqlMysqlBackup.IMysqlMysqlBackupSourceDetails? SourceDetailsInput
        {
            get => GetInstanceProperty<oci.MysqlMysqlBackup.IMysqlMysqlBackupSourceDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.mysqlMysqlBackup.MysqlMysqlBackupTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "validateBackupDetailsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.mysqlMysqlBackup.MysqlMysqlBackupValidateBackupDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ValidateBackupDetailsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "validateTriggerInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ValidateTriggerInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "backupType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupType
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

        [JsiiProperty(name: "dbSystemId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbSystemId
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

        [JsiiProperty(name: "retentionInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RetentionInDays
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "softDelete", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SoftDelete
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "validateTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ValidateTrigger
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
