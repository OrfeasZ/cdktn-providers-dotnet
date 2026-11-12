using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareBotManagement
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareBotManagement.DataCloudflareBotManagementAiAgentsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareBotManagement.DataCloudflareBotManagementAiAgentsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareBotManagementAiAgentsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareBotManagementAiAgentsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareBotManagementAiAgentsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareBotManagementAiAgentsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "anthropicAgent", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AnthropicAgent
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "googleAgent", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GoogleAgent
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instinct", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Instinct
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "muse", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Muse
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "openaiAgent", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpenaiAgent
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareBotManagement.DataCloudflareBotManagementAiAgents\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareBotManagement.IDataCloudflareBotManagementAiAgents? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareBotManagement.IDataCloudflareBotManagementAiAgents?>();
            set => SetInstanceProperty(value);
        }
    }
}
