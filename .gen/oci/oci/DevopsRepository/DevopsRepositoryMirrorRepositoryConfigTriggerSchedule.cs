using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsRepository
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.devopsRepository.DevopsRepositoryMirrorRepositoryConfigTriggerSchedule")]
    public class DevopsRepositoryMirrorRepositoryConfigTriggerSchedule : oci.DevopsRepository.IDevopsRepositoryMirrorRepositoryConfigTriggerSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_repository#schedule_type DevopsRepository#schedule_type}.</summary>
        [JsiiProperty(name: "scheduleType", typeJson: "{\"primitive\":\"string\"}")]
        public string ScheduleType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_repository#custom_schedule DevopsRepository#custom_schedule}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customSchedule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomSchedule
        {
            get;
            set;
        }
    }
}
