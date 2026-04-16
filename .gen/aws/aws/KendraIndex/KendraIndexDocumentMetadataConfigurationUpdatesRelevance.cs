using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraIndex
{
    [JsiiByValue(fqn: "aws.kendraIndex.KendraIndexDocumentMetadataConfigurationUpdatesRelevance")]
    public class KendraIndexDocumentMetadataConfigurationUpdatesRelevance : aws.KendraIndex.IKendraIndexDocumentMetadataConfigurationUpdatesRelevance
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/kendra_index#duration KendraIndex#duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Duration
        {
            get;
            set;
        }

        private object? _freshness;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/kendra_index#freshness KendraIndex#freshness}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "freshness", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Freshness
        {
            get => _freshness;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _freshness = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/kendra_index#importance KendraIndex#importance}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "importance", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Importance
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/kendra_index#rank_order KendraIndex#rank_order}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rankOrder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RankOrder
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/kendra_index#values_importance_map KendraIndex#values_importance_map}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "valuesImportanceMap", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, double>? ValuesImportanceMap
        {
            get;
            set;
        }
    }
}
