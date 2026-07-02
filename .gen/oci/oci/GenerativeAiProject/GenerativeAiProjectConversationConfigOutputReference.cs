using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiProject
{
    [JsiiClass(nativeType: typeof(oci.GenerativeAiProject.GenerativeAiProjectConversationConfigOutputReference), fullyQualifiedName: "oci.generativeAiProject.GenerativeAiProjectConversationConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GenerativeAiProjectConversationConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GenerativeAiProjectConversationConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GenerativeAiProjectConversationConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GenerativeAiProjectConversationConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetConversationsRetentionInHours")]
        public virtual void ResetConversationsRetentionInHours()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResponsesRetentionInHours")]
        public virtual void ResetResponsesRetentionInHours()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "conversationsRetentionInHoursInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ConversationsRetentionInHoursInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "responsesRetentionInHoursInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ResponsesRetentionInHoursInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "conversationsRetentionInHours", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConversationsRetentionInHours
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "responsesRetentionInHours", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ResponsesRetentionInHours
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.generativeAiProject.GenerativeAiProjectConversationConfig\"}", isOptional: true)]
        public virtual oci.GenerativeAiProject.IGenerativeAiProjectConversationConfig? InternalValue
        {
            get => GetInstanceProperty<oci.GenerativeAiProject.IGenerativeAiProjectConversationConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
