using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciMysqlDbSystemMaintenanceEvents
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/data-sources/mysql_db_system_maintenance_events oci_mysql_db_system_maintenance_events}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciMysqlDbSystemMaintenanceEvents.DataOciMysqlDbSystemMaintenanceEvents), fullyQualifiedName: "oci.dataOciMysqlDbSystemMaintenanceEvents.DataOciMysqlDbSystemMaintenanceEvents", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciMysqlDbSystemMaintenanceEvents.DataOciMysqlDbSystemMaintenanceEventsConfig\"}}]")]
    public class DataOciMysqlDbSystemMaintenanceEvents : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/data-sources/mysql_db_system_maintenance_events oci_mysql_db_system_maintenance_events} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciMysqlDbSystemMaintenanceEvents(Constructs.Construct scope, string id, oci.DataOciMysqlDbSystemMaintenanceEvents.IDataOciMysqlDbSystemMaintenanceEventsConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciMysqlDbSystemMaintenanceEvents.IDataOciMysqlDbSystemMaintenanceEventsConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMysqlDbSystemMaintenanceEvents(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMysqlDbSystemMaintenanceEvents(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciMysqlDbSystemMaintenanceEvents resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciMysqlDbSystemMaintenanceEvents to import.</param>
        /// <param name="importFromId">The id of the existing DataOciMysqlDbSystemMaintenanceEvents that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciMysqlDbSystemMaintenanceEvents to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciMysqlDbSystemMaintenanceEvents to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/data-sources/mysql_db_system_maintenance_events#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciMysqlDbSystemMaintenanceEvents that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciMysqlDbSystemMaintenanceEvents to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciMysqlDbSystemMaintenanceEvents.DataOciMysqlDbSystemMaintenanceEvents), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciMysqlDbSystemMaintenanceEvents.IDataOciMysqlDbSystemMaintenanceEventsFilter" />)[]</param>
        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciMysqlDbSystemMaintenanceEvents.DataOciMysqlDbSystemMaintenanceEventsFilter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFilter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataOciMysqlDbSystemMaintenanceEvents.IDataOciMysqlDbSystemMaintenanceEventsFilter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciMysqlDbSystemMaintenanceEvents.IDataOciMysqlDbSystemMaintenanceEventsFilter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciMysqlDbSystemMaintenanceEvents.IDataOciMysqlDbSystemMaintenanceEventsFilter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
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

        [JsiiMethod(name: "resetMaintenanceAction")]
        public virtual void ResetMaintenanceAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaintenanceStatus")]
        public virtual void ResetMaintenanceStatus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaintenanceType")]
        public virtual void ResetMaintenanceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMysqlVersionAfterMaintenance")]
        public virtual void ResetMysqlVersionAfterMaintenance()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMysqlVersionBeforeMaintenance")]
        public virtual void ResetMysqlVersionBeforeMaintenance()
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
        = GetStaticProperty<string>(typeof(oci.DataOciMysqlDbSystemMaintenanceEvents.DataOciMysqlDbSystemMaintenanceEvents))!;

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"oci.dataOciMysqlDbSystemMaintenanceEvents.DataOciMysqlDbSystemMaintenanceEventsFilterList\"}")]
        public virtual oci.DataOciMysqlDbSystemMaintenanceEvents.DataOciMysqlDbSystemMaintenanceEventsFilterList Filter
        {
            get => GetInstanceProperty<oci.DataOciMysqlDbSystemMaintenanceEvents.DataOciMysqlDbSystemMaintenanceEventsFilterList>()!;
        }

        [JsiiProperty(name: "maintenanceEvents", typeJson: "{\"fqn\":\"oci.dataOciMysqlDbSystemMaintenanceEvents.DataOciMysqlDbSystemMaintenanceEventsMaintenanceEventsList\"}")]
        public virtual oci.DataOciMysqlDbSystemMaintenanceEvents.DataOciMysqlDbSystemMaintenanceEventsMaintenanceEventsList MaintenanceEvents
        {
            get => GetInstanceProperty<oci.DataOciMysqlDbSystemMaintenanceEvents.DataOciMysqlDbSystemMaintenanceEventsMaintenanceEventsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbSystemIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DbSystemIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciMysqlDbSystemMaintenanceEvents.IDataOciMysqlDbSystemMaintenanceEventsFilter" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciMysqlDbSystemMaintenanceEvents.DataOciMysqlDbSystemMaintenanceEventsFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        [JsiiProperty(name: "maintenanceActionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaintenanceActionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maintenanceStatusInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaintenanceStatusInput
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
        [JsiiProperty(name: "mysqlVersionAfterMaintenanceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MysqlVersionAfterMaintenanceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mysqlVersionBeforeMaintenanceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MysqlVersionBeforeMaintenanceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "dbSystemId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbSystemId
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

        [JsiiProperty(name: "maintenanceAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaintenanceAction
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maintenanceStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaintenanceStatus
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

        [JsiiProperty(name: "mysqlVersionAfterMaintenance", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MysqlVersionAfterMaintenance
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mysqlVersionBeforeMaintenance", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MysqlVersionBeforeMaintenance
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
