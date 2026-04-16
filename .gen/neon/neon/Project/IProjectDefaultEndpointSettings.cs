using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace neon.Project
{
    [JsiiInterface(nativeType: typeof(IProjectDefaultEndpointSettings), fullyQualifiedName: "neon.project.ProjectDefaultEndpointSettings")]
    public interface IProjectDefaultEndpointSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#autoscaling_limit_max_cu Project#autoscaling_limit_max_cu}.</summary>
        [JsiiProperty(name: "autoscalingLimitMaxCu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AutoscalingLimitMaxCu
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#autoscaling_limit_min_cu Project#autoscaling_limit_min_cu}.</summary>
        [JsiiProperty(name: "autoscalingLimitMinCu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AutoscalingLimitMinCu
        {
            get
            {
                return null;
            }
        }

        /// <summary>Duration of inactivity in seconds after which the compute endpoint is automatically suspended.</summary>
        /// <remarks>
        /// The value 0 means use the global default.
        /// The value -1 means never suspend. The default value is 300 seconds (5 minutes).
        /// The maximum value is 604800 seconds (1 week)
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#suspend_timeout_seconds Project#suspend_timeout_seconds}
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

        [JsiiTypeProxy(nativeType: typeof(IProjectDefaultEndpointSettings), fullyQualifiedName: "neon.project.ProjectDefaultEndpointSettings")]
        internal sealed class _Proxy : DeputyBase, neon.Project.IProjectDefaultEndpointSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#autoscaling_limit_max_cu Project#autoscaling_limit_max_cu}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoscalingLimitMaxCu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AutoscalingLimitMaxCu
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#autoscaling_limit_min_cu Project#autoscaling_limit_min_cu}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoscalingLimitMinCu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AutoscalingLimitMinCu
            {
                get => GetInstanceProperty<double?>();
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
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
