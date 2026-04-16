using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreAgentRuntimeEndpoint
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_agent_runtime_endpoint aws_bedrockagentcore_agent_runtime_endpoint}.</summary>
    [JsiiClass(nativeType: typeof(aws.BedrockagentcoreAgentRuntimeEndpoint.BedrockagentcoreAgentRuntimeEndpoint), fullyQualifiedName: "aws.bedrockagentcoreAgentRuntimeEndpoint.BedrockagentcoreAgentRuntimeEndpoint", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.bedrockagentcoreAgentRuntimeEndpoint.BedrockagentcoreAgentRuntimeEndpointConfig\"}}]")]
    public class BedrockagentcoreAgentRuntimeEndpoint : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_agent_runtime_endpoint aws_bedrockagentcore_agent_runtime_endpoint} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public BedrockagentcoreAgentRuntimeEndpoint(Constructs.Construct scope, string id, aws.BedrockagentcoreAgentRuntimeEndpoint.IBedrockagentcoreAgentRuntimeEndpointConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.BedrockagentcoreAgentRuntimeEndpoint.IBedrockagentcoreAgentRuntimeEndpointConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BedrockagentcoreAgentRuntimeEndpoint(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BedrockagentcoreAgentRuntimeEndpoint(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a BedrockagentcoreAgentRuntimeEndpoint resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the BedrockagentcoreAgentRuntimeEndpoint to import.</param>
        /// <param name="importFromId">The id of the existing BedrockagentcoreAgentRuntimeEndpoint that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the BedrockagentcoreAgentRuntimeEndpoint to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the BedrockagentcoreAgentRuntimeEndpoint to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_agent_runtime_endpoint#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing BedrockagentcoreAgentRuntimeEndpoint that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the BedrockagentcoreAgentRuntimeEndpoint to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.BedrockagentcoreAgentRuntimeEndpoint.BedrockagentcoreAgentRuntimeEndpoint), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.bedrockagentcoreAgentRuntimeEndpoint.BedrockagentcoreAgentRuntimeEndpointTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.BedrockagentcoreAgentRuntimeEndpoint.IBedrockagentcoreAgentRuntimeEndpointTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.BedrockagentcoreAgentRuntimeEndpoint.IBedrockagentcoreAgentRuntimeEndpointTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAgentRuntimeVersion")]
        public virtual void ResetAgentRuntimeVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
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
        = GetStaticProperty<string>(typeof(aws.BedrockagentcoreAgentRuntimeEndpoint.BedrockagentcoreAgentRuntimeEndpoint))!;

        [JsiiProperty(name: "agentRuntimeArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentRuntimeArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "agentRuntimeEndpointArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentRuntimeEndpointArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tagsAll", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap TagsAll
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.bedrockagentcoreAgentRuntimeEndpoint.BedrockagentcoreAgentRuntimeEndpointTimeoutsOutputReference\"}")]
        public virtual aws.BedrockagentcoreAgentRuntimeEndpoint.BedrockagentcoreAgentRuntimeEndpointTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.BedrockagentcoreAgentRuntimeEndpoint.BedrockagentcoreAgentRuntimeEndpointTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "agentRuntimeIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AgentRuntimeIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "agentRuntimeVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AgentRuntimeVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
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
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.bedrockagentcoreAgentRuntimeEndpoint.BedrockagentcoreAgentRuntimeEndpointTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "agentRuntimeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentRuntimeId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "agentRuntimeVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentRuntimeVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
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

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
