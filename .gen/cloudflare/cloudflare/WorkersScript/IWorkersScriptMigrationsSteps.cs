using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersScript
{
    [JsiiInterface(nativeType: typeof(IWorkersScriptMigrationsSteps), fullyQualifiedName: "cloudflare.workersScript.WorkersScriptMigrationsSteps")]
    public interface IWorkersScriptMigrationsSteps
    {
        /// <summary>A list of classes to delete Durable Object namespaces from.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#deleted_classes WorkersScript#deleted_classes}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#new_classes WorkersScript#new_classes}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#new_sqlite_classes WorkersScript#new_sqlite_classes}
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

        /// <summary>A list of classes with Durable Object namespaces that were renamed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#renamed_classes WorkersScript#renamed_classes}
        /// </remarks>
        [JsiiProperty(name: "renamedClasses", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.workersScript.WorkersScriptMigrationsStepsRenamedClasses\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RenamedClasses
        {
            get
            {
                return null;
            }
        }

        /// <summary>A list of transfers for Durable Object namespaces from a different Worker and class to a class defined in this Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#transferred_classes WorkersScript#transferred_classes}
        /// </remarks>
        [JsiiProperty(name: "transferredClasses", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.workersScript.WorkersScriptMigrationsStepsTransferredClasses\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TransferredClasses
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkersScriptMigrationsSteps), fullyQualifiedName: "cloudflare.workersScript.WorkersScriptMigrationsSteps")]
        internal sealed class _Proxy : DeputyBase, cloudflare.WorkersScript.IWorkersScriptMigrationsSteps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A list of classes to delete Durable Object namespaces from.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#deleted_classes WorkersScript#deleted_classes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deletedClasses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DeletedClasses
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>A list of classes to create Durable Object namespaces from.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#new_classes WorkersScript#new_classes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "newClasses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? NewClasses
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>A list of classes to create Durable Object namespaces with SQLite from.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#new_sqlite_classes WorkersScript#new_sqlite_classes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "newSqliteClasses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? NewSqliteClasses
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>A list of classes with Durable Object namespaces that were renamed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#renamed_classes WorkersScript#renamed_classes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "renamedClasses", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.workersScript.WorkersScriptMigrationsStepsRenamedClasses\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RenamedClasses
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>A list of transfers for Durable Object namespaces from a different Worker and class to a class defined in this Worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#transferred_classes WorkersScript#transferred_classes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "transferredClasses", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.workersScript.WorkersScriptMigrationsStepsTransferredClasses\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TransferredClasses
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
