using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreOauth2CredentialProvider
{
    [JsiiClass(nativeType: typeof(aws.BedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigOutputReference), fullyQualifiedName: "aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCustomOauth2ProviderConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigCustomOauth2ProviderConfig\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCustomOauth2ProviderConfig(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigCustomOauth2ProviderConfig[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigCustomOauth2ProviderConfig).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigCustomOauth2ProviderConfig).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGithubOauth2ProviderConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigGithubOauth2ProviderConfig\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutGithubOauth2ProviderConfig(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigGithubOauth2ProviderConfig[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigGithubOauth2ProviderConfig).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigGithubOauth2ProviderConfig).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGoogleOauth2ProviderConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigGoogleOauth2ProviderConfig\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutGoogleOauth2ProviderConfig(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigGoogleOauth2ProviderConfig[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigGoogleOauth2ProviderConfig).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigGoogleOauth2ProviderConfig).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMicrosoftOauth2ProviderConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfig\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutMicrosoftOauth2ProviderConfig(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfig[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfig).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfig).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSalesforceOauth2ProviderConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigSalesforceOauth2ProviderConfig\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSalesforceOauth2ProviderConfig(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigSalesforceOauth2ProviderConfig[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigSalesforceOauth2ProviderConfig).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigSalesforceOauth2ProviderConfig).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSlackOauth2ProviderConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigSlackOauth2ProviderConfig\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSlackOauth2ProviderConfig(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigSlackOauth2ProviderConfig[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigSlackOauth2ProviderConfig).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigSlackOauth2ProviderConfig).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCustomOauth2ProviderConfig")]
        public virtual void ResetCustomOauth2ProviderConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGithubOauth2ProviderConfig")]
        public virtual void ResetGithubOauth2ProviderConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGoogleOauth2ProviderConfig")]
        public virtual void ResetGoogleOauth2ProviderConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMicrosoftOauth2ProviderConfig")]
        public virtual void ResetMicrosoftOauth2ProviderConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSalesforceOauth2ProviderConfig")]
        public virtual void ResetSalesforceOauth2ProviderConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSlackOauth2ProviderConfig")]
        public virtual void ResetSlackOauth2ProviderConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "customOauth2ProviderConfig", typeJson: "{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigCustomOauth2ProviderConfigList\"}")]
        public virtual aws.BedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigCustomOauth2ProviderConfigList CustomOauth2ProviderConfig
        {
            get => GetInstanceProperty<aws.BedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigCustomOauth2ProviderConfigList>()!;
        }

        [JsiiProperty(name: "githubOauth2ProviderConfig", typeJson: "{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigGithubOauth2ProviderConfigList\"}")]
        public virtual aws.BedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigGithubOauth2ProviderConfigList GithubOauth2ProviderConfig
        {
            get => GetInstanceProperty<aws.BedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigGithubOauth2ProviderConfigList>()!;
        }

        [JsiiProperty(name: "googleOauth2ProviderConfig", typeJson: "{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigGoogleOauth2ProviderConfigList\"}")]
        public virtual aws.BedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigGoogleOauth2ProviderConfigList GoogleOauth2ProviderConfig
        {
            get => GetInstanceProperty<aws.BedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigGoogleOauth2ProviderConfigList>()!;
        }

        [JsiiProperty(name: "microsoftOauth2ProviderConfig", typeJson: "{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigList\"}")]
        public virtual aws.BedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigList MicrosoftOauth2ProviderConfig
        {
            get => GetInstanceProperty<aws.BedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigList>()!;
        }

        [JsiiProperty(name: "salesforceOauth2ProviderConfig", typeJson: "{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigList\"}")]
        public virtual aws.BedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigList SalesforceOauth2ProviderConfig
        {
            get => GetInstanceProperty<aws.BedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigList>()!;
        }

        [JsiiProperty(name: "slackOauth2ProviderConfig", typeJson: "{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigSlackOauth2ProviderConfigList\"}")]
        public virtual aws.BedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigSlackOauth2ProviderConfigList SlackOauth2ProviderConfig
        {
            get => GetInstanceProperty<aws.BedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigSlackOauth2ProviderConfigList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "customOauth2ProviderConfigInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigCustomOauth2ProviderConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CustomOauth2ProviderConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "githubOauth2ProviderConfigInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigGithubOauth2ProviderConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? GithubOauth2ProviderConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "googleOauth2ProviderConfigInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigGoogleOauth2ProviderConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? GoogleOauth2ProviderConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "microsoftOauth2ProviderConfigInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? MicrosoftOauth2ProviderConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "salesforceOauth2ProviderConfigInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigSalesforceOauth2ProviderConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SalesforceOauth2ProviderConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "slackOauth2ProviderConfigInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigSlackOauth2ProviderConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SlackOauth2ProviderConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.bedrockagentcoreOauth2CredentialProvider.BedrockagentcoreOauth2CredentialProviderOauth2ProviderConfig\"}]}}", isOptional: true)]
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
                        case aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfig cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreOauth2CredentialProvider.IBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfig).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
