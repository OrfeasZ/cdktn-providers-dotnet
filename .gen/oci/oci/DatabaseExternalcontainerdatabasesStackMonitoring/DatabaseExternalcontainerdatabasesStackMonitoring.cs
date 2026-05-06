using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseExternalcontainerdatabasesStackMonitoring
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_externalcontainerdatabases_stack_monitoring oci_database_externalcontainerdatabases_stack_monitoring}.</summary>
    [JsiiClass(nativeType: typeof(oci.DatabaseExternalcontainerdatabasesStackMonitoring.DatabaseExternalcontainerdatabasesStackMonitoring), fullyQualifiedName: "oci.databaseExternalcontainerdatabasesStackMonitoring.DatabaseExternalcontainerdatabasesStackMonitoring", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.databaseExternalcontainerdatabasesStackMonitoring.DatabaseExternalcontainerdatabasesStackMonitoringConfig\"}}]")]
    public class DatabaseExternalcontainerdatabasesStackMonitoring : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_externalcontainerdatabases_stack_monitoring oci_database_externalcontainerdatabases_stack_monitoring} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DatabaseExternalcontainerdatabasesStackMonitoring(Constructs.Construct scope, string id, oci.DatabaseExternalcontainerdatabasesStackMonitoring.IDatabaseExternalcontainerdatabasesStackMonitoringConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DatabaseExternalcontainerdatabasesStackMonitoring.IDatabaseExternalcontainerdatabasesStackMonitoringConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseExternalcontainerdatabasesStackMonitoring(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseExternalcontainerdatabasesStackMonitoring(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DatabaseExternalcontainerdatabasesStackMonitoring resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DatabaseExternalcontainerdatabasesStackMonitoring to import.</param>
        /// <param name="importFromId">The id of the existing DatabaseExternalcontainerdatabasesStackMonitoring that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DatabaseExternalcontainerdatabasesStackMonitoring to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DatabaseExternalcontainerdatabasesStackMonitoring to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_externalcontainerdatabases_stack_monitoring#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DatabaseExternalcontainerdatabasesStackMonitoring that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DatabaseExternalcontainerdatabasesStackMonitoring to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DatabaseExternalcontainerdatabasesStackMonitoring.DatabaseExternalcontainerdatabasesStackMonitoring), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseExternalcontainerdatabasesStackMonitoring.DatabaseExternalcontainerdatabasesStackMonitoringTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DatabaseExternalcontainerdatabasesStackMonitoring.IDatabaseExternalcontainerdatabasesStackMonitoringTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseExternalcontainerdatabasesStackMonitoring.IDatabaseExternalcontainerdatabasesStackMonitoringTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(oci.DatabaseExternalcontainerdatabasesStackMonitoring.DatabaseExternalcontainerdatabasesStackMonitoring))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseExternalcontainerdatabasesStackMonitoring.DatabaseExternalcontainerdatabasesStackMonitoringTimeoutsOutputReference\"}")]
        public virtual oci.DatabaseExternalcontainerdatabasesStackMonitoring.DatabaseExternalcontainerdatabasesStackMonitoringTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DatabaseExternalcontainerdatabasesStackMonitoring.DatabaseExternalcontainerdatabasesStackMonitoringTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableStackMonitoringInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableStackMonitoringInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "externalContainerDatabaseIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExternalContainerDatabaseIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "externalDatabaseConnectorIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExternalDatabaseConnectorIdInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.databaseExternalcontainerdatabasesStackMonitoring.DatabaseExternalcontainerdatabasesStackMonitoringTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "enableStackMonitoring", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object EnableStackMonitoring
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "externalContainerDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalContainerDatabaseId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "externalDatabaseConnectorId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalDatabaseConnectorId
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
