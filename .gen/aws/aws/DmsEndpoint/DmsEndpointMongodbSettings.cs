using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DmsEndpoint
{
    [JsiiByValue(fqn: "aws.dmsEndpoint.DmsEndpointMongodbSettings")]
    public class DmsEndpointMongodbSettings : aws.DmsEndpoint.IDmsEndpointMongodbSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dms_endpoint#auth_mechanism DmsEndpoint#auth_mechanism}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authMechanism", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthMechanism
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dms_endpoint#auth_source DmsEndpoint#auth_source}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthSource
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dms_endpoint#auth_type DmsEndpoint#auth_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dms_endpoint#docs_to_investigate DmsEndpoint#docs_to_investigate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "docsToInvestigate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DocsToInvestigate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dms_endpoint#extract_doc_id DmsEndpoint#extract_doc_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "extractDocId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExtractDocId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dms_endpoint#nesting_level DmsEndpoint#nesting_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nestingLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NestingLevel
        {
            get;
            set;
        }

        private object? _useUpdateLookup;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dms_endpoint#use_update_lookup DmsEndpoint#use_update_lookup}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "useUpdateLookup", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? UseUpdateLookup
        {
            get => _useUpdateLookup;
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
                _useUpdateLookup = value;
            }
        }
    }
}
