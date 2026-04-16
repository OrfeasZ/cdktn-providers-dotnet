using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace neon.Project
{
    [JsiiByValue(fqn: "neon.project.ProjectDefaultEndpointSettings")]
    public class ProjectDefaultEndpointSettings : neon.Project.IProjectDefaultEndpointSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#autoscaling_limit_max_cu Project#autoscaling_limit_max_cu}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoscalingLimitMaxCu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AutoscalingLimitMaxCu
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#autoscaling_limit_min_cu Project#autoscaling_limit_min_cu}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoscalingLimitMinCu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AutoscalingLimitMinCu
        {
            get;
            set;
        }

        /// <summary>Duration of inactivity in seconds after which the compute endpoint is automatically suspended.</summary>
        /// <remarks>
        /// The value 0 means use the global default.
        /// The value -1 means never suspend. The default value is 300 seconds (5 minutes).
        /// The maximum value is 604800 seconds (1 week)
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#suspend_timeout_seconds Project#suspend_timeout_seconds}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "suspendTimeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SuspendTimeoutSeconds
        {
            get;
            set;
        }
    }
}
