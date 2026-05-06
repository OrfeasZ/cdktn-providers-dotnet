using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OptimizerProfile
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.optimizerProfile.OptimizerProfileTargetTagsItems")]
    public class OptimizerProfileTargetTagsItems : oci.OptimizerProfile.IOptimizerProfileTargetTagsItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/optimizer_profile#tag_definition_name OptimizerProfile#tag_definition_name}.</summary>
        [JsiiProperty(name: "tagDefinitionName", typeJson: "{\"primitive\":\"string\"}")]
        public string TagDefinitionName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/optimizer_profile#tag_namespace_name OptimizerProfile#tag_namespace_name}.</summary>
        [JsiiProperty(name: "tagNamespaceName", typeJson: "{\"primitive\":\"string\"}")]
        public string TagNamespaceName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/optimizer_profile#tag_value_type OptimizerProfile#tag_value_type}.</summary>
        [JsiiProperty(name: "tagValueType", typeJson: "{\"primitive\":\"string\"}")]
        public string TagValueType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/optimizer_profile#tag_values OptimizerProfile#tag_values}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tagValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? TagValues
        {
            get;
            set;
        }
    }
}
