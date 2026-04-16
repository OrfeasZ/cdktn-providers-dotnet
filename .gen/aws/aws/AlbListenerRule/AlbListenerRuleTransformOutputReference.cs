using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AlbListenerRule
{
    [JsiiClass(nativeType: typeof(aws.AlbListenerRule.AlbListenerRuleTransformOutputReference), fullyQualifiedName: "aws.albListenerRule.AlbListenerRuleTransformOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AlbListenerRuleTransformOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public AlbListenerRuleTransformOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected AlbListenerRuleTransformOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbListenerRuleTransformOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHostHeaderRewriteConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.albListenerRule.AlbListenerRuleTransformHostHeaderRewriteConfig\"}}]")]
        public virtual void PutHostHeaderRewriteConfig(aws.AlbListenerRule.IAlbListenerRuleTransformHostHeaderRewriteConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AlbListenerRule.IAlbListenerRuleTransformHostHeaderRewriteConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUrlRewriteConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.albListenerRule.AlbListenerRuleTransformUrlRewriteConfig\"}}]")]
        public virtual void PutUrlRewriteConfig(aws.AlbListenerRule.IAlbListenerRuleTransformUrlRewriteConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AlbListenerRule.IAlbListenerRuleTransformUrlRewriteConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHostHeaderRewriteConfig")]
        public virtual void ResetHostHeaderRewriteConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUrlRewriteConfig")]
        public virtual void ResetUrlRewriteConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "hostHeaderRewriteConfig", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleTransformHostHeaderRewriteConfigOutputReference\"}")]
        public virtual aws.AlbListenerRule.AlbListenerRuleTransformHostHeaderRewriteConfigOutputReference HostHeaderRewriteConfig
        {
            get => GetInstanceProperty<aws.AlbListenerRule.AlbListenerRuleTransformHostHeaderRewriteConfigOutputReference>()!;
        }

        [JsiiProperty(name: "urlRewriteConfig", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleTransformUrlRewriteConfigOutputReference\"}")]
        public virtual aws.AlbListenerRule.AlbListenerRuleTransformUrlRewriteConfigOutputReference UrlRewriteConfig
        {
            get => GetInstanceProperty<aws.AlbListenerRule.AlbListenerRuleTransformUrlRewriteConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostHeaderRewriteConfigInput", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleTransformHostHeaderRewriteConfig\"}", isOptional: true)]
        public virtual aws.AlbListenerRule.IAlbListenerRuleTransformHostHeaderRewriteConfig? HostHeaderRewriteConfigInput
        {
            get => GetInstanceProperty<aws.AlbListenerRule.IAlbListenerRuleTransformHostHeaderRewriteConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urlRewriteConfigInput", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleTransformUrlRewriteConfig\"}", isOptional: true)]
        public virtual aws.AlbListenerRule.IAlbListenerRuleTransformUrlRewriteConfig? UrlRewriteConfigInput
        {
            get => GetInstanceProperty<aws.AlbListenerRule.IAlbListenerRuleTransformUrlRewriteConfig?>();
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.albListenerRule.AlbListenerRuleTransform\"}]}}", isOptional: true)]
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
                        case aws.AlbListenerRule.IAlbListenerRuleTransform cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AlbListenerRule.IAlbListenerRuleTransform).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
