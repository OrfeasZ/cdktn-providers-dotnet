using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedAutonomousDatabasesRemoveDg
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_remove_dg oci_distributed_database_distributed_autonomous_databases_remove_dg}.</summary>
    [JsiiClass(nativeType: typeof(oci.DistributedDatabaseDistributedAutonomousDatabasesRemoveDg.DistributedDatabaseDistributedAutonomousDatabasesRemoveDg), fullyQualifiedName: "oci.distributedDatabaseDistributedAutonomousDatabasesRemoveDg.DistributedDatabaseDistributedAutonomousDatabasesRemoveDg", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabasesRemoveDg.DistributedDatabaseDistributedAutonomousDatabasesRemoveDgConfig\"}}]")]
    public class DistributedDatabaseDistributedAutonomousDatabasesRemoveDg : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_remove_dg oci_distributed_database_distributed_autonomous_databases_remove_dg} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DistributedDatabaseDistributedAutonomousDatabasesRemoveDg(Constructs.Construct scope, string id, oci.DistributedDatabaseDistributedAutonomousDatabasesRemoveDg.IDistributedDatabaseDistributedAutonomousDatabasesRemoveDgConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DistributedDatabaseDistributedAutonomousDatabasesRemoveDg.IDistributedDatabaseDistributedAutonomousDatabasesRemoveDgConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DistributedDatabaseDistributedAutonomousDatabasesRemoveDg(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DistributedDatabaseDistributedAutonomousDatabasesRemoveDg(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DistributedDatabaseDistributedAutonomousDatabasesRemoveDg resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DistributedDatabaseDistributedAutonomousDatabasesRemoveDg to import.</param>
        /// <param name="importFromId">The id of the existing DistributedDatabaseDistributedAutonomousDatabasesRemoveDg that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DistributedDatabaseDistributedAutonomousDatabasesRemoveDg to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DistributedDatabaseDistributedAutonomousDatabasesRemoveDg to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_remove_dg#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DistributedDatabaseDistributedAutonomousDatabasesRemoveDg that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DistributedDatabaseDistributedAutonomousDatabasesRemoveDg to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DistributedDatabaseDistributedAutonomousDatabasesRemoveDg.DistributedDatabaseDistributedAutonomousDatabasesRemoveDg), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedAutonomousDatabasesRemoveDg.IDistributedDatabaseDistributedAutonomousDatabasesRemoveDgRemoveDg" />)[]</param>
        [JsiiMethod(name: "putRemoveDg", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabasesRemoveDg.DistributedDatabaseDistributedAutonomousDatabasesRemoveDgRemoveDg\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRemoveDg(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DistributedDatabaseDistributedAutonomousDatabasesRemoveDg.IDistributedDatabaseDistributedAutonomousDatabasesRemoveDgRemoveDg[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DistributedDatabaseDistributedAutonomousDatabasesRemoveDg.IDistributedDatabaseDistributedAutonomousDatabasesRemoveDgRemoveDg).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DistributedDatabaseDistributedAutonomousDatabasesRemoveDg.IDistributedDatabaseDistributedAutonomousDatabasesRemoveDgRemoveDg).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabasesRemoveDg.DistributedDatabaseDistributedAutonomousDatabasesRemoveDgTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DistributedDatabaseDistributedAutonomousDatabasesRemoveDg.IDistributedDatabaseDistributedAutonomousDatabasesRemoveDgTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DistributedDatabaseDistributedAutonomousDatabasesRemoveDg.IDistributedDatabaseDistributedAutonomousDatabasesRemoveDgTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(oci.DistributedDatabaseDistributedAutonomousDatabasesRemoveDg.DistributedDatabaseDistributedAutonomousDatabasesRemoveDg))!;

        [JsiiProperty(name: "actionPending", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ActionPending
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "removeDg", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabasesRemoveDg.DistributedDatabaseDistributedAutonomousDatabasesRemoveDgRemoveDgList\"}")]
        public virtual oci.DistributedDatabaseDistributedAutonomousDatabasesRemoveDg.DistributedDatabaseDistributedAutonomousDatabasesRemoveDgRemoveDgList RemoveDg
        {
            get => GetInstanceProperty<oci.DistributedDatabaseDistributedAutonomousDatabasesRemoveDg.DistributedDatabaseDistributedAutonomousDatabasesRemoveDgRemoveDgList>()!;
        }

        [JsiiProperty(name: "retryToken", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RetryToken
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabasesRemoveDg.DistributedDatabaseDistributedAutonomousDatabasesRemoveDgTimeoutsOutputReference\"}")]
        public virtual oci.DistributedDatabaseDistributedAutonomousDatabasesRemoveDg.DistributedDatabaseDistributedAutonomousDatabasesRemoveDgTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DistributedDatabaseDistributedAutonomousDatabasesRemoveDg.DistributedDatabaseDistributedAutonomousDatabasesRemoveDgTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "workRequestId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkRequestId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "distributedAutonomousDatabaseIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DistributedAutonomousDatabaseIdInput
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedAutonomousDatabasesRemoveDg.IDistributedDatabaseDistributedAutonomousDatabasesRemoveDgRemoveDg" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "removeDgInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabasesRemoveDg.DistributedDatabaseDistributedAutonomousDatabasesRemoveDgRemoveDg\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RemoveDgInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.DistributedDatabaseDistributedAutonomousDatabasesRemoveDg.IDistributedDatabaseDistributedAutonomousDatabasesRemoveDgTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabasesRemoveDg.DistributedDatabaseDistributedAutonomousDatabasesRemoveDgTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "distributedAutonomousDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DistributedAutonomousDatabaseId
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
