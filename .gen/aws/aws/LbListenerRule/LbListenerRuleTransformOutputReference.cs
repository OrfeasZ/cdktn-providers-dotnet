using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LbListenerRule
{
    [JsiiClass(nativeType: typeof(aws.LbListenerRule.LbListenerRuleTransformOutputReference), fullyQualifiedName: "aws.lbListenerRule.LbListenerRuleTransformOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class LbListenerRuleTransformOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public LbListenerRuleTransformOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected LbListenerRuleTransformOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LbListenerRuleTransformOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHostHeaderRewriteConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lbListenerRule.LbListenerRuleTransformHostHeaderRewriteConfig\"}}]")]
        public virtual void PutHostHeaderRewriteConfig(aws.LbListenerRule.ILbListenerRuleTransformHostHeaderRewriteConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LbListenerRule.ILbListenerRuleTransformHostHeaderRewriteConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUrlRewriteConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lbListenerRule.LbListenerRuleTransformUrlRewriteConfig\"}}]")]
        public virtual void PutUrlRewriteConfig(aws.LbListenerRule.ILbListenerRuleTransformUrlRewriteConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LbListenerRule.ILbListenerRuleTransformUrlRewriteConfig)}, new object[]{@value});
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

        [JsiiProperty(name: "hostHeaderRewriteConfig", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleTransformHostHeaderRewriteConfigOutputReference\"}")]
        public virtual aws.LbListenerRule.LbListenerRuleTransformHostHeaderRewriteConfigOutputReference HostHeaderRewriteConfig
        {
            get => GetInstanceProperty<aws.LbListenerRule.LbListenerRuleTransformHostHeaderRewriteConfigOutputReference>()!;
        }

        [JsiiProperty(name: "urlRewriteConfig", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleTransformUrlRewriteConfigOutputReference\"}")]
        public virtual aws.LbListenerRule.LbListenerRuleTransformUrlRewriteConfigOutputReference UrlRewriteConfig
        {
            get => GetInstanceProperty<aws.LbListenerRule.LbListenerRuleTransformUrlRewriteConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostHeaderRewriteConfigInput", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleTransformHostHeaderRewriteConfig\"}", isOptional: true)]
        public virtual aws.LbListenerRule.ILbListenerRuleTransformHostHeaderRewriteConfig? HostHeaderRewriteConfigInput
        {
            get => GetInstanceProperty<aws.LbListenerRule.ILbListenerRuleTransformHostHeaderRewriteConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urlRewriteConfigInput", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleTransformUrlRewriteConfig\"}", isOptional: true)]
        public virtual aws.LbListenerRule.ILbListenerRuleTransformUrlRewriteConfig? UrlRewriteConfigInput
        {
            get => GetInstanceProperty<aws.LbListenerRule.ILbListenerRuleTransformUrlRewriteConfig?>();
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.lbListenerRule.LbListenerRuleTransform\"}]}}", isOptional: true)]
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
                        case aws.LbListenerRule.ILbListenerRuleTransform cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.LbListenerRule.ILbListenerRuleTransform).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
