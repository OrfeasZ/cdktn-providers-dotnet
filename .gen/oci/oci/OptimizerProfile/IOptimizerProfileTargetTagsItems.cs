using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OptimizerProfile
{
    [JsiiInterface(nativeType: typeof(IOptimizerProfileTargetTagsItems), fullyQualifiedName: "oci.optimizerProfile.OptimizerProfileTargetTagsItems")]
    public interface IOptimizerProfileTargetTagsItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/optimizer_profile#tag_definition_name OptimizerProfile#tag_definition_name}.</summary>
        [JsiiProperty(name: "tagDefinitionName", typeJson: "{\"primitive\":\"string\"}")]
        string TagDefinitionName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/optimizer_profile#tag_namespace_name OptimizerProfile#tag_namespace_name}.</summary>
        [JsiiProperty(name: "tagNamespaceName", typeJson: "{\"primitive\":\"string\"}")]
        string TagNamespaceName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/optimizer_profile#tag_value_type OptimizerProfile#tag_value_type}.</summary>
        [JsiiProperty(name: "tagValueType", typeJson: "{\"primitive\":\"string\"}")]
        string TagValueType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/optimizer_profile#tag_values OptimizerProfile#tag_values}.</summary>
        [JsiiProperty(name: "tagValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TagValues
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOptimizerProfileTargetTagsItems), fullyQualifiedName: "oci.optimizerProfile.OptimizerProfileTargetTagsItems")]
        internal sealed class _Proxy : DeputyBase, oci.OptimizerProfile.IOptimizerProfileTargetTagsItems
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/optimizer_profile#tag_definition_name OptimizerProfile#tag_definition_name}.</summary>
            [JsiiProperty(name: "tagDefinitionName", typeJson: "{\"primitive\":\"string\"}")]
            public string TagDefinitionName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/optimizer_profile#tag_namespace_name OptimizerProfile#tag_namespace_name}.</summary>
            [JsiiProperty(name: "tagNamespaceName", typeJson: "{\"primitive\":\"string\"}")]
            public string TagNamespaceName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/optimizer_profile#tag_value_type OptimizerProfile#tag_value_type}.</summary>
            [JsiiProperty(name: "tagValueType", typeJson: "{\"primitive\":\"string\"}")]
            public string TagValueType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/optimizer_profile#tag_values OptimizerProfile#tag_values}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tagValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TagValues
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
