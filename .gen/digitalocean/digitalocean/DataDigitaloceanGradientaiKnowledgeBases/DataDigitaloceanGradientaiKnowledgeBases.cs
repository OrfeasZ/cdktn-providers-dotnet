using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanGradientaiKnowledgeBases
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_knowledge_bases digitalocean_gradientai_knowledge_bases}.</summary>
    [JsiiClass(nativeType: typeof(digitalocean.DataDigitaloceanGradientaiKnowledgeBases.DataDigitaloceanGradientaiKnowledgeBases), fullyQualifiedName: "digitalocean.dataDigitaloceanGradientaiKnowledgeBases.DataDigitaloceanGradientaiKnowledgeBases", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiKnowledgeBases.DataDigitaloceanGradientaiKnowledgeBasesConfig\"}}]")]
    public class DataDigitaloceanGradientaiKnowledgeBases : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_knowledge_bases digitalocean_gradientai_knowledge_bases} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataDigitaloceanGradientaiKnowledgeBases(Constructs.Construct scope, string id, digitalocean.DataDigitaloceanGradientaiKnowledgeBases.IDataDigitaloceanGradientaiKnowledgeBasesConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, digitalocean.DataDigitaloceanGradientaiKnowledgeBases.IDataDigitaloceanGradientaiKnowledgeBasesConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanGradientaiKnowledgeBases(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanGradientaiKnowledgeBases(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataDigitaloceanGradientaiKnowledgeBases resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataDigitaloceanGradientaiKnowledgeBases to import.</param>
        /// <param name="importFromId">The id of the existing DataDigitaloceanGradientaiKnowledgeBases that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataDigitaloceanGradientaiKnowledgeBases to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataDigitaloceanGradientaiKnowledgeBases to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_knowledge_bases#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataDigitaloceanGradientaiKnowledgeBases that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataDigitaloceanGradientaiKnowledgeBases to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(digitalocean.DataDigitaloceanGradientaiKnowledgeBases.DataDigitaloceanGradientaiKnowledgeBases), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiKnowledgeBases.DataDigitaloceanGradientaiKnowledgeBasesFilter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFilter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case digitalocean.DataDigitaloceanGradientaiKnowledgeBases.IDataDigitaloceanGradientaiKnowledgeBasesFilter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.DataDigitaloceanGradientaiKnowledgeBases.IDataDigitaloceanGradientaiKnowledgeBasesFilter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.DataDigitaloceanGradientaiKnowledgeBases.IDataDigitaloceanGradientaiKnowledgeBasesFilter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSort", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiKnowledgeBases.DataDigitaloceanGradientaiKnowledgeBasesSort\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSort(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case digitalocean.DataDigitaloceanGradientaiKnowledgeBases.IDataDigitaloceanGradientaiKnowledgeBasesSort[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.DataDigitaloceanGradientaiKnowledgeBases.IDataDigitaloceanGradientaiKnowledgeBasesSort).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.DataDigitaloceanGradientaiKnowledgeBases.IDataDigitaloceanGradientaiKnowledgeBasesSort).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSort")]
        public virtual void ResetSort()
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
        = GetStaticProperty<string>(typeof(digitalocean.DataDigitaloceanGradientaiKnowledgeBases.DataDigitaloceanGradientaiKnowledgeBases))!;

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiKnowledgeBases.DataDigitaloceanGradientaiKnowledgeBasesFilterList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiKnowledgeBases.DataDigitaloceanGradientaiKnowledgeBasesFilterList Filter
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiKnowledgeBases.DataDigitaloceanGradientaiKnowledgeBasesFilterList>()!;
        }

        [JsiiProperty(name: "knowledgeBases", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiKnowledgeBases.DataDigitaloceanGradientaiKnowledgeBasesKnowledgeBasesList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiKnowledgeBases.DataDigitaloceanGradientaiKnowledgeBasesKnowledgeBasesList KnowledgeBases
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiKnowledgeBases.DataDigitaloceanGradientaiKnowledgeBasesKnowledgeBasesList>()!;
        }

        [JsiiProperty(name: "sort", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiKnowledgeBases.DataDigitaloceanGradientaiKnowledgeBasesSortList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiKnowledgeBases.DataDigitaloceanGradientaiKnowledgeBasesSortList Sort
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiKnowledgeBases.DataDigitaloceanGradientaiKnowledgeBasesSortList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiKnowledgeBases.DataDigitaloceanGradientaiKnowledgeBasesFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FilterInput
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
        [JsiiProperty(name: "sortInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiKnowledgeBases.DataDigitaloceanGradientaiKnowledgeBasesSort\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SortInput
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
