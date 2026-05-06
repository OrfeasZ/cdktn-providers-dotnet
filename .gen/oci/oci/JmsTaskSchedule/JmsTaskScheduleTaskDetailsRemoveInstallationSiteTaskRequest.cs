using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsTaskSchedule
{
    [JsiiByValue(fqn: "oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequest")]
    public class JmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequest : oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequest
    {
        private object? _installationSites;

        /// <summary>installation_sites block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#installation_sites JmsTaskSchedule#installation_sites}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "installationSites", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequestInstallationSites\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? InstallationSites
        {
            get => _installationSites;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequestInstallationSites[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequestInstallationSites).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _installationSites = value;
            }
        }
    }
}
