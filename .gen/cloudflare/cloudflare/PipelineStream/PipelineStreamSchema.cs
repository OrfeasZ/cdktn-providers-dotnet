using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PipelineStream
{
    [JsiiByValue(fqn: "cloudflare.pipelineStream.PipelineStreamSchema")]
    public class PipelineStreamSchema : cloudflare.PipelineStream.IPipelineStreamSchema
    {
        private object? _fields;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#fields PipelineStream#fields}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pipelineStream.PipelineStreamSchemaFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Fields
        {
            get => _fields;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.PipelineStream.IPipelineStreamSchemaFields[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.PipelineStream.IPipelineStreamSchemaFields).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _fields = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#format PipelineStream#format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "format", typeJson: "{\"fqn\":\"cloudflare.pipelineStream.PipelineStreamSchemaFormat\"}", isOptional: true)]
        public cloudflare.PipelineStream.IPipelineStreamSchemaFormat? Format
        {
            get;
            set;
        }

        private object? _inferred;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#inferred PipelineStream#inferred}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inferred", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Inferred
        {
            get => _inferred;
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
                _inferred = value;
            }
        }
    }
}
