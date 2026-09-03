using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreCrossConnect
{
    [JsiiInterface(nativeType: typeof(ICoreCrossConnectLoaProperties), fullyQualifiedName: "oci.coreCrossConnect.CoreCrossConnectLoaProperties")]
    public interface ICoreCrossConnectLoaProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/core_cross_connect#authorized_agent CoreCrossConnect#authorized_agent}.</summary>
        [JsiiProperty(name: "authorizedAgent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuthorizedAgent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/core_cross_connect#expiry_extension_count CoreCrossConnect#expiry_extension_count}.</summary>
        [JsiiProperty(name: "expiryExtensionCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ExpiryExtensionCount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreCrossConnectLoaProperties), fullyQualifiedName: "oci.coreCrossConnect.CoreCrossConnectLoaProperties")]
        internal sealed class _Proxy : DeputyBase, oci.CoreCrossConnect.ICoreCrossConnectLoaProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/core_cross_connect#authorized_agent CoreCrossConnect#authorized_agent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authorizedAgent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuthorizedAgent
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/core_cross_connect#expiry_extension_count CoreCrossConnect#expiry_extension_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "expiryExtensionCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ExpiryExtensionCount
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
