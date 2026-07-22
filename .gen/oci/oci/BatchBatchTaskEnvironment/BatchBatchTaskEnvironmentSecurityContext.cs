using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BatchBatchTaskEnvironment
{
    [JsiiByValue(fqn: "oci.batchBatchTaskEnvironment.BatchBatchTaskEnvironmentSecurityContext")]
    public class BatchBatchTaskEnvironmentSecurityContext : oci.BatchBatchTaskEnvironment.IBatchBatchTaskEnvironmentSecurityContext
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/batch_batch_task_environment#fs_group BatchBatchTaskEnvironment#fs_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fsGroup", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FsGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/batch_batch_task_environment#run_as_group BatchBatchTaskEnvironment#run_as_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "runAsGroup", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RunAsGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/batch_batch_task_environment#run_as_user BatchBatchTaskEnvironment#run_as_user}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "runAsUser", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RunAsUser
        {
            get;
            set;
        }
    }
}
