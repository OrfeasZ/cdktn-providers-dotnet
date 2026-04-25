using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkerVersion
{
    [JsiiInterface(nativeType: typeof(IWorkerVersionBindings), fullyQualifiedName: "cloudflare.workerVersion.WorkerVersionBindings")]
    public interface IWorkerVersionBindings
    {
        /// <summary>A JavaScript variable name for the binding.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#name WorkerVersion#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>The kind of resource that the binding provides.</summary>
        /// <remarks>
        /// Available values: "ai", "ai_search", "ai_search_namespace", "analytics_engine", "assets", "browser", "d1", "data_blob", "dispatch_namespace", "durable_object_namespace", "hyperdrive", "inherit", "images", "json", "kv_namespace", "media", "mtls_certificate", "plain_text", "pipelines", "queue", "ratelimit", "r2_bucket", "secret_text", "send_email", "service", "text_blob", "vectorize", "version_metadata", "secrets_store_secret", "flagship", "secret_key", "workflow", "wasm_module", "vpc_service", "vpc_network".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#type WorkerVersion#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Algorithm-specific key parameters. [Learn more](https://developer.mozilla.org/en-US/docs/Web/API/SubtleCrypto/importKey#algorithm).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#algorithm WorkerVersion#algorithm}
        /// </remarks>
        [JsiiProperty(name: "algorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Algorithm
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of allowed destination addresses.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#allowed_destination_addresses WorkerVersion#allowed_destination_addresses}
        /// </remarks>
        [JsiiProperty(name: "allowedDestinationAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedDestinationAddresses
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of allowed sender addresses.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#allowed_sender_addresses WorkerVersion#allowed_sender_addresses}
        /// </remarks>
        [JsiiProperty(name: "allowedSenderAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedSenderAddresses
        {
            get
            {
                return null;
            }
        }

        /// <summary>ID of the Flagship app to bind to for feature flag evaluation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#app_id WorkerVersion#app_id}
        /// </remarks>
        [JsiiProperty(name: "appId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AppId
        {
            get
            {
                return null;
            }
        }

        /// <summary>R2 bucket to bind to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#bucket_name WorkerVersion#bucket_name}
        /// </remarks>
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BucketName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Identifier of the certificate to bind to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#certificate_id WorkerVersion#certificate_id}
        /// </remarks>
        [JsiiProperty(name: "certificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The exported class name of the Durable Object.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#class_name WorkerVersion#class_name}
        /// </remarks>
        [JsiiProperty(name: "className", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClassName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Identifier of the D1 database to bind to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#database_id WorkerVersion#database_id}
        /// </remarks>
        [JsiiProperty(name: "databaseId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DatabaseId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The name of the dataset to bind to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#dataset WorkerVersion#dataset}
        /// </remarks>
        [JsiiProperty(name: "dataset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Dataset
        {
            get
            {
                return null;
            }
        }

        /// <summary>Destination address for the email.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#destination_address WorkerVersion#destination_address}
        /// </remarks>
        [JsiiProperty(name: "destinationAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DestinationAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>The dispatch namespace the Durable Object script belongs to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#dispatch_namespace WorkerVersion#dispatch_namespace}
        /// </remarks>
        [JsiiProperty(name: "dispatchNamespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DispatchNamespace
        {
            get
            {
                return null;
            }
        }

        /// <summary>Entrypoint to invoke on the target Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#entrypoint WorkerVersion#entrypoint}
        /// </remarks>
        [JsiiProperty(name: "entrypoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Entrypoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>The environment of the script_name to bind to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#environment WorkerVersion#environment}
        /// </remarks>
        [JsiiProperty(name: "environment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Environment
        {
            get
            {
                return null;
            }
        }

        /// <summary>Data format of the key. [Learn more](https://developer.mozilla.org/en-US/docs/Web/API/SubtleCrypto/importKey#format). Available values: "raw", "pkcs8", "spki", "jwk".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#format WorkerVersion#format}
        /// </remarks>
        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Format
        {
            get
            {
                return null;
            }
        }

        /// <summary>Identifier of the D1 database to bind to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#id WorkerVersion#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the Vectorize index to bind to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#index_name WorkerVersion#index_name}
        /// </remarks>
        [JsiiProperty(name: "indexName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IndexName
        {
            get
            {
                return null;
            }
        }

        /// <summary>The user-chosen instance name.</summary>
        /// <remarks>
        /// Must exist at deploy time. The worker can search, chat, update, and manage items/jobs on this instance.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#instance_name WorkerVersion#instance_name}
        /// </remarks>
        [JsiiProperty(name: "instanceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceName
        {
            get
            {
                return null;
            }
        }

        /// <summary>JSON data to use.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#json WorkerVersion#json}
        /// </remarks>
        [JsiiProperty(name: "json", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Json
        {
            get
            {
                return null;
            }
        }

        /// <summary>The [jurisdiction](https://developers.cloudflare.com/r2/reference/data-location/#jurisdictional-restrictions) of the R2 bucket. Available values: "eu", "fedramp", "fedramp-high".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#jurisdiction WorkerVersion#jurisdiction}
        /// </remarks>
        [JsiiProperty(name: "jurisdiction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Jurisdiction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Base64-encoded key data. Required if `format` is "raw", "pkcs8", or "spki".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#key_base64 WorkerVersion#key_base64}
        /// </remarks>
        [JsiiProperty(name: "keyBase64", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeyBase64
        {
            get
            {
                return null;
            }
        }

        /// <summary>Key data in [JSON Web Key](https://developer.mozilla.org/en-US/docs/Web/API/SubtleCrypto/importKey#json_web_key) format. Required if `format` is "jwk".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#key_jwk WorkerVersion#key_jwk}
        /// </remarks>
        [JsiiProperty(name: "keyJwk", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeyJwk
        {
            get
            {
                return null;
            }
        }

        /// <summary>The namespace the instance belongs to.</summary>
        /// <remarks>
        /// Defaults to "default" if omitted. Customers who don't use namespaces can simply omit this field.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#namespace WorkerVersion#namespace}
        /// </remarks>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Namespace
        {
            get
            {
                return null;
            }
        }

        /// <summary>Namespace identifier tag.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#namespace_id WorkerVersion#namespace_id}
        /// </remarks>
        [JsiiProperty(name: "namespaceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NamespaceId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Identifier of the network to bind to. Only "cf1:network" is currently supported. Mutually exclusive with tunnel_id.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#network_id WorkerVersion#network_id}
        /// </remarks>
        [JsiiProperty(name: "networkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NetworkId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The old name of the inherited binding.</summary>
        /// <remarks>
        /// If set, the binding will be renamed from <c>old_name</c> to <c>name</c> in the new version. If not set, the binding will keep the same name between versions.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#old_name WorkerVersion#old_name}
        /// </remarks>
        [JsiiProperty(name: "oldName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OldName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Outbound worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#outbound WorkerVersion#outbound}
        /// </remarks>
        [JsiiProperty(name: "outbound", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionBindingsOutbound\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.WorkerVersion.IWorkerVersionBindingsOutbound? Outbound
        {
            get
            {
                return null;
            }
        }

        /// <summary>The name of the file containing the data content. Only accepted for `service worker syntax` Workers.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#part WorkerVersion#part}
        /// </remarks>
        [JsiiProperty(name: "part", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Part
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the Pipeline to bind to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#pipeline WorkerVersion#pipeline}
        /// </remarks>
        [JsiiProperty(name: "pipeline", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Pipeline
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the Queue to bind to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#queue_name WorkerVersion#queue_name}
        /// </remarks>
        [JsiiProperty(name: "queueName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? QueueName
        {
            get
            {
                return null;
            }
        }

        /// <summary>The script where the Durable Object is defined, if it is external to this Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#script_name WorkerVersion#script_name}
        /// </remarks>
        [JsiiProperty(name: "scriptName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScriptName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the secret in the store.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#secret_name WorkerVersion#secret_name}
        /// </remarks>
        [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecretName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of Worker to bind to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#service WorkerVersion#service}
        /// </remarks>
        [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Service
        {
            get
            {
                return null;
            }
        }

        /// <summary>Identifier of the VPC service to bind to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#service_id WorkerVersion#service_id}
        /// </remarks>
        [JsiiProperty(name: "serviceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The rate limit configuration.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#simple WorkerVersion#simple}
        /// </remarks>
        [JsiiProperty(name: "simple", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionBindingsSimple\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.WorkerVersion.IWorkerVersionBindingsSimple? Simple
        {
            get
            {
                return null;
            }
        }

        /// <summary>ID of the store containing the secret.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#store_id WorkerVersion#store_id}
        /// </remarks>
        [JsiiProperty(name: "storeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StoreId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The text value to use.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#text WorkerVersion#text}
        /// </remarks>
        [JsiiProperty(name: "text", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Text
        {
            get
            {
                return null;
            }
        }

        /// <summary>UUID of the Cloudflare Tunnel to bind to. Mutually exclusive with network_id.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#tunnel_id WorkerVersion#tunnel_id}
        /// </remarks>
        [JsiiProperty(name: "tunnelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TunnelId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Allowed operations with the key. [Learn more](https://developer.mozilla.org/en-US/docs/Web/API/SubtleCrypto/importKey#keyUsages).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#usages WorkerVersion#usages}
        /// </remarks>
        [JsiiProperty(name: "usages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Usages
        {
            get
            {
                return null;
            }
        }

        /// <summary>Identifier for the version to inherit the binding from, which can be the version ID or the literal "latest" to inherit from the latest version.</summary>
        /// <remarks>
        /// Defaults to inheriting the binding from the latest version.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#version_id WorkerVersion#version_id}
        /// </remarks>
        [JsiiProperty(name: "versionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VersionId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the Workflow to bind to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#workflow_name WorkerVersion#workflow_name}
        /// </remarks>
        [JsiiProperty(name: "workflowName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WorkflowName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkerVersionBindings), fullyQualifiedName: "cloudflare.workerVersion.WorkerVersionBindings")]
        internal sealed class _Proxy : DeputyBase, cloudflare.WorkerVersion.IWorkerVersionBindings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A JavaScript variable name for the binding.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#name WorkerVersion#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The kind of resource that the binding provides.</summary>
            /// <remarks>
            /// Available values: "ai", "ai_search", "ai_search_namespace", "analytics_engine", "assets", "browser", "d1", "data_blob", "dispatch_namespace", "durable_object_namespace", "hyperdrive", "inherit", "images", "json", "kv_namespace", "media", "mtls_certificate", "plain_text", "pipelines", "queue", "ratelimit", "r2_bucket", "secret_text", "send_email", "service", "text_blob", "vectorize", "version_metadata", "secrets_store_secret", "flagship", "secret_key", "workflow", "wasm_module", "vpc_service", "vpc_network".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#type WorkerVersion#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Algorithm-specific key parameters. [Learn more](https://developer.mozilla.org/en-US/docs/Web/API/SubtleCrypto/importKey#algorithm).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#algorithm WorkerVersion#algorithm}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "algorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Algorithm
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>List of allowed destination addresses.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#allowed_destination_addresses WorkerVersion#allowed_destination_addresses}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowedDestinationAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedDestinationAddresses
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>List of allowed sender addresses.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#allowed_sender_addresses WorkerVersion#allowed_sender_addresses}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowedSenderAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedSenderAddresses
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>ID of the Flagship app to bind to for feature flag evaluation.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#app_id WorkerVersion#app_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "appId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AppId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>R2 bucket to bind to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#bucket_name WorkerVersion#bucket_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BucketName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Identifier of the certificate to bind to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#certificate_id WorkerVersion#certificate_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "certificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The exported class name of the Durable Object.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#class_name WorkerVersion#class_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "className", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClassName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Identifier of the D1 database to bind to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#database_id WorkerVersion#database_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "databaseId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DatabaseId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The name of the dataset to bind to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#dataset WorkerVersion#dataset}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Dataset
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Destination address for the email.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#destination_address WorkerVersion#destination_address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "destinationAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DestinationAddress
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The dispatch namespace the Durable Object script belongs to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#dispatch_namespace WorkerVersion#dispatch_namespace}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dispatchNamespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DispatchNamespace
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Entrypoint to invoke on the target Worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#entrypoint WorkerVersion#entrypoint}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "entrypoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Entrypoint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The environment of the script_name to bind to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#environment WorkerVersion#environment}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "environment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Environment
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Data format of the key. [Learn more](https://developer.mozilla.org/en-US/docs/Web/API/SubtleCrypto/importKey#format). Available values: "raw", "pkcs8", "spki", "jwk".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#format WorkerVersion#format}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Format
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Identifier of the D1 database to bind to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#id WorkerVersion#id}
            ///
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Name of the Vectorize index to bind to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#index_name WorkerVersion#index_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "indexName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IndexName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The user-chosen instance name.</summary>
            /// <remarks>
            /// Must exist at deploy time. The worker can search, chat, update, and manage items/jobs on this instance.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#instance_name WorkerVersion#instance_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "instanceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>JSON data to use.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#json WorkerVersion#json}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "json", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Json
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The [jurisdiction](https://developers.cloudflare.com/r2/reference/data-location/#jurisdictional-restrictions) of the R2 bucket. Available values: "eu", "fedramp", "fedramp-high".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#jurisdiction WorkerVersion#jurisdiction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jurisdiction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Jurisdiction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Base64-encoded key data. Required if `format` is "raw", "pkcs8", or "spki".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#key_base64 WorkerVersion#key_base64}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keyBase64", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeyBase64
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Key data in [JSON Web Key](https://developer.mozilla.org/en-US/docs/Web/API/SubtleCrypto/importKey#json_web_key) format. Required if `format` is "jwk".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#key_jwk WorkerVersion#key_jwk}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keyJwk", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeyJwk
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The namespace the instance belongs to.</summary>
            /// <remarks>
            /// Defaults to "default" if omitted. Customers who don't use namespaces can simply omit this field.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#namespace WorkerVersion#namespace}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Namespace
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Namespace identifier tag.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#namespace_id WorkerVersion#namespace_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "namespaceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NamespaceId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Identifier of the network to bind to. Only "cf1:network" is currently supported. Mutually exclusive with tunnel_id.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#network_id WorkerVersion#network_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NetworkId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The old name of the inherited binding.</summary>
            /// <remarks>
            /// If set, the binding will be renamed from <c>old_name</c> to <c>name</c> in the new version. If not set, the binding will keep the same name between versions.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#old_name WorkerVersion#old_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oldName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OldName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Outbound worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#outbound WorkerVersion#outbound}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "outbound", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionBindingsOutbound\"}", isOptional: true)]
            public cloudflare.WorkerVersion.IWorkerVersionBindingsOutbound? Outbound
            {
                get => GetInstanceProperty<cloudflare.WorkerVersion.IWorkerVersionBindingsOutbound?>();
            }

            /// <summary>The name of the file containing the data content. Only accepted for `service worker syntax` Workers.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#part WorkerVersion#part}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "part", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Part
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Name of the Pipeline to bind to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#pipeline WorkerVersion#pipeline}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pipeline", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Pipeline
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Name of the Queue to bind to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#queue_name WorkerVersion#queue_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queueName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? QueueName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The script where the Durable Object is defined, if it is external to this Worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#script_name WorkerVersion#script_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scriptName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScriptName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Name of the secret in the store.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#secret_name WorkerVersion#secret_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecretName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Name of Worker to bind to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#service WorkerVersion#service}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Service
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Identifier of the VPC service to bind to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#service_id WorkerVersion#service_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serviceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The rate limit configuration.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#simple WorkerVersion#simple}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "simple", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionBindingsSimple\"}", isOptional: true)]
            public cloudflare.WorkerVersion.IWorkerVersionBindingsSimple? Simple
            {
                get => GetInstanceProperty<cloudflare.WorkerVersion.IWorkerVersionBindingsSimple?>();
            }

            /// <summary>ID of the store containing the secret.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#store_id WorkerVersion#store_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StoreId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The text value to use.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#text WorkerVersion#text}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "text", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Text
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>UUID of the Cloudflare Tunnel to bind to. Mutually exclusive with network_id.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#tunnel_id WorkerVersion#tunnel_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tunnelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TunnelId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Allowed operations with the key. [Learn more](https://developer.mozilla.org/en-US/docs/Web/API/SubtleCrypto/importKey#keyUsages).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#usages WorkerVersion#usages}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "usages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Usages
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Identifier for the version to inherit the binding from, which can be the version ID or the literal "latest" to inherit from the latest version.</summary>
            /// <remarks>
            /// Defaults to inheriting the binding from the latest version.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#version_id WorkerVersion#version_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "versionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VersionId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Name of the Workflow to bind to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#workflow_name WorkerVersion#workflow_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "workflowName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WorkflowName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
