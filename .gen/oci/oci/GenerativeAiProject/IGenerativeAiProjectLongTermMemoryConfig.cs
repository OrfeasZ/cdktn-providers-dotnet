using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiProject
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiProjectLongTermMemoryConfig), fullyQualifiedName: "oci.generativeAiProject.GenerativeAiProjectLongTermMemoryConfig")]
    public interface IGenerativeAiProjectLongTermMemoryConfig
    {
        /// <summary>standard_long_term_memory_strategy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/generative_ai_project#standard_long_term_memory_strategy GenerativeAiProject#standard_long_term_memory_strategy}
        /// </remarks>
        [JsiiProperty(name: "standardLongTermMemoryStrategy", typeJson: "{\"fqn\":\"oci.generativeAiProject.GenerativeAiProjectLongTermMemoryConfigStandardLongTermMemoryStrategy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.GenerativeAiProject.IGenerativeAiProjectLongTermMemoryConfigStandardLongTermMemoryStrategy? StandardLongTermMemoryStrategy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiProjectLongTermMemoryConfig), fullyQualifiedName: "oci.generativeAiProject.GenerativeAiProjectLongTermMemoryConfig")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiProject.IGenerativeAiProjectLongTermMemoryConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>standard_long_term_memory_strategy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/generative_ai_project#standard_long_term_memory_strategy GenerativeAiProject#standard_long_term_memory_strategy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "standardLongTermMemoryStrategy", typeJson: "{\"fqn\":\"oci.generativeAiProject.GenerativeAiProjectLongTermMemoryConfigStandardLongTermMemoryStrategy\"}", isOptional: true)]
            public oci.GenerativeAiProject.IGenerativeAiProjectLongTermMemoryConfigStandardLongTermMemoryStrategy? StandardLongTermMemoryStrategy
            {
                get => GetInstanceProperty<oci.GenerativeAiProject.IGenerativeAiProjectLongTermMemoryConfigStandardLongTermMemoryStrategy?>();
            }
        }
    }
}
