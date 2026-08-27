using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiProject
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiProjectShortTermMemoryOptimizationConfig), fullyQualifiedName: "oci.generativeAiProject.GenerativeAiProjectShortTermMemoryOptimizationConfig")]
    public interface IGenerativeAiProjectShortTermMemoryOptimizationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/generative_ai_project#is_enabled GenerativeAiProject#is_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsEnabled
        {
            get;
        }

        /// <summary>condenser_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/generative_ai_project#condenser_config GenerativeAiProject#condenser_config}
        /// </remarks>
        [JsiiProperty(name: "condenserConfig", typeJson: "{\"fqn\":\"oci.generativeAiProject.GenerativeAiProjectShortTermMemoryOptimizationConfigCondenserConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.GenerativeAiProject.IGenerativeAiProjectShortTermMemoryOptimizationConfigCondenserConfig? CondenserConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiProjectShortTermMemoryOptimizationConfig), fullyQualifiedName: "oci.generativeAiProject.GenerativeAiProjectShortTermMemoryOptimizationConfig")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiProject.IGenerativeAiProjectShortTermMemoryOptimizationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/generative_ai_project#is_enabled GenerativeAiProject#is_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>condenser_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/generative_ai_project#condenser_config GenerativeAiProject#condenser_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "condenserConfig", typeJson: "{\"fqn\":\"oci.generativeAiProject.GenerativeAiProjectShortTermMemoryOptimizationConfigCondenserConfig\"}", isOptional: true)]
            public oci.GenerativeAiProject.IGenerativeAiProjectShortTermMemoryOptimizationConfigCondenserConfig? CondenserConfig
            {
                get => GetInstanceProperty<oci.GenerativeAiProject.IGenerativeAiProjectShortTermMemoryOptimizationConfigCondenserConfig?>();
            }
        }
    }
}
