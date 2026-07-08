using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BatchBatchTaskEnvironment
{
    [JsiiInterface(nativeType: typeof(IBatchBatchTaskEnvironmentSecurityContext), fullyQualifiedName: "oci.batchBatchTaskEnvironment.BatchBatchTaskEnvironmentSecurityContext")]
    public interface IBatchBatchTaskEnvironmentSecurityContext
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/batch_batch_task_environment#fs_group BatchBatchTaskEnvironment#fs_group}.</summary>
        [JsiiProperty(name: "fsGroup", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FsGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/batch_batch_task_environment#run_as_group BatchBatchTaskEnvironment#run_as_group}.</summary>
        [JsiiProperty(name: "runAsGroup", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RunAsGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/batch_batch_task_environment#run_as_user BatchBatchTaskEnvironment#run_as_user}.</summary>
        [JsiiProperty(name: "runAsUser", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RunAsUser
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchBatchTaskEnvironmentSecurityContext), fullyQualifiedName: "oci.batchBatchTaskEnvironment.BatchBatchTaskEnvironmentSecurityContext")]
        internal sealed class _Proxy : DeputyBase, oci.BatchBatchTaskEnvironment.IBatchBatchTaskEnvironmentSecurityContext
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/batch_batch_task_environment#fs_group BatchBatchTaskEnvironment#fs_group}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fsGroup", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FsGroup
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/batch_batch_task_environment#run_as_group BatchBatchTaskEnvironment#run_as_group}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "runAsGroup", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RunAsGroup
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/batch_batch_task_environment#run_as_user BatchBatchTaskEnvironment#run_as_user}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "runAsUser", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RunAsUser
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
