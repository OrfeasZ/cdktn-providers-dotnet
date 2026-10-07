using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.Provider
{
    [JsiiInterface(nativeType: typeof(IScalewayProviderEndpoints), fullyQualifiedName: "scaleway.provider.ScalewayProviderEndpoints")]
    public interface IScalewayProviderEndpoints
    {
        /// <summary>Use this to override the default service endpoint URL.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.86.0/docs#s3 ScalewayProvider#s3}
        /// </remarks>
        [JsiiProperty(name: "s3", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? S3
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IScalewayProviderEndpoints), fullyQualifiedName: "scaleway.provider.ScalewayProviderEndpoints")]
        internal sealed class _Proxy : DeputyBase, scaleway.Provider.IScalewayProviderEndpoints
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Use this to override the default service endpoint URL.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.86.0/docs#s3 ScalewayProvider#s3}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
