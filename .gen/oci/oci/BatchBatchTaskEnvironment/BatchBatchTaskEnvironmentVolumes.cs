using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BatchBatchTaskEnvironment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.batchBatchTaskEnvironment.BatchBatchTaskEnvironmentVolumes")]
    public class BatchBatchTaskEnvironmentVolumes : oci.BatchBatchTaskEnvironment.IBatchBatchTaskEnvironmentVolumes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/batch_batch_task_environment#local_mount_directory_path BatchBatchTaskEnvironment#local_mount_directory_path}.</summary>
        [JsiiProperty(name: "localMountDirectoryPath", typeJson: "{\"primitive\":\"string\"}")]
        public string LocalMountDirectoryPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/batch_batch_task_environment#mount_target_export_path BatchBatchTaskEnvironment#mount_target_export_path}.</summary>
        [JsiiProperty(name: "mountTargetExportPath", typeJson: "{\"primitive\":\"string\"}")]
        public string MountTargetExportPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/batch_batch_task_environment#mount_target_fqdn BatchBatchTaskEnvironment#mount_target_fqdn}.</summary>
        [JsiiProperty(name: "mountTargetFqdn", typeJson: "{\"primitive\":\"string\"}")]
        public string MountTargetFqdn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/batch_batch_task_environment#name BatchBatchTaskEnvironment#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/batch_batch_task_environment#type BatchBatchTaskEnvironment#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
