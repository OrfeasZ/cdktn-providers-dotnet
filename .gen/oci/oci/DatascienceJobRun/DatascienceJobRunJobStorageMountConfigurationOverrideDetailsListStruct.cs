using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceJobRun
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.datascienceJobRun.DatascienceJobRunJobStorageMountConfigurationOverrideDetailsListStruct")]
    public class DatascienceJobRunJobStorageMountConfigurationOverrideDetailsListStruct : oci.DatascienceJobRun.IDatascienceJobRunJobStorageMountConfigurationOverrideDetailsListStruct
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/datascience_job_run#destination_directory_name DatascienceJobRun#destination_directory_name}.</summary>
        [JsiiProperty(name: "destinationDirectoryName", typeJson: "{\"primitive\":\"string\"}")]
        public string DestinationDirectoryName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/datascience_job_run#storage_type DatascienceJobRun#storage_type}.</summary>
        [JsiiProperty(name: "storageType", typeJson: "{\"primitive\":\"string\"}")]
        public string StorageType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/datascience_job_run#bucket DatascienceJobRun#bucket}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/datascience_job_run#destination_path DatascienceJobRun#destination_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/datascience_job_run#export_id DatascienceJobRun#export_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "exportId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExportId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/datascience_job_run#mount_target_id DatascienceJobRun#mount_target_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mountTargetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MountTargetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/datascience_job_run#namespace DatascienceJobRun#namespace}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Namespace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/datascience_job_run#prefix DatascienceJobRun#prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Prefix
        {
            get;
            set;
        }
    }
}
