using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceNotebookSession
{
    [JsiiInterface(nativeType: typeof(IDatascienceNotebookSessionNotebookSessionStorageMountConfigurationDetailsListStruct), fullyQualifiedName: "oci.datascienceNotebookSession.DatascienceNotebookSessionNotebookSessionStorageMountConfigurationDetailsListStruct")]
    public interface IDatascienceNotebookSessionNotebookSessionStorageMountConfigurationDetailsListStruct
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#destination_directory_name DatascienceNotebookSession#destination_directory_name}.</summary>
        [JsiiProperty(name: "destinationDirectoryName", typeJson: "{\"primitive\":\"string\"}")]
        string DestinationDirectoryName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#storage_type DatascienceNotebookSession#storage_type}.</summary>
        [JsiiProperty(name: "storageType", typeJson: "{\"primitive\":\"string\"}")]
        string StorageType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#bucket DatascienceNotebookSession#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Bucket
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#destination_path DatascienceNotebookSession#destination_path}.</summary>
        [JsiiProperty(name: "destinationPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DestinationPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#export_id DatascienceNotebookSession#export_id}.</summary>
        [JsiiProperty(name: "exportId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExportId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#mount_target_id DatascienceNotebookSession#mount_target_id}.</summary>
        [JsiiProperty(name: "mountTargetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MountTargetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#namespace DatascienceNotebookSession#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Namespace
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#prefix DatascienceNotebookSession#prefix}.</summary>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Prefix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceNotebookSessionNotebookSessionStorageMountConfigurationDetailsListStruct), fullyQualifiedName: "oci.datascienceNotebookSession.DatascienceNotebookSessionNotebookSessionStorageMountConfigurationDetailsListStruct")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceNotebookSession.IDatascienceNotebookSessionNotebookSessionStorageMountConfigurationDetailsListStruct
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#destination_directory_name DatascienceNotebookSession#destination_directory_name}.</summary>
            [JsiiProperty(name: "destinationDirectoryName", typeJson: "{\"primitive\":\"string\"}")]
            public string DestinationDirectoryName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#storage_type DatascienceNotebookSession#storage_type}.</summary>
            [JsiiProperty(name: "storageType", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#bucket DatascienceNotebookSession#bucket}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Bucket
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#destination_path DatascienceNotebookSession#destination_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DestinationPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#export_id DatascienceNotebookSession#export_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "exportId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExportId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#mount_target_id DatascienceNotebookSession#mount_target_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mountTargetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MountTargetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#namespace DatascienceNotebookSession#namespace}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Namespace
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#prefix DatascienceNotebookSession#prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Prefix
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
