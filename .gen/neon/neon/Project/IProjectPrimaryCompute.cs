using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace neon.Project
{
    [JsiiInterface(nativeType: typeof(IProjectPrimaryCompute), fullyQualifiedName: "neon.project.ProjectPrimaryCompute")]
    public interface IProjectPrimaryCompute
    {
        /// <summary>Maximal value of the autoscaling limit for the primary project compute.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.17.0/docs/resources/project#autoscaling_limit_max_cu Project#autoscaling_limit_max_cu}
        /// </remarks>
        [JsiiProperty(name: "autoscalingLimitMaxCu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AutoscalingLimitMaxCu
        {
            get
            {
                return null;
            }
        }

        /// <summary>Minimal value of the autoscaling limit for the primary project compute.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.17.0/docs/resources/project#autoscaling_limit_min_cu Project#autoscaling_limit_min_cu}
        /// </remarks>
        [JsiiProperty(name: "autoscalingLimitMinCu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AutoscalingLimitMinCu
        {
            get
            {
                return null;
            }
        }

        /// <summary>Compute name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.17.0/docs/resources/project#name Project#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Duration of inactivity in seconds after which the default compute endpoint is automatically suspended.</summary>
        /// <remarks>
        /// The value 0 means use the global default.
        /// The value -1 means never suspend. The default value is 300 seconds (5 minutes).
        /// The maximum value is 604800 seconds (1 week)
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.17.0/docs/resources/project#suspend_timeout_seconds Project#suspend_timeout_seconds}
        /// </remarks>
        [JsiiProperty(name: "suspendTimeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SuspendTimeoutSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IProjectPrimaryCompute), fullyQualifiedName: "neon.project.ProjectPrimaryCompute")]
        internal sealed class _Proxy : DeputyBase, neon.Project.IProjectPrimaryCompute
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Maximal value of the autoscaling limit for the primary project compute.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.17.0/docs/resources/project#autoscaling_limit_max_cu Project#autoscaling_limit_max_cu}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoscalingLimitMaxCu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AutoscalingLimitMaxCu
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Minimal value of the autoscaling limit for the primary project compute.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.17.0/docs/resources/project#autoscaling_limit_min_cu Project#autoscaling_limit_min_cu}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoscalingLimitMinCu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AutoscalingLimitMinCu
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Compute name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.17.0/docs/resources/project#name Project#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
