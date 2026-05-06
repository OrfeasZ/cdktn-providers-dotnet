using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceJob
{
    [JsiiInterface(nativeType: typeof(IDatascienceJobJobStorageMountConfigurationDetailsListStruct), fullyQualifiedName: "oci.datascienceJob.DatascienceJobJobStorageMountConfigurationDetailsListStruct")]
    public interface IDatascienceJobJobStorageMountConfigurationDetailsListStruct
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#destination_directory_name DatascienceJob#destination_directory_name}.</summary>
        [JsiiProperty(name: "destinationDirectoryName", typeJson: "{\"primitive\":\"string\"}")]
        string DestinationDirectoryName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#storage_type DatascienceJob#storage_type}.</summary>
        [JsiiProperty(name: "storageType", typeJson: "{\"primitive\":\"string\"}")]
        string StorageType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#bucket DatascienceJob#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Bucket
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#destination_path DatascienceJob#destination_path}.</summary>
        [JsiiProperty(name: "destinationPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DestinationPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#export_id DatascienceJob#export_id}.</summary>
        [JsiiProperty(name: "exportId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExportId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#mount_target_id DatascienceJob#mount_target_id}.</summary>
        [JsiiProperty(name: "mountTargetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MountTargetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#namespace DatascienceJob#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Namespace
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#prefix DatascienceJob#prefix}.</summary>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Prefix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceJobJobStorageMountConfigurationDetailsListStruct), fullyQualifiedName: "oci.datascienceJob.DatascienceJobJobStorageMountConfigurationDetailsListStruct")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceJob.IDatascienceJobJobStorageMountConfigurationDetailsListStruct
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#destination_directory_name DatascienceJob#destination_directory_name}.</summary>
            [JsiiProperty(name: "destinationDirectoryName", typeJson: "{\"primitive\":\"string\"}")]
            public string DestinationDirectoryName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#storage_type DatascienceJob#storage_type}.</summary>
            [JsiiProperty(name: "storageType", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#bucket DatascienceJob#bucket}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Bucket
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#destination_path DatascienceJob#destination_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DestinationPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#export_id DatascienceJob#export_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "exportId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExportId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#mount_target_id DatascienceJob#mount_target_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mountTargetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MountTargetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#namespace DatascienceJob#namespace}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Namespace
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#prefix DatascienceJob#prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Prefix
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
