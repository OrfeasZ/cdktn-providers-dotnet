using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncApi
{
    [JsiiClass(nativeType: typeof(aws.AppsyncApi.AppsyncApiEventConfigOutputReference), fullyQualifiedName: "aws.appsyncApi.AppsyncApiEventConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppsyncApiEventConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public AppsyncApiEventConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected AppsyncApiEventConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppsyncApiEventConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAuthProvider", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigAuthProvider\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAuthProvider(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.AppsyncApi.IAppsyncApiEventConfigAuthProvider[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AppsyncApi.IAppsyncApiEventConfigAuthProvider).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AppsyncApi.IAppsyncApiEventConfigAuthProvider).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putConnectionAuthMode", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigConnectionAuthMode\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutConnectionAuthMode(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.AppsyncApi.IAppsyncApiEventConfigConnectionAuthMode[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AppsyncApi.IAppsyncApiEventConfigConnectionAuthMode).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AppsyncApi.IAppsyncApiEventConfigConnectionAuthMode).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDefaultPublishAuthMode", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigDefaultPublishAuthMode\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDefaultPublishAuthMode(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.AppsyncApi.IAppsyncApiEventConfigDefaultPublishAuthMode[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AppsyncApi.IAppsyncApiEventConfigDefaultPublishAuthMode).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AppsyncApi.IAppsyncApiEventConfigDefaultPublishAuthMode).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDefaultSubscribeAuthMode", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigDefaultSubscribeAuthMode\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDefaultSubscribeAuthMode(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.AppsyncApi.IAppsyncApiEventConfigDefaultSubscribeAuthMode[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AppsyncApi.IAppsyncApiEventConfigDefaultSubscribeAuthMode).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AppsyncApi.IAppsyncApiEventConfigDefaultSubscribeAuthMode).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLogConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigLogConfig\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLogConfig(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.AppsyncApi.IAppsyncApiEventConfigLogConfig[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AppsyncApi.IAppsyncApiEventConfigLogConfig).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AppsyncApi.IAppsyncApiEventConfigLogConfig).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAuthProvider")]
        public virtual void ResetAuthProvider()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConnectionAuthMode")]
        public virtual void ResetConnectionAuthMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultPublishAuthMode")]
        public virtual void ResetDefaultPublishAuthMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultSubscribeAuthMode")]
        public virtual void ResetDefaultSubscribeAuthMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogConfig")]
        public virtual void ResetLogConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "authProvider", typeJson: "{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigAuthProviderList\"}")]
        public virtual aws.AppsyncApi.AppsyncApiEventConfigAuthProviderList AuthProvider
        {
            get => GetInstanceProperty<aws.AppsyncApi.AppsyncApiEventConfigAuthProviderList>()!;
        }

        [JsiiProperty(name: "connectionAuthMode", typeJson: "{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigConnectionAuthModeList\"}")]
        public virtual aws.AppsyncApi.AppsyncApiEventConfigConnectionAuthModeList ConnectionAuthMode
        {
            get => GetInstanceProperty<aws.AppsyncApi.AppsyncApiEventConfigConnectionAuthModeList>()!;
        }

        [JsiiProperty(name: "defaultPublishAuthMode", typeJson: "{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigDefaultPublishAuthModeList\"}")]
        public virtual aws.AppsyncApi.AppsyncApiEventConfigDefaultPublishAuthModeList DefaultPublishAuthMode
        {
            get => GetInstanceProperty<aws.AppsyncApi.AppsyncApiEventConfigDefaultPublishAuthModeList>()!;
        }

        [JsiiProperty(name: "defaultSubscribeAuthMode", typeJson: "{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigDefaultSubscribeAuthModeList\"}")]
        public virtual aws.AppsyncApi.AppsyncApiEventConfigDefaultSubscribeAuthModeList DefaultSubscribeAuthMode
        {
            get => GetInstanceProperty<aws.AppsyncApi.AppsyncApiEventConfigDefaultSubscribeAuthModeList>()!;
        }

        [JsiiProperty(name: "logConfig", typeJson: "{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigLogConfigList\"}")]
        public virtual aws.AppsyncApi.AppsyncApiEventConfigLogConfigList LogConfig
        {
            get => GetInstanceProperty<aws.AppsyncApi.AppsyncApiEventConfigLogConfigList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authProviderInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigAuthProvider\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AuthProviderInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionAuthModeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigConnectionAuthMode\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ConnectionAuthModeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultPublishAuthModeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigDefaultPublishAuthMode\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DefaultPublishAuthModeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultSubscribeAuthModeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigDefaultSubscribeAuthMode\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DefaultSubscribeAuthModeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logConfigInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigLogConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LogConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfig\"}]}}", isOptional: true)]
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
                        case aws.AppsyncApi.IAppsyncApiEventConfig cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AppsyncApi.IAppsyncApiEventConfig).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
