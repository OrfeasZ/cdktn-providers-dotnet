using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceNotebookSession
{
    [JsiiByValue(fqn: "oci.datascienceNotebookSession.DatascienceNotebookSessionNotebookSessionConfigurationDetailsNotebookSessionShapeConfigDetails")]
    public class DatascienceNotebookSessionNotebookSessionConfigurationDetailsNotebookSessionShapeConfigDetails : oci.DatascienceNotebookSession.IDatascienceNotebookSessionNotebookSessionConfigurationDetailsNotebookSessionShapeConfigDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#cpu_baseline DatascienceNotebookSession#cpu_baseline}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cpuBaseline", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CpuBaseline
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#memory_in_gbs DatascienceNotebookSession#memory_in_gbs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MemoryInGbs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#ocpus DatascienceNotebookSession#ocpus}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Ocpus
        {
            get;
            set;
        }
    }
}
