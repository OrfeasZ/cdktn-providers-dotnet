using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreDrgRouteDistributionStatement
{
    [JsiiClass(nativeType: typeof(oci.CoreDrgRouteDistributionStatement.CoreDrgRouteDistributionStatementMatchCriteriaOutputReference), fullyQualifiedName: "oci.coreDrgRouteDistributionStatement.CoreDrgRouteDistributionStatementMatchCriteriaOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CoreDrgRouteDistributionStatementMatchCriteriaOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CoreDrgRouteDistributionStatementMatchCriteriaOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CoreDrgRouteDistributionStatementMatchCriteriaOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreDrgRouteDistributionStatementMatchCriteriaOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAttachmentType")]
        public virtual void ResetAttachmentType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDrgAttachmentId")]
        public virtual void ResetDrgAttachmentId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMatchType")]
        public virtual void ResetMatchType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "attachmentTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AttachmentTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "drgAttachmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DrgAttachmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "matchTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MatchTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "attachmentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AttachmentType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "drgAttachmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DrgAttachmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "matchType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MatchType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.coreDrgRouteDistributionStatement.CoreDrgRouteDistributionStatementMatchCriteria\"}", isOptional: true)]
        public virtual oci.CoreDrgRouteDistributionStatement.ICoreDrgRouteDistributionStatementMatchCriteria? InternalValue
        {
            get => GetInstanceProperty<oci.CoreDrgRouteDistributionStatement.ICoreDrgRouteDistributionStatementMatchCriteria?>();
            set => SetInstanceProperty(value);
        }
    }
}
