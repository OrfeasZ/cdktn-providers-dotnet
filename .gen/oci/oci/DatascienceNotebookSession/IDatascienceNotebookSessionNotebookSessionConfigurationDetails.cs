using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceNotebookSession
{
    [JsiiInterface(nativeType: typeof(IDatascienceNotebookSessionNotebookSessionConfigurationDetails), fullyQualifiedName: "oci.datascienceNotebookSession.DatascienceNotebookSessionNotebookSessionConfigurationDetails")]
    public interface IDatascienceNotebookSessionNotebookSessionConfigurationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#shape DatascienceNotebookSession#shape}.</summary>
        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        string Shape
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#subnet_id DatascienceNotebookSession#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        string SubnetId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#block_storage_size_in_gbs DatascienceNotebookSession#block_storage_size_in_gbs}.</summary>
        [JsiiProperty(name: "blockStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BlockStorageSizeInGbs
        {
            get
            {
                return null;
            }
        }

        /// <summary>notebook_session_shape_config_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#notebook_session_shape_config_details DatascienceNotebookSession#notebook_session_shape_config_details}
        /// </remarks>
        [JsiiProperty(name: "notebookSessionShapeConfigDetails", typeJson: "{\"fqn\":\"oci.datascienceNotebookSession.DatascienceNotebookSessionNotebookSessionConfigurationDetailsNotebookSessionShapeConfigDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceNotebookSession.IDatascienceNotebookSessionNotebookSessionConfigurationDetailsNotebookSessionShapeConfigDetails? NotebookSessionShapeConfigDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#private_endpoint_id DatascienceNotebookSession#private_endpoint_id}.</summary>
        [JsiiProperty(name: "privateEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrivateEndpointId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceNotebookSessionNotebookSessionConfigurationDetails), fullyQualifiedName: "oci.datascienceNotebookSession.DatascienceNotebookSessionNotebookSessionConfigurationDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceNotebookSession.IDatascienceNotebookSessionNotebookSessionConfigurationDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#shape DatascienceNotebookSession#shape}.</summary>
            [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
            public string Shape
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#subnet_id DatascienceNotebookSession#subnet_id}.</summary>
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
            public string SubnetId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#block_storage_size_in_gbs DatascienceNotebookSession#block_storage_size_in_gbs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "blockStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BlockStorageSizeInGbs
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>notebook_session_shape_config_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#notebook_session_shape_config_details DatascienceNotebookSession#notebook_session_shape_config_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "notebookSessionShapeConfigDetails", typeJson: "{\"fqn\":\"oci.datascienceNotebookSession.DatascienceNotebookSessionNotebookSessionConfigurationDetailsNotebookSessionShapeConfigDetails\"}", isOptional: true)]
            public oci.DatascienceNotebookSession.IDatascienceNotebookSessionNotebookSessionConfigurationDetailsNotebookSessionShapeConfigDetails? NotebookSessionShapeConfigDetails
            {
                get => GetInstanceProperty<oci.DatascienceNotebookSession.IDatascienceNotebookSessionNotebookSessionConfigurationDetailsNotebookSessionShapeConfigDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#private_endpoint_id DatascienceNotebookSession#private_endpoint_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "privateEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivateEndpointId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
