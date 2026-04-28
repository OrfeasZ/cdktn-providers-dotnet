using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanGradientaiAgent
{
    [JsiiInterface(nativeType: typeof(IDataDigitaloceanGradientaiAgentModel), fullyQualifiedName: "digitalocean.dataDigitaloceanGradientaiAgent.DataDigitaloceanGradientaiAgentModel")]
    public interface IDataDigitaloceanGradientaiAgentModel
    {
        /// <summary>agreement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_agent#agreement DataDigitaloceanGradientaiAgent#agreement}
        /// </remarks>
        [JsiiProperty(name: "agreement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgent.DataDigitaloceanGradientaiAgentModelAgreement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Agreement
        {
            get
            {
                return null;
            }
        }

        /// <summary>Inference name of the model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_agent#inference_name DataDigitaloceanGradientaiAgent#inference_name}
        /// </remarks>
        [JsiiProperty(name: "inferenceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InferenceName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Infernce version of the model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_agent#inference_version DataDigitaloceanGradientaiAgent#inference_version}
        /// </remarks>
        [JsiiProperty(name: "inferenceVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InferenceVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicates if the Model Base is foundational.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_agent#is_foundational DataDigitaloceanGradientaiAgent#is_foundational}
        /// </remarks>
        [JsiiProperty(name: "isFoundational", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsFoundational
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the Knowledge Base.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_agent#name DataDigitaloceanGradientaiAgent#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Parent UUID of the Model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_agent#parent_uuid DataDigitaloceanGradientaiAgent#parent_uuid}
        /// </remarks>
        [JsiiProperty(name: "parentUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ParentUuid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Provider of the Model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_agent#provider DataDigitaloceanGradientaiAgent#provider}
        /// </remarks>
        [JsiiProperty(name: "provider", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Provider
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicates if the Model upload is complete.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_agent#upload_complete DataDigitaloceanGradientaiAgent#upload_complete}
        /// </remarks>
        [JsiiProperty(name: "uploadComplete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UploadComplete
        {
            get
            {
                return null;
            }
        }

        /// <summary>URL of the Model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_agent#url DataDigitaloceanGradientaiAgent#url}
        /// </remarks>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Url
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of Usecases for the Model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_agent#usecases DataDigitaloceanGradientaiAgent#usecases}
        /// </remarks>
        [JsiiProperty(name: "usecases", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Usecases
        {
            get
            {
                return null;
            }
        }

        /// <summary>versions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_agent#versions DataDigitaloceanGradientaiAgent#versions}
        /// </remarks>
        [JsiiProperty(name: "versions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgent.DataDigitaloceanGradientaiAgentModelVersions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Versions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataDigitaloceanGradientaiAgentModel), fullyQualifiedName: "digitalocean.dataDigitaloceanGradientaiAgent.DataDigitaloceanGradientaiAgentModel")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DataDigitaloceanGradientaiAgent.IDataDigitaloceanGradientaiAgentModel
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>agreement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_agent#agreement DataDigitaloceanGradientaiAgent#agreement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "agreement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgent.DataDigitaloceanGradientaiAgentModelAgreement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Agreement
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Inference name of the model.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_agent#inference_name DataDigitaloceanGradientaiAgent#inference_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "inferenceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InferenceName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Infernce version of the model.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_agent#inference_version DataDigitaloceanGradientaiAgent#inference_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "inferenceVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InferenceVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Indicates if the Model Base is foundational.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_agent#is_foundational DataDigitaloceanGradientaiAgent#is_foundational}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isFoundational", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsFoundational
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Name of the Knowledge Base.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_agent#name DataDigitaloceanGradientaiAgent#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Parent UUID of the Model.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_agent#parent_uuid DataDigitaloceanGradientaiAgent#parent_uuid}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parentUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ParentUuid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Provider of the Model.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_agent#provider DataDigitaloceanGradientaiAgent#provider}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Provider
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Indicates if the Model upload is complete.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_agent#upload_complete DataDigitaloceanGradientaiAgent#upload_complete}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "uploadComplete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? UploadComplete
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>URL of the Model.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_agent#url DataDigitaloceanGradientaiAgent#url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Url
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>List of Usecases for the Model.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_agent#usecases DataDigitaloceanGradientaiAgent#usecases}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "usecases", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Usecases
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>versions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_agent#versions DataDigitaloceanGradientaiAgent#versions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "versions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgent.DataDigitaloceanGradientaiAgentModelVersions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Versions
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
