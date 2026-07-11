using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.DataAzurestackSubnet
{
    [JsiiByValue(fqn: "azurestack.dataAzurestackSubnet.DataAzurestackSubnetTimeouts")]
    public class DataAzurestackSubnetTimeouts : azurestack.DataAzurestackSubnet.IDataAzurestackSubnetTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/subnet#read DataAzurestackSubnet#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
