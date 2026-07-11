using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.DataAzurestackRouteTable
{
    [JsiiByValue(fqn: "azurestack.dataAzurestackRouteTable.DataAzurestackRouteTableTimeouts")]
    public class DataAzurestackRouteTableTimeouts : azurestack.DataAzurestackRouteTable.IDataAzurestackRouteTableTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/route_table#read DataAzurestackRouteTable#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
