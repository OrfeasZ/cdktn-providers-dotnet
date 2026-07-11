using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsAgentPools
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/agent_pools azuredevops_agent_pools}.</summary>
    [JsiiClass(nativeType: typeof(azuredevops.DataAzuredevopsAgentPools.DataAzuredevopsAgentPools), fullyQualifiedName: "azuredevops.dataAzuredevopsAgentPools.DataAzuredevopsAgentPools", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"azuredevops.dataAzuredevopsAgentPools.DataAzuredevopsAgentPoolsConfig\"}}]")]
    public class DataAzuredevopsAgentPools : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/agent_pools azuredevops_agent_pools} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzuredevopsAgentPools(Constructs.Construct scope, string id, azuredevops.DataAzuredevopsAgentPools.IDataAzuredevopsAgentPoolsConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azuredevops.DataAzuredevopsAgentPools.IDataAzuredevopsAgentPoolsConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzuredevopsAgentPools(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzuredevopsAgentPools(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAzuredevopsAgentPools resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzuredevopsAgentPools to import.</param>
        /// <param name="importFromId">The id of the existing DataAzuredevopsAgentPools that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzuredevopsAgentPools to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzuredevopsAgentPools to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/agent_pools#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzuredevopsAgentPools that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzuredevopsAgentPools to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azuredevops.DataAzuredevopsAgentPools.DataAzuredevopsAgentPools), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.dataAzuredevopsAgentPools.DataAzuredevopsAgentPoolsTimeouts\"}}]")]
        public virtual void PutTimeouts(azuredevops.DataAzuredevopsAgentPools.IDataAzuredevopsAgentPoolsTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.DataAzuredevopsAgentPools.IDataAzuredevopsAgentPoolsTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azuredevops.DataAzuredevopsAgentPools.DataAzuredevopsAgentPools))!;

        [JsiiProperty(name: "agentPools", typeJson: "{\"fqn\":\"azuredevops.dataAzuredevopsAgentPools.DataAzuredevopsAgentPoolsAgentPoolsList\"}")]
        public virtual azuredevops.DataAzuredevopsAgentPools.DataAzuredevopsAgentPoolsAgentPoolsList AgentPools
        {
            get => GetInstanceProperty<azuredevops.DataAzuredevopsAgentPools.DataAzuredevopsAgentPoolsAgentPoolsList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuredevops.dataAzuredevopsAgentPools.DataAzuredevopsAgentPoolsTimeoutsOutputReference\"}")]
        public virtual azuredevops.DataAzuredevopsAgentPools.DataAzuredevopsAgentPoolsTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azuredevops.DataAzuredevopsAgentPools.DataAzuredevopsAgentPoolsTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azuredevops.DataAzuredevopsAgentPools.IDataAzuredevopsAgentPoolsTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azuredevops.dataAzuredevopsAgentPools.DataAzuredevopsAgentPoolsTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
