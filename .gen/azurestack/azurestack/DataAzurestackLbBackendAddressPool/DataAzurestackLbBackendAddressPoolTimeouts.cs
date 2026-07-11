using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.DataAzurestackLbBackendAddressPool
{
    [JsiiByValue(fqn: "azurestack.dataAzurestackLbBackendAddressPool.DataAzurestackLbBackendAddressPoolTimeouts")]
    public class DataAzurestackLbBackendAddressPoolTimeouts : azurestack.DataAzurestackLbBackendAddressPool.IDataAzurestackLbBackendAddressPoolTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/lb_backend_address_pool#read DataAzurestackLbBackendAddressPool#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
