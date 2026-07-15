using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DifStack
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.difStack.DifStackDataflowConnections")]
    public class DifStackDataflowConnections : oci.DifStack.IDifStackDataflowConnections
    {
        /// <summary>connection_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/dif_stack#connection_details DifStack#connection_details}
        /// </remarks>
        [JsiiProperty(name: "connectionDetails", typeJson: "{\"fqn\":\"oci.difStack.DifStackDataflowConnectionsConnectionDetails\"}")]
        public oci.DifStack.IDifStackDataflowConnectionsConnectionDetails ConnectionDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/dif_stack#subnet_id DifStack#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public string SubnetId
        {
            get;
            set;
        }
    }
}
