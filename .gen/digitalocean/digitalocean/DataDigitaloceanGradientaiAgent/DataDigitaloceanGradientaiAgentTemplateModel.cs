using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanGradientaiAgent
{
    [JsiiByValue(fqn: "digitalocean.dataDigitaloceanGradientaiAgent.DataDigitaloceanGradientaiAgentTemplateModel")]
    public class DataDigitaloceanGradientaiAgentTemplateModel : digitalocean.DataDigitaloceanGradientaiAgent.IDataDigitaloceanGradientaiAgentTemplateModel
    {
        private object? _agreement;

        /// <summary>agreement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#agreement DataDigitaloceanGradientaiAgent#agreement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "agreement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgent.DataDigitaloceanGradientaiAgentTemplateModelAgreement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Agreement
        {
            get => _agreement;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.DataDigitaloceanGradientaiAgent.IDataDigitaloceanGradientaiAgentTemplateModelAgreement[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.DataDigitaloceanGradientaiAgent.IDataDigitaloceanGradientaiAgentTemplateModelAgreement).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _agreement = value;
            }
        }

        /// <summary>Inference name of the model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#inference_name DataDigitaloceanGradientaiAgent#inference_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inferenceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InferenceName
        {
            get;
            set;
        }

        /// <summary>Infernce version of the model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#inference_version DataDigitaloceanGradientaiAgent#inference_version}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inferenceVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InferenceVersion
        {
            get;
            set;
        }

        private object? _isFoundational;

        /// <summary>Indicates if the Model Base is foundational.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#is_foundational DataDigitaloceanGradientaiAgent#is_foundational}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isFoundational", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsFoundational
        {
            get => _isFoundational;
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
                _isFoundational = value;
            }
        }

        /// <summary>Name of the Knowledge Base.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#name DataDigitaloceanGradientaiAgent#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Parent UUID of the Model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#parent_uuid DataDigitaloceanGradientaiAgent#parent_uuid}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parentUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ParentUuid
        {
            get;
            set;
        }

        /// <summary>Provider of the Model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#provider DataDigitaloceanGradientaiAgent#provider}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Provider
        {
            get;
            set;
        }

        private object? _uploadComplete;

        /// <summary>Indicates if the Model upload is complete.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#upload_complete DataDigitaloceanGradientaiAgent#upload_complete}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "uploadComplete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? UploadComplete
        {
            get => _uploadComplete;
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
                _uploadComplete = value;
            }
        }

        /// <summary>URL of the Model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#url DataDigitaloceanGradientaiAgent#url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Url
        {
            get;
            set;
        }

        /// <summary>List of Usecases for the Model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#usecases DataDigitaloceanGradientaiAgent#usecases}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "usecases", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Usecases
        {
            get;
            set;
        }

        private object? _versions;

        /// <summary>versions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#versions DataDigitaloceanGradientaiAgent#versions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "versions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgent.DataDigitaloceanGradientaiAgentTemplateModelVersions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Versions
        {
            get => _versions;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.DataDigitaloceanGradientaiAgent.IDataDigitaloceanGradientaiAgentTemplateModelVersions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.DataDigitaloceanGradientaiAgent.IDataDigitaloceanGradientaiAgentTemplateModelVersions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _versions = value;
            }
        }
    }
}
