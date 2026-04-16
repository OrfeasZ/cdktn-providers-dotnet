using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncApi
{
    [JsiiClass(nativeType: typeof(aws.AppsyncApi.AppsyncApiEventConfigAuthProviderOutputReference), fullyQualifiedName: "aws.appsyncApi.AppsyncApiEventConfigAuthProviderOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppsyncApiEventConfigAuthProviderOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public AppsyncApiEventConfigAuthProviderOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected AppsyncApiEventConfigAuthProviderOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppsyncApiEventConfigAuthProviderOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCognitoConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigAuthProviderCognitoConfig\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCognitoConfig(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.AppsyncApi.IAppsyncApiEventConfigAuthProviderCognitoConfig[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AppsyncApi.IAppsyncApiEventConfigAuthProviderCognitoConfig).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AppsyncApi.IAppsyncApiEventConfigAuthProviderCognitoConfig).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLambdaAuthorizerConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigAuthProviderLambdaAuthorizerConfig\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLambdaAuthorizerConfig(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.AppsyncApi.IAppsyncApiEventConfigAuthProviderLambdaAuthorizerConfig[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AppsyncApi.IAppsyncApiEventConfigAuthProviderLambdaAuthorizerConfig).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AppsyncApi.IAppsyncApiEventConfigAuthProviderLambdaAuthorizerConfig).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOpenidConnectConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigAuthProviderOpenidConnectConfig\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutOpenidConnectConfig(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.AppsyncApi.IAppsyncApiEventConfigAuthProviderOpenidConnectConfig[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AppsyncApi.IAppsyncApiEventConfigAuthProviderOpenidConnectConfig).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AppsyncApi.IAppsyncApiEventConfigAuthProviderOpenidConnectConfig).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCognitoConfig")]
        public virtual void ResetCognitoConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLambdaAuthorizerConfig")]
        public virtual void ResetLambdaAuthorizerConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOpenidConnectConfig")]
        public virtual void ResetOpenidConnectConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cognitoConfig", typeJson: "{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigAuthProviderCognitoConfigList\"}")]
        public virtual aws.AppsyncApi.AppsyncApiEventConfigAuthProviderCognitoConfigList CognitoConfig
        {
            get => GetInstanceProperty<aws.AppsyncApi.AppsyncApiEventConfigAuthProviderCognitoConfigList>()!;
        }

        [JsiiProperty(name: "lambdaAuthorizerConfig", typeJson: "{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigAuthProviderLambdaAuthorizerConfigList\"}")]
        public virtual aws.AppsyncApi.AppsyncApiEventConfigAuthProviderLambdaAuthorizerConfigList LambdaAuthorizerConfig
        {
            get => GetInstanceProperty<aws.AppsyncApi.AppsyncApiEventConfigAuthProviderLambdaAuthorizerConfigList>()!;
        }

        [JsiiProperty(name: "openidConnectConfig", typeJson: "{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigAuthProviderOpenidConnectConfigList\"}")]
        public virtual aws.AppsyncApi.AppsyncApiEventConfigAuthProviderOpenidConnectConfigList OpenidConnectConfig
        {
            get => GetInstanceProperty<aws.AppsyncApi.AppsyncApiEventConfigAuthProviderOpenidConnectConfigList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cognitoConfigInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigAuthProviderCognitoConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CognitoConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lambdaAuthorizerConfigInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigAuthProviderLambdaAuthorizerConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LambdaAuthorizerConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "openidConnectConfigInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigAuthProviderOpenidConnectConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? OpenidConnectConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "authType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.appsyncApi.AppsyncApiEventConfigAuthProvider\"}]}}", isOptional: true)]
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
                        case aws.AppsyncApi.IAppsyncApiEventConfigAuthProvider cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AppsyncApi.IAppsyncApiEventConfigAuthProvider).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
