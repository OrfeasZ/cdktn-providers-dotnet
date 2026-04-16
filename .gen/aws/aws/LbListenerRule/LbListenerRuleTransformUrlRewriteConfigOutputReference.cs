using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LbListenerRule
{
    [JsiiClass(nativeType: typeof(aws.LbListenerRule.LbListenerRuleTransformUrlRewriteConfigOutputReference), fullyQualifiedName: "aws.lbListenerRule.LbListenerRuleTransformUrlRewriteConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LbListenerRuleTransformUrlRewriteConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LbListenerRuleTransformUrlRewriteConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LbListenerRuleTransformUrlRewriteConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LbListenerRuleTransformUrlRewriteConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRewrite", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lbListenerRule.LbListenerRuleTransformUrlRewriteConfigRewrite\"}}]")]
        public virtual void PutRewrite(aws.LbListenerRule.ILbListenerRuleTransformUrlRewriteConfigRewrite @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LbListenerRule.ILbListenerRuleTransformUrlRewriteConfigRewrite)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetRewrite")]
        public virtual void ResetRewrite()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "rewrite", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleTransformUrlRewriteConfigRewriteOutputReference\"}")]
        public virtual aws.LbListenerRule.LbListenerRuleTransformUrlRewriteConfigRewriteOutputReference Rewrite
        {
            get => GetInstanceProperty<aws.LbListenerRule.LbListenerRuleTransformUrlRewriteConfigRewriteOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "rewriteInput", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleTransformUrlRewriteConfigRewrite\"}", isOptional: true)]
        public virtual aws.LbListenerRule.ILbListenerRuleTransformUrlRewriteConfigRewrite? RewriteInput
        {
            get => GetInstanceProperty<aws.LbListenerRule.ILbListenerRuleTransformUrlRewriteConfigRewrite?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleTransformUrlRewriteConfig\"}", isOptional: true)]
        public virtual aws.LbListenerRule.ILbListenerRuleTransformUrlRewriteConfig? InternalValue
        {
            get => GetInstanceProperty<aws.LbListenerRule.ILbListenerRuleTransformUrlRewriteConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
