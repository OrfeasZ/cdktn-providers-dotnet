using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OcvpEsxiHost
{
    [JsiiInterface(nativeType: typeof(IOcvpEsxiHostTimeouts), fullyQualifiedName: "oci.ocvpEsxiHost.OcvpEsxiHostTimeouts")]
    public interface IOcvpEsxiHostTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_esxi_host#create OcvpEsxiHost#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOcvpEsxiHostTimeouts), fullyQualifiedName: "oci.ocvpEsxiHost.OcvpEsxiHostTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.OcvpEsxiHost.IOcvpEsxiHostTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_esxi_host#create OcvpEsxiHost#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
