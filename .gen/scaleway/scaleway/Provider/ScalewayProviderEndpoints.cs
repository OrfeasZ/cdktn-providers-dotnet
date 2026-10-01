using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.Provider
{
    [JsiiByValue(fqn: "scaleway.provider.ScalewayProviderEndpoints")]
    public class ScalewayProviderEndpoints : scaleway.Provider.IScalewayProviderEndpoints
    {
        /// <summary>Use this to override the default service endpoint URL.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.84.0/docs#s3 ScalewayProvider#s3}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3
        {
            get;
            set;
        }
    }
}
