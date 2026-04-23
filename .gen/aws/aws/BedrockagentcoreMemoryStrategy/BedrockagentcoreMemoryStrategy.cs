using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreMemoryStrategy
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_memory_strategy aws_bedrockagentcore_memory_strategy}.</summary>
    [JsiiClass(nativeType: typeof(aws.BedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategy), fullyQualifiedName: "aws.bedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategy", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.bedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyConfig\"}}]")]
    public class BedrockagentcoreMemoryStrategy : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_memory_strategy aws_bedrockagentcore_memory_strategy} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public BedrockagentcoreMemoryStrategy(Constructs.Construct scope, string id, aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BedrockagentcoreMemoryStrategy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BedrockagentcoreMemoryStrategy(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a BedrockagentcoreMemoryStrategy resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the BedrockagentcoreMemoryStrategy to import.</param>
        /// <param name="importFromId">The id of the existing BedrockagentcoreMemoryStrategy that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the BedrockagentcoreMemoryStrategy to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the BedrockagentcoreMemoryStrategy to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_memory_strategy#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing BedrockagentcoreMemoryStrategy that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the BedrockagentcoreMemoryStrategy to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.BedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategy), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyConfiguration\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutConfiguration(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyConfiguration[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyConfiguration).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyConfiguration).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.bedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.BedrockagentcoreMemoryStrategy.IBedrockagentcoreMemoryStrategyTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConfiguration")]
        public virtual void ResetConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMemoryExecutionRoleArn")]
        public virtual void ResetMemoryExecutionRoleArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
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
        = GetStaticProperty<string>(typeof(aws.BedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategy))!;

        [JsiiProperty(name: "configuration", typeJson: "{\"fqn\":\"aws.bedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyConfigurationList\"}")]
        public virtual aws.BedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyConfigurationList Configuration
        {
            get => GetInstanceProperty<aws.BedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyConfigurationList>()!;
        }

        [JsiiProperty(name: "memoryStrategyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MemoryStrategyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.bedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyTimeoutsOutputReference\"}")]
        public virtual aws.BedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.BedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "configurationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ConfigurationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "memoryExecutionRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MemoryExecutionRoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "memoryIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MemoryIdInput
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
        [JsiiProperty(name: "namespacesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? NamespacesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.bedrockagentcoreMemoryStrategy.BedrockagentcoreMemoryStrategyTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "memoryExecutionRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MemoryExecutionRoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "memoryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MemoryId
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

        [JsiiProperty(name: "namespaces", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Namespaces
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
