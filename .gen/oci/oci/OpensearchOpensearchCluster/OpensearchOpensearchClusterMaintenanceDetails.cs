using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpensearchOpensearchCluster
{
    [JsiiByValue(fqn: "oci.opensearchOpensearchCluster.OpensearchOpensearchClusterMaintenanceDetails")]
    public class OpensearchOpensearchClusterMaintenanceDetails : oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterMaintenanceDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#notification_email_ids OpensearchOpensearchCluster#notification_email_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notificationEmailIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NotificationEmailIds
        {
            get;
            set;
        }
    }
}
