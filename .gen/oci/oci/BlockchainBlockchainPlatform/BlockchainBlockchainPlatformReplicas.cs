using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BlockchainBlockchainPlatform
{
    [JsiiByValue(fqn: "oci.blockchainBlockchainPlatform.BlockchainBlockchainPlatformReplicas")]
    public class BlockchainBlockchainPlatformReplicas : oci.BlockchainBlockchainPlatform.IBlockchainBlockchainPlatformReplicas
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#ca_count BlockchainBlockchainPlatform#ca_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "caCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CaCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#console_count BlockchainBlockchainPlatform#console_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "consoleCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ConsoleCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#proxy_count BlockchainBlockchainPlatform#proxy_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "proxyCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ProxyCount
        {
            get;
            set;
        }
    }
}
