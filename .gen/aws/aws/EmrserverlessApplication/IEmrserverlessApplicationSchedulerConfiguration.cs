using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrserverlessApplication
{
    [JsiiInterface(nativeType: typeof(IEmrserverlessApplicationSchedulerConfiguration), fullyQualifiedName: "aws.emrserverlessApplication.EmrserverlessApplicationSchedulerConfiguration")]
    public interface IEmrserverlessApplicationSchedulerConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/emrserverless_application#max_concurrent_runs EmrserverlessApplication#max_concurrent_runs}.</summary>
        [JsiiProperty(name: "maxConcurrentRuns", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxConcurrentRuns
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/emrserverless_application#queue_timeout_minutes EmrserverlessApplication#queue_timeout_minutes}.</summary>
        [JsiiProperty(name: "queueTimeoutMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? QueueTimeoutMinutes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrserverlessApplicationSchedulerConfiguration), fullyQualifiedName: "aws.emrserverlessApplication.EmrserverlessApplicationSchedulerConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.EmrserverlessApplication.IEmrserverlessApplicationSchedulerConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/emrserverless_application#max_concurrent_runs EmrserverlessApplication#max_concurrent_runs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxConcurrentRuns", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxConcurrentRuns
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/emrserverless_application#queue_timeout_minutes EmrserverlessApplication#queue_timeout_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "queueTimeoutMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? QueueTimeoutMinutes
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
