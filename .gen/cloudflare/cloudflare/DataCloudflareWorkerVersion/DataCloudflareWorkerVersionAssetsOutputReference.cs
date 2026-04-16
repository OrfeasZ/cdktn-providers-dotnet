using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareWorkerVersion
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareWorkerVersion.DataCloudflareWorkerVersionAssetsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareWorkerVersion.DataCloudflareWorkerVersionAssetsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareWorkerVersionAssetsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareWorkerVersionAssetsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareWorkerVersionAssetsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareWorkerVersionAssetsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "config", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkerVersion.DataCloudflareWorkerVersionAssetsConfigOutputReference\"}")]
        public virtual cloudflare.DataCloudflareWorkerVersion.DataCloudflareWorkerVersionAssetsConfigOutputReference Config
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkerVersion.DataCloudflareWorkerVersionAssetsConfigOutputReference>()!;
        }

        [JsiiProperty(name: "jwt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Jwt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkerVersion.DataCloudflareWorkerVersionAssets\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareWorkerVersion.IDataCloudflareWorkerVersionAssets? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkerVersion.IDataCloudflareWorkerVersionAssets?>();
            set => SetInstanceProperty(value);
        }
    }
}
