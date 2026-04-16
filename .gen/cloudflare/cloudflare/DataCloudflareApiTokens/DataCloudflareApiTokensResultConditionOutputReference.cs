using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareApiTokens
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareApiTokens.DataCloudflareApiTokensResultConditionOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareApiTokens.DataCloudflareApiTokensResultConditionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareApiTokensResultConditionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareApiTokensResultConditionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareApiTokensResultConditionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareApiTokensResultConditionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "requestIp", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareApiTokens.DataCloudflareApiTokensResultConditionRequestIpOutputReference\"}")]
        public virtual cloudflare.DataCloudflareApiTokens.DataCloudflareApiTokensResultConditionRequestIpOutputReference RequestIp
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareApiTokens.DataCloudflareApiTokensResultConditionRequestIpOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareApiTokens.DataCloudflareApiTokensResultCondition\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareApiTokens.IDataCloudflareApiTokensResultCondition? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareApiTokens.IDataCloudflareApiTokensResultCondition?>();
            set => SetInstanceProperty(value);
        }
    }
}
