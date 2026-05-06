using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceNotebookSession
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.datascienceNotebookSession.DatascienceNotebookSessionNotebookSessionConfigDetails")]
    public class DatascienceNotebookSessionNotebookSessionConfigDetails : oci.DatascienceNotebookSession.IDatascienceNotebookSessionNotebookSessionConfigDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#shape DatascienceNotebookSession#shape}.</summary>
        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        public string Shape
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#block_storage_size_in_gbs DatascienceNotebookSession#block_storage_size_in_gbs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "blockStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BlockStorageSizeInGbs
        {
            get;
            set;
        }

        /// <summary>notebook_session_shape_config_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#notebook_session_shape_config_details DatascienceNotebookSession#notebook_session_shape_config_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "notebookSessionShapeConfigDetails", typeJson: "{\"fqn\":\"oci.datascienceNotebookSession.DatascienceNotebookSessionNotebookSessionConfigDetailsNotebookSessionShapeConfigDetails\"}", isOptional: true)]
        public oci.DatascienceNotebookSession.IDatascienceNotebookSessionNotebookSessionConfigDetailsNotebookSessionShapeConfigDetails? NotebookSessionShapeConfigDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#private_endpoint_id DatascienceNotebookSession#private_endpoint_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateEndpointId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#subnet_id DatascienceNotebookSession#subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubnetId
        {
            get;
            set;
        }
    }
}
