using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpensearchOpensearchCluster
{
    [JsiiByValue(fqn: "oci.opensearchOpensearchCluster.OpensearchOpensearchClusterCertificateConfig")]
    public class OpensearchOpensearchClusterCertificateConfig : oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterCertificateConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#cluster_certificate_mode OpensearchOpensearchCluster#cluster_certificate_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clusterCertificateMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClusterCertificateMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#dashboard_certificate_mode OpensearchOpensearchCluster#dashboard_certificate_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dashboardCertificateMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DashboardCertificateMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#open_search_api_certificate_id OpensearchOpensearchCluster#open_search_api_certificate_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "openSearchApiCertificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OpenSearchApiCertificateId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#open_search_dashboard_certificate_id OpensearchOpensearchCluster#open_search_dashboard_certificate_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "openSearchDashboardCertificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OpenSearchDashboardCertificateId
        {
            get;
            set;
        }
    }
}
