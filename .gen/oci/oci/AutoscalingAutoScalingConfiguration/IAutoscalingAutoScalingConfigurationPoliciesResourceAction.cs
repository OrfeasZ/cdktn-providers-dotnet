using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AutoscalingAutoScalingConfiguration
{
    [JsiiInterface(nativeType: typeof(IAutoscalingAutoScalingConfigurationPoliciesResourceAction), fullyQualifiedName: "oci.autoscalingAutoScalingConfiguration.AutoscalingAutoScalingConfigurationPoliciesResourceAction")]
    public interface IAutoscalingAutoScalingConfigurationPoliciesResourceAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/autoscaling_auto_scaling_configuration#action AutoscalingAutoScalingConfiguration#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        string Action
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/autoscaling_auto_scaling_configuration#action_type AutoscalingAutoScalingConfiguration#action_type}.</summary>
        [JsiiProperty(name: "actionType", typeJson: "{\"primitive\":\"string\"}")]
        string ActionType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingAutoScalingConfigurationPoliciesResourceAction), fullyQualifiedName: "oci.autoscalingAutoScalingConfiguration.AutoscalingAutoScalingConfigurationPoliciesResourceAction")]
        internal sealed class _Proxy : DeputyBase, oci.AutoscalingAutoScalingConfiguration.IAutoscalingAutoScalingConfigurationPoliciesResourceAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/autoscaling_auto_scaling_configuration#action AutoscalingAutoScalingConfiguration#action}.</summary>
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
            public string Action
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/autoscaling_auto_scaling_configuration#action_type AutoscalingAutoScalingConfiguration#action_type}.</summary>
            [JsiiProperty(name: "actionType", typeJson: "{\"primitive\":\"string\"}")]
            public string ActionType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
