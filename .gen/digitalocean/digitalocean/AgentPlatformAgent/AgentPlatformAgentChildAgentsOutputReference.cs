using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.AgentPlatformAgent
{
    [JsiiClass(nativeType: typeof(digitalocean.AgentPlatformAgent.AgentPlatformAgentChildAgentsOutputReference), fullyQualifiedName: "digitalocean.agentPlatformAgent.AgentPlatformAgentChildAgentsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AgentPlatformAgentChildAgentsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public AgentPlatformAgentChildAgentsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected AgentPlatformAgentChildAgentsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AgentPlatformAgentChildAgentsOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsAnthropicApiKey" />)[]</param>
        [JsiiMethod(name: "putAnthropicApiKey", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentChildAgentsAnthropicApiKey\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAnthropicApiKey(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsAnthropicApiKey[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsAnthropicApiKey).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsAnthropicApiKey).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsApiKeyInfos" />)[]</param>
        [JsiiMethod(name: "putApiKeyInfos", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentChildAgentsApiKeyInfos\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutApiKeyInfos(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsApiKeyInfos[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsApiKeyInfos).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsApiKeyInfos).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsApiKeys" />)[]</param>
        [JsiiMethod(name: "putApiKeys", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentChildAgentsApiKeys\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutApiKeys(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsApiKeys[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsApiKeys).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsApiKeys).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsChatbot" />)[]</param>
        [JsiiMethod(name: "putChatbot", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentChildAgentsChatbot\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutChatbot(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsChatbot[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsChatbot).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsChatbot).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsChatbotIdentifiers" />)[]</param>
        [JsiiMethod(name: "putChatbotIdentifiers", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentChildAgentsChatbotIdentifiers\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutChatbotIdentifiers(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsChatbotIdentifiers[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsChatbotIdentifiers).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsChatbotIdentifiers).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsDeployment" />)[]</param>
        [JsiiMethod(name: "putDeployment", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentChildAgentsDeployment\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDeployment(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsDeployment[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsDeployment).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsDeployment).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAnthropicApiKey")]
        public virtual void ResetAnthropicApiKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetApiKeyInfos")]
        public virtual void ResetApiKeyInfos()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetApiKeys")]
        public virtual void ResetApiKeys()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetChatbot")]
        public virtual void ResetChatbot()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetChatbotIdentifiers")]
        public virtual void ResetChatbotIdentifiers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeployment")]
        public virtual void ResetDeployment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "agentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "anthropicApiKey", typeJson: "{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentChildAgentsAnthropicApiKeyList\"}")]
        public virtual digitalocean.AgentPlatformAgent.AgentPlatformAgentChildAgentsAnthropicApiKeyList AnthropicApiKey
        {
            get => GetInstanceProperty<digitalocean.AgentPlatformAgent.AgentPlatformAgentChildAgentsAnthropicApiKeyList>()!;
        }

        [JsiiProperty(name: "apiKeyInfos", typeJson: "{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentChildAgentsApiKeyInfosList\"}")]
        public virtual digitalocean.AgentPlatformAgent.AgentPlatformAgentChildAgentsApiKeyInfosList ApiKeyInfos
        {
            get => GetInstanceProperty<digitalocean.AgentPlatformAgent.AgentPlatformAgentChildAgentsApiKeyInfosList>()!;
        }

        [JsiiProperty(name: "apiKeys", typeJson: "{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentChildAgentsApiKeysList\"}")]
        public virtual digitalocean.AgentPlatformAgent.AgentPlatformAgentChildAgentsApiKeysList ApiKeys
        {
            get => GetInstanceProperty<digitalocean.AgentPlatformAgent.AgentPlatformAgentChildAgentsApiKeysList>()!;
        }

        [JsiiProperty(name: "chatbot", typeJson: "{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentChildAgentsChatbotList\"}")]
        public virtual digitalocean.AgentPlatformAgent.AgentPlatformAgentChildAgentsChatbotList Chatbot
        {
            get => GetInstanceProperty<digitalocean.AgentPlatformAgent.AgentPlatformAgentChildAgentsChatbotList>()!;
        }

        [JsiiProperty(name: "chatbotIdentifiers", typeJson: "{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentChildAgentsChatbotIdentifiersList\"}")]
        public virtual digitalocean.AgentPlatformAgent.AgentPlatformAgentChildAgentsChatbotIdentifiersList ChatbotIdentifiers
        {
            get => GetInstanceProperty<digitalocean.AgentPlatformAgent.AgentPlatformAgentChildAgentsChatbotIdentifiersList>()!;
        }

        [JsiiProperty(name: "deployment", typeJson: "{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentChildAgentsDeploymentList\"}")]
        public virtual digitalocean.AgentPlatformAgent.AgentPlatformAgentChildAgentsDeploymentList Deployment
        {
            get => GetInstanceProperty<digitalocean.AgentPlatformAgent.AgentPlatformAgentChildAgentsDeploymentList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsAnthropicApiKey" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "anthropicApiKeyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentChildAgentsAnthropicApiKey\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AnthropicApiKeyInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsApiKeyInfos" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "apiKeyInfosInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentChildAgentsApiKeyInfos\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ApiKeyInfosInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsApiKeys" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "apiKeysInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentChildAgentsApiKeys\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ApiKeysInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsChatbotIdentifiers" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "chatbotIdentifiersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentChildAgentsChatbotIdentifiers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ChatbotIdentifiersInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsChatbot" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "chatbotInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentChildAgentsChatbot\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ChatbotInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsDeployment" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deploymentInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentChildAgentsDeployment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DeploymentInput
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
        [JsiiProperty(name: "instructionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstructionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelUuidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModelUuidInput
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
        [JsiiProperty(name: "projectIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProjectIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instruction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Instruction
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "modelUuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelUuid
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

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
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

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgents" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentChildAgents\"}]}}", isOptional: true)]
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
                        case digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgents cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgents).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
