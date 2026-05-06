using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BlockchainBlockchainPlatform
{
    [JsiiByValue(fqn: "oci.blockchainBlockchainPlatform.BlockchainBlockchainPlatformTimeouts")]
    public class BlockchainBlockchainPlatformTimeouts : oci.BlockchainBlockchainPlatform.IBlockchainBlockchainPlatformTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#create BlockchainBlockchainPlatform#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#delete BlockchainBlockchainPlatform#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#update BlockchainBlockchainPlatform#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
