using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AlbListenerRule
{
    [JsiiClass(nativeType: typeof(aws.AlbListenerRule.AlbListenerRuleTransformUrlRewriteConfigOutputReference), fullyQualifiedName: "aws.albListenerRule.AlbListenerRuleTransformUrlRewriteConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AlbListenerRuleTransformUrlRewriteConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AlbListenerRuleTransformUrlRewriteConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbListenerRuleTransformUrlRewriteConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbListenerRuleTransformUrlRewriteConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRewrite", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.albListenerRule.AlbListenerRuleTransformUrlRewriteConfigRewrite\"}}]")]
        public virtual void PutRewrite(aws.AlbListenerRule.IAlbListenerRuleTransformUrlRewriteConfigRewrite @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AlbListenerRule.IAlbListenerRuleTransformUrlRewriteConfigRewrite)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetRewrite")]
        public virtual void ResetRewrite()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "rewrite", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleTransformUrlRewriteConfigRewriteOutputReference\"}")]
        public virtual aws.AlbListenerRule.AlbListenerRuleTransformUrlRewriteConfigRewriteOutputReference Rewrite
        {
            get => GetInstanceProperty<aws.AlbListenerRule.AlbListenerRuleTransformUrlRewriteConfigRewriteOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "rewriteInput", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleTransformUrlRewriteConfigRewrite\"}", isOptional: true)]
        public virtual aws.AlbListenerRule.IAlbListenerRuleTransformUrlRewriteConfigRewrite? RewriteInput
        {
            get => GetInstanceProperty<aws.AlbListenerRule.IAlbListenerRuleTransformUrlRewriteConfigRewrite?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleTransformUrlRewriteConfig\"}", isOptional: true)]
        public virtual aws.AlbListenerRule.IAlbListenerRuleTransformUrlRewriteConfig? InternalValue
        {
            get => GetInstanceProperty<aws.AlbListenerRule.IAlbListenerRuleTransformUrlRewriteConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
