using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsBedrockagentAgentVersions
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/data-sources/bedrockagent_agent_versions aws_bedrockagent_agent_versions}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsBedrockagentAgentVersions.DataAwsBedrockagentAgentVersions), fullyQualifiedName: "aws.dataAwsBedrockagentAgentVersions.DataAwsBedrockagentAgentVersions", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsBedrockagentAgentVersions.DataAwsBedrockagentAgentVersionsConfig\"}}]")]
    public class DataAwsBedrockagentAgentVersions : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/data-sources/bedrockagent_agent_versions aws_bedrockagent_agent_versions} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsBedrockagentAgentVersions(Constructs.Construct scope, string id, aws.DataAwsBedrockagentAgentVersions.IDataAwsBedrockagentAgentVersionsConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsBedrockagentAgentVersions.IDataAwsBedrockagentAgentVersionsConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsBedrockagentAgentVersions(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsBedrockagentAgentVersions(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAwsBedrockagentAgentVersions resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsBedrockagentAgentVersions to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsBedrockagentAgentVersions that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsBedrockagentAgentVersions to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsBedrockagentAgentVersions to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/data-sources/bedrockagent_agent_versions#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsBedrockagentAgentVersions that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsBedrockagentAgentVersions to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.DataAwsBedrockagentAgentVersions.DataAwsBedrockagentAgentVersions), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAgentVersionSummaries", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsBedrockagentAgentVersions.DataAwsBedrockagentAgentVersionsAgentVersionSummaries\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAgentVersionSummaries(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DataAwsBedrockagentAgentVersions.IDataAwsBedrockagentAgentVersionsAgentVersionSummaries[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DataAwsBedrockagentAgentVersions.IDataAwsBedrockagentAgentVersionsAgentVersionSummaries).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DataAwsBedrockagentAgentVersions.IDataAwsBedrockagentAgentVersionsAgentVersionSummaries).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAgentVersionSummaries")]
        public virtual void ResetAgentVersionSummaries()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
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
        = GetStaticProperty<string>(typeof(aws.DataAwsBedrockagentAgentVersions.DataAwsBedrockagentAgentVersions))!;

        [JsiiProperty(name: "agentVersionSummaries", typeJson: "{\"fqn\":\"aws.dataAwsBedrockagentAgentVersions.DataAwsBedrockagentAgentVersionsAgentVersionSummariesList\"}")]
        public virtual aws.DataAwsBedrockagentAgentVersions.DataAwsBedrockagentAgentVersionsAgentVersionSummariesList AgentVersionSummaries
        {
            get => GetInstanceProperty<aws.DataAwsBedrockagentAgentVersions.DataAwsBedrockagentAgentVersionsAgentVersionSummariesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "agentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AgentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "agentVersionSummariesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsBedrockagentAgentVersions.DataAwsBedrockagentAgentVersionsAgentVersionSummaries\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AgentVersionSummariesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "agentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentId
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
    }
}
