using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ClusterHealthDiagnosisStore
{
    [JsiiByValue(fqn: "oci.clusterHealthDiagnosisStore.ClusterHealthDiagnosisStoreTimeouts")]
    public class ClusterHealthDiagnosisStoreTimeouts : oci.ClusterHealthDiagnosisStore.IClusterHealthDiagnosisStoreTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/cluster_health_diagnosis_store#create ClusterHealthDiagnosisStore#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/cluster_health_diagnosis_store#delete ClusterHealthDiagnosisStore#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/cluster_health_diagnosis_store#update ClusterHealthDiagnosisStore#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
