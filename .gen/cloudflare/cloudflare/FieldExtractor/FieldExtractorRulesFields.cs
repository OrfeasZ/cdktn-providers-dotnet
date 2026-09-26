using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.FieldExtractor
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.fieldExtractor.FieldExtractorRulesFields")]
    public class FieldExtractorRulesFields : cloudflare.FieldExtractor.IFieldExtractorRulesFields
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/field_extractor#expression FieldExtractor#expression}.</summary>
        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}")]
        public string Expression
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/field_extractor#name FieldExtractor#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
