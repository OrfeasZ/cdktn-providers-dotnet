using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkerVersion
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.workerVersion.WorkerVersionBindings")]
    public class WorkerVersionBindings : cloudflare.WorkerVersion.IWorkerVersionBindings
    {
        /// <summary>For `type: ai` or `type: ai_search` or `type: ai_search_namespace` or `type: messaging` or `type: analytics_engine` or `type: artifacts` or `type: assets` or `type: browser` or `type: d1` or `type: data_blob` or `type: dispatch_namespace` or `type: durable_object_namespace` or `type: hyperdrive` or `type: images` or `type: json` or `type: kv_namespace` or `type: media` or `type: mtls_certificate` or `type: plain_text` or `type: pipelines` or `type: k2` or `type: queue` or `type: ratelimit` or `type: r2_bucket` or `type: secret_text` or `type: send_email` or `type: service` or `type: text_blob` or `type: vectorize` or `type: version_metadata` or `type: secrets_store_secret` or `type: flagship` or `type: secret_key` or `type: workflow` or `type: wasm_module` or `type: vpc_service` or `type: vpc_network` or `type: worker_loader`: A JavaScript variable name for the binding.</summary>
        /// <remarks>
        /// For <c>type: inherit</c>: The name of the inherited binding.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#name WorkerVersion#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>The kind of resource that the binding provides.</summary>
        /// <remarks>
        /// Available values: "ai", "ai_search", "ai_search_namespace", "messaging", "analytics_engine", "artifacts", "assets", "browser", "d1", "data_blob", "dispatch_namespace", "durable_object_namespace", "hyperdrive", "inherit", "images", "json", "kv_namespace", "media", "mtls_certificate", "plain_text", "pipelines", "k2", "queue", "ratelimit", "r2_bucket", "secret_text", "send_email", "service", "text_blob", "vectorize", "version_metadata", "secrets_store_secret", "flagship", "secret_key", "workflow", "wasm_module", "vpc_service", "vpc_network", "worker_loader".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#type WorkerVersion#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>For `type: secret_key`: Algorithm-specific key parameters. [Learn more](https://developer.mozilla.org/en-US/docs/Web/API/SubtleCrypto/importKey#algorithm).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#algorithm WorkerVersion#algorithm}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "algorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Algorithm
        {
            get;
            set;
        }

        /// <summary>For `type: send_email`: List of allowed destination addresses.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#allowed_destination_addresses WorkerVersion#allowed_destination_addresses}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowedDestinationAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowedDestinationAddresses
        {
            get;
            set;
        }

        /// <summary>For `type: send_email`: List of allowed sender addresses.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#allowed_sender_addresses WorkerVersion#allowed_sender_addresses}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowedSenderAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowedSenderAddresses
        {
            get;
            set;
        }

        /// <summary>For `type: flagship`: ID of the Flagship app to bind to for feature flag evaluation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#app_id WorkerVersion#app_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "appId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AppId
        {
            get;
            set;
        }

        /// <summary>For `type: r2_bucket`: R2 bucket to bind to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#bucket_name WorkerVersion#bucket_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BucketName
        {
            get;
            set;
        }

        /// <summary>For `type: mtls_certificate`: Identifier of the certificate to bind to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#certificate_id WorkerVersion#certificate_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "certificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateId
        {
            get;
            set;
        }

        /// <summary>For `type: durable_object_namespace`: The exported class name of the Durable Object.</summary>
        /// <remarks>
        /// For <c>type: workflow</c>: Class name of the Workflow. Should only be provided if the Workflow belongs to this script.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#class_name WorkerVersion#class_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "className", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClassName
        {
            get;
            set;
        }

        /// <summary>For `type: d1`: Identifier of the D1 database to bind to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#database_id WorkerVersion#database_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "databaseId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DatabaseId
        {
            get;
            set;
        }

        /// <summary>For `type: analytics_engine`: The name of the dataset to bind to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#dataset WorkerVersion#dataset}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Dataset
        {
            get;
            set;
        }

        /// <summary>For `type: send_email`: Destination address for the email.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#destination_address WorkerVersion#destination_address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "destinationAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationAddress
        {
            get;
            set;
        }

        /// <summary>For `type: durable_object_namespace`: The dispatch namespace the Durable Object script belongs to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#dispatch_namespace WorkerVersion#dispatch_namespace}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dispatchNamespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DispatchNamespace
        {
            get;
            set;
        }

        /// <summary>For `type: service`: Entrypoint to invoke on the target Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#entrypoint WorkerVersion#entrypoint}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "entrypoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Entrypoint
        {
            get;
            set;
        }

        /// <summary>For `type: durable_object_namespace`: The environment of the script_name to bind to.</summary>
        /// <remarks>
        /// For <c>type: service</c>: Optional environment if the Worker utilizes one.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#environment WorkerVersion#environment}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "environment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Environment
        {
            get;
            set;
        }

        /// <summary>For `type: secret_key`: Data format of the key. [Learn more](https://developer.mozilla.org/en-US/docs/Web/API/SubtleCrypto/importKey#format). Available values: "raw", "pkcs8", "spki", "jwk".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#format WorkerVersion#format}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Format
        {
            get;
            set;
        }

        /// <summary>For `type: d1`: Identifier of the D1 database to bind to.</summary>
        /// <remarks>
        /// For <c>type: hyperdrive</c>: Identifier of the Hyperdrive connection to bind to.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#id WorkerVersion#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <summary>For `type: vpc_network`: Enables Gateway identity for the binding.</summary>
        /// <remarks>
        /// Requires network_id to be "cf1:network" and cannot be combined with tunnel_id or an explicit "cf1:vnet:&lt;UUID&gt;" network_id.
        /// Available values: "runtime-email-alpha".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#identity WorkerVersion#identity}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "identity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Identity
        {
            get;
            set;
        }

        /// <summary>For `type: vectorize`: Name of the Vectorize index to bind to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#index_name WorkerVersion#index_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "indexName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IndexName
        {
            get;
            set;
        }

        /// <summary>For `type: ai_search`: The user-chosen instance name.</summary>
        /// <remarks>
        /// Must exist at deploy time. The worker can search, chat, update, and manage items/jobs on this instance.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#instance_name WorkerVersion#instance_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "instanceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InstanceName
        {
            get;
            set;
        }

        /// <summary>For `type: json`: JSON data to use.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#json WorkerVersion#json}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "json", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Json
        {
            get;
            set;
        }

        /// <summary>For `type: r2_bucket`: The [jurisdiction](https://developers.cloudflare.com/r2/reference/data-location/#jurisdictional-restrictions) of the R2 bucket. Available values: "eu", "fedramp", "fedramp-high", "us".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#jurisdiction WorkerVersion#jurisdiction}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jurisdiction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Jurisdiction
        {
            get;
            set;
        }

        /// <summary>For `type: secret_key`: Base64-encoded key data. Required if `format` is "raw", "pkcs8", or "spki".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#key_base64 WorkerVersion#key_base64}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keyBase64", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyBase64
        {
            get;
            set;
        }

        /// <summary>For `type: secret_key`: Key data in [JSON Web Key](https://developer.mozilla.org/en-US/docs/Web/API/SubtleCrypto/importKey#json_web_key) format. Required if `format` is "jwk".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#key_jwk WorkerVersion#key_jwk}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keyJwk", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyJwk
        {
            get;
            set;
        }

        /// <summary>For `type: ai_search`: The namespace the instance belongs to.</summary>
        /// <remarks>
        /// Defaults to "default" if omitted. Customers who don't use namespaces can simply omit this field.
        ///
        /// For <c>type: ai_search_namespace</c>: The user-chosen namespace name. Must exist before deploy -- Wrangler handles auto-creation on deploy failure (R2 bucket pattern). The "default" namespace is auto-created by config-api for new accounts. Grants full access (CRUD + search + chat) to all instances within the namespace.
        ///
        /// For <c>type: messaging</c>: The Messaging namespace to bind to.
        ///
        /// For <c>type: artifacts</c>: The Artifacts namespace exposed to the Worker in the Worker's account. Must be 2-63 characters, start with an ASCII alphanumeric character, contain only ASCII alphanumeric characters, dots, underscores, and hyphens, and must not end with a hyphen. The namespace does not need to be created before binding it.
        ///
        /// For <c>type: dispatch_namespace</c>: The name of the dispatch namespace.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#namespace WorkerVersion#namespace}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Namespace
        {
            get;
            set;
        }

        /// <summary>For `type: durable_object_namespace` or `type: kv_namespace`: Namespace identifier tag.</summary>
        /// <remarks>
        /// For <c>type: ratelimit</c>: Identifier of the rate limit namespace to bind to.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#namespace_id WorkerVersion#namespace_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "namespaceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NamespaceId
        {
            get;
            set;
        }

        /// <summary>For `type: vpc_network`: Identifier of the network to bind to.</summary>
        /// <remarks>
        /// Use "cf1:network" to select the account's default virtual network at runtime, or "cf1:vnet:&lt;UUID&gt;" to select an explicit virtual network in the Worker's account. Mutually exclusive with tunnel_id.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#network_id WorkerVersion#network_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NetworkId
        {
            get;
            set;
        }

        /// <summary>For `type: inherit`: The old name of the inherited binding.</summary>
        /// <remarks>
        /// If set, the binding will be renamed from <c>old_name</c> to <c>name</c> in the new version. If not set, the binding will keep the same name between versions.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#old_name WorkerVersion#old_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oldName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OldName
        {
            get;
            set;
        }

        /// <summary>For `type: dispatch_namespace`: Outbound worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#outbound WorkerVersion#outbound}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "outbound", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionBindingsOutbound\"}", isOptional: true)]
        public cloudflare.WorkerVersion.IWorkerVersionBindingsOutbound? Outbound
        {
            get;
            set;
        }

        /// <summary>For `type: data_blob`: The name of the file containing the data content. Only accepted for `service worker syntax` Workers.</summary>
        /// <remarks>
        /// For <c>type: text_blob</c>: The name of the file containing the text content. Only accepted for <c>service worker syntax</c> Workers.
        ///
        /// For <c>type: wasm_module</c>: The name of the file containing the WebAssembly module content. Only accepted for <c>service worker syntax</c> Workers.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#part WorkerVersion#part}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "part", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Part
        {
            get;
            set;
        }

        /// <summary>For `type: pipelines`: Name of the Pipeline to bind to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#pipeline WorkerVersion#pipeline}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pipeline", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Pipeline
        {
            get;
            set;
        }

        /// <summary>For `type: queue`: Name of the Queue to bind to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#queue_name WorkerVersion#queue_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queueName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? QueueName
        {
            get;
            set;
        }

        /// <summary>For `type: durable_object_namespace`: The script where the Durable Object is defined, if it is external to this Worker.</summary>
        /// <remarks>
        /// For <c>type: workflow</c>: Script name that contains the Workflow. If not provided, defaults to this script name.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#script_name WorkerVersion#script_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scriptName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScriptName
        {
            get;
            set;
        }

        /// <summary>For `type: secrets_store_secret`: Name of the secret in the store.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#secret_name WorkerVersion#secret_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretName
        {
            get;
            set;
        }

        /// <summary>For `type: service`: Name of Worker to bind to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#service WorkerVersion#service}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Service
        {
            get;
            set;
        }

        /// <summary>For `type: vpc_service`: Identifier of the VPC service to bind to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#service_id WorkerVersion#service_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serviceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServiceId
        {
            get;
            set;
        }

        /// <summary>For `type: ratelimit`: The rate limit configuration.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#simple WorkerVersion#simple}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "simple", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionBindingsSimple\"}", isOptional: true)]
        public cloudflare.WorkerVersion.IWorkerVersionBindingsSimple? Simple
        {
            get;
            set;
        }

        /// <summary>For `type: secrets_store_secret`: ID of the store containing the secret.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#store_id WorkerVersion#store_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "storeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StoreId
        {
            get;
            set;
        }

        /// <summary>For `type: k2`: ID of a K2 stream owned by the account deploying the Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#stream WorkerVersion#stream}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stream", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Stream
        {
            get;
            set;
        }

        /// <summary>For `type: plain_text`: The text value to use.</summary>
        /// <remarks>
        /// For <c>type: secret_text</c>: The secret value to use.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#text WorkerVersion#text}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "text", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Text
        {
            get;
            set;
        }

        /// <summary>For `type: vpc_network`: UUID of the Cloudflare Tunnel to bind to. Mutually exclusive with network_id.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#tunnel_id WorkerVersion#tunnel_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tunnelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TunnelId
        {
            get;
            set;
        }

        /// <summary>For `type: secret_key`: Allowed operations with the key. [Learn more](https://developer.mozilla.org/en-US/docs/Web/API/SubtleCrypto/importKey#keyUsages).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#usages WorkerVersion#usages}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "usages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Usages
        {
            get;
            set;
        }

        /// <summary>For `type: inherit`: Identifier for the version to inherit the binding from.</summary>
        /// <remarks>
        /// This can be a version ID, or the literal "latest" to inherit from the most recently uploaded version, which may not be the deployed version. Defaults to "latest". Only the Workers API version endpoints under <c>/accounts/{account_id}/workers/workers/{worker_id}/versions</c> accept a version ID. Other endpoints, including script upload and script version upload, accept only "latest" and reject a version ID with error 10057.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#version_id WorkerVersion#version_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "versionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VersionId
        {
            get;
            set;
        }

        /// <summary>For `type: workflow`: Name of the Workflow to bind to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/worker_version#workflow_name WorkerVersion#workflow_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "workflowName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WorkflowName
        {
            get;
            set;
        }
    }
}
