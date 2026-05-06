using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreDrgAttachmentManagement
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreDrgAttachmentManagement.CoreDrgAttachmentManagementNetworkDetails")]
    public class CoreDrgAttachmentManagementNetworkDetails : oci.CoreDrgAttachmentManagement.ICoreDrgAttachmentManagementNetworkDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_attachment_management#id CoreDrgAttachmentManagement#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public string Id
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_attachment_management#type CoreDrgAttachmentManagement#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_attachment_management#route_table_id CoreDrgAttachmentManagement#route_table_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "routeTableId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RouteTableId
        {
            get;
            set;
        }
    }
}
