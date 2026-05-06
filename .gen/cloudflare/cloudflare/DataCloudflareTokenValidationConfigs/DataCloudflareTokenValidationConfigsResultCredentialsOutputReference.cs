using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareTokenValidationConfigs
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareTokenValidationConfigs.DataCloudflareTokenValidationConfigsResultCredentialsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareTokenValidationConfigs.DataCloudflareTokenValidationConfigsResultCredentialsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareTokenValidationConfigsResultCredentialsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareTokenValidationConfigsResultCredentialsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareTokenValidationConfigsResultCredentialsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareTokenValidationConfigsResultCredentialsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "keys", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareTokenValidationConfigs.DataCloudflareTokenValidationConfigsResultCredentialsKeysList\"}")]
        public virtual cloudflare.DataCloudflareTokenValidationConfigs.DataCloudflareTokenValidationConfigsResultCredentialsKeysList Keys
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareTokenValidationConfigs.DataCloudflareTokenValidationConfigsResultCredentialsKeysList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareTokenValidationConfigs.DataCloudflareTokenValidationConfigsResultCredentials\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareTokenValidationConfigs.IDataCloudflareTokenValidationConfigsResultCredentials? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareTokenValidationConfigs.IDataCloudflareTokenValidationConfigsResultCredentials?>();
            set => SetInstanceProperty(value);
        }
    }
}
