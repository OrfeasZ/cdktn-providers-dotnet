using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareFlagshipFlag
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareFlagshipFlagFilter), fullyQualifiedName: "cloudflare.dataCloudflareFlagshipFlag.DataCloudflareFlagshipFlagFilter")]
    public interface IDataCloudflareFlagshipFlagFilter
    {
        /// <summary>Max items to return (1–200).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/data-sources/flagship_flag#limit DataCloudflareFlagshipFlag#limit}
        /// </remarks>
        [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Limit
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareFlagshipFlagFilter), fullyQualifiedName: "cloudflare.dataCloudflareFlagshipFlag.DataCloudflareFlagshipFlagFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareFlagshipFlag.IDataCloudflareFlagshipFlagFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Max items to return (1–200).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/data-sources/flagship_flag#limit DataCloudflareFlagshipFlag#limit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Limit
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
