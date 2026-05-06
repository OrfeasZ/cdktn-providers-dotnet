using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsRepository
{
    [JsiiInterface(nativeType: typeof(IDevopsRepositoryMirrorRepositoryConfigTriggerSchedule), fullyQualifiedName: "oci.devopsRepository.DevopsRepositoryMirrorRepositoryConfigTriggerSchedule")]
    public interface IDevopsRepositoryMirrorRepositoryConfigTriggerSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_repository#schedule_type DevopsRepository#schedule_type}.</summary>
        [JsiiProperty(name: "scheduleType", typeJson: "{\"primitive\":\"string\"}")]
        string ScheduleType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_repository#custom_schedule DevopsRepository#custom_schedule}.</summary>
        [JsiiProperty(name: "customSchedule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomSchedule
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsRepositoryMirrorRepositoryConfigTriggerSchedule), fullyQualifiedName: "oci.devopsRepository.DevopsRepositoryMirrorRepositoryConfigTriggerSchedule")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsRepository.IDevopsRepositoryMirrorRepositoryConfigTriggerSchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_repository#schedule_type DevopsRepository#schedule_type}.</summary>
            [JsiiProperty(name: "scheduleType", typeJson: "{\"primitive\":\"string\"}")]
            public string ScheduleType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_repository#custom_schedule DevopsRepository#custom_schedule}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customSchedule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomSchedule
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
