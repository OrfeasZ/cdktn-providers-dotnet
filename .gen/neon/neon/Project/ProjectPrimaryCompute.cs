using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace neon.Project
{
    [JsiiByValue(fqn: "neon.project.ProjectPrimaryCompute")]
    public class ProjectPrimaryCompute : neon.Project.IProjectPrimaryCompute
    {
        /// <summary>Maximal value of the autoscaling limit for the primary project compute.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.17.0/docs/resources/project#autoscaling_limit_max_cu Project#autoscaling_limit_max_cu}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "autoscalingLimitMaxCu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AutoscalingLimitMaxCu
        {
            get;
            set;
        }

        /// <summary>Minimal value of the autoscaling limit for the primary project compute.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.17.0/docs/resources/project#autoscaling_limit_min_cu Project#autoscaling_limit_min_cu}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "autoscalingLimitMinCu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AutoscalingLimitMinCu
        {
            get;
            set;
        }

        /// <summary>Compute name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.17.0/docs/resources/project#name Project#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Duration of inactivity in seconds after which the default compute endpoint is automatically suspended.</summary>
        /// <remarks>
        /// The value 0 means use the global default.
        /// The value -1 means never suspend. The default value is 300 seconds (5 minutes).
        /// The maximum value is 604800 seconds (1 week)
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.17.0/docs/resources/project#suspend_timeout_seconds Project#suspend_timeout_seconds}
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
