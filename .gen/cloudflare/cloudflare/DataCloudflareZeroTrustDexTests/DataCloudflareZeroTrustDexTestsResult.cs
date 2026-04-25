using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustDexTests
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareZeroTrustDexTests.DataCloudflareZeroTrustDexTestsResult")]
    public class DataCloudflareZeroTrustDexTestsResult : cloudflare.DataCloudflareZeroTrustDexTests.IDataCloudflareZeroTrustDexTestsResult
    {
        private object? _targetPolicies;

        /// <summary>DEX rules targeted by this test.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/zero_trust_dex_tests#target_policies DataCloudflareZeroTrustDexTests#target_policies}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetPolicies", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDexTests.DataCloudflareZeroTrustDexTestsResultTargetPolicies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TargetPolicies
        {
            get => _targetPolicies;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.DataCloudflareZeroTrustDexTests.IDataCloudflareZeroTrustDexTestsResultTargetPolicies[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.DataCloudflareZeroTrustDexTests.IDataCloudflareZeroTrustDexTestsResultTargetPolicies).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _targetPolicies = value;
            }
        }
    }
}
