using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncChannelNamespace
{
    [JsiiClass(nativeType: typeof(aws.AppsyncChannelNamespace.AppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegrationOutputReference), fullyQualifiedName: "aws.appsyncChannelNamespace.AppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegrationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegrationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public AppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegrationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected AppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegrationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegrationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLambdaConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncChannelNamespace.AppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegrationLambdaConfig\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLambdaConfig(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.AppsyncChannelNamespace.IAppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegrationLambdaConfig[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AppsyncChannelNamespace.IAppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegrationLambdaConfig).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AppsyncChannelNamespace.IAppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegrationLambdaConfig).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetLambdaConfig")]
        public virtual void ResetLambdaConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "lambdaConfig", typeJson: "{\"fqn\":\"aws.appsyncChannelNamespace.AppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegrationLambdaConfigList\"}")]
        public virtual aws.AppsyncChannelNamespace.AppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegrationLambdaConfigList LambdaConfig
        {
            get => GetInstanceProperty<aws.AppsyncChannelNamespace.AppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegrationLambdaConfigList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataSourceNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DataSourceNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lambdaConfigInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncChannelNamespace.AppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegrationLambdaConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LambdaConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "dataSourceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataSourceName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.appsyncChannelNamespace.AppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegration\"}]}}", isOptional: true)]
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
                        case aws.AppsyncChannelNamespace.IAppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegration cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AppsyncChannelNamespace.IAppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegration).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
