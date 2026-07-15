using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataccMaintenanceExecutions
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/data-sources/datacc_maintenance_executions oci_datacc_maintenance_executions}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDataccMaintenanceExecutions.DataOciDataccMaintenanceExecutions), fullyQualifiedName: "oci.dataOciDataccMaintenanceExecutions.DataOciDataccMaintenanceExecutions", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDataccMaintenanceExecutions.DataOciDataccMaintenanceExecutionsConfig\"}}]")]
    public class DataOciDataccMaintenanceExecutions : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/data-sources/datacc_maintenance_executions oci_datacc_maintenance_executions} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDataccMaintenanceExecutions(Constructs.Construct scope, string id, oci.DataOciDataccMaintenanceExecutions.IDataOciDataccMaintenanceExecutionsConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDataccMaintenanceExecutions.IDataOciDataccMaintenanceExecutionsConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataccMaintenanceExecutions(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataccMaintenanceExecutions(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDataccMaintenanceExecutions resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDataccMaintenanceExecutions to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDataccMaintenanceExecutions that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDataccMaintenanceExecutions to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDataccMaintenanceExecutions to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/data-sources/datacc_maintenance_executions#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDataccMaintenanceExecutions that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDataccMaintenanceExecutions to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDataccMaintenanceExecutions.DataOciDataccMaintenanceExecutions), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciDataccMaintenanceExecutions.IDataOciDataccMaintenanceExecutionsFilter" />)[]</param>
        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDataccMaintenanceExecutions.DataOciDataccMaintenanceExecutionsFilter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFilter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataOciDataccMaintenanceExecutions.IDataOciDataccMaintenanceExecutionsFilter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciDataccMaintenanceExecutions.IDataOciDataccMaintenanceExecutionsFilter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciDataccMaintenanceExecutions.IDataOciDataccMaintenanceExecutionsFilter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInfrastructureId")]
        public virtual void ResetInfrastructureId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaintenanceRunId")]
        public virtual void ResetMaintenanceRunId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaintenanceSubtype")]
        public virtual void ResetMaintenanceSubtype()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaintenanceType")]
        public virtual void ResetMaintenanceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetState")]
        public virtual void ResetState()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetResourceType")]
        public virtual void ResetTargetResourceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeAcceptedGreaterThanOrEqualTo")]
        public virtual void ResetTimeAcceptedGreaterThanOrEqualTo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeAcceptedLessThanOrEqualTo")]
        public virtual void ResetTimeAcceptedLessThanOrEqualTo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetType")]
        public virtual void ResetType()
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
        = GetStaticProperty<string>(typeof(oci.DataOciDataccMaintenanceExecutions.DataOciDataccMaintenanceExecutions))!;

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"oci.dataOciDataccMaintenanceExecutions.DataOciDataccMaintenanceExecutionsFilterList\"}")]
        public virtual oci.DataOciDataccMaintenanceExecutions.DataOciDataccMaintenanceExecutionsFilterList Filter
        {
            get => GetInstanceProperty<oci.DataOciDataccMaintenanceExecutions.DataOciDataccMaintenanceExecutionsFilterList>()!;
        }

        [JsiiProperty(name: "maintenanceExecutionCollection", typeJson: "{\"fqn\":\"oci.dataOciDataccMaintenanceExecutions.DataOciDataccMaintenanceExecutionsMaintenanceExecutionCollectionList\"}")]
        public virtual oci.DataOciDataccMaintenanceExecutions.DataOciDataccMaintenanceExecutionsMaintenanceExecutionCollectionList MaintenanceExecutionCollection
        {
            get => GetInstanceProperty<oci.DataOciDataccMaintenanceExecutions.DataOciDataccMaintenanceExecutionsMaintenanceExecutionCollectionList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciDataccMaintenanceExecutions.IDataOciDataccMaintenanceExecutionsFilter" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDataccMaintenanceExecutions.DataOciDataccMaintenanceExecutionsFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FilterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "infrastructureIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InfrastructureIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maintenanceRunIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaintenanceRunIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maintenanceSubtypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaintenanceSubtypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maintenanceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaintenanceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetResourceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetResourceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeAcceptedGreaterThanOrEqualToInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeAcceptedGreaterThanOrEqualToInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeAcceptedLessThanOrEqualToInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeAcceptedLessThanOrEqualToInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
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

        [JsiiProperty(name: "infrastructureId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InfrastructureId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maintenanceRunId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaintenanceRunId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maintenanceSubtype", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaintenanceSubtype
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maintenanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaintenanceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetResourceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeAcceptedGreaterThanOrEqualTo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeAcceptedGreaterThanOrEqualTo
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeAcceptedLessThanOrEqualTo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeAcceptedLessThanOrEqualTo
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
