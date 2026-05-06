using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BlockchainBlockchainPlatform
{
    [JsiiInterface(nativeType: typeof(IBlockchainBlockchainPlatformReplicas), fullyQualifiedName: "oci.blockchainBlockchainPlatform.BlockchainBlockchainPlatformReplicas")]
    public interface IBlockchainBlockchainPlatformReplicas
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#ca_count BlockchainBlockchainPlatform#ca_count}.</summary>
        [JsiiProperty(name: "caCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CaCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#console_count BlockchainBlockchainPlatform#console_count}.</summary>
        [JsiiProperty(name: "consoleCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ConsoleCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#proxy_count BlockchainBlockchainPlatform#proxy_count}.</summary>
        [JsiiProperty(name: "proxyCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ProxyCount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBlockchainBlockchainPlatformReplicas), fullyQualifiedName: "oci.blockchainBlockchainPlatform.BlockchainBlockchainPlatformReplicas")]
        internal sealed class _Proxy : DeputyBase, oci.BlockchainBlockchainPlatform.IBlockchainBlockchainPlatformReplicas
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#ca_count BlockchainBlockchainPlatform#ca_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "caCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CaCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#console_count BlockchainBlockchainPlatform#console_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "consoleCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ConsoleCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/blockchain_blockchain_platform#proxy_count BlockchainBlockchainPlatform#proxy_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "proxyCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ProxyCount
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
