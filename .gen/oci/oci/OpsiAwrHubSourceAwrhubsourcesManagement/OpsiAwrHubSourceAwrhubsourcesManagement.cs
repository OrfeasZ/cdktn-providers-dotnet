using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpsiAwrHubSourceAwrhubsourcesManagement
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_awr_hub_source_awrhubsources_management oci_opsi_awr_hub_source_awrhubsources_management}.</summary>
    [JsiiClass(nativeType: typeof(oci.OpsiAwrHubSourceAwrhubsourcesManagement.OpsiAwrHubSourceAwrhubsourcesManagement), fullyQualifiedName: "oci.opsiAwrHubSourceAwrhubsourcesManagement.OpsiAwrHubSourceAwrhubsourcesManagement", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.opsiAwrHubSourceAwrhubsourcesManagement.OpsiAwrHubSourceAwrhubsourcesManagementConfig\"}}]")]
    public class OpsiAwrHubSourceAwrhubsourcesManagement : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_awr_hub_source_awrhubsources_management oci_opsi_awr_hub_source_awrhubsources_management} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public OpsiAwrHubSourceAwrhubsourcesManagement(Constructs.Construct scope, string id, oci.OpsiAwrHubSourceAwrhubsourcesManagement.IOpsiAwrHubSourceAwrhubsourcesManagementConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.OpsiAwrHubSourceAwrhubsourcesManagement.IOpsiAwrHubSourceAwrhubsourcesManagementConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpsiAwrHubSourceAwrhubsourcesManagement(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpsiAwrHubSourceAwrhubsourcesManagement(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a OpsiAwrHubSourceAwrhubsourcesManagement resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the OpsiAwrHubSourceAwrhubsourcesManagement to import.</param>
        /// <param name="importFromId">The id of the existing OpsiAwrHubSourceAwrhubsourcesManagement that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the OpsiAwrHubSourceAwrhubsourcesManagement to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the OpsiAwrHubSourceAwrhubsourcesManagement to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_awr_hub_source_awrhubsources_management#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing OpsiAwrHubSourceAwrhubsourcesManagement that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the OpsiAwrHubSourceAwrhubsourcesManagement to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.OpsiAwrHubSourceAwrhubsourcesManagement.OpsiAwrHubSourceAwrhubsourcesManagement), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.opsiAwrHubSourceAwrhubsourcesManagement.OpsiAwrHubSourceAwrhubsourcesManagementTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.OpsiAwrHubSourceAwrhubsourcesManagement.IOpsiAwrHubSourceAwrhubsourcesManagementTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OpsiAwrHubSourceAwrhubsourcesManagement.IOpsiAwrHubSourceAwrhubsourcesManagementTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(oci.OpsiAwrHubSourceAwrhubsourcesManagement.OpsiAwrHubSourceAwrhubsourcesManagement))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.opsiAwrHubSourceAwrhubsourcesManagement.OpsiAwrHubSourceAwrhubsourcesManagementTimeoutsOutputReference\"}")]
        public virtual oci.OpsiAwrHubSourceAwrhubsourcesManagement.OpsiAwrHubSourceAwrhubsourcesManagementTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.OpsiAwrHubSourceAwrhubsourcesManagement.OpsiAwrHubSourceAwrhubsourcesManagementTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "awrHubSourceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AwrHubSourceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableAwrhubsourceInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableAwrhubsourceInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.opsiAwrHubSourceAwrhubsourcesManagement.OpsiAwrHubSourceAwrhubsourcesManagementTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "awrHubSourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AwrHubSourceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enableAwrhubsource", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object EnableAwrhubsource
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

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
