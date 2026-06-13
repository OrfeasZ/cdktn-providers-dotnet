using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAiGateway
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareAiGateway.DataCloudflareAiGatewayGuardrailsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareAiGateway.DataCloudflareAiGatewayGuardrailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareAiGatewayGuardrailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareAiGatewayGuardrailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareAiGatewayGuardrailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareAiGatewayGuardrailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "prompt", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiGateway.DataCloudflareAiGatewayGuardrailsPromptOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAiGateway.DataCloudflareAiGatewayGuardrailsPromptOutputReference Prompt
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiGateway.DataCloudflareAiGatewayGuardrailsPromptOutputReference>()!;
        }

        [JsiiProperty(name: "response", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiGateway.DataCloudflareAiGatewayGuardrailsResponseOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAiGateway.DataCloudflareAiGatewayGuardrailsResponseOutputReference Response
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiGateway.DataCloudflareAiGatewayGuardrailsResponseOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiGateway.DataCloudflareAiGatewayGuardrails\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareAiGateway.IDataCloudflareAiGatewayGuardrails? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiGateway.IDataCloudflareAiGatewayGuardrails?>();
            set => SetInstanceProperty(value);
        }
    }
}
