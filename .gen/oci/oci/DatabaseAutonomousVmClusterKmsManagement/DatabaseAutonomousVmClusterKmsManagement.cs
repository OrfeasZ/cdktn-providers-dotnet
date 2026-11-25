using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousVmClusterKmsManagement
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/database_autonomous_vm_cluster_kms_management oci_database_autonomous_vm_cluster_kms_management}.</summary>
    [JsiiClass(nativeType: typeof(oci.DatabaseAutonomousVmClusterKmsManagement.DatabaseAutonomousVmClusterKmsManagement), fullyQualifiedName: "oci.databaseAutonomousVmClusterKmsManagement.DatabaseAutonomousVmClusterKmsManagement", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.databaseAutonomousVmClusterKmsManagement.DatabaseAutonomousVmClusterKmsManagementConfig\"}}]")]
    public class DatabaseAutonomousVmClusterKmsManagement : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/database_autonomous_vm_cluster_kms_management oci_database_autonomous_vm_cluster_kms_management} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DatabaseAutonomousVmClusterKmsManagement(Constructs.Construct scope, string id, oci.DatabaseAutonomousVmClusterKmsManagement.IDatabaseAutonomousVmClusterKmsManagementConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DatabaseAutonomousVmClusterKmsManagement.IDatabaseAutonomousVmClusterKmsManagementConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseAutonomousVmClusterKmsManagement(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseAutonomousVmClusterKmsManagement(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DatabaseAutonomousVmClusterKmsManagement resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DatabaseAutonomousVmClusterKmsManagement to import.</param>
        /// <param name="importFromId">The id of the existing DatabaseAutonomousVmClusterKmsManagement that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DatabaseAutonomousVmClusterKmsManagement to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DatabaseAutonomousVmClusterKmsManagement to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/database_autonomous_vm_cluster_kms_management#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DatabaseAutonomousVmClusterKmsManagement that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DatabaseAutonomousVmClusterKmsManagement to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DatabaseAutonomousVmClusterKmsManagement.DatabaseAutonomousVmClusterKmsManagement), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseAutonomousVmClusterKmsManagement.DatabaseAutonomousVmClusterKmsManagementTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DatabaseAutonomousVmClusterKmsManagement.IDatabaseAutonomousVmClusterKmsManagementTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseAutonomousVmClusterKmsManagement.IDatabaseAutonomousVmClusterKmsManagementTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsExclusive")]
        public virtual void ResetIsExclusive()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKeyStoreId")]
        public virtual void ResetKeyStoreId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThalesHsmPort")]
        public virtual void ResetThalesHsmPort()
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
        = GetStaticProperty<string>(typeof(oci.DatabaseAutonomousVmClusterKmsManagement.DatabaseAutonomousVmClusterKmsManagement))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseAutonomousVmClusterKmsManagement.DatabaseAutonomousVmClusterKmsManagementTimeoutsOutputReference\"}")]
        public virtual oci.DatabaseAutonomousVmClusterKmsManagement.DatabaseAutonomousVmClusterKmsManagementTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DatabaseAutonomousVmClusterKmsManagement.DatabaseAutonomousVmClusterKmsManagementTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autonomousVmClusterIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AutonomousVmClusterIdInput
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
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isExclusiveInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsExclusiveInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyManagementSystemInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyManagementSystemInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyStoreIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyStoreIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "thalesHsmPortInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ThalesHsmPortInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.DatabaseAutonomousVmClusterKmsManagement.IDatabaseAutonomousVmClusterKmsManagementTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.databaseAutonomousVmClusterKmsManagement.DatabaseAutonomousVmClusterKmsManagementTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "autonomousVmClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutonomousVmClusterId
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

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isExclusive", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsExclusive
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

        [JsiiProperty(name: "keyManagementSystem", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyManagementSystem
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "keyStoreId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyStoreId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "thalesHsmPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ThalesHsmPort
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
