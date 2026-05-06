using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpensearchOpensearchCluster
{
    [JsiiInterface(nativeType: typeof(IOpensearchOpensearchClusterCertificateConfig), fullyQualifiedName: "oci.opensearchOpensearchCluster.OpensearchOpensearchClusterCertificateConfig")]
    public interface IOpensearchOpensearchClusterCertificateConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#cluster_certificate_mode OpensearchOpensearchCluster#cluster_certificate_mode}.</summary>
        [JsiiProperty(name: "clusterCertificateMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClusterCertificateMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#dashboard_certificate_mode OpensearchOpensearchCluster#dashboard_certificate_mode}.</summary>
        [JsiiProperty(name: "dashboardCertificateMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DashboardCertificateMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#open_search_api_certificate_id OpensearchOpensearchCluster#open_search_api_certificate_id}.</summary>
        [JsiiProperty(name: "openSearchApiCertificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OpenSearchApiCertificateId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#open_search_dashboard_certificate_id OpensearchOpensearchCluster#open_search_dashboard_certificate_id}.</summary>
        [JsiiProperty(name: "openSearchDashboardCertificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OpenSearchDashboardCertificateId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchOpensearchClusterCertificateConfig), fullyQualifiedName: "oci.opensearchOpensearchCluster.OpensearchOpensearchClusterCertificateConfig")]
        internal sealed class _Proxy : DeputyBase, oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterCertificateConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#cluster_certificate_mode OpensearchOpensearchCluster#cluster_certificate_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clusterCertificateMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClusterCertificateMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#dashboard_certificate_mode OpensearchOpensearchCluster#dashboard_certificate_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dashboardCertificateMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DashboardCertificateMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#open_search_api_certificate_id OpensearchOpensearchCluster#open_search_api_certificate_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "openSearchApiCertificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OpenSearchApiCertificateId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opensearch_opensearch_cluster#open_search_dashboard_certificate_id OpensearchOpensearchCluster#open_search_dashboard_certificate_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "openSearchDashboardCertificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OpenSearchDashboardCertificateId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
