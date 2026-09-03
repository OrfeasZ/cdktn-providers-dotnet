using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiProject
{
    [JsiiByValue(fqn: "oci.generativeAiProject.GenerativeAiProjectLongTermMemoryConfig")]
    public class GenerativeAiProjectLongTermMemoryConfig : oci.GenerativeAiProject.IGenerativeAiProjectLongTermMemoryConfig
    {
        /// <summary>standard_long_term_memory_strategy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_project#standard_long_term_memory_strategy GenerativeAiProject#standard_long_term_memory_strategy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "standardLongTermMemoryStrategy", typeJson: "{\"fqn\":\"oci.generativeAiProject.GenerativeAiProjectLongTermMemoryConfigStandardLongTermMemoryStrategy\"}", isOptional: true)]
        public oci.GenerativeAiProject.IGenerativeAiProjectLongTermMemoryConfigStandardLongTermMemoryStrategy? StandardLongTermMemoryStrategy
        {
            get;
            set;
        }
    }
}
