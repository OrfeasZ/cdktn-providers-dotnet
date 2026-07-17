using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsWorkitemtrackingprocessProcesses
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/workitemtrackingprocess_processes azuredevops_workitemtrackingprocess_processes}.</summary>
    [JsiiClass(nativeType: typeof(azuredevops.DataAzuredevopsWorkitemtrackingprocessProcesses.DataAzuredevopsWorkitemtrackingprocessProcesses), fullyQualifiedName: "azuredevops.dataAzuredevopsWorkitemtrackingprocessProcesses.DataAzuredevopsWorkitemtrackingprocessProcesses", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"azuredevops.dataAzuredevopsWorkitemtrackingprocessProcesses.DataAzuredevopsWorkitemtrackingprocessProcessesConfig\"}}]")]
    public class DataAzuredevopsWorkitemtrackingprocessProcesses : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/workitemtrackingprocess_processes azuredevops_workitemtrackingprocess_processes} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzuredevopsWorkitemtrackingprocessProcesses(Constructs.Construct scope, string id, azuredevops.DataAzuredevopsWorkitemtrackingprocessProcesses.IDataAzuredevopsWorkitemtrackingprocessProcessesConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azuredevops.DataAzuredevopsWorkitemtrackingprocessProcesses.IDataAzuredevopsWorkitemtrackingprocessProcessesConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzuredevopsWorkitemtrackingprocessProcesses(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzuredevopsWorkitemtrackingprocessProcesses(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAzuredevopsWorkitemtrackingprocessProcesses resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzuredevopsWorkitemtrackingprocessProcesses to import.</param>
        /// <param name="importFromId">The id of the existing DataAzuredevopsWorkitemtrackingprocessProcesses that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzuredevopsWorkitemtrackingprocessProcesses to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzuredevopsWorkitemtrackingprocessProcesses to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/workitemtrackingprocess_processes#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzuredevopsWorkitemtrackingprocessProcesses that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzuredevopsWorkitemtrackingprocessProcesses to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azuredevops.DataAzuredevopsWorkitemtrackingprocessProcesses.DataAzuredevopsWorkitemtrackingprocessProcesses), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.dataAzuredevopsWorkitemtrackingprocessProcesses.DataAzuredevopsWorkitemtrackingprocessProcessesTimeouts\"}}]")]
        public virtual void PutTimeouts(azuredevops.DataAzuredevopsWorkitemtrackingprocessProcesses.IDataAzuredevopsWorkitemtrackingprocessProcessesTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.DataAzuredevopsWorkitemtrackingprocessProcesses.IDataAzuredevopsWorkitemtrackingprocessProcessesTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetExpand")]
        public virtual void ResetExpand()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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
        = GetStaticProperty<string>(typeof(azuredevops.DataAzuredevopsWorkitemtrackingprocessProcesses.DataAzuredevopsWorkitemtrackingprocessProcesses))!;

        [JsiiProperty(name: "processes", typeJson: "{\"fqn\":\"azuredevops.dataAzuredevopsWorkitemtrackingprocessProcesses.DataAzuredevopsWorkitemtrackingprocessProcessesProcessesList\"}")]
        public virtual azuredevops.DataAzuredevopsWorkitemtrackingprocessProcesses.DataAzuredevopsWorkitemtrackingprocessProcessesProcessesList Processes
        {
            get => GetInstanceProperty<azuredevops.DataAzuredevopsWorkitemtrackingprocessProcesses.DataAzuredevopsWorkitemtrackingprocessProcessesProcessesList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuredevops.dataAzuredevopsWorkitemtrackingprocessProcesses.DataAzuredevopsWorkitemtrackingprocessProcessesTimeoutsOutputReference\"}")]
        public virtual azuredevops.DataAzuredevopsWorkitemtrackingprocessProcesses.DataAzuredevopsWorkitemtrackingprocessProcessesTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azuredevops.DataAzuredevopsWorkitemtrackingprocessProcesses.DataAzuredevopsWorkitemtrackingprocessProcessesTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "expandInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExpandInput
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azuredevops.DataAzuredevopsWorkitemtrackingprocessProcesses.IDataAzuredevopsWorkitemtrackingprocessProcessesTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azuredevops.dataAzuredevopsWorkitemtrackingprocessProcesses.DataAzuredevopsWorkitemtrackingprocessProcessesTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "expand", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Expand
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
