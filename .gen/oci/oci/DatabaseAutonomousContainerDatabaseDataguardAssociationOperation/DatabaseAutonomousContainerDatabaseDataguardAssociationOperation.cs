using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousContainerDatabaseDataguardAssociationOperation
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_dataguard_association_operation oci_database_autonomous_container_database_dataguard_association_operation}.</summary>
    [JsiiClass(nativeType: typeof(oci.DatabaseAutonomousContainerDatabaseDataguardAssociationOperation.DatabaseAutonomousContainerDatabaseDataguardAssociationOperation), fullyQualifiedName: "oci.databaseAutonomousContainerDatabaseDataguardAssociationOperation.DatabaseAutonomousContainerDatabaseDataguardAssociationOperation", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.databaseAutonomousContainerDatabaseDataguardAssociationOperation.DatabaseAutonomousContainerDatabaseDataguardAssociationOperationConfig\"}}]")]
    public class DatabaseAutonomousContainerDatabaseDataguardAssociationOperation : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_dataguard_association_operation oci_database_autonomous_container_database_dataguard_association_operation} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DatabaseAutonomousContainerDatabaseDataguardAssociationOperation(Constructs.Construct scope, string id, oci.DatabaseAutonomousContainerDatabaseDataguardAssociationOperation.IDatabaseAutonomousContainerDatabaseDataguardAssociationOperationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DatabaseAutonomousContainerDatabaseDataguardAssociationOperation.IDatabaseAutonomousContainerDatabaseDataguardAssociationOperationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseAutonomousContainerDatabaseDataguardAssociationOperation(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseAutonomousContainerDatabaseDataguardAssociationOperation(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DatabaseAutonomousContainerDatabaseDataguardAssociationOperation resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DatabaseAutonomousContainerDatabaseDataguardAssociationOperation to import.</param>
        /// <param name="importFromId">The id of the existing DatabaseAutonomousContainerDatabaseDataguardAssociationOperation that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DatabaseAutonomousContainerDatabaseDataguardAssociationOperation to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DatabaseAutonomousContainerDatabaseDataguardAssociationOperation to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_dataguard_association_operation#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DatabaseAutonomousContainerDatabaseDataguardAssociationOperation that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DatabaseAutonomousContainerDatabaseDataguardAssociationOperation to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DatabaseAutonomousContainerDatabaseDataguardAssociationOperation.DatabaseAutonomousContainerDatabaseDataguardAssociationOperation), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseAutonomousContainerDatabaseDataguardAssociationOperation.DatabaseAutonomousContainerDatabaseDataguardAssociationOperationTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DatabaseAutonomousContainerDatabaseDataguardAssociationOperation.IDatabaseAutonomousContainerDatabaseDataguardAssociationOperationTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseAutonomousContainerDatabaseDataguardAssociationOperation.IDatabaseAutonomousContainerDatabaseDataguardAssociationOperationTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(oci.DatabaseAutonomousContainerDatabaseDataguardAssociationOperation.DatabaseAutonomousContainerDatabaseDataguardAssociationOperation))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseAutonomousContainerDatabaseDataguardAssociationOperation.DatabaseAutonomousContainerDatabaseDataguardAssociationOperationTimeoutsOutputReference\"}")]
        public virtual oci.DatabaseAutonomousContainerDatabaseDataguardAssociationOperation.DatabaseAutonomousContainerDatabaseDataguardAssociationOperationTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DatabaseAutonomousContainerDatabaseDataguardAssociationOperation.DatabaseAutonomousContainerDatabaseDataguardAssociationOperationTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autonomousContainerDatabaseDataguardAssociationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AutonomousContainerDatabaseDataguardAssociationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autonomousContainerDatabaseIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AutonomousContainerDatabaseIdInput
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
        [JsiiProperty(name: "operationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OperationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.databaseAutonomousContainerDatabaseDataguardAssociationOperation.DatabaseAutonomousContainerDatabaseDataguardAssociationOperationTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "autonomousContainerDatabaseDataguardAssociationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutonomousContainerDatabaseDataguardAssociationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "autonomousContainerDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutonomousContainerDatabaseId
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

        [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Operation
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
