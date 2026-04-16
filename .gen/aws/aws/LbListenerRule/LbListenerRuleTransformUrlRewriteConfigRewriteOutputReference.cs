using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LbListenerRule
{
    [JsiiClass(nativeType: typeof(aws.LbListenerRule.LbListenerRuleTransformUrlRewriteConfigRewriteOutputReference), fullyQualifiedName: "aws.lbListenerRule.LbListenerRuleTransformUrlRewriteConfigRewriteOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LbListenerRuleTransformUrlRewriteConfigRewriteOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LbListenerRuleTransformUrlRewriteConfigRewriteOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LbListenerRuleTransformUrlRewriteConfigRewriteOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LbListenerRuleTransformUrlRewriteConfigRewriteOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "regexInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegexInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replaceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReplaceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "regex", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Regex
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "replace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Replace
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleTransformUrlRewriteConfigRewrite\"}", isOptional: true)]
        public virtual aws.LbListenerRule.ILbListenerRuleTransformUrlRewriteConfigRewrite? InternalValue
        {
            get => GetInstanceProperty<aws.LbListenerRule.ILbListenerRuleTransformUrlRewriteConfigRewrite?>();
            set => SetInstanceProperty(value);
        }
    }
}
