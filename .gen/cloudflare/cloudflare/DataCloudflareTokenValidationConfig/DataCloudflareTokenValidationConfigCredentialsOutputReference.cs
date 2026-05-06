using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareTokenValidationConfig
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareTokenValidationConfig.DataCloudflareTokenValidationConfigCredentialsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareTokenValidationConfig.DataCloudflareTokenValidationConfigCredentialsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareTokenValidationConfigCredentialsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareTokenValidationConfigCredentialsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareTokenValidationConfigCredentialsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareTokenValidationConfigCredentialsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "keys", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareTokenValidationConfig.DataCloudflareTokenValidationConfigCredentialsKeysList\"}")]
        public virtual cloudflare.DataCloudflareTokenValidationConfig.DataCloudflareTokenValidationConfigCredentialsKeysList Keys
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareTokenValidationConfig.DataCloudflareTokenValidationConfigCredentialsKeysList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareTokenValidationConfig.DataCloudflareTokenValidationConfigCredentials\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareTokenValidationConfig.IDataCloudflareTokenValidationConfigCredentials? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareTokenValidationConfig.IDataCloudflareTokenValidationConfigCredentials?>();
            set => SetInstanceProperty(value);
        }
    }
}
