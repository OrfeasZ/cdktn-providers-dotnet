using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncChannelNamespace
{
    [JsiiClass(nativeType: typeof(aws.AppsyncChannelNamespace.AppsyncChannelNamespaceHandlerConfigsOnPublishOutputReference), fullyQualifiedName: "aws.appsyncChannelNamespace.AppsyncChannelNamespaceHandlerConfigsOnPublishOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppsyncChannelNamespaceHandlerConfigsOnPublishOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public AppsyncChannelNamespaceHandlerConfigsOnPublishOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected AppsyncChannelNamespaceHandlerConfigsOnPublishOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppsyncChannelNamespaceHandlerConfigsOnPublishOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIntegration", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncChannelNamespace.AppsyncChannelNamespaceHandlerConfigsOnPublishIntegration\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutIntegration(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.AppsyncChannelNamespace.IAppsyncChannelNamespaceHandlerConfigsOnPublishIntegration[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AppsyncChannelNamespace.IAppsyncChannelNamespaceHandlerConfigsOnPublishIntegration).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AppsyncChannelNamespace.IAppsyncChannelNamespaceHandlerConfigsOnPublishIntegration).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetIntegration")]
        public virtual void ResetIntegration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "integration", typeJson: "{\"fqn\":\"aws.appsyncChannelNamespace.AppsyncChannelNamespaceHandlerConfigsOnPublishIntegrationList\"}")]
        public virtual aws.AppsyncChannelNamespace.AppsyncChannelNamespaceHandlerConfigsOnPublishIntegrationList Integration
        {
            get => GetInstanceProperty<aws.AppsyncChannelNamespace.AppsyncChannelNamespaceHandlerConfigsOnPublishIntegrationList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "behaviorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BehaviorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "integrationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncChannelNamespace.AppsyncChannelNamespaceHandlerConfigsOnPublishIntegration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? IntegrationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "behavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Behavior
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.appsyncChannelNamespace.AppsyncChannelNamespaceHandlerConfigsOnPublish\"}]}}", isOptional: true)]
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
                        case aws.AppsyncChannelNamespace.IAppsyncChannelNamespaceHandlerConfigsOnPublish cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AppsyncChannelNamespace.IAppsyncChannelNamespaceHandlerConfigsOnPublish).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
