using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OptimizerProfile
{
    [JsiiInterface(nativeType: typeof(IOptimizerProfileLevelsConfigurationItems), fullyQualifiedName: "oci.optimizerProfile.OptimizerProfileLevelsConfigurationItems")]
    public interface IOptimizerProfileLevelsConfigurationItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/optimizer_profile#level OptimizerProfile#level}.</summary>
        [JsiiProperty(name: "level", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Level
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/optimizer_profile#recommendation_id OptimizerProfile#recommendation_id}.</summary>
        [JsiiProperty(name: "recommendationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RecommendationId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOptimizerProfileLevelsConfigurationItems), fullyQualifiedName: "oci.optimizerProfile.OptimizerProfileLevelsConfigurationItems")]
        internal sealed class _Proxy : DeputyBase, oci.OptimizerProfile.IOptimizerProfileLevelsConfigurationItems
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/optimizer_profile#level OptimizerProfile#level}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "level", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Level
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/optimizer_profile#recommendation_id OptimizerProfile#recommendation_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "recommendationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RecommendationId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
