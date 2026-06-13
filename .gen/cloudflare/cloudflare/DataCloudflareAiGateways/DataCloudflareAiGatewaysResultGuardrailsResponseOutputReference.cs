using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAiGateways
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareAiGateways.DataCloudflareAiGatewaysResultGuardrailsResponseOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareAiGateways.DataCloudflareAiGatewaysResultGuardrailsResponseOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareAiGatewaysResultGuardrailsResponseOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareAiGatewaysResultGuardrailsResponseOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareAiGatewaysResultGuardrailsResponseOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareAiGatewaysResultGuardrailsResponseOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "p1", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string P1
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "s1", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S1
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "s10", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S10
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "s11", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S11
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "s12", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S12
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "s13", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S13
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "s2", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S2
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "s3", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "s4", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S4
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "s5", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S5
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "s6", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S6
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "s7", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S7
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "s8", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S8
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "s9", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S9
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiGateways.DataCloudflareAiGatewaysResultGuardrailsResponse\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareAiGateways.IDataCloudflareAiGatewaysResultGuardrailsResponse? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiGateways.IDataCloudflareAiGatewaysResultGuardrailsResponse?>();
            set => SetInstanceProperty(value);
        }
    }
}
