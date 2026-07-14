using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LogAnalyticsWorkspaceTableCustomLog
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/log_analytics_workspace_table_custom_log azurerm_log_analytics_workspace_table_custom_log}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.LogAnalyticsWorkspaceTableCustomLog.LogAnalyticsWorkspaceTableCustomLog), fullyQualifiedName: "azurerm.logAnalyticsWorkspaceTableCustomLog.LogAnalyticsWorkspaceTableCustomLog", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.logAnalyticsWorkspaceTableCustomLog.LogAnalyticsWorkspaceTableCustomLogConfig\"}}]")]
    public class LogAnalyticsWorkspaceTableCustomLog : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/log_analytics_workspace_table_custom_log azurerm_log_analytics_workspace_table_custom_log} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LogAnalyticsWorkspaceTableCustomLog(Constructs.Construct scope, string id, azurerm.LogAnalyticsWorkspaceTableCustomLog.ILogAnalyticsWorkspaceTableCustomLogConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.LogAnalyticsWorkspaceTableCustomLog.ILogAnalyticsWorkspaceTableCustomLogConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LogAnalyticsWorkspaceTableCustomLog(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LogAnalyticsWorkspaceTableCustomLog(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a LogAnalyticsWorkspaceTableCustomLog resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the LogAnalyticsWorkspaceTableCustomLog to import.</param>
        /// <param name="importFromId">The id of the existing LogAnalyticsWorkspaceTableCustomLog that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the LogAnalyticsWorkspaceTableCustomLog to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the LogAnalyticsWorkspaceTableCustomLog to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/log_analytics_workspace_table_custom_log#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing LogAnalyticsWorkspaceTableCustomLog that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the LogAnalyticsWorkspaceTableCustomLog to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.LogAnalyticsWorkspaceTableCustomLog.LogAnalyticsWorkspaceTableCustomLog), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.LogAnalyticsWorkspaceTableCustomLog.ILogAnalyticsWorkspaceTableCustomLogColumn" />)[]</param>
        [JsiiMethod(name: "putColumn", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.logAnalyticsWorkspaceTableCustomLog.LogAnalyticsWorkspaceTableCustomLogColumn\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutColumn(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.LogAnalyticsWorkspaceTableCustomLog.ILogAnalyticsWorkspaceTableCustomLogColumn[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.LogAnalyticsWorkspaceTableCustomLog.ILogAnalyticsWorkspaceTableCustomLogColumn).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.LogAnalyticsWorkspaceTableCustomLog.ILogAnalyticsWorkspaceTableCustomLogColumn).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.logAnalyticsWorkspaceTableCustomLog.LogAnalyticsWorkspaceTableCustomLogTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.LogAnalyticsWorkspaceTableCustomLog.ILogAnalyticsWorkspaceTableCustomLogTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LogAnalyticsWorkspaceTableCustomLog.ILogAnalyticsWorkspaceTableCustomLogTimeouts)}, new object[]{@value});
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

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlan")]
        public virtual void ResetPlan()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetentionInDays")]
        public virtual void ResetRetentionInDays()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTotalRetentionInDays")]
        public virtual void ResetTotalRetentionInDays()
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
        = GetStaticProperty<string>(typeof(azurerm.LogAnalyticsWorkspaceTableCustomLog.LogAnalyticsWorkspaceTableCustomLog))!;

        [JsiiProperty(name: "column", typeJson: "{\"fqn\":\"azurerm.logAnalyticsWorkspaceTableCustomLog.LogAnalyticsWorkspaceTableCustomLogColumnList\"}")]
        public virtual azurerm.LogAnalyticsWorkspaceTableCustomLog.LogAnalyticsWorkspaceTableCustomLogColumnList Column
        {
            get => GetInstanceProperty<azurerm.LogAnalyticsWorkspaceTableCustomLog.LogAnalyticsWorkspaceTableCustomLogColumnList>()!;
        }

        [JsiiProperty(name: "solutions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Solutions
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "standardColumn", typeJson: "{\"fqn\":\"azurerm.logAnalyticsWorkspaceTableCustomLog.LogAnalyticsWorkspaceTableCustomLogStandardColumnList\"}")]
        public virtual azurerm.LogAnalyticsWorkspaceTableCustomLog.LogAnalyticsWorkspaceTableCustomLogStandardColumnList StandardColumn
        {
            get => GetInstanceProperty<azurerm.LogAnalyticsWorkspaceTableCustomLog.LogAnalyticsWorkspaceTableCustomLogStandardColumnList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.logAnalyticsWorkspaceTableCustomLog.LogAnalyticsWorkspaceTableCustomLogTimeoutsOutputReference\"}")]
        public virtual azurerm.LogAnalyticsWorkspaceTableCustomLog.LogAnalyticsWorkspaceTableCustomLogTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.LogAnalyticsWorkspaceTableCustomLog.LogAnalyticsWorkspaceTableCustomLogTimeoutsOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.LogAnalyticsWorkspaceTableCustomLog.ILogAnalyticsWorkspaceTableCustomLogColumn" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "columnInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.logAnalyticsWorkspaceTableCustomLog.LogAnalyticsWorkspaceTableCustomLogColumn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ColumnInput
        {
            get => GetInstanceProperty<object?>();
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
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "planInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PlanInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retentionInDaysInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RetentionInDaysInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.LogAnalyticsWorkspaceTableCustomLog.ILogAnalyticsWorkspaceTableCustomLogTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.logAnalyticsWorkspaceTableCustomLog.LogAnalyticsWorkspaceTableCustomLogTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "totalRetentionInDaysInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TotalRetentionInDaysInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workspaceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WorkspaceIdInput
        {
            get => GetInstanceProperty<string?>();
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

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "plan", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Plan
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

        [JsiiProperty(name: "totalRetentionInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalRetentionInDays
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "workspaceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkspaceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
