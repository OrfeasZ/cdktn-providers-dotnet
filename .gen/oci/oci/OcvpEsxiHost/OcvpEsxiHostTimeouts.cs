using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OcvpEsxiHost
{
    [JsiiByValue(fqn: "oci.ocvpEsxiHost.OcvpEsxiHostTimeouts")]
    public class OcvpEsxiHostTimeouts : oci.OcvpEsxiHost.IOcvpEsxiHostTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_esxi_host#create OcvpEsxiHost#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }
    }
}
