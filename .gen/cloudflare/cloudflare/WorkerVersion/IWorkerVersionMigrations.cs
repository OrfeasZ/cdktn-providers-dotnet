using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkerVersion
{
    [JsiiInterface(nativeType: typeof(IWorkerVersionMigrations), fullyQualifiedName: "cloudflare.workerVersion.WorkerVersionMigrations")]
    public interface IWorkerVersionMigrations
    {
        /// <summary>A list of classes to delete Durable Object namespaces from.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#deleted_classes WorkerVersion#deleted_classes}
        /// </remarks>
        [JsiiProperty(name: "deletedClasses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DeletedClasses
        {
            get
            {
                return null;
            }
        }

        /// <summary>A list of classes to create Durable Object namespaces from.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#new_classes WorkerVersion#new_classes}
        /// </remarks>
        [JsiiProperty(name: "newClasses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? NewClasses
        {
            get
            {
                return null;
            }
        }

        /// <summary>A list of classes to create Durable Object namespaces with SQLite from.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#new_sqlite_classes WorkerVersion#new_sqlite_classes}
        /// </remarks>
        [JsiiProperty(name: "newSqliteClasses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? NewSqliteClasses
        {
            get
            {
                return null;
            }
        }

        /// <summary>Tag to set as the latest migration tag.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#new_tag WorkerVersion#new_tag}
        /// </remarks>
        [JsiiProperty(name: "newTag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NewTag
        {
            get
            {
                return null;
            }
        }

        /// <summary>Tag used to verify against the latest migration tag for this Worker.</summary>
        /// <remarks>
        /// If they don't match, the upload is rejected.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#old_tag WorkerVersion#old_tag}
        /// </remarks>
        [JsiiProperty(name: "oldTag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OldTag
        {
            get
            {
                return null;
            }
        }

        /// <summary>A list of classes with Durable Object namespaces that were renamed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#renamed_classes WorkerVersion#renamed_classes}
        /// </remarks>
        [JsiiProperty(name: "renamedClasses", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.workerVersion.WorkerVersionMigrationsRenamedClasses\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RenamedClasses
        {
            get
            {
                return null;
            }
        }

        /// <summary>Migrations to apply in order.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#steps WorkerVersion#steps}
        /// </remarks>
        [JsiiProperty(name: "steps", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.workerVersion.WorkerVersionMigrationsSteps\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Steps
        {
            get
            {
                return null;
            }
        }

        /// <summary>A list of transfers for Durable Object namespaces from a different Worker and class to a class defined in this Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#transferred_classes WorkerVersion#transferred_classes}
        /// </remarks>
        [JsiiProperty(name: "transferredClasses", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.workerVersion.WorkerVersionMigrationsTransferredClasses\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TransferredClasses
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkerVersionMigrations), fullyQualifiedName: "cloudflare.workerVersion.WorkerVersionMigrations")]
        internal sealed class _Proxy : DeputyBase, cloudflare.WorkerVersion.IWorkerVersionMigrations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A list of classes to delete Durable Object namespaces from.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#deleted_classes WorkerVersion#deleted_classes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deletedClasses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DeletedClasses
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>A list of classes to create Durable Object namespaces from.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#new_classes WorkerVersion#new_classes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "newClasses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? NewClasses
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>A list of classes to create Durable Object namespaces with SQLite from.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#new_sqlite_classes WorkerVersion#new_sqlite_classes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "newSqliteClasses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? NewSqliteClasses
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Tag to set as the latest migration tag.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#new_tag WorkerVersion#new_tag}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "newTag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NewTag
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Tag used to verify against the latest migration tag for this Worker.</summary>
            /// <remarks>
            /// If they don't match, the upload is rejected.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#old_tag WorkerVersion#old_tag}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oldTag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OldTag
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A list of classes with Durable Object namespaces that were renamed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#renamed_classes WorkerVersion#renamed_classes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "renamedClasses", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.workerVersion.WorkerVersionMigrationsRenamedClasses\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RenamedClasses
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Migrations to apply in order.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#steps WorkerVersion#steps}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "steps", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.workerVersion.WorkerVersionMigrationsSteps\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Steps
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>A list of transfers for Durable Object namespaces from a different Worker and class to a class defined in this Worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/worker_version#transferred_classes WorkerVersion#transferred_classes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "transferredClasses", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.workerVersion.WorkerVersionMigrationsTransferredClasses\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TransferredClasses
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
