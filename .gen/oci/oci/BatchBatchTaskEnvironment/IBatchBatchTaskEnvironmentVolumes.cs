using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BatchBatchTaskEnvironment
{
    [JsiiInterface(nativeType: typeof(IBatchBatchTaskEnvironmentVolumes), fullyQualifiedName: "oci.batchBatchTaskEnvironment.BatchBatchTaskEnvironmentVolumes")]
    public interface IBatchBatchTaskEnvironmentVolumes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/batch_batch_task_environment#local_mount_directory_path BatchBatchTaskEnvironment#local_mount_directory_path}.</summary>
        [JsiiProperty(name: "localMountDirectoryPath", typeJson: "{\"primitive\":\"string\"}")]
        string LocalMountDirectoryPath
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/batch_batch_task_environment#mount_target_export_path BatchBatchTaskEnvironment#mount_target_export_path}.</summary>
        [JsiiProperty(name: "mountTargetExportPath", typeJson: "{\"primitive\":\"string\"}")]
        string MountTargetExportPath
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/batch_batch_task_environment#mount_target_fqdn BatchBatchTaskEnvironment#mount_target_fqdn}.</summary>
        [JsiiProperty(name: "mountTargetFqdn", typeJson: "{\"primitive\":\"string\"}")]
        string MountTargetFqdn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/batch_batch_task_environment#name BatchBatchTaskEnvironment#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/batch_batch_task_environment#type BatchBatchTaskEnvironment#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchBatchTaskEnvironmentVolumes), fullyQualifiedName: "oci.batchBatchTaskEnvironment.BatchBatchTaskEnvironmentVolumes")]
        internal sealed class _Proxy : DeputyBase, oci.BatchBatchTaskEnvironment.IBatchBatchTaskEnvironmentVolumes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/batch_batch_task_environment#local_mount_directory_path BatchBatchTaskEnvironment#local_mount_directory_path}.</summary>
            [JsiiProperty(name: "localMountDirectoryPath", typeJson: "{\"primitive\":\"string\"}")]
            public string LocalMountDirectoryPath
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/batch_batch_task_environment#mount_target_export_path BatchBatchTaskEnvironment#mount_target_export_path}.</summary>
            [JsiiProperty(name: "mountTargetExportPath", typeJson: "{\"primitive\":\"string\"}")]
            public string MountTargetExportPath
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/batch_batch_task_environment#mount_target_fqdn BatchBatchTaskEnvironment#mount_target_fqdn}.</summary>
            [JsiiProperty(name: "mountTargetFqdn", typeJson: "{\"primitive\":\"string\"}")]
            public string MountTargetFqdn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/batch_batch_task_environment#name BatchBatchTaskEnvironment#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/batch_batch_task_environment#type BatchBatchTaskEnvironment#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
