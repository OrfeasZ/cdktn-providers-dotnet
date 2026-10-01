using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.AgentPlatformKnowledgeBase
{
    [JsiiClass(nativeType: typeof(digitalocean.AgentPlatformKnowledgeBase.AgentPlatformKnowledgeBaseDatasourcesOutputReference), fullyQualifiedName: "digitalocean.agentPlatformKnowledgeBase.AgentPlatformKnowledgeBaseDatasourcesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AgentPlatformKnowledgeBaseDatasourcesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public AgentPlatformKnowledgeBaseDatasourcesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AgentPlatformKnowledgeBaseDatasourcesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AgentPlatformKnowledgeBaseDatasourcesOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesFileUploadDataSource" />)[]</param>
        [JsiiMethod(name: "putFileUploadDataSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformKnowledgeBase.AgentPlatformKnowledgeBaseDatasourcesFileUploadDataSource\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFileUploadDataSource(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesFileUploadDataSource[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesFileUploadDataSource).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesFileUploadDataSource).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesLastIndexingJob" />)[]</param>
        [JsiiMethod(name: "putLastIndexingJob", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformKnowledgeBase.AgentPlatformKnowledgeBaseDatasourcesLastIndexingJob\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLastIndexingJob(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesLastIndexingJob[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesLastIndexingJob).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesLastIndexingJob).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesSpacesDataSource" />)[]</param>
        [JsiiMethod(name: "putSpacesDataSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformKnowledgeBase.AgentPlatformKnowledgeBaseDatasourcesSpacesDataSource\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSpacesDataSource(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesSpacesDataSource[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesSpacesDataSource).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesSpacesDataSource).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesWebCrawlerDataSource" />)[]</param>
        [JsiiMethod(name: "putWebCrawlerDataSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformKnowledgeBase.AgentPlatformKnowledgeBaseDatasourcesWebCrawlerDataSource\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutWebCrawlerDataSource(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesWebCrawlerDataSource[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesWebCrawlerDataSource).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesWebCrawlerDataSource).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFileUploadDataSource")]
        public virtual void ResetFileUploadDataSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLastIndexingJob")]
        public virtual void ResetLastIndexingJob()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpacesDataSource")]
        public virtual void ResetSpacesDataSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUuid")]
        public virtual void ResetUuid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWebCrawlerDataSource")]
        public virtual void ResetWebCrawlerDataSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fileUploadDataSource", typeJson: "{\"fqn\":\"digitalocean.agentPlatformKnowledgeBase.AgentPlatformKnowledgeBaseDatasourcesFileUploadDataSourceList\"}")]
        public virtual digitalocean.AgentPlatformKnowledgeBase.AgentPlatformKnowledgeBaseDatasourcesFileUploadDataSourceList FileUploadDataSource
        {
            get => GetInstanceProperty<digitalocean.AgentPlatformKnowledgeBase.AgentPlatformKnowledgeBaseDatasourcesFileUploadDataSourceList>()!;
        }

        [JsiiProperty(name: "lastIndexingJob", typeJson: "{\"fqn\":\"digitalocean.agentPlatformKnowledgeBase.AgentPlatformKnowledgeBaseDatasourcesLastIndexingJobList\"}")]
        public virtual digitalocean.AgentPlatformKnowledgeBase.AgentPlatformKnowledgeBaseDatasourcesLastIndexingJobList LastIndexingJob
        {
            get => GetInstanceProperty<digitalocean.AgentPlatformKnowledgeBase.AgentPlatformKnowledgeBaseDatasourcesLastIndexingJobList>()!;
        }

        [JsiiProperty(name: "spacesDataSource", typeJson: "{\"fqn\":\"digitalocean.agentPlatformKnowledgeBase.AgentPlatformKnowledgeBaseDatasourcesSpacesDataSourceList\"}")]
        public virtual digitalocean.AgentPlatformKnowledgeBase.AgentPlatformKnowledgeBaseDatasourcesSpacesDataSourceList SpacesDataSource
        {
            get => GetInstanceProperty<digitalocean.AgentPlatformKnowledgeBase.AgentPlatformKnowledgeBaseDatasourcesSpacesDataSourceList>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "webCrawlerDataSource", typeJson: "{\"fqn\":\"digitalocean.agentPlatformKnowledgeBase.AgentPlatformKnowledgeBaseDatasourcesWebCrawlerDataSourceList\"}")]
        public virtual digitalocean.AgentPlatformKnowledgeBase.AgentPlatformKnowledgeBaseDatasourcesWebCrawlerDataSourceList WebCrawlerDataSource
        {
            get => GetInstanceProperty<digitalocean.AgentPlatformKnowledgeBase.AgentPlatformKnowledgeBaseDatasourcesWebCrawlerDataSourceList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesFileUploadDataSource" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fileUploadDataSourceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformKnowledgeBase.AgentPlatformKnowledgeBaseDatasourcesFileUploadDataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FileUploadDataSourceInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesLastIndexingJob" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lastIndexingJobInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformKnowledgeBase.AgentPlatformKnowledgeBaseDatasourcesLastIndexingJob\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LastIndexingJobInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesSpacesDataSource" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spacesDataSourceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformKnowledgeBase.AgentPlatformKnowledgeBaseDatasourcesSpacesDataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SpacesDataSourceInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "uuidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UuidInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesWebCrawlerDataSource" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "webCrawlerDataSourceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformKnowledgeBase.AgentPlatformKnowledgeBaseDatasourcesWebCrawlerDataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? WebCrawlerDataSourceInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Uuid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasources" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"digitalocean.agentPlatformKnowledgeBase.AgentPlatformKnowledgeBaseDatasources\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasources cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasources).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
