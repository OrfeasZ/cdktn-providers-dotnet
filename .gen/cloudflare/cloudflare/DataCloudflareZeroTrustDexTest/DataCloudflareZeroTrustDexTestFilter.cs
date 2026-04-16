using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustDexTest
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareZeroTrustDexTest.DataCloudflareZeroTrustDexTestFilter")]
    public class DataCloudflareZeroTrustDexTestFilter : cloudflare.DataCloudflareZeroTrustDexTest.IDataCloudflareZeroTrustDexTestFilter
    {
        /// <summary>Filter by test type Available values: "http", "traceroute".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_dex_test#kind DataCloudflareZeroTrustDexTest#kind}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Kind
        {
            get;
            set;
        }

        /// <summary>Filter by test name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/zero_trust_dex_test#test_name DataCloudflareZeroTrustDexTest#test_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "testName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TestName
        {
            get;
            set;
        }
    }
}
