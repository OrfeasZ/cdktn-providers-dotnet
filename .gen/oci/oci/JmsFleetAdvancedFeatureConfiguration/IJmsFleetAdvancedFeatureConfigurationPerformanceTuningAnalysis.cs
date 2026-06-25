using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsFleetAdvancedFeatureConfiguration
{
    [JsiiInterface(nativeType: typeof(IJmsFleetAdvancedFeatureConfigurationPerformanceTuningAnalysis), fullyQualifiedName: "oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationPerformanceTuningAnalysis")]
    public interface IJmsFleetAdvancedFeatureConfigurationPerformanceTuningAnalysis
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/jms_fleet_advanced_feature_configuration#is_enabled JmsFleetAdvancedFeatureConfiguration#is_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IJmsFleetAdvancedFeatureConfigurationPerformanceTuningAnalysis), fullyQualifiedName: "oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationPerformanceTuningAnalysis")]
        internal sealed class _Proxy : DeputyBase, oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationPerformanceTuningAnalysis
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/jms_fleet_advanced_feature_configuration#is_enabled JmsFleetAdvancedFeatureConfiguration#is_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
